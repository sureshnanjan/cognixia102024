-- Drop and create the bank database

DROP DATABASE IF EXISTS airline;

CREATE DATABASE airline;

USE airline;
 
-- Show info about creating the database structure

SELECT 'CREATING DATABASE STRUCTURE' as 'INFO';
 
-- Drop existing tables if they exist

DROP TABLE IF EXISTS country, manufacturer, customer, airline, city, airport, aircraft_model, aircraft, flight, seat_class, aircraft_seat, booking, flight_leg, booking_leg;

-- Country Table

CREATE TABLE country (

    country_id INT PRIMARY KEY,

    country_name VARCHAR(100) NOT NULL

);
 
-- Manufacturer Table

CREATE TABLE manufacturer (

    manufacturer_id INT PRIMARY KEY,

    manufacturer_name VARCHAR(100) NOT NULL

);
 
-- Customer Table

CREATE TABLE customer (

    customer_id INT PRIMARY KEY,

    country_id INT,

    first_name VARCHAR(100),

    last_name VARCHAR(100),

    passport_number VARCHAR(50),

    email_address VARCHAR(100),

    phone_number VARCHAR(15),

    FOREIGN KEY (country_id) REFERENCES country(country_id)

);
 
-- Airline Table

CREATE TABLE airline (

    airline_id INT PRIMARY KEY,

    airline_name VARCHAR(100) NOT NULL

);
 
-- City Table

CREATE TABLE city (

    city_id INT PRIMARY KEY,

    country_id INT,

    city_name VARCHAR(100),

    FOREIGN KEY (country_id) REFERENCES country(country_id)

);
 
-- Airport Table

CREATE TABLE airport (

    airport_code VARCHAR(10) PRIMARY KEY,

    city_id INT,

    airport_name VARCHAR(100),

    FOREIGN KEY (city_id) REFERENCES city(city_id)

);
 
-- Aircraft_Model Table

CREATE TABLE aircraft_model (

    model_id INT PRIMARY KEY,

    manufacturer_id INT,

    model_name VARCHAR(100),

    FOREIGN KEY (manufacturer_id) REFERENCES manufacturer(manufacturer_id)

);
 
-- Aircraft Table

CREATE TABLE aircraft (

    aircraft_id INT PRIMARY KEY,

    model_id INT,

    owned_by_airline_id INT,

    FOREIGN KEY (model_id) REFERENCES aircraft_model(model_id),

    FOREIGN KEY (owned_by_airline_id) REFERENCES airline(airline_id)

);
 
-- Flight Table

CREATE TABLE flight (

    flight_code VARCHAR(10) PRIMARY KEY,

    airline_id INT,

    FOREIGN KEY (airline_id) REFERENCES airline(airline_id)

);
 
-- Seat_Class Table

CREATE TABLE seat_class (

    seat_class_id INT PRIMARY KEY,

    class_name VARCHAR(50)

);
 
-- Aircraft_Seat Table

CREATE TABLE aircraft_seat (

    seat_id INT PRIMARY KEY,

    aircraft_id INT,

    seat_class_id INT,

    FOREIGN KEY (aircraft_id) REFERENCES aircraft(aircraft_id),

    FOREIGN KEY (seat_class_id) REFERENCES seat_class(seat_class_id)

);
 
-- Booking Table

CREATE TABLE booking (

    booking_id INT PRIMARY KEY,

    airline_id INT,

    customer_id INT,

    FOREIGN KEY (airline_id) REFERENCES airline(airline_id),

    FOREIGN KEY (customer_id) REFERENCES customer(customer_id)

);
 
-- Flight_Leg Table

CREATE TABLE flight_leg (

    leg_id INT PRIMARY KEY,

    flight_code VARCHAR(10),

    arrival_airport_code VARCHAR(10),

    departure_airport_code VARCHAR(10),

    aircraft_id INT,

    arrival_time TIMESTAMP,

    departure_time TIMESTAMP,

    FOREIGN KEY (flight_code) REFERENCES flight(flight_code),

    FOREIGN KEY (arrival_airport_code) REFERENCES airport(airport_code),

    FOREIGN KEY (departure_airport_code) REFERENCES airport(airport_code),

    FOREIGN KEY (aircraft_id) REFERENCES aircraft(aircraft_id)

);
 
-- Booking_Leg Table

CREATE TABLE booking_leg (

    booking_leg_id INT PRIMARY KEY,

    booking_id INT,

    leg_id INT,

    seat_id INT,

    price DECIMAL(10, 2),

    FOREIGN KEY (booking_id) REFERENCES booking(booking_id),

    FOREIGN KEY (leg_id) REFERENCES flight_leg(leg_id),

    FOREIGN KEY (seat_id) REFERENCES aircraft_seat(seat_id)

);
SELECT 'LOADING country' as 'INFO'; 

source country.dump;

SELECT 'LOADING manufacturer' as 'INFO'; 

source manufacturer.dump;

SELECT 'LOADING customer' as 'INFO'; 

source customer.dump; 

SELECT 'LOADING airline' as 'INFO'; 

source airline.dump;

SELECT 'LOADING city' as 'INFO'; 

source city.dump; 

SELECT 'LOADING airport' as 'INFO'; 

source airport.dump; 

SELECT 'LOADING aircraft_model' as 'INFO'; 

source aircraft_model.dump;

SELECT 'LOADING aircraft' as 'INFO'; 

source aircraft.dump;  

SELECT 'LOADING flight' as 'INFO'; 

source flight.dump; 

SELECT 'LOADING seat_class' as 'INFO'; 

source seat_class.dump; 
  
SELECT 'LOADING aircraft_seat' as 'INFO'; 

source aircraft_seat.dump; 

SELECT 'LOADING booking' as 'INFO'; 

source booking.dump; 

SELECT 'LOADING flight_leg' as 'INFO'; 

source flight_leg.dump; 

SELECT 'LOADING booking_leg' as 'INFO'; 

source booking_leg.dump; 
