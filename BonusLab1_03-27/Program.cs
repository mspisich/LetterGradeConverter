using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                int grade = int.Parse(Console.ReadLine());

                //Print letter grade

                /*
                Grade Ranges:

                A+: 100-99
                A: 98-88
                B+: 87-86
                B: 85-80
                C+: 79-76
                C: 75-67
                D+: 66-60
                F: 59-0
                */

                if (grade >= 99)
                {
                    Console.WriteLine("Letter Grade: A+");
                }
                else if (grade >= 88 && grade <= 98)
                {
                    Console.WriteLine("Letter Grade: A");
                }
                else if (grade >= 86 && grade <= 87)
                {
                    Console.WriteLine("Letter Grade: B+");
                }
                else if (grade >= 80 && grade <= 85)
                {
                    Console.WriteLine("Letter Grade: B");
                }
                else if (grade >= 76 && grade <= 79)
                {
                    Console.WriteLine("Letter Grade: C+");
                }
                else if (grade >= 67 && grade <= 75)
                {
                    Console.WriteLine("Letter Grade: C");
                }
                else if (grade == 66)
                {
                    Console.WriteLine("Letter Grade: D+");
                }
                else if (grade >= 60 && grade <= 65)
                {
                    Console.WriteLine("Letter Grade: D");
                }
                else if (grade < 60)
                {
                    Console.WriteLine("Letter Grade: F");
                }

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
