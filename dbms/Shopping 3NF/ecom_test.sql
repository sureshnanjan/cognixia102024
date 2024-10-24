USE ecom;

SELECT 'TESTING INSTALLATION' as 'INFO';

DROP TABLE IF EXISTS expected_values, found_values;
CREATE TABLE expected_values (
    table_name varchar(30) not null primary key,
    recs int not null
);


CREATE TABLE found_values LIKE expected_values;

INSERT INTO `expected_values` VALUES 
('addresses',   8),
('brand',      10),
('colour',    10),
('customer_order',    4),
('customer_order_line',    4),
('product',    13),
('product_category',    8),
('size',    9),
('supplier',    8),
('supplier_order',    4),
('supplier_order_line',    4),
('user_address',    4),
('users_account',    4);

SELECT table_name, recs AS expected_records FROM expected_values;

INSERT INTO found_values VALUES ('addresses', (SELECT COUNT(*) FROM addresses));

INSERT INTO found_values VALUES ('brand', (SELECT COUNT(*) FROM brand));

INSERT INTO found_values VALUES ('colour', (SELECT COUNT(*) FROM colour));

INSERT INTO found_values VALUES ('customer_order', (SELECT COUNT(*) FROM customer_order));

INSERT INTO found_values VALUES ('customer_order_line', (SELECT COUNT(*) FROM customer_order_line));

INSERT INTO found_values VALUES ('product', (SELECT COUNT(*) FROM product));

INSERT INTO found_values VALUES ('product_category', (SELECT COUNT(*) FROM product_category));

INSERT INTO found_values VALUES ('size', (SELECT COUNT(*) FROM size));

INSERT INTO found_values VALUES ('supplier', (SELECT COUNT(*) FROM supplier));

INSERT INTO found_values VALUES ('supplier_order', (SELECT COUNT(*) FROM supplier_order));

INSERT INTO found_values VALUES ('supplier_order_line', (SELECT COUNT(*) FROM supplier_order_line));

INSERT INTO found_values VALUES ('user_address', (SELECT COUNT(*) FROM user_address));

INSERT INTO found_values VALUES ('users_account', (SELECT COUNT(*) FROM users_account));

SELECT table_name, recs as 'found_records ' from found_values;

SELECT  
    e.table_name, 
    IF(e.recs=f.recs,'OK', 'not ok') AS records_match
from 
    expected_values e INNER JOIN found_values f USING (table_name); 

set @count_fail=(select count(*) from expected_values e inner join found_values f on (e.table_name=f.table_name) where f.recs != e.recs);

select timediff(
    now(),
    (select create_time from information_schema.tables where table_schema='ecom' and table_name='expected_values')
) as computation_time;

select 'count' as summary, if(@count_fail = 0, "OK", "FAIL" ) as 'result';