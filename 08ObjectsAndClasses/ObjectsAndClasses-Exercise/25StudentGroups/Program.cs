using System;
using System.Collections.Generic;
using System.Linq;

namespace _25StudentGroups
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, Town> towns = new Dictionary<string, Town>();
            Town town = new Town();

            while (true)
            {
                if (input == "End")
                {
                    break;
                }

                if (input.IndexOf("=>") != -1)
                {
                    town = ReadTown(input);
                    towns.Add(town.Name, town);
                }

                input = Console.ReadLine();
                Group group = new Group();
                List<Student> students = new List<Student>();

                while (input.IndexOf("|") != -1)
                {
                    Student student = ReadStudent(input);
                    group.Students.Add(student);
                    students.Add(student);

                    input = Console.ReadLine();
                }

                FillGroups(students, towns, town);
            }

            PrintGroups(towns.Values.ToList());
        }


        private static void FillGroups(List<Student> students, Dictionary<string, Town> towns, Town town)
        {
            students = students
                .OrderBy(s => s.RegistrartionDate)
                .ThenBy(s => s.Name)
                .ThenBy(s => s.Email)
                .ToList();
            Group group = new Group();

            for (int i = 0; i < students.Count; i++)
            {
                group.Students.Add(students[i]);
                if (group.Students.Count == town.Capacity || i == students.Count - 1)
                {
                    towns[town.Name].Groups.Add(group);
                    group = new Group();
                }
            }
        }

        private static Town ReadTown(string input)
        {
            string[] townInfo = input
                .Split(new char[] { '=', '>' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.Trim())
                .ToArray();
            string[] seatsInfo = townInfo[1].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            string name = townInfo[0];
            int capacity = int.Parse(seatsInfo[0]);

            return new Town(name, capacity);
        }

        private static Student ReadStudent(string input)
        {
            string[] studentInfo = input
              .Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries)
              .Select(x => x.Trim())
              .ToArray();
            string studentName = studentInfo[0];
            string email = studentInfo[1];
            DateTime registrationDate = DateTime.ParseExact(studentInfo[2], "d-MMM-yyyy", null);

            return new Student(studentName, email, registrationDate);
        }

        private static void PrintGroups(List<Town> towns)
        {
            towns = towns.OrderBy(t => t.Name).ToList();
            int townsCount = towns.Count;
            int groupsCount = 0;

            foreach (Town t in towns)
            {
                groupsCount += t.Groups.Count;
            }

            Console.WriteLine($"Created {groupsCount} groups in {townsCount} towns:");

            foreach (Town t in towns)
            {
                foreach (Group g in t.Groups)
                {
                    List<string> emails = new List<string>();

                    foreach (Student s in g.Students)
                    {
                        emails.Add(s.Email);
                    }

                    Console.Write($"{t.Name} => ");
                    Console.WriteLine(string.Join(", ", emails));
                }
            }
        }
    }

    public class Town
    {
        public string Name { get; set; }
        public int Capacity { get; set; }
        public List<Group> Groups { get; set; }

        public Town()
        {
            this.Groups = new List<Group>();
        }

        public Town(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.Groups = new List<Group>();
        }
    }

    public class Group
    {
        public List<Student> Students { get; set; }
        public List<string> emails { get; set; }

        public Group()
        {
            this.Students = new List<Student>();
            this.emails = new List<string>();
        }
    }

    public class Student
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime RegistrartionDate { get; set; }

        public Student(string name, string email, DateTime registrationDate)
        {
            this.Name = name;
            this.Email = email;
            this.RegistrartionDate = registrationDate;
        }
    }
}
