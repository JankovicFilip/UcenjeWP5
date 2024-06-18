--use eunovawp5;


--select * from grupe;
select * from clanovi;


select a.naziv as smjer, b.naziv as grupa
from smjerovi a inner join grupe b
on a.sifra = b.smjer


--select a.naziv as smjer, b.naziv as grupa
--from smjerovi a left join grupe b
--on a.sifra = b.smjer


select a.naziv as smjer, b.naziv as grupa, d.ime, d.prezime
from smjerovi a inner join grupe b
on a.sifra = b.smjer
inner join clanovi c  on b.sifra = c.grupa
inner join polaznici d on c.polaznik = d.sifra
where d.ime like 'P%'
order by 4;


-- broj clanova po grupi
select a.naziv, count(b.polaznik) as polaznika
from  grupe a inner join clanovi b
on a.sifra = b.grupa
group by a.naziv;
