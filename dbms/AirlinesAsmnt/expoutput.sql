SELECT 
    airport_code, 
    city_id, 
    airport_name,
    CASE 
        WHEN airport_code = 'JFK' AND city_id = 1 AND airport_name = 'John F. Kennedy International Airport' THEN 'Matched'
        WHEN airport_code = 'LAX' AND city_id = 2 AND airport_name = 'Los Angelss International Airport' THEN 'Matched'
        WHEN airport_code = 'YYZ' AND city_id = 3 AND airport_name = 'Toronto Pearson International Airport' THEN 'Matched'
        WHEN airport_code = 'LHR' AND city_id = 4 AND airport_name = 'Heathow Airport' THEN 'Matched'
        WHEN airport_code = 'SYD' AND city_id = 5 AND airport_name = 'Sydney Kingsford Smith Airport' THEN 'Matched'
        WHEN airport_code = 'TXL' AND city_id = 6 AND airport_name = 'Berlin Tegel Airport' THEN 'Matched'
        ELSE 'Not Matched' 
    END AS status
FROM airport
WHERE airport_code IN ('JFK', 'LAX', 'YYZ', 'LHR', 'SYD', 'TXL');