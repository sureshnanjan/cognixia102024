-- Insert data into customers table
INSERT INTO customers (first_name, last_name, birth_date, gender, address, phone_number, email) VALUES
('John', 'Doe', '1985-06-15', 'M', '123 Elm St, Springfield', '555-1234', 'johndoe@example.com'),
('Jane', 'Smith', '1990-09-25', 'F', '456 Oak St, Springfield', '555-5678', 'janesmith@example.com'),
('Michael', 'Johnson', '1978-12-05', 'M', '789 Pine St, Springfield', '555-9876', 'michael.johnson@example.com'),
('Emily', 'Davis', '1992-04-19', 'F', '101 Maple St, Springfield', '555-6543', 'emily.davis@example.com');

-- Insert data into accounts table
INSERT INTO accounts (customer_id, account_type, balance, date_opened, status) VALUES
(1, 'Checking', 1200.50, '2020-01-15', 'Active'),
(2, 'Savings', 2500.75, '2021-05-30', 'Active'),
(3, 'Business', 50000.00, '2018-02-22', 'Active'),
(4, 'Checking', 800.00, '2019-08-10', 'Frozen');

-- Insert data into transactions table
INSERT INTO transactions (account_id, transaction_type, amount, transaction_date, description) VALUES
(1, 'Deposit', 500.00, '2024-10-01 10:00:00', 'Salary Deposit'),
(2, 'Withdrawal', 200.00, '2024-10-02 11:30:00', 'ATM Withdrawal'),
(3, 'Deposit', 1500.00, '2024-10-03 14:00:00', 'Business Income'),
(4, 'Withdrawal', 300.00, '2024-10-04 15:15:00', 'Frozen Account Fee');

-- Insert data into loans table
INSERT INTO loans (customer_id, loan_type, loan_amount, interest_rate, start_date, end_date, status) VALUES
(1, 'Personal', 10000.00, 5.5, '2020-01-01', '2025-01-01', 'Active'),
(2, 'Mortgage', 200000.00, 3.8, '2021-06-15', '2041-06-15', 'Active'),
(3, 'Business', 50000.00, 7.5, '2018-02-22', '2023-02-22', 'Paid'),
(4, 'Personal', 5000.00, 6.0, '2020-09-10', '2025-09-10', 'Active');

-- Insert data into employees table
INSERT INTO employees (first_name, last_name, position, salary, hire_date) VALUES
('Alice', 'Brown', 'Manager', 60000.00, '2015-03-22'),
('Bob', 'Williams', 'Teller', 35000.00, '2018-07-15'),
('Charlie', 'Miller', 'Clerk', 40000.00, '2017-10-12'),
('David', 'Wilson', 'Assistant Manager', 50000.00, '2016-11-09');

-- Insert data into branches table
INSERT INTO branches (branch_name, location, phone_number, manager_id) VALUES
('Main Branch', '123 Main St, Springfield', '555-0001', 1),
('Westside Branch', '456 West St, Springfield', '555-0002', 2);

-- Insert data into dept_manager table
INSERT INTO dept_manager (employee_id, branch_id, from_date, to_date) VALUES
(1, 1, '2015-03-22', '2025-03-22'),
(2, 2, '2018-07-15', '2028-07-15');
