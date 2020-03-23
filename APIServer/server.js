const express = require('express')
const sqliteJson = require('sqlite-json')
const md5 = require('js-md5');
const crypto = require('crypto')

const app = express()
const port = 80

const db = sqliteJson('DryCleaning.db3');

app.listen(port,
    (err) => {
        if (err) {
            return console.log('Error start server', err)
        }
        console.log(`Server is listening on ${port}`)
    })


app.post('/authorization', function (request, response) {
    var passportid = request.query.passportid
    var password = request.query.password

    if (passportid == null || password == null) {
        response.status(401).json({ message: '401 Unauthorized' })
    }
    else {
        var passwordMD5 = md5(password)

        db.json(`SELECT * FROM Employee WHERE PassportID = '${passportid}' AND Password = '${passwordMD5}'`, function (err, jsonString) {
            var json = JSON.parse(jsonString)
            if (json.length == 1) {
                var token = crypto.randomBytes(16).toString('hex');
                db.json(`DELETE FROM Token WHERE Employee = '${passportid}'`, function (err, jsonString) {
                    db.json(`INSERT INTO Token VALUES(${passportid}, '${md5(token)}')`, function (err, jsonString) {
                        response.status(200).json({ token: token })
                    });
                });
            }
            else {
                console.log(`Authorisation error for passport '${passportid}'`);
                response.status(401).json({ message: '401 Unauthorized' })
            }
        });
    }
})

app.use((request, response, next) => {
    var token = request.headers.token

    if (token == null) {
        response.status(401).json({ message: '401 Unauthorized' })
    }
    else {
        db.json(`SELECT * FROM Token, Employee WHERE Token.Employee = Employee.PassportID AND Token.Token = '${md5(token)}'`, function (err, jsonString) {
            var json = JSON.parse(jsonString)
            if (json.length == 1) {
                console.log(`Incoming request from '${json[0].Name}'`)
                // only authorization success next methods
                response.locals.passportid = json[0].Employee
                next()
            }
            else {
                response.status(401).json({ message: '401 Unauthorized' })
            }
        });
    }
})

app.get('/user', function (request, response) {
    db.json(`SELECT PassportID, Name, Role, IsAdmin FROM Employee WHERE PassportID = '${response.locals.passportid}'`, function (err, jsonString) {
        response.json(JSON.parse(jsonString)[0])
    });
});

app.put('/user', function (request, response) {
    var newPassportID = request.query.newPassportID == null ? "null" : `"${request.query.newPassportID}"`
    var newName = request.query.newName == null ? "null" : `"${request.query.newName}"`
    var newPassword = request.query.newPassword == null ? "null" : `"${md5(request.query.newPassword)}"`

    db.json(`UPDATE Employee
        SET
        PassportID = coalesce(${newPassportID}, PassportID),
        Name = coalesce(${newName}, Name),
        Password = coalesce(${newPassword}, Password)
        WHERE PassportID = '${response.locals.passportid}'`,
    function(err){
        if (err){
            response.status(500).json({ message: err.message })
        }
        else{
            db.json(`SELECT PassportID, Name, Role, IsAdmin FROM Employee WHERE PassportID = '${response.locals.passportid}'`, function (err, jsonString) {
                response.json(JSON.parse(jsonString)[0])
            });
        }
    });
});

app.post('/users', function (request, response) {
    db.json(`SELECT IsAdmin FROM Employee WHERE PassportID = '${response.locals.passportid}'`, function (err, jsonString) {
        var user = JSON.parse(jsonString)[0]
        if(user.IsAdmin)
        {
            if(request.query.newPassportID == null ||
                request.query.name == null ||
                request.query.role == null ||
                request.query.newPassword == null){
                    response.status(400).json({ message: "400 Bad Request" })
            }
            else{
                var isAdmin = request.query.isAdmin == null ? false : request.query.isAdmin
                db.json(`INSERT INTO Employee VALUES(
                    "${request.query.newPassportID}",
                    "${request.query.name}",
                    "${request.query.role}",
                    "${md5(request.query.newPassword)}",
                    ${isAdmin});`, function (err, jsonString) {
                        if (err){
                            response.status(500).json({ message: err.message })
                        }
                        else{
                            response.status(200).json({ message: "OK" })
                        }
                });
            }
        }
        else{
            response.status(403).json({ message: "403 Forbidden" })
        }
    });
});

