using System;

namespace n10482652{
	public class FencingTools
	{
        private void drawMenu()
        {
            Console.WriteLine(@"
Welcome to the Tool Library
===========Fencing Tools===========
1. Hand Tools
2. Electric Fencing
3. Steel Fencing
4. Power Tools
5. Fencing Accessories
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
                    // Display all hand tools
                    Console.Clear();
                    foreach (var tool in toolLibrarySystem.FHandTools.tools)
                    {
                        Console.WriteLine(tool);
                    }
                    break;
                case 2:
                    // Display all electric fencing
                    Console.Clear();
                    foreach (var tool in toolLibrarySystem.ElectricFencing.tools)
                    {
                        Console.WriteLine(tool);
                    }
                    break;
                case 3:
                    // Display all steel fencing
                    Console.Clear();
                    foreach (var tool in toolLibrarySystem.SteelFencing.tools)
                    {
                        Console.WriteLine(tool);
                    }
                    break;
                case 4:
                    // Display all power tools
                    Console.Clear();
                    foreach (var tool in toolLibrarySystem.PowerTools.tools)
                    {
                        Console.WriteLine(tool);
                    }
                    break;
                case 5:
                    // Display all fencing accessories
                    Console.Clear();
                    foreach (var tool in toolLibrarySystem.FencingAccessories.tools)
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
