DROP DATABASE IF EXISTS banking_db;
CREATE DATABASE IF NOT EXISTS banking_db;
USE banking_db;

SELECT 'CREATING DATABASE STRUCTURE' as 'INFO';

DROP TABLE IF EXISTS transaction, customer_account, account, account_status, account_type, customer;

CREATE TABLE customer (
    customer_id INT NOT NULL,
    first_name VARCHAR(15) NOT NULL,
    last_name VARCHAR(20) NOT NULL,
    date_of_birth DATE NOT NULL,
    signup_date DATE NOT NULL,
    PRIMARY KEY (customer_id)
);

CREATE TABLE account_type (
    account_type_id INT NOT NULL,
    account_type VARCHAR(20) NOT NULL,
    PRIMARY KEY (account_type_id)
);

CREATE TABLE account_status(
  status_id INT NOT NULL, 
  status_value VARCHAR(20) NOT NULL, 
  PRIMARY KEY(status_id)
);

CREATE TABLE account(
  account_number INT NOT NULL, 
  account_type_id INT NOT NULL, 
  status_id INT NOT NULL, 
  date_opened DATE NOT NULL, 
  date_closed DATE, 
  PRIMARY KEY(account_number), 
  FOREIGN KEY (account_type_id) REFERENCES account_type(account_type_id), 
  FOREIGN KEY (status_id) REFERENCES account_status(status_id)
);

CREATE TABLE customer_account (
    customer_id INT NOT NULL,
    account_number INT NOT NULL,
    PRIMARY KEY (account_number, customer_id),
    FOREIGN KEY (customer_id) REFERENCES customer(customer_id) ON DELETE CASCADE,
    FOREIGN KEY (account_number) REFERENCES account(account_number) ON DELETE CASCADE
);

CREATE TABLE transaction(
  transaction_id INT NOT NULL, 
  transaction_datetime DATETIME NOT NULL, 
  from_account INT NOT NULL, 
  to_account INT NOT NULL, 
  description VARCHAR(100) , 
  amount DECIMAL(15, 2) NOT NULL,
  PRIMARY KEY(transaction_id), 
  FOREIGN KEY (from_account) REFERENCES account(account_number) ON DELETE CASCADE, 
  FOREIGN KEY (to_account) REFERENCES account(account_number) ON DELETE CASCADE 
);




