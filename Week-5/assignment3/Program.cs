using System;

namespace assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the course name: ");
            string courseName = Console.ReadLine();

            Console.Write("Enter number of students: ");
            int studentNum = int.Parse(Console.ReadLine());
            Console.Write("\n");

            string[] studentNames = new string[studentNum + 1];
            double[] studentGrades = new double[101];

            double highestGrade = 0;
            string highestStudent = "";
            double sum = 0;
            int count = 0;

            for (int i = 0; i < studentNum; i++)
            {
                count++;
                Console.Write("Enter name of student " + count + ": ");
                studentNames[i] = Console.ReadLine();
            }
            Console.Write("\n");

            for (int i = 0; i < studentNum; i++)
            {
                Console.Write("Enter grade of student " + studentNames[i] + ": ");
                studentGrades[i] = int.Parse(Console.ReadLine());
                 
                sum += studentGrades[i];

                if (studentGrades[i] > highestGrade)
                {
                    highestGrade = studentGrades[i];
                    highestStudent = studentNames[i];
                }
            }
            Console.Write("\n");

            double avrg = sum / studentNum;
            Console.Write($"Average grade: {avrg:0.0}");
            Console.Write("\n");
            Console.Write("Student " + highestStudent + " has maximum grade: " + highestGrade);
            Console.Write("\n");

            for (int i = 0; i < studentNum; i++)
            {
                Console.Write("Grade for student " + studentNames[i] + " ( course " + courseName + "): " + studentGrades[i]);
                Console.Write("\n");
            }
        }
    }
}
