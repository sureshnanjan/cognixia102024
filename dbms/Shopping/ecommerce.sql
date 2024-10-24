DROP DATABASE IF EXISTS ecommerce;
CREATE DATABASE ecommerce;
USE ecommerce;

-- Create address table
CREATE TABLE address (
    address_id INT AUTO_INCREMENT PRIMARY KEY,
    house_unit_no VARCHAR(20),
    address_line1 TEXT NOT NULL,
    address_line2 TEXT,
    city VARCHAR(50) NOT NULL,
    region VARCHAR(50) NOT NULL,
    postal_code VARCHAR(20) NOT NULL,
    country VARCHAR(50) NOT NULL
);

-- Create user_account table
CREATE TABLE user_account (
    username VARCHAR(50) NOT NULL PRIMARY KEY,
    first_name VARCHAR(50) NOT NULL,
    last_name VARCHAR(50) NOT NULL,
    email_address VARCHAR(100) NOT NULL UNIQUE
);

-- Create user_address table
CREATE TABLE user_address (
    address_id INT,
    username VARCHAR(50),
    PRIMARY KEY (address_id, username),
    FOREIGN KEY (address_id) REFERENCES address(address_id) ON DELETE CASCADE,
    FOREIGN KEY (username) REFERENCES user_account(username) ON DELETE CASCADE
);

-- Create product_category table
CREATE TABLE product_category (
    category_id INT AUTO_INCREMENT PRIMARY KEY,
    category_name VARCHAR(100) NOT NULL
);

-- Create brand table
CREATE TABLE brand (
    brand_id INT AUTO_INCREMENT PRIMARY KEY,
    brand_name VARCHAR(100) NOT NULL
);

-- Create colour table
CREATE TABLE colour (
    colour_id INT AUTO_INCREMENT PRIMARY KEY,
    colour_name VARCHAR(50) NOT NULL
);

-- Create size table
CREATE TABLE size (
    size_id INT AUTO_INCREMENT PRIMARY KEY,
    size_name VARCHAR(50) NOT NULL
);

-- Create supplier table
CREATE TABLE supplier (
    supplier_id INT AUTO_INCREMENT PRIMARY KEY,
    supplier_name VARCHAR(100) NOT NULL
);

-- Create product table
CREATE TABLE product (
    product_id INT AUTO_INCREMENT PRIMARY KEY,
    product_name VARCHAR(100) NOT NULL,
    product_category_id INT,
    brand_id INT,
    colour_id INT,
    size_id INT,
    supplier_id INT,
    FOREIGN KEY (product_category_id) REFERENCES product_category(category_id) ON DELETE SET NULL,
    FOREIGN KEY (brand_id) REFERENCES brand(brand_id) ON DELETE SET NULL,
    FOREIGN KEY (colour_id) REFERENCES colour(colour_id) ON DELETE SET NULL,
    FOREIGN KEY (size_id) REFERENCES size(size_id) ON DELETE SET NULL,
    FOREIGN KEY (supplier_id) REFERENCES supplier(supplier_id) ON DELETE SET NULL
);

-- Create customer_order table
CREATE TABLE customer_order (
    order_id INT AUTO_INCREMENT PRIMARY KEY,
    order_discount DECIMAL(5,2) DEFAULT 0,
    shipping_address INT,
    billing_address INT,
    username VARCHAR(50),
    order_date DATETIME DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (shipping_address) REFERENCES address(address_id) ON DELETE SET NULL,
    FOREIGN KEY (billing_address) REFERENCES address(address_id) ON DELETE SET NULL,
    FOREIGN KEY (username) REFERENCES user_account(username) ON DELETE CASCADE
);

-- Create customer_order_line table
CREATE TABLE customer_order_line (
    order_line_id INT AUTO_INCREMENT PRIMARY KEY,
    product_id INT,
    qty INT NOT NULL,
    discount DECIMAL(5,2) DEFAULT 0,
    price DECIMAL(10,2) NOT NULL,
    order_id INT,
    FOREIGN KEY (product_id) REFERENCES product(product_id) ON DELETE CASCADE,
    FOREIGN KEY (order_id) REFERENCES customer_order(order_id) ON DELETE CASCADE
);

-- Create supplier_order table
CREATE TABLE supplier_order (
    order_id INT AUTO_INCREMENT PRIMARY KEY,
    order_discount DECIMAL(5,2) DEFAULT 0,
    supplier_id INT,
    order_date DATETIME DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (supplier_id) REFERENCES supplier(supplier_id) ON DELETE CASCADE
);

-- Create supplier_order_line table
CREATE TABLE supplier_order_line (
    order_line_id INT AUTO_INCREMENT PRIMARY KEY,
    product_id INT,
    qty INT NOT NULL,
    discount DECIMAL(5,2) DEFAULT 0,
    price DECIMAL(10,2) NOT NULL,
    order_id INT,
    FOREIGN KEY (product_id) REFERENCES product(product_id) ON DELETE CASCADE,
    FOREIGN KEY (order_id) REFERENCES supplier_order(order_id) ON DELETE CASCADE
);

SELECT 'Tables Created Successfully' AS INFO;
