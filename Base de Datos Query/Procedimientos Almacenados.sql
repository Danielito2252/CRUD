
----PROCEDIMIENTO ALMACENADO
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

------Actualizar Datos
CREATE PROC Sp_Modificar
@ID INT,
@Nombre NVARCHAR(30),
@Apellido Nvarchar (30),
@Sexo Nvarchar (12)
AS
UPDATE Personas SET Nombre = @Nombre, Apellido = @Apellido, Sexo = @Sexo
WHERE ID = @ID
GO
---------ELIMINAR REGISTROS
CREATE PROC Sp_Eliminar
@ID INT
AS
DELETE Personas WHERE ID = @ID
GO

--------BUSCAR DATOS
CREATE PROC Sp_Buscar
@Buscar NVARCHAR(30)
AS
SELECT * FROM Personas
WHERE Nombre LIKE @Buscar + '%'
GO



