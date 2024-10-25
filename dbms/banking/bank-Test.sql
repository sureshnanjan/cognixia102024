WITH expected_counts AS (
    SELECT 'customer' AS TableName, 10 AS ExpectedCount
    UNION ALL
    SELECT 'account_type', 10
    UNION ALL
    SELECT 'account_status', 10
    UNION ALL
    SELECT 'account', 10
    UNION ALL
    SELECT 'customer_account', 10
    UNION ALL
    SELECT 'transaction', 10
),
actual_counts AS (
    SELECT 'customer' AS TableName, COUNT(*) AS ActualCount FROM customer
    UNION ALL
    SELECT 'account_type', COUNT(*) FROM account_type
    UNION ALL
    SELECT 'account_status', COUNT(*) FROM account_status
    UNION ALL
    SELECT 'account', COUNT(*) FROM account
    UNION ALL
    SELECT 'customer_account', COUNT(*) FROM customer_account
    UNION ALL
    SELECT 'transaction', COUNT(*) FROM transaction
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
