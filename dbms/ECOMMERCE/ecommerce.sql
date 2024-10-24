-- Sample e-commerce database 
-- See changelog table for details
-- Copyright (C) 2023, Your Company
-- 
-- Original schema created by Your Name
-- This work is licensed under the 
-- Creative Commons Attribution-Share Alike 3.0 Unported License. 
-- To view a copy of this license, visit 
-- http://creativecommons.org/licenses/by-sa/3.0/ or send a letter to 
-- Creative Commons, 171 Second Street, Suite 300, San Francisco, 
-- California, 94105, USA.
-- 
-- DISCLAIMER
-- To the best of our knowledge, this data is fabricated, and
-- it does not correspond to real people. 
-- Any similarity to existing people is purely coincidental.

DROP DATABASE IF EXISTS e_commerce;
CREATE DATABASE IF NOT EXISTS e_commerce;
USE e_commerce;

SELECT 'CREATING DATABASE STRUCTURE' AS 'INFO';

DROP TABLE IF EXISTS address,
                     user_address,
                     user_account,
                     customer_order,
                     customer_order_line,
                     product_category,
                     brand,
                     colour,
                     size,
                     supplier,
                     product,
                     supplier_order,
                     supplier_order_line;

/*!50503 set default_storage_engine = InnoDB */;
/*!50503 select CONCAT('storage engine: ', @@default_storage_engine) AS INFO */;

CREATE TABLE address (
    address_id INT AUTO_INCREMENT PRIMARY KEY,
    house_unit_no VARCHAR(20),
    address_line1 VARCHAR(255) NOT NULL,
    address_line2 VARCHAR(255),
    city VARCHAR(100) NOT NULL,
    region VARCHAR(100),
    postal_code VARCHAR(20),
    country VARCHAR(100) NOT NULL
);

CREATE TABLE user_address (
    address_id INT,
    username VARCHAR(50),
    PRIMARY KEY (address_id, username),
    FOREIGN KEY (address_id) REFERENCES address(address_id),
    FOREIGN KEY (username) REFERENCES user_account(username)
);

CREATE TABLE user_account (
    username VARCHAR(50) PRIMARY KEY,
    first_name VARCHAR(50) NOT NULL,
    last_name VARCHAR(50) NOT NULL,
    email_address VARCHAR(100) UNIQUE NOT NULL
);

CREATE TABLE customer_order (
    order_id INT AUTO_INCREMENT PRIMARY KEY,
    order_discount DECIMAL(10, 2),
    shipping_address INT,
    billing_address INT,
    username VARCHAR(50),
    order_date DATETIME NOT NULL,
    FOREIGN KEY (shipping_address) REFERENCES address(address_id),
    FOREIGN KEY (billing_address) REFERENCES address(address_id),
    FOREIGN KEY (username) REFERENCES user_account(username)
);

CREATE TABLE customer_order_line (
    order_line_id INT AUTO_INCREMENT PRIMARY KEY,
    product_id INT,
    qty INT NOT NULL,
    discount DECIMAL(10, 2),
    price DECIMAL(10, 2) NOT NULL,
    order_id INT,
    FOREIGN KEY (order_id) REFERENCES customer_order(order_id)
);

CREATE TABLE product_category (
    category_id INT AUTO_INCREMENT PRIMARY KEY,
    category_name VARCHAR(100) NOT NULL
);

CREATE TABLE brand (
    brand_id INT AUTO_INCREMENT PRIMARY KEY,
    brand_name VARCHAR(100) NOT NULL
);

CREATE TABLE colour (
    colour_id INT AUTO_INCREMENT PRIMARY KEY,
    colour_name VARCHAR(50) NOT NULL
);

CREATE TABLE size (
    size_id INT AUTO_INCREMENT PRIMARY KEY,
    size_name VARCHAR(50) NOT NULL
);

CREATE TABLE supplier (
    supplier_id INT AUTO_INCREMENT PRIMARY KEY,
    supplier_name VARCHAR(100) NOT NULL
);

CREATE TABLE product (
    product_id INT AUTO_INCREMENT PRIMARY KEY,
    product_name VARCHAR(100) NOT NULL,
    product_category_id INT,
    brand_id INT,
    colour_id INT,
    size_id INT,
    supplier_id INT,
    FOREIGN KEY (product_category_id) REFERENCES product_category(category_id),
    FOREIGN KEY (brand_id) REFERENCES brand(brand_id),
    FOREIGN KEY (colour_id) REFERENCES colour(colour_id),
    FOREIGN KEY (size_id) REFERENCES size(size_id),
    FOREIGN KEY (supplier_id) REFERENCES supplier(supplier_id)
);

CREATE TABLE supplier_order (
    order_id INT AUTO_INCREMENT PRIMARY KEY,
    order_discount DECIMAL(10, 2),
    supplier_id INT,
    order_date DATETIME NOT NULL,
    FOREIGN KEY (supplier_id) REFERENCES supplier(supplier_id)
);

CREATE TABLE supplier_order_line (
    order_line_id INT AUTO_INCREMENT PRIMARY KEY,
    product_id INT,
    qty INT NOT NULL,
    discount DECIMAL(10, 2),
    price DECIMAL(10, 2) NOT NULL,
    order_id INT,
    FOREIGN KEY (order_id) REFERENCES supplier_order(order_id),
    FOREIGN KEY (product_id) REFERENCES product(product_id)
);

FLUSH /*!50503 binary */ logs;

SELECT 'LOADING address' AS 'INFO';
-- source load_address.dump;
SELECT 'LOADING user_address' AS 'INFO';
-- source load_user_address.dump;
SELECT 'LOADING user_account' AS 'INFO';
-- source load_user_account.dump;
SELECT 'LOADING customer_order' AS 'INFO';
-- source load_customer_order.dump;
SELECT 'LOADING customer_order_line' AS 'INFO';
-- source load_customer_order_line.dump;
SELECT 'LOADING product_category' AS 'INFO';
-- source load_product_category.dump;
SELECT 'LOADING brand' AS 'INFO';
-- source load_brand.dump;
SELECT 'LOADING colour' AS 'INFO';
-- source load_colour.dump;
SELECT 'LOADING size' AS 'INFO';
-- source load_size.dump;
SELECT 'LOADING supplier' AS 'INFO';
-- source load_supplier.dump;
SELECT 'LOADING product' AS 'INFO';
-- source load_product.dump;
SELECT 'LOADING supplier_order' AS 'INFO';
-- source load_supplier_order.dump;
SELECT 'LOADING supplier_order_line' AS 'INFO';
-- source load_supplier_order_line.dump;
