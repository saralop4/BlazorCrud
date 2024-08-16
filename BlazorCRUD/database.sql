CREATE DATABASE BlazorCRUD;

use BlazorCRUD;

create table Clientes(
id int primary key identity(1,1),
nombre varchar(80) not null,
correo varchar(80)not null,
telefono varchar(20) not null,
fecha datetime not null
)

---------------------------
GO
CREATE PROCEDURE [dbo].[GuardarCliente]
@Nombre varchar(80),
@Correo varchar (80),
@Telefono varchar(20),
@Fecha datetime

AS
BEGIN

INSERT INTO dbo.Clientes(nombre, correo, telefono, fecha) VALUES (@Nombre,@Correo,@Telefono,@Fecha)

END

GO
--------------------------------------

CREATE PROCEDURE [dbo].[ListarClientes]

AS
BEGIN

select * from dbo.Clientes

END

GO
-------------------------------