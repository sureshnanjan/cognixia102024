-- Drop existing ecommerce database and create a new one
DROP DATABASE IF EXISTS ecommerce;
CREATE DATABASE ecommerce;
USE ecommerce;

-- Create tables
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

CREATE TABLE supplier (
    supplier_id INT PRIMARY KEY,
    supplier_name VARCHAR(255)
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

CREATE TABLE supplier_order (
    order_id INT PRIMARY KEY,
    supplier_id INT,
    order_discount DECIMAL(10, 2),
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

CREATE TABLE user_account (
    username VARCHAR(255) PRIMARY KEY,
    first_name VARCHAR(100),
    last_name VARCHAR(100),
    email_address VARCHAR(255)
);

CREATE TABLE address (
    address_id INT PRIMARY KEY,
    address_line VARCHAR(255),
    city VARCHAR(100),
    postal_code VARCHAR(20),
    country VARCHAR(100)
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

-- Insert sample data into tables
INSERT INTO product_category (category_id, category_name) VALUES 
(1, 'Electronics'), 
(2, 'Clothing'), 
(3, 'Home & Kitchen');

INSERT INTO brand (brand_id, brand_name) VALUES 
(1, 'Brand A'), 
(2, 'Brand B'), 
(3, 'Brand C');

INSERT INTO colour (colour_id, colour_name) VALUES 
(1, 'Red'), 
(2, 'Blue'), 
(3, 'Green');

INSERT INTO size (size_id, size_name) VALUES 
(1, 'Small'), 
(2, 'Medium'), 
(3, 'Large');

INSERT INTO supplier (supplier_id, supplier_name) VALUES 
(1, 'Supplier A'), 
(2, 'Supplier B'), 
(3, 'Supplier C');

INSERT INTO product (product_id, product_category_id, brand_id, colour_id, size_id, supplier_id, product_name) VALUES 
(1 ,1 ,1 ,1 ,1 ,1 ,'Smartphone'),  
(2 ,1 ,2 ,2 ,2 ,2 ,'Laptop'),  
(3 ,2 ,3 ,3 ,3 ,3 ,'T-Shirt');

INSERT INTO supplier_order (order_id,supplier_id,order_discount) VALUES 
(1 ,1 ,10.00),  
(2 ,2 ,15.50),  
(3 ,3 ,20.00);

INSERT INTO supplier_order_line (order_line_id, product_id, order_id, qty, discount, price) VALUES 
(1 ,1 ,1 ,100 ,0.00 ,599.99),  
(2 ,2 ,1 ,50 ,0.00 ,999.99),  
(3 ,3 ,2 ,200 ,0.00 ,19.99);

INSERT INTO user_account (username, first_name, last_name, email_address) VALUES 
('johndoe', 'John', 'Doe', 'john.doe@example.com'),  
('janesmith', 'Jane', 'Smith', 'jane.smith@example.com'),  
('alicejohnson', 'Alice', 'Johnson', 'alice.johnson@example.com');

INSERT INTO address (address_id,address_line,city,postal_code,country) VALUES 
(1,'123 Main St','Los Angeles','90001','USA'),  
(2,'456 Elm St','New York','10001','USA'),  
(3,'789 Maple Ave','Chicago','60601','USA');

INSERT INTO customer_order (order_id, username, shipping_address,billing_address,order_date,order_discount) VALUES 
(1 ,'johndoe' ,'123 Main St' ,'123 Main St' ,'2023-01-01' ,'0.00'),  
(2 ,'janesmith' ,'456 Elm St' ,'456 Elm St' ,'2023-02-15' ,'5.00');

INSERT INTO customer_order_line (order_line_id, product_id, order_id, qty, discount, price) VALUES 
(1 ,1 ,1 ,10 ,0.50 ,19.99),  
(2 ,2 ,1 ,5 ,0.75 ,999.99);

INSERT INTO user_address (address_id, username) VALUES 
(1,'johndoe'),  
(2,'janesmith');

-- Create expected_values table for record counts
DROP TABLE IF EXISTS expected_values;
CREATE TABLE expected_values (
   table_name varchar(30) not null primary key,
   recs int not null
);

-- Create found_values table for actual counts
DROP TABLE IF EXISTS found_values;
CREATE TABLE found_values LIKE expected_values;

-- Insert expected record counts
INSERT INTO expected_values VALUES 
('product_category',   3),  
('brand',   3),  
('colour',   3),  
('size',   3),  
('supplier',   3),  
('product',   3),  
('supplier_order',   3),  
('supplier_order_line',   3),  
('user_account',   3),  
('address',   3),  
('customer_order',   0),  
('customer_order_line',   0),  
('user_address',   2);  

-- Insert actual record counts into found_values
INSERT INTO found_values VALUES 
('product_category', (SELECT COUNT(*) FROM product_category)),
('brand', (SELECT COUNT(*) FROM brand)),
('colour', (SELECT COUNT(*) FROM colour)),
('size', (SELECT COUNT(*) FROM size)),
('supplier', (SELECT COUNT(*) FROM supplier)),
('product', (SELECT COUNT(*) FROM product)),
('supplier_order', (SELECT COUNT(*) FROM supplier_order)),
('supplier_order_line', (SELECT COUNT(*) FROM supplier_order_line)),
('user_account', (SELECT COUNT(*) FROM user_account)),
('address', (SELECT COUNT(*) FROM address)),
('customer_order', (SELECT COUNT(*) FROM customer_order)),
('customer_order_line', (SELECT COUNT(*) FROM customer_order_line)),
('user_address', (SELECT COUNT(*) FROM user_address));

-- Compare expected and found records
SELECT  
   e.table_name,
   e.recs AS expected_records,
   f.recs AS found_records,
   IF(e.recs = f.recs,'OK','not ok') AS records_match
FROM 
   expected_values e 
INNER JOIN found_values f ON e.table_name = f.table_name;

-- Cleanup
DROP TABLE expected_values;
DROP TABLE found_values;