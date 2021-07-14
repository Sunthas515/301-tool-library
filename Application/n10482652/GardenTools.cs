using System;

namespace n10482652
{
	public class GardeningTools
	{
        private void drawMenu()
        {
            Console.WriteLine(@"
Welcome to the Tool Library
===========Gardening Tools===========
1. Line Trimmers
2. Lawn Mowers
3. Hand Tools
4. Wheelbarrows
5. Garden Power Tools
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
                    // Display all line trimmers
                    Console.Clear();
                    foreach (var tool in toolLibrarySystem.LineTrimmers.tools)
                    {
                        Console.WriteLine(tool.Name.ToString());
                    }
                    break;
                case 2:
                    // Display all lawn mowers
                    Console.Clear();
                    foreach (var tool in toolLibrarySystem.LawnMowers.tools)
                    {
                        Console.WriteLine(tool);
                    }
                    break;
                case 3:
                    // Display all hand tools
                    Console.Clear();
                    foreach (var tool in toolLibrarySystem.GHandTools.tools)
                    {
                        Console.WriteLine(tool);
                    }
                    break;
                case 4:
                    // Display all wheelbarrows
                    Console.Clear();
                    foreach (var tool in toolLibrarySystem.WheelBarrows.tools)
                    {
                        Console.WriteLine(tool);
                    }
                    break;
                case 5:
                    // Display all power tools
                    Console.Clear();
                    foreach (var tool in toolLibrarySystem.PowerTools.tools)
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
