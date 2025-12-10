


select 
case when  (select count(salary)from employee) <2
         then null
        else(
            select max(salary)from employee 
            where salary<(select max(salary)from employee)) 

        end as  SecondHighestSalary


