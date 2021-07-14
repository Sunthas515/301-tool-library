using System;

namespace n10482652
{
	public class FlooringTools
	{
        private void drawMenu()
        {
            Console.WriteLine(@"
Welcome to the Tool Library
===========Flooring Tools===========
1. Scrapers
2. Floor Lasers
3. Floor Leveling Tools
4. Floor Leveling Materials
5. Floor Hand Tools
6. Tiling Tools
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
                    // Display all Scrapers
                    Console.Clear();
                    foreach (var tool in toolLibrarySystem.Scrapers.tools)
                    {
                        Console.WriteLine(tool);
                    }
                    break;
                case 2:
                    // Display all floor lasers
                    Console.Clear();
                    foreach (var tool in toolLibrarySystem.FloorLasers.tools)
                    {
                        Console.WriteLine(tool);
                    }
                    break;
                case 3:
                    // Display all leveling tools
                    Console.Clear();
                    foreach (var tool in toolLibrarySystem.FloorLevellingTools.tools)
                    {
                        Console.WriteLine(tool);
                    }
                    break;
                case 4:
                    // Display all leveling materials
                    Console.Clear();
                    foreach (var tool in toolLibrarySystem.FloorLevellingMaterials.tools)
                    {
                        Console.WriteLine(tool);
                    }
                    break;
                case 5:
                    // Display all hand tools
                    Console.Clear();
                    foreach (var tool in toolLibrarySystem.FloorHandTools.tools)
                    {
                        Console.WriteLine(tool);
                    }
                    break;
                case 6:
                    // Display all tiling tools
                    Console.Clear();
                    foreach (var tool in toolLibrarySystem.TilingTools.tools)
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
