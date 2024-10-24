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

-- question Is ‘Academy Dinosaur’ available for rent from Store 1
use sakila;
SELECT 
    f.film_id, 
    f.title, 
    s.store_id, 
    i.inventory_id
FROM 
    inventory AS i
INNER JOIN 
    store AS s ON i.store_id = s.store_id
INNER JOIN 
    film AS f ON i.film_id = f.film_id
WHERE 
    f.title = 'Academy Dinosaur' AND s.store_id = 1;