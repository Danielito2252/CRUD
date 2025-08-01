CREATE DATABASE Crud_N_Capas
GO
USE Crud_N_Capas
Go
create table Personas(
ID INT PRIMARY KEY,
Nombre NVARCHAR (30),
Apellido NVARCHAR (30),
Sexo NVARCHAR (12)
);
SELECT * FROM Personas

----Procedimiento almacenado
CREATE PROC SP_Mostrar
AS
SELECT * FROM Personas
GO
------Insertar datos
CREATE PROC Sp_Insertar
@ID INT,
@Nombre NVARCHAR(30),
@Apellido Nvarchar (30),
@Sexo Nvarchar (12)
AS
INSERT INTO Personas VALUES (@ID, @Nombre, @Apellido,@Sexo)
GO
