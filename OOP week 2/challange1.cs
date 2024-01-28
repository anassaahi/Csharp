using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Student
{
    public string Name;
    public int MatricMarks;
    public int FscMarks;
    public int EcatMarks;

    public Student(string name, int matricMarks, int fscMarks, int ecatMarks)
    {
        Name = name;
        MatricMarks = matricMarks;
        FscMarks = fscMarks;
        EcatMarks = ecatMarks;
    }

    public int CalculateAggregate()
    {
        return (MatricMarks + FscMarks + EcatMarks) / 3;
    }
}
namespace challange1
{
    internal class Program
    {
        static List<Student> students = new List<Student>();

        static void Main()
        {
            int choice;
            while(true)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Show Students");
                Console.WriteLine("3. Calculate Aggregate");
                Console.WriteLine("4. Top Students");
                Console.WriteLine("5. Exit");

                Console.Write("Enter your choice (1-5): ");
                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            AddStudent();
                            break;
                        case 2:
                            ShowStudents();
                            break;
                        case 3:
                            CalculateAggregate();
                            break;
                        case 4:
                            TopStudents();
                            break;
                        case 5:
                            Console.WriteLine("Exiting the program. Goodbye!");
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                }

                Console.WriteLine();
            }
            
        }

        static void AddStudent()
        {
            Console.Write("Enter student name: ");
            string name = Console.ReadLine();

            Console.Write("Enter matric marks: ");
            int matricMarks = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Fsc marks: ");
            int fscMarks = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Ecat marks: ");
            int ecatMarks = Convert.ToInt32(Console.ReadLine());

            Student newStudent = new Student(name, matricMarks, fscMarks, ecatMarks);
            students.Add(newStudent);

            Console.WriteLine("Student information added successfully.");
        }

        static void ShowStudents()
        {
            Console.WriteLine("List of Students:");

            foreach (var student in students)
            {
                Console.WriteLine($"Name: {student.Name}, Matric Marks: {student.MatricMarks}, Fsc Marks: {student.FscMarks}, Ecat Marks: {student.EcatMarks}");
            }
        }

        static void CalculateAggregate()
        {
            if (students.Count > 0)
            {
                int totalAggregate = 0;

                foreach (var student in students)
                {
                    totalAggregate += student.CalculateAggregate();
                }

                double averageAggregate = (double)totalAggregate / students.Count;
                Console.WriteLine($"Average Aggregate of all students: {averageAggregate:F2}");
            }
            else
            {
                Console.WriteLine("No students available to calculate aggregate.");
            }
        }

        static void TopStudents()
        {
            if (students.Count > 0)
            {
                var top3Students = students.OrderByDescending(s => s.CalculateAggregate()).Take(3);

                Console.WriteLine("Top 3 Students:");

                foreach (var student in top3Students)
                {
                    Console.WriteLine($"Name: {student.Name}, Aggregate: {student.CalculateAggregate()}");
                }
            }
            else
            {
                Console.WriteLine("No students available to display top students.");
            }
        }
    }
}
