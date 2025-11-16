create database Final_Project
use Final_Project

create table loggin
(TeleNo varchar(10) primary key,
PW varchar(10))

insert into loggin values ('0774361544','Kd2006')
select* from loggin
-------------------------------------------------------------------------------

create table admin_login
(UN varchar(15) primary key,
PWD varchar (15))

insert into admin_login values ('bk1982','1982')
select* from admin_login
-------------------------------------------------------------------------------

create table registrations
(CusName varchar(35),
TeleNo varchar(10) primary key,
Address varchar(50),
Email varchar(22))

select* from registrations
-------------------------------------------------------------------------------

create table ordering
(OrdID int primary key,
CusName varchar(35),
TeleNo varchar(10),
Address varchar(50),
Email varchar(22))

select* from ordering
--------------------------------------------------------------------------------

create table admin_registrations
(TeleNo varchar(10) primary key,
CasName varchar(25),
Branch varchar (35))

select* from admin_registrations

create table items
(ItemName varchar (50) primary key)
