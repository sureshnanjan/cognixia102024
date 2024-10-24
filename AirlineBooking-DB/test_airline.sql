-- Create expected_values table for record counts
DROP TABLE IF EXISTS expected_values;

CREATE TABLE expected_values (
    table_name varchar(30) not null primary key,
    recs int not null
);

-- Create found_values table for actual counts
DROP TABLE IF EXISTS found_values;

CREATE TABLE found_values LIKE expected_values;

-- Insert expected record counts
INSERT INTO expected_values VALUES 
('aircraft', 10),
('aircraft_model', 10),
('aircraft_seat', 10),
('airline', 10),
('airport', 10),
('booking', 10),
('booking_leg', 10),
('country', 10),
('customer', 10),
('flight', 10),
('leg', 10),
('manufacturer', 10),
('seat_class', 10);

-- Insert actual record counts into found_values
INSERT INTO found_values VALUES 
('aircraft', (SELECT COUNT(*) FROM aircraft)),
('aircraft_model', (SELECT COUNT(*) FROM aircraft_model)),
('aircraft_seat', (SELECT COUNT(*) FROM aircraft_seat)),
('airline', (SELECT COUNT(*) FROM airline)),
('airport', (SELECT COUNT(*) FROM airport)),
('booking', (SELECT COUNT(*) FROM booking)),
('booking_leg', (SELECT COUNT(*) FROM booking_leg)),
('country', (SELECT COUNT(*) FROM country)),
('customer', (SELECT COUNT(*) FROM customer)),
('flight', (SELECT COUNT(*) FROM flight)),
('leg', (SELECT COUNT(*) FROM leg)),
('manufacturer', (SELECT COUNT(*) FROM manufacturer)),
('seat_class', (SELECT COUNT(*) FROM seat_class));

-- Compare expected and found records
SELECT  
    e.table_name,
    e.recs AS expected_records,
    f.recs AS found_records,
    IF(e.recs = f.recs, 'OK', 'not ok') AS records_match
FROM 
    expected_values e 
INNER JOIN found_values f ON e.table_name = f.table_name;

-- Cleanup
DROP TABLE expected_values;
DROP TABLE found_values;
