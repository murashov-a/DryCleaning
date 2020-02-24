# API сервер химчистки

## Авторизация
Параметры: passportid, password  
Пример:  

```
.../?passportid=123412&password=1234
```

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

> PUT /user?newPassportID=123456789&newName=Анонимус&newPassword=новыйпароль

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

### Заказы
> GET /cleaningorder

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
