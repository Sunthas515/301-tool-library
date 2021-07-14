using System;

namespace n10482652 {
	public class ElectronicTools
	{
        private void drawMenu()
        {
            Console.WriteLine(@"
Welcome to the Tool Library
===========Electronic Tools===========
1. Voltage Testers
2. Oscilloscopes
3. Thermal Imaging
4. Data Testing Tools
5. Insulation Testers
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
                    // Display all  Voltage Testers
                    Console.Clear();
                    foreach (var tool in toolLibrarySystem.VoltageTester.tools)
                    {
                        Console.WriteLine(tool);
                    }
                    break;
                case 2:
                    // Display all Oscilloscopes
                    Console.Clear();
                    foreach (var tool in toolLibrarySystem.Oscilloscopes.tools)
                    {
                        Console.WriteLine(tool);
                    }
                    break;
                case 3:
                    // Display all Thermal Imaging
                    Console.Clear();
                    foreach (var tool in toolLibrarySystem.ThermalImaging.tools)
                    {
                        Console.WriteLine(tool);
                    }
                    break;
                case 4:
                    // Display all Data Testing Tools
                    Console.Clear();
                    foreach (var tool in toolLibrarySystem.DataTestTool.tools)
                    {
                        Console.WriteLine(tool);
                    }
                    break;
                case 5:
                    // Display all Insulation Testers
                    Console.Clear();
                    foreach (var tool in toolLibrarySystem.InsulationTesters.tools)
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
