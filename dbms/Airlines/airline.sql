DROP DATABASE IF EXISTS flight_booking;
CREATE DATABASE flight_booking;
USE flight_booking;

-- Create country table
CREATE TABLE country (
    country_id INT AUTO_INCREMENT PRIMARY KEY,
    country_name VARCHAR(100) NOT NULL
);

-- Create city table
CREATE TABLE city (
    city_id INT AUTO_INCREMENT PRIMARY KEY,
    city_name VARCHAR(100) NOT NULL,
    country_id INT,
    FOREIGN KEY (country_id) REFERENCES country(country_id) ON DELETE CASCADE
);

-- Create airport table
CREATE TABLE airport (
    airport_code VARCHAR(10) PRIMARY KEY,
    airport_name VARCHAR(100) NOT NULL,
    city_id INT,
    FOREIGN KEY (city_id) REFERENCES city(city_id) ON DELETE CASCADE
);

-- Create manufacturer table
CREATE TABLE manufacturer (
    manufacturer_id INT AUTO_INCREMENT PRIMARY KEY,
    manufacturer_name VARCHAR(100) NOT NULL
);

-- Create aircraft_model table
CREATE TABLE aircraft_model (
    model_id INT AUTO_INCREMENT PRIMARY KEY,
    manufacturer_id INT,
    model_name VARCHAR(100) NOT NULL,
    FOREIGN KEY (manufacturer_id) REFERENCES manufacturer(manufacturer_id) ON DELETE CASCADE
);

-- Create airline table
CREATE TABLE airline (
    airline_id INT AUTO_INCREMENT PRIMARY KEY,
    airline_name VARCHAR(100) NOT NULL
);

-- Create aircraft table
CREATE TABLE aircraft (
    aircraft_id INT AUTO_INCREMENT PRIMARY KEY,
    aircraft_model_id INT,
    owned_by_airline_id INT,
    FOREIGN KEY (aircraft_model_id) REFERENCES aircraft_model(model_id) ON DELETE CASCADE,
    FOREIGN KEY (owned_by_airline_id) REFERENCES airline(airline_id) ON DELETE CASCADE
);

-- Create seat_class table
CREATE TABLE seat_class (
    seat_class_id INT AUTO_INCREMENT PRIMARY KEY,
    class_name VARCHAR(50) NOT NULL
);

-- Create aircraft_seat table
CREATE TABLE aircraft_seat (
    seat_id INT AUTO_INCREMENT PRIMARY KEY,
    aircraft_id INT,
    seat_class_id INT,
    FOREIGN KEY (aircraft_id) REFERENCES aircraft(aircraft_id) ON DELETE CASCADE,
    FOREIGN KEY (seat_class_id) REFERENCES seat_class(seat_class_id) ON DELETE CASCADE
);

-- Create flight table
CREATE TABLE flight (
    flight_code VARCHAR(10) PRIMARY KEY,
    airline_id INT,
    FOREIGN KEY (airline_id) REFERENCES airline(airline_id) ON DELETE CASCADE
);

-- Create leg table
CREATE TABLE leg (
    leg_id INT AUTO_INCREMENT PRIMARY KEY,
    arrival_airport_code VARCHAR(10),
    departure_airport_code VARCHAR(10),
    arrival_time DATETIME NOT NULL,
    departure_time DATETIME NOT NULL,
    aircraft_id INT,
    flight_code VARCHAR(10),
    FOREIGN KEY (arrival_airport_code) REFERENCES airport(airport_code) ON DELETE CASCADE,
    FOREIGN KEY (departure_airport_code) REFERENCES airport(airport_code) ON DELETE CASCADE,
    FOREIGN KEY (aircraft_id) REFERENCES aircraft(aircraft_id) ON DELETE CASCADE,
    FOREIGN KEY (flight_code) REFERENCES flight(flight_code) ON DELETE CASCADE
);

-- Create customer table
CREATE TABLE customer (
    customer_id INT AUTO_INCREMENT PRIMARY KEY,
    first_name VARCHAR(50) NOT NULL,
    last_name VARCHAR(50) NOT NULL,
    passport_number VARCHAR(20) NOT NULL UNIQUE,
    email_address VARCHAR(100) NOT NULL UNIQUE,
    phone_number VARCHAR(20),
    country_id INT,
    FOREIGN KEY (country_id) REFERENCES country(country_id) ON DELETE SET NULL
);

-- Create booking table
CREATE TABLE booking (
    booking_id INT AUTO_INCREMENT PRIMARY KEY,
    airline_id INT,
    customer_id INT,
    FOREIGN KEY (airline_id) REFERENCES airline(airline_id) ON DELETE CASCADE,
    FOREIGN KEY (customer_id) REFERENCES customer(customer_id) ON DELETE CASCADE
);

-- Create booking_leg table
CREATE TABLE booking_leg (
    booking_leg_id INT AUTO_INCREMENT PRIMARY KEY,
    booking_id INT,
    leg_id INT,
    seat_id INT,
    price DECIMAL(10, 2) NOT NULL,
    FOREIGN KEY (booking_id) REFERENCES booking(booking_id) ON DELETE CASCADE,
    FOREIGN KEY (leg_id) REFERENCES leg(leg_id) ON DELETE CASCADE,
    FOREIGN KEY (seat_id) REFERENCES aircraft_seat(seat_id) ON DELETE SET NULL
);

SELECT 'Schema Created Successfully' AS INFO;
