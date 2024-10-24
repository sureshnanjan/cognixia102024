DROP DATABASE IF EXISTS bank;
CREATE DATABASE IF NOT EXISTS bank;
USE bank;


SELECT 'CREATING DATABASE STRUCTURE' as 'INFO';

DROP TABLE IF EXISTS customer,
                     account_type,
                     account_status,
                     account, 
                     customer_account, 
                     transaction;
                     
                     
/*!50503 set default_storage_engine = InnoDB */;
/*!50503 select CONCAT('storage engine: ', @@default_storage_engine) as INFO */;

-- Create Customer Table
CREATE TABLE customer (
    customer_id INT PRIMARY KEY AUTO_INCREMENT,
    first_name VARCHAR(50) NOT NULL,
    last_name VARCHAR(50) NOT NULL,
    date_of_birth DATE NOT NULL,
    signup_date DATE NOT NULL
);

-- Create Account Type Table
CREATE TABLE account_type (
    account_type_id INT PRIMARY KEY AUTO_INCREMENT,
    account_type VARCHAR(50) NOT NULL
);

-- Create Account Status Table
CREATE TABLE account_status (
    status_id INT PRIMARY KEY AUTO_INCREMENT,
    status_value VARCHAR(50) NOT NULL
);


-- Create Account Table
CREATE TABLE account (
    account_number INT PRIMARY KEY,
    account_type_id INT NOT NULL,
    status_id INT NOT NULL,
    date_opened DATE NOT NULL,
    date_closed DATE,
    FOREIGN KEY (account_type_id) REFERENCES account_type(account_type_id),
    FOREIGN KEY (status_id) REFERENCES account_status(status_id)
);


-- Create Customer_Account (Join) Table
CREATE TABLE customer_account (
    customer_id INT NOT NULL,
    account_number INT NOT NULL,
    PRIMARY KEY (customer_id, account_number),
    FOREIGN KEY (customer_id) REFERENCES customer(customer_id),
    FOREIGN KEY (account_number) REFERENCES account(account_number)
);


-- Create Transaction Table
CREATE TABLE transaction (
    transaction_id INT PRIMARY KEY AUTO_INCREMENT,
    transaction_datetime DATETIME NOT NULL,
    from_account INT NOT NULL,
    to_account INT NOT NULL,
    description VARCHAR(255),
    amount DECIMAL(10, 2) NOT NULL,
    FOREIGN KEY (from_account) REFERENCES account(account_number),
    FOREIGN KEY (to_account) REFERENCES account(account_number)
);


