/* Write your T-SQL query statement below */
select a.machine_id, ROUND(AVG(b.timestamp - a.timestamp),3) as processing_time
from Activity a join Activity b
on b.machine_id = a.machine_id and a.process_id = b.process_id and a.timestamp < b.timestamp
group by a.machine_id;