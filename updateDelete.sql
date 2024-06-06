--select * from smjerovi where sifra=2;

--update smjerovi set izvodiseod='2024-06-06 19:10' where sifra=2;

--update smjerovi set cijena = 999.42 , vaucer=0 where sifra=3;

--select * from smjerovi;
--update smjerovi set cijena = cijena * 0.9;
--select * from smjerovi;

--select * from smjerovi;
--update smjerovi set cijena = cijena * 1.065;
--select * from smjerovi;

--select * from smjerovi;
--update smjerovi set cijena = cijena - 10;
--select * from smjerovi;

select * from polaznici;
update polaznici set oib = '07759048912' where sifra = 5;
select * from polaznici;

select * from grupe;

--update grupe set smjer = 11 where sifra = 1;

delete from smjerovi;

delete from grupe;

delete from clanovi;