use master;
go
drop database if exists trgovinaOdjecom;
go
create database trgovinaOdjecom collate Croatian_CI_AS;
go
use trgovinaOdjecom;


create table svekar(
sifra int not null primary key identity(1,1),
bojaociju varchar(40) not null,
prstena int,
dukserica varchar(41),
lipa decimal(13,8),
eura decimal(12,7),
majica varchar(35)
);

create table sestra(
sifra int not null primary key identity(1,1),
introvertno bit,
haljina varchar(31) not null,
maraka decimal(16,6),
hlace varchar(46) not null,
narukvica int not null
);

create table sestra_svekar(
sifra int not null primary key identity(1,1),
sestra int not null foreign key references sestra(sifra),
svekar int not null foreign key references svekar(sifra)
);

create table zena(
sifra int not null primary key identity(1,1),
treciputa datetime,
hlace varchar(46),
kratkamajica varchar(31) not null,
jmbag char(11) not null,
bojaociju varchar(39) not null,
haljina varchar(44),
sestra int not null foreign key references sestra(sifra)
);

create table muskarac(
sifra int not null primary key identity(1,1),
bojaociju varchar(50) not null,
hlace varchar(30),
modelnaucala varchar(43),
maraka decimal(14,5),
zena int not null foreign key references zena(sifra)
);

create table mladic(
sifra int not null primary key identity(1,1),
suknja varchar(50) not null,
kuna decimal(16,8) not null,
drugiputa datetime,
asocijalno bit,
extroventno bit not null,
dukserica varchar(48) not null,
muskarac int foreign key references muskarac(sifra)
);


create table punac(
sifra int not null primary key identity(1,1),
ogrlica int,
gustoca decimal(14,9),
hlace varchar(41) not null
);

create table cura(
sifra int not null primary key identity(1,1),
novcica decimal(16,5) not null,
gustoca decimal (18,6) not null,
lipa decimal(13,10),
ogrlica int not null,
bojakose varchar(38),
suknja varchar(36),
punac int foreign key references punac(sifra)
);


insert into sestra(haljina,hlace,narukvica) values
('Prada','Adidas',1),
('Armani','Nike',2),
('Gucci','Puma',3);

insert into svekar(bojaociju) values
('Plava'),
('Siva'),
('Crna');

insert into sestra_svekar(sestra,svekar) values
(1,1),
(2,2),
(3,3);

insert into zena(kratkamajica,jmbag, bojaociju,sestra) values
('Plava','10090043012','Smeđa',1),
('Siva','10090043042','Plava',2),
('Crna','10090043042','Crna',3);

insert into muskarac(bojaociju,maraka,zena) values
('Plava',12.92,1),
('Crna',12.33,2),
('Siva',12.44,3);

insert into punac(hlace) values
('bla'),
('blabla'),
('blablabla');

insert into cura (novcica,gustoca,ogrlica) values 
(12.22,13.33,1),
(12.33,13.44,2),
(13.22,11.22,3);

update cura set gustoca = 15.77;

insert into mladic(suknja,kuna,extroventno,dukserica) values
('Asd',17.55,0,'Bla'),
('WASD',13.44,1,'Blaasd'),
('DSA',13.55,1,'Blabla');

delete from mladic where kuna > 15.78;

select kratkamajica from zena where hlace like '%ana%';

select dukserica from svekar;

select a.dukserica, e.hlace
from svekar a inner join sestra_svekar b
on a.sifra = b.svekar
inner join sestra c on b.sestra = c.sifra 
inner join zena d on c.sifra = d.sestra
inner join muskarac e on d.sifra = e.zena
where d.hlace like '%a%' and c.haljina like '%ba%'
order by 2 desc;


select a.haljina, a.maraka
from sestra a inner join sestra_svekar b
on a.sifra = b.sestra
inner join svekar c on c.sifra = b.svekar
where
a.sifra not in (select distinct b.sestra from sestra_svekar);
