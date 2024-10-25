DROP DATABASE IF EXISTS shopping_db;
CREATE DATABASE IF NOT EXISTS shopping_db;
USE shopping_db;

SELECT 'CREATING DATABASE STRUCTURE' as 'INFO';

DROP TABLE IF EXISTS address, user_address, user_account, customer_order, customer_order_line, product_category, brand, colour, size, supplier, product, supplier_order, supplier_order_line;

CREATE TABLE user_account (
    username VARCHAR(20) PRIMARY KEY,
    first_name VARCHAR(20) NOT NULL,
    last_name VARCHAR(20),
    email_address VARCHAR(50) NOT NULL
);

-- 1. Address Table
CREATE TABLE address(
    address_id INT PRIMARY KEY AUTO_INCREMENT,
    house_unit_no VARCHAR(20),
    address_line1 VARCHAR(75) NOT NULL,
    address_line2 VARCHAR(50),
    city VARCHAR(20) NOT NULL,
    region VARCHAR(20),
    postal_code VARCHAR(20),
    country VARCHAR(20) NOT NULL
);

-- 2. User Address Table
CREATE TABLE user_address(
    address_id INT,
    username VARCHAR(20),
    PRIMARY KEY(address_id, username),
    FOREIGN KEY(address_id) REFERENCES address(address_id) ON DELETE CASCADE,
    FOREIGN KEY(username) REFERENCES user_account(username) ON DELETE CASCADE
);


-- 4. Customer Order Table
CREATE TABLE customer_order (
    order_id INT PRIMARY KEY AUTO_INCREMENT,
    order_discount DECIMAL(5,2),
    shipping_address INT,
    billing_address INT,
    username VARCHAR(20) NOT NULL,
    order_date DATE,
    FOREIGN KEY(shipping_address) REFERENCES address(address_id),
    FOREIGN KEY(billing_address) REFERENCES address(address_id),
    FOREIGN KEY(username) REFERENCES user_account(username)
);


-- 6. Product Category Table
CREATE TABLE product_category (
    category_id INT PRIMARY KEY AUTO_INCREMENT,
    category_name VARCHAR(30) NOT NULL
);

-- 7. Brand Table
CREATE TABLE brand (
    brand_id INT PRIMARY KEY AUTO_INCREMENT,
    brand_name VARCHAR(30) UNIQUE NOT NULL
);

-- 8. Colour Table
CREATE TABLE colour (
    colour_id INT PRIMARY KEY AUTO_INCREMENT,
    colour_name VARCHAR(20) UNIQUE NOT NULL
);

-- 9. Size Table
CREATE TABLE size (
    size_id INT PRIMARY KEY AUTO_INCREMENT,
    size_name VARCHAR(20) UNIQUE NOT NULL
);

-- 10. Supplier Table
CREATE TABLE supplier (
    supplier_id INT PRIMARY KEY,
    supplier_name VARCHAR(30) UNIQUE NOT NULL
);

-- 11. Product Table
CREATE TABLE product (
    product_id INT PRIMARY KEY AUTO_INCREMENT,
    product_name VARCHAR(100) NOT NULL,
    product_category_id INT,
    brand_id INT,
    colour_id INT,
    size_id INT,
    supplier_id INT,
    FOREIGN KEY(product_category_id) REFERENCES product_category(category_id),
    FOREIGN KEY(brand_id) REFERENCES brand(brand_id),
    FOREIGN KEY(colour_id) REFERENCES colour(colour_id),
    FOREIGN KEY(size_id) REFERENCES size(size_id),
    FOREIGN KEY(supplier_id) REFERENCES supplier(supplier_id)
);

-- 5. Customer Order Line Table
CREATE TABLE customer_order_line (
    order_line_id INT PRIMARY KEY AUTO_INCREMENT,
    product_id INT NOT NULL,
    qty INT NOT NULL,
    discount DECIMAL(5,2),
    price DECIMAL(10,2) NOT NULL,
    order_id INT NOT NULL,
    FOREIGN KEY(product_id) REFERENCES product(product_id),
    FOREIGN KEY(order_id) REFERENCES customer_order(order_id) ON DELETE CASCADE
);

-- 12. Supplier Order Table
CREATE TABLE supplier_order (
    order_id INT PRIMARY KEY AUTO_INCREMENT,
    order_discount DECIMAL(5,2),
    supplier_id INT NOT NULL,
    order_date DATE,
    FOREIGN KEY(supplier_id) REFERENCES supplier(supplier_id)
);

-- 13. Supplier Order Line Table
CREATE TABLE supplier_order_line (
    order_line_id INT PRIMARY KEY AUTO_INCREMENT,
    product_id INT NOT NULL,
    qty INT NOT NULL,
    discount DECIMAL(5,2),
    price DECIMAL(10,2) NOT NULL,
    order_id INT NOT NULL,
    FOREIGN KEY (product_id) REFERENCES product(product_id),
    FOREIGN KEY (order_id) REFERENCES supplier_order(order_id) ON DELETE CASCADE
);

show tables;



