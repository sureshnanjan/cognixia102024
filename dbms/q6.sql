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

-- question Which actor has appeared in the most films?
use sakila;
SELECT CONCAT(a.first_name, ' ', a.last_name) AS Name,count(f.film_id) As No_of_films
FROM actor AS a
INNER JOIN film_actor AS f ON a.actor_id = f.actor_id
GROUP BY a.actor_id
HAVING COUNT(f.film_id) = (
    SELECT MAX(film_count) 
    FROM (
        SELECT COUNT(film_id) AS film_count
        FROM film_actor
        GROUP BY actor_id
    ) AS counts
);