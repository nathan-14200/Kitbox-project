﻿using System;
using System.Collections.Generic;

namespace StoreKeeper
{
    class MainClass
    {
        private static Master master = new Master();


        // Text for all the actions of the menu
        private static List<string> menuItems = new List<string>()
            {
                "Search orders",
                "See state of orders",
                "Print orders",
                "See state of stock",
                "Make orders to suppliers",
                "Remove piece",
                "Add piece",
                "Exit"
            };

        public static void Main(string[] args)
        {
            bool running = true;

            // create the text for the menu
            List<string> menuText = new List<string>();
            for (int i = 0; i < menuItems.Count; i++)
            {
                menuText.Add(String.Format("[{0}]    {1}", i + 1, menuItems[i]));
            }

            while (running)
            {
                string choice = Menuprint(menuText);

                Console.Clear();

                // execute the input action
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
                        ShowOrders();
                        PrintState();
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
                        // remove piece
                        ShowStock();
                        RemovePiece();
                        break;
                    case "7":
                        // add piece
                        ShowStock();
                        AddPiece();
                        break;
                    case "8":
                        // exit
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

        public static void PrintState()
        {
            int i = AskOrder();

            master.Init();
            master.PrintStateOrder(i);
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

        public static Tuple<string, int> AskPiece()
        {
            Console.WriteLine("Code of the piece : ");
            string code = Console.ReadLine();
            Console.WriteLine("Quantity : ");
            int qt = int.Parse(Console.ReadLine());
            return new Tuple<string, int>(code, qt);
        }

        public static void RemovePiece()
        {
            Tuple<string, int> piece = AskPiece();
            master.RemovePiece(piece);
        }

        public static void AddPiece()
        {
            Tuple<string, int> piece = AskPiece();
            master.AddPiece(piece);
        }
    }
}