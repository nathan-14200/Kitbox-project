using System;
using System.Collections.Generic;

namespace StoreKeeper
{
    class MainClass
    {
        private static List<string> menuItems = new List<string>()
            {
                "a",
                "b",
                "Exit"
            };

        public static void Main(string[] args)
        {
            List<string> menuText = new List<string>();
            for(int i = 0; i < menuItems.Count; i++)
            {
                menuText.Add(String.Format("[{0}]    {1}", i, menuItems[i]));
            }

            string choice = Menuprint(menuText);
        }

        public static string Menuprint(List<string> menu)
        {
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
