using System;

namespace n10482652
{
    public class Main
    {
        private void drawMenu()
        {
            Console.WriteLine(@"
Welcome to the Tool Library
===========Main Menu===========
1. Staff Login
2. Member Login
0. Exit
===============================");
        } 

        private void Selection()
        {
            Console.Write("\nPlease make a selection 1-2, or 0 to exit: ");
        }
        internal void Menu(ToolLibrarySystem toolLibrarySystem)
        {
            drawMenu();
            Selection();
            string input = Console.ReadLine();
            int num;

            while (!int.TryParse(input, out num))
            {
                Selection();
                input = Console.ReadLine();
            }

            switch (num)
            {
                case 1:
                    // Do Staff Login
                    Console.Clear();
                    Staff staff = new Staff();
                    staff.Login(toolLibrarySystem);
                    break;
                case 2:
                    // Do Member Login
                    Console.Clear();
                    Members member = new Members();
                    member.Login(toolLibrarySystem);
                    break;
                case 0:
                    System.Environment.Exit(1);
                    break;
            }
        }
    }
}
