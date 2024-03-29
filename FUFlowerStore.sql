DROP TABLE Supplier;
DROP TABLE Category;
DROP TABLE FlowerBouquet;
DROP TABLE Customer;
DROP TABLE [Order];
DROP TABLE OrderDetail;

CREATE TABLE Supplier(
	SupplierID varchar(5) PRIMARY KEY,
	SupplierName varchar(20),
	SupplierAddress varchar(50),
	SupplierTelephone varchar(15),
);

CREATE TABLE Category(
	CategoryID varchar(5) PRIMARY KEY,
	CategoryName varchar(20),
	CategoryDescription varchar(50),
	CategoryNote varchar(50),
);

CREATE TABLE FlowerBouquet(
	FlowerBouquetID varchar(5) PRIMARY KEY,
	CategoryID varchar(5),
	FlowerBouquetName varchar(20), 
	[Description] varchar(50),
	UnitPrice float,
	UnitsInStock float,
	FlowerBouquetStatus bit,
	SupplierID varchar(5),
	Morphology varchar(50),
	FOREIGN KEY (CategoryID) REFERENCES Category(CategoryID),
	FOREIGN KEY (SupplierID) REFERENCES Supplier(SupplierID)
);

CREATE TABLE Customer(
	CustomerID varchar(5) PRIMARY KEY,
	Email varchar(40),
	CustomerName varchar(20),
	City varchar(15),
	Country varchar(15),
	[Password] varchar(15),
	Birthday varchar(15),
	CustomerStatus bit,
);

CREATE TABLE [Order](
	OrderID varchar(5) PRIMARY KEY,
	CustomerID varchar(5),
	OrderDate date,
	ShippedDate date, 
	Total float, 
	OrderStatus bit,
	FOREIGN KEY (CustomerID) REFERENCES Customer(CustomerID)
);

CREATE TABLE OrderDetail(
	OrderID varchar(5),
	FlowerBouquetID varchar(5),
	UnitPrice float,
	Quanity int,
	Discount float,
	FOREIGN KEY (OrderID) REFERENCES [Order],
	FOREIGN KEY (FlowerBouquetID) REFERENCES FlowerBouquet(FlowerBouquetID)
);

