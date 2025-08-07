--select book_code, title from book; 
--select * from publisher;

--select distinct publisher_name
--from publisher
--where city = 'Boston';

--select distinct publisher_name 
--from publisher 
--where City not in ('Boston');


--select branch_name
--from branch
--where NUM_EMPLOYEES >= 9

--select book_code, title
--from book 
--where type = 'SFI' 

--select book_code, title
--from book 
--where type = 'SFI' and paperback = 'Y';

--select book_code, title 
--from book
--where type = 'SFI' or PUBLISHER_CODE= 'SC';

--select book_code, title, price
--from book 
--where price between 20 and 30;


--select book_code, title
--from book
--where type = 'MYS' and price < 20;


--select book_code, title, price * 0.9 as discounted_price
--from book

--select publisher_name
--from publisher
--where publisher_name like '% and %'

--select book_code, title 
--from book
--where type = 'SFI' or type = 'MYS' or type = 'ART' 

--select book_code, title 
--from book
--where type = 'SFI' or type = 'MYS' or type = 'ART' 
--order by title;

--select book_code, title, price 
--from book
--where type = 'SFI' or type = 'MYS' or type = 'ART' 
--order by price DESC, title;

--select distinct type 
--from book

--select count (*) 
--from book
--where type = 'SFI'


--select type, avg(price) 
--from book 
--group by type

--select type, avg(price)
--from book 
--where paperback = 'Y'
--group by type

--select type, avg(price)
--from book 
--where paperback = 'Y'	
--group by type
--having avg(price) > 10

--select * 
--from book
--where price = (select max(price) from book) 

--select title, price 
--from book
--where price = (select min(price) from book)

--select sum (NUM_EMPLOYEES) 
--from branch

--select book.book_code, book.title, publisher.publisher_code, publisher.publisher_name
--from book
--join publisher on book.PUBLISHER_CODE = publisher.PUBLISHER_CODE


--select book.book_code, book.title, book.price, publisher.PUBLISHER_NAME
--from book
--join publisher on book.publisher_code = publisher.PUBLISHER_code
--where publisher.publisher_name = 'Plume'



			





