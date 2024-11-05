-- Drop and create the bank database
DROP DATABASE IF EXISTS bank;
CREATE DATABASE bank;
USE bank;

-- Show info about creating the database structure
SELECT 'CREATING DATABASE STRUCTURE' as 'INFO';

-- Drop existing tables if they exist
DROP TABLE IF EXISTS customer_account, transaction, account, customer, account_type, account_status;

-- Create the account_status table
CREATE TABLE account_status (
    status_id INT PRIMARY KEY,
    status_value VARCHAR(50)
);

-- Create the account_type table
CREATE TABLE account_type (
    account_type_id INT PRIMARY KEY,
    account_type VARCHAR(50)
);

-- Create the customer table
CREATE TABLE customer (
    customer_id INT PRIMARY KEY,
    first_name VARCHAR(50),
    last_name VARCHAR(50),
    date_of_birth DATE,
    signup_date DATE
);

-- Create the account table with foreign keys for account_type and account_status
CREATE TABLE account (
    account_number INT PRIMARY KEY,
    account_type_id INT,
    status_id INT,
    date_opened DATE,
    date_closed DATE,
    FOREIGN KEY (account_type_id) REFERENCES account_type(account_type_id),
    FOREIGN KEY (status_id) REFERENCES account_status(status_id)
);

-- Create the customer_account junction table for many-to-many relationship
CREATE TABLE customer_account (
    customer_id INT,
    account_number INT,
    PRIMARY KEY (customer_id, account_number),
    FOREIGN KEY (customer_id) REFERENCES customer(customer_id),
    FOREIGN KEY (account_number) REFERENCES account(account_number)
);

-- Create the transaction table with foreign keys
CREATE TABLE transaction (
    transaction_id INT PRIMARY KEY,
    transaction_datetime DATETIME,
    from_account INT,
    to_account INT,
    description VARCHAR(255),
    amount DECIMAL(10, 2),
    FOREIGN KEY (from_account) REFERENCES account(account_number),
    FOREIGN KEY (to_account) REFERENCES account(account_number)
);

-- Insert data into the account_type table
INSERT INTO account_type (account_type_id, account_type)
VALUES (1, 'Savings'),
       (2, 'Credit Card'),
       (3, 'Transaction'),
       (4, 'Loan'),
       (5, 'Fixed Deposit'),
       (6, 'Business Account'),
       (7, 'Overdraft'),
       (8, 'Recurring Deposit'),
       (9, 'Mortgage'),
       (10, 'Personal Loan');

-- Insert data into the account_status table
INSERT INTO account_status (status_id, status_value)
VALUES (1, 'Active'),
       (2, 'Inactive'),
       (3, 'Pending'),
       (4, 'Suspended'),
       (5, 'Closed');

-- Insert data into the customer table
INSERT INTO customer (customer_id, first_name, last_name, date_of_birth, signup_date)
VALUES (1, 'John', 'Doe', '1985-06-15', '2020-01-01'),
       (2, 'Jane', 'Smith', '1990-07-20', '2020-03-05'),
       (3, 'David', 'Brown', '1978-10-10', '2021-06-10'),
       (4, 'Laura', 'Wilson', '1982-11-15', '2021-02-21'),
       (5, 'Emily', 'Johnson', '1995-08-25', '2020-07-14'),
       (6, 'Michael', 'Davis', '1991-12-01', '2022-09-13'),
       (7, 'Sarah', 'Miller', '1988-04-22', '2019-11-01'),
       (8, 'James', 'Taylor', '1983-01-08', '2021-08-12'),
       (9, 'Anna', 'Martinez', '1979-05-18', '2021-03-19'),
       (10, 'Robert', 'Garcia', '1986-09-23', '2021-10-25');

-- Insert data into the account table first (before referencing it in customer_account and transaction)
INSERT INTO account (account_number, account_type_id, status_id, date_opened, date_closed)
VALUES (1001, 1, 1, '2020-01-01', NULL),
       (1002, 2, 1, '2020-03-05', NULL),
       (1003, 3, 1, '2021-06-10', NULL),
       (1004, 4, 5, '2019-05-01', '2020-04-01'),
       (1005, 1, 1, '2021-01-15', NULL),
       (1006, 3, 1, '2022-09-13', NULL),
       (1007, 2, 2, '2020-10-10', '2021-08-09'),
       (1008, 1, 1, '2019-11-01', NULL),
       (1009, 4, 5, '2021-04-10', '2022-03-15'),
       (1010, 2, 1, '2021-10-25', NULL);

-- Insert data into the customer_account table
INSERT INTO customer_account (customer_id, account_number)
VALUES (1, 1001), (2, 1002), (3, 1003), (4, 1004), (5, 1005),
       (6, 1006), (7, 1007), (8, 1008), (9, 1009), (10, 1010);

-- Insert data into the transaction table
INSERT INTO transaction (transaction_id, transaction_datetime, from_account, to_account, description, amount)
VALUES (1, '2022-01-05 10:30:00', 1001, 1003, 'Payment to Brown', 150.50),
       (2, '2022-03-10 12:15:00', 1004, 1002, 'Loan repayment', 1000.00),
       (3, '2022-04-25 14:00:00', 1005, 1006, 'Transfer to Davis', 200.00),
       (4, '2022-05-14 09:20:00', 1007, 1009, 'Payment to Martinez', 50.00),
       (5, '2022-06-01 11:05:00', 1003, 1008, 'Transfer to Taylor', 300.00),
       (6, '2022-07-18 16:45:00', 1009, 1001, 'Payment from Garcia', 500.00),
       (7, '2022-08-07 13:10:00', 1002, 1004, 'Loan payment to Smith', 250.00),
       (8, '2022-09-12 18:00:00', 1008, 1005, 'Transfer from Wilson', 75.00),
       (9, '2022-10-10 15:25:00', 1006, 1007, 'Payment from Miller', 100.00),
       (10, '2022-11-05 17:50:00', 1010, 1003, 'Payment to Brown', 400.00);
