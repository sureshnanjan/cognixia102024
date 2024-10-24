--  Sample bank database validation script 

USE bank;

SELECT 'TESTING BANK INSTALLATION' as 'INFO';

DROP TABLE IF EXISTS expected_values, found_values;
CREATE TABLE expected_values (
    table_name varchar(30) not null primary key,
    recs int not null
    );

CREATE TABLE found_values LIKE expected_values;

INSERT INTO `expected_values` VALUES 
('customer',        15),
('account',         10),
('customer_account',10),
('transaction',     10),
('account_type',    5),
('account_status',  5);

SELECT table_name, recs AS expected_records FROM expected_values;


-- Verify records and checksums
SELECT table_name, recs as 'found_records' from found_values;

-- Compare the expected and found values
SELECT  
    e.table_name, 
    IF(e.recs=f.recs,'OK', 'not ok') AS records_match
     
FROM 
    expected_values e 
    INNER JOIN found_values f USING (table_name); 

-- Summarize results
SET @count_fail = (SELECT COUNT(*) FROM expected_values e INNER JOIN found_values f ON (e.table_name=f.table_name) WHERE f.recs != e.recs);

SELECT TIMEDIFF(
    NOW(),
    (SELECT create_time FROM information_schema.tables WHERE table_schema='bank' AND table_name='expected_values')
) AS computation_time;

DROP TABLE expected_values, found_values;

SELECT 'COUNT' AS summary, IF(@count_fail = 0, "OK", "FAIL" ) AS 'result'
