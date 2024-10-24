-- Drop temporary tables if they exist
DROP TABLE IF EXISTS expected_tables, found_tables, table_schema_check;

-- Create expected tables structure to store the table names that should exist
CREATE TABLE expected_tables (
    table_name VARCHAR(100) NOT NULL PRIMARY KEY
);

-- Create found tables structure to store the actual table names in the database
CREATE TABLE found_tables (
    table_name VARCHAR(100) NOT NULL PRIMARY KEY
);

-- Create a table to check the schema (columns, data types) of each table
CREATE TABLE table_schema_check (
    table_name VARCHAR(100),
    column_name VARCHAR(100),
    column_type VARCHAR(100),
    is_nullable VARCHAR(3),
    column_default VARCHAR(100),
    key_type VARCHAR(10),
    FOREIGN KEY (table_name) REFERENCES expected_tables(table_name)
);

-- Insert the expected table names into the expected_tables table
INSERT INTO expected_tables (table_name) VALUES
('country'),
('city'),
('airport'),
('manufacturer'),
('aircraft_model'),
('airline'),
('aircraft'),
('seat_class'),
('customer'),
('booking'),
('flight'),
('leg'),
('aircraft_seat'),
('booking_leg');

-- Insert the actual table names into the found_tables table
INSERT INTO found_tables (table_name)
SELECT table_name 
FROM information_schema.tables 
WHERE table_schema = 'airline_reservations';

-- Compare expected vs actual tables (check if all expected tables exist in the database)
SELECT 
    e.table_name AS expected_table, 
    f.table_name AS found_table,
    IF(e.table_name IS NOT NULL AND f.table_name IS NOT NULL, 'OK', 'FAIL') AS status
FROM 
    expected_tables e
    LEFT JOIN found_tables f ON e.table_name = f.table_name
WHERE e.table_name NOT IN ('expected_tables', 'found_tables', 'table_schema_check') 
UNION ALL
SELECT 
    e.table_name AS expected_table, 
    f.table_name AS found_table,
    'FAIL' AS status
FROM 
    expected_tables e
    LEFT JOIN found_tables f ON e.table_name = f.table_name
WHERE f.table_name IS NULL
AND e.table_name NOT IN ('expected_tables', 'found_tables', 'table_schema_check')
UNION ALL
SELECT 
    e.table_name AS expected_table, 
    f.table_name AS found_table,
    'FAIL' AS status
FROM 
    found_tables f
    LEFT JOIN expected_tables e ON e.table_name = f.table_name
WHERE e.table_name IS NULL
AND f.table_name NOT IN ('expected_tables', 'found_tables', 'table_schema_check');

-- Check the schema of all the tables (columns, data types) and insert into table_schema_check
INSERT INTO table_schema_check (table_name, column_name, column_type, is_nullable, column_default, key_type)
SELECT 
    t.table_name,
    c.column_name,
    c.data_type,
    c.is_nullable,
    c.column_default,
    c.column_key
FROM 
    information_schema.columns c
JOIN 
    information_schema.tables t 
    ON c.table_name = t.table_name
WHERE 
    t.table_schema = 'airline_reservations'
AND t.table_name NOT IN ('expected_tables', 'found_tables', 'table_schema_check');

-- Verify the schema for each table (comparing expected structure with actual structure, excluding special tables)
SELECT 
    e.table_name AS expected_table, 
    s.table_name AS found_table,
    e.column_name AS expected_column,
    e.column_type AS expected_type,
    s.column_name AS found_column,
    s.column_type AS found_type,
    IF(e.column_name IS NOT NULL AND s.column_name IS NOT NULL, 'OK', 'FAIL') AS status
FROM 
    (SELECT table_name, column_name, column_type FROM table_schema_check WHERE table_name NOT IN ('expected_tables', 'found_tables', 'table_schema_check')) e
LEFT JOIN 
    (SELECT table_name, column_name, column_type FROM table_schema_check WHERE table_name NOT IN ('expected_tables', 'found_tables', 'table_schema_check')) s 
    ON e.table_name = s.table_name AND e.column_name = s.column_name
WHERE e.table_name NOT IN ('expected_tables', 'found_tables', 'table_schema_check') 
AND s.table_name NOT IN ('expected_tables', 'found_tables', 'table_schema_check')
UNION ALL
SELECT 
    e.table_name AS expected_table, 
    s.table_name AS found_table,
    e.column_name AS expected_column,
    e.column_type AS expected_type,
    s.column_name AS found_column,
    s.column_type AS found_type,
    'FAIL' AS status
FROM 
    (SELECT table_name, column_name, column_type FROM table_schema_check WHERE table_name NOT IN ('expected_tables', 'found_tables', 'table_schema_check')) e
LEFT JOIN 
    (SELECT table_name, column_name, column_type FROM table_schema_check WHERE table_name NOT IN ('expected_tables', 'found_tables', 'table_schema_check')) s 
    ON e.table_name = s.table_name AND e.column_name = s.column_name
WHERE s.column_name IS NULL
AND e.table_name NOT IN ('expected_tables', 'found_tables', 'table_schema_check') 
AND e.column_name NOT IN ('expected_tables', 'found_tables', 'table_schema_check')
UNION ALL
SELECT 
    s.table_name AS expected_table, 
    e.table_name AS found_table,
    s.column_name AS expected_column,
    s.column_type AS expected_type,
    e.column_name AS found_column,
    e.column_type AS found_type,
    'FAIL' AS status
FROM 
    (SELECT table_name, column_name, column_type FROM table_schema_check WHERE table_name NOT IN ('expected_tables', 'found_tables', 'table_schema_check')) e
LEFT JOIN 
    (SELECT table_name, column_name, column_type FROM table_schema_check WHERE table_name NOT IN ('expected_tables', 'found_tables', 'table_schema_check')) s 
    ON e.table_name = s.table_name AND e.column_name = s.column_name
WHERE e.column_name IS NULL
AND s.table_name NOT IN ('expected_tables', 'found_tables', 'table_schema_check')
AND s.column_name NOT IN ('expected_tables', 'found_tables', 'table_schema_check');

-- Clean up by dropping temporary tables
DROP TABLE expected_tables, found_tables, table_schema_check;
