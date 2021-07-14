using System;

namespace n10482652
{
    public class ElectricityTools
    {
        private void drawMenu()
        {
            Console.WriteLine(@"
Welcome to the Tool Library
===========Electricity Tools===========
1. Test Equipment
2. Safety Equipment
3. Basic Hand Tools
4. Circuit Protection
5. Cable Tools
0. Exit
===============================");
        }

        private void Selection()
        {
            Console.Write("\nPlease make a selection 1-5, or 0 to return to previous menu: ");
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
                    // Display all  Test Equipment
                    Console.Clear();
                    foreach (var tool in toolLibrarySystem.TestEquipment.tools)
                    {
                        Console.WriteLine(tool);
                    }
                    break;
                case 2:
                    // Display all Safety Equipment
                    Console.Clear();
                    foreach (var tool in toolLibrarySystem.SafetyEquipment.tools)
                    {
                        Console.WriteLine(tool);
                    }
                    break;
                case 3:
                    // Display all  Basic Hand Tools
                    Console.Clear();
                    foreach (var tool in toolLibrarySystem.BasicHandTools.tools)
                    {
                        Console.WriteLine(tool);
                    }
                    break;
                case 4:
                    // Display all Circuit Protection
                    Console.Clear();
                    foreach (var tool in toolLibrarySystem.CircuitProtection.tools)
                    {
                        Console.WriteLine(tool);
                    }
                    break;
                case 5:
                    // Display all Cable Tools
                    Console.Clear();
                    foreach (var tool in toolLibrarySystem.CableTools.tools)
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
