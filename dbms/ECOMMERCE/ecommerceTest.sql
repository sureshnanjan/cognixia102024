-- Sample e-commerce database 
-- This script is for validating expected and actual values after data insertion
-- Disclaimer: The data is fabricated for testing purposes only.

USE e_commerce;

SELECT 'TESTING INSTALLATION' AS 'INFO';

DROP TABLE IF EXISTS expected_values, found_values;
CREATE TABLE expected_values (
    table_name VARCHAR(30) NOT NULL PRIMARY KEY,
    recs INT NOT NULL,
    crc_sha VARCHAR(100) NOT NULL,
    crc_md5 VARCHAR(100) NOT NULL
);

CREATE TABLE found_values LIKE expected_values;

INSERT INTO expected_values VALUES 
('address',    5, '4b315afa0e35ca6649df897b958345bcb3d2b764', 'd1af5e170d2d1591d776d5638d71fc5f'),
('user_account', 3, 'a5b8f6a307efda82c7c721e68d4e8f99', 'eaa378f39bdbf0f39e2e6aeb9378fd4b'),
('customer_order', 3, '3f17eeb95f375c9e9162cf3f5eac75e2', 'caa0c2a9f5198a194b5aefad4b84cb8'),
('product',    3, '81b5bfc9c0e6b88a6f6e88ef4de0e9b4', 'ff6c67883e186a1c487a5cf0cb4ab8f5');

SELECT table_name, recs AS expected_records, crc_md5 AS expected_crc FROM expected_values;

DROP TABLE IF EXISTS tchecksum;
CREATE TABLE tchecksum (chk CHAR(100));

SET @crc= '';

INSERT INTO tchecksum 
    SELECT @crc := MD5(CONCAT_WS('#', @crc, house_unit_no, address_line1, address_line2, city, region, postal_code, country)) 
    FROM address ORDER BY house_unit_no;
INSERT INTO found_values VALUES ('address', (SELECT COUNT(*) FROM address), @crc, @crc);

SET @crc = '';
INSERT INTO tchecksum 
    SELECT @crc := MD5(CONCAT_WS('#', @crc, username, first_name, last_name, email_address)) 
    FROM user_account ORDER BY username;
INSERT INTO found_values VALUES ('user_account', (SELECT COUNT(*) FROM user_account), @crc, @crc);

SET @crc = '';
INSERT INTO tchecksum 
    SELECT @crc := MD5(CONCAT_WS('#', @crc, order_discount, shipping_address, billing_address, username, order_date)) 
    FROM customer_order ORDER BY order_id;
INSERT INTO found_values VALUES ('customer_order', (SELECT COUNT(*) FROM customer_order), @crc, @crc);

SET @crc = '';
INSERT INTO tchecksum 
    SELECT @crc := MD5(CONCAT_WS('#', @crc, product_name, product_category_id, brand_id, colour_id, size_id, supplier_id)) 
    FROM product ORDER BY product_id;
INSERT INTO found_values VALUES ('product', (SELECT COUNT(*) FROM product), @crc, @crc);

DROP TABLE tchecksum;

SELECT table_name, recs AS 'found_records   ', crc_md5 AS found_crc FROM found_values;

SELECT  
    e.table_name, 
    IF(e.recs = f.recs, 'OK', 'not ok') AS records_match, 
    IF(e.crc_md5 = f.crc_md5, 'ok', 'not ok') AS crc_match 
FROM 
    expected_values e 
INNER JOIN found_values f USING (table_name); 

SET @crc_fail = (SELECT COUNT(*) FROM expected_values e INNER JOIN found_values f ON (e.table_name = f.table_name) WHERE f.crc_md5 != e.crc_md5);
SET @count_fail = (SELECT COUNT(*) FROM expected_values e INNER JOIN found_values f ON (e.table_name = f.table_name) WHERE f.recs != e.recs);

SELECT TIMEDIFF(
    NOW(),
    (SELECT create_time FROM information_schema.tables WHERE table_schema = 'e_commerce' AND table_name = 'expected_values')
) AS computation_time;

DROP TABLE expected_values, found_values;

SELECT 'CRC' AS summary, IF(@crc_fail = 0, 'OK', 'FAIL') AS 'result'
UNION ALL
SELECT 'count', IF(@count_fail = 0, 'OK', 'FAIL');
