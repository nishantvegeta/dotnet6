-- duplicate emails
SELECT email as Email FROM Person 
GROUP BY email
HAVING COUNT(email) > 1;

-- second highest salary
SELECT MAX(salary) as SecondHighestSalary FROM Employee
WHERE salary < (SELECT MAX(salary) from Employee);

-- Top 3 salaries
SELECT d.name as Department, e.name as Employee, e.salary as Salary
FROM Employee e
JOIN Department d
ON e.DepartmentId = d.Id
WHERE
3 > (SELECT COUNT(DISTINCT e1.salary) FROM Employee e1 
    WHERE e1.salary > e.salary 
    AND e1.DepartmentId = e.DepartmentId);