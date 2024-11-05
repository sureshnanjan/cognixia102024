-- Drop and create the ecom database
DROP DATABASE IF EXISTS ecom;
CREATE DATABASE ecom;
USE ecom;

-- Show info about creating the database structure
SELECT 'CREATING DATABASE STRUCTURE' as 'INFO';

-- Create tables
CREATE TABLE product_category (
    category_id INT AUTO_INCREMENT PRIMARY KEY,
    category_name VARCHAR(255) NOT NULL
);

CREATE TABLE brand (
    brand_id INT AUTO_INCREMENT PRIMARY KEY,
    brand_name VARCHAR(255) NOT NULL
);

CREATE TABLE colour (
    colour_id INT AUTO_INCREMENT PRIMARY KEY,
    colour_name VARCHAR(255) NOT NULL
);

CREATE TABLE size (
    size_id INT AUTO_INCREMENT PRIMARY KEY,
    size_name VARCHAR(255) NOT NULL
);

CREATE TABLE supplier (
    supplier_id INT AUTO_INCREMENT PRIMARY KEY,
    supplier_name VARCHAR(255) NOT NULL
);

CREATE TABLE product (
    product_id INT AUTO_INCREMENT PRIMARY KEY,
    product_category_id INT,
    brand_id INT,
    colour_id INT,
    size_id INT,
    supplier_id INT,
    product_name VARCHAR(255) NOT NULL,
    FOREIGN KEY (product_category_id) REFERENCES product_category(category_id),
    FOREIGN KEY (brand_id) REFERENCES brand(brand_id),
    FOREIGN KEY (colour_id) REFERENCES colour(colour_id),
    FOREIGN KEY (size_id) REFERENCES size(size_id),
    FOREIGN KEY (supplier_id) REFERENCES supplier(supplier_id)
);

-- Corrected users_account table name
CREATE TABLE users_account (
    username VARCHAR(255) PRIMARY KEY,
    first_name VARCHAR(50),
    last_name VARCHAR(50),
    email_address VARCHAR(100)
);

CREATE TABLE addresses (
    address_id INT AUTO_INCREMENT PRIMARY KEY,
    address VARCHAR(255)
);

CREATE TABLE user_address (
    address_id INT,
    username VARCHAR(255),
    PRIMARY KEY (address_id, username),  -- Composite Primary Key
    FOREIGN KEY (address_id) REFERENCES addresses(address_id),  -- Foreign Key referencing addresses
    FOREIGN KEY (username) REFERENCES users_account(username)  -- Foreign Key referencing users_account
);

CREATE TABLE customer_order (
    order_id INT AUTO_INCREMENT PRIMARY KEY,
    username VARCHAR(255),
    shipping_address_id INT,
    billing_address_id INT,
    order_date DATETIME NOT NULL,
    order_discount DECIMAL(10, 2) DEFAULT 0,
    FOREIGN KEY (username) REFERENCES users_account(username),
    FOREIGN KEY (shipping_address_id) REFERENCES addresses(address_id),
    FOREIGN KEY (billing_address_id) REFERENCES addresses(address_id)
);

CREATE TABLE supplier_order (
    order_id INT AUTO_INCREMENT PRIMARY KEY,
    supplier_id INT,
    order_discount DECIMAL(10, 2) DEFAULT 0,
    FOREIGN KEY (supplier_id) REFERENCES supplier(supplier_id)
);

CREATE TABLE supplier_order_line (
    order_line_id INT AUTO_INCREMENT PRIMARY KEY,
    product_id INT,
    order_id INT,
    qty INT NOT NULL,
    discount DECIMAL(10, 2) DEFAULT 0,
    price DECIMAL(10, 2) NOT NULL,
    FOREIGN KEY (product_id) REFERENCES product(product_id),
    FOREIGN KEY (order_id) REFERENCES supplier_order(order_id)
);

CREATE TABLE customer_order_line (
    order_line_id INT AUTO_INCREMENT PRIMARY KEY,
    product_id INT,
    order_id INT,
    qty INT NOT NULL,
    discount DECIMAL(10, 2) DEFAULT 0,
    price DECIMAL(10, 2) NOT NULL,
    FOREIGN KEY (product_id) REFERENCES product(product_id),
    FOREIGN KEY (order_id) REFERENCES customer_order(order_id)
);


-- Show info about loading customers

SELECT 'LOADING product_category' as 'INFO';

-- You can now source your dump file or insert data manually here

source product_category.dump;

SELECT 'LOADING brand' as 'INFO';

source brand.dump;

SELECT 'LOADING colour' as 'INFO';

source colour.dump;

SELECT 'LOADING size' as 'INFO';

source size.dump;

SELECT 'LOADING supplier' as 'INFO';

source supplier.dump;

SELECT 'LOADING product' as 'INFO';

source product.dump;

SELECT 'LOADING users_account' as 'INFO';

source users_account.dump;

SELECT 'LOADING addresses' as 'INFO';

source addresses.dump;
					
SELECT 'LOADING user_address' as 'INFO';

source user_address.dump;

SELECT 'LOADING customer_order' as 'INFO';

source customer_order.dump;

SELECT 'LOADING supplier_order' as 'INFO';

source supplier_order.dump;

SELECT 'LOADING supplier_order_line' as 'INFO';

source supplier_order_line.dump;

SELECT 'LOADING customer_order_line' as 'INFO';

source customer_order_line.dump;
