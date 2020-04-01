--
-- Файл сгенерирован с помощью SQLiteStudio v3.2.1 в Ср апр 1 18:09:44 2020
--
-- Использованная кодировка текста: UTF-8
--
PRAGMA foreign_keys = off;
BEGIN TRANSACTION;

-- Таблица: ChemicalAgent
DROP TABLE IF EXISTS ChemicalAgent;
CREATE TABLE ChemicalAgent (Name TEXT PRIMARY KEY NOT NULL);
INSERT INTO ChemicalAgent (Name) VALUES ('Стиральный порошок');
INSERT INTO ChemicalAgent (Name) VALUES ('Усилитель и активатор');
INSERT INTO ChemicalAgent (Name) VALUES ('Аппрет и пропитка');

-- Таблица: Cleaning
DROP TABLE IF EXISTS Cleaning;
CREATE TABLE Cleaning (ID INTEGER PRIMARY KEY AUTOINCREMENT, Date DATETIME NOT NULL, Result TEXT NOT NULL REFERENCES Result (Name), Employee INTEGER NOT NULL REFERENCES Employee (PassportID), ChemicalAgent TEXT NOT NULL REFERENCES ChemicalAgent (Name));
INSERT INTO Cleaning (ID, Date, Result, Employee, ChemicalAgent) VALUES (1, '01-04-2020', 'Положительный', 123456, 'Стиральный порошок');
INSERT INTO Cleaning (ID, Date, Result, Employee, ChemicalAgent) VALUES (2, '01-04-2020', 'Отрицательный', 123456, 'Аппрет и пропитка');
INSERT INTO Cleaning (ID, Date, Result, Employee, ChemicalAgent) VALUES (11, '01-04-2020', 'Положительный', 123456, 'Стиральный порошок');

-- Таблица: CleaningOrder
DROP TABLE IF EXISTS CleaningOrder;
CREATE TABLE CleaningOrder (ID INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, DateOfReceipt DATETIME NOT NULL, DateOfReturn DATETIME, TargetTerm DATETIME NOT NULL, ActualTerm DATETIME CHECK (TargetTerm > datetime(DateOfReceipt, '+2 day')), Employee INTEGER NOT NULL REFERENCES Employee (PassportID), Client INTEGER NOT NULL REFERENCES Client (ID));
INSERT INTO CleaningOrder (ID, DateOfReceipt, DateOfReturn, TargetTerm, ActualTerm, Employee, Client) VALUES (1, '05-03-2020', '05-03-2020', '05-03-2020', NULL, 123456, 3);
INSERT INTO CleaningOrder (ID, DateOfReceipt, DateOfReturn, TargetTerm, ActualTerm, Employee, Client) VALUES (2, '05-03-2020', '05-03-2020', '05-03-2020', NULL, 123456, 6);
INSERT INTO CleaningOrder (ID, DateOfReceipt, DateOfReturn, TargetTerm, ActualTerm, Employee, Client) VALUES (3, '05-03-2020', '05-03-2020', '05-03-2020', '', 198472, 12);
INSERT INTO CleaningOrder (ID, DateOfReceipt, DateOfReturn, TargetTerm, ActualTerm, Employee, Client) VALUES (24, '28-03-2020', '28-03-2020', '28-03-2020', '29-03-2020', 12468, 2);
INSERT INTO CleaningOrder (ID, DateOfReceipt, DateOfReturn, TargetTerm, ActualTerm, Employee, Client) VALUES (25, '28-03-2020', '28-03-2020', '28-03-2020', '28-03-2020', 12468, 2);
INSERT INTO CleaningOrder (ID, DateOfReceipt, DateOfReturn, TargetTerm, ActualTerm, Employee, Client) VALUES (26, '28-03-2020', NULL, '28-03-2020', NULL, 123456, 20);
INSERT INTO CleaningOrder (ID, DateOfReceipt, DateOfReturn, TargetTerm, ActualTerm, Employee, Client) VALUES (28, '28-03-2020', '28-03-2020', '28-03-2020', '', 123456, 3);
INSERT INTO CleaningOrder (ID, DateOfReceipt, DateOfReturn, TargetTerm, ActualTerm, Employee, Client) VALUES (31, '01-04-2020', '17-04-2020', '01-04-2020', '18-04-2020', 123456, 2);

