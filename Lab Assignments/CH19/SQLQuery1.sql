--select book_code, title 
--from book; 

--select * 
--from publisher;

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

--select book.title, book.BOOK_CODE, book.PRICE, publisher.PUBLISHER_NAME
--from book
--join publisher on book.PUBLISHER_CODE = publisher.PUBLISHER_CODE
--where publisher.PUBLISHER_NAME = 'Plume' and book.price >= 14

--select book.book_code, book.title, inventory.ON_HAND, branch.BRANCH_NUM
--from ((book
--join inventory on book.BOOK_CODE = INVENTORY.BOOK_CODE)
--join branch on inventory.BRANCH_NUM = branch.BRANCH_NUM)
--where branch.BRANCH_NUM = 4

--select book.title, book.type, publisher.PUBLISHER_NAME
--from book
--join publisher on book.PUBLISHER_CODE = publisher.PUBLISHER_CODE
--where book.type = 'PSY' and publisher.PUBLISHER_NAME = 'Jove Publications';


--select book.title
--from book
--join wrote on book.book_code = wrote.book_code
--join author on wrote.Author_num = author.AUTHOR_NUM
--where author.author_num = 18

--select title
--from book
--where book_code in (select book_code from wrote where author_num = 18)

--select title 
--from book
--where exists (select book_code from wrote where wrote.book_code = book.book_code 
--and wrote.AUTHOR_NUM = 18)

--select book.BOOK_CODE, book.title
--from book
--join wrote on book.BOOK_CODE = wrote.BOOK_CODE
--join author on wrote.AUTHOR_NUM = author.AUTHOR_NUM
--join inventory on WROTE.BOOK_CODE = inventory.BOOK_CODE
--join branch on inventory.BRANCH_NUM = branch.BRANCH_NUM
--where author.AUTHOR_NUM = 20 and branch.BRANCH_NUM = 2;

--select bk1.book_code AS book1, bk2.book_code AS book2
--from book bk1
--join book bk2 on bk1.price = bk2.price
--and bk1.book_code < bk2.BOOK_CODE
--order by bk1.book_code, bk2.book_code;

--select book.title, author.AUTHOR_LAST,inventory.ON_HAND
--from book
--join wrote on book.BOOK_CODE = wrote.BOOK_CODE
--join author on wrote.AUTHOR_NUM = author.AUTHOR_NUM
--join inventory on wrote.BOOK_CODE = inventory.BOOK_CODE
--join branch on inventory.BRANCH_NUM = branch.BRANCH_NUM
--where branch.BRANCH_NUM = 4

--select book.title, AUTHOR.AUTHOR_LAST, inventory.ON_HAND
--from book
--join wrote on book.BOOK_CODE = wrote.BOOK_CODE
--join author on wrote.AUTHOR_NUM = author.AUTHOR_NUM
--join inventory on wrote.BOOK_CODE = inventory.BOOK_CODE
--join branch on inventory.BRANCH_NUM = branch.BRANCH_NUM
--where branch.BRANCH_NUM = 4
--and book.PAPERBACK = 'Y'

--select book_code, title, price, city
--from book
--join publisher on book.PUBLISHER_CODE = publisher.PUBLISHER_CODE
--where publisher.city = 'Boston'
--and book.price > 10

--select book_code , title, price
--from book
--where PRICE > 10
--union
--select city 
--from publisher
--where city = 'Boston'

--select book.book_code , title, price
--from book
--join PUBLISHER on book.PUBLISHER_CODE = publisher.PUBLISHER_CODE
--where publisher.city = 'Boston'
--union
--select book.book_code , title, price
--from book
--join PUBLISHER on book.PUBLISHER_CODE = publisher.PUBLISHER_CODE
--where book.price > 10

--select book.book_code,book.title, book.price
--from book
--join publisher on book.PUBLISHER_CODE = publisher.PUBLISHER_CODE
--where not publisher.city = 'Boston'
--and price > 10

--select book.book_code, book.title, book.price
--from book
--where price > All (select price from book where type = 'HOR')


--select book_code, title price
--from book
--where price > ANY (select price from book where type = 'HOR')

select book.book_code, book.title,INVENTORY.ON_HAND
from book
left join inventory on book.book_code = inventory.book_code
and inventory.branch_num = 2
order by book.book_code;