app.delete('/users/:passportid', function (request, response) {
    db.json(`SELECT IsAdmin FROM Employee WHERE PassportID = '${response.locals.passportid}'`, function (err, jsonString) {
        var user = JSON.parse(jsonString)[0]
        if(user.IsAdmin || response.locals.passportid == request.params.passportid)
        {
            db.json(`DELETE FROM Employee WHERE PassportID = '${request.params.passportid}'`, function (err, jsonString) {
                if (err)
                {
                    response.status(500).json({ message: err.message })
                }
                else
                {
                    response.status(200).json({ message: "OK" })
                }
            });
        }
        else
        {
            response.status(403).json({ message: "403 Forbidden" })
        }
    });
});

app.put('/users/:passportid', function (request, response) {
    db.json(`SELECT IsAdmin FROM Employee WHERE PassportID = '${response.locals.passportid}'`, function (err, jsonString) {
        var user = JSON.parse(jsonString)[0]
        
        var newPassportID = request.query.newPassportID == null || request.query.newPassportID == '' ? "null" : `"${request.query.newPassportID}"`
        var newName = request.query.newName == null || request.query.newName == '' ? "null" : `"${request.query.newName}"`
        var newPassword = request.query.newPassword == null || request.query.newPassword == '' ? "null" : `"${md5(request.query.newPassword)}"`

        var newRole = "null" //only for admin
        var newIsAdmin = "null" //only for admin

        if(user.IsAdmin)
        {
            var newRole = request.query.newRole == null || request.query.newRole == '' ? "null" : `"${request.query.newRole}"`
            var newIsAdmin = request.query.newIsAdmin == null || request.query.newIsAdmin == '' ? "null" : (request.query.newIsAdmin.toLowerCase() === 'true')
        }

        if(!user.IsAdmin && request.params.passportid != response.locals.passportid) //query passport != current passport
        {
            response.status(403).json({ message: "Запрещено изменение не своего пользователя" })
        }
        else
        {
            var sqlQuery = `UPDATE Employee
                            SET
                            PassportID = coalesce(${newPassportID}, PassportID),
                            Name = coalesce(${newName}, Name),
                            Password = coalesce(${newPassword}, Password),
                            Role = coalesce(${newRole}, Role),
                            IsAdmin = coalesce(${newIsAdmin}, IsAdmin)
                            WHERE PassportID = '${request.params.passportid}'`
            db.json(sqlQuery,
                function(err){
                    if (err){
                        response.status(500).json({ message: err.message })
                    }
                    else{
                        db.json(`SELECT PassportID, Name, Role, IsAdmin FROM Employee WHERE PassportID = '${request.params.passportid}'`, function (err, jsonString) {
                            response.json(JSON.parse(jsonString)[0])
                        });
                    }
                });
        }
    });
});

app.get('/users', function (request, response) {
    db.json(`SELECT PassportID, Name, Role, IsAdmin FROM Employee`, function (err, jsonString) {
        response.json(JSON.parse(jsonString))
    });
});

app.get('/users/:passportid', function (request, response) {
    db.json(`SELECT PassportID, Name, Role, IsAdmin FROM Employee WHERE PassportID = '${request.params.passportid}'`, function (err, jsonString) {
        response.json(JSON.parse(jsonString)[0])
    });
});

app.get('/materials', function (request, response) {
    db.json(`SELECT Name FROM Material`, function (err, jsonString) {
        response.json(JSON.parse(jsonString))
    });
});

app.post('/materials', function (request, response) {
    if(request.query.name == null){
            response.status(400).json({ message: "400 Bad Request" })
    }
    else{
        db.json(`INSERT INTO Material VALUES(
            "${request.query.name}");`, function (err, jsonString) {
                if (err){
                    response.status(500).json({ message: err.message })
                }
                else{
                    response.status(200).json({ message: "OK" })
                }
        });
    }
});

app.get('/chemicalagents', function (request, response) {
    db.json(`SELECT Name FROM ChemicalAgent`, function (err, jsonString) {
        response.json(JSON.parse(jsonString))
    });
});

app.post('/chemicalagents', function (request, response) {
    if(request.query.name == null){
            response.status(400).json({ message: "400 Bad Request" })
    }
    else{
        db.json(`INSERT INTO ChemicalAgent VALUES(
            "${request.query.name}");`, function (err, jsonString) {
                if (err){
                    response.status(500).json({ message: err.message })
                }
                else{
                    response.status(200).json({ message: "OK" })
                }
        });
    }
});

app.get('/clients', function (request, response) {
    db.json(`SELECT * FROM Client`, function (err, jsonString) {
        response.json(JSON.parse(jsonString))
    });
});

app.post('/clients', function (request, response) {
    if(request.query.name == null ||
        request.query.telephone == null){
            response.status(400).json({ message: "400 Bad Request" })
    }
    else{
        db.json(`INSERT INTO Client (Name, Telephone) VALUES(
            "${request.query.name}",
            "${request.query.telephone}");`, function (err, jsonString) {
                if (err){
                    response.status(500).json({ message: err.message })
                }
                else{
                    response.status(200).json({ message: "OK" })
                }
        });
    }
});

