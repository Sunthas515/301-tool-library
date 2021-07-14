using System;

namespace n10482652 {
    public class ToolTypes
    {
        private void drawMenu()
        {
            Console.WriteLine(@"
Welcome to the Tool Library
===========Tool Types===========
1. Gardening Tools
2. Flooring Tools
3. Fencing Tools
4. Measuring Tools
5. Cleaining Tools
6. Painting Tools
7. Electronic Tools
8. Electricity Tools
9. Automotive Tools
0. Exit
===============================");
        }

        private void Selection()
        {
            Console.Write("\nPlease make a selection 1-9, or 0 to return to previous menu: ");
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
                    GardeningTools gardeningTools = new GardeningTools();
                    Console.Clear();
                    gardeningTools.Menu(toolLibrarySystem, user);
                    break;
                case 2:
                    FlooringTools flooringTools = new FlooringTools();
                    Console.Clear();
                    flooringTools.Menu(toolLibrarySystem, user);
                    break;
                case 3:
                    FencingTools fencingTools = new FencingTools();
                    Console.Clear();
                    fencingTools.Menu(toolLibrarySystem, user);
                    break;
                case 4:
                    MeasuringTools measuringTools = new MeasuringTools();
                    Console.Clear();
                    measuringTools.Menu(toolLibrarySystem, user);
                    break;
                case 5:
                    CleainingTools cleainingTools = new CleainingTools();
                    Console.Clear();
                    cleainingTools.Menu(toolLibrarySystem, user);
                    break;
                case 6:
                    PaintingTools paintingTools = new PaintingTools();
                    Console.Clear();
                    paintingTools.Menu(toolLibrarySystem, user);
                    break;
                case 7:
                    ElectronicTools electronicTools = new ElectronicTools();
                    Console.Clear();
                    electronicTools.Menu(toolLibrarySystem, user);
                    break;
                case 8:
                    ElectricityTools electricityTools = new ElectricityTools();
                    Console.Clear();
                    electricityTools.Menu(toolLibrarySystem, user);
                    break;
                case 9:
                    AutomotiveTools automotiveTools = new AutomotiveTools();
                    Console.Clear();
                    automotiveTools.Menu(toolLibrarySystem, user);
                    break;
                case 0:
                    Console.Clear();
                    Members member = new Members();
                    member.Menu(toolLibrarySystem, user);
                    break;
                default:
                    Selection();
                    input = Console.ReadLine();
                    break;
            }
        }
    }
}
