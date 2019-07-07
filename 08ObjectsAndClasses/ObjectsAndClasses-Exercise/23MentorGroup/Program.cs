using System;
using System.Collections.Generic;
using System.Linq;

namespace _23MentorGroup
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, Student> group = ReadUsers();
            group = AddComments(group);
            PrintStudents(group.Values.ToList());
        }

        private static SortedDictionary<string, Student> ReadUsers()
        {
            SortedDictionary<string, Student> group = new SortedDictionary<string, Student>();
            string command = Console.ReadLine();
            string[] input;

            while (command != "end of dates")
            {
                input = command.Split(' ').ToArray();
                string name = input[0];

                if (!group.ContainsKey(name))
                {
                    Student st = new Student(name);
                    group.Add(name, st);
                }

                if (input.Length > 1)
                {
                    List<DateTime> dates = input[1].Split(',').Select(d => DateTime.ParseExact(d, "dd/mm/yyyy", null)).ToList();
                    group[name].Dates.AddRange(dates);
                }

                command = Console.ReadLine();
            }
            return group;
        }

        private static SortedDictionary<string, Student> AddComments(SortedDictionary<string, Student> group)
        {
            string command = Console.ReadLine();
            string[] input;

            while (command != "end of comments")
            {
                input = command.Split('-').ToArray();
                string name = input[0];
                string comment = input[1];
                if (group.ContainsKey(name))
                {
                    group[name].Comments.Add(comment);
                }

                command = Console.ReadLine();
            }

            return group;
        }

        private static void PrintStudents(List<Student> group)
        {
            foreach (Student student in group)
            {
                Console.WriteLine(student.Name);
                Console.WriteLine("Comments:");
                foreach (string comment in student.Comments)
                {
                    Console.WriteLine($"- {comment}");
                }

                Console.WriteLine("Dates attended:");
                student.Dates.Sort();

                foreach (DateTime date in student.Dates)
                {
                    Console.WriteLine($"-- {date.ToString("dd/mm/yyyy")}");
                }
            }
        }
    }

    public class Student
    {
        public string Name { get; set; }
        public List<DateTime> Dates { get; set; }
        public List<string> Comments { get; set; }

        public Student(string name)
        {
            Name = name;
            this.Comments = new List<string>();
            this.Dates = new List<DateTime>();
        }

    }
}

