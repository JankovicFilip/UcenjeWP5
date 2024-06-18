--use svastara;

select * from Artikli where  kratkiNaziv like '%PLAFONJERA%' and cijena >= 100 and cijena <=150;


select a.naziv as mjesto, b.naziv as opcina, c.naziv as zupanija
from mjesta a inner join opcine b
on a.opcina = b.sifra
inner join zupanije c
on c.sifra = b.zupanija
where c.naziv like '%baranj%'
order by 1;

select b.naziv as opcina, count(a.sifra) as mjesta
from mjesta a inner join opcine b
on a.opcina = b.sifra
inner join zupanije c
on c.sifra = b.zupanija
where c.naziv like '%split%'
group by b.naziv
order by 2 desc;


select top 5 a.naziv,
sum(c.kolicina*c.cijena) as ukupno,
min(c.kolicina*c.cijena) as minimalno,
max(c.kolicina*c.cijena) as maksimalno
from Dobavljaci a inner join Primke b
on a.sifra = b.dobavljac
inner join ArtikliNaPrimci c
on c.primka = b.sifra
where b.datum between '2017-01-01' and '2017-12-31'
group by a.naziv
having min(c.kolicina*c.cijena) > 0
order by 3 desc, 2 desc;

select distinct a.ime, a.mjesto
from Kupci a inner join Mjesta b
on a.mjesto = b.sifra
where b.naziv = 'Osijek';

select * from Artikli where cijena between 1000 and 1100
order by 6 desc;

-- 52601 artikala
select count(*) from Artikli;

select distinct artikl from ArtikliNaPrimci;

select * from Artikli where
sifra not in (select distinct artikl from ArtikliNaPrimci);

delete from Artikli where 
sifra not in (select distinct artikl from ArtikliNaPrimci);


insert into Kupci(ime,prezime,mjesto,jmbg) values
('Filip','Janković',45691,'1605981302381');

select naziv, count(*)
from mjesta
group by naziv
having count(*)>1
order by 2 desc;