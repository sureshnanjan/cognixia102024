USE bank;

SELECT 'TESTING INSTALLATION' AS 'INFO';

-- Drop tables if they exist
DROP TABLE IF EXISTS expected_values, found_values;

-- Create expected values table
CREATE TABLE expected_values (
    table_name VARCHAR(30) NOT NULL PRIMARY KEY,
    recs INT NOT NULL
);

-- Create found values table
CREATE TABLE found_values LIKE expected_values;

-- Insert expected values
INSERT INTO expected_values VALUES 
('customer', 4),
('account', 3),
('account_type', 3),
('account_status', 3),
('customer_account', 5),
('transaction', 3);

SELECT table_name, recs AS expected_records FROM expected_values;

-- Check record counts for each table
INSERT INTO found_values VALUES ('customer', (SELECT COUNT(*) FROM customer));
INSERT INTO found_values VALUES ('account', (SELECT COUNT(*) FROM account));
INSERT INTO found_values VALUES ('account_type', (SELECT COUNT(*) FROM account_type));
INSERT INTO found_values VALUES ('account_status', (SELECT COUNT(*) FROM account_status));
INSERT INTO found_values VALUES ('customer_account', (SELECT COUNT(*) FROM customer_account));
INSERT INTO found_values VALUES ('transaction', (SELECT COUNT(*) FROM transaction));

-- Select found values for comparison
SELECT table_name, recs AS 'found_records' FROM found_values;

-- Compare expected vs found values
SELECT  
    e.table_name, 
    IF(e.recs = f.recs, 'OK', 'not ok') AS records_match
FROM 
    expected_values e 
INNER JOIN found_values f USING (table_name);

-- Count discrepancies
SET @count_fail = (SELECT COUNT(*) FROM expected_values e 
                    INNER JOIN found_values f ON (e.table_name = f.table_name) 
                    WHERE f.recs != e.recs);

-- Timing computation
SELECT TIMEDIFF(
    NOW(),
    (SELECT create_time FROM information_schema.tables WHERE table_schema = 'bank' AND table_name = 'expected_values')
) AS computation_time;

-- Drop temporary tables
DROP TABLE expected_values, found_values;

-- Summary of results
SELECT 'count' AS summary, IF(@count_fail = 0, 'OK', 'FAIL') AS 'result';
