DROP DATABASE IF EXISTS BANK_DB;
CREATE DATABASE IF NOT EXISTS BANK_DB;
USE BANK_DB;

SELECT 'CREATING DATABASE STRUCTURE' as 'INFO';

DROP TABLE IF EXISTS customer,account_type,account_status,account,customer_account,transaction;

/*!50503 set default_storage_engine = InnoDB */;
/*!50503 select CONCAT('storage engine: ', @@default_storage_engine) as INFO */;


CREATE TABLE customer (
    customer_id INT AUTO_INCREMENT PRIMARY KEY,
    first_name VARCHAR(50) NOT NULL,
    last_name VARCHAR(50) NOT NULL,
    date_of_birth DATE NOT NULL,
    signup_date DATETIME DEFAULT CURRENT_TIMESTAMP
);

CREATE TABLE account_type (
    account_type_id INT AUTO_INCREMENT PRIMARY KEY,
    account_type VARCHAR(50) NOT NULL
);

CREATE TABLE account_status (
    status_id INT AUTO_INCREMENT PRIMARY KEY,
    status_valus VARCHAR(50) NOT NULL
);

CREATE TABLE account (
    account_number INT AUTO_INCREMENT PRIMARY KEY,
    account_type_id INT,
    status_id INT,
    date_opened DATETIME NOT NULL,
    date_closed DATETIME,
    FOREIGN KEY (account_type_id) REFERENCES account_type(account_type_id),
    FOREIGN KEY (status_id) REFERENCES account_status(status_id)
);

CREATE TABLE customer_account (
    customer_id INT,
    account_number INT,
    PRIMARY KEY (customer_id, account_number),
    FOREIGN KEY (customer_id) REFERENCES customer(customer_id),
    FOREIGN KEY (account_number) REFERENCES account(account_number)
);
CREATE TABLE transaction (
    transaction_id INT AUTO_INCREMENT PRIMARY KEY,
    transaction_datetime DATETIME NOT NULL,
    from_account INT,
    to_account INT,
    description VARCHAR(255),
    amount DECIMAL(10, 2) NOT NULL,
    FOREIGN KEY (from_account) REFERENCES account(account_number),
    FOREIGN KEY (to_account) REFERENCES account(account_number)
);
-- ount_status: status_id, status_value