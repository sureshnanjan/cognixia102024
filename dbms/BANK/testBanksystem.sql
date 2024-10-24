-- Validate Customer Table
SELECT 
    'Customer Count' AS validation,
    (SELECT COUNT(*) FROM customer) AS actual_count,
    (SELECT COUNT(*) FROM (VALUES (10)) AS expected_count(expected)) AS expected_count;

-- Validate Account Type Table
SELECT 
    'Account Type Count' AS validation,
    (SELECT COUNT(*) FROM account_type) AS actual_count,
    (SELECT COUNT(*) FROM (VALUES (10)) AS expected_count(expected)) AS expected_count;

-- Validate Account Status Table
SELECT 
    'Account Status Count' AS validation,
    (SELECT COUNT(*) FROM account_status) AS actual_count,
    (SELECT COUNT(*) FROM (VALUES (10)) AS expected_count(expected)) AS expected_count;

-- Validate Account Table
SELECT 
    'Account Count' AS validation,
    (SELECT COUNT(*) FROM account) AS actual_count,
    (SELECT COUNT(*) FROM (VALUES (10)) AS expected_count(expected)) AS expected_count;

-- Validate Customer Account Table
SELECT 
    'Customer Account Count' AS validation,
    (SELECT COUNT(*) FROM customer_account) AS actual_count,
    (SELECT COUNT(*) FROM (VALUES (10)) AS expected_count(expected)) AS expected_count;

-- Validate Transaction Table
SELECT 
    'Transaction Count' AS validation,
    (SELECT COUNT(*) FROM transaction) AS actual_count,
    (SELECT COUNT(*) FROM (VALUES (10)) AS expected_count(expected)) AS expected_count;
