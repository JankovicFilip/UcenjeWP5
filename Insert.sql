select * from smjerovi;

-- skolska sintaksa
-- 1 -> ovo je sifra koju generira baza
insert into smjerovi (naziv,cijena,brojsati,izvodiseod,vaucer)
values ('Web programiranje',1599.99,225,'2024-02-07 18:00', 1);


-- losa sintaksa
-- 2
insert into smjerovi values ('Web dizajn',1200,150,null,null);

-- mvp
-- 3
insert into smjerovi (naziv) values ('ččččšđ');

select * from grupe;
--1
insert into grupe (naziv, brojslobodnihmjesta, smjer)
values ('WP5',26,1);
--2
insert into grupe (naziv, brojslobodnihmjesta, smjer)
values ('WD1',16,2);

select * from polaznici;

insert into polaznici (ime, prezime, email) values
('Filip','Janković','filip.vno.jankovic@gmail.com'),
('Hrvoje','Trdin','hthrvojetrdin@gmail.com');
