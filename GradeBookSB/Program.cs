using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace GradeBookSB
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> students = new List<string>();
            List<double> grades = new List<double>();
            string newStudent;

            Console.WriteLine("Enter your students (or ENTER to finish):");
            do
            {
                newStudent = Console.ReadLine();
                if (newStudent != "")
                {
                    students.Add(newStudent);
                }
            }
            while (newStudent != "");

            // Get student grades
            foreach (string student in students)
            {
                Console.WriteLine("Grade for " + student + ": ");
                double newGrade = double.Parse(Console.ReadLine());
                grades.Add(newGrade);
            }

            // Print class roster
            StringBuilder classRoster = new StringBuilder("\nClass roster:");
            //Console.WriteLine("\nClass roster:");
            for (int i = 0; i < students.Count; i++)
            {
                classRoster.Append("\n" + students[i] + " (" + grades[i] + ")");
                //Console.WriteLine(students[i] + " (" + grades[i] + ")");
            }

            double sum = grades.Sum();
            double avg = sum / grades.Count;

            classRoster.Append("\nAverage grade: " + avg);
            Console.WriteLine(classRoster.ToString());
            //Console.WriteLine("Average grade: " + avg);

            Console.ReadLine();
        }
    }
}