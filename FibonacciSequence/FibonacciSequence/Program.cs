using System;

namespace FibonacciSequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string YesNo;

            Console.WriteLine("\nThis program accepts 0 and perform the first 20 of Fibonacci Sequence.");

            do 
            {
            int loop = 0, num1, num2 = 1, temp; //the variables are inside the "do" so that when it loops, the variables will restart.

            Console.Write("\nEnter 0: ");
            num1 = Convert.ToInt32(Console.ReadLine());

                if (num1 == 0)
                {
                    while (loop < 20)
                    {
                        Console.WriteLine(num1); 
                        temp = num1; 
                        num1 = num2; 
                        num2 = temp + num2;
                        loop++;
                    }
                }
                else
                {
                    Console.WriteLine("\nInvalid Input!");
                }

            Console.Write("\nRestart? (Yes/No): ");
            YesNo = Console.ReadLine();

            }
            while (YesNo == "Yes");

            Console.WriteLine("\nThank you for using my Finonacci Sequence Project!");

            Console.ReadKey(true);
        }
    }
}
