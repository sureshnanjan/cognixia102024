-- Check Record Counts for each table
WITH expected_counts AS (
    SELECT 'country' AS TableName, 10 AS ExpectedCount
    UNION ALL
    SELECT 'city', 10
    UNION ALL
    SELECT 'airport', 10
    UNION ALL
    SELECT 'manufacturer', 5
    UNION ALL
    SELECT 'aircraft_model', 5
    UNION ALL
    SELECT 'airline', 5
    UNION ALL
    SELECT 'aircraft', 5
    UNION ALL
    SELECT 'seat_class', 3
    UNION ALL
    SELECT 'aircraft_seat', 10
    UNION ALL
    SELECT 'flight', 6
    UNION ALL
    SELECT 'leg', 5
    UNION ALL
    SELECT 'customer', 10
    UNION ALL
    SELECT 'booking', 10
    UNION ALL
    SELECT 'booking_leg', 10
),
actual_counts AS (
    SELECT 'country' AS TableName, COUNT(*) AS ActualCount FROM country
    UNION ALL
    SELECT 'city', COUNT(*) FROM city
    UNION ALL
    SELECT 'airport', COUNT(*) FROM airport
    UNION ALL
    SELECT 'manufacturer', COUNT(*) FROM manufacturer
    UNION ALL
    SELECT 'aircraft_model', COUNT(*) FROM aircraft_model
    UNION ALL
    SELECT 'airline', COUNT(*) FROM airline
    UNION ALL
    SELECT 'aircraft', COUNT(*) FROM aircraft
    UNION ALL
    SELECT 'seat_class', COUNT(*) FROM seat_class
    UNION ALL
    SELECT 'aircraft_seat', COUNT(*) FROM aircraft_seat
    UNION ALL
    SELECT 'flight', COUNT(*) FROM flight
    UNION ALL
    SELECT 'leg', COUNT(*) FROM leg
    UNION ALL
    SELECT 'customer', COUNT(*) FROM customer
    UNION ALL
    SELECT 'booking', COUNT(*) FROM booking
    UNION ALL
    SELECT 'booking_leg', COUNT(*) FROM booking_leg
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
