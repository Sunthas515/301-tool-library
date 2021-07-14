using System;

namespace n10482652 {
	public class MeasuringTools
	{
        private void drawMenu()
        {
            Console.WriteLine(@"
Welcome to the Tool Library
===========Measuring Tools===========
1. Distance Tools
2. Laser Measure
3. Measuring Jugs
4. Temperature & Humidity Tools
5. Levelling Tools
6. Markers
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
                    // Display all distance tools
                    Console.Clear();
                    foreach (var tool in toolLibrarySystem.DistanceTools.tools)
                    {
                        Console.WriteLine(tool);
                    }
                    break;
                case 2:
                    // Display all laser measures
                    Console.Clear();
                    foreach (var tool in toolLibrarySystem.LaserMeasurer.tools)
                    {
                        Console.WriteLine(tool);
                    }
                    break;
                case 3:
                    // Display all measuring jugs
                    Console.Clear();
                    foreach (var tool in toolLibrarySystem.MeasuringJugs.tools)
                    {
                        Console.WriteLine(tool);
                    }
                    break;
                case 4:
                    // Display all temperature and humidity tools
                    Console.Clear();
                    foreach (var tool in toolLibrarySystem.Temp_HumidityTools.tools)
                    {
                        Console.WriteLine(tool);
                    }
                    break;
                case 5:
                    // Display all levelling tools
                    Console.Clear();
                    foreach (var tool in toolLibrarySystem.LevellingTools.tools)
                    {
                        Console.WriteLine(tool);
                    }
                    break;
                case 6:
                    // Display all markers
                    Console.Clear();
                    foreach (var tool in toolLibrarySystem.Markers.tools)
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
