--  Sample bank database 
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

CREATE TABLE customer (
    customer_id INT NOT NULL,
    first_name VARCHAR(50) NOT NULL,
    last_name VARCHAR(50) NOT NULL,
    date_of_birth DATE NOT NULL,
    signup_date DATE NOT NULL,
PRIMARY KEY (customer_id)
);

CREATE TABLE account_type (
    account_type_id INT NOT NULL,
    account_type VARCHAR(50) NOT NULL,
PRIMARY KEY (account_type_id)
);
CREATE TABLE account_status (
    status_id INT NOT NULL,
    status_value VARCHAR(50) NOT NULL,
PRIMARY KEY (status_id)
);
CREATE TABLE account (
    account_number INT NOT NULL,
    account_type_id INT NOT NULL,
    status_id INT NOT NULL,
    date_opened DATE NOT NULL,
    date_closed DATE,
PRIMARY KEY (account_number),
FOREIGN KEY (account_type_id) REFERENCES account_type(account_type_id) ON DELETE CASCADE,
FOREIGN KEY (status_id) REFERENCES account_status(status_id) ON DELETE CASCADE
);
CREATE TABLE customer_account (
    customer_id INT NOT NULL,
    account_number INT NOT NULL,
    PRIMARY KEY (customer_id, account_number),
FOREIGN KEY (customer_id) REFERENCES customer(customer_id) ON DELETE CASCADE,
FOREIGN KEY (account_number) REFERENCES account(account_number) ON DELETE CASCADE
);
CREATE TABLE transaction (
    transaction_id INT NOT NULL,
    transaction_datetime DATETIME NOT NULL,
    from_account INT NOT NULL,
    to_account INT NOT NULL,
    description VARCHAR(255),
    amount DECIMAL(10, 2) NOT NULL,
    PRIMARY KEY (transaction_id),
FOREIGN KEY (from_account) REFERENCES account(account_number) ON DELETE CASCADE,
FOREIGN KEY (to_account) REFERENCES account(account_number) ON DELETE CASCADE
);



