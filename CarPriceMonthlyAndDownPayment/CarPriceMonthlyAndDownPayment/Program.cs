using System;

namespace CarPriceMonthlyAndDownPayment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;
            double ToyotaPrice = 1500000, HondaPrice = 1200000, FordPrice = 2300000, BMWPrice = 2500000, MercedesPrice = 3000000;
            string YesNo;
            double DownPayment, RemainingBalance, Installment;

            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("WELCOME TO ABC CAR DEALERCHIP");

            Console.ForegroundColor= ConsoleColor.Black;
            Console.WriteLine("\nChoose a car brand: \n\n1. Toyota - \n\n2. Honda - \n\n3. Ford - \n\n4. BMW - \n\n5. Mercedes -");

            Console.ForegroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(18, 4);
            Console.WriteLine("P 1,500,000");

            Console.SetCursorPosition(18, 6);
            Console.WriteLine("P 1,200,000");

            Console.SetCursorPosition(18, 8);
            Console.WriteLine("P 2,300,000");

            Console.SetCursorPosition(18, 10);
            Console.WriteLine("P 2,500,000");

            Console.SetCursorPosition(18, 12);
            Console.WriteLine("P 3,000,000");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\nEnter the number of your chosen car brand: ");
            choice = Convert.ToInt32(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.DarkRed;
            switch (choice)
            {
                case 1:
                    Console.WriteLine("You selected: Toyota");
                    Console.WriteLine($"Price: P {ToyotaPrice:n2}");
                    Console.Write("\nDo you want to purchase this car? (Yes/No): ");
                    YesNo = Console.ReadLine();
                    
                    if (YesNo == "Yes")
                    {
                        DownPayment = ToyotaPrice * .30;
                        Console.WriteLine($"Downpayment (30%): P {DownPayment:n2}");

                        RemainingBalance = ToyotaPrice - DownPayment;
                        Console.WriteLine($"\nRemaining Balance: P {RemainingBalance:n2}");

                        Installment = RemainingBalance / 60;
                        Console.WriteLine($"\nMonthly Installment (for 5 years): P {Installment:n2}");
                    }
                    else
                    {
                        Console.WriteLine("\nThank you for your interest.");
                    }
                    break;
                case 2:
                    Console.WriteLine("You selected: Honda");
                    Console.WriteLine($"Price: P {HondaPrice:n2}");
                    Console.Write("\nDo you want to purchase this car? (Yes/No): ");
                    YesNo = Console.ReadLine();

                    if (YesNo == "Yes")
                    {
                        DownPayment = HondaPrice * .30;
                        Console.WriteLine($"Downpayment (30%): P {DownPayment:n2}");

                        RemainingBalance = HondaPrice - DownPayment;
                        Console.WriteLine($"\nRemaining Balance: P {RemainingBalance:n2}");

                        Installment = RemainingBalance / 60;
                        Console.WriteLine($"\nMonthly Installment (for 5 years): P {Installment:n2}");
                    }
                    else
                    {
                        Console.WriteLine("\nThank you for your interest.");
                    }
                    break;
                case 3:
                    Console.WriteLine("You selected: Ford");
                    Console.WriteLine($"Price: P {FordPrice:n2}");
                    Console.Write("\nDo you want to purchase this car? (Yes/No): ");
                    YesNo = Console.ReadLine();

                    if (YesNo == "Yes)")
                    {
                        DownPayment = FordPrice * .30;
                        Console.WriteLine($"Downpayment (30%): P {DownPayment:n2}");

                        RemainingBalance = FordPrice - DownPayment;
                        Console.WriteLine($"\nRemaining Balance: P {RemainingBalance:n2}");

                        Installment = RemainingBalance / 60;
                        Console.WriteLine($"\nMonthly Installment (for 5 years): P {Installment:n2}");
                    }
                    else
                    {
                        Console.WriteLine("\nThank you for your interest.");
                    }
                    break;
                case 4:
                    Console.WriteLine("You selected: BMW");
                    Console.WriteLine($"Price: P {BMWPrice:n2}");
                    Console.Write("\nDo you want to purchase this car? (Yes/No): ");
                    YesNo = Console.ReadLine();

                    if (YesNo == "Yes")
                    {
                        DownPayment = BMWPrice * .30;
                        Console.WriteLine($"Downpayment (30%): P {DownPayment:n2}");

                        RemainingBalance = BMWPrice - DownPayment;
                        Console.WriteLine($"\nRemaining Balance: P {RemainingBalance:n2}");

                        Installment = RemainingBalance / 60;
                        Console.WriteLine($"\nMonthly Installment (for 5 years): P {Installment:n2}");
                    }
                    else
                    {
                        Console.WriteLine("\nThank you for your interest.");
                    }
                    break;
                case 5:
                    Console.WriteLine("You selected: Mercedes");
                    Console.WriteLine($"Price: P {MercedesPrice:n2}");
                    Console.Write("\nDo you want to purchase this car? (Yes/No): ");
                    YesNo = Console.ReadLine();

                    if (YesNo == "Yes")
                    {
                        DownPayment = MercedesPrice * .30;
                        Console.WriteLine($"Downpayment (30%): P {DownPayment:n2}");

                        RemainingBalance = MercedesPrice - DownPayment;
                        Console.WriteLine($"\nRemaining Balance: P {RemainingBalance:n2}");

                        Installment = RemainingBalance / 60;
                        Console.WriteLine($"\nMonthly Installment (for 5 years): P {Installment:n2}");
                    }
                    else
                    {
                        Console.WriteLine("\nThank you for your interest.");
                    }
                    break;
                default:
                    Console.WriteLine("\nEnter a valid choice");
                    break;
            }
            Console.ReadKey(true);
        }
    }
}
