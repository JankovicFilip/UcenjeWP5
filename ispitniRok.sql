use master;
go
drop database if exists ispit;
go
create database ispit;
go
use ispit;

create table ispitniRok(
sifra int not null primary key identity(1,1),
predmet varchar(50) not null,
vrstaIspita varchar(20) not null,
datum datetime,
pristupio bit not null
);

create table pristupnici(
ispitniRok int not null,
student varchar(50) not null,
brojBodova int not null,
ocjena int not null
);

alter table pristupnici add foreign key (ispitniRok) references ispitniRok(sifra);

select * from ispitniRok;

insert into ispitniRok (predmet, vrstaIspita, pristupio) values
('Hrvatski jezik', 'Teorijski', 1),
('Matematika', 'Praktični', 0),
('Engleski jezik', 'Teorijski', 1);

select * from pristupnici;
insert into pristupnici (ispitniRok, student, brojBodova, ocjena) values
(1,'John Doe', 69, 3),
(2, 'Jane Johnson', 99, 5),
(3, 'Filip Janković', 100, 5);