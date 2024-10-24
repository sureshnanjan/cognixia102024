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
-- Adjust the expected values based on the sample data inserted earlier
INSERT INTO expected_values (table_name, expected_recs) VALUES
('country', 5), 
('city', 5),
('airport', 5),
('manufacturer', 5),
('airline', 5),
('aircraft_model', 5),
('aircraft', 5),
('seat_class', 3),
('aircraft_seat', 5),
('customer', 5),
('flight', 5),
('leg', 5),
('booking', 5),
('booking_leg', 5);

-- Display the expected records
SELECT table_name, expected_recs AS expected_records FROM expected_values;

-- Retrieve actual records (row count) for each table and store them in found_values
INSERT INTO found_values (table_name, found_recs)
SELECT 'country', COUNT(*) FROM country
UNION ALL
SELECT 'city', COUNT(*) FROM city
UNION ALL
SELECT 'airport', COUNT(*) FROM airport
UNION ALL
SELECT 'manufacturer', COUNT(*) FROM manufacturer
UNION ALL
SELECT 'airline', COUNT(*) FROM airline
UNION ALL
SELECT 'aircraft_model', COUNT(*) FROM aircraft_model
UNION ALL
SELECT 'aircraft', COUNT(*) FROM aircraft
UNION ALL
SELECT 'seat_class', COUNT(*) FROM seat_class
UNION ALL
SELECT 'aircraft_seat', COUNT(*) FROM aircraft_seat
UNION ALL
SELECT 'customer', COUNT(*) FROM customer
UNION ALL
SELECT 'flight', COUNT(*) FROM flight
UNION ALL
SELECT 'leg', COUNT(*) FROM leg
UNION ALL
SELECT 'booking', COUNT(*) FROM booking
UNION ALL
SELECT 'booking_leg', COUNT(*) FROM booking_leg;

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
