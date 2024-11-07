using System;

namespace ChristmasTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 20; i++)
                {
                    for (int y = 20; y > i; y--)
                    {
                        Console.Write(" ");
                    }
                    for (int x = 0; x <= i; x++)
                    {
                        Console.Write("X ");
                    }
                    Console.WriteLine();
                }
            for (int z = 0; z <= 5; z++)
                {
                    for (int x = 0; x < 15; x++)
                    {
                        Console.Write(" ");
                    }
                    for (int w = 0; w < 6; w++)
                    {
                        Console.Write("I ");
                    }
                    Console.WriteLine();
                }
            Console.ReadKey(true);
        }
    }
}
