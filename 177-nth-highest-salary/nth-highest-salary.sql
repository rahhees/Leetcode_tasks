CREATE FUNCTION getNthHighestSalary(@N INT) RETURNS INT AS
BEGIN
    if @N is null or @N <1
    return null;
    RETURN (
        select distinct salary from employee
         order by salary desc
          offset (@N-1 )row
           fetch next 1 row only 

    );
END