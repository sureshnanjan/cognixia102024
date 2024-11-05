USE bank;

SELECT 'TESTING INSTALLATION' as 'INFO';

DROP TABLE IF EXISTS expected_values, found_values;
CREATE TABLE expected_values (
    table_name varchar(30) not null primary key,
    recs int not null
);


CREATE TABLE found_values LIKE expected_values;

INSERT INTO `expected_values` VALUES 
('customer',   10),
('account',      10),
('transaction',    10),
('account_type',    10),
('account_status',    5),
('customer_account',    10);

SELECT table_name, recs AS expected_records FROM expected_values;

INSERT INTO found_values VALUES ('customer', (SELECT COUNT(*) FROM customer));

INSERT INTO found_values VALUES ('account', (SELECT COUNT(*) FROM account));

INSERT INTO found_values VALUES ('transaction', (SELECT COUNT(*) FROM transaction));

INSERT INTO found_values VALUES ('account_type', (SELECT COUNT(*) FROM account_type));

INSERT INTO found_values VALUES ('account_status', (SELECT COUNT(*) FROM account_status));

INSERT INTO found_values VALUES ('customer_account', (SELECT COUNT(*) FROM customer_account));

SELECT table_name, recs as 'found_records ' from found_values;

SELECT  
    e.table_name, 
    IF(e.recs=f.recs,'OK', 'not ok') AS records_match
from 
    expected_values e INNER JOIN found_values f USING (table_name); 

set @count_fail=(select count(*) from expected_values e inner join found_values f on (e.table_name=f.table_name) where f.recs != e.recs);

select timediff(
    now(),
    (select create_time from information_schema.tables where table_schema='bank' and table_name='expected_values')
) as computation_time;

select 'count' as summary, if(@count_fail = 0, "OK", "FAIL" ) as 'result';