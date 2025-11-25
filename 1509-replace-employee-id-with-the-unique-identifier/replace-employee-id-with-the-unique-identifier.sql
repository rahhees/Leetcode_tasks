/* Write your T-SQL query statement below */

select m.unique_id,e.name from Employees e left join EmployeeUNI m on e.id=m.id;




