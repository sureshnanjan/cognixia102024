-- Use the database for bank
USE shopping_db;

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
('address', 10),
('user_address', 10),
('user_account', 10),
('customer_order',10 ),
('customer_order_line', 10),
('product_category', 10),
('brand', 10),
('colour', 10),
('size', 10),
('supplier', 15 ),
('product', 10),
('supplier_order', 10),
('supplier_order_line', 10);

-- Display the expected values
SELECT table_name, recs AS expected_record FROM expected_values;

-- Insert found values into table 
INSERT INTO found_values VALUES ('address', (SELECT COUNT(*) FROM address));
INSERT INTO found_values VALUES ('user_address', (SELECT COUNT(*) FROM user_address));
INSERT INTO found_values VALUES ('user_account', (SELECT COUNT(*) FROM user_account));
INSERT INTO found_values VALUES ('customer_order', (SELECT COUNT(*) FROM customer_order));
INSERT INTO found_values VALUES ('customer_order_line', (SELECT COUNT(*) FROM customer_order_line));
INSERT INTO found_values VALUES ('product_category', (SELECT COUNT(*) FROM product_category));
INSERT INTO found_values VALUES ('brand', (SELECT COUNT(*) FROM brand));
INSERT INTO found_values VALUES ('colour', (SELECT COUNT(*) FROM colour));
INSERT INTO found_values VALUES ('size', (SELECT COUNT(*) FROM size));
INSERT INTO found_values VALUES ('supplier', (SELECT COUNT(*) FROM supplier));
INSERT INTO found_values VALUES ('product', (SELECT COUNT(*) FROM product));
INSERT INTO found_values VALUES ('supplier_order', (SELECT COUNT(*) FROM supplier_order));
INSERT INTO found_values VALUES ('supplier_order_line', (SELECT COUNT(*) FROM supplier_order_line));

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
    (SELECT create_time FROM information_schema.tables WHERE table_schema='shopping_db' and table_name='expected_values')
) AS computation_time;

-- Dropping the temporary tables
DROP TABLE expected_values,found_values;

-- Result summary
SELECT 'count' AS summary, if(@count_fail = 0, "OK", "FAIL" ) AS result;