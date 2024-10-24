-- Insert Values into Customer Table
INSERT INTO customer (first_name, last_name, date_of_birth, signup_date) VALUES
('John', 'Doe', '1985-02-15', '2020-05-01'),
('Jane', 'Smith', '1990-07-20', '2021-03-10'),
('Michael', 'Johnson', '1978-09-10', '2019-11-22'),
('Emily', 'Williams', '1988-06-14', '2020-08-12'),
('David', 'Brown', '1992-01-25', '2021-02-14'),
('Emma', 'Jones', '1985-11-30', '2018-09-03'),
('Liam', 'Garcia', '1975-04-04', '2017-07-19'),
('Olivia', 'Martinez', '1980-12-24', '2022-01-05'),
('Noah', 'Davis', '1995-05-05', '2023-05-20'),
('Sophia', 'Lopez', '1983-03-18', '2021-10-31');

-- Insert Values into Account Type Table
INSERT INTO account_type (account_type) VALUES
('Savings'),
('Checking'),
('Credit Card'),
('Loan'),
('Investment'),
('Mortgage'),
('Student Loan'),
('Business Account'),
('Retirement'),
('Money Market');

-- Insert Values into Account Status Table
INSERT INTO account_status (status_value) VALUES
('Active'),
('Inactive'),
('Closed'),
('Pending'),
('Frozen'),
('Suspended'),
('Under Review'),
('Dormant'),
('Blocked'),
('Limited');

-- Insert Values into Account Table
INSERT INTO account (account_number, account_type_id, status_id, date_opened, date_closed) VALUES
(1001, 1, 1, '2020-05-01', NULL),
(1002, 2, 1, '2021-03-10', NULL),
(1003, 3, 2, '2019-11-22', '2022-01-15'),
(1004, 4, 1, '2020-08-12', NULL),
(1005, 5, 3, '2021-02-14', '2023-05-10'),
(1006, 6, 4, '2018-09-03', NULL),
(1007, 7, 5, '2017-07-19', NULL),
(1008, 8, 6, '2022-01-05', NULL),
(1009, 9, 7, '2023-05-20', NULL),
(1010, 10, 8, '2021-10-31', NULL);

-- Insert Values into Customer_Account Table (Join table)
INSERT INTO customer_account (customer_id, account_number) VALUES
(1, 1001),
(2, 1002),
(3, 1003),
(4, 1004),
(5, 1005),
(6, 1006),
(7, 1007),
(8, 1008),
(9, 1009),
(10, 1010);

-- Insert Values into Transaction Table
INSERT INTO transaction (transaction_datetime, from_account, to_account, description, amount) VALUES
('2023-05-15 10:30:00', 1001, 1002, 'Payment for services', 250.00),
('2023-06-10 14:50:00', 1002, 1003, 'Transfer to credit card', 100.00),
('2023-07-01 09:20:00', 1003, 1004, 'Loan repayment', 500.00),
('2023-07-15 13:45:00', 1004, 1005, 'Investment deposit', 300.00),
('2023-08-01 16:30:00', 1005, 1006, 'Mortgage payment', 750.00),
('2023-08-20 11:00:00', 1006, 1007, 'Business account funding', 1000.00),
('2023-09-05 12:15:00', 1007, 1008, 'Savings transfer', 200.00),
('2023-09-15 14:40:00', 1008, 1009, 'Retirement fund transfer', 400.00),
('2023-09-30 17:25:00', 1009, 1010, 'Money market investment', 600.00),
('2023-10-10 15:50:00', 1010, 1001, 'Payment for services', 150.00);
