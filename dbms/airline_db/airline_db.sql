DROP DATABASE IF EXISTS airline_db;
CREATE DATABASE IF NOT EXISTS airline_db;
USE airline_db;

SELECT 'CREATING DATABASE STRUCTURE' as 'INFO';

DROP TABLE IF EXISTS booking_leg, booking, customer, aircraft_seat, seat_class, airline, manufacturer, aircraft_model, aircraft, leg, flight, airport, city, country;

-- 1. Country Table
CREATE TABLE country (
    country_id INT PRIMARY KEY,
    country_name VARCHAR(30) NOT NULL
);

-- 2. City Table
CREATE TABLE city (
    city_id INT PRIMARY KEY,
    city_name VARCHAR(30) NOT NULL,
    country_id INT,
    FOREIGN KEY (country_id) REFERENCES country(country_id) ON DELETE CASCADE
);

-- 3. Airport Table
CREATE TABLE airport (
    airport_code VARCHAR(10) PRIMARY KEY,
    airport_name VARCHAR(50) NOT NULL,
    city_id INT,
    FOREIGN KEY (city_id) REFERENCES city(city_id) ON DELETE CASCADE
);

-- 4. Airline Table
CREATE TABLE airline (
    airline_id INT PRIMARY KEY,
    airline_name VARCHAR(30) NOT NULL
);

-- 5. Manufacturer Table
CREATE TABLE manufacturer (
    manufacturer_id INT PRIMARY KEY,
    manufacturer_name VARCHAR(20) NOT NULL
);

-- 6. Aircraft Model Table
CREATE TABLE aircraft_model (
    model_id INT PRIMARY KEY,
    manufacturer_id INT,
    model_name VARCHAR(30) NOT NULL,
    FOREIGN KEY (manufacturer_id) REFERENCES manufacturer(manufacturer_id) ON DELETE CASCADE
);

-- 7. Aircraft Table
CREATE TABLE aircraft (
    aircraft_id INT PRIMARY KEY,
    aircraft_model_id INT,
    owned_by_airline_id INT,
    FOREIGN KEY (aircraft_model_id) REFERENCES aircraft_model(model_id),
    FOREIGN KEY (owned_by_airline_id) REFERENCES airline(airline_id)
);

-- 8. Seat Class Table
CREATE TABLE seat_class (
    seat_class_id INT PRIMARY KEY,
    class_name VARCHAR(20) NOT NULL
);

-- 9. Aircraft Seat Table
CREATE TABLE aircraft_seat (
    seat_id INT PRIMARY KEY,
    aircraft_id INT,
    seat_class_id INT,
    FOREIGN KEY (aircraft_id) REFERENCES aircraft(aircraft_id),
    FOREIGN KEY (seat_class_id) REFERENCES seat_class(seat_class_id)
);

-- 10. Flight Table
CREATE TABLE flight (
    flight_code VARCHAR(10) PRIMARY KEY,
    airline_id INT,
    FOREIGN KEY (airline_id) REFERENCES airline(airline_id)
);

-- 11. Leg Table
CREATE TABLE leg (
    leg_id INT PRIMARY KEY,
    arrival_airport_code VARCHAR(10),
    departure_airport_code VARCHAR(10),
    arrival_time DATETIME,
    departure_time DATETIME,
    aircraft_id INT,
    flight_code VARCHAR(10),
    FOREIGN KEY (arrival_airport_code) REFERENCES airport(airport_code),
    FOREIGN KEY (departure_airport_code) REFERENCES airport(airport_code),
    FOREIGN KEY (aircraft_id) REFERENCES aircraft(aircraft_id),
    FOREIGN KEY (flight_code) REFERENCES flight(flight_code)
);

-- 12. Customer Table
CREATE TABLE customer (
    customer_id INT PRIMARY KEY,
    first_name VARCHAR(20) NOT NULL,
    last_name VARCHAR(20) NOT NULL,
    passport_number VARCHAR(20) NOT NULL UNIQUE,
    email_address VARCHAR(30),
    phone_number VARCHAR(15),
    country_id INT,
    FOREIGN KEY (country_id) REFERENCES country(country_id)
);

-- 13. Booking Table
CREATE TABLE booking (
    booking_id INT PRIMARY KEY,
    airline_id INT,
    customer_id INT,
    FOREIGN KEY (airline_id) REFERENCES airline(airline_id),
    FOREIGN KEY (customer_id) REFERENCES customer(customer_id)
);

-- 14. Booking Leg Table
CREATE TABLE booking_leg (
    booking_leg_id INT PRIMARY KEY,
    booking_id INT,
    leg_id INT,
    seat_id INT,
    price DECIMAL(10, 2),
    FOREIGN KEY (booking_id) REFERENCES booking(booking_id) ON DELETE CASCADE,
    FOREIGN KEY (leg_id) REFERENCES leg(leg_id),
    FOREIGN KEY (seat_id) REFERENCES aircraft_seat(seat_id)
);
show tables;



