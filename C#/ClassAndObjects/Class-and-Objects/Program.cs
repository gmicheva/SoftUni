using System;
using System.Collections.Generic;
using System.Linq;

namespace Class_and_Objects
{
    class Student
    {
        public string Name;
        public double AvarageGrade;
    }

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();

            for (int i = 0; i < n; i++)
            {
                List<string> data = Console.ReadLine().Split(' ').ToList();
                Student currentStudent = new Student();
                currentStudent.Name = data[0];
                currentStudent.AvarageGrade = data.Skip(1).Select(double.Parse).Average();
                students.Add(currentStudent);
            }
            foreach (Student item in students.Where(x => x.AvarageGrade >=5.00).OrderBy(x => x.Name).ThenByDescending(x => x.AvarageGrade))
            {
                Console.WriteLine($"{item.Name} -> {item.AvarageGrade:0.00}");
            }
        }
    }
}
