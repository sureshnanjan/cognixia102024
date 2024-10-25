-- Use the database for bank
USE airline_db;

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
('aircraft', 10),
('aircraft_model', 10),
('aircraft_seat', 10),
('airline',10 ),
('airport', 10),
('booking', 10),
('booking_leg', 10),
('city', 10),
('country', 10),
('customer', 10 ),
('flight', 10),
('leg', 10),
('seat_class', 10);
('manufactures', 10);

-- Display the expected values
SELECT table_name, recs AS expected_record FROM expected_values;

-- Insert found values into table 
INSERT INTO found_values VALUES ('aircraft', (SELECT COUNT(*) FROM aircraft));
INSERT INTO found_values VALUES ('aircraft_model', (SELECT COUNT(*) FROM aircraft_model));
INSERT INTO found_values VALUES ('aircraft_seat', (SELECT COUNT(*) FROM aircraft_seat));
INSERT INTO found_values VALUES ('airline', (SELECT COUNT(*) FROM airline));
INSERT INTO found_values VALUES ('airport', (SELECT COUNT(*) FROM airport));
INSERT INTO found_values VALUES ('booking', (SELECT COUNT(*) FROM booking));
INSERT INTO found_values VALUES ('booking_leg', (SELECT COUNT(*) FROM booking_leg));
INSERT INTO found_values VALUES ('city', (SELECT COUNT(*) FROM city));
INSERT INTO found_values VALUES ('country', (SELECT COUNT(*) FROM country));
INSERT INTO found_values VALUES ('customer', (SELECT COUNT(*) FROM customer));
INSERT INTO found_values VALUES ('flight', (SELECT COUNT(*) FROM flight));
INSERT INTO found_values VALUES ('leg', (SELECT COUNT(*) FROM leg));
INSERT INTO found_values VALUES ('seat_class', (SELECT COUNT(*) FROM seat_class));
INSERT INTO found_values VALUES ('manufactures', (SELECT COUNT(*) FROM manufactures));

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
    (SELECT create_time FROM information_schema.tables WHERE table_schema='airline_db' and table_name='expected_values')
) AS computation_time;

-- Dropping the temporary tables
DROP TABLE expected_values,found_values;

-- Result summary
SELECT 'count' AS summary, if(@count_fail = 0, "OK", "FAIL" ) AS result;