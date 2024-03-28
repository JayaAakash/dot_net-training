use test

select * from employee

-- 1.	Write a query to display your birthday( day of week).

select datename(dw, getdate()) as Birthday_of_week
from employee
where id = '3'
--output:- Thursday


-- 2.	Write a query to display your age in days.
select datediff(day, age, getdate()) as ageindays
from employee
where id = '3';
-- output:- 45354

-- 3.	Write a query to display all employees information those who joined before 5 years in the current month.

select * from employee
where dateadd(year, -5, getdate()) <= joining_date
  and month(joining_date) = month(getdate())
  --output :-
  -- 6	komal	22	mp	    0.00	2020-03-02
  -- 7	muffy	24	indore	0.00	2021-03-02


-- 4.	Create table Employees with empno, ename, sal, doj columns and perform the following operations in a single transaction.

create table employees ( empno int, ename varchar (15), salary decimal (10,2), doj date)

-- a. First insert 3 rows.
begin transaction
 

insert into employees (empno,ename,salary,doj)
values (1,'Aakash',5000,'2021-10-1'),
       (2,'Banurekha',9000,'2000-10-1'),
		(3,'Prakash',6000,'2017-10-1')
select * from employees

-- output :-
--        1	Aakash	    5000.00	    2021-10-01
--        2	Banurekha	9000.00 	2000-10-01
--        3	Prakash	    6000.00 	2017-10-01

--b. Update the second row sal with 15% increment  
update Employees set salary = salary * 1.15
where empno = 2
-- output:-
      -- 1	Aakash	    5000.00	    2021-10-01
      -- 2	Banurekha	10350.00	2000-10-01
      -- 3	Prakash	     6000.00	2017-10-01

-- c. Delete first row.
delete from employees where empno = 1
commit
-- output :-
         --2	Banurekha	10350.00	2000-10-01
       --  3	Prakash	     6000.00	2017-10-01

--After completing above all actions how to recall the deleted row without losing increment of second row.


select * from employees
 rollback  empno = 1
 commit

--   5.Create a user defined function calculate Bonus for all employees of a  given job using 	following conditions

create function CalculateBonus (@deptno int, @salary decimal(10, 2))  
returns decimal(10, 2) as

BEGIN  
   declare @bonus decimal(10, 2);
	
   
    if @deptno = 10

	 -- a.     For Deptno 10 employees 15% of sal as bonus.
        set @bonus = @salary * 0.15;

		-- b.     For Deptno 20 employees  20% of sal as bonus
    else if @deptno = 20
        set @bonus = @salary * 0.20;
		-- 	c      For Others employees 5%of sal as bonus
    else
        set @bonus = @salary * 0.05;

    return @bonus;  
end

-- a.     For Deptno 10 employees 15% of sal as bonus.
select id, name, salary, deptno, dbo.CalculateBonus(deptno, salary) as bonus from employee
where deptno = 10 

--output :-
           --1	ramesh	2000.00	10	300.00
           --5	hardik	8500.00	10	1275.00

 -- b.     For Deptno 20 employees  20% of sal as bonus
select id, name, salary, deptno, dbo.CalculateBonus(deptno, salary) as bonus from employee
where deptno = 20

--output :-
          --2	khilan	1500.00	20	300.00
          --6	komal	0.00	20	0.00


--  c      For Others employees 5%of sal as bonus
select id, name, salary, deptno, dbo.CalculateBonus(deptno, salary) as bonus from employee
where deptno not in (20,10)

--output :-
          -- 3	koushik	    2000.00	30	100.00
          -- 4	chaitali	6500.00	40	325.00
          -- 7	muffy	    0.00	30	0.00