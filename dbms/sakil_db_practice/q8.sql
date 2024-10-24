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
-- question Insert a record to represent Mary Smith renting ‘Academy Dinosaur’ from Mike Hillyer at Store 1 toda
use sakila;
-- to get the customer id of the Mary Smith  
select customer_id from customer where first_name='Mary' and last_name='Smith';
-- to get the staff id of the Mike Hillyer
select staff_id from staff where first_name='Mike' and last_name='Hillyer';
-- insertting value
-- insert into rental values (1,Now(),1,1,1,'2024-10-30 14:35:27',Now());
-- select Now();
-- INSERT INTO rental (rental_id, rental_date, inventory_id, customer_id, staff_id, return_date, last_update) 
-- VALUES (2, NOW(), 1, 1, 1, '2024-10-30 14:35:27', NOW());
INSERT INTO rental (rental_date, inventory_id, customer_id, staff_id, return_date, last_update) 
VALUES (NOW(), 1, 1, 1, '2024-10-30 14:35:27', NOW());



