/* Write your T-SQL query statement below */


with duplicate_value as (
    select tiv_2015 from 
    Insurance group by tiv_2015
    having count(*)>1
),
unique_value as (
    select lat,lon from 
    Insurance group by lat,lon 
    having count(*)=1
)

select round(sum(i.tiv_2016),2) as
tiv_2016 from insurance i 
join duplicate_value t on i.tiv_2015 = t.tiv_2015
join unique_value u
 on i.lat =u.lat
  and i.lon = u.lon;
