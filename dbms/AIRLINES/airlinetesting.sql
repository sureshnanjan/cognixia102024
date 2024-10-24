

-- Validation Script
USE flight_db;

DROP TABLE IF EXISTS expected_values, found_values;
CREATE TABLE expected_values (
    table_name VARCHAR(30) NOT NULL PRIMARY KEY,
    recs INT NOT NULL,
    crc_sha VARCHAR(100) NOT NULL,
    crc_md5 VARCHAR(100) NOT NULL
);

CREATE TABLE found_values LIKE expected_values;

INSERT INTO expected_values VALUES 
('airline',   5, '4d4aa689914d8fd41db7e45c2168e7dcb9697359', '4ec56ab5ba37218d187cf6ab09ce1aa1'),
('country',   3, '4b315afa0e35ca6649df897b958345bcb3d2b764', 'd1af5e170d2d1591d776d5638d71fc5f'),
('city',      10, 'a5b8f6a307efda82c7c721e68d4e8f99', 'eaa378f39bdbf0f39e2e6aeb9378fd4b'),
('airport',   15, '3f17eeb95f375c9e9162cf3f5eac75e2', 'caa0c2a9f5198a194b5aefad4b84cb8'),
('aircraft',  8, '81b5bfc9c0e6b88a6f6e88ef4de0e9b4', 'ff6c67883e186a1c487a5cf0cb4ab8f5'),
('leg',       12, 'd12d5f746b88f07e69b9e36675b6067abb01b60e', 'bfa016c472df68e70a03facafa1bc0a8'),
('booking',   7, '6f17c34c564e4321b1c913299b8e700f', '3a1b68e6fa2a3b4aa4688481f3a5d899'),
('customer',  20, 'f66c9c62a8e7c27f24d0e27d82887f3a', 'a7c3c67e2db77d4d76e94799f0b0a69f'),
('booking_leg', 30, '56f17c34c564e4321b1c913299b8e700f', 'bc7c7bca6b4724c1ef988c1d4917f250');

SELECT table_name, recs AS expected_records, crc_md5 AS expected_crc FROM expected_values;

DROP TABLE IF EXISTS tchecksum;
CREATE TABLE tchecksum (chk CHAR(100));

SET @crc= '';

INSERT INTO tchecksum 
    SELECT @crc := MD5(CONCAT_WS('#', @crc, airline_name)) 
    FROM airline ORDER BY airline_id;
INSERT INTO found_values VALUES ('airline', (SELECT COUNT(*) FROM airline), @crc, @crc);

SET @crc = '';
INSERT INTO tchecksum 
    SELECT @crc := MD5(CONCAT_WS('#', @crc, country_name)) 
    FROM country ORDER BY country_id;
INSERT INTO found_values VALUES ('country', (SELECT COUNT(*) FROM country), @crc, @crc);

SET @crc = '';
INSERT INTO tchecksum 
    SELECT @crc := MD5(CONCAT_WS('#', @crc, city_name, country_id)) 
    FROM city ORDER BY city_id;
INSERT INTO found_values VALUES ('city', (SELECT COUNT(*) FROM city), @crc, @crc);

SET @crc = '';
INSERT INTO tchecksum 
    SELECT @crc := MD5(CONCAT_WS('#', @crc, airport_name, city_id)) 
    FROM airport ORDER BY airport_code;
INSERT INTO found_values VALUES ('airport', (SELECT COUNT(*) FROM airport), @crc, @crc);

SET @crc = '';
INSERT INTO tchecksum 
    SELECT @crc := MD5(CONCAT_WS('#', @crc, model_name, manufacturer_id)) 
    FROM aircraft_model ORDER BY model_id;
INSERT INTO found_values VALUES ('aircraft_model', (SELECT COUNT(*) FROM aircraft_model), @crc, @crc);

SET @crc = '';
INSERT INTO tchecksum 
    SELECT @crc := MD5(CONCAT_WS('#', @crc, aircraft_model_id, owned_by_airline_id)) 
    FROM aircraft ORDER BY aircraft_id;
INSERT INTO found_values VALUES ('aircraft', (SELECT COUNT(*) FROM aircraft), @crc, @crc);

SET @crc = '';
INSERT INTO tchecksum 
    SELECT @crc := MD5(CONCAT_WS('#', @crc, class_name)) 
    FROM seat_class ORDER BY seat_class_id;
INSERT INTO found_values VALUES ('seat_class', (SELECT COUNT(*) FROM seat_class), @crc, @crc);

SET @crc = '';
INSERT INTO tchecksum 
    SELECT @crc := MD5(CONCAT_WS('#', @crc, seat_id, aircraft_id, seat_class_id)) 
    FROM aircraft_seat ORDER BY seat_id;
INSERT INTO found_values VALUES ('aircraft_seat', (SELECT COUNT(*) FROM aircraft_seat), @crc, @crc);

SET @crc = '';
INSERT INTO tchecksum 
    SELECT @crc := MD5(CONCAT_WS('#', @crc, first_name, last_name, passport_number, email_address, phone_number, country_id)) 
    FROM customer ORDER BY customer_id;
INSERT INTO found_values VALUES
