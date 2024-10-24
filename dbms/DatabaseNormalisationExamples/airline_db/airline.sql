-- Drop database if it exists and create a new one
DROP DATABASE IF EXISTS airline_reservations;
CREATE DATABASE IF NOT EXISTS airline_reservations;
USE airline_reservations;

-- Create tables in the correct order, starting with those that are referenced by foreign keys

CREATE TABLE country (
    country_id INT PRIMARY KEY AUTO_INCREMENT,
    country_name VARCHAR(100)
);

CREATE TABLE city (
    city_id INT PRIMARY KEY AUTO_INCREMENT,
    city_name VARCHAR(100),
    country_id INT,
    FOREIGN KEY (country_id) REFERENCES country(country_id)
);

CREATE TABLE airport (
    airport_code VARCHAR(10) PRIMARY KEY,
    airport_name VARCHAR(100),
    city_id INT,
    FOREIGN KEY (city_id) REFERENCES city(city_id)
);

CREATE TABLE manufacturer (
    manufacturer_id INT PRIMARY KEY AUTO_INCREMENT,
    manufacturer_name VARCHAR(100)
);

CREATE TABLE aircraft_model (
    model_id INT PRIMARY KEY AUTO_INCREMENT,
    manufacturer_id INT,
    model_name VARCHAR(100),
    FOREIGN KEY (manufacturer_id) REFERENCES manufacturer(manufacturer_id)
);

CREATE TABLE airline (
    airline_id INT PRIMARY KEY AUTO_INCREMENT,
    airline_name VARCHAR(100)
);

CREATE TABLE aircraft (
    aircraft_id INT PRIMARY KEY AUTO_INCREMENT,
    aircraft_model_id INT,
    owned_by_airline_id INT,
    FOREIGN KEY (aircraft_model_id) REFERENCES aircraft_model(model_id),
    FOREIGN KEY (owned_by_airline_id) REFERENCES airline(airline_id)
);

CREATE TABLE seat_class (
    seat_class_id INT PRIMARY KEY AUTO_INCREMENT,
    class_name VARCHAR(50)
);

CREATE TABLE customer (
    customer_id INT PRIMARY KEY AUTO_INCREMENT,
    first_name VARCHAR(100),
    last_name VARCHAR(100),
    passport_number VARCHAR(20),
    email_address VARCHAR(100),
    phone_number VARCHAR(20),
    country_id INT,
    FOREIGN KEY (country_id) REFERENCES country(country_id)
);

CREATE TABLE booking (
    booking_id INT PRIMARY KEY AUTO_INCREMENT,
    airline_id INT,
    customer_id INT,
    FOREIGN KEY (airline_id) REFERENCES airline(airline_id),
    FOREIGN KEY (customer_id) REFERENCES customer(customer_id)
);

CREATE TABLE flight (
    flight_code VARCHAR(20) PRIMARY KEY,
    airline_id INT,
    FOREIGN KEY (airline_id) REFERENCES airline(airline_id)
);

CREATE TABLE leg (
    leg_id INT PRIMARY KEY AUTO_INCREMENT,
    arrival_airport_code VARCHAR(10),
    departure_airport_code VARCHAR(10),
    arrival_time DATETIME,
    departure_time DATETIME,
    aircraft_id INT,
    flight_code VARCHAR(20),
    FOREIGN KEY (arrival_airport_code) REFERENCES airport(airport_code),
    FOREIGN KEY (departure_airport_code) REFERENCES airport(airport_code),
    FOREIGN KEY (aircraft_id) REFERENCES aircraft(aircraft_id),
    FOREIGN KEY (flight_code) REFERENCES flight(flight_code)
);

CREATE TABLE aircraft_seat (
    seat_id INT PRIMARY KEY AUTO_INCREMENT,
    aircraft_id INT,
    seat_class_id INT,
    FOREIGN KEY (aircraft_id) REFERENCES aircraft(aircraft_id),
    FOREIGN KEY (seat_class_id) REFERENCES seat_class(seat_class_id)
);

CREATE TABLE booking_leg (
    booking_leg_id INT PRIMARY KEY AUTO_INCREMENT,
    booking_id INT,
    leg_id INT,
    seat_id INT,
    price DECIMAL(10, 2),
    FOREIGN KEY (booking_id) REFERENCES booking(booking_id),
    FOREIGN KEY (leg_id) REFERENCES leg(leg_id),
    FOREIGN KEY (seat_id) REFERENCES aircraft_seat(seat_id)
);
