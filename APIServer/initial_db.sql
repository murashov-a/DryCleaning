--
-- Файл сгенерирован с помощью SQLiteStudio v3.2.1 в Пн фев 24 22:01:25 2020
--
-- Использованная кодировка текста: UTF-8
--
PRAGMA foreign_keys = off;
BEGIN TRANSACTION;

-- Таблица: ChemicalAgent
DROP TABLE IF EXISTS ChemicalAgent;
CREATE TABLE ChemicalAgent(
    Name TEXT PRIMARY KEY
);
INSERT INTO ChemicalAgent (Name) VALUES ('Стиральный порошок');
INSERT INTO ChemicalAgent (Name) VALUES ('Усилитель и активатор');
INSERT INTO ChemicalAgent (Name) VALUES ('Аппрет и пропитка');

-- Таблица: Cleaning
DROP TABLE IF EXISTS Cleaning;
CREATE TABLE Cleaning(
    ID INTEGER PRIMARY KEY,
    Date DATETIME NOT NULL,
    Result TEXT NOT NULL REFERENCES Result(Result),
    Employee INTEGER NOT NULL REFERENCES Employee(PassportID),
    ChemicalAgent TEXT NOT NULL REFERENCES ChemicalAgent(Name),
    Thing INTEGER NOT NULL,
    FOREIGN KEY(Thing) REFERENCES Thing(ID)
);
INSERT INTO Cleaning (ID, Date, Result, Employee, ChemicalAgent, Thing) VALUES (1, '2019-01-09', 'Отрицательный', 123412, 'Стиральный порошок', 1);
INSERT INTO Cleaning (ID, Date, Result, Employee, ChemicalAgent, Thing) VALUES (2, '2019-10-27', 'Положительный', 198472, 'Усилитель и активатор', 1);
INSERT INTO Cleaning (ID, Date, Result, Employee, ChemicalAgent, Thing) VALUES (3, '2019-10-29', 'Отрицательный', 123412, 'Аппрет и пропитка', 1);
INSERT INTO Cleaning (ID, Date, Result, Employee, ChemicalAgent, Thing) VALUES (4, '2019-11-09', 'Положительный', 198472, 'Усилитель и активатор', 1);
INSERT INTO Cleaning (ID, Date, Result, Employee, ChemicalAgent, Thing) VALUES (5, '2019-11-10', 'Отрицательный', 123412, 'Усилитель и активатор', 1);
INSERT INTO Cleaning (ID, Date, Result, Employee, ChemicalAgent, Thing) VALUES (6, '2019-11-08', 'Положительный', 123412, 'Аппрет и пропитка', 1);
INSERT INTO Cleaning (ID, Date, Result, Employee, ChemicalAgent, Thing) VALUES (7, '2019-11-05', 'Отрицательный', 823715, 'Стиральный порошок', 2);
INSERT INTO Cleaning (ID, Date, Result, Employee, ChemicalAgent, Thing) VALUES (8, '2019-11-04', 'Положительный', 823715, 'Аппрет и пропитка', 2);
INSERT INTO Cleaning (ID, Date, Result, Employee, ChemicalAgent, Thing) VALUES (9, '2019-11-03', 'Отрицательный', 823715, 'Аппрет и пропитка', 1);
INSERT INTO Cleaning (ID, Date, Result, Employee, ChemicalAgent, Thing) VALUES (10, '2019-11-02', 'Положительный', 198472, 'Аппрет и пропитка', 1);
INSERT INTO Cleaning (ID, Date, Result, Employee, ChemicalAgent, Thing) VALUES (11, '2019-11-12', 'Отрицательный', 198472, 'Аппрет и пропитка', 2);
INSERT INTO Cleaning (ID, Date, Result, Employee, ChemicalAgent, Thing) VALUES (12, '2019-11-13', 'Положительный', 524342, 'Аппрет и пропитка', 1);
INSERT INTO Cleaning (ID, Date, Result, Employee, ChemicalAgent, Thing) VALUES (13, '2019-11-16', 'Отрицательный', 524342, 'Аппрет и пропитка', 2);
INSERT INTO Cleaning (ID, Date, Result, Employee, ChemicalAgent, Thing) VALUES (14, '2019-11-20', 'Без изменения', 524342, 'Усилитель и активатор', 1);
INSERT INTO Cleaning (ID, Date, Result, Employee, ChemicalAgent, Thing) VALUES (15, '2019-11-02', 'Без изменения', 524342, 'Аппрет и пропитка', 2);
INSERT INTO Cleaning (ID, Date, Result, Employee, ChemicalAgent, Thing) VALUES (16, '2019-11-13', 'Без изменения', 524342, 'Аппрет и пропитка', 1);
INSERT INTO Cleaning (ID, Date, Result, Employee, ChemicalAgent, Thing) VALUES (17, '2019-11-16', 'Без изменения', 524342, 'Усилитель и активатор', 2);
INSERT INTO Cleaning (ID, Date, Result, Employee, ChemicalAgent, Thing) VALUES (18, '2019-11-20', 'Без изменения', 123412, 'Усилитель и активатор', 2);