app.get('/clients/:id', function (request, response) {
    db.json(`SELECT * FROM Client WHERE ID = '${request.params.id}'`, function (err, jsonString) {
        response.json(JSON.parse(jsonString)[0])
    });
});

app.get('/results', function (request, response) {
    db.json(`SELECT * FROM Result`, function (err, jsonString) {
        response.json(JSON.parse(jsonString))
    });
});

app.get('/roles', function (request, response) {
    db.json(`SELECT IsAdmin FROM Employee WHERE PassportID = '${response.locals.passportid}'`, function (err, jsonString) {
        var user = JSON.parse(jsonString)[0]
        var query = ``
        if(user.IsAdmin)
        {
            query = `SELECT Name, Salary FROM Role`
        }
        else{
            query = `SELECT Name, null FROM Role`
        }
        db.json(query, function (err, jsonString) {
            response.json(JSON.parse(jsonString))
        });
    });
});

app.post('/roles', function (request, response) {
    db.json(`SELECT IsAdmin FROM Employee WHERE PassportID = '${response.locals.passportid}'`, function (err, jsonString) {
        var user = JSON.parse(jsonString)[0]
        if(user.IsAdmin)
        {
            if(request.query.name == null ||
                request.query.salary == null){
                    response.status(400).json({ message: "400 Bad Request" })
            }
            else{
                db.json(`INSERT INTO Role VALUES(
                    "${request.query.name}",
                    "${request.query.salary}");`, function (err, jsonString) {
                        if (err){
                            response.status(500).json({ message: err.message })
                        }
                        else{
                            response.status(200).json({ message: "OK" })
                        }
                });
            }
        }
        else{
            response.status(403).json({ message: "403 Forbidden" })
        }
    });
});

app.put('/roles/:name', function (request, response) {
    db.json(`SELECT IsAdmin FROM Employee WHERE PassportID = '${response.locals.passportid}'`, function (err, jsonString) {
        var user = JSON.parse(jsonString)[0]
        if(user.IsAdmin)
        {
            var newName = request.query.newName == null || request.query.newName == '' ? "null" : `"${request.query.newName}"`
            var newSalary = request.query.newSalary == null || request.query.newSalary == '' ? "null" : `"${request.query.newSalary}"`
            
            var sqlQuery = `UPDATE Role
                SET
                Name = coalesce(${newName}, Name),
                Salary = coalesce(${newSalary}, Salary)
                WHERE Name = '${request.params.name}'`
            db.json(sqlQuery,
            function(err){
                if (err){
                    response.status(500).json({ message: err.message })
                }
                else{
                    response.status(200).json({ message: "OK" })
                }
            });
        }
        else
        {
            response.status(403).json({ message: "403 Forbidden" })
        }
    });
});

app.delete('/roles/:name', function (request, response) {
    db.json(`SELECT IsAdmin FROM Employee WHERE PassportID = '${response.locals.passportid}'`, function (err, jsonString) {
        var user = JSON.parse(jsonString)[0]
        if(user.IsAdmin)
        {
            db.json(`DELETE FROM Role WHERE Name = '${request.params.name}'`, function (err, jsonString) {
                if (err)
                {
                    response.status(500).json({ message: err.message })
                }
                else
                {
                    response.status(200).json({ message: "OK" })
                }
            });
        }
        else
        {
            response.status(403).json({ message: "403 Forbidden" })
        }
    });
});

app.get('/types', function (request, response) {
    db.json(`SELECT * FROM Type`, function (err, jsonString) {
        response.json(JSON.parse(jsonString))
    });
});

app.post('/types', function (request, response) {
        if(request.query.name == null ||
            request.query.compensation == null ||
            request.query.cleaningprice == null){
                response.status(400).json({ message: "400 Bad Request" })
        }
        else{
            db.json(`INSERT INTO Type VALUES(
                "${request.query.name}",
                "${request.query.compensation}",
                "${request.query.cleaningprice}");`, function (err, jsonString) {
                    if (err){
                        response.status(500).json({ message: err.message })
                    }
                    else{
                        response.status(200).json({ message: "OK" })
                    }
            });
        }
});

app.get('/cleanings', function (request, response) {
    db.json(`SELECT * FROM Cleaning`, function (err, jsonString) {
        response.json(JSON.parse(jsonString))
    });
});

