SELECT 
    username, 
    first_name, 
    last_name, 
    email_address,
    CASE 
        WHEN username = 'user1' AND first_name = 'Alice' AND last_name = 'Smith' AND email_address = 'alice@example.com' THEN 'Matched'
        WHEN username = 'user2' AND first_name = 'Bob' AND last_name = 'Johnson' AND email_address = 'bob@example.com' THEN 'Matched'
        WHEN username = 'user3' AND first_name = 'Charlie' AND last_name = 'Brown' AND email_address = 'charlie@example.com' THEN 'Matched'
        WHEN username = 'user4' AND first_name = 'David' AND last_name = 'Williams' AND email_address = 'david@example.com' THEN 'Matched'
        ELSE 'Not Matched' 
    END AS status
FROM user_account
WHERE username IN ('user1', 'user2', 'user3', 'user4');