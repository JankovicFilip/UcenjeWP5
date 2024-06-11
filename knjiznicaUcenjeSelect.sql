-- select top 10 percent * from autor;

select distinct ime from autor
where ime not like '%a%'
and ime like 't%'
and ime not like '%o%'
order by ime;