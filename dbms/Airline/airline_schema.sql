-- Create the Airline Reservations Database
DROP DATABASE IF EXISTS airline_reservations;
CREATE DATABASE airline_reservations;
USE airline_reservations;

SELECT 'CREATING DATABASE STRUCTURE' AS 'INFO';

-- Drop tables if they exist
DROP TABLE IF EXISTS customers,
                     airports,
                     airlines,
                     aircraft_models,
                     aircrafts,
                     flights,
                     legs,
                     bookings,
                     booking_details;

-- Create tables
CREATE TABLE customers (
    customer_id INT NOT NULL AUTO_INCREMENT,
    first_name VARCHAR(50) NOT NULL,
    last_name VARCHAR(50) NOT NULL,
    passport_number VARCHAR(20) NOT NULL UNIQUE,
    email VARCHAR(255) NOT NULL UNIQUE,
    phone_number VARCHAR(20),
    registration_date DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
    PRIMARY KEY (customer_id)
);

CREATE TABLE airports (
    airport_id INT NOT NULL AUTO_INCREMENT,
    name VARCHAR(100) NOT NULL,
    city VARCHAR(100) NOT NULL,
    country VARCHAR(100) NOT NULL,
    PRIMARY KEY (airport_id)
);

CREATE TABLE airlines (
    airline_id INT NOT NULL AUTO_INCREMENT,
    name VARCHAR(100) NOT NULL,
    IATA_code VARCHAR(3) NOT NULL UNIQUE,
    PRIMARY KEY (airline_id)
);

CREATE TABLE aircraft_models (
    model_id INT NOT NULL AUTO_INCREMENT,
    manufacturer VARCHAR(100) NOT NULL,
    configuration TEXT,
    PRIMARY KEY (model_id)
);

CREATE TABLE aircrafts (
    aircraft_id INT NOT NULL AUTO_INCREMENT,
    registration_number VARCHAR(20) NOT NULL UNIQUE,
    model_id INT NOT NULL,
    airline_id INT NOT NULL,
    PRIMARY KEY (aircraft_id),
    FOREIGN KEY (model_id) REFERENCES aircraft_models(model_id) ON DELETE CASCADE,
    FOREIGN KEY (airline_id) REFERENCES airlines(airline_id) ON DELETE CASCADE
);

CREATE TABLE flights (
    flight_id INT NOT NULL AUTO_INCREMENT,
    flight_code VARCHAR(10) NOT NULL UNIQUE,
    airline_id INT NOT NULL,
    PRIMARY KEY (flight_id),
    FOREIGN KEY (airline_id) REFERENCES airlines(airline_id) ON DELETE CASCADE
);

CREATE TABLE legs (
    leg_id INT NOT NULL AUTO_INCREMENT,
    flight_id INT NOT NULL,
    departure_airport_id INT NOT NULL,
    arrival_airport_id INT NOT NULL,
    departure_time DATETIME NOT NULL,
    arrival_time DATETIME NOT NULL,
    aircraft_id INT NOT NULL,
    PRIMARY KEY (leg_id),
    FOREIGN KEY (flight_id) REFERENCES flights(flight_id) ON DELETE CASCADE,
    FOREIGN KEY (departure_airport_id) REFERENCES airports(airport_id) ON DELETE CASCADE,
    FOREIGN KEY (arrival_airport_id) REFERENCES airports(airport_id) ON DELETE CASCADE,
    FOREIGN KEY (aircraft_id) REFERENCES aircrafts(aircraft_id) ON DELETE CASCADE
);

CREATE TABLE bookings (
    booking_id INT NOT NULL AUTO_INCREMENT,
    customer_id INT NOT NULL,
    flight_id INT NOT NULL,
    booking_date DATETIME NOT NULL DEFAULT CURRENT_TIMESTAMP,
    total_amount DECIMAL(15, 2) NOT NULL,
    PRIMARY KEY (booking_id),
    FOREIGN KEY (customer_id) REFERENCES customers(customer_id) ON DELETE CASCADE,
    FOREIGN KEY (flight_id) REFERENCES flights(flight_id) ON DELETE CASCADE
);

CREATE TABLE booking_details (
    booking_detail_id INT NOT NULL AUTO_INCREMENT,
    booking_id INT NOT NULL,
    leg_id INT NOT NULL,
    seat_class ENUM('First Class', 'Business Class', 'Economy') NOT NULL,
    price DECIMAL(10, 2) NOT NULL,
    PRIMARY KEY (booking_detail_id),
    FOREIGN KEY (booking_id) REFERENCES bookings(booking_id) ON DELETE CASCADE,
    FOREIGN KEY (leg_id) REFERENCES legs(leg_id) ON DELETE CASCADE
);
SELECT 'DATABASE STRUCTURE CREATED' AS 'INFO';
source airline_dump.dump
