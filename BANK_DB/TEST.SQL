SELECT
    c.customer_id,c.first_name,c.last_name,c.date_of_birth,c.signup_date,   
CASE WHEN
c.first_name ='Alice'
AND
c.last_name ='Smith'
AND
c.date_of_birth ='1990-01-01'
AND
c.signup_date ='2020-01-10'
THEN 'Matched'
WHEN
c.first_name ='Bob'
AND
c.last_name ='Johnson'
AND
c.date_of_birth ='1985-02-15'
AND
c.signup_date ='2021-02-20'
THEN 'Matched'
-- Add checks for all other records here
ELSE 'Not Matched'
END AS status
FROM customer c
WHERE customer_id IN (1, 2, 3, 4, 5, 6, 7, 8, 9, 10);