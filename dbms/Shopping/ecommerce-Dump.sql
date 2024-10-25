INSERT INTO address (house_unit_no, address_line1, address_line2, city, region, postal_code, country) VALUES
('1A', '123 Main St', 'Apt 1', 'New York', 'NY', '10001', 'USA'),
('2B', '456 Elm St', 'Suite 200', 'Los Angeles', 'CA', '90001', 'USA'),
('3C', '789 Oak St', '', 'Chicago', 'IL', '60601', 'USA'),
('4D', '321 Maple St', 'Unit 4', 'Houston', 'TX', '77001', 'USA'),
('5E', '654 Pine St', '', 'Phoenix', 'AZ', '85001', 'USA');
INSERT INTO user_account (username, first_name, last_name, email_address) VALUES
('john_doe', 'John', 'Doe', 'john.doe@example.com'),
('jane_smith', 'Jane', 'Smith', 'jane.smith@example.com'),
('alice_johnson', 'Alice', 'Johnson', 'alice.johnson@example.com'),
('bob_brown', 'Bob', 'Brown', 'bob.brown@example.com'),
('charlie_davis', 'Charlie', 'Davis', 'charlie.davis@example.com');
INSERT INTO product_category (category_name) VALUES
('Electronics'),
('Clothing'),
('Home Goods'),
('Books'),
('Toys');
INSERT INTO brand (brand_name) VALUES
('Brand A'),
('Brand B'),
('Brand C'),
('Brand D'),
('Brand E');
INSERT INTO colour (colour_name) VALUES
('Red'),
('Blue'),
('Green'),
('Yellow'),
('Black');
INSERT INTO size (size_name) VALUES
('Small'),
('Medium'),
('Large'),
('Extra Large'),
('One Size');
INSERT INTO supplier (supplier_name) VALUES
('Supplier A'),
('Supplier B'),
('Supplier C'),
('Supplier D'),
('Supplier E');
INSERT INTO product (product_name, product_category_id, brand_id, colour_id, size_id, supplier_id) VALUES
('Smartphone', 1, 1, 1, 3, 1),
('T-shirt', 2, 2, 2, 1, 2),
('Coffee Maker', 3, 3, 3, 4, 3),
('Novel', 4, 4, 4, 5, 4),
('Action Figure', 5, 5, 5, 2, 5);
INSERT INTO customer_order (order_discount, shipping_address, billing_address, username, order_date) VALUES
(10.00, 1, 1, 'john_doe', '2024-01-10 12:00:00'),
(15.50, 2, 2, 'jane_smith', '2024-01-11 13:00:00'),
(5.00, 3, 3, 'alice_johnson', '2024-01-12 14:00:00'),
(20.00, 4, 4, 'bob_brown', '2024-01-13 15:00:00'),
(7.50, 5, 5, 'charlie_davis', '2024-01-14 16:00:00');
INSERT INTO customer_order_line (product_id, qty, discount, price, order_id) VALUES
(1, 1, 5.00, 500.00, 1),
(2, 2, 1.50, 25.00, 2),
(3, 1, 10.00, 100.00, 3),
(4, 3, 2.00, 15.00, 4),
(5, 4, 0.50, 20.00, 5);
INSERT INTO supplier_order (order_discount, supplier_id, order_date) VALUES
(5.00, 1, '2024-01-15 10:00:00'),
(10.00, 2, '2024-01-16 11:00:00'),
(7.50, 3, '2024-01-17 12:00:00'),
(20.00, 4, '2024-01-18 13:00:00'),
(2.50, 5, '2024-01-19 14:00:00');

INSERT INTO supplier_order_line (product_id, qty, discount, price, order_id) VALUES
(1, 10, 5.00, 5000.00, 1),
(2, 5, 2.50, 125.00, 2),
(3, 20, 7.50, 1500.00, 3),
(4, 15, 3.00, 450.00, 4),
(5, 12, 1.00, 240.00, 5);
