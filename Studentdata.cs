using System;

namespace ConsoleApp
{
    class Studentdata
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many students are there in the class? : ");
            var studentCount = int.Parse(Console.ReadLine());

            var studentGrades = new int[studentCount];
            var studentNames = new string[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                Console.Write("student name: ");
                studentNames[i] = Console.ReadLine();

                Console.Write("student grade: ");
                studentGrades[i] = int.Parse(Console.ReadLine());

            }
            for (int i = 0; i < studentCount; i++)

            {
                Console.WriteLine("The details are Name: {0},Grade: {1}", studentNames[i], studentGrades[i]);


            }

        }
        
    }
    }