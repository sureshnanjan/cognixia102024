-- Insert sample data into tables
INSERT INTO customers (first_name, last_name, passport_number, email, phone_number) VALUES
('John', 'Doe', 'X123456789', 'johndoe@example.com', '555-1234'),
('Jane', 'Smith', 'X987654321', 'janesmith@example.com', '555-5678'),
('Michael', 'Johnson', 'X112233445', 'michael.johnson@example.com', '555-9876'),
('Emily', 'Davis', 'X556677889', 'emily.davis@example.com', '555-6543');

INSERT INTO airports (name, city, country) VALUES
('Los Angeles International Airport', 'Los Angeles', 'USA'),
('John F. Kennedy International Airport', 'New York', 'USA'),
('Heathrow Airport', 'London', 'UK');

INSERT INTO airlines (name, IATA_code) VALUES
('American Airlines', 'AA'),
('Delta Airlines', 'DL'),
('British Airways', 'BA');

INSERT INTO aircraft_models (manufacturer, configuration) VALUES
('Boeing', '2-4-2'),
('Airbus', '3-3'),
('Embraer', '1-2');

INSERT INTO aircrafts (registration_number, model_id, airline_id) VALUES
('N12345', 1, 1),
('N67890', 2, 2),
('N54321', 3, 3);

INSERT INTO flights (flight_code, airline_id) VALUES
('AA100', 1),
('DL200', 2),
('BA300', 3);

INSERT INTO legs (flight_id, departure_airport_id, arrival_airport_id, departure_time, arrival_time, aircraft_id) VALUES
(1, 1, 2, '2023-11-01 08:00:00', '2023-11-01 14:00:00', 1),
(2, 2, 3, '2023-11-02 09:00:00', '2023-11-02 15:00:00', 2),
(3, 3, 1, '2023-11-03 10:00:00', '2023-11-03 16:00:00', 3);

INSERT INTO bookings (customer_id, flight_id, total_amount) VALUES
(1, 1, 250.00),
(2, 2, 300.00),
(3, 3, 150.00),
(4, 1, 200.00);

INSERT INTO booking_details (booking_id, leg_id, seat_class, price) VALUES
(1, 1, 'Economy', 250.00),
(2, 2, 'Business Class', 300.00),
(3, 3, 'First Class', 150.00),
(4, 1, 'Economy', 200.00);
