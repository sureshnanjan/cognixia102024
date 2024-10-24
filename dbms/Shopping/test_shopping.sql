-- Sample shopping website database validation script

USE shopping_website;

SELECT 'TESTING SHOPPING WEBSITE INSTALLATION' AS 'INFO';

-- Drop any previous validation tables if they exist
DROP TABLE IF EXISTS expected_values, found_values;

-- Create expected values table to store expected record counts for each table
CREATE TABLE expected_values (
    table_name VARCHAR(30) NOT NULL PRIMARY KEY,
    recs INT NOT NULL
);

-- Create found_values table with the same structure
CREATE TABLE found_values LIKE expected_values;

-- Insert expected record counts for each table
INSERT INTO expected_values VALUES 
('customers',        10),
('products',         20),
('categories',       5),
('orders',           15),
('order_details',    25),
('employees',        8),
('branches',         4);

-- Display expected record counts
SELECT table_name, recs AS expected_records FROM expected_values;

-- Verify records in found_values (this should be filled with actual counts later)
SELECT table_name, recs AS 'found_records' FROM found_values;

-- Compare the expected and found record counts
SELECT  
    e.table_name, 
    IF(e.recs = f.recs, 'OK', 'not ok') AS records_match
FROM 
    expected_values e 
    INNER JOIN found_values f USING (table_name);

-- Summarize results by counting failed comparisons
SET @count_fail = (
    SELECT COUNT(*) 
    FROM expected_values e 
    INNER JOIN found_values f 
    ON e.table_name = f.table_name 
    WHERE f.recs != e.recs
);

-- Calculate the computation time
SELECT TIMEDIFF(
    NOW(),
    (SELECT create_time 
     FROM information_schema.tables 
     WHERE table_schema = 'shopping_website' 
     AND table_name = 'expected_values')
) AS computation_time;

-- Cleanup by dropping validation tables
DROP TABLE expected_values, found_values;

-- Display summary of results
SELECT 'COUNT' AS summary, 
       IF(@count_fail = 0, "OK", "FAIL") AS 'result';
