using System;
using System.Collections.Generic;

namespace StoreKeeper
{
    class MainClass
    {
        private static List<string> menuItems = new List<string>()
            {
                "Search orders",
                "See state of orders",
                "See state of stock",
                "Print orders",
                "Make orders to suppliers",
                "Exit"
            };

        public static void Main(string[] args)
        {
            bool running = true;

            List<string> menuText = new List<string>();
            for(int i = 0; i < menuItems.Count; i++)
            {
                menuText.Add(String.Format("[{0}]    {1}", i+1 , menuItems[i]));
            }

            while (running)
            {
                string choice = Menuprint(menuText);

                Console.Clear();

                switch (choice)
                {
                    case "1":
                        // show all the orders
                        //fct 1
                        break;
                    case "2":
                        // ask orders
                        // show actual state of order
                        //fct 2
                        break;
                    case "3":
                        // show actual state of stock
                        //fct 3
                        break;
                    case "4":
                        // ask orders
                        // return txt file of orders "Valerian"
                        //fct 4
                        break;
                    case "5":
                        // return txt file orders to supplier
                        // update stock
                        //fct 5
                        break;
                    case "6":
                        Console.WriteLine("[Exit]");
                        running = false;
                        break;
                }
            }

            Environment.Exit(0);
        }

        public static string Menuprint(List<string> menu)
        {
            /*
             *  Display the menu
             */
            foreach(string item in menu)
            {
                Console.WriteLine(item);
            }

            Console.Write("Your Choice : ");
            string userChoice = Console.ReadLine();
            Console.Clear();

            return userChoice;
        }
    }
}