-- Таблица: CleaningThing
DROP TABLE IF EXISTS CleaningThing;
CREATE TABLE CleaningThing (CleaningID INTEGER REFERENCES Cleaning (ID), ThingID INTEGER REFERENCES Thing (ID), PRIMARY KEY (CleaningID, ThingID));
INSERT INTO CleaningThing (CleaningID, ThingID) VALUES (1, 5);
INSERT INTO CleaningThing (CleaningID, ThingID) VALUES (2, 6);

-- Таблица: Client
DROP TABLE IF EXISTS Client;
CREATE TABLE Client (ID INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL, Name TEXT NOT NULL, Telephone TEXT NOT NULL);
INSERT INTO Client (ID, Name, Telephone) VALUES (2, 'Корнилова Алёна Денисовна 2', '89271455393');
INSERT INTO Client (ID, Name, Telephone) VALUES (3, 'Шилов Зиновий Рудольфович', '89261455393');
INSERT INTO Client (ID, Name, Telephone) VALUES (4, 'Красильников Петр Гордеевич', '89271455393');
INSERT INTO Client (ID, Name, Telephone) VALUES (5, 'Щербаков Савелий Рубенович', '89271455893');
INSERT INTO Client (ID, Name, Telephone) VALUES (6, 'Петров Игнатий Рубенович', '89271465393');
INSERT INTO Client (ID, Name, Telephone) VALUES (12, 'Блинов Григорий Иванович', '89271455303');
INSERT INTO Client (ID, Name, Telephone) VALUES (14, 'Терентьев Мстислав Яковлевич', '89271455392');
INSERT INTO Client (ID, Name, Telephone) VALUES (15, 'Панфилов Адольф Демьянович', '89271455333');
INSERT INTO Client (ID, Name, Telephone) VALUES (16, 'Алексеев Панкрат Вениаминович', '89271455343');
INSERT INTO Client (ID, Name, Telephone) VALUES (17, 'Медведев Митрофан Парфеньевич', '89271455593');
INSERT INTO Client (ID, Name, Telephone) VALUES (18, 'Туров Аркадий Богданович', '89271456393');
INSERT INTO Client (ID, Name, Telephone) VALUES (19, 'Карпов Трофим Дамирович', '89271475393');
INSERT INTO Client (ID, Name, Telephone) VALUES (20, 'Белов Тарас Иосифович', '89271458393');
INSERT INTO Client (ID, Name, Telephone) VALUES (21, 'Казаков Михаил Пётрович', '89271495393');
INSERT INTO Client (ID, Name, Telephone) VALUES (22, 'Чернов Алексей Тимурович', '89271405393');

-- Таблица: Employee
DROP TABLE IF EXISTS Employee;
CREATE TABLE Employee (PassportID INTEGER PRIMARY KEY NOT NULL, Name TEXT NOT NULL, Role TEXT NOT NULL REFERENCES Role (Name), Password varchar (32) NOT NULL, IsAdmin BOOLEAN DEFAULT (false) NOT NULL);
INSERT INTO Employee (PassportID, Name, Role, Password, IsAdmin) VALUES (12468, 'Иванова Галина Ивановна', 'Приемщик-кассир', '81dc9bdb52d04dc20036dbd8313ed055', 0);
INSERT INTO Employee (PassportID, Name, Role, Password, IsAdmin) VALUES (123456, 'Мурашов Александр Михайлович', 'Администратор', '81dc9bdb52d04dc20036dbd8313ed055', 1);
INSERT INTO Employee (PassportID, Name, Role, Password, IsAdmin) VALUES (198472, 'Александрова Александра Александровна', 'Директор', '81dc9bdb52d04dc20036dbd8313ed055', 1);
INSERT INTO Employee (PassportID, Name, Role, Password, IsAdmin) VALUES (823715, 'Артемьев Артём Артёмович', 'Приемщик-кассир', '81dc9bdb52d04dc20036dbd8313ed055', 0);

