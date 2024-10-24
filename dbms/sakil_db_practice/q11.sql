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
-- question What is the average running time of films by category 
use sakila;
SELECT 
    c.name, 
    AVG(f.length) AS average_length
FROM 
    film AS f
INNER JOIN 
    film_category AS fc ON f.film_id = fc.film_id
INNER JOIN 
    category AS c ON fc.category_id = c.category_id
GROUP BY 
    c.name
ORDER BY 
    average_length DESC;