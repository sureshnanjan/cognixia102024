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
SELECT 
    `rental`.`rental_id`, 
    `rental`.`return_date` 
FROM 
    `sakila`.`rental`
JOIN 
    `sakila`.`inventory` ON `rental`.`inventory_id` = `inventory`.`inventory_id` 
JOIN 
    `sakila`.`film` ON `inventory`.`film_id` = `film`.`film_id` 
WHERE 
    `film`.`title`= 'Academy Dinosaur';