using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resturant_App
{
    class Program
    {
        static void Main(string[] args)
        {
            bool displayMenu = true;
            while (displayMenu)
            {
                displayMenu = MainMenu();

            }
        }

        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the C# resturant!");
            Console.WriteLine(" ");
            Console.WriteLine("Would you like a booth or table?");
            Console.WriteLine("1) Table");
            Console.WriteLine("2) Booth");
            Console.WriteLine("3) Exit");
            int ChosenSitting = int.Parse(Console.ReadLine());

            if (ChosenSitting == 1)
            {
                Console.WriteLine("You are assigned to a table. Press Enter to start ordering.");
                Console.ReadLine();
                Ordering();
                return true;
            }
            else if (ChosenSitting == 2)
            {
                Console.WriteLine("You are assigned to a booth. Press Enter to start Ordering.");
                Console.ReadLine();
                Ordering();
                return true;
            }
            else
            {
                return false;
            }


        }

        private static void Ordering()
        {
            string[] food = FoodMenu();
            string[] drink = DrinkMenu();
            Console.Clear();

            double totalprice = double.Parse(food[1]) + double.Parse(drink[1]);
            double tip = totalprice * 0.15;
            double total = totalprice + tip;
            Console.WriteLine("You ordered " + food[0] + " and " + drink[0] + " for total of $" + totalprice + "." +
                " We suggest you pay tip amount of $" + tip + " make it total $" + total + ".");
            Console.ReadLine();
        }

        private static string[] FoodMenu()
        {
            Console.Clear();
            Console.WriteLine("Which menu would you like?");
            Console.WriteLine("1) Breakfast menu");
            Console.WriteLine("2) Lunch menu");
            Console.WriteLine("3) Dinner menu");
            int ChosenMenu = int.Parse(Console.ReadLine());

            string[] food = new string [2];

            if (ChosenMenu == 1)
            {
                food = BreakfastMenu();
                return food;
            }
            else if (ChosenMenu == 2)
            {
                food = LunchMenu();
                return food;
            }
            else
            {
                food = DinnerMenu();
                return food;
            }
        }

        private static string[] BreakfastMenu()
        {
            Console.Clear();
            string[] BreakfastItems = new string[] { "Eggs", "Harshbrown", "Bacon", "Bread", "Fruit Cup" };
            string[] BreakfastPrice = new string[] { "1.5", "1.5", "2.0", "1.0", "2.5" };
            Console.WriteLine("Please select items you would like to order.");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i+1 + " )" + BreakfastItems[i]);
            }
            int ChosenBreakfast = int.Parse(Console.ReadLine())-1;

            string[] OrderedFood = new string[2];
            OrderedFood[0] = BreakfastItems[ChosenBreakfast];
            OrderedFood [1] = BreakfastPrice[ChosenBreakfast];
            Console.WriteLine("You ordered " + OrderedFood [0] + " for $" + OrderedFood[1] + " . " +
                "Please press Enter to order drinks." );
            Console.ReadLine();

            return OrderedFood; 
        }

        private static string[] LunchMenu()
        {
            Console.Clear();
            string[] LunchItems = new string[] { "Sandwich", "Soup", "Wrap", "Burger", "Noodle" };
            string[] LunchPrice = new string[] { "3.0", "2.5", "3.0", "3.5", "3.5" };
            Console.WriteLine("Please select items you would like to order.");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i+1 + " )" + LunchItems[i]);
            }
            int ChosenLunch = int.Parse(Console.ReadLine()) - 1;

            string[] OrderedFood = new string[2];
            OrderedFood[0] = LunchItems[ChosenLunch];
            OrderedFood[1] = LunchPrice[ChosenLunch];
            Console.WriteLine("You ordered " + OrderedFood[0] + " for $" + OrderedFood[1] + " . " +
                "Please press Enter to order drinks.");
            Console.ReadLine();

            return OrderedFood;
        }

        private static string[] DinnerMenu()
        {
            Console.Clear();
            string[] DinnerItems = new string[] { "Steak", "Porkchop", "Risotto", "Fish", "Chicken" };
            string[] DinnerPrice = new string[] { "7.0", "6.5", "4.0", "7.5", "6.0" };

            Console.WriteLine("Please select items you would like to order.");
            for (int i = 0; i<5; i++)
            {
                Console.WriteLine(i+1 + " )" + DinnerItems[i]);
            }
            int ChosenDinner = int.Parse(Console.ReadLine()) - 1;

            string[] OrderedFood = new string[2];
            OrderedFood[0] = DinnerItems[ChosenDinner];
            OrderedFood[1] = DinnerPrice[ChosenDinner];
            Console.WriteLine("You ordered " + OrderedFood[0] + " for $" + OrderedFood[1] + " ." + 
                " Please press Enter to order drinks.");
            Console.ReadLine();

            return OrderedFood;
        }

        private static string[] DrinkMenu()
        {
            Console.Clear();
            string[] Drinks = new string[] { "Coke", "juice", "Milk", "Lemonade", "Water","Vodka Soda", "Gin and Tonic", "White Wine", "Red Wine", "Sparklings" };
            string[] DrinkPrice = new string[] { "1.0", "1.5", "1.5", "2.0", "0.0", "2.5", "2.5", "3.0", "3.0", "3.0" };
            bool DrinkNotOrdered = true;
            int ChosenDrink = 0;

            while (DrinkNotOrdered)
            {
                Console.WriteLine("What drinks would you like?");
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(i+1 + " )" + Drinks[i]);
                }
                ChosenDrink = int.Parse(Console.ReadLine()) - 1;

                if (ChosenDrink > 5)
                {
                    Console.WriteLine("Please enter your birthday in mm/dd/yyyy format.");
                    string YourBirthday_Input = Console.ReadLine();
                    DateTime YourBirthday = DateTime.Parse(YourBirthday_Input);
                    DateTime TodayDate = DateTime.Today;
                    TimeSpan TotalDate = TodayDate.Subtract(YourBirthday);
                    int TotalDateCounted = TotalDate.Days;
                    int Age = TotalDateCounted / 365;

                    if (Age < 21)
                    {
                        Console.WriteLine("I am sorry, you are not allowed to order alcohol, Please order again.");
                        Console.ReadLine();
                    }
                    else
                    {
                        DrinkNotOrdered = false;
                    }
                }
                else
                    DrinkNotOrdered = false;
            }

            string[] OrderedDrink = new string[2];
            OrderedDrink[0] = Drinks[ChosenDrink];
            OrderedDrink[1] = DrinkPrice[ChosenDrink];
            Console.WriteLine("You ordered " + OrderedDrink[0] + " for $" + OrderedDrink[1] + " .");
            Console.ReadLine();
            return OrderedDrink;
        }
    }
}
