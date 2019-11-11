create database mvccruddb;
use mvccruddb;

create table IF NOT EXISTS product(
ProductID INT NOT NULL AUTO_INCREMENT,
ProductName VARCHAR(50),
Price DECIMAL,
Count INT,
PRIMARY KEY(ProductID)
);
