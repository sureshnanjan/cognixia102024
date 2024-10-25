USE airline; 

SELECT 'TESTING INSTALLATION' as 'INFO'; 

DROP TABLE IF EXISTS expected_values, found_values; 

CREATE TABLE expected_values ( 

    table_name varchar(30) not null primary key, 

    recs int not null 

); 

CREATE TABLE found_values LIKE expected_values; 

INSERT INTO `expected_values` VALUES  

('country',   10), 

('manufacturer',      10), 

('customer',    10), 

('airline',    10), 

('city',    10), 

('airport',    10), 

('aircraft_model',    10), 

('aircraft',    10), 

('flight',    10), 

('seat_class',    10), 

('aircraft_seat',    10), 

('booking',    10), 

('flight_leg',    10); 

('booking_leg',    4); 

SELECT table_name, recs AS expected_records FROM expected_values; 

INSERT INTO found_values VALUES ('country', (SELECT COUNT(*) FROM country)); 

INSERT INTO found_values VALUES ('manufacturer', (SELECT COUNT(*) FROM manufacturer)); 

INSERT INTO found_values VALUES ('customer', (SELECT COUNT(*) FROM customer)); 

INSERT INTO found_values VALUES ('airline', (SELECT COUNT(*) FROM airline)); 

INSERT INTO found_values VALUES ('city', (SELECT COUNT(*) FROM city)); 

INSERT INTO found_values VALUES ('airport', (SELECT COUNT(*) FROM airport)); 

INSERT INTO found_values VALUES ('aircraft_model', (SELECT COUNT(*) FROM aircraft_model)); 

INSERT INTO found_values VALUES ('aircraft', (SELECT COUNT(*) FROM aircraft)); 

INSERT INTO found_values VALUES ('flight', (SELECT COUNT(*) FROM flight)); 

INSERT INTO found_values VALUES ('seat_class', (SELECT COUNT(*) FROM seat_class)); 

INSERT INTO found_values VALUES ('aircraft_seat', (SELECT COUNT(*) FROM aircraft_seat)); 

INSERT INTO found_values VALUES ('booking', (SELECT COUNT(*) FROM booking)); 

INSERT INTO found_values VALUES ('flight_leg', (SELECT COUNT(*) FROM flight_leg)); 

INSERT INTO found_values VALUES ('booking_leg', (SELECT COUNT(*) FROM booking_leg)); 

SELECT table_name, recs as 'found_records ' from found_values; 

SELECT   

    e.table_name,  

    IF(e.recs=f.recs,'OK', 'not ok') AS records_match 

from  

    expected_values e INNER JOIN found_values f USING (table_name);  

set @count_fail=(select count(*) from expected_values e inner join found_values f on (e.table_name=f.table_name) where f.recs != e.recs); 

select timediff( 

    now(), 

    (select create_time from information_schema.tables where table_schema='airline' and table_name='expected_values') 

) as computation_time; 

  

select 'count' as summary, if(@count_fail = 0, "OK", "FAIL" ) as 'result'; 