create database moviestv;
use moviestv;
create table series (
id int primary key auto_increment,
Titulo varchar(100) not null,
Genero varchar(100) not null,
Autor varchar(100) not null,
Duracion varchar(100)
);
insert into series (Titulo, Genero, autor, Duracion)
values ('Depredador2', 'Accion', 'Jon wick', '2:00');
insert into series (Titulo, Genero, autor, Duracion)
values ('Fantasma', 'Accion', 'will rock', '1:00');
insert into series (Titulo, Genero, autor, Duracion)
values ('Animales salvajes', 'Flora', 'elon musk', '3:30');
insert into series (Titulo, Genero, autor, Duracion)
values ('El hombre calculador', 'mate', 'elon ', '3:00');
select * from series;

