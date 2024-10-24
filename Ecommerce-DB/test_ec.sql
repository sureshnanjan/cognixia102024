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

('address', 10),

('brand', 10),

('colour', 10),

('customer_order', 10),

('customer_order_line', 10),

('product', 10),

('product_category', 10),

('size', 10),

('supplier', 10),

('supplier_order', 10),

('supplier_order_line', 10),

('user_account', 10),

('user_address', 10);
 
 
-- Insert actual record counts into found_values

INSERT INTO found_values VALUES 

('address', (SELECT COUNT(*) FROM address)),

('brand', (SELECT COUNT(*) FROM brand)),

('colour', (SELECT COUNT(*) FROM colour)),

('customer_order', (SELECT COUNT(*) FROM customer_order)),

('customer_order_line', (SELECT COUNT(*) FROM customer_order_line)),

('product', (SELECT COUNT(*) FROM product)),

('product_category', (SELECT COUNT(*) FROM product_category)),

('size', (SELECT COUNT(*) FROM size)),

('supplier', (SELECT COUNT(*) FROM supplier)),

('supplier_order', (SELECT COUNT(*) FROM supplier_order)),

('supplier_order_line', (SELECT COUNT(*) FROM supplier_order_line)),

('user_account', (SELECT COUNT(*) FROM user_account)),

('user_address', (SELECT COUNT(*) FROM user_address));
 
-- Compare expected and found records

SELECT  

    e.table_name,

    e.recs AS expected_records,

    f.recs AS found_records,

    IF(e.recs = f.recs,'OK','not ok') AS records_match

FROM 

    expected_values e 

INNER JOIN found_values f ON e.table_name = f.table_name;
 
-- Cleanup

DROP TABLE expected_values;

DROP TABLE found_values;