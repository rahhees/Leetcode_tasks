/* Write your T-SQL query statement below */


select * from Patients 
 where conditions Like 'DIAB1%'
 or  conditions    Like '% DIAB1%'
