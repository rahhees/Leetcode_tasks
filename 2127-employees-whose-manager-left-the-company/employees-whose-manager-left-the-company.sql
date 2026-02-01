/* Write your T-SQL query statement below */


with sample as(
    select employee_id from 
    employees 
)


select e.employee_id from Employees e
where e.salary<30000
and e.manager_id not in (select employee_id from  sample)
order by  e.employee_id;