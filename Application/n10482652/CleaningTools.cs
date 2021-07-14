using System;

namespace n10482652 {
	public class CleainingTools
	{
        private void drawMenu()
        {
            Console.WriteLine(@"
Welcome to the Tool Library
===========Cleaining Tools===========
1. Draining
2. Car Cleaining
3. Vacuum
4. Pressure Cleaners
5. Pool Cleaning
6. Floor Cleaning
0. Exit
===============================");
        }

        private void Selection()
        {
            Console.Write("\nPlease make a selection 1-6, or 0 to return to previous menu: ");
        }

        internal void Menu(ToolLibrarySystem toolLibrarySystem, Member user)
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
                    // Display all Draining
                    Console.Clear();
                    foreach (var tool in toolLibrarySystem.Draining.tools)
                    {
                        Console.WriteLine(tool);
                    }
                    break;
                case 2:
                    // Display all Car Cleaning
                    Console.Clear();
                    foreach (var tool in toolLibrarySystem.CarCleaning.tools)
                    {
                        Console.WriteLine(tool);
                    }
                    break;
                case 3:
                    // Display all vacuum
                    Console.Clear();
                    foreach (var tool in toolLibrarySystem.Vacuum.tools)
                    {
                        Console.WriteLine(tool);
                    }
                    break;
                case 4:
                    // Display all pressure cleaning
                    Console.Clear();
                    foreach (var tool in toolLibrarySystem.PressureCleaners.tools)
                    {
                        Console.WriteLine(tool);
                    }
                    break;
                case 5:
                    // Display all pool cleaning
                    Console.Clear();
                    foreach (var tool in toolLibrarySystem.PoolCleaning.tools)
                    {
                        Console.WriteLine(tool);
                    }
                    break;
                case 6:
                    // Display all floor cleaning
                    Console.Clear();
                    foreach (var tool in toolLibrarySystem.FloorCleaning.tools)
                    {
                        Console.WriteLine(tool);
                    }
                    break;
                case 0:
                    Console.Clear();
                    ToolTypes toolTypes = new ToolTypes();
                    toolTypes.Menu(toolLibrarySystem, user);
                    break;
                default:
                    Selection();
                    input = Console.ReadLine();
                    break;
            }
        }
    }
}
