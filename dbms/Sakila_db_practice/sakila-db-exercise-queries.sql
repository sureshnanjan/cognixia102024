select *from actor where first_name="Scarlett";

select *from actor where last_name="Johansson";

select count(distinct last_name) as Number_of_distinct_last_name from actor;

select last_name from actor group by last_name having count(last_name)=1;

select last_name from actor group by last_name having count(last_name)>1;

select *from actor join film;

SELECT actor.actor_id, actor.first_name, actor.last_name, film_actor.film_count
FROM actor
JOIN (
    SELECT actor_id, count(actor_id) AS film_count
    FROM film_actor
    GROUP BY actor_id
) film_actor ON actor.actor_id = film_actor.actor_id
ORDER BY film_actor.film_count DESC
LIMIT 1;

SELECT film.film_id, film.title, store.store_id, inventory.inventory_id
FROM film
INNER JOIN inventory ON film.film_id = inventory.film_id
INNER JOIN store ON inventory.store_id = store.store_id
WHERE (film.title = 'Academy Dinosaur' AND store.store_id = 1);

SELECT rental_date,rental_date + interval(SELECT rental_duration FROM film WHERE film_id = 1) DAY AS due_date
FROM rental
WHERE rental_id = (SELECT rental_id FROM rental ORDER BY rental_id DESC LIMIT 1);

SELECT avg(length) as average_running_time_of_films FROM film;

SELECT category.name, avg(length) AS average_running_time
FROM film 
JOIN film_category USING (film_id) 
JOIN category USING (category_id)
GROUP BY category.name
HAVING avg(length) > (SELECT avg(length) FROM film)
ORDER BY avg(length) DESC;
 
  

