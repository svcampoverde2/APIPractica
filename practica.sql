
create database practica;
create table cliente(
idCliente int identity(1,1) primary key,
cedula varchar(10) not null,
nombres varchar(45) not null,
apellidos varchar(45) not null, 
direccion varchar(60) not null,
edad int not null,
idCiudad int not null,
estado varchar(8)not null);


create table ciudad(
id_ciudad int identity(1,1) primary key,
nombreCiudad varchar(45) not null,
estado varchar(8) not null);

insert into cliente(cedula, nombres, apellidos, direccion, edad, idCiudad, estado)
values('0988765442', 'Jose', 'Jaramillo', '9 de octubre', 34, 1, 'A');
insert into cliente(cedula, nombres, apellidos, direccion, edad, idCiudad, estado)
values('0988765555', 'Maritza', 'Arrollo', 'Ximena', 45, 2, 'A');
insert into cliente(cedula, nombres, apellidos, direccion, edad, idCiudad, estado)
values('0922765442', 'Juan', 'Lopez', 'Aguita', 25, 3, 'A');
insert into cliente(cedula, nombres, apellidos, direccion, edad, idCiudad, estado)
values('0988768855', 'Karen', 'Ludeña', 'Juan montalvo', 30, 4, 'A');
insert into cliente(cedula, nombres, apellidos, direccion, edad, idCiudad, estado)
values('0922763242', 'Angel', 'Velez', 'Aloa', 54, 5, 'A');
insert into cliente(cedula, nombres, apellidos, direccion, edad, idCiudad, estado)
values('0988558855', 'Erika', 'Gonzales', 'Guasmo', 44, 2, 'A');

insert into cliente(cedula, nombres, apellidos, direccion, edad, idCiudad, estado)
values('0988765122', 'Melany', 'Astudilo', 'Marcel Laneado', 18, 1, 'A');
insert into cliente(cedula, nombres, apellidos, direccion, edad, idCiudad, estado)
values('0988799555', 'Jaime', 'Arreaga', 'Centenarrio', 25, 2, 'A');
insert into cliente(cedula, nombres, apellidos, direccion, edad, idCiudad, estado)
values('0922115442', 'Pedro', 'Campos', 'Tomebamba', 45, 3, 'A');
insert into cliente(cedula, nombres, apellidos, direccion, edad, idCiudad, estado)
values('0999768855', 'Carmen', 'Correa', 'Catamayo', 20, 4, 'A');
insert into cliente(cedula, nombres, apellidos, direccion, edad, idCiudad, estado)
values('0926563242', 'Angela', 'Alvarez', 'Arbolito', 48, 5, 'A');
insert into cliente(cedula, nombres, apellidos, direccion, edad, idCiudad, estado)
values('0988576855', 'Mario', 'Gonzales', 'Guasmo', 64, 2, 'A');

insert into ciudad(nombreCiudad, estado)values('Machala', 'A');
insert into ciudad(nombreCiudad, estado)values('Guayaquil', 'A');
insert into ciudad(nombreCiudad, estado)values('Cuenca', 'A');
insert into ciudad(nombreCiudad, estado)values('Loja', 'A')
insert into ciudad(nombreCiudad, estado)values('Quito', 'A')
select *from ciudad;
