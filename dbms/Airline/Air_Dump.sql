-- Insert sample data into country table
INSERT INTO country (country_name) VALUES
('United States'),
('Canada'),
('United Kingdom'),
('Australia'),
('Germany'),
('France'),
('Japan'),
('India'),
('Brazil'),
('Mexico');

-- Insert sample data into city table
INSERT INTO city (city_name, country_id) VALUES
('New York', 1),
('Toronto', 2),
('London', 3),
('Sydney', 4),
('Berlin', 5),
('Paris', 6),
('Tokyo', 7),
('Mumbai', 8),
('São Paulo', 9),
('Mexico City', 10);

-- Insert sample data into airport table
INSERT INTO airport (airport_code, airport_name, city_id) VALUES
('JFK', 'John F. Kennedy International Airport', 1),
('YYZ', 'Toronto Pearson International Airport', 2),
('LHR', 'Heathrow Airport', 3),
('SYD', 'Sydney Kingsford Smith Airport', 4),
('TXL', 'Berlin Tegel Airport', 5),
('CDG', 'Charles de Gaulle Airport', 6),
('NRT', 'Narita International Airport', 7),
('BOM', 'Chhatrapati Shivaji Maharaj International Airport', 8),
('GRU', 'São Paulo/Guarulhos–Governador André Franco Montoro International Airport', 9),
('MEX', 'Mexico City International Airport', 10);

-- Insert sample data into manufacturer table
INSERT INTO manufacturer (manufacturer_name) VALUES
('Boeing'),
('Airbus'),
('Embraer'),
('Bombardier'),
('Lockheed Martin');

-- Insert sample data into aircraft_model table
INSERT INTO aircraft_model (manufacturer_id, model_name) VALUES
(1, 'Boeing 737'),
(1, 'Boeing 747'),
(2, 'Airbus A320'),
(2, 'Airbus A380'),
(3, 'Embraer E190');

-- Insert sample data into airline table
INSERT INTO airline (airline_name) VALUES
('American Airlines'),
('Air Canada'),
('British Airways'),
('Qantas'),
('Lufthansa');

-- Insert sample data into aircraft table
INSERT INTO aircraft (aircraft_model_id, owned_by_airline_id) VALUES
(1, 1),
(2, 1),
(3, 2),
(4, 3),
(5, 4);

INSERT INTO seat_class (seat_class_id, class_name) VALUES
(1, 'Economy'),
(2, 'Business'),
(3, 'First'),
(4, 'Premium Economy'),
(5, 'Basic Economy');


-- Insert sample data into aircraft_seat table
INSERT INTO aircraft_seat (aircraft_id, seat_class_id) VALUES
(1, 1),
(1, 2),
(1, 3),
(2, 1),
(2, 2),
(3, 1),
(3, 2),
(4, 1),
(4, 2),
(5, 1);

-- Insert sample data into flight table
INSERT INTO flight (flight_code, airline_id) VALUES
('AA100', 1),
('AC200', 2),
('BA300', 3),
('QF400', 4),
('LH500', 5);

-- Insert sample data into leg table
INSERT INTO leg (arrival_airport_code, departure_airport_code, arrival_time, departure_time, aircraft_id, flight_code) VALUES
('YYZ', 'JFK', '2023-12-01 14:00:00', '2023-12-01 12:00:00', 1, 'AA100'),
('LHR', 'JFK', '2023-12-02 15:00:00', '2023-12-02 13:00:00', 2, 'BA300'),
('SYD', 'YYZ', '2023-12-03 10:00:00', '2023-12-03 08:00:00', 3, 'QF400'),
('CDG', 'TXL', '2023-12-04 16:00:00', '2023-12-04 14:00:00', 4, 'LH500'),
('NRT', 'SYD', '2023-12-05 12:00:00', '2023-12-05 10:00:00', 5, 'AC200');

-- Insert sample data into customer table
INSERT INTO customer (first_name, last_name, passport_number, email_address, phone_number, country_id) VALUES
('John', 'Doe', 'P123456789', 'john@example.com', '555-1234', 1),
('Jane', 'Smith', 'P987654321', 'jane@example.com', '555-5678', 2),
('Alice', 'Johnson', 'P456789123', 'alice@example.com', '555-8765', 3),
('Bob', 'Brown', 'P321654987', 'bob@example.com', '555-4321', 4),
('Charlie', 'White', 'P159753486', 'charlie@example.com', '555-2468', 5),
('David', 'Black', 'P753159852', 'david@example.com', '555-1357', 6),
('Eve', 'Green', 'P852963741', 'eve@example.com', '555-8642', 7),
('Frank', 'Yellow', 'P963258147', 'frank@example.com', '555-9512', 8),
('Grace', 'Pink', 'P147258369', 'grace@example.com', '555-7531', 9),
('Henry', 'Gray', 'P369258147', 'henry@example.com', '555-3214', 10);

-- Insert sample data into booking table
INSERT INTO booking (airline_id, customer_id) VALUES
(1, 1),
(2, 2),
(3, 3),
(4, 4),
(5, 5),
(1, 6),
(2, 7),
(3, 8),
(4, 9),
(5, 10);

-- Insert sample data into booking_leg table
INSERT INTO booking_leg (booking_id, leg_id, seat_id, price) VALUES
(1, 1, 1, 200.00),
(2, 2, 2, 150.00),
(3, 3, 3, 300.00),
(4, 4, 4, 250.00),
(5, 5, 5, 350.00),
(6, 1, 1, 200.00),
(7, 2, 2, 150.00),
(8, 3, 3, 300.00),
(9, 4, 4, 250.00),
(10, 5, 5, 350.00);

SELECT 'Sample Data Inserted Successfully' AS INFO;