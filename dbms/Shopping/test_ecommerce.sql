-- Check Record Counts for each table
WITH expected_counts AS (
    SELECT 'user_account' AS TableName, 10 AS ExpectedCount
    UNION ALL
    SELECT 'address', 19
    UNION ALL
    SELECT 'product_category', 10
    UNION ALL
    SELECT 'brand', 10
    UNION ALL
    SELECT 'colour', 10
    UNION ALL
    SELECT 'size', 10
    UNION ALL
    SELECT 'supplier', 10
    UNION ALL
    SELECT 'product', 10
    UNION ALL
    SELECT 'customer_order', 10
    UNION ALL
    SELECT 'customer_order_line', 10
    UNION ALL
    SELECT 'supplier_order', 10
    UNION ALL
    SELECT 'supplier_order_line', 10
),
actual_counts AS (
    SELECT 'user_account' AS TableName, COUNT(*) AS ActualCount FROM user_account
    UNION ALL
    SELECT 'address', COUNT(*) FROM address
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
    SELECT 'customer_order', COUNT(*) FROM customer_order
    UNION ALL
    SELECT 'customer_order_line', COUNT(*) FROM customer_order_line
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
