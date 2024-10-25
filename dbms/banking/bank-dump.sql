INSERT INTO customer (customer_id, first_name, last_name, date_of_birth, signup_date)
VALUES 
(1, 'John', 'Doe', '1985-05-15', '2024-01-10'),
(2, 'Jane', 'Smith', '1990-07-20', '2024-02-12'),
(3, 'Alice', 'Johnson', '1978-03-25', '2024-03-05'),
(4, 'Bob', 'Brown', '1982-11-12', '2024-04-07'),
(5, 'Charlie', 'Davis', '1995-09-18', '2024-05-19'),
(6, 'Emily', 'Wilson', '1988-06-05', '2024-06-20'),
(7, 'Frank', 'Miller', '1975-02-22', '2024-07-23'),
(8, 'Grace', 'Lee', '1992-12-30', '2024-08-11'),
(9, 'Henry', 'White', '1987-10-14', '2024-09-13'),
(10, 'Isabella', 'Martinez', '1994-04-27', '2024-10-15');
INSERT INTO account_type (account_type_id, account_type) VALUES
(1, 'Savings'),
(2, 'Checking'),
(3, 'Business'),
(4, 'Joint'),
(5, 'Fixed Deposit'),
(6, 'Recurring Deposit'),
(7, 'Student'),
(8, 'Retirement'),
(9, 'Investment'),
(10, 'Salary');
INSERT INTO account_status (status_id, status_value) VALUES
(1, 'Active'),
(2, 'Inactive'),
(3, 'Closed'),
(4, 'Frozen'),
(5, 'Pending'),
(6, 'Dormant'),
(7, 'Suspended'),
(8, 'Terminated'),
(9, 'Blocked'),
(10, 'Hold');
INSERT INTO account (account_number, account_type_id, status_id, date_opened, date_closed) VALUES
(101, 1, 1, '2024-01-05', NULL),
(102, 2, 1, '2024-02-15', NULL),
(103, 1, 3, '2024-01-10', '2024-06-20'),
(104, 3, 2, '2024-03-05', NULL),
(105, 5, 1, '2024-04-11', NULL),
(106, 4, 4, '2024-05-22', NULL),
(107, 6, 1, '2024-06-30', NULL),
(108, 7, 6, '2024-02-17', NULL),
(109, 9, 1, '2024-07-05', NULL),
(110, 10, 7, '2024-03-20', NULL);
INSERT INTO customer_account (customer_id, account_number) VALUES
(1, 101),
(2, 102),
(3, 103),
(4, 104),
(5, 105),
(6, 106),
(7, 107),
(8, 108),
(9, 109),
(10, 110);
INSERT INTO transaction (transaction_id, transaction_datetime, from_account, to_account, description, amount) VALUES
(1001, '2024-07-01 10:30:00', 101, 102, 'Transfer to Jane Smith', 500.00),
(1002, '2024-07-01 12:15:00', 102, 101, 'Refund from Jane Smith', 100.00),
(1003, '2024-07-02 09:45:00', 101, 103, 'Payment to Alice Johnson', 150.00),
(1004, '2024-07-03 14:00:00', 104, 105, 'Transfer to Fixed Deposit', 700.00),
(1005, '2024-07-04 16:30:00', 106, 107, 'Joint account to Recurring Deposit', 200.00),
(1006, '2024-07-05 18:20:00', 108, 109, 'Transfer to Investment account', 900.00),
(1007, '2024-07-06 11:10:00', 110, 105, 'Salary to Fixed Deposit', 300.00),
(1008, '2024-07-07 09:00:00', 105, 106, 'Transfer to Joint account', 450.00),
(1009, '2024-07-08 13:30:00', 103, 104, 'Business account payment', 600.00),
(1010, '2024-07-09 15:00:00', 102, 109, 'Checking to Investment', 800.00);





