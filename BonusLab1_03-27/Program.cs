using System;

namespace BonusLab1_03_27
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Letter Grade Converter!");

            bool runProgram = true;
            while (runProgram)
            {
                //User inputs numerical grade
                Console.WriteLine("Enter a numerical grade: ");
                int gradeNum = int.Parse(Console.ReadLine());

                //Print letter grade

                /*
                Grade Ranges:

                A+: 100-99
                A: 98-88
                B+: 87-86
                B: 85-80
                C+: 79-76
                C: 75-67
                D+: 66
                D: 65-60
                F: 59-0
                */

                //Letter grade defaults to error message
                string gradeLetter = "Invalid input!";

                if (gradeNum > 100)
                {
                    gradeLetter = "Grade cannot be over 100!";
                }
                else if (gradeNum >= 99 && gradeNum <= 100)
                {
                    gradeLetter = "A+";
                }
                else if (gradeNum >= 88)
                {
                    gradeLetter = "A";
                }
                else if (gradeNum >= 86)
                {
                    gradeLetter = "B+";
                }
                else if (gradeNum >= 80)
                {
                    gradeLetter = "B";
                }
                else if (gradeNum >= 76)
                {
                    gradeLetter = "C+";
                }
                else if (gradeNum >= 67)
                {
                    gradeLetter = "C";
                }
                else if (gradeNum == 66)
                {
                    gradeLetter = "D+";
                }
                else if (gradeNum >= 60)
                {
                    gradeLetter = "D";
                }
                else if (gradeNum < 60 && gradeNum >= 0)
                {
                    gradeLetter = "F";
                }
                else if (gradeNum < 0)
                {
                    gradeLetter = "Grade cannot be less than 0!";
                }

                //Print grade
                Console.WriteLine("Letter Grade: " + gradeLetter);

                //Ask if user wants to continue
                Console.WriteLine("Continue? y/n: ");
                string cont = Console.ReadLine();

                //Verify input
                while(cont != "y" && cont != "Y" && cont != "n" && cont != "N")
                {
                    Console.WriteLine("Please type y/n! Continue?: ");
                    cont = Console.ReadLine();
                }

                //Do not continue, quit program
                if(cont == "n" || cont == "N")
                {
                    runProgram = false;
                }
            }
        }
    }
}
