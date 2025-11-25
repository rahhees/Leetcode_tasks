/* Write your T-SQL query statement below */


select p.product_name,year,price from Product p right join Sales s on p.product_id=s.product_id;