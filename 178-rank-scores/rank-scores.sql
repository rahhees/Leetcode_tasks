/* Write your T-SQL query statement below */


-- select score,id as rank from Scores order by score desc;

select score,dense_rank() over (order by score desc)as rank from Scores