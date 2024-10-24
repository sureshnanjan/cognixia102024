-- Insert data into customers table
INSERT INTO customers (first_name, last_name, email, phone_number, address) VALUES
('John', 'Doe', 'johndoe@example.com', '555-1234', '123 Elm St, Springfield'),
('Jane', 'Smith', 'janesmith@example.com', '555-5678', '456 Oak St, Springfield'),
('Michael', 'Johnson', 'michael.johnson@example.com', '555-9876', '789 Pine St, Springfield'),
('Emily', 'Davis', 'emily.davis@example.com', '555-6543', '101 Maple St, Springfield');

-- Insert data into categories table
INSERT INTO categories (category_name, description) VALUES
('Electronics', 'Gadgets, devices, and electronics items'),
('Fashion', 'Clothing, footwear, and accessories'),
('Home & Kitchen', 'Furniture, appliances, and kitchenware'),
('Sports', 'Sports equipment, apparel, and accessories'),
('Books', 'Books, novels, and educational material');

-- Insert data into products table
INSERT INTO products (product_name, category_id, price, stock_quantity, description) VALUES
('Laptop', 1, 1200.00, 50, '14-inch display laptop with 16GB RAM and 512GB SSD'),
('Sneakers', 2, 75.00, 100, 'Comfortable running shoes for all-day use'),
('Blender', 3, 60.00, 30, '500W blender with multiple speed settings'),
('Basketball', 4, 25.00, 200, 'Standard-size basketball for indoor and outdoor use'),
('The Great Gatsby', 5, 15.00, 150, 'Classic novel by F. Scott Fitzgerald');

-- Insert data into employees table
INSERT INTO employees (first_name, last_name, position, salary, hire_date) VALUES
('Alice', 'Brown', 'Manager', 60000.00, '2015-03-22'),
('Bob', 'Williams', 'Sales Associate', 35000.00, '2018-07-15'),
('Charlie', 'Miller', 'Cashier', 40000.00, '2017-10-12'),
('David', 'Wilson', 'Warehouse Manager', 50000.00, '2016-11-09');

-- Insert data into orders table
INSERT INTO orders (customer_id, total_amount, status) VALUES
(1, 1250.00, 'Shipped'),
(2, 300.00, 'Pending'),
(3, 160.00, 'Delivered'),
(4, 200.00, 'Cancelled');

-- Insert data into order_details table
INSERT INTO order_details (order_id, product_id, quantity, price) VALUES
(1, 1, 1, 1200.00),
(1, 5, 1, 15.00),
(2, 2, 2, 75.00),
(3, 3, 2, 60.00),
(3, 4, 1, 25.00),
(4, 4, 2, 25.00);

-- Insert data into branches table
-- INSERT INTO branches (branch_name, location, phone_number, manager_id) VALUES
-- ('Main Store', '123 Main St, Springfield', '555-1111', 1),
-- ('Westside Store', '456 West St, Springfield', '555-2222', 2);

-- Insert data into dept_manager table
-- INSERT INTO dept_manager (employee_id, branch_id, from_date, to_date) VALUES
-- (1, 1, '2015-03-22', '2025-03-22'),
-- (2, 2, '2018-07-15', '2028-07-15');
