using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challange1
{
    internal class Program
    {

        static List<student> students = new List<student>();

        static void Main()
        {
            int choice;
            while (true)
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
                            DisplayTopStudents();
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
            Console.Write("Enter Matric marks: ");
            int matricMarks = int.Parse(Console.ReadLine());
            Console.Write("Enter Fsc marks: ");
            int fscMarks = int.Parse(Console.ReadLine());
            Console.Write("Enter Ecat marks: ");
            int ecatMarks = int.Parse(Console.ReadLine());
            student newStudent = new student(name, matricMarks, fscMarks, ecatMarks);
            students.Add(newStudent);
            Console.WriteLine("Student added successfully!\n");
        }
        
        static void ShowStudents()
        {
            Console.WriteLine("List of Students:");
            foreach (var student in students)
            {
                student.DisplayStudentInfo();
            }
        }

        static void CalculateAggregate()
        {
            double totalAggregate = 0;
            foreach (var student in students)
            {
                totalAggregate += student.CalculateAggregate();
            }

            double averageAggregate = totalAggregate / students.Count;

            Console.WriteLine($"Average Aggregate of all students: {averageAggregate:F2}\n");
        }

        static void DisplayTopStudents()
        {
            var topStudents = students.OrderByDescending(s => s.CalculateAggregate()).Take(3);

            Console.WriteLine("Top 3 Students:");
            foreach (var student in topStudents)
            {
                student.DisplayStudentInfo();
            }
        }
    }
}
