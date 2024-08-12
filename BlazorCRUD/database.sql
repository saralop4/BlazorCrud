CREATE DATABASE BlazorCRUD;

use BlazorCRUD;

create table Clientes(
id int primary key identity(1,1),
nombre varchar(80) not null,
correo varchar(80)not null,
telefono varchar(20) not null,
fecha datetime not null
)