DROP DATABASE IF EXISTS airline_booking;
CREATE DATABASE airline_booking;
USE airline_booking;

CREATE TABLE country (
    country_id INT PRIMARY KEY,
    country_name VARCHAR(255)
);

CREATE TABLE airline (
    airline_id INT PRIMARY KEY,
    airline_name VARCHAR(255)
);

CREATE TABLE manufacturer (
    manufacturer_id INT PRIMARY KEY,
    manufacturer_name VARCHAR(255)
);

CREATE TABLE aircraft_model (
    model_id INT PRIMARY KEY,
    manufacturer_id INT,
    model_name VARCHAR(255),
    FOREIGN KEY (manufacturer_id) REFERENCES manufacturer(manufacturer_id)
);

CREATE TABLE customer (
    customer_id INT PRIMARY KEY,
    country_id INT,
    first_name VARCHAR(100),
    last_name VARCHAR(100),
    passport_number VARCHAR(50),
    email_address VARCHAR(255),
    phone_number VARCHAR(20),
    FOREIGN KEY (country_id) REFERENCES country(country_id)
);

CREATE TABLE aircraft (
    aircraft_id INT PRIMARY KEY,
    aircraft_model_id INT,
    owned_by_airline_id INT,
    FOREIGN KEY (aircraft_model_id) REFERENCES aircraft_model(model_id),
    FOREIGN KEY (owned_by_airline_id) REFERENCES airline(airline_id)
);

CREATE TABLE airport (
    airport_code CHAR(3) PRIMARY KEY,
    city_id INT,
    airport_name VARCHAR(255),
    city VARCHAR(255)
);

CREATE TABLE flight (
    flight_code CHAR(6) PRIMARY KEY,
    airline_id INT,
    FOREIGN KEY (airline_id) REFERENCES airline(airline_id)
);

CREATE TABLE seat_class (
    seat_class_id INT PRIMARY KEY,
    class_name VARCHAR(100)
);

CREATE TABLE aircraft_seat (
    seat_id INT PRIMARY KEY,
    aircraft_id INT,
    seat_class_id INT,
    FOREIGN KEY (aircraft_id) REFERENCES aircraft(aircraft_id),
    FOREIGN KEY (seat_class_id) REFERENCES seat_class(seat_class_id)
);

CREATE TABLE leg (
    leg_id INT PRIMARY KEY,
    arrival_airport_code CHAR(3),
    departure_airport_code CHAR(3),
    flight_code CHAR(6),
    aircraft_id INT,
    arrival_time DATETIME,
    departure_time DATETIME,
    FOREIGN KEY (arrival_airport_code) REFERENCES airport(airport_code),
    FOREIGN KEY (departure_airport_code) REFERENCES airport(airport_code),
    FOREIGN KEY (flight_code) REFERENCES flight(flight_code),
    FOREIGN KEY (aircraft_id) REFERENCES aircraft(aircraft_id)
);

CREATE TABLE booking (
    booking_id INT PRIMARY KEY,
    airline_id INT,
    customer_id INT,
    FOREIGN KEY (airline_id) REFERENCES airline(airline_id),
    FOREIGN KEY (customer_id) REFERENCES customer(customer_id)
);

CREATE TABLE booking_leg (
    booking_leg_id INT PRIMARY KEY,
    booking_id INT,
    leg_id INT,
    seat_id INT,
    price DECIMAL(10, 2),
    FOREIGN KEY (booking_id) REFERENCES booking(booking_id),
    FOREIGN KEY (leg_id) REFERENCES leg(leg_id),
    FOREIGN KEY (seat_id) REFERENCES aircraft_seat(seat_id)
);