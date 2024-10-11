using System;

namespace NumberOddOrEven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\nThis program allows the user to input a number and check wether it is an Odd or Even number.");
            Console.Write("\nEnter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            
            if (number % 2 == 0)
            {
                Console.WriteLine($"\n{number} is an Even number!");
            }
            else
            {
                Console.WriteLine($"\n{number} is an Odd number!");
            }
            Console.ReadKey(true);
        }
    }
}
