/*
Author: Tyler Williams
Date: 1/19/2023
Description: C# Console Application for calculating letter grades
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deliverable_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a numeric grade: ");
            try
            {                
                int grade = int.Parse(Console.ReadLine());

                string letter;

                if (grade >= 90)
                {
                    letter = "A";
                    Console.WriteLine("Your expected letter grade for ISM 4300 is: " + letter);
                }
                else if (grade >= 80 && grade < 90)
                {
                    letter = "B";
                    Console.WriteLine("Your expected letter grade for ISM 4300 is: " + letter);
                }
                else if (grade >= 70 && grade < 80)
                {
                    letter = "C";
                    Console.WriteLine("Your expected letter grade for ISM 4300 is: " + letter);
                }
                else if (grade >= 60 && grade < 70)
                {
                    letter = "D";
                    Console.WriteLine("Your expected letter grade for ISM 4300 is: " + letter);
                }
                else
                {
                    letter = "F";
                    Console.WriteLine("Your expected letter grade for ISM 4300 is: " + letter);
                }
                Console.ReadKey(true);
            }
            catch
            {
                Console.WriteLine("Enter a numeric value");
                Console.ReadKey(true);
            }
        }
    }
}
