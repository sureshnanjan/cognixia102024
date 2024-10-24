-- Create the Banking Database
DROP DATABASE IF EXISTS banking;
CREATE DATABASE IF NOT EXISTS banking;
USE banking;

SELECT 'CREATING DATABASE STRUCTURE' AS 'INFO';

-- Drop tables if they exist
DROP TABLE IF EXISTS customers,
                     accounts,
                     transactions,
                     loans,
                     branches,
                     employees,
                     dept_manager;

-- Create customers table
CREATE TABLE customers (
    customer_id INT NOT NULL AUTO_INCREMENT,
    first_name VARCHAR(50) NOT NULL,
    last_name VARCHAR(50) NOT NULL,
    birth_date DATE NOT NULL,
    gender ENUM('M', 'F') NOT NULL,
    address VARCHAR(255) NOT NULL,
    phone_number VARCHAR(15) NOT NULL,
    email VARCHAR(100),
    PRIMARY KEY (customer_id)
);

-- Create employees table
CREATE TABLE employees (
    employee_id INT NOT NULL AUTO_INCREMENT,
    first_name VARCHAR(50) NOT NULL,
    last_name VARCHAR(50) NOT NULL,
    position VARCHAR(100) NOT NULL,
    salary DECIMAL(15, 2) NOT NULL,
    hire_date DATE NOT NULL,
    PRIMARY KEY (employee_id)
);

-- Create branches table
CREATE TABLE branches (
    branch_id INT NOT NULL AUTO_INCREMENT,
    branch_name VARCHAR(100) NOT NULL,
    location VARCHAR(255) NOT NULL,
    phone_number VARCHAR(15) NOT NULL,
    manager_id INT NOT NULL,
    PRIMARY KEY (branch_id),
    FOREIGN KEY (manager_id) REFERENCES employees(employee_id) ON DELETE CASCADE
);

-- Create dept_manager table
CREATE TABLE dept_manager (
    employee_id INT NOT NULL,
    branch_id INT NOT NULL,
    from_date DATE NOT NULL,
    to_date DATE NOT NULL,
    PRIMARY KEY (employee_id, branch_id),
    FOREIGN KEY (employee_id) REFERENCES employees(employee_id) ON DELETE CASCADE,
    FOREIGN KEY (branch_id) REFERENCES branches(branch_id) ON DELETE CASCADE
);

-- Create accounts table
CREATE TABLE accounts (
    account_id INT NOT NULL AUTO_INCREMENT,
    customer_id INT NOT NULL,
    account_type ENUM('Savings', 'Checking', 'Business') NOT NULL,
    balance DECIMAL(15, 2) NOT NULL DEFAULT 0.00,
    date_opened DATE NOT NULL,
    status ENUM('Active', 'Closed', 'Frozen') NOT NULL DEFAULT 'Active',
    PRIMARY KEY (account_id),
    FOREIGN KEY (customer_id) REFERENCES customers(customer_id) ON DELETE CASCADE
);

-- Create transactions table
CREATE TABLE transactions (
    transaction_id INT NOT NULL AUTO_INCREMENT,
    account_id INT NOT NULL,
    transaction_type ENUM('Deposit', 'Withdrawal', 'Transfer', 'Fee') NOT NULL,
    amount DECIMAL(15, 2) NOT NULL,
    transaction_date DATETIME NOT NULL,
    description VARCHAR(255),
    PRIMARY KEY (transaction_id),
    FOREIGN KEY (account_id) REFERENCES accounts(account_id) ON DELETE CASCADE
);

-- Create loans table
CREATE TABLE loans (
    loan_id INT NOT NULL AUTO_INCREMENT,
    customer_id INT NOT NULL,
    loan_type VARCHAR(50) NOT NULL,
    loan_amount DECIMAL(15, 2) NOT NULL,
    interest_rate DECIMAL(5, 2) NOT NULL,
    start_date DATE NOT NULL,
    end_date DATE NOT NULL,
    status ENUM('Active', 'Paid', 'Default') NOT NULL,
    PRIMARY KEY (loan_id),
    FOREIGN KEY (customer_id) REFERENCES customers(customer_id) ON DELETE CASCADE
);
show tables;
SELECT 'LOADING dept_manager' AS 'INFO';
source bank_dump.dump;