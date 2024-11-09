using System;

namespace Diamond
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Green;
            for (int x = 0; x < 20; x++)
            {
                for (int y = 20; y > x; y--)
                {
                    Console.Write(" ");
                }
                for (int z = 0; z <= x; z++)
                {
                    Console.Write("X ");
                }
                Console.WriteLine();
            }
            for (int v = 20; v >= 0; v--)
            {
                for (int w = 20; w > v; w--)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j <= v; j++)
                {
                    Console.Write("X ");
                }
                Console.WriteLine();
            }
            Console.ReadKey(true);
        }
    }
}
