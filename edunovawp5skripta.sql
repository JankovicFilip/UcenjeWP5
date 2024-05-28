
use master;
go
drop database if exists edunovawp5;
go
create database edunovawp5;
go
use edunovawp5;

create table smjerovi(
sifra int not null primary key identity(1,1),
naziv varchar(50) not null,
cijena decimal(18,2),
brojsati int,
izvodiseod datetime,
vaucer bit
);

--create table grupe(
--sifra int,
--naziv varchar(20),
--brojslobodnihmjesta int,
--datumpocetka datetime,
--smjer int,
--predavac varchar(50)
--);

--create table polaznici(
--sifra int,
--ime varchar(50),
--prezime varchar(50),
--email varchar(100),
--oib char(11)
--);

--create table clanovi(
--grupa int,
--polaznik int
--);



