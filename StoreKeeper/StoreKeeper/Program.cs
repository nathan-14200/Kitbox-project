using System;
using System.Collections.Generic;

namespace StoreKeeper
{
    class MainClass
    {
        private static Master master = new Master();

        private static List<string> menuItems = new List<string>()
            {
                "Search orders",
                "See state of orders",
                "Print orders",
                "See state of stock",
                "Make orders to suppliers",
                "Exit"
            };

        public static void Main(string[] args)
        {
            bool running = true;

            List<string> menuText = new List<string>();
            for (int i = 0; i < menuItems.Count; i++)
            {
                menuText.Add(String.Format("[{0}]    {1}", i + 1, menuItems[i]));
            }

            while (running)
            {
                string choice = Menuprint(menuText);

                Console.Clear();

                switch (choice)
                {
                    case "1":
                        // show all the orders
                        ShowOrders();
                        break;
                    case "2":
                        // show actual state of order
                        ShowOrders();
                        ShowState();
                        break;
                    case "3":
                        // return txt file of orders 
                        //fct 3
                        break;
                    case "4":
                        // show actual state of stock
                        ShowStock();
                        break;
                    case "5":
                        // return txt file orders to supplier
                        // update stock
                        MakeCmd();
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

            Console.WriteLine(String.Format("{0} ----- {1} ----- {2}", Environment.NewLine, "Menu", Environment.NewLine));
            foreach (string item in menu)
            {
                Console.WriteLine(item);
            }

            Console.Write("Your Choice : ");
            string userChoice = Console.ReadLine();
            Console.Clear();

            return userChoice;
        }

        public static int AskOrder()
        {
            Console.Write("ID of the orders :");
            return int.Parse(Console.ReadLine());
        }

        public static void ShowOrders()
        {
            master.Init();
            master.ShowOrders();
        }

        public static void ShowState()
        {
            int i = AskOrder();

            master.Init();
            master.ShowStateOrder(i);
        }

        public static void ShowStock()
        {
            master.Init();
            master.ShowStock();
        }

        public static void MakeCmd()
        {
            master.Init();
            Dictionary<string, Tuple<string, int, double>> cmd = master.CommandStock();
            master.ShowCmd(cmd);
            master.PrintCmd(cmd);
        }
    }
}
