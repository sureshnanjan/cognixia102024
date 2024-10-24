-- Drop the expected and found values tables if they exist
DROP TABLE IF EXISTS expected_values, found_values;

-- Create expected values table with structure to store the expected row count for each table
CREATE TABLE expected_values (
    table_name VARCHAR(30) NOT NULL PRIMARY KEY,
    expected_recs INT NOT NULL
);

-- Create found values table to store actual results (row count)
CREATE TABLE found_values (
    table_name VARCHAR(30) NOT NULL PRIMARY KEY,
    found_recs INT NOT NULL
);

-- Insert expected values (row count) for each table
-- Adjust the expected values based on your data
INSERT INTO expected_values (table_name, expected_recs) VALUES
('customer', 15),
('account', 15),
('account_type', 15),
('account_status', 15),
('customer_account', 15),
('transaction', 15);

-- Display the expected records
SELECT table_name, expected_recs AS expected_records FROM expected_values;

-- Retrieve actual records (row count) for each table and store them in found_values
INSERT INTO found_values (table_name, found_recs)
SELECT 'customer', COUNT(*) FROM customer
UNION ALL
SELECT 'account', COUNT(*) FROM account
UNION ALL
SELECT 'account_type', COUNT(*) FROM account_type
UNION ALL
SELECT 'account_status', COUNT(*) FROM account_status
UNION ALL
SELECT 'customer_account', COUNT(*) FROM customer_account
UNION ALL
SELECT 'transaction', COUNT(*) FROM transaction;

-- Display the found (actual) records
SELECT table_name, found_recs AS found_records FROM found_values;

-- Compare records for each table
SELECT 
    e.table_name, 
    e.expected_recs AS expected_records,
    f.found_recs AS found_records,
    IF(e.expected_recs = f.found_recs, 'OK', 'FAIL') AS status
FROM 
    expected_values e
    INNER JOIN found_values f ON e.table_name = f.table_name;

-- Set variables to track discrepancies
SET @count_fail = (SELECT COUNT(*) 
                    FROM expected_values e 
                    INNER JOIN found_values f ON e.table_name = f.table_name 
                    WHERE f.found_recs != e.expected_recs);

-- Summary of record count match status for all tables
SELECT 'Summary', IF(@count_fail = 0, 'All records match (OK)', CONCAT(@count_fail, ' table(s) mismatch (FAIL)')) AS status;

-- Drop tables after use
DROP TABLE expected_values, found_values;
