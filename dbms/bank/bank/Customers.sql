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

-- Show info about loading customers
SELECT 'LOADING customer' as 'INFO';
-- You can now source your dump file or insert data manually here
source customer.dump;

SELECT 'LOADING account_type' as 'INFO';

source account_type.dump;

SELECT 'LOADING account_status' as 'INFO';

source account_status.dump;

SELECT 'LOADING account' as 'INFO';

source account.dump;

SELECT 'LOADING customer_account' as 'INFO';

source customer_account.dump;

SELECT 'LOADING transaction' as 'INFO';

source transaction.dump;




