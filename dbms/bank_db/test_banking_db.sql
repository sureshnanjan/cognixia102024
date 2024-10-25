-- Use the database for bank
USE banking_db;

SELECT 'TESTING INSTALLATION' as 'INFO';

-- Dropping the tables if they already exists
DROP TABLE IF EXISTS expected_values, found_values;

-- Create table for expected values
CREATE TABLE expected_values (
    table_name VARCHAR(30) NOT NULL PRIMARY KEY,
    recs INT NOT NULL
);

-- Create table for found values
CREATE TABLE found_values LIKE expected_values;

-- Insert expected values into table
INSERT INTO expected_values VALUES 
('account_type', 5),
('account_status', 10),
('account', 15),
('customer', 15),
('customer_account', 15),
('transaction', 8);

-- Display the expected values
SELECT table_name, recs AS expected_record FROM expected_values;

-- Insert found values into table 
INSERT INTO found_values VALUES ('account_type', (SELECT COUNT(*) FROM account_type));
INSERT INTO found_values VALUES ('account_status', (SELECT COUNT(*) FROM account_status));
INSERT INTO found_values VALUES ('account', (SELECT COUNT(*) FROM account));
INSERT INTO found_values VALUES ('customer', (SELECT COUNT(*) FROM customer));
INSERT INTO found_values VALUES ('customer_account', (SELECT COUNT(*) FROM customer_account));
INSERT INTO found_values VALUES ('transaction', (SELECT COUNT(*) FROM transaction));

-- Display the found values
SELECT table_name, recs AS found_records FROM found_values;

-- Compare expected and found values
SELECT  
    e.table_name, 
    IF(e.recs=f.recs,'OK', 'NOT OK') AS records_match 
FROM 
    expected_values e INNER JOIN found_values f USING (table_name); 

-- Count discrepancies
SET @count_fail=(SELECT count(*) FROM expected_values e INNER JOIN found_values f ON (e.table_name=f.table_name) WHERE f.recs != e.recs);

-- Time computation 
SELECT timediff(
    now(),
    (SELECT create_time FROM information_schema.tables WHERE table_schema='banking_db' and table_name='expected_values')
) AS computation_time;

-- Dropping the temporary tables
DROP TABLE expected_values,found_values;

-- Result summary
SELECT 'count' AS summary, if(@count_fail = 0, "OK", "FAIL" ) AS result;