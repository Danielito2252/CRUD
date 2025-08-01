CREATE DATABASE Crud_N_Capas
GO

USE Crud_N_Capas
GO

create table Personas(
ID INT PRIMARY KEY,
Nombre NVARCHAR (30),
Apellido NVARCHAR (30),
Sexo NVARCHAR (12)
);
SELECT * FROM Personas