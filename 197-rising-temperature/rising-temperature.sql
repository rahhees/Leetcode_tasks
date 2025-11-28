/* Write your T-SQL query statement below */

select w1.id from weather w1 join weather w2 on DATEADD(DAY,-1,W1.recordDate)=w2.recordDate
where w1.temperature >w2.temperature ;


