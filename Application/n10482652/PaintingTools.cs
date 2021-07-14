using System;

namespace n10482652 {
	public class PaintingTools
	{
        private void drawMenu()
        {
            Console.WriteLine(@"
Welcome to the Tool Library
===========Painting Tools===========
1. Sanding Tools
2. Brushes
3. Rollers
4. Paint Removal Tools
5. Paint Scrapers
6. Sprayers
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
                    // Display all sanding tools
                    Console.Clear();
                    foreach (var tool in toolLibrarySystem.SandingTools.tools)
                    {
                        Console.WriteLine(tool);
                    }
                    break;
                case 2:
                    // Display all brushes
                    Console.Clear();
                    foreach (var tool in toolLibrarySystem.Brushes.tools)
                    {
                        Console.WriteLine(tool);
                    }
                    break;
                case 3:
                    // Display all rollers
                    Console.Clear();
                    foreach (var tool in toolLibrarySystem.Rollers.tools)
                    {
                        Console.WriteLine(tool);
                    }
                    break;
                case 4:
                    // Display all paint removal tools
                    Console.Clear();
                    foreach (var tool in toolLibrarySystem.PaintRemovalTools.tools)
                    {
                        Console.WriteLine(tool);
                    }
                    break;
                case 5:
                    // Display all paint scrapers
                    Console.Clear();
                    foreach (var tool in toolLibrarySystem.PaintScrapers.tools)
                    {
                        Console.WriteLine(tool);
                    }
                    break;
                case 6:
                    // Display all sprayers
                    Console.Clear();
                    foreach (var tool in toolLibrarySystem.Sprayers.tools)
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
