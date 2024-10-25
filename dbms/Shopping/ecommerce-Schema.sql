DROP DATABASE IF EXISTS Ecommerce;
CREATE DATABASE Ecommerce;
Use Ecommerce;
CREATE TABLE address (
    address_id INT PRIMARY KEY AUTO_INCREMENT,
    house_unit_no VARCHAR(10),
    address_line1 VARCHAR(255) NOT NULL,
    address_line2 VARCHAR(255),
    city VARCHAR(100) NOT NULL,
    region VARCHAR(100) NOT NULL,
    postal_code VARCHAR(20) NOT NULL,
    country VARCHAR(100) NOT NULL
);
CREATE TABLE user_account (
    username VARCHAR(50) PRIMARY KEY,
    first_name VARCHAR(100) NOT NULL,
    last_name VARCHAR(100) NOT NULL,
    email_address VARCHAR(100) NOT NULL UNIQUE
);
CREATE TABLE user_address (
    address_id INT,
    username VARCHAR(50),
    PRIMARY KEY (address_id, username),
    FOREIGN KEY (address_id) REFERENCES address(address_id) ON DELETE CASCADE,
    FOREIGN KEY (username) REFERENCES user_account(username) ON DELETE CASCADE
);
CREATE TABLE product_category (
    category_id INT PRIMARY KEY AUTO_INCREMENT,
    category_name VARCHAR(100) NOT NULL
);
CREATE TABLE brand (
    brand_id INT PRIMARY KEY AUTO_INCREMENT,
    brand_name VARCHAR(100) NOT NULL
);
CREATE TABLE colour (
    colour_id INT PRIMARY KEY AUTO_INCREMENT,
    colour_name VARCHAR(100) NOT NULL
);
CREATE TABLE size (
    size_id INT PRIMARY KEY AUTO_INCREMENT,
    size_name VARCHAR(50) NOT NULL
);
CREATE TABLE supplier (
    supplier_id INT PRIMARY KEY AUTO_INCREMENT,
    supplier_name VARCHAR(100) NOT NULL
);
CREATE TABLE product (
    product_id INT PRIMARY KEY AUTO_INCREMENT,
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
CREATE TABLE customer_order (
    order_id INT PRIMARY KEY AUTO_INCREMENT,
    order_discount DECIMAL(10, 2),
    shipping_address INT,
    billing_address INT,
    username VARCHAR(50),
    order_date DATETIME DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (shipping_address) REFERENCES address(address_id) ON DELETE SET NULL,
    FOREIGN KEY (billing_address) REFERENCES address(address_id) ON DELETE SET NULL,
    FOREIGN KEY (username) REFERENCES user_account(username) ON DELETE CASCADE
);
CREATE TABLE customer_order_line (
    order_line_id INT PRIMARY KEY AUTO_INCREMENT,
    product_id INT,
    qty INT NOT NULL,
    discount DECIMAL(10, 2),
    price DECIMAL(10, 2) NOT NULL,
    order_id INT,
    FOREIGN KEY (product_id) REFERENCES product(product_id) ON DELETE CASCADE,
    FOREIGN KEY (order_id) REFERENCES customer_order(order_id) ON DELETE CASCADE
);
CREATE TABLE supplier_order (
    order_id INT PRIMARY KEY AUTO_INCREMENT,
    order_discount DECIMAL(10, 2),
    supplier_id INT,
    order_date DATETIME DEFAULT CURRENT_TIMESTAMP,
    FOREIGN KEY (supplier_id) REFERENCES supplier(supplier_id) ON DELETE CASCADE
);

CREATE TABLE supplier_order_line (
    order_line_id INT PRIMARY KEY AUTO_INCREMENT,
    product_id INT,
    qty INT NOT NULL,
    discount DECIMAL(10, 2),
    price DECIMAL(10, 2) NOT NULL,
    order_id INT,
    FOREIGN KEY (product_id) REFERENCES product(product_id) ON DELETE CASCADE,
    FOREIGN KEY (order_id) REFERENCES supplier_order(order_id) ON DELETE CASCADE
);
SELECT 'Table created SuccessFully' AS INFO;
