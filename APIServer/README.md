# API сервер химчистки

## Авторизация


> POST /authorization

Номер паспорта и пароль передаются в header

| Атрибут | Тип | Необходимый | Описание |
| ------ | ------ | ------ | ------ |
| passportid | integer | да | Номер паспорта |
| password | string | да | Пароль |

Пример ответа:  
```json
{
    "token": "e27dde70b5491b7a251a3a6f030e1746"
}
```

Дальнейшие запросы выполняются через выданный токен.  
Токен указывается с помощью header ключа `token`

## Ресурсы
### Текущий сотрудник  

> GET /user  

Пример ответа:  
```json
{
    "PassportID": 123412,
    "Name": "Иванов Иван Иваныч",
    "Role": "Администратор",
    "IsAdmin": 1
}
```

### Редактировать текущего сотрудника
  
> PUT /user

| Атрибут | Тип | Необходимый | Описание |
| ------ | ------ | ------ | ------ |
| newPassportID | string | нет | Новый номер паспорта |
| newName | string | нет | Новое ФИО |
| newPassword | string | нет | Новый пароль |


Пример ответа:  
```json
{
    "PassportID": 123456789,
    "Name": "Анонимус",
    "Role": "Администратор",
    "IsAdmin": 1
}
```

### Добавить сотрудника  

> POST /users

_Только для администраторов_

| Атрибут | Тип | Необходимый | Описание |
| ------ | ------ | ------ | ------ |
| newPassportID | string | да | Номер паспорта |
| name | string | да | ФИО |
| role | string | да | Должность |
| newPassword | string | да | Пароль |
| isAdmin | boolean | нет | Является ли администратором системы (по умолчанию false) |

### Удалить сотрудника  

> DELETE /users/:passportid

_Только для администраторов_

### Редактировать сотрудника
  
> PUT /users/:passportid

| Атрибут | Тип | Необходимый | Описание |
| ------ | ------ | ------ | ------ |
| newPassportID | string | нет | Новый номер паспорта |
| newName | string | нет | Новое ФИО |
| newRole | string | нет | Должность |
| newIsAdmin | string | нет | Является ли администратором системы |


### Все сотрудники  

> GET /users

Пример ответа:  
```json
{
    "123412": {
        "PassportID": 123412,
        "Name": "Иванов Иван Иваныч",
        "Role": "Администратор",
        "IsAdmin": 1
    },
    "198472": {
        "PassportID": 198472,
        "Name": "Александрова Александра Александровна",
        "Role": "Директор",
        "IsAdmin": 1
    }
}
```

### Сотрудник

> GET /users/:passportid

Пример ответа:  
```json
{
    "PassportID": 198472,
    "Name": "Александрова Александра Александровна",
    "Role": "Директор",
    "IsAdmin": 1
}
```

### Материалы

> GET /materials

Пример ответа:  
```json
{
    "хлопок": {
        "Material": "хлопок"
    },
    "полиэстер": {
        "Material": "полиэстер"
    }
}
```

### Материал

> GET /materials/:name

### Добавить материал

> POST /materials

| Атрибут | Тип | Необходимый | Описание |
| ------ | ------ | ------ | ------ |
| name | string | да | Название материала |

### Редактировать материал

> PUT /materials/:name

| Атрибут | Тип | Необходимый | Описание |
| ------ | ------ | ------ | ------ |
| name | string | да | Новое название материала |

### Удалить материал

> DELETE /materials/:name

### Химические средства  

> GET /chemicalagents

Пример ответа:  
```json
{
    "Стиральный порошок": {
        "Name": "Стиральный порошок"
    },
    "Усилитель и активатор": {
        "Name": "Усилитель и активатор"
    },
    "Аппрет и пропитка": {
        "Name": "Аппрет и пропитка"
    }
}
```

### Добавить химическое средство  

> POST /chemicalagents

| Атрибут | Тип | Необходимый | Описание |
| ------ | ------ | ------ | ------ |
| name | string | да | Название химического средства |

### Редактировать химическое средство  

> PUT /chemicalagents/:name

| Атрибут | Тип | Необходимый | Описание |
| ------ | ------ | ------ | ------ |
| name | string | да | Название химического средства |

### Удалить химическое средство  

> DELETE /chemicalagents/:name

### Клиенты

> GET /clients

Пример ответа:  
```json
{
    "1": {
        "ID": 1,
        "Name": "Корнилов Филипп Семенович",
        "Telephone": "83271455393"
    },
    "2": {
        "ID": 2,
        "Name": "Корнилова Алёна Денисовна",
        "Telephone": "83271455393"
    }
}
```

### Добавить клиента

> POST /clients

| Атрибут | Тип | Необходимый | Описание |
| ------ | ------ | ------ | ------ |
| name | string | да | ФИО клиента |
| telephone | string | да | Телефон клиента |

### Клиент по ID  

> GET /clients/:id

Пример ответа:  
```json
{
    "ID": 5,
    "Name": "Щербаков Савелий Рубенович",
    "Telephone": "89271455893"
}
```

### Редактировать клиента  

> PUT /clients/:id

| Атрибут | Тип | Необходимый | Описание |
| ------ | ------ | ------ | ------ |
| name | string | нет | ФИО клиента |
| telephone | string | нет | Телефон клиента |

### Удалить клиента  

> DELETE /clients/:id

## Возможные результаты чистки  

> GET /results

Пример ответа:  
```json
{
    "Положительный": {
        "Result": "Положительный"
    },
    "Отрицательный": {
        "Result": "Отрицательный"
    },
    "Без изменения": {
        "Result": "Без изменения"
    }
}
```

