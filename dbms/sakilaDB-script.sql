SELECT * FROM actor WHERE first_name = 'Scarlett';
SELECT * FROM actor WHERE last_name = 'Johansson';
SELECT COUNT(DISTINCT last_name) FROM actor;
SELECT last_name FROM actor GROUP BY last_name HAVING COUNT(*) = 1;
SELECT last_name, COUNT(*) FROM actor GROUP BY last_name HAVING COUNT(*) > 1;
SELECT actor_id, COUNT(film_id) AS film_count
FROM film_actor
GROUP BY actor_id
ORDER BY film_count DESC
LIMIT 1;
SELECT inventory_id
FROM inventory
WHERE film_id = (SELECT film_id FROM film WHERE title = 'Academy Dinosaur')
AND store_id = 1
AND inventory_id NOT IN (SELECT inventory_id FROM rental WHERE return_date IS NULL);
INSERT INTO rental (rental_date, inventory_id, customer_id, staff_id)
VALUES (NOW(), 
       (SELECT inventory_id FROM inventory WHERE film_id = (SELECT film_id FROM film WHERE title = 'Academy Dinosaur') AND store_id = 1 LIMIT 1),
       (SELECT customer_id FROM customer WHERE first_name = 'Mary' AND last_name = 'Smith'),
       (SELECT staff_id FROM staff WHERE first_name = 'Mike' AND last_name = 'Hillyer'));
SELECT rental.rental_date + INTERVAL film.rental_duration DAY AS due_date
FROM rental
JOIN inventory ON rental.inventory_id = inventory.inventory_id
JOIN film ON inventory.film_id = film.film_id
WHERE film.title = 'Academy Dinosaur'
ORDER BY rental.rental_date DESC
LIMIT 1;
SELECT AVG(length) AS average_running_time FROM film;
SELECT c.name AS category, AVG(f.length) AS average_running_time
FROM film f
JOIN film_category fc ON f.film_id = fc.film_id
JOIN category c ON fc.category_id = c.category_id
GROUP BY c.name;
