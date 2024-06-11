-- select * from smjerovi;

-- filtriranje kolona
-- * sve kolone
-- naziv kolone, konstanta i izraz

--select naziv, cijena, *,
--'Osijek' as grad,2 as broj,
--getdate() as datum from smjerovi;



-- filtriranja redova

select * from polaznici;

-- where klauzula
-- operatori = , != razlicito

select * from polaznici where ime = 'Luka';

select * from polaznici where ime != 'Luka';

-- < > >= <=
select * from polaznici where sifra < 5;

-- logicki operatori
-- and, or, not
-- boolean operatori
select ime, prezime from polaznici where sifra > 5 and sifra < 10;

select * from polaznici where sifra = 1 or sifra = 2;

select * from polaznici where not sifra = 2

-- ostali operatori
-- like

select * from polaznici where ime not like '%a%';

select * from polaznici where ime like '%a%';

-- descending
select ime from polaznici where ime like '%a%'
order by ime desc;

-- distinct radi da ako ima 2 filipa, pokaze jednog
select distinct ime from polaznici where ime like '%a%'
order by ime desc;

select * from polaznici where ime like '%a';

select * from polaznici where prezime like 'm%';

-- in
-- umjesto da se pise or puno puta
select * from polaznici where sifra in (2,7,12,25);

select * from polaznici where not sifra in (2,7,12,25);

-- between
-- umjesto >= and <=
select * from polaznici where sifra between 2 and 8;

-- na null vrijednosti se uvijek ide sa dva operator: is null ili is not null
select * from smjerovi where izvodiseod is  not null;