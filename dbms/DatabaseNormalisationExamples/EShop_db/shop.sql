-- Drop and create tables
DROP DATABASE IF EXISTS shop;
CREATE DATABASE IF NOT EXISTS shop;
USE shop;
SELECT 'CREATING DATABASE STRUCTURE' as 'INFO';

-- Drop tables if they exist
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

-- Create the tables
CREATE TABLE product_category (
    category_id INT PRIMARY KEY AUTO_INCREMENT,
    category_name VARCHAR(100)
);

CREATE TABLE brand (
    brand_id INT PRIMARY KEY AUTO_INCREMENT,
    brand_name VARCHAR(100)
);

CREATE TABLE colour (
    colour_id INT PRIMARY KEY AUTO_INCREMENT,
    colour_name VARCHAR(50)
);

CREATE TABLE size (
    size_id INT PRIMARY KEY AUTO_INCREMENT,
    size_name VARCHAR(20)
);

CREATE TABLE supplier (
    supplier_id INT PRIMARY KEY AUTO_INCREMENT,
    supplier_name VARCHAR(100)
);

CREATE TABLE product (
    product_id INT PRIMARY KEY AUTO_INCREMENT,
    product_name VARCHAR(100),
    product_category_id INT,
    brand_id INT,
    colour_id INT,
    size_id INT,
    supplier_id INT,
    price DECIMAL(10, 2),
    FOREIGN KEY (product_category_id) REFERENCES product_category(category_id),
    FOREIGN KEY (brand_id) REFERENCES brand(brand_id),
    FOREIGN KEY (colour_id) REFERENCES colour(colour_id),
    FOREIGN KEY (size_id) REFERENCES size(size_id),
    FOREIGN KEY (supplier_id) REFERENCES supplier(supplier_id)
);

CREATE TABLE user_account (
    username VARCHAR(50) PRIMARY KEY,
    first_name VARCHAR(100),
    last_name VARCHAR(100),
    email_address VARCHAR(100)
);

CREATE TABLE address (
    address_id INT PRIMARY KEY AUTO_INCREMENT,
    house_unit_no VARCHAR(50),
    address_line1 VARCHAR(255),
    address_line2 VARCHAR(255),
    city VARCHAR(100),
    region VARCHAR(100),
    postal_code VARCHAR(20),
    country VARCHAR(100)
);

CREATE TABLE user_address (
    address_id INT,
    username VARCHAR(50),
    PRIMARY KEY (address_id, username),
    FOREIGN KEY (address_id) REFERENCES address(address_id),
    FOREIGN KEY (username) REFERENCES user_account(username)
);

CREATE TABLE customer_order (
    order_id INT PRIMARY KEY AUTO_INCREMENT,
    order_discount DECIMAL(5, 2),
    shipping_address INT,
    billing_address INT,
    username VARCHAR(50),
    order_date DATE,
    FOREIGN KEY (shipping_address) REFERENCES address(address_id),
    FOREIGN KEY (billing_address) REFERENCES address(address_id),
    FOREIGN KEY (username) REFERENCES user_account(username)
);

CREATE TABLE customer_order_line (
    order_line_id INT PRIMARY KEY AUTO_INCREMENT,
    product_id INT,
    qty INT,
    discount DECIMAL(5, 2),
    price DECIMAL(10, 2),
    order_id INT,
    FOREIGN KEY (product_id) REFERENCES product(product_id),
    FOREIGN KEY (order_id) REFERENCES customer_order(order_id)
);

CREATE TABLE supplier_order (
    order_id INT PRIMARY KEY AUTO_INCREMENT,
    order_discount DECIMAL(5, 2),
    supplier_id INT,
    order_date DATE,
    FOREIGN KEY (supplier_id) REFERENCES supplier(supplier_id)
);

CREATE TABLE supplier_order_line (
    order_line_id INT PRIMARY KEY AUTO_INCREMENT,
    product_id INT,
    qty INT,
    discount DECIMAL(5, 2),
    price DECIMAL(10, 2),
    order_id INT,
    FOREIGN KEY (product_id) REFERENCES product(product_id),
    FOREIGN KEY (order_id) REFERENCES supplier_order(order_id)
);

