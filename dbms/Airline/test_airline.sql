USE your_database_name; -- Replace with your actual database name

SELECT 'TESTING INSTALLATION' AS 'INFO';

DROP TABLE IF EXISTS expected_values, found_values;
CREATE TABLE expected_values (
    table_name VARCHAR(30) NOT NULL PRIMARY KEY,
    recs INT NOT NULL
);

CREATE TABLE found_values LIKE expected_values;

-- Insert expected record counts
INSERT INTO `expected_values` VALUES 
('country', 10),
('airline', 10),
('manufacturer', 10),
('aircraft_model', 10),
('customer', 10),
('aircraft', 10),
('airport', 10),
('flight', 10),
('seat_class', 10),
('aircraft_seat', 10),
('leg', 10),
('booking', 10),
('booking_leg', 10);

-- Count records for each table and insert into found_values
INSERT INTO found_values VALUES ('country', (SELECT COUNT(*) FROM country));
INSERT INTO found_values VALUES ('airline', (SELECT COUNT(*) FROM airline));
INSERT INTO found_values VALUES ('manufacturer', (SELECT COUNT(*) FROM manufacturer));
INSERT INTO found_values VALUES ('aircraft_model', (SELECT COUNT(*) FROM aircraft_model));
INSERT INTO found_values VALUES ('customer', (SELECT COUNT(*) FROM customer));
INSERT INTO found_values VALUES ('aircraft', (SELECT COUNT(*) FROM aircraft));
INSERT INTO found_values VALUES ('airport', (SELECT COUNT(*) FROM airport));
INSERT INTO found_values VALUES ('flight', (SELECT COUNT(*) FROM flight));
INSERT INTO found_values VALUES ('seat_class', (SELECT COUNT(*) FROM seat_class));
INSERT INTO found_values VALUES ('aircraft_seat', (SELECT COUNT(*) FROM aircraft_seat));
INSERT INTO found_values VALUES ('leg', (SELECT COUNT(*) FROM leg));
INSERT INTO found_values VALUES ('booking', (SELECT COUNT(*) FROM booking));
INSERT INTO found_values VALUES ('booking_leg', (SELECT COUNT(*) FROM booking_leg));

-- Display the counts
SELECT 
    e.table_name, 
    e.recs AS expected_records, 
    f.recs AS found_records 
FROM 
    expected_values e 
JOIN 
    found_values f ON e.table_name = f.table_name;

-- Cleanup
DROP TABLE expected_values, found_values;