### Добавить результат  

> POST /results

| Атрибут | Тип | Необходимый | Описание |
| ------ | ------ | ------ | ------ |
| name | string | нет | Название результата |

### Должности

> GET /roles

_Администраторы видят зарплату_

Пример ответа:  
```json
{
    "Администратор": {
        "Name": "Администратор",
        "Salary": 35000
    },
    "Технолог химчистки и прачечной": {
        "Name": "Технолог химчистки и прачечной",
        "Salary": 45000
    }
}
```

### Добавление должностей

> POST /roles

_Только для администраторов_

| Атрибут | Тип | Необходимый | Описание |
| ------ | ------ | ------ | ------ |
| name | string | да | Название должности |
| salary | string | да | Зарплата |

### Типы одежды 

> GET /types

Пример ответа:  
```json
{
    "Верхняя одежда": {
        "Name": "Верхняя одежда",
        "Compensation": 2500,
        "CleaningPrice": 5000
    },
    "Штаны": {
        "Name": "Штаны",
        "Compensation": 1500,
        "CleaningPrice": 2000
    }
}
```

### Добавить типы одежды 

> POST /types

| Атрибут | Тип | Необходимый | Описание |
| ------ | ------ | ------ | ------ |
| name | string | да | Название типа одежды |
| compensation | integer | да | Сумма компенсации |
| cleaningprice | integer | да | Цена чистки |

### Чистки 

> GET /cleanings

Пример ответа:  
```json
{
    "1": {
        "ID": 1,
        "Date": "2019-01-09",
        "Result": "Отрицательный",
        "Employee": 123412,
        "ChemicalAgent": "Стиральный порошок",
        "Thing": 1
    },
    "2": {
        "ID": 2,
        "Date": "2019-10-27",
        "Result": "Положительный",
        "Employee": 198472,
        "ChemicalAgent": "Усилитель и активатор",
        "Thing": 1
    }
}
```

### Вещи 

> GET /things

Пример ответа:  
```json
{
    "1": {
        "ID": 1,
        "Name": "Шуба",
        "Material": "шерсть",
        "Type": "Верхняя одежда",
        "CleaningOrder": 1
    },
    "2": {
        "ID": 2,
        "Name": "Штаны",
        "Material": "лён",
        "Type": "Верхняя одежда",
        "CleaningOrder": 2
    }
}
```

### Вещь

> GET /things/:id

Пример ответа:  
```json
{
    "ID": 2,
    "Name": "Штаны",
    "Material": "лён",
    "Type": "Верхняя одежда",
    "CleaningOrder": 2
}
```

### Добавить вещь к существующему заказу

> POST /things

| Атрибут | Тип | Необходимый | Описание |
| ------ | ------ | ------ | ------ |
| name | string | да | Название одежды |
| material | string | да | Материал одежды |
| type | integer | string | Тип одежды |
| cleaningorder | integer | да | Номер заказа |


### Заказы
> GET /cleaningorders

Пример ответа:  
```json
{
    "1": {
        "ID": 1,
        "DateOfReceipt": "2019-01-06",
        "DateOfReturn": null,
        "TargetTerm": "2019-01-10",
        "ActualTerm": "2019-01-09",
        "Employee": 223512,
        "Client": 9,
        "Thing": 2,
        "Price": 0
    },
    "2": {
        "ID": 2,
        "DateOfReceipt": "2019-01-06",
        "DateOfReturn": null,
        "TargetTerm": "2019-01-10",
        "ActualTerm": "2019-01-09",
        "Employee": 223512,
        "Client": 8,
        "Thing": 2,
        "Price": 0
    }
}
```

### Заказ

> GET /cleaningorder/:id

Пример ответа:  
```json
{
    "ID": 2,
    "DateOfReceipt": "2019-01-06",
    "DateOfReturn": null,
    "TargetTerm": "2019-01-10",
    "ActualTerm": "2019-01-09",
    "Employee": 223512,
    "Client": 9,
    "Thing": 1,
    "Price": 0
}
```


# Полный список запросов
`get /user`   
`put /user`   
`post /users`   
`delete /users/:passportid`   
`put /users/:passportid`   
`get /users`   
`get /users/:passportid`   
`get /materials`   
`get /materials/:name`   
`post /materials`   
`put /materials/:name`   
`delete /materials/:name`   
`get /chemicalagents`   
`post /chemicalagents`   
`put /chemicalagents/:name`   
`delete /chemicalagents/:name`   
`get /clients`   
`post /clients`   
`get /clients/:id`   
`put /clients/:id`   
`delete /clients/:id`   
`get /results`   
`post /results`   
`put /results/:name`   
`delete /results/:name`   
`get /roles`   
`post /roles`   
`put /roles/:name`   
`delete /roles/:name`   
`get /types`   
`put /types/:name`   
`delete /types/:name`   
`post /types`   
`get /cleaningsthings`   
`post /cleaningsthings`   
`put /cleaningsthings/:cleaningid/:thingid`   
`delete /cleaningsthings/:cleaningid/:thingid`   
`get /cleanings`   
`post /cleanings`   
`get /cleanings/:id`   
`put /cleanings/:id`   
`delete /cleanings/:id`   
`get /things`   
`post /things`   
`get /things/:id`   
`put /things/:id`   
`delete /things/:id`   
`get /cleaningorders`   
`post /cleaningorders`   
`put /cleaningorders/:id`   
`get /cleaningorders/:id`   
`delete /cleaningorders/:id`