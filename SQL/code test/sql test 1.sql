create database test	

use test

--1. creating table books table

create table books (id int primary key,
    title varchar(40),
    author VARCHAR(45),
    isbn varchar(15) unique,
    publish_date date)

	insert into books(id,title,author,isbn,publish_date)
	values (1,'my first sql book','mary parker',981483029127,'2012-02-22 12:08:17'),
	(2,'my second sql book','john mayer',857300923713,'1972-07-03 09:22:45'),
	(3, 'my third sql book','cary flint',523120967812,'2015-10-18 14:05:44')

	select * from books

	-- query to find the author name end with er
select id, title, author, isbn, publish_date
from books
WHERE author LIKE '%er'



--2. creating table for reviews

create table reviews(
id int ,
    book_id int,
    reviewer_name varchar(30),
    content text,
    rating int,
    publish_date date)

	insert into reviews(id,book_id,reviewer_name,content,rating,publish_date)
	values (1,1,'john smith','my first review',4,'2017-12-10 05:50:11.1'),
	(2,2,'john smith', 'my second review',5,'2017-10-13 15:05:12.6'),
	(3,2,'alice walker','another review',1,'2017-10-22 23:47:10')

	select * from reviews

	--query to find  the Title ,Author and ReviewerName for all the books
	select b.title, b.author, r.reviewer_name
from books b
join reviews r on b.id = r.book_id

--query to find the reviewer name who reviewed more than one book
select reviewer_name
from reviews
group by reviewer_name
having count(book_id) > 1



-- 3. creating table for customers

create table customers(id int ,
    name varchar(15),
    age int,
    address varchar(35),
    salary decimal(6, 2))

	insert into customers(id,name,age,address,salary)
values(1,'ramesh',32,'ahmedabad',2000.00),
(2,'khilan',25,'delhi',1500.00),
(3,'koushik',23,'kota',2000.00),
(4,'chaitali',25,'mumbai',6500.00),
(5,'hardik',27,'bhopal',8500.00),
(6,'komal',22,'mp',4500.00),
(7,'muffy',24,'indore',1000.00)

-- 4. Display the Name for the customer from above customer table  who live in same address which has character o anywhere in address

select name
from customers
where address like '%o%'

--4. creating table for orders

create table orders(
oid int ,
    date date,
    customer_id int,
    amount varchar(8))

	insert into orders(oid,date,customer_id,amount)
	values(102,'2019-10-08 00:00:00',3,3000),
	(100,'2009-10-08 00:00:00',3,1500),
	(101,'2009-11-20 00:00:00',2,1560),
	(103,'2008-05-20 00:00:00',4, 2060)

	--query to display the   Date,Total no of customer  placed order on same Date 

	select date, count(distinct customer_id) as total_customers
from orders
group by date;

-- 5. creating employee table

create table employee(id int ,
    name varchar(15),
    age int,
    address varchar(35),
    salary decimal(6, 2))

	insert into employee(id,name,age,address,salary)
values(1,'ramesh',32,'ahmedabad',2000.00),
(2,'khilan',25,'delhi',1500.00),
(3,'koushik',23,'kota',2000.00),
(4,'chaitali',25,'mumbai',6500.00),
(5,'hardik',27,'bhopal',8500.00),
(6,'komal',22,'mp',0),
(7,'muffy',24,'indore',0)


--query for names of the Employee in lower case, whose salary is null 

select lower(name) as lower_case_name
from employee
where salary is null


--6. creating table for studentdetails

create table studentdetails( registerno int,
    name varchar(255),
    age int,
    qualification varchar(20),
    mobileno varchar(15),
    mail_id VARCHAR(20),
    location varchar(20),
    gender varchar(8))

	insert into studentdetails(registerno,name,age,qualification,mobileno,mail_id,location,gender)
	values (3,'kumar',20,'b.e','9952835777','sai@gmail.com','chennai','m'),
	 (3,'selvi',22,'b.e','9952835777','sai@gmail.com','chennai','m'),
	  (4,'sai',22,'b.e','9952835777','sai@gmail.com','chennai','f'),
	  (5,'nisha',22,'b.e','9952835777','sai@gmail.com','chennai','f'),
	  (6,'saisaran',22,'b.e','9952835777','sai@gmail.com','chennai','f'),
	  (7,'tom',22,'b.e','9952835777','sai@gmail.com','chennai','m')
	 
	 --query to see gender count

	select gender, count(*) as total_students
from studentdetails
group by gender;

create table EmpAudit1(Message varchar(max))
 
create trigger trgAuditDelete
on Employee for delete
as
	begin
		declare @id int
		select @id=empno from deleted
 
		insert into Empaudit1
		values('New Employee with Id  :  '+cast(@id as varchar(20))+
		     	' is deleted  '+cast(getdate()as nvarchar(10)))
	end
 
delete  from Employee where Empno=1111
select * from Empaudit1