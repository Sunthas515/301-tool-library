using System;

namespace n10482652
{
    public class AutomotiveTools
    {
        private void drawMenu()
        {
            Console.WriteLine(@"
Welcome to the Tool Library
===========Automotve Tools===========
1. Jacks
2. Air Compressors
3. Battery Chargers
4. Socket Tools
5. Braking
6. Drivetrain
0. Exit
===============================");
        }

        private void Selection()
        {
            Console.Write("\nPlease make a selection 1-6, or 0 to return to previous menu: ");
        }

        internal void Menu(ToolLibrarySystem toolLibrarySystem, Member user)
        {
            ToolTypes toolTypes = new ToolTypes();
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
                    // Display all Jacks
                    Console.Clear();
                    foreach (var tool in toolLibrarySystem.Jacks.tools)
                    {
                        Console.WriteLine(tool);
                    }
                    break;
                case 2:
                    // Display all air compressors
                    Console.Clear();
                    foreach (var tool in toolLibrarySystem.AirCompressors.tools)
                    {
                        Console.WriteLine(tool);
                    }
                    break;
                case 3:
                    // Display all battery chargers
                    Console.Clear();
                    foreach (var tool in toolLibrarySystem.BatteryChargers.tools)
                    {
                        Console.WriteLine(tool);
                    }
                    break;
                case 4:
                    // Display all socket tools
                    Console.Clear();
                    foreach (var tool in toolLibrarySystem.SocketTools.tools)
                    {
                        Console.WriteLine(tool);
                    }
                    break;
                case 5:
                    // Display all braking
                    Console.Clear();
                    foreach (var tool in toolLibrarySystem.Braking.tools)
                    {
                        Console.WriteLine(tool);
                    }
                    break;
                case 6:
                    // Display all drivetrain
                    Console.Clear();
                    foreach (var tool in toolLibrarySystem.Drivetrain.tools)
                    {
                        Console.WriteLine(tool);
                    }
                    break;
                case 0:
                    Console.Clear();
                    toolTypes.Menu(toolLibrarySystem, user);
                    break;
                default:
                    Selection();
                    input = Console.ReadLine();
                    break;
            }
            toolTypes.Menu(toolLibrarySystem, user);
        }
    }
}
