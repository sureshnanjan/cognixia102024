-- Drop existing bank database and create a new one
DROP DATABASE IF EXISTS bank;
CREATE DATABASE bank;
USE bank;

-- Create tables
CREATE TABLE account_type (
    account_type_id INT PRIMARY KEY,
    account_type VARCHAR(100)
);

CREATE TABLE account_status (
    status_id INT PRIMARY KEY,
    status_value VARCHAR(100)
);

CREATE TABLE customer (
    customer_id INT PRIMARY KEY,
    first_name VARCHAR(100),
    last_name VARCHAR(100),
    date_of_birth DATE,
    signup_date DATE
);

CREATE TABLE account (
    account_number INT PRIMARY KEY,
    account_type_id INT,
    status_id INT,
    date_opened DATE,
    date_closed DATE,
    FOREIGN KEY (account_type_id) REFERENCES account_type(account_type_id),
    FOREIGN KEY (status_id) REFERENCES account_status(status_id)
);

CREATE TABLE customer_account (
    account_number INT,
    customer_id INT,
    PRIMARY KEY (account_number, customer_id),
    FOREIGN KEY (account_number) REFERENCES account(account_number),
    FOREIGN KEY (customer_id) REFERENCES customer(customer_id)
);

CREATE TABLE transaction (
    transaction_id INT PRIMARY KEY,
    transaction_datetime DATETIME,
    from_account INT,
    to_account INT,
    description VARCHAR(255),
    FOREIGN KEY (from_account) REFERENCES account(account_number),
    FOREIGN KEY (to_account) REFERENCES account(account_number)
);

-- Insert sample data into tables
INSERT INTO account_type (account_type_id, account_type) VALUES 
(1, 'Savings'), 
(2, 'Checking'), 
(3, 'Business');

INSERT INTO account_status (status_id, status_value) VALUES 
(1, 'Active'), 
(2, 'Inactive');

INSERT INTO customer (customer_id, first_name, last_name, date_of_birth, signup_date) VALUES 
(1, 'John', 'Doe', '1985-05-15', '2020-01-01'),
(2, 'Jane', 'Smith', '1990-07-20', '2020-02-15'),
(3, 'Alice', 'Johnson', '1975-09-30', '2020-03-10'),
(4, 'Bob', 'Brown', '1988-12-12', '2020-04-05'),
(5, 'Charlie', 'Davis', '1995-03-25', '2020-05-20'),
(6, 'Eve', 'Wilson', '1982-11-11', '2020-06-15'),
(7, 'Frank', 'Miller', '1992-08-08', '2020-07-22'),
(8, 'Grace', 'Lee', '1980-01-01', '2020-08-30'),
(9, 'Hank', 'Garcia', '1986-04-04', '2020-09-18'),
(10, 'Ivy', 'Martinez', '1993-06-06', '2020-10-25');

INSERT INTO account (account_number, account_type_id, status_id, date_opened) VALUES 
(1001, 1, 1, '2021-01-15'), 
(1002, 2, 1, '2021-02-20'), 
(1003, 1, 2, '2021-03-25');

INSERT INTO customer_account (account_number, customer_id) VALUES 
(1001, 1), 
(1002, 2), 
(1003, 3);

INSERT INTO transaction (transaction_id, transaction_datetime, from_account, to_account, description) VALUES 
(2001,'2023-01-01 10:00:00' ,1001 ,1002 ,'Deposit to savings account.'),
(2002,'2023-01-02 11:00:00' ,1002 ,1003 ,'Transfer from checking account.');

-- Create expected_values table for record counts
DROP TABLE IF EXISTS expected_values;
CREATE TABLE expected_values (
    table_name varchar(30) not null primary key,
    recs int not null
);

-- Create found_values table for actual counts
DROP TABLE IF EXISTS found_values;
CREATE TABLE found_values LIKE expected_values;

-- Insert expected record counts
INSERT INTO expected_values VALUES 
('account_type',   3),
('account_status',   2),
('customer',   10),
('account',   3),
('customer_account',   3),
('transaction',   2);

-- Insert actual record counts into found_values
INSERT INTO found_values VALUES 
('account_type', (SELECT COUNT(*) FROM account_type)),
('account_status', (SELECT COUNT(*) FROM account_status)),
('customer', (SELECT COUNT(*) FROM customer)),
('account', (SELECT COUNT(*) FROM account)),
('customer_account', (SELECT COUNT(*) FROM customer_account)),
('transaction', (SELECT COUNT(*) FROM transaction));

-- Compare expected and found records
SELECT  
    e.table_name,
    e.recs AS expected_records,
    f.recs AS found_records,
    IF(e.recs = f.recs,'OK','not ok') AS records_match
FROM 
    expected_values e 
INNER JOIN found_values f ON e.table_name = f.table_name;

-- Cleanup
DROP TABLE expected_values;
DROP TABLE found_values;