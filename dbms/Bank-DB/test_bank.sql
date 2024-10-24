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

('account_type',   3),

('account_status',   2),

('customer',   10),

('account',   3),

('customer_account',   3),

('transaction',   2);
 
-- Insert actual record counts into found_values

INSERT INTO found_values VALUES 

('account_type', (SELECT COUNT(*) FROM account_type)),

('account_status', (SELECT COUNT(*) FROM account_status)),

('customer', (SELECT COUNT(*) FROM customer)),

('account', (SELECT COUNT(*) FROM account)),

('customer_account', (SELECT COUNT(*) FROM customer_account)),

('transaction', (SELECT COUNT(*) FROM transaction));
 
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