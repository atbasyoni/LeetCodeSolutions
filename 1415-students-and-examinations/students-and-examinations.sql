/* Write your T-SQL query statement below */
select s.student_id, s.student_name, ss.subject_name, COUNT(e.student_id) as attended_exams 
from Students s cross join Subjects ss
left join Examinations e
on e.student_id = s.student_id  and e.subject_name = ss.subject_name
group by s.student_id, s.student_name, ss.subject_name
order by s.student_id, s.student_name, ss.subject_name