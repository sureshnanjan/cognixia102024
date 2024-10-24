
drop database if exists shopping;
create database if not exists shopping;
use shopping;

CREATE TABLE supplier (
    supplier_id INT PRIMARY KEY,
    supplier_name VARCHAR(255)
);
CREATE TABLE supplier_order (
    order_id INT PRIMARY KEY,
    supplier_id INT,
    order_discount DECIMAL(10, 2),
    FOREIGN KEY (supplier_id) REFERENCES supplier(supplier_id)
);
CREATE TABLE product_category (
    category_id INT PRIMARY KEY,
    category_name VARCHAR(255)
    );
    CREATE TABLE brand (
    brand_id INT PRIMARY KEY,
    brand_name VARCHAR(255)
);
CREATE TABLE colour (
    colour_id INT PRIMARY KEY,
    colour_name VARCHAR(100)
);
CREATE TABLE size (
    size_id INT PRIMARY KEY,
    size_name VARCHAR(50)
);
CREATE TABLE product (
    product_id INT PRIMARY KEY,
    product_category_id INT,
    brand_id INT,
    colour_id INT,
    size_id INT,
    supplier_id INT,
    product_name VARCHAR(255),
    FOREIGN KEY (product_category_id) REFERENCES product_category(category_id),
    FOREIGN KEY (brand_id) REFERENCES brand(brand_id),
    FOREIGN KEY (colour_id) REFERENCES colour(colour_id),
    FOREIGN KEY (size_id) REFERENCES size(size_id),
    FOREIGN KEY (supplier_id) REFERENCES supplier(supplier_id)
);



CREATE TABLE supplier_order_line (
    order_line_id INT PRIMARY KEY,
    product_id INT,
    order_id INT,
    qty INT,
    discount DECIMAL(5, 2),
    price DECIMAL(10, 2),
    FOREIGN KEY (product_id) REFERENCES product(product_id),
    FOREIGN KEY (order_id) REFERENCES supplier_order(order_id)
);
CREATE TABLE address (
    address_id INT PRIMARY KEY,
    address_line VARCHAR(255),
    city VARCHAR(100),
    postal_code VARCHAR(20),
    country VARCHAR(100)
);
CREATE TABLE user_account (
    username VARCHAR(255) PRIMARY KEY,
    first_name VARCHAR(100),
    last_name VARCHAR(100),
    email_address VARCHAR(255)
);
CREATE TABLE customer_order (
    order_id INT PRIMARY KEY,
    username VARCHAR(255),
    shipping_address INT,
    billing_address INT,
    order_date DATE,
    order_discount DECIMAL(10, 2),
    FOREIGN KEY (username) REFERENCES user_account(username),
    FOREIGN KEY (shipping_address) REFERENCES address(address_id),
    FOREIGN KEY (billing_address) REFERENCES address(address_id)
);
CREATE TABLE customer_order_line (
    order_line_id INT PRIMARY KEY,
    product_id INT,
    order_id INT,
    qty INT,
    discount DECIMAL(5, 2),
    price DECIMAL(10, 2),
    FOREIGN KEY (product_id) REFERENCES product(product_id),
    FOREIGN KEY (order_id) REFERENCES customer_order(order_id)
);


CREATE TABLE user_address (
    address_id INT,
    username VARCHAR(255),
    PRIMARY KEY (address_id, username),
    FOREIGN KEY (address_id) REFERENCES address(address_id),
    FOREIGN KEY (username) REFERENCES user_account(username)
);
