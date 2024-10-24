-- Sample flight database 
-- This script is for validating expected and actual values after data insertion
-- Disclaimer: The data is fabricated for testing purposes only.

DROP DATABASE IF EXISTS flight_db;
CREATE DATABASE IF NOT EXISTS flight_db;
USE flight_db;

SELECT 'CREATING DATABASE STRUCTURE' AS 'INFO';

DROP TABLE IF EXISTS flight, leg, airport, country, city, aircraft, aircraft_model, manufacturer, airline, aircraft_seat, seat_class, customer, booking, booking_leg;

/*!50503 set default_storage_engine = InnoDB */;
/*!50503 select CONCAT('storage engine: ', @@default_storage_engine) AS INFO */;

CREATE TABLE airline (
    airline_id INT AUTO_INCREMENT PRIMARY KEY,
    airline_name VARCHAR(100) NOT NULL
);

CREATE TABLE country (
    country_id INT AUTO_INCREMENT PRIMARY KEY,
    country_name VARCHAR(100) NOT NULL
);

CREATE TABLE city (
    city_id INT AUTO_INCREMENT PRIMARY KEY,
    city_name VARCHAR(100) NOT NULL,
    country_id INT,
    FOREIGN KEY (country_id) REFERENCES country(country_id)
);

CREATE TABLE airport (
    airport_code VARCHAR(10) PRIMARY KEY,
    airport_name VARCHAR(100) NOT NULL,
    city_id INT,
    FOREIGN KEY (city_id) REFERENCES city(city_id)
);

CREATE TABLE aircraft_model (
    model_id INT AUTO_INCREMENT PRIMARY KEY,
    manufacturer_id INT,
    model_name VARCHAR(100) NOT NULL,
    FOREIGN KEY (manufacturer_id) REFERENCES manufacturer(manufacturer_id)
);

CREATE TABLE manufacturer (
    manufacturer_id INT AUTO_INCREMENT PRIMARY KEY,
    manufacturer_name VARCHAR(100) NOT NULL
);

CREATE TABLE aircraft (
    aircraft_id INT AUTO_INCREMENT PRIMARY KEY,
    aircraft_model_id INT,
    owned_by_airline_id INT,
    FOREIGN KEY (aircraft_model_id) REFERENCES aircraft_model(model_id),
    FOREIGN KEY (owned_by_airline_id) REFERENCES airline(airline_id)
);

CREATE TABLE seat_class (
    seat_class_id INT AUTO_INCREMENT PRIMARY KEY,
    class_name VARCHAR(50) NOT NULL
);

CREATE TABLE aircraft_seat (
    seat_id INT AUTO_INCREMENT PRIMARY KEY,
    aircraft_id INT,
    seat_class_id INT,
    FOREIGN KEY (aircraft_id) REFERENCES aircraft(aircraft_id),
    FOREIGN KEY (seat_class_id) REFERENCES seat_class(seat_class_id)
);

CREATE TABLE flight (
    flight_code VARCHAR(10) PRIMARY KEY,
    airline_id INT,
    FOREIGN KEY (airline_id) REFERENCES airline(airline_id)
);

CREATE TABLE leg (
    leg_id INT AUTO_INCREMENT PRIMARY KEY,
    arrival_airport_code VARCHAR(10),
    departure_airport_code VARCHAR(10),
    arrival_time DATETIME NOT NULL,
    departure_time DATETIME NOT NULL,
    aircraft_id INT,
    flight_code VARCHAR(10),
    FOREIGN KEY (arrival_airport_code) REFERENCES airport(airport_code),
    FOREIGN KEY (departure_airport_code) REFERENCES airport(airport_code),
    FOREIGN KEY (aircraft_id) REFERENCES aircraft(aircraft_id),
    FOREIGN KEY (flight_code) REFERENCES flight(flight_code)
);

CREATE TABLE customer (
    customer_id INT AUTO_INCREMENT PRIMARY KEY,
    first_name VARCHAR(50) NOT NULL,
    last_name VARCHAR(50) NOT NULL,
    passport_number VARCHAR(20) NOT NULL,
    email_address VARCHAR(100),
    phone_number VARCHAR(15),
    country_id INT,
    FOREIGN KEY (country_id) REFERENCES country(country_id)
);

CREATE TABLE booking (
    booking_id INT AUTO_INCREMENT PRIMARY KEY,
    airline_id INT,
    customer_id INT,
    FOREIGN KEY (airline_id) REFERENCES airline(airline_id),
    FOREIGN KEY (customer_id) REFERENCES customer(customer_id)
);

CREATE TABLE booking_leg (
    booking_leg_id INT AUTO_INCREMENT PRIMARY KEY,
    booking_id INT,
    leg_id INT,
    seat_id INT,
    price DECIMAL(10, 2) NOT NULL,
    FOREIGN KEY (booking_id) REFERENCES booking(booking_id),
    FOREIGN KEY (leg_id) REFERENCES leg(leg_id),
    FOREIGN KEY (seat_id) REFERENCES aircraft_seat(seat_id)
);

SELECT 'TABLE STRUCTURE CREATED' AS 'INFO';