app.post('/cleanings', function (request, response) {
    if(request.query.date == null ||
        request.query.result == null ||
        request.query.employee == null ||
        request.query.chemicalagent == null ||
        request.query.thing == null){
            response.status(400).json({ message: "400 Bad Request" })
    }
    else{
        db.json(`INSERT INTO Cleaning (Date, Result, Employee, ChemicAlagent, Thing) VALUES(
            "${request.query.date}",
            "${request.query.result}",
            "${request.query.employee}",
            "${request.query.chemicalagent}",
            "${request.query.thing}");`, function (err, jsonString) {
                if (err){
                    response.status(500).json({ message: err.message })
                }
                else{
                    response.status(200).json({ message: "OK" })
                }
        });
    }
});

app.get('/cleanings/:id', function (request, response) {
    db.json(`SELECT * FROM Cleaning WHERE ID = '${request.params.id}'`, function (err, jsonString) {
        response.json(JSON.parse(jsonString)[0])
    });
});

app.get('/things', function (request, response) {
    db.json(`SELECT * FROM Thing`, function (err, jsonString) {
        response.json(JSON.parse(jsonString))
    });
});

app.post('/things', function (request, response) {
    if(request.query.name == null ||
        request.query.material == null ||
        request.query.type == null ||
        request.query.cleaningorder == null){
            response.status(400).json({ message: "400 Bad Request" })
    }
    else{
        db.json(`INSERT INTO Thing (Name, Material, Type, CleaningOrder) VALUES(
            "${request.query.name}",
            "${request.query.material}",
            "${request.query.type}",
            "${request.query.cleaningorder}");`, function (err, jsonString) {
                if (err){
                    response.status(500).json({ message: err.message })
                }
                else{
                    response.status(200).json({ message: "OK" })
                }
        });
    }
});

app.get('/things/:id', function (request, response) {
    db.json(`SELECT * FROM Thing WHERE ID = '${request.params.id}'`, function (err, jsonString) {
        response.json(JSON.parse(jsonString)[0])
    });
});

app.get('/cleaningorders', function (request, response) {
    db.json(`SELECT * FROM CleaningOrder`, function (err, jsonString) {
        response.json(JSON.parse(jsonString))
    });
});

app.post('/cleaningorders', function (request, response) {
    if( request.query.dateofreceipt == null ||
        request.query.targetterm == null ||
        request.query.employee == null ||
        request.query.client == null){
            response.status(400).json({ message: "400 Bad Request" })
    }
    else{
        var DateOfReceipt = request.query.dateofreceipt
        //var DateOfReturn = request.query.dateofreturn //== null ? "null" : `${request.query.dateofreturn}`
        var TargetTerm = request.query.targetterm
        //var ActualTerm = request.query.actualterm //== null ? "null" : `${request.query.actualterm}`
        var Employee = request.query.employee
        var Client = request.query.client

        db.json(`INSERT INTO CleaningOrder (DateOfReceipt, TargetTerm, Employee, Client) VALUES(
            '${DateOfReceipt}',
            '${TargetTerm}',
            ${Employee},
            ${Client});`, function (err, jsonString) {
                if (err){
                    response.status(500).json({ message: err.message })
                }
                else{
                    response.status(200).json({ message: "OK" })
                }
        });
    }
});

app.put('/cleaningorders/:id', function (request, response) {
    var DateOfReceipt = request.query.dateofreceipt == null ? "null" : `"${request.query.dateofreceipt}"`
    var DateOfReturn = request.query.dateofreturn == null ? "null" : `"${request.query.dateofreturn}"`
    var TargetTerm = request.query.targetterm == null ? "null" : `"${request.query.targetterm}"`
    var ActualTerm = request.query.actualterm == null ? "null" : `"${request.query.actualterm}"`
    var Employee = request.query.employee == null ? "null" : `${request.query.employee}`
    var Client = request.query.client == null ? "null" : `${request.query.client}`

    db.json(`UPDATE CleaningOrder
        SET
        DateOfReceipt = coalesce(${DateOfReceipt}, DateOfReceipt),
        DateOfReturn = coalesce(${DateOfReturn}, DateOfReturn),
        TargetTerm = coalesce(${TargetTerm}, TargetTerm),
        ActualTerm = coalesce(${ActualTerm}, ActualTerm),
        Employee = coalesce(${Employee}, Employee),
        Client = coalesce(${Client}, Client)
        WHERE ID = '${request.params.id}'`,
    function(err){
        if (err){
            response.status(500).json({ message: err.message })
        }
        else{
            db.json(`SELECT * FROM CleaningOrder WHERE ID = '${request.params.id}'`, function (err, jsonString) {
                response.json(JSON.parse(jsonString)[0])
            });
        }
    });
});

app.get('/cleaningorders/:id', function (request, response) {
    db.json(`SELECT * FROM CleaningOrder WHERE ID = '${request.params.id}'`, function (err, jsonString) {
        response.json(JSON.parse(jsonString)[0])
    });
});