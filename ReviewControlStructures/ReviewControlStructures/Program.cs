using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewControlStructures
{
    internal class Program
    {
        static void Main(string[] args)
        {
        Main:   
            Console.Clear(); // Clears the screen every time Main runs

            Console.WriteLine("This program checks if your number is even or odd and shows its sequence."); //PROMPT FOR USERS

            Console.Write("\nEnter a number: ");
            string input1 = Console.ReadLine();

            int num1 = 0;
            bool valid1 = int.TryParse(input1, out num1);

            if (valid1)
            {
                if (num1 % 2 == 0)  //EVEN NUMBER
                {
                    Console.WriteLine(num1 + " is an even number.");
                    Console.WriteLine("\nHere's the sequence of the number you entered:"); //FIRST OUTPUT

                    int x = num1;
                    while (x >= 2) //LOOPS AS LONG AS X IS 2 OR GREATER
                    {
                        Console.Write(x + " ");
                        x -= 2; //DECREMENTS BY 2
                    }
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Sorry, I can’t show the sequence for odd numbers."); //SECOND OUTPUT
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid number."); //THIRD OUTPUT
            }

            Console.Write("\nDo you want to try again (y/n)? "); //ASKS USERS IF THEY WANT TO TRY AGAIIN
            string again = Console.ReadLine();

            if (again == "y" || again == "Y")
            {
                Main(args); //RESTART PROGRAM WITH CLEAR SCREEN
                return;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("\nThank you for using this program."); //END OF LOOP
            }

            Console.ReadKey();
        }
    }
}
