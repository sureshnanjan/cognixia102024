-- Licensed to the Software Freedom Conservancy (SFC) under one
-- or more contributor license agreements.  See the NOTICE file
-- distributed with this work for additional information
-- regarding copyright ownership.  The SFC licenses this file
-- to you under the Apache License, Version 2.0 (the
-- "License"); you may not use this file except in compliance
-- with the License.  You may obtain a copy of the License at

--   http://www.apache.org/licenses/LICENSE-2.0

-- Unless required by applicable law or agreed to in writing,
-- software distributed under the License is distributed on an
-- "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
-- KIND, either express or implied.  See the License for the
-- specific language governing permissions and limitations
-- under the License.

INSERT INTO `sakila`.`rental` (`rental_date`, `inventory_id`, `customer_id`, `return_date`, `staff_id`)
VALUES (
    NOW(),  -- Assuming you want to insert the current date and time
    (SELECT `inventory`.`inventory_id` 
     FROM `sakila`.`inventory` 
     JOIN `sakila`.`film` ON `film`.`film_id` = `inventory`.`film_id`
     JOIN `sakila`.`customer` ON `customer`.`store_id` = `inventory`.`store_id`
     WHERE `customer`.`customer_id` = 1  -- Adjust as needed for your customer_id
     LIMIT 1), 
    1,  
    NULL,
    1   
);
-- select statement to get output of the query
SELECT 
    rental_id, 
    rental_date, 
    inventory_id, 
    customer_id, 
    return_date, 
    staff_id
FROM 
    sakila.rental
WHERE 
    customer_id = 1
ORDER BY 
    rental_date DESC
LIMIT 1;