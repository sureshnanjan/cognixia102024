INSERT INTO account_status(status_id, status_value) VALUES
(1, 'Active'),
(2, 'Inactive'),
(3, 'Dormant'),
(4, 'Closed'),
(5, 'Blocked'),
(6, 'Frozen'),
(7, 'Overdrawn'),
(8, 'Pending Verification'),
(9, 'Suspended'),
(10, 'Under Review');

INSERT INTO customer(customer_id, first_name, last_name, date_of_birth, signup_date) VALUES
(1, 'John', 'Doe', '1990-05-12', '2023-01-15'),
(2, 'Jane', 'Smith', '1985-03-24', '2022-07-20'),
(3, 'Alice', 'Johnson', '1992-11-30', '2021-10-10'),
(4, 'Bob', 'Williams', '1988-09-14', '2022-12-05'),
(5, 'Charlie', 'Brown', '1995-06-18', '2023-06-30'),
(6, 'David', 'Miller', '1991-02-25', '2023-03-18'),
(7, 'Eve', 'Davis', '1983-07-21', '2020-08-22'),
(8, 'Frank', 'Wilson', '1997-01-11', '2021-05-01'),
(9, 'Grace', 'Taylor', '1996-04-08', '2023-04-07'),
(10, 'Hannah', 'Moore', '1993-12-19', '2022-02-11'),
(11, 'Isaac', 'Clark', '1980-08-15', '2023-09-09'),
(12, 'Julia', 'Garcia', '1989-04-03', '2022-11-18'),
(13, 'Kevin', 'Martinez', '1994-01-29', '2023-02-22'),
(14, 'Laura', 'Rodriguez', '1987-07-11', '2021-12-04'),
(15, 'Michael', 'Lopez', '1998-10-27', '2023-07-15');

INSERT INTO account_type(account_type_id, account_type) VALUES
(1, 'Savings'),
(2, 'Current'),
(3, 'Salary'),
(4, 'Fixed Deposit'),
(5, 'NRI');

INSERT INTO account(account_number, account_type_id, status_id, date_opened, date_closed) VALUES
(1001, 1, 1, '2023-01-20', NULL),  
(1002, 2, 1, '2022-07-25', NULL),  
(1003, 1, 1, '2021-10-15', NULL),  
(1004, 3, 1, '2022-12-10', NULL), 
(1005, 2, 1, '2023-07-05', NULL),  
(1006, 4, 1, '2023-03-20', NULL),  
(1007, 1, 4, '2020-09-01', '2022-06-11'),  
(1008, 2, 1, '2021-05-15', NULL),  
(1009, 3, 1, '2023-04-10', NULL),  
(1010, 1, 1, '2022-02-20', NULL),  
(1011, 4, 1, '2023-09-15', NULL),  
(1012, 5, 1, '2022-11-20', NULL),  
(1013, 2, 1, '2023-02-28', NULL),  
(1014, 3, 1, '2021-12-10', NULL),  
(1015, 2, 1, '2023-07-20', NULL);

INSERT INTO customer_account(customer_id, account_number) VALUES
(1, 1001),  
(2, 1002),  
(3, 1003),  
(4, 1004),  
(5, 1005),  
(6, 1006),  
(7, 1007),  
(8, 1008),  
(9, 1009), 
(10, 1010), 
(11, 1011), 
(12, 1012), 
(13, 1013),
(14, 1014), 
(15, 1015);

INSERT INTO transaction(transaction_id, transaction_datetime, from_account, to_account, description, amount) VALUES
(1, '2023-01-21 10:00:00', 1001, 1002, 'Transfer to Jane Smith', 100.00),
(2, '2023-02-15 14:30:00', 1003, 1004, 'Payment for services', 200.50),
(3, '2023-03-05 09:45:00', 1005, 1006, 'Deposit to Fixed Deposit', 1500.00),
(4, '2023-04-10 11:15:00', 1012, 1008, 'Transfer to Frank Wilson', 250.00),
(5, '2023-05-20 16:00:00', 1009, 1010, 'Monthly Salary Payment', 3000.00),
(6, '2023-06-12 08:30:00', 1011, 1012, 'Bill Payment', 120.75),
(7, '2023-07-25 10:15:00', 1013, 1014, 'Transfer to Laura Rodriguez', 400.00),
(8, '2023-08-30 13:00:00', 1015, 1001, 'Transfer from John Doe', 50.00);

select * from account;
select * from account_type;
select * from account_status;
select * from transaction;
select * from customer;
select * from customer_account;
