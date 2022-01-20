CREATE DATABASE Helperland
USE Helperland

/* Customer Table */
CREATE TABLE Customer
(
ID INT IDENTITY (1,1)  PRIMARY KEY NOT NULL , 
Firstname VARCHAR(20) NOT NULL ,
Lastname VARCHAR(20) NOT NULL ,
Email_id VARCHAR(30) NOT NULL UNIQUE,
Phone_no VARCHAR(15) NOT NULL UNIQUE,
Birthdate DATE ,
Language VARCHAR(15),
Password VARCHAR(30) NOT NULL
)

/* Service Provider Table */

CREATE TABLE  Service_provider
(
ID INT IDENTITY (1,1) NOT NULL PRIMARY KEY , 
Firstname VARCHAR(20) NOT NULL ,
Lastname VARCHAR(20) NOT NULL ,
Email_id VARCHAR(30) NOT NULL UNIQUE,
Phone_no VARCHAR(15) NOT NULL UNIQUE,
Birthdate DATE ,
Nationality VARCHAR(15),
Gender CHAR(1) NOT NULL,
Avtar VARBINARY(MAX),
House_no INT,
Street VARCHAR(50),
Postal_code VARCHAR(10),
City VARCHAR(50),
Status BIT NOT NULL DEFAULT '0',
Password VARCHAR(30) NOT NULL,
)

/* Admin Table */

CREATE TABLE  Admin
(
ID INT IDENTITY (1,1) NOT NULL PRIMARY KEY , 
Firstname VARCHAR(20) NOT NULL ,
Lastname VARCHAR(20) NOT NULL ,
Email_id VARCHAR(30) NOT NULL UNIQUE,
Password VARCHAR(30) NOT NULL
)


/* Role Table */

CREATE TABLE Role
(
ID INT NOT NULL PRIMARY KEY , 
Type VARCHAR(20) NOT NULL
)
/* Credentials Table */

CREATE TABLE Credential
(
Email_id VARCHAR(30)  NOT NULL PRIMARY KEY , 
Password VARCHAR(30) NOT NULL,
Role INT NOT NULL FOREIGN KEY REFERENCES Role(ID)
)
/* Service_provider_Serving_area Table */
CREATE TABLE Service_provider_Serving_area
(

ID INT  FOREIGN KEY REFERENCES  Service_provider(ID)NOT NULL,
Postal_code VARCHAR(10) NOT NULL,
Radius INT NOT NULL

)


/* Customer address Table */

CREATE TABLE  Customer_address
(
ID INT IDENTITY (1,1) NOT NULL PRIMARY KEY , 
Customer_ID INT NOT NULL FOREIGN KEY REFERENCES  Customer(ID),
House_no INT,
Street VARCHAR(50),
Postal_code VARCHAR(10),
City VARCHAR(50),
Phone_no VARCHAR(15) NOT NULL,
)

/* Status Table */

CREATE TABLE  Status
(
ID INT NOT NULL  PRIMARY KEY , 
Name VARCHAR(10)
)

/* Service Table */

CREATE TABLE  Service
(
ID INT IDENTITY (1,1) NOT NULL PRIMARY KEY , 
Customer_ID INT NOT NULL FOREIGN KEY REFERENCES  Customer(ID),
Service_provicer_ID INT  FOREIGN KEY REFERENCES  Service_provider(ID),
Date DATE NOT NULL ,
Start_time TIME NOT NULL,
Duration TIME NOT NULL,
Extra_service VARCHAR(50),
Comment VARCHAR(50) ,
Pet BIT NOT NULL,
Total_price FLOAT NOT NULL,
Address_id INT NOT NULL FOREIGN KEY REFERENCES  Customer_address(ID),
Status INT NOT NULL FOREIGN KEY REFERENCES  Status(ID),
)

/* Service Provider Rating Table */

CREATE TABLE  Sp_rating
(
ID INT IDENTITY (1,1) NOT NULL PRIMARY KEY , 
Customer_ID INT NOT NULL FOREIGN KEY REFERENCES  Customer(ID),
Service_provicer_ID INT NOT NULL FOREIGN KEY REFERENCES  Service_provider(ID),
Rating FLOAT NOT NULL ,
Comment VARCHAR(50),
)

/* Favourite table */

CREATE TABLE  Favourite
(
ID INT IDENTITY (1,1) NOT NULL PRIMARY KEY , 
Customer_ID INT NOT NULL FOREIGN KEY REFERENCES  Customer(ID),
Service_provicer_ID INT NOT NULL FOREIGN KEY REFERENCES  Service_provider(ID)
)


