create database tiacessivel
use tiacessivel
	IF OBJECT_ID('dbo.usuario') is null
create table Usuario(Id int identity primary key, Nome varchar(50) not null, DataNascimento date not null, Cpf varchar(14) not null, Sexo varchar(8) not null, Email varchar(50) not null, Celular varchar(11) not null, Whatsapp varchar(3) not null, senha varchar(10))
