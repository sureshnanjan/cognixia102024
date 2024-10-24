-- Drop the expected and found tables if they exist
DROP TABLE IF EXISTS expected_bank_tables, found_bank_tables;

-- Create expected tables structure to store the table names that should exist in the `bank` database
CREATE TABLE expected_bank_tables (
    table_name VARCHAR(100) NOT NULL PRIMARY KEY
);

-- Create found tables structure to store the actual table names in the `bank` database
CREATE TABLE found_bank_tables (
    table_name VARCHAR(100) NOT NULL PRIMARY KEY
);

-- Insert the expected table names into the expected_bank_tables table
INSERT INTO expected_bank_tables (table_name) VALUES
('customer'),
('account_type'),
('account_status'),
('account'),
('customer_account'),
('transaction');

-- Display the expected table names
SELECT table_name FROM expected_bank_tables;

-- Insert the actual table names into the found_bank_tables table
INSERT INTO found_bank_tables (table_name)
SELECT table_name 
FROM information_schema.tables 
WHERE table_schema = 'bank';

-- Display the found table names (actual)
SELECT table_name FROM found_bank_tables;

-- Compare expected vs actual tables, excluding the `expected_bank_tables` and `found_bank_tables` themselves
SELECT 
    e.table_name AS expected_table, 
    f.table_name AS found_table,
    IF(e.table_name IS NOT NULL AND f.table_name IS NOT NULL, 'OK', 'FAIL') AS status
FROM 
    expected_bank_tables e
    LEFT JOIN found_bank_tables f ON e.table_name = f.table_name
WHERE e.table_name NOT IN ('expected_bank_tables', 'found_bank_tables')   -- Exclude these specific tables
AND f.table_name NOT IN ('expected_bank_tables', 'found_bank_tables')       -- Exclude these specific tables
UNION ALL
SELECT 
    e.table_name AS expected_table, 
    f.table_name AS found_table,
    'FAIL' AS status
FROM 
    expected_bank_tables e
    LEFT JOIN found_bank_tables f ON e.table_name = f.table_name
WHERE f.table_name IS NULL
AND e.table_name NOT IN ('expected_bank_tables', 'found_bank_tables')       -- Exclude these specific tables
UNION ALL
SELECT 
    e.table_name AS expected_table, 
    f.table_name AS found_table,
    'FAIL' AS status
FROM 
    found_bank_tables f
    LEFT JOIN expected_bank_tables e ON e.table_name = f.table_name
WHERE e.table_name IS NULL
AND f.table_name NOT IN ('expected_bank_tables', 'found_bank_tables');      -- Exclude these specific tables

-- Clean up by dropping temporary tables
DROP TABLE expected_bank_tables, found_bank_tables;
