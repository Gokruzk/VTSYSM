create database votaciones;
/*create database jama;*/
/*select * from votantes;*/
use votaciones;
/*
drop table listaa;

select * from listaa;
select * from listab;
select * from listac;
select * from blancos;
select * from nulos;

insert into institucion values(1, "xd");
insert into blancos values(default, 1);
insert into nulos values(default, 1);

select * from presidentes;
select * from vicepresidentes;
select * from votantes;
select * from num_listas;

delete from presidentes where cedula='0877777777';
delete from vicepresidentes where cedula='0888888888';
delete from num_listas where id = 6;
delete from listaa where id <> 1;
delete from num_listas;

truncate num_listas;

SET SQL_SAFE_UPDATES = 0;
update votantes set estado = "sin votar";
*/
create table institucion(
	id int primary key,
	nombre varchar(100)
);

/*select * from presidentes;*/

create table nulos(
id int auto_increment primary key,
null_votos int
);

create table blancos(
id int auto_increment primary key,
blancos_votos int
);

create table votantes(
	CEDULA char(10) primary key,
    NOMBRES varchar(30),
    APELLIDOS varchar(30),
    ESTADO varchar(10)
);

create table num_listas(
id int primary key auto_increment,
numero int,
letra char(1)
);

create table presidentes(
CEDULA char(10) primary key,
NOMBRES varchar(30),
APELLIDOS varchar(30),
LISTA char(1)
);

create table vicepresidentes(
CEDULA char(10) primary key,
NOMBRES varchar(30),
APELLIDOS varchar(30),
LISTA char(1)
);

insert into institucion values(1, "-editar nombre de institucion en configuracion-");
insert into blancos values(default, 1);
insert into nulos values(default, 1);




