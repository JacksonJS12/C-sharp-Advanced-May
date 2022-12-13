using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassroomProject
{
    public class Classroom
    {
        public Classroom(int capacity)
        {
            this.Students = new List<Student>();
            this.Capacity = capacity;
        }

        public List<Student> Students;
        public int Capacity { get; set; }
        public int Count 
            => Students.Count;

        public string RegisterStudent(Student student)
        {
            if (this.Students.Count == this.Capacity)
            {
                return "No seats in the classroom";
            }

            this.Students.Add(student);
            return $"Added student {student.FirstName} {student.LastName}";
        }

        public string DismissStudent(string firstName, string lastName)
        {
            Student student = this.Students
                .FirstOrDefault(s => s.FirstName == firstName && s.LastName == lastName);

            if (student == null) 
            {
                return "Student not found";
            }

            this.Students.Remove(student);

            return $"Dismissed student {firstName} {lastName}";
        }

        public string GetSubjectInfo(string subject)
        {
            List<Student> students = this.Students
                .Where(s => s.Subject == subject)
                .ToList();

            if (students.Count == 0)
            {
                return "No students enrolled for the subject";
            }

            StringBuilder sb = new StringBuilder();
            sb
                .AppendLine($"Subject: {subject}")
                .AppendLine("Students:");

            foreach (Student student in students)
            {
                sb 
                    .AppendLine($"{student.FirstName} {student.LastName}");
            }

            return sb
                .ToString()
                .TrimEnd();
        }

        public int GetStudentsCount()
        {
            return this.Students.Count;
        }

        public Student GetStudent(string firstName, string lastName)
        {
            return this.Students
                .FirstOrDefault(s => s.FirstName == firstName && s.LastName == lastName);
        }
    }
}
