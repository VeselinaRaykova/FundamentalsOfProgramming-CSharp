using System;
using System.Collections.Generic;
using System.Linq;

namespace _19AverageGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();

            for (int i = 0; i < count; i++)
            {
                string[] input = Console.ReadLine().Split(' ');
                string name = input[0];
                List<double> grades = input.Skip(1).Select(double.Parse).ToList();
                Student student = new Student(Name: name, Grades: grades);
                if (student.AverageGrade >= 5.00)
                {
                    students.Add(student);
                }
            }

            students = students
                .OrderBy(s => s.Name)
                .ThenByDescending(s => s.AverageGrade)
                .ToList();

            foreach (Student s in students)
            {
                Console.WriteLine($"{s.Name} -> {s.AverageGrade:f2}");
            }
        }
    }

    public class Student
    {
        private string name;
        public string Name { get; set; }
        public List<double> Grades { get; set; }
        public double AverageGrade { get; }

        public Student(string Name, List<double> Grades)
        {
            this.Name = Name;
            this.Grades = Grades;
            this.AverageGrade = Grades.Average();
        }
    }
}
