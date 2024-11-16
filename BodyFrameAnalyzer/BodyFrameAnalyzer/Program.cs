using System;

namespace BodyFrameAnalyzer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            int weight, height;

            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Green;

            Console.SetCursorPosition(50, 1);
            Console.WriteLine("BODY FRAME ANALYZER");

            Console.SetCursorPosition(25, 3);
            Console.Write("Enter your Name: ");
            name = Console.ReadLine();

            Console.SetCursorPosition(25, 4);
            Console.Write("Enter your weight (lbs): ");
            weight = Convert.ToInt32(Console.ReadLine());

            Console.SetCursorPosition(25, 5);
            Console.Write("Enter your height (inch): ");
            height = Convert.ToInt32(Console.ReadLine());

            Console.SetCursorPosition(25, 7);
            Console.Write($"Greetings, {name}. ");

            switch (height)
            {
                case 58:
                    if (weight <= 111)
                    {
                        Console.Write("Your body is a Small Frame.");
                    }
                    else if (weight <= 121)
                    {
                        Console.Write("Your body is a Medium Frame.");
                    }
                    else if (weight <= 131)
                    {
                        Console.Write("Your body is a Large Frame.");
                    }
                    break;
                case 59:
                    if (weight <= 113)
                    {
                        Console.Write("Your body is a Small Frame.");
                    }
                    else if (weight <= 123)
                    {
                        Console.Write("Your body is a Medium Frame.");
                    }
                    else if (weight <= 134)
                    {
                        Console.Write("Your body is a Large Frame.");
                    }
                    break;
                case 60:
                    if (weight <= 115)
                    {
                        Console.Write("Your body is a Small Frame.");
                    }
                    else if (weight <= 126)
                    {
                        Console.Write("Your body is a Medium Frame.");
                    }
                    else if (weight <= 137)
                    {
                        Console.Write("Your body is a Large Frame.");
                    }
                    break;
                case 61:
                    if (weight <= 118)
                    {
                        Console.Write("Your body is a Small Frame.");
                    }
                    else if (weight <= 129)
                    {
                        Console.Write("Your body is a Medium Frame.");
                    }
                    else if (weight <= 140)
                    {
                        Console.Write("Your body is a Large Frame.");
                    }
                    break;
                case 62:
                    if (weight <= 121)
                    {
                        Console.Write("Your body is a Small Frame.");
                    }
                    else if (weight <= 132)
                    {
                        Console.Write("Your body is a Medium Frame.");
                    }
                    else if (weight <= 143)
                    {
                        Console.Write("Your body is a Large Frame.");
                    }
                    break;
                case 63:
                    if (weight <= 124)
                    {
                        Console.Write("Your body is a Small Frame.");
                    }
                    else if (weight <= 135)
                    {
                        Console.Write("Your body is a Medium Frame.");
                    }
                    else if (weight <= 147)
                    {
                        Console.Write("Your body is a Large Frame.");
                    }
                    break;
                case 64:
                    if (weight <= 127)
                    {
                        Console.Write("Your body is a Small Frame.");
                    }
                    else if (weight <= 138)
                    {
                        Console.Write("Your body is a Medium Frame.");
                    }
                    else if (weight <= 155)
                    {
                        Console.Write("Your body is a Large Frame.");
                    }
                    break;
                case 65:
                    if (weight <= 130)
                    {
                        Console.Write("Your body is a Small Frame.");
                    }
                    else if (weight <= 141)
                    {
                        Console.Write("Your body is a Medium Frame.");
                    }
                    else if (weight <= 155)
                    {
                        Console.Write("Your body is a Large Frame.");
                    }
                    break;
            }
        Console.ReadKey(true);
        }
    }
}