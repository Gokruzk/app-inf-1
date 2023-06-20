CREATE DATABASE DatosProduc
Use DatosProduc

CREATE TABLE Productos(
    idProd int identity (1,1) primary key,
    NombrePro varchar(80) not null,
    Precio int not null,
    Cantidad int not null,
    Iva int not null,
    TotalPrecio float not null
)