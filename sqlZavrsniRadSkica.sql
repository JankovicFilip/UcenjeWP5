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

create table mediji(
sifra int not null primary key identity(1,1),
naziv varchar(50) not null,
opis varchar(1000),
vrsta varchar(20),
genre varchar(100)
);

create table komentari(
sifra int not null primary key identity(1,1),
opis varchar(1000),
korisnik int not null,
medij int not null
);

alter table komentari add foreign key(medij) references mediji(sifra);
alter table komentari add foreign key(korisnik) references korisnici(sifra);

select * from korisnici;
insert into korisnici (ime, prezime, username, password) values
('Milo', 'Schwartz', 'magpieluthien', '1234abcd'),
('Damien', 'Elis', 'woodchuckungol', 'abcd1234'),
('Addie', 'Hess', 'snailcirith', 'efgh5678'),
('Caitlyn', 'West', 'ibexedori', '1234'),
('Susan', 'Huber', 'widgeonent', 'abcd');


