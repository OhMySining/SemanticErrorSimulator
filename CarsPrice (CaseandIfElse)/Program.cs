using System;

namespace CarsPrice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;
            double HondaPrice = 764000, HyundaiPrice = 1068000, NissanPrice = 1179000, MitsubishiPrice = 919000, UserMoney;
            string YesorNo;

            Console.WriteLine("\nThis program allow the user to pick a car and view it's price to purchase it.");
            Console.WriteLine("\nWhat brand of car are you looking for? \n1. Honda \n2. Hyundai \n3. Nissan \n4. Mitsubishi \n5. Exit");
            Console.Write("\nEnter your choice here: ");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine($"\nYou've chosen Honda! \nIts selling price is {HondaPrice:n2}");
                    Console.Write("\nInterested? Do you want to purchase? (Yes or No): ");
                    YesorNo = Console.ReadLine();
                        if (YesorNo == "Yes")
                        {
                        Console.Write("\nEnter your money: ");
                        UserMoney = Convert.ToDouble(Console.ReadLine());
                            if (UserMoney >= 764000)
                            {
                            Console.WriteLine("\nYou've purchased a Honda car!");
                            }
                            else
                            {
                            Console.WriteLine("\nPurchase failed.");
                            }
                        }
                        else
                        {
                        Console.WriteLine("\nThank you for your time!");
                        }
                    break;
                case 2:
                    Console.WriteLine($"\nYou've chosen Hyundai! \nIts selling price is {HyundaiPrice:n2}");
                    Console.Write("\nInterested? Do you want to purchase? (Yes or No): ");
                    YesorNo = Console.ReadLine();
                    if (YesorNo == "Yes")
                    {
                        Console.Write("\nEnter your money: ");
                        UserMoney = Convert.ToDouble(Console.ReadLine());
                        if (UserMoney >= 1068000)
                        {
                            Console.WriteLine("\nYou've purchased a Hyundai car!");
                        }
                        else
                        {
                            Console.WriteLine("\nPurchase failed.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nThank you for your time!");
                    }
                    break;
                case 3:
                    Console.WriteLine($"\nYou've chosen Nissan! \nIts selling price is {NissanPrice}");
                    Console.Write("\nInterested? Do you want to purchase? (Yes or No): ");
                    YesorNo = Console.ReadLine();
                    if (YesorNo == "Yes")
                    {
                        Console.Write("\nEnter your money: ");
                        UserMoney = Convert.ToDouble(Console.ReadLine());
                        if (UserMoney >= 1179000)
                        {
                            Console.WriteLine("\nYou've purchased a Nissan car!");
                        }
                        else
                        {
                            Console.WriteLine("\nPurchase failed.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nThank you for your time!");
                    }
                    break;
                case 4:
                    Console.WriteLine($"\nYou've chosen Mitsubishi! \nIt's selling price is {MitsubishiPrice}");
                    Console.Write("\nInterested? Do you want to purchase? (Yes or No): ");
                    YesorNo = Console.ReadLine();
                    if (YesorNo == "Yes")
                    {
                        Console.Write("\nEnter your money: ");
                        UserMoney = Convert.ToDouble(Console.ReadLine());
                        if (UserMoney >= 919000)
                        {
                            Console.WriteLine("\nYou've purchased a Mitsubishi car!");
                        }
                        else
                        {
                            Console.WriteLine("\nPurchase failed.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nThank you for your time!");
                    }
                    break;
                default:
                    Console.WriteLine("\nInvalid input! Please select a valid choice.");
                    break;
            }
            Console.ReadKey(true);
        }
    }
}
