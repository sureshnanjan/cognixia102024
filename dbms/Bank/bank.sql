DROP DATABASE IF EXISTS bank;
CREATE DATABASE IF NOT EXISTS bank;
USE bank;

SELECT 'CREATING DATABASE STRUCTURE' AS 'INFO';

DROP TABLE IF EXISTS customer,
                     customer_account, 
                     account,
                     account_type, 
                     transaction, 
                     account_status;

CREATE TABLE customer (
    customer_id     INT            NOT NULL,
    first_name      VARCHAR(15)    NOT NULL,
    last_name       VARCHAR(15)    NOT NULL,
    date_of_birth   DATE           NOT NULL,
    signup_date     DATE           NOT NULL,
    PRIMARY KEY(customer_id)
);

CREATE TABLE account_type (
    account_type_id  INT          NOT NULL AUTO_INCREMENT,
    account_type     VARCHAR(10)  NOT NULL,
    PRIMARY KEY(account_type_id)
);

CREATE TABLE account_status (
    status_id       INT          NOT NULL AUTO_INCREMENT,
    status_value    VARCHAR(50)   NOT NULL,  -- Changed to VARCHAR for descriptive statuses
    PRIMARY KEY(status_id)
);

CREATE TABLE account (
    account_number  BIGINT      NOT NULL,
    account_type_id INT         NOT NULL,
    status_id       INT         NOT NULL,
    date_opened     DATE        NOT NULL,
    date_closed     DATE        NULL,  -- Allow NULL for open accounts
    FOREIGN KEY (account_type_id) REFERENCES account_type(account_type_id) ON DELETE CASCADE,
    FOREIGN KEY (status_id) REFERENCES account_status(status_id) ON DELETE CASCADE,
    PRIMARY KEY(account_number)
);

CREATE TABLE customer_account (
    customer_id    INT        NOT NULL, 
    account_number BIGINT     NOT NULL,
    FOREIGN KEY (customer_id) REFERENCES customer(customer_id) ON DELETE CASCADE,
    FOREIGN KEY (account_number) REFERENCES account(account_number) ON DELETE CASCADE,
    PRIMARY KEY(customer_id,account_number)
);

CREATE TABLE transaction (
    transaction_id         INT     NOT NULL AUTO_INCREMENT,
    transaction_datetime   DATETIME NOT NULL,  -- Use DATETIME for more precision
    from_account           BIGINT  NOT NULL,
    to_account             BIGINT  NOT NULL,
    description            VARCHAR(255) NOT NULL,
    FOREIGN KEY (from_account) REFERENCES account(account_number) ON DELETE CASCADE,
    FOREIGN KEY (to_account) REFERENCES account(account_number) ON DELETE CASCADE,
    PRIMARY KEY(transaction_id)
);

SELECT 'DATABASE STRUCTURE CREATED' AS 'INFO';


