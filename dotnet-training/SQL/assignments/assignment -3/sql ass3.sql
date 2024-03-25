use ass2
select * from employees
-- 1. Retrieve a list of MANAGERS. 
select * from employees where job = 'manager'

-- 2. Find out the names and salaries of all employees earning more than 1000 per month.
select ename,salary from employees where salary > 1000

-- 3. Display the names and salaries of all employees except JAMES. 
select ename,salary from employees where ename <> 'james'

-- 4.Find out the details of employees whose names begin with ‘S’.
select * from employees where ename like 's%'

-- 5. Find out the names of all employees that have ‘A’ anywhere in their name. 
select  * from employees where ename like '%a%'

-- 6. Find out the names of all employees that have ‘L’ as their third character in their names
select  ename from employees where ename like '__l%'

-- 7. Compute daily salary of JONES.
select salary / 30 as daily_salary from employees
where ename ='jones'

-- 8. Calculate the total monthly salary of all employees. 
select sum (salary) as total_salary from employees 

-- 9. Print the average annual salary .
select AVG (salary * 12) as average_sal from employees

-- 10. Select the name, job, salary, department number of all employees except  SALESMAN from department number 30.
select ename,job,salary,deptno from employees
where deptno = 30 and job != 'salesman'

-- 11. List unique departments of the EMP table. 
select distinct deptno from employees

-- 12. List the name and salary of employees who earn more than 1500 and are in department 10 or 30. Label the columns Employee and Monthly Salary respectively.
select ename as employee, salary as monthly_salary from employees
where salary > 1500 and (deptno = 10 or deptno = 30)

-- 13. Display the name, job, and salary of all the employees whose job is MANAGER or ANALYST and their salary is not equal to 1000, 3000, or 5000. 
select ename,job,salary from employees
where (job='manager' or job='analyst') and salary not in (1000,3000,5000)

-- 14. Display the name, salary and commission for all employees whose commission amount is greater than their salary increased by 10%. 
select ename,salary,comm from employees
where comm > salary * 1.1

-- 15. Display the name of all employees who have two Ls in their name and are in department 30 or their manager is 7782.
select ename from employees
where (ename like '%ll%' and deptno=30) or mgr_id=7782

-- 16. Display the names of employees with experience of over 30 years and under 40 yrs. Count the total number of employees. 
select ename from employees
where datediff (year, hiredate, getdate()) between 30 and 39

select  count (*) as total_employee from employees
where datediff(year, hiredate, getdate()) between 30 and 39

-- 17. Retrieve the names of departments in ascending order and their employees in descending order.

select dname as department, ename as employee from employees
join department on employees.deptno = department.deptno
order by department asc, employee desc

-- 18. Find out experience of MILLER. 

select ename,hiredate, getdate() as "current_date",
       datediff(year, hiredate, getdate()) as exp_years from employees
where ename = 'MILLER'