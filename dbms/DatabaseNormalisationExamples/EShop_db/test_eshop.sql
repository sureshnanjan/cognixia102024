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
-- Adjust the expected values based on your sample data
INSERT INTO expected_values (table_name, expected_recs) VALUES
('product_category', 5),  -- Adjusted this to 5
('brand', 5),
('colour', 5),
('size', 5),
('supplier', 5),
('product', 5),
('customer_order', 5),
('customer_order_line', 5),
('user_account', 5),
('address', 5),
('user_address', 5),
('supplier_order', 5),
('supplier_order_line', 5);

-- Display the expected records
SELECT table_name, expected_recs AS expected_records FROM expected_values;

-- Retrieve actual records (row count) for each table and store them in found_values
INSERT INTO found_values (table_name, found_recs)
SELECT 'product_category', COUNT(*) FROM product_category
UNION ALL
SELECT 'brand', COUNT(*) FROM brand
UNION ALL
SELECT 'colour', COUNT(*) FROM colour
UNION ALL
SELECT 'size', COUNT(*) FROM size
UNION ALL
SELECT 'supplier', COUNT(*) FROM supplier
UNION ALL
SELECT 'product', COUNT(*) FROM product
UNION ALL
SELECT 'customer_order', COUNT(*) FROM customer_order
UNION ALL
SELECT 'customer_order_line', COUNT(*) FROM customer_order_line
UNION ALL
SELECT 'user_account', COUNT(*) FROM user_account
UNION ALL
SELECT 'address', COUNT(*) FROM address
UNION ALL
SELECT 'user_address', COUNT(*) FROM user_address
UNION ALL
SELECT 'supplier_order', COUNT(*) FROM supplier_order
UNION ALL
SELECT 'supplier_order_line', COUNT(*) FROM supplier_order_line;

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