-- Таблица: CleaningOrder
DROP TABLE IF EXISTS CleaningOrder;
CREATE TABLE CleaningOrder(
    ID INTEGER,
    DateOfReceipt DATETIME NOT NULL,
    DateOfReturn DATETIME,
    TargetTerm DATETIME NOT NULL,
    ActualTerm DATETIME CHECK (TargetTerm > datetime(DateOfReceipt,'+2 day')),
    Employee INTEGER NOT NULL references Employee(PassportID),
    Client INTEGER NOT NULL references Client(ID),
    Thing INTEGER NOT NULL,
    Price INTEGER not null,
    FOREIGN KEY(Thing) REFERENCES Thing(ID),
    PRIMARY KEY (ID, Thing)
);
INSERT INTO CleaningOrder (ID, DateOfReceipt, DateOfReturn, TargetTerm, ActualTerm, Employee, Client, Thing, Price) VALUES (1, '2019-01-06', NULL, '2019-01-10', '2019-01-09', 223512, 10, 1, 0);
INSERT INTO CleaningOrder (ID, DateOfReceipt, DateOfReturn, TargetTerm, ActualTerm, Employee, Client, Thing, Price) VALUES (1, '2019-01-06', NULL, '2019-01-10', '2019-01-09', 223512, 9, 2, 0);
INSERT INTO CleaningOrder (ID, DateOfReceipt, DateOfReturn, TargetTerm, ActualTerm, Employee, Client, Thing, Price) VALUES (2, '2019-01-06', NULL, '2019-01-10', '2019-01-09', 223512, 9, 1, 0);
INSERT INTO CleaningOrder (ID, DateOfReceipt, DateOfReturn, TargetTerm, ActualTerm, Employee, Client, Thing, Price) VALUES (2, '2019-01-06', NULL, '2019-01-10', '2019-01-09', 223512, 8, 2, 0);
INSERT INTO CleaningOrder (ID, DateOfReceipt, DateOfReturn, TargetTerm, ActualTerm, Employee, Client, Thing, Price) VALUES (3, '2019-01-06', NULL, '2019-01-10', '2019-01-09', 223512, 8, 1, 0);
INSERT INTO CleaningOrder (ID, DateOfReceipt, DateOfReturn, TargetTerm, ActualTerm, Employee, Client, Thing, Price) VALUES (3, '2019-01-06', NULL, '2019-01-10', NULL, 223512, 7, 2, 0);
INSERT INTO CleaningOrder (ID, DateOfReceipt, DateOfReturn, TargetTerm, ActualTerm, Employee, Client, Thing, Price) VALUES (4, '2019-01-06', NULL, '2019-01-10', NULL, 223512, 7, 1, 0);
INSERT INTO CleaningOrder (ID, DateOfReceipt, DateOfReturn, TargetTerm, ActualTerm, Employee, Client, Thing, Price) VALUES (4, '2019-01-06', NULL, '2019-01-10', NULL, 223512, 7, 2, 0);
INSERT INTO CleaningOrder (ID, DateOfReceipt, DateOfReturn, TargetTerm, ActualTerm, Employee, Client, Thing, Price) VALUES (4, '2019-01-06', NULL, '2019-01-10', NULL, 223512, 7, 3, 0);

