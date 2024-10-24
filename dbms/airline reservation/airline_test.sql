-- Sample airline reservations database validation script

USE airline_reservations;

SELECT 'TESTING AIRLINE RESERVATION INSTALLATION' AS 'INFO';

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
('customers',       4),  -- Adjust the expected counts based on your data
('airports',        3),
('airlines',        3),
('aircraft_models', 3),
('aircrafts',      3),
('flights',        3),
('legs',           3),
('bookings',       4),
('booking_details', 4);

-- Display expected record counts
SELECT table_name, recs AS expected_records FROM expected_values;

-- Verify records in found_values (this should be filled with actual counts later)
INSERT INTO found_values (table_name, recs)
SELECT 
    'customers', COUNT(*) FROM customers
UNION ALL
SELECT 
    'airports', COUNT(*) FROM airports
UNION ALL
SELECT 
    'airlines', COUNT(*) FROM airlines
UNION ALL
SELECT 
    'aircraft_models', COUNT(*) FROM aircraft_models
UNION ALL
SELECT 
    'aircrafts', COUNT(*) FROM aircrafts
UNION ALL
SELECT 
    'flights', COUNT(*) FROM flights
UNION ALL
SELECT 
    'legs', COUNT(*) FROM legs
UNION ALL
SELECT 
    'bookings', COUNT(*) FROM bookings
UNION ALL
SELECT 
    'booking_details', COUNT(*) FROM booking_details;

-- Compare the expected and found record counts
SELECT  
    e.table_name, 
    IF(e.recs = f.recs, 'OK', 'not ok') AS records_match
FROM 
    expected_values e 
    LEFT JOIN found_values f ON e.table_name = f.table_name;

-- Summarize results by counting failed comparisons
SET @count_fail = (
    SELECT COUNT(*) 
    FROM expected_values e 
    LEFT JOIN found_values f ON e.table_name = f.table_name 
    WHERE f.recs != e.recs
);

-- Calculate the computation time
SELECT TIMEDIFF(
    NOW(),
    (SELECT create_time 
     FROM information_schema.tables 
     WHERE table_schema = 'airline_reservations' 
     AND table_name = 'expected_values')
) AS computation_time;

-- Cleanup by dropping validation tables
DROP TABLE expected_values, found_values;

-- Display summary of results
SELECT 'COUNT' AS summary, 
       IF(@count_fail = 0, "OK", "FAIL") AS 'result';
