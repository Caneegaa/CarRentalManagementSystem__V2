CREATE DATABASE CarRentalManagement ;

USE CarRentalManagement ;

CREATE TABLE Cars (
	CarId NVARCHAR(20) PRIMARY KEY,
	Brand NVARCHAR(20),
	Model NVARCHAR(20),
	RentalPrice Decimal(2)
);