-- Таблица: Client
DROP TABLE IF EXISTS Client;
CREATE TABLE Client(
    ID INTEGER PRIMARY KEY AUTOINCREMENT,
    Name TEXT NOT NULL,
    Telephone TEXT NOT NULL
);
INSERT INTO Client (ID, Name, Telephone) VALUES (1, 'Корнилов Филипп Семенович', '83271455393');
INSERT INTO Client (ID, Name, Telephone) VALUES (2, 'Корнилова Алёна Денисовна', '83271455393');
INSERT INTO Client (ID, Name, Telephone) VALUES (3, 'Шилов Зиновий Рудольфович', '89261455393');
INSERT INTO Client (ID, Name, Telephone) VALUES (4, 'Красильников Петр Гордеевич', '89271455393');
INSERT INTO Client (ID, Name, Telephone) VALUES (5, 'Щербаков Савелий Рубенович', '89271455893');
INSERT INTO Client (ID, Name, Telephone) VALUES (6, 'Петров Игнатий Рубенович', '89271465393');
INSERT INTO Client (ID, Name, Telephone) VALUES (7, 'Орлов Прохор Христофорович', '89271485393');
INSERT INTO Client (ID, Name, Telephone) VALUES (8, 'Брагин Нинель Игнатьевич', '89274455393');
INSERT INTO Client (ID, Name, Telephone) VALUES (9, 'Селезнёв Мартын Тимурович', '89271457393');
INSERT INTO Client (ID, Name, Telephone) VALUES (10, 'Пестов Арсен Филиппович', '89271855393');
INSERT INTO Client (ID, Name, Telephone) VALUES (11, 'Дорофеев Нисон Витальевич', '89271455993');
INSERT INTO Client (ID, Name, Telephone) VALUES (12, 'Блинов Григорий Иванович', '89271455303');
INSERT INTO Client (ID, Name, Telephone) VALUES (13, 'Некрасов Карл Давидович', '89271455313');
INSERT INTO Client (ID, Name, Telephone) VALUES (14, 'Терентьев Мстислав Яковлевич', '89271455392');
INSERT INTO Client (ID, Name, Telephone) VALUES (15, 'Панфилов Адольф Демьянович', '89271455333');
INSERT INTO Client (ID, Name, Telephone) VALUES (16, 'Алексеев Панкрат Вениаминович', '89271455343');
INSERT INTO Client (ID, Name, Telephone) VALUES (17, 'Медведев Митрофан Парфеньевич', '89271455593');
INSERT INTO Client (ID, Name, Telephone) VALUES (18, 'Туров Аркадий Богданович', '89271456393');
INSERT INTO Client (ID, Name, Telephone) VALUES (19, 'Карпов Трофим Дамирович', '89271475393');
INSERT INTO Client (ID, Name, Telephone) VALUES (20, 'Белов Тарас Иосифович', '89271458393');
INSERT INTO Client (ID, Name, Telephone) VALUES (21, 'Казаков Михаил Пётрович', '89271495393');
INSERT INTO Client (ID, Name, Telephone) VALUES (22, 'Чернов Алексей Тимурович', '89271405393');
INSERT INTO Client (ID, Name, Telephone) VALUES (23, 'Фадеев Климент Куприянович', '89272455393');
INSERT INTO Client (ID, Name, Telephone) VALUES (24, 'Виноградов Семен Христофорович', '89371455393');
INSERT INTO Client (ID, Name, Telephone) VALUES (25, 'Соболев Владимир Петрович', '89471455393');
INSERT INTO Client (ID, Name, Telephone) VALUES (26, 'Иванов Ефрем Анатольевич', '85271455393');
INSERT INTO Client (ID, Name, Telephone) VALUES (27, 'Макаров Леонид Даниилович', '89271455396');
INSERT INTO Client (ID, Name, Telephone) VALUES (28, 'Петухов Адам Павлович', '89271455397');
INSERT INTO Client (ID, Name, Telephone) VALUES (29, 'Мухин Владлен Эдуардович', '89271454393');

