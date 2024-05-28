use master;
go
drop database if exists zavrsniskica;
go
create database zavrsniskica;
go
use zavrsniskica;

create table korisnici(
sifra int not null primary key identity(1,1),
ime varchar(50) not null,
prezime varchar(50) not null,
username varchar(50) not null,
password varchar(50) not null
);

create table shows(
sifra int not null primary key identity(1,1),
naziv varchar(50) not null,
opis varchar(1000),
komentar int not null
);

create table komentari(
sifra int not null primary key identity(1,1),
opis varchar(1000),
korisnik int not null
);

alter table shows add foreign key(komentar) references komentari(sifra);
alter table komentari add foreign key(korisnik) references korisnici(sifra);