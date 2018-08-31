using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentsDict
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> students = new Dictionary<int, string>();
            string newStudent;

            Console.WriteLine("Enter your students (or ENTER to finish):");
            do
            {
                Console.Write("Id: ");
                newStudent = Console.ReadLine();
                if (newStudent != "")
                {
                    int id = int.Parse(newStudent);
                    // Get the student's name
                    Console.WriteLine("Name: ");
                    string newName = Console.ReadLine();

                    students.Add(id, newName);
                }
            }
            while (newStudent != "");

            // Print class roster
            Console.WriteLine("\nClass roster:");
            foreach (KeyValuePair<int, string> student in students)
            {
                Console.WriteLine(student.Key + " (" + student.Value + ")");
            }

            Console.ReadLine();
        }
    }
}