-- Таблица: Employee
DROP TABLE IF EXISTS Employee;
CREATE TABLE Employee (PassportID INTEGER PRIMARY KEY, Name TEXT NOT NULL, Role NOT NULL REFERENCES Role (Name), Password varchar (32) NOT NULL, IsAdmin BOOLEAN DEFAULT (false) NOT NULL);
INSERT INTO Employee (PassportID, Name, Role, Password, IsAdmin) VALUES (123456, 'Мурашов Александр Михайлович', 'Администратор', '81dc9bdb52d04dc20036dbd8313ed055', 1);
INSERT INTO Employee (PassportID, Name, Role, Password, IsAdmin) VALUES (198472, 'Александрова Александра Александровна', 'Директор', '81dc9bdb52d04dc20036dbd8313ed055', 1);
INSERT INTO Employee (PassportID, Name, Role, Password, IsAdmin) VALUES (524342, 'Николаев Николай Николаевич', 'Технолог химчистки и прачечной', '81dc9bdb52d04dc20036dbd8313ed055', 0);
INSERT INTO Employee (PassportID, Name, Role, Password, IsAdmin) VALUES (823715, 'Артемьев Артём Артёмович', 'Приемщик-кассир', '81dc9bdb52d04dc20036dbd8313ed055', 0);

-- Таблица: Material
DROP TABLE IF EXISTS Material;
CREATE TABLE Material(
    Material TEXT PRIMARY KEY
);
INSERT INTO Material (Material) VALUES ('хлопок');
INSERT INTO Material (Material) VALUES ('полиэстер');
INSERT INTO Material (Material) VALUES ('шёлк');
INSERT INTO Material (Material) VALUES ('лён');
INSERT INTO Material (Material) VALUES ('шерсть');
INSERT INTO Material (Material) VALUES ('синтетика');

-- Таблица: Result
DROP TABLE IF EXISTS Result;
CREATE TABLE Result(
    Result TEXT PRIMARY KEY
);
INSERT INTO Result (Result) VALUES ('Положительный');
INSERT INTO Result (Result) VALUES ('Отрицательный');
INSERT INTO Result (Result) VALUES ('Без изменения');

-- Таблица: Role
DROP TABLE IF EXISTS Role;
CREATE TABLE Role(
    Name TEXT PRIMARY KEY,
    Salary INTEGER NOT NULL
);
INSERT INTO Role (Name, Salary) VALUES ('Администратор', 35000);
INSERT INTO Role (Name, Salary) VALUES ('Технолог химчистки и прачечной', 45000);
INSERT INTO Role (Name, Salary) VALUES ('Приемщик-кассир', 20000);
INSERT INTO Role (Name, Salary) VALUES ('Директор', 250000);

-- Таблица: Thing
DROP TABLE IF EXISTS Thing;
CREATE TABLE Thing(
    ID INTEGER PRIMARY KEY AUTOINCREMENT,
    Name TEXT NOT NULL,
    Material TEXT NOT NULL REFERENCES Material(Material),
    Type TEXT NOT NULL REFERENCES Type(Name),
    CleaningOrder INTEGER NOT NULL,
    FOREIGN KEY(CleaningOrder) REFERENCES CleaningOrder(ID)
);
INSERT INTO Thing (ID, Name, Material, Type, CleaningOrder) VALUES (1, 'Шуба', 'шерсть', 'Верхняя одежда', 1);
INSERT INTO Thing (ID, Name, Material, Type, CleaningOrder) VALUES (2, 'Штаны', 'лён', 'Верхняя одежда', 2);
INSERT INTO Thing (ID, Name, Material, Type, CleaningOrder) VALUES (3, 'Шуба', 'шерсть', 'Верхняя одежда', 1);
INSERT INTO Thing (ID, Name, Material, Type, CleaningOrder) VALUES (4, 'Штаны', 'лён', 'Верхняя одежда', 2);
INSERT INTO Thing (ID, Name, Material, Type, CleaningOrder) VALUES (5, 'Куртка', 'лён', 'Верхняя одежда', 3);

-- Таблица: Type
DROP TABLE IF EXISTS Type;
CREATE TABLE Type(
    Name TEXT PRIMARY KEY,
    Compensation INTEGER NOT NULL CHECK (Compensation < CleaningPrice),
    CleaningPrice INTEGER NOT NULL
);
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
