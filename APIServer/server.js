const express = require('express')
const sqliteJson = require('sqlite-json')
const md5 = require('js-md5');

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

/*
Authorization
*/
app.use((request, response, next) => {
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
                console.log(`Incoming request from '${json[0].Name}'`)
                // only authorization success next methods
                next()
            }
            else {
                console.log(`Authorisation error for passport '${passportid}'`);
                response.status(401).json({ message: '401 Unauthorized' })
            }
        });
    }
})

app.get('/user', function (request, response) {
    var passportid = request.query.passportid

    db.json(`SELECT PassportID, Name, Role, IsAdmin FROM Employee WHERE PassportID = '${passportid}'`, function (err, jsonString) {
        response.json(JSON.parse(jsonString)[0])
    });
});

app.put('/user', function (request, response) {
    var passportid = request.query.passportid

    var newPassportID = request.query.newPassportID == null ? "null" : `"${request.query.newPassportID}"`
    var newName = request.query.newName == null ? "null" : `"${request.query.newName}"`
    var newPassword = request.query.newPassword == null ? "null" : `"${md5(request.query.newPassword)}"`


    db.json(`UPDATE Employee
        SET
        PassportID = coalesce(${newPassportID}, PassportID),
        Name = coalesce(${newName}, Name),
        Password = coalesce(${newPassword}, Password)
        WHERE PassportID = '${passportid}'`,
    function(err){
        if (err){
            response.status(500).json({ message: err.message })
        }
        else{
            db.json(`SELECT PassportID, Name, Role, IsAdmin FROM Employee WHERE PassportID = '${passportid}'`, function (err, jsonString) {
                response.json(JSON.parse(jsonString)[0])
            });
        }
    });
});

app.post('/users', function (request, response) {
    var passportid = request.query.passportid
    db.json(`SELECT IsAdmin FROM Employee WHERE PassportID = '${passportid}'`, function (err, jsonString) {
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

app.get('/users', function (request, response) {
    var passportid = request.query.passportid

    db.json(`SELECT PassportID, Name, Role, IsAdmin FROM Employee`, {key: 'PassportID'}, function (err, jsonString) {
        response.json(JSON.parse(jsonString))
    });
});

app.get('/users/:passportid', function (request, response) {
    db.json(`SELECT PassportID, Name, Role, IsAdmin FROM Employee WHERE PassportID = '${request.params.passportid}'`, function (err, jsonString) {
        response.json(JSON.parse(jsonString)[0])
    });
});

app.get('/materials', function (request, response) {
    db.json(`SELECT Material FROM Material`, {key: 'Material'}, function (err, jsonString) {
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
    db.json(`SELECT Name FROM ChemicalAgent`, {key: 'Name'}, function (err, jsonString) {
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
    db.json(`SELECT * FROM Client`, {key: 'ID'}, function (err, jsonString) {
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
    db.json(`SELECT * FROM Result`, {key: 'Result'}, function (err, jsonString) {
        response.json(JSON.parse(jsonString))
    });
});

app.get('/roles', function (request, response) {
    var passportid = request.query.passportid

    db.json(`SELECT IsAdmin FROM Employee WHERE PassportID = '${passportid}'`, function (err, jsonString) {
        var user = JSON.parse(jsonString)[0]
        var query = ``
        if(user.IsAdmin)
        {
            query = `SELECT Name, Salary FROM Role`
        }
        else{
            query = `SELECT Name FROM Role`
        }
        db.json(query, {key: 'Name'}, function (err, jsonString) {
            response.json(JSON.parse(jsonString))
        });
    });
});

app.post('/roles', function (request, response) {
    var passportid = request.query.passportid
    db.json(`SELECT IsAdmin FROM Employee WHERE PassportID = '${passportid}'`, function (err, jsonString) {
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

app.get('/types', function (request, response) {
    db.json(`SELECT * FROM Type`, {key: 'Name'}, function (err, jsonString) {
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
    db.json(`SELECT * FROM Cleaning`, {key: 'ID'}, function (err, jsonString) {
        response.json(JSON.parse(jsonString))
    });
});

app.get('/cleanings/:id', function (request, response) {
    db.json(`SELECT * FROM Cleaning WHERE ID = '${request.params.id}'`, function (err, jsonString) {
        response.json(JSON.parse(jsonString)[0])
    });
});

app.get('/things', function (request, response) {
    db.json(`SELECT * FROM Thing`, {key: 'ID'}, function (err, jsonString) {
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
    db.json(`SELECT * FROM CleaningOrder`, {key: 'ID'}, function (err, jsonString) {
        response.json(JSON.parse(jsonString))
    });
});

app.post('/cleaningorders', function (request, response) {
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

app.get('/cleaningorder/:id', function (request, response) {
    db.json(`SELECT * FROM CleaningOrder WHERE ID = '${request.params.id}'`, function (err, jsonString) {
        response.json(JSON.parse(jsonString)[0])
    });
});