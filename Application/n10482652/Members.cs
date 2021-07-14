using System;


namespace n10482652
{
    public class Members
    {
        private void drawMenu()
        {
            Console.WriteLine(@"
Welcome to the Tool Library
===========Member Menu===========
1. Display all the tools of a tool type
2. Borrow a tool
3. Return a tool
4. List all the tools that I am renting
5. Display top three (3) most frequently rented tools
0. Exit
===============================");
        }

        private void Selection()
        {
            Console.Write("\nPlease make a selection 1-5, or 0 to return to main menu: ");
        }


        private string GetType(string tooltype)
        {
            while (tooltype == "")
            {
                switch (tooltype)
                {
                    case "Line Trimmers":
                        tooltype = "Line";
                        return (tooltype);
                    case "Lawn Mowers":
                        tooltype = "Mower";
                        return (tooltype);
                    case "Garden Hand Tools":
                        tooltype = "Hand";
                        return (tooltype);
                    case "Wheelbarrows":
                        tooltype = "Wheelbarrow";
                        return (tooltype);
                    case "Garden Power Tools":
                        tooltype = "Power";
                        return (tooltype);
                    case "Scrapers":
                        tooltype = "Scraper";
                        return (tooltype);
                    case "Floor Lasers":
                        tooltype = "Laser";
                        return (tooltype);
                    case "Floor Levelling Tools":
                        tooltype = "Tools";
                        return (tooltype);
                    case "Floor Levelling Materials":
                        tooltype = "Materials";
                        return (tooltype);
                    case "Floor Hand Tools":
                        tooltype = "Hand";
                        return (tooltype);
                    case "Tiling Tools":
                        tooltype = "Tiling";
                        return (tooltype);
                    case "Fencing Hand Tools":
                        tooltype = "Hand";
                        return (tooltype);
                    case "Electric Fencing":
                        tooltype = "Electric";
                        return (tooltype);
                    case "Steel Fencing":
                        tooltype = "Steel";
                        return (tooltype);
                    case "Power Tools":
                        tooltype = "Power";
                        return (tooltype);
                    case "Fencing Accessories":
                        tooltype = "Accessories";
                        return (tooltype);
                    case "Distance Tools":
                        tooltype = "Distance";
                        return (tooltype);
                    case "Laser Measurer":
                        tooltype = "Laser";
                        return (tooltype);
                    case "Measuring Jugs":
                        tooltype = "Jug";
                        return (tooltype);
                    case "Temperature & Humidity Tools":
                        tooltype = "Temp";
                        return (tooltype);
                    case "Levelling Tools":
                        tooltype = "Level";
                        return (tooltype);
                    case "Markers":
                        tooltype = "Markers";
                        return (tooltype);
                    case "Draining":
                        tooltype = "Drain";
                        return (tooltype);
                    case "Car Cleaning":
                        tooltype = "Car";
                        return (tooltype);
                    case "Vacuum":
                        tooltype = "Vacuum";
                        return (tooltype);
                    case "Pressure Cleaners":
                        tooltype = "Pressure";
                        return (tooltype);
                    case "Pool Cleaning":
                        tooltype = "Pool";
                        return (tooltype);
                    case "Floor Cleaning":
                        tooltype = "Floor";
                        return (tooltype);
                    case "Sanding Tools":
                        tooltype = "Sanding";
                        return (tooltype);
                    case "Brushes":
                        tooltype = "Brushes";
                        return (tooltype);
                    case "Rollers":
                        tooltype = "Rollers";
                        return (tooltype);
                    case "Paint Removal Tools":
                        tooltype = "Removal";
                        return (tooltype);
                    case "Paint Scrapers":
                        tooltype = "Scraper";
                        return (tooltype);
                    case "Sprayers":
                        tooltype = "Spray";
                        return (tooltype);
                    case "Voltage Tester":
                        tooltype = "Voltage";
                        return (tooltype);
                    case "Oscilloscopes":
                        tooltype = "Oscill";
                        return (tooltype);
                    case "Thermal Imaging":
                        tooltype = "Therm";
                        return (tooltype);
                    case "Data Test Tool":
                        tooltype = "Test";
                        return (tooltype);
                    case "Insulation Testers":
                        tooltype = "Insul";
                        return (tooltype);
                    case "Test Equipment":
                        tooltype = "Test";
                        return (tooltype);
                    case "Safety Equipment":
                        tooltype = "Safety";
                        return (tooltype);
                    case "Basic Hand Tools":
                        tooltype = "Hand";
                        return (tooltype);
                    case "Circuit Protectrion":
                        tooltype = "Circuit";
                        return (tooltype);
                    case "Cable Tools":
                        tooltype = "Cable";
                        return (tooltype);
                    case "Jacks":
                        tooltype = "Jacks";
                        return (tooltype);
                    case "Air Compressors":
                        tooltype = "Air";
                        return (tooltype);
                    case "Battery Chargers":
                        tooltype = "Battery";
                        return (tooltype);
                    case "Socket Tools":
                        tooltype = "Socket";
                        return (tooltype);
                    case "Braking":
                        tooltype = "Brake";
                        return (tooltype);
                    case "Drivetrain":
                        tooltype = "Drive";
                        return (tooltype);
                    default:
                        Console.WriteLine("Please use one of the predetermined tool types");
                        Console.Write("Please specify a type of tool: ");
                        string type = Console.ReadLine();
                        return (tooltype);
                }
            }
            return (tooltype);
        }

        private string GetCategory(string toolcat)
        {
            while (toolcat == "")
            {
                switch (toolcat)
                {
                    case "Gardening Tools":
                        toolcat = "Garden";
                        return (toolcat);
                    case "Flooring Tools":
                        toolcat = "Floor";
                        return (toolcat);
                    case "Fencing Tools":
                        toolcat = "Fence";
                        return (toolcat);
                    case "Measuring Tools":
                        toolcat = "Measure";
                        return (toolcat);
                    case "Cleaning Tools":
                        toolcat = "Clean";
                        return (toolcat);
                    case "Painting Tools":
                        toolcat = "Paint";
                        return (toolcat);
                    case "Electronic Tools":
                        toolcat = "Electronic";
                        return (toolcat);
                    case "Electricity Tools":
                        toolcat = "Electric";
                        return (toolcat);
                    case "Automotive Tools":
                        toolcat = "Auto";
                        return (toolcat);
                    default:
                        Console.WriteLine("Please use one of the predetermined tool categories");
                        Console.WriteLine("Please specify tool category: ");
                        string category = Console.ReadLine();
                        return (toolcat);
                }
            }
            return (toolcat);
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
                    // Display all tools
                    Console.Clear();
                    ToolTypes toolTypes = new ToolTypes();
                    toolTypes.Menu(toolLibrarySystem, user);
                    break;
                case 2:
                    // Borrow tools
                    Tool tool = new Tool();
                    Console.Write("Please specify tool category: ");
                    string category = Console.ReadLine();

                    string toolcat = GetCategory(category);

                    Console.Write("Please specify a type of tool: ");
                    string type = Console.ReadLine();

                    string tooltype = GetType(type);

                    Console.Write("Enter tool name: ");
                    tool.Name = Console.ReadLine();

                    //Add tool to member's borrowed tools | AvailableQuantity-- | NoBorrowings++
                    Console.Clear();
                    toolLibrarySystem.borrowTool(user, tool, toolcat, tooltype);

                    Menu(toolLibrarySystem, user);
                    break;
                case 3:
                    //Return tools
                    Tool tool_ret = new Tool();
                    Console.Write("Please specify tool category: ");
                    category = Console.ReadLine();

                    toolcat = GetCategory(category);

                    Console.Write("Please specify a type of tool: ");
                    type = Console.ReadLine();

                    tooltype = GetType(type);

                    Console.Write("Enter tool name: ");
                    tool_ret.Name = Console.ReadLine();

                    //Remove tool from member's borrowed tools | AvailableQuantity++
                    Console.Clear();
                    toolLibrarySystem.returnTool(user, tool_ret, toolcat, tooltype);
                    Menu(toolLibrarySystem, user);
                    break;
                case 4:
                    // List rented tools
                    Console.Clear();
                    toolLibrarySystem.displayBorrowingTools(user);
                    Menu(toolLibrarySystem, user);
                    break;
                case 5:
                    // Display top 3 tools
                    Console.Clear();
                    toolLibrarySystem.displayTopTHree();
                    Menu(toolLibrarySystem, user);
                    break;
                case 0:
                    Console.Clear();
                    Main main = new Main();
                    main.Menu(toolLibrarySystem);
                    break;
                default:
                    Selection();
                    input = Console.ReadLine();
                    break;
            }
        }

        private void drawLogin()
        {
        Console.WriteLine(@"
Welcome to the Tool Library
===========Member Login===========
");
        }

        internal void Login(ToolLibrarySystem toolLibrarySystem)
        {
            drawLogin();
            Member login = new Member();

            Console.Write("Please Enter First Name: ");
            login.FirstName = Console.ReadLine();
            Console.Write("Please enter Last Name: ");
            login.LastName = Console.ReadLine();
            Console.Write("Please Enter PIN: ");
            while (true)
            {
                var key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.Enter)
                    break;
                login.PIN += key.KeyChar;
            }

            //Check user and password
            if (toolLibrarySystem.memberCollection.login(login))
            {
                //Proceed to Member Menu
                Console.Clear();
                Menu(toolLibrarySystem, login);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("\n\nUsername or PIN Incorrect. Please try again");
                Login(toolLibrarySystem);
            }
        }
    }
}
