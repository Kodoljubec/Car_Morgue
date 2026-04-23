Create table Engine (
EngineID int identity primary key,
cubic_capacity decimal,
Fuel varchar(30),
CarID int
)
Create table Cars(
vinID int primary key,
Make varchar(30),
Model varchar(30),
Year INT,
engineID int,
foreign key (engineID) references Engine(EngineID)
)
Create table Parts(
ID int identity primary key,
Part varchar(30),
Category varchar(30),
Price Decimal,
CarID int,
foreign key(CarID) references Cars(vinID)
);
Create table Clients(
ID int identity primary key,
Name varchar(30),
PhoneNumber char(10),
Email varchar(33),
Address varchar (50)
);
Create table Sales(
SalesID int identity primary key,
Date date,
CustomerID int,
PartsID int,
foreign key (CustomerID) references Clients (ID),
foreign key (PartsID) references Parts(ID)
);

INSERT INTO Engine (cubic_capacity, Fuel) VALUES
(1.2, 'Petrol'),
(1.4, 'Petrol'),
(1.6, 'Diesel'),
(1.8, 'Petrol'),
(2.0, 'Diesel'),
(2.2, 'Diesel'),
(2.5, 'Petrol'),
(3.0, 'Diesel'),
(3.5, 'Petrol'),
(4.0, 'Petrol');

INSERT INTO Cars (vinID, Make, Model, Year, engineID) VALUES
(1001, 'BMW', 'E46', 2003, 1),
(1002, 'Audi', 'A3', 2004, 2),
(1003, 'VW', 'Golf 5', 2006, 3),
(1004, 'Ford', 'Focus', 2008, 4),
(1005, 'Opel', 'Astra H', 2007, 5),
(1006, 'Toyota', 'Corolla', 2009, 6),
(1007, 'Honda', 'Civic', 2010, 7),
(1008, 'Mercedes', 'C220', 2012, 8),
(1009, 'Nissan', 'Altima', 2015, 9),
(1010, 'Mazda', '6', 2016, 10);

INSERT INTO Parts (Part, Category, Price, CarID) VALUES
('Brake Pads', 'Brakes', 120.00, 1001),
('Oil Filter', 'Engine', 25.00, 1002),
('Air Filter', 'Engine', 30.00, 1003),
('Spark Plug', 'Ignition', 15.00, 1004),
('Fuel Pump', 'Fuel System', 200.00, 1005),
('Radiator', 'Cooling', 180.00, 1006),
('Clutch Kit', 'Transmission', 350.00, 1007),
('Battery', 'Electrical', 220.00, 1008),
('Alternator', 'Electrical', 270.00, 1009),
('Starter', 'Electrical', 260.00, 1010);

alter table Engine
drop column CarID

select * from Engine

INSERT INTO Clients (Name, PhoneNumber, Email, Address) VALUES
('Ivan Ivanov', '0888000001', 'ivan1@email.com', 'Sofia'),
('Petar Petrov', '0888000002', 'petar2@email.com', 'Plovdiv'),
('Georgi Georgiev', '0888000003', 'georgi3@email.com', 'Varna'),
('Dimitar Dimitrov', '0888000004', 'dimi4@email.com', 'Burgas'),
('Stoyan Stoyanov', '0888000005', 'stoyan5@email.com', 'Ruse'),
('Nikola Nikolov', '0888000006', 'nikola6@email.com', 'Stara Zagora'),
('Ivan Petrov', '0888000007', 'ivan7@email.com', 'Pleven'),
('Hristo Hristov', '0888000008', 'hristo8@email.com', 'Dobrich'),
('Todor Todorov', '0888000009', 'todor9@email.com', 'Shumen'),
('Vasil Vasilev', '0888000010', 'vasil10@email.com', 'Sliven');


INSERT INTO Sales (Date, CustomerID, PartsID) VALUES
('2026-04-01', 1, 1),
('2026-04-02', 2, 2),
('2026-04-03', 3, 3),
('2026-04-04', 4, 4),
('2026-04-05', 5, 5),
('2026-04-06', 6, 6),
('2026-04-07', 7, 7),
('2026-04-08', 8, 8),
('2026-04-09', 9, 9),
('2026-04-10', 10, 10);