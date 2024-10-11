using System;

namespace CarsPrice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;
            double HondaPrice = 764000, HyundaiPrice = 1068000, NissanPrice = 1179000, MitsubishiPrice = 919000, UserMoney, Change;
            string YesorNo, Yes0rNo2;

            Console.WriteLine("\n\nThis program allow the user to pick a car and view it's price to purchase it.");

            do
            {
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
                                if (UserMoney > 76400)
                                {
                                    Change = UserMoney - HondaPrice;
                                    Console.WriteLine($"\nHere is your change {Change:n2}");
                                }
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
                                if (UserMoney > 1068000)
                                {
                                    Change = UserMoney - HyundaiPrice;
                                    Console.WriteLine($"\nHere is your change {Change:n2}");
                                }
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
                        Console.WriteLine($"\nYou've chosen Nissan! \nIts selling price is {NissanPrice:n2}");
                        Console.Write("\nInterested? Do you want to purchase? (Yes or No): ");
                        YesorNo = Console.ReadLine();
                        if (YesorNo == "Yes")
                        {
                            Console.Write("\nEnter your money: ");
                            UserMoney = Convert.ToDouble(Console.ReadLine());
                            if (UserMoney >= 1179000)
                            {
                                Console.WriteLine("\nYou've purchased a Nissan car!");
                                if (UserMoney > 1179000)
                                {
                                    Change = UserMoney - NissanPrice;
                                    Console.WriteLine($"\nHere is your change {Change:n2}");
                                }
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
                        Console.WriteLine($"\nYou've chosen Mitsubishi! \nIt's selling price is {MitsubishiPrice:n2}");
                        Console.Write("\nInterested? Do you want to purchase? (Yes or No): ");
                        YesorNo = Console.ReadLine();
                        if (YesorNo == "Yes")
                        {
                            Console.Write("\nEnter your money: ");
                            UserMoney = Convert.ToDouble(Console.ReadLine());
                            if (UserMoney >= 919000)
                            {
                                Console.WriteLine("\nYou've purchased a Mitsubishi car!");
                                if (UserMoney > 919000)
                                {
                                    Change = UserMoney - MitsubishiPrice;
                                    Console.WriteLine($"\nHere is your change {Change:n2}");
                                }
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
                    case 5:
                        Console.WriteLine("\nThank you for checking my CarPrice project.");
                        break;
                    default:
                        Console.WriteLine("\nInvalid input! Please select a valid choice.");
                        break;

                }
                Console.Write("\nDo you want another transaction? (Yes or No): ");
                Yes0rNo2 = Console.ReadLine();

            }
            while (Yes0rNo2 == "Yes");

            Console.WriteLine("\nThank you for your time with us!");

            Console.ReadKey(true);
        }
    }
}
