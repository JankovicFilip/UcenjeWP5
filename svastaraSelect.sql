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