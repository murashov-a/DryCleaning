const express = require('express')
const sqliteJson = require('sqlite-json')
const md5 = require('js-md5');

const app = express()
const port = 80

const database = sqliteJson('DryCleaning.db3');

app.use((request, response, next) => {
    var login = request.query.login
    var password = request.query.password

    if (login == null || password == null) {
        response.status(401).json({ message: '401 Unauthorized' })
    }
    else {
        var passwordMD5 = md5(password)

        database.json(`SELECT * FROM Employee WHERE Login = '${login}' AND Password = '${passwordMD5}'`, function (err, jsonString) {
            var json = JSON.parse(jsonString)
            if (json.length == 0) {
                console.log(`Authorisation error for user '${login}'`);
                response.status(401).json({ message: '401 Unauthorized' })
            }
            else {
                console.log(`Incoming request from ${login}`)
                next()
            }
        });
    }
})

app.get('/user', function (request, response) {
    var login = request.query.login
    var passwordMD5 = md5(request.query.password)

    database.json(`SELECT PassportID, Login, Name, Role FROM Employee WHERE Login = '${login}' AND Password = '${passwordMD5}' limit 1`, function (err, jsonString) {
        var user = JSON.parse(jsonString)[0]
        response.json(user) //response.json({ PassportID: user.PassportID, Login: user.Login, Name: user.Name, Role: user.Role }) //withot limit 1
    });
});

app.get('/materials', function (request, response) {
    database.json(`SELECT * FROM Material`, function (err, jsonString) {
        var materials = JSON.parse(jsonString)
        response.json(materials)
    });
});

app.listen(port,
    (err) => {
        if (err) {
            return console.log('Error start server', err)
        }
        console.log(`Server is listening on ${port}`)
    })