-- Таблица: Material
DROP TABLE IF EXISTS Material;
CREATE TABLE Material (Name TEXT PRIMARY KEY NOT NULL);
INSERT INTO Material (Name) VALUES ('хлопок');
INSERT INTO Material (Name) VALUES ('полиэстер');
INSERT INTO Material (Name) VALUES ('шёлк');
INSERT INTO Material (Name) VALUES ('лён');
INSERT INTO Material (Name) VALUES ('шерсть');
INSERT INTO Material (Name) VALUES ('синтетика');

-- Таблица: Result
DROP TABLE IF EXISTS Result;
CREATE TABLE Result (Name TEXT PRIMARY KEY);
INSERT INTO Result (Name) VALUES ('Положительный');
INSERT INTO Result (Name) VALUES ('Отрицательный');
INSERT INTO Result (Name) VALUES ('Без изменения');

-- Таблица: Role
DROP TABLE IF EXISTS Role;
CREATE TABLE Role (Name TEXT PRIMARY KEY NOT NULL, Salary INTEGER);
INSERT INTO Role (Name, Salary) VALUES ('Администратор', 35000);
INSERT INTO Role (Name, Salary) VALUES ('Технолог химчистки и прачечной', 45000);
INSERT INTO Role (Name, Salary) VALUES ('Директор', 250000);
INSERT INTO Role (Name, Salary) VALUES ('Приемщик-кассир', 20000);

-- Таблица: Thing
DROP TABLE IF EXISTS Thing;
CREATE TABLE Thing (ID INTEGER PRIMARY KEY AUTOINCREMENT, Name TEXT NOT NULL, Material TEXT NOT NULL REFERENCES Material (Name), Type TEXT NOT NULL REFERENCES Type (Name), CleaningOrder INTEGER NOT NULL, FOREIGN KEY (CleaningOrder) REFERENCES CleaningOrder (ID));
INSERT INTO Thing (ID, Name, Material, Type, CleaningOrder) VALUES (1, 'Шуба', 'шерсть', 'Верхняя одежда', 1);
INSERT INTO Thing (ID, Name, Material, Type, CleaningOrder) VALUES (2, 'Штаны', 'лён', 'Верхняя одежда', 2);
INSERT INTO Thing (ID, Name, Material, Type, CleaningOrder) VALUES (5, 'Куртка', 'лён', 'Верхняя одежда', 1);
INSERT INTO Thing (ID, Name, Material, Type, CleaningOrder) VALUES (6, 'Шуба', 'лён', 'Верхняя одежда', 3);

-- Таблица: Token
DROP TABLE IF EXISTS Token;
CREATE TABLE Token (Employee INTEGER NOT NULL REFERENCES Employee (PassportID), Token TEXT NOT NULL PRIMARY KEY);
INSERT INTO Token (Employee, Token) VALUES (123456, '088b9d0db07cbd67e5291777eb246e3d');

-- Таблица: Type
DROP TABLE IF EXISTS Type;
CREATE TABLE Type (Name TEXT PRIMARY KEY NOT NULL, Compensation INTEGER NOT NULL CHECK (Compensation < CleaningPrice), CleaningPrice INTEGER NOT NULL);
INSERT INTO Type (Name, Compensation, CleaningPrice) VALUES ('Верхняя одежда', 2500, 5000);
INSERT INTO Type (Name, Compensation, CleaningPrice) VALUES ('Штаны', 1500, 2000);
INSERT INTO Type (Name, Compensation, CleaningPrice) VALUES ('Головной убор', 500, 1000);
INSERT INTO Type (Name, Compensation, CleaningPrice) VALUES ('Нижнее бельё', 50, 100);
INSERT INTO Type (Name, Compensation, CleaningPrice) VALUES ('Кофты', 500, 1000);
INSERT INTO Type (Name, Compensation, CleaningPrice) VALUES ('Перчатки', 250, 500);
INSERT INTO Type (Name, Compensation, CleaningPrice) VALUES ('Носки', 25, 50);
INSERT INTO Type (Name, Compensation, CleaningPrice) VALUES ('Шарфы', 150, 300);

COMMIT TRANSACTION;
PRAGMA foreign_keys = on;
