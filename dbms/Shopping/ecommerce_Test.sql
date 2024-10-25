WITH expected_counts AS (
    SELECT 'address' AS TableName, 5 AS ExpectedCount
    UNION ALL
    SELECT 'user_address', 5
    UNION ALL
    SELECT 'user_account', 5
    UNION ALL
    SELECT 'customer_order', 5
    UNION ALL
    SELECT 'customer_order_line', 5
    UNION ALL
    SELECT 'product_category', 5
    UNION ALL
    SELECT 'brand', 5
    UNION ALL
    SELECT 'colour', 5
    UNION ALL
    SELECT 'size', 5
    UNION ALL
    SELECT 'supplier', 5
    UNION ALL
    SELECT 'product', 5
    UNION ALL
    SELECT 'supplier_order', 5
    UNION ALL
    SELECT 'supplier_order_line', 5
),
actual_counts AS (
    SELECT 'address' AS TableName, COUNT(*) AS ActualCount FROM address
    UNION ALL
    SELECT 'user_address', COUNT(*) FROM user_address
    UNION ALL
    SELECT 'user_account', COUNT(*) FROM user_account
    UNION ALL
    SELECT 'customer_order', COUNT(*) FROM customer_order
    UNION ALL
    SELECT 'customer_order_line', COUNT(*) FROM customer_order_line
    UNION ALL
    SELECT 'product_category', COUNT(*) FROM product_category
    UNION ALL
    SELECT 'brand', COUNT(*) FROM brand
    UNION ALL
    SELECT 'colour', COUNT(*) FROM colour
    UNION ALL
    SELECT 'size', COUNT(*) FROM size
    UNION ALL
    SELECT 'supplier', COUNT(*) FROM supplier
    UNION ALL
    SELECT 'product', COUNT(*) FROM product
    UNION ALL
    SELECT 'supplier_order', COUNT(*) FROM supplier_order
    UNION ALL
    SELECT 'supplier_order_line', COUNT(*) FROM supplier_order_line
)
SELECT 
    ec.TableName,
    ec.ExpectedCount,
    ac.ActualCount,
    CASE 
        WHEN ec.ExpectedCount = ac.ActualCount THEN 'Match'
        ELSE 'Mismatch'
    END AS Status
FROM expected_counts ec
JOIN actual_counts ac ON ec.TableName = ac.TableName;

SELECT 'Count Check Completed' AS INFO;
