using System;

namespace n10482652
{
    public class Staff
    {
        private void drawMenu()
        {
            Console.WriteLine(@"
Welcome to the Tool Library
===========Staff Menu===========
1. Add a new tool
2. Add new pieces of an existing tool
3. Remove some pieces of a tool
4. Register a new member
5. Remove a member
6. Find the contact number of a member
0. Exit
===============================");
        }

        private void Selection()
        {
            Console.Write("\nPlease make a selection 1-6, or 0 to return to main menu: ");
        }

        private string GetType(string tooltype)
        {
            while (tooltype != "")
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
            while (toolcat != "")
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

        internal void Menu(ToolLibrarySystem toolLibrarySystem)
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
                    // Add new tool
                    Tool tool = new Tool();
                    Console.Write("Please specify tool category: ");
                    string category = Console.ReadLine();

                    string toolcat = GetCategory(category);

                    Console.Write("Please specify a type of tool: ");
                    string type = Console.ReadLine();

                    string tooltype = GetType(type);

                    Console.Write("Enter tool name: ");
                    tool.Name = Console.ReadLine();
                    tool.Quantity = 1;
                    tool.AvailableQuantity = 1;
                    tool.NoBorrowings = 0;

                    toolLibrarySystem.add(tool, toolcat, tooltype);
                    Menu(toolLibrarySystem);
                    break;
                case 2:
                    // Add new tool piece
                    Tool tool_piece = new Tool();
                    Console.Write("Please specify tool category: ");
                    category = Console.ReadLine();

                    toolcat = GetCategory(category);

                    Console.Write("Please specify a type of tool: ");
                    type = Console.ReadLine();

                    tooltype = GetType(type);

                    Console.Write("Enter tool name: ");
                    tool_piece.Name = Console.ReadLine();

                    Console.Write("Enter amount of tools to add: ");
                    input = Console.ReadLine();

                    while (!int.TryParse(input, out num))
                    {
                        Console.Write("Enter amount of tools to add: ");
                        input = Console.ReadLine();
                    }

                    toolLibrarySystem.add(tool_piece, num, toolcat, tooltype);
                    Menu(toolLibrarySystem);
                    break;
                case 3:
                    //Remove tool piece
                    Tool tool_rem = new Tool();
                    Console.Write("Please specify tool category: ");
                    category = Console.ReadLine();

                    toolcat = GetCategory(category);

                    Console.Write("Please specify a type of tool: ");
                    type = Console.ReadLine();

                    tooltype = GetType(type);

                    Console.Write("Enter tool name: ");
                    tool_rem.Name = Console.ReadLine();

                    Console.Write("Would you like to batch remove " + tool_rem.Name + "? (y/n): ");
                    string batch = Console.ReadLine();

                    while (batch != "y" || batch != "n")
                    {
                        if (batch == "y")
                        {
                            Console.Write("Enter amount of tools to remove: ");
                            input = Console.ReadLine();

                            while (!int.TryParse(input, out num))
                            {
                                Console.Write("Enter amount of tools to remove: ");
                                input = Console.ReadLine();
                            }

                            toolLibrarySystem.delete(tool_rem, num, toolcat, tooltype);
                            Menu(toolLibrarySystem);
                        }
                        else if (batch == "n")
                        {
                            toolLibrarySystem.delete(tool_rem, toolcat, tooltype);
                            Menu(toolLibrarySystem);
                        }
                        else
                        {
                            Console.Write("Would you like to batch remove " + tool_rem.Name + "? (y/n): ");
                            batch = Console.ReadLine();
                        }
                    }
                    Menu(toolLibrarySystem);

                    break;
                case 4:
                    //Register user
                    Member member = new Member();
                    Console.Write("Enter First Name: ");
                    member.FirstName = Console.ReadLine();

                    Console.Write("Enter Last Name: ");
                    member.LastName = Console.ReadLine();

                    Console.Write("Enter Phone Number: ");
                    member.ContactNumber = Console.ReadLine();

                    Console.Write("Enter PIN: ");
                    member.PIN = Console.ReadLine();

                    toolLibrarySystem.add(member);
                    Menu(toolLibrarySystem);
                    break;
                case 5:
                    // Remove member
                    Member member_rem = new Member();
                    Console.Write("Enter First Name: ");
                    member_rem.FirstName = Console.ReadLine();

                    Console.Write("Enter Last Name: ");
                    member_rem.LastName = Console.ReadLine();

                    toolLibrarySystem.delete(member_rem);
                    Menu(toolLibrarySystem);
                    break;
                case 6:
                    //Member contact
                    Member member_con = new Member();
                    Console.Write("Enter First Name: ");
                    member_con.FirstName = Console.ReadLine();

                    Console.Write("Enter Last Name: ");
                    member_con.LastName = Console.ReadLine();

                    if (toolLibrarySystem.memberCollection.search(member_con))
                    {
                        var memberArray = toolLibrarySystem.memberCollection.toArray();
                        foreach (var user in memberArray)
                        {
                            if ((user.FirstName == member_con.FirstName) && (user.LastName == member_con.LastName))
                                Console.Clear();
                                Console.WriteLine(user.ContactNumber);
                        }
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("\n\nMember not found in system");
                    }
                    Menu(toolLibrarySystem);
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

        internal void Login(ToolLibrarySystem toolLibrarySystem)
        {
            string user = "";
            string password = "";

            Console.WriteLine(@"
Welcome to the Tool Library
===========Staff Login===========
");
            Console.Write("Please Enter User: ");
            user = Console.ReadLine();
            Console.Write("Please Enter Password: ");
            while (true)
            {
                var key = System.Console.ReadKey(true);
                if (key.Key == ConsoleKey.Enter)
                    break;
                password += key.KeyChar;
            }

            //Check user and password
            if (user == "staff" && password == "today123")
            {
                //Proceed to Staff Menu
                Console.Clear();
                Menu(toolLibrarySystem);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("\n\nUsername or Password Incorrect. Please try again");
                Login(toolLibrarySystem);
            }
        }
    }
}
