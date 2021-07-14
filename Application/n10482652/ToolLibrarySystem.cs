using System;
using System.Collections.Generic;

namespace n10482652
{
    class ToolLibrarySystem : iToolLibrarySystem
    {
        //Tool collections for garden tools
        public ToolCollection LineTrimmers = new ToolCollection();
        public ToolCollection LawnMowers = new ToolCollection();
        public ToolCollection GHandTools = new ToolCollection();
        public ToolCollection WheelBarrows = new ToolCollection();
        public ToolCollection GardenPowerTools = new ToolCollection();

        //Tool collections for Flooring Tools
        public ToolCollection Scrapers = new ToolCollection();
        public ToolCollection FloorLasers = new ToolCollection();
        public ToolCollection FloorLevellingTools = new ToolCollection();
        public ToolCollection FloorLevellingMaterials = new ToolCollection();
        public ToolCollection FloorHandTools = new ToolCollection();
        public ToolCollection TilingTools = new ToolCollection();

        //Tool collections for Fencing Tools
        public ToolCollection FHandTools = new ToolCollection();
        public ToolCollection ElectricFencing = new ToolCollection();
        public ToolCollection SteelFencing = new ToolCollection();
        public ToolCollection PowerTools = new ToolCollection();
        public ToolCollection FencingAccessories = new ToolCollection();

        //Tool collections for Measuring Tools
        public ToolCollection DistanceTools = new ToolCollection();
        public ToolCollection LaserMeasurer = new ToolCollection();
        public ToolCollection MeasuringJugs = new ToolCollection();
        public ToolCollection Temp_HumidityTools = new ToolCollection();
        public ToolCollection LevellingTools = new ToolCollection();
        public ToolCollection Markers = new ToolCollection();

        //Tool collections for Cleaning Tools
        public ToolCollection Draining = new ToolCollection();
        public ToolCollection CarCleaning = new ToolCollection();
        public ToolCollection Vacuum = new ToolCollection();
        public ToolCollection PressureCleaners = new ToolCollection();
        public ToolCollection PoolCleaning = new ToolCollection();
        public ToolCollection FloorCleaning = new ToolCollection();

        //Tool collections for Painting Tools
        public ToolCollection SandingTools = new ToolCollection();
        public ToolCollection Brushes = new ToolCollection();
        public ToolCollection Rollers = new ToolCollection();
        public ToolCollection PaintRemovalTools = new ToolCollection();
        public ToolCollection PaintScrapers = new ToolCollection();
        public ToolCollection Sprayers = new ToolCollection();

        //Tool collections for Electronic Tools
        public ToolCollection VoltageTester = new ToolCollection();
        public ToolCollection Oscilloscopes = new ToolCollection();
        public ToolCollection ThermalImaging = new ToolCollection();
        public ToolCollection DataTestTool = new ToolCollection();
        public ToolCollection InsulationTesters = new ToolCollection();

        //Tool collections for Electricity Tools
        public ToolCollection TestEquipment = new ToolCollection();
        public ToolCollection SafetyEquipment = new ToolCollection();
        public ToolCollection BasicHandTools = new ToolCollection();
        public ToolCollection CircuitProtection = new ToolCollection();
        public ToolCollection CableTools = new ToolCollection();

        //Tool collections for Automotive Tools
        public ToolCollection Jacks = new ToolCollection();
        public ToolCollection AirCompressors = new ToolCollection();
        public ToolCollection BatteryChargers = new ToolCollection();
        public ToolCollection SocketTools = new ToolCollection();
        public ToolCollection Braking = new ToolCollection();
        public ToolCollection Drivetrain = new ToolCollection();

        public MemberCollection memberCollection = new MemberCollection();

        //Added additional category and type variables in order to be able to separate tools into tool category and tool type
        public void add(iTool aTool, string category, string type)
        {
            Console.Clear();
            Console.WriteLine("Adding " + aTool.Name + " to system");

            switch (category)
            {
                case "Garden":
                    switch (type)
                    {
                        case "Line":
                            bool exists = LineTrimmers.search(aTool);

                            while (exists)
                            {
                                Console.WriteLine("Tool already in system. Please use 'Add new pieces of an existing tool'");
                                break;
                            }

                            while (!exists)
                            {
                                LineTrimmers.add(aTool);
                                break;
                            }

                            foreach (var tool in LineTrimmers.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Mower":
                            exists = LawnMowers.search(aTool);

                            while (exists)
                            {
                                Console.WriteLine("Tool already in system. Please use 'Add new pieces of an existing tool'");
                                break;
                            }

                            while (!exists)
                            {
                                LawnMowers.add(aTool);
                                break;
                            }

                            foreach (var tool in LawnMowers.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Hand":
                            exists = GHandTools.search(aTool);

                            while (exists)
                            {
                                Console.WriteLine("Tool already in system. Please use 'Add new pieces of an existing tool'");
                                break;
                            }

                            while (!exists)
                            {
                                GHandTools.add(aTool);
                                break;
                            }

                            foreach (var tool in GHandTools.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "wheelbarrow":
                            exists = WheelBarrows.search(aTool);

                            while (exists)
                            {
                                Console.WriteLine("Tool already in system. Please use 'Add new pieces of an existing tool'");
                                break;
                            }

                            while (!exists)
                            {
                                WheelBarrows.add(aTool);
                                break;
                            }

                            foreach (var tool in WheelBarrows.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Power":
                            exists = GardenPowerTools.search(aTool);

                            while (exists)
                            {
                                Console.WriteLine("Tool already in system. Please use 'Add new pieces of an existing tool'");
                                break;
                            }

                            while (!exists)
                            {
                                GardenPowerTools.add(aTool);
                                break;
                            }

                            foreach (var tool in GardenPowerTools.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                    }
                    break;
                case "Floor":
                    switch (type)
                    {
                        case "Scraper":
                            bool exists = Scrapers.search(aTool);

                            while (exists)
                            {
                                Console.WriteLine("Tool already in system. Please use 'Add new pieces of an existing tool'");
                                break;
                            }

                            while (!exists)
                            {
                                Scrapers.add(aTool);
                                break;
                            }

                            foreach (var tool in Scrapers.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Laser":
                            exists = FloorLasers.search(aTool);

                            while (exists)
                            {
                                Console.WriteLine("Tool already in system. Please use 'Add new pieces of an existing tool'");
                                break;
                            }

                            while (!exists)
                            {
                                FloorLasers.add(aTool);
                                break;
                            }

                            foreach (var tool in FloorLasers.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Tools":
                            exists = FloorLevellingTools.search(aTool);

                            while (exists)
                            {
                                Console.WriteLine("Tool already in system. Please use 'Add new pieces of an existing tool'");
                                break;
                            }

                            while (!exists)
                            {
                                FloorLevellingTools.add(aTool);
                                break;
                            }

                            foreach (var tool in FloorLevellingTools.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Materials":
                            exists = FloorLevellingMaterials.search(aTool);

                            while (exists)
                            {
                                Console.WriteLine("Tool already in system. Please use 'Add new pieces of an existing tool'");
                                break;
                            }

                            while (!exists)
                            {
                                FloorLevellingMaterials.add(aTool);
                                break;
                            }

                            foreach (var tool in FloorLevellingMaterials.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Hand":
                            exists = FloorHandTools.search(aTool);

                            while (exists)
                            {
                                Console.WriteLine("Tool already in system. Please use 'Add new pieces of an existing tool'");
                                break;
                            }

                            while (!exists)
                            {
                                FloorHandTools.add(aTool);
                                break;
                            }

                            foreach (var tool in FloorHandTools.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Tiling":
                            exists = TilingTools.search(aTool);

                            while (exists)
                            {
                                Console.WriteLine("Tool already in system. Please use 'Add new pieces of an existing tool'");
                                break;
                            }

                            while (!exists)
                            {
                                TilingTools.add(aTool);
                                break;
                            }

                            foreach (var tool in TilingTools.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                    }
                    break;
                case "Fence":
                    switch (type)
                    {
                        case "Hand":
                            bool exists = FHandTools.search(aTool);

                            while (exists)
                            {
                                Console.WriteLine("Tool already in system. Please use 'Add new pieces of an existing tool'");
                                break;
                            }

                            while (!exists)
                            {
                                FHandTools.add(aTool);
                                break;
                            }

                            foreach (var tool in FHandTools.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Electric":
                            exists = ElectricFencing.search(aTool);

                            while (exists)
                            {
                                Console.WriteLine("Tool already in system. Please use 'Add new pieces of an existing tool'");
                                break;
                            }

                            while (!exists)
                            {
                                ElectricFencing.add(aTool);
                                break;
                            }

                            foreach (var tool in ElectricFencing.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Steel":
                            exists = SteelFencing.search(aTool);

                            while (exists)
                            {
                                Console.WriteLine("Tool already in system. Please use 'Add new pieces of an existing tool'");
                                break;
                            }

                            while (!exists)
                            {
                                SteelFencing.add(aTool);
                                break;
                            }

                            foreach (var tool in SteelFencing.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Power":
                            exists = PowerTools.search(aTool);
                            while (exists)
                            {
                                Console.WriteLine("Tool already in system. Please use 'Add new pieces of an existing tool'");
                                break;
                            }

                            while (!exists)
                            {
                                PowerTools.add(aTool);
                                break;
                            }

                            foreach (var tool in PowerTools.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Accessories":
                            exists = FencingAccessories.search(aTool);

                            while (exists)
                            {
                                Console.WriteLine("Tool already in system. Please use 'Add new pieces of an existing tool'");
                                break;
                            }

                            while (!exists)
                            {
                                FencingAccessories.add(aTool);
                                break;
                            }

                            foreach (var tool in FencingAccessories.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                    }
                    break;
                case "Measure":
                    switch (type)
                    {
                        case "Distance":
                            bool exists = DistanceTools.search(aTool);

                            while (exists)
                            {
                                Console.WriteLine("Tool already in system. Please use 'Add new pieces of an existing tool'");
                                break;
                            }

                            while (!exists)
                            {
                                DistanceTools.add(aTool);
                                break;
                            }

                            foreach (var tool in DistanceTools.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Laser":
                            exists = LaserMeasurer.search(aTool);

                            while (exists)
                            {
                                Console.WriteLine("Tool already in system. Please use 'Add new pieces of an existing tool'");
                                break;
                            }

                            while (!exists)
                            {
                                LaserMeasurer.add(aTool);
                                break;
                            }

                            foreach (var tool in LaserMeasurer.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Jug":
                            exists = MeasuringJugs.search(aTool);

                            while (exists)
                            {
                                Console.WriteLine("Tool already in system. Please use 'Add new pieces of an existing tool'");
                                break;
                            }

                            while (!exists)
                            {
                                MeasuringJugs.add(aTool);
                                break;
                            }

                            foreach (var tool in MeasuringJugs.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Temp":
                            exists = Temp_HumidityTools.search(aTool);

                            while (exists)
                            {
                                Console.WriteLine("Tool already in system. Please use 'Add new pieces of an existing tool'");
                                break;
                            }

                            while (!exists)
                            {
                                Temp_HumidityTools.add(aTool);
                                break;
                            }

                            foreach (var tool in Temp_HumidityTools.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Level":
                            exists = LevellingTools.search(aTool);

                            while (exists)
                            {
                                Console.WriteLine("Tool already in system. Please use 'Add new pieces of an existing tool'");
                                break;
                            }

                            while (!exists)
                            {
                                LevellingTools.add(aTool);
                                break;
                            }

                            foreach (var tool in LevellingTools.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Markers":
                            exists = Markers.search(aTool);

                            while (exists)
                            {
                                Console.WriteLine("Tool already in system. Please use 'Add new pieces of an existing tool'");
                                break;
                            }

                            while (!exists)
                            {
                                Markers.add(aTool);
                                break;
                            }

                            foreach (var tool in Markers.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                    }
                    break;
                case "Clean":
                    switch (type)
                    {
                        case "Drain":
                            bool exists = Draining.search(aTool);

                            while (exists)
                            {
                                Console.WriteLine("Tool already in system. Please use 'Add new pieces of an existing tool'");
                                break;
                            }

                            while (!exists)
                            {
                                Draining.add(aTool);
                                break;
                            }

                            foreach (var tool in Draining.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Car":
                            exists = CarCleaning.search(aTool);

                            while (exists)
                            {
                                Console.WriteLine("Tool already in system. Please use 'Add new pieces of an existing tool'");
                                break;
                            }

                            while (!exists)
                            {
                                CarCleaning.add(aTool);
                                break;
                            }

                            foreach (var tool in CarCleaning.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Vacuum":
                            exists = Vacuum.search(aTool);

                            while (exists)
                            {
                                Console.WriteLine("Tool already in system. Please use 'Add new pieces of an existing tool'");
                                break;
                            }

                            while (!exists)
                            {
                                Vacuum.add(aTool);
                                break;
                            }

                            foreach (var tool in Vacuum.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Pressure":
                            exists = PressureCleaners.search(aTool);

                            while (exists)
                            {
                                Console.WriteLine("Tool already in system. Please use 'Add new pieces of an existing tool'");
                                break;
                            }

                            while (!exists)
                            {
                                PressureCleaners.add(aTool);
                                break;
                            }

                            foreach (var tool in PressureCleaners.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Pool":
                            exists = PoolCleaning.search(aTool);

                            while (exists)
                            {
                                Console.WriteLine("Tool already in system. Please use 'Add new pieces of an existing tool'");
                                break;
                            }

                            while (!exists)
                            {
                                PoolCleaning.add(aTool);
                                break;
                            }

                            foreach (var tool in PoolCleaning.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Floor":
                            exists = FloorCleaning.search(aTool);

                            while (exists)
                            {
                                Console.WriteLine("Tool already in system. Please use 'Add new pieces of an existing tool'");
                                break;
                            }

                            while (!exists)
                            {
                                FloorCleaning.add(aTool);
                                break;
                            }

                            foreach (var tool in FloorCleaning.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                    }
                    break;
                case "Paint":
                    switch (type)
                    {
                        case "Sanding":
                            bool exists = SandingTools.search(aTool);

                            while (exists)
                            {
                                Console.WriteLine("Tool already in system. Please use 'Add new pieces of an existing tool'");
                                break;
                            }

                            while (!exists)
                            {
                                SandingTools.add(aTool);
                                break;
                            }

                            foreach (var tool in SandingTools.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Brushes":
                            exists = Brushes.search(aTool);

                            while (exists)
                            {
                                Console.WriteLine("Tool already in system. Please use 'Add new pieces of an existing tool'");
                                break;
                            }

                            while (!exists)
                            {
                                Brushes.add(aTool);
                                break;
                            }

                            foreach (var tool in Brushes.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Rollers":
                            exists = Rollers.search(aTool);

                            while (exists)
                            {
                                Console.WriteLine("Tool already in system. Please use 'Add new pieces of an existing tool'");
                                break;
                            }

                            while (!exists)
                            {
                                Rollers.add(aTool);
                                break;
                            }

                            foreach (var tool in Rollers.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Removal":
                            exists = PaintRemovalTools.search(aTool);

                            while (exists)
                            {
                                Console.WriteLine("Tool already in system. Please use 'Add new pieces of an existing tool'");
                                break;
                            }

                            while (!exists)
                            {
                                PaintRemovalTools.add(aTool);
                                break;
                            }

                            foreach (var tool in PaintRemovalTools.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Scraper":
                            exists = PaintScrapers.search(aTool);

                            while (exists)
                            {
                                Console.WriteLine("Tool already in system. Please use 'Add new pieces of an existing tool'");
                                break;
                            }

                            while (!exists)
                            {
                                PaintScrapers.add(aTool);
                                break;
                            }

                            foreach (var tool in PaintScrapers.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Spray":
                            exists = Sprayers.search(aTool);

                            while (exists)
                            {
                                Console.WriteLine("Tool already in system. Please use 'Add new pieces of an existing tool'");
                                break;
                            }

                            while (!exists)
                            {
                                Sprayers.add(aTool);
                                break;
                            }

                            foreach (var tool in Sprayers.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                    }
                    break;
                case "Electronic":
                    switch (type)
                    {
                        case "Voltage":
                            bool exists = VoltageTester.search(aTool);

                            while (exists)
                            {
                                Console.WriteLine("Tool already in system. Please use 'Add new pieces of an existing tool'");
                                break;
                            }

                            while (!exists)
                            {
                                VoltageTester.add(aTool);
                                break;
                            }

                            foreach (var tool in VoltageTester.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Oscill":
                            exists = Oscilloscopes.search(aTool);

                            while (exists)
                            {
                                Console.WriteLine("Tool already in system. Please use 'Add new pieces of an existing tool'");
                                break;
                            }

                            while (!exists)
                            {
                                Oscilloscopes.add(aTool);
                                break;
                            }

                            foreach (var tool in Oscilloscopes.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Therm":
                            exists = ThermalImaging.search(aTool);

                            while (exists)
                            {
                                Console.WriteLine("Tool already in system. Please use 'Add new pieces of an existing tool'");
                                break;
                            }

                            while (!exists)
                            {
                                ThermalImaging.add(aTool);
                                break;
                            }

                            foreach (var tool in ThermalImaging.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Test":
                            exists = DataTestTool.search(aTool);

                            while (exists)
                            {
                                Console.WriteLine("Tool already in system. Please use 'Add new pieces of an existing tool'");
                                break;
                            }

                            while (!exists)
                            {
                                DataTestTool.add(aTool);
                                break;
                            }

                            foreach (var tool in DataTestTool.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Insul":
                            exists = InsulationTesters.search(aTool);

                            while (exists)
                            {
                                Console.WriteLine("Tool already in system. Please use 'Add new pieces of an existing tool'");
                                break;
                            }

                            while (!exists)
                            {
                                InsulationTesters.add(aTool);
                                break;
                            }

                            foreach (var tool in InsulationTesters.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                    }
                    break;
                case "Electric":
                    switch (type)
                    {
                        case "Test":
                            bool exists = TestEquipment.search(aTool);

                            while (exists)
                            {
                                Console.WriteLine("Tool already in system. Please use 'Add new pieces of an existing tool'");
                                break;
                            }

                            while (!exists)
                            {
                                TestEquipment.add(aTool);
                                break;
                            }

                            foreach (var tool in TestEquipment.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Safety":
                            exists = SafetyEquipment.search(aTool);

                            while (exists)
                            {
                                Console.WriteLine("Tool already in system. Please use 'Add new pieces of an existing tool'");
                                break;
                            }

                            while (!exists)
                            {
                                SafetyEquipment.add(aTool);
                                break;
                            }

                            foreach (var tool in SafetyEquipment.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Hand":
                            exists = BasicHandTools.search(aTool);

                            while (exists)
                            {
                                Console.WriteLine("Tool already in system. Please use 'Add new pieces of an existing tool'");
                                break;
                            }

                            while (!exists)
                            {
                                BasicHandTools.add(aTool);
                                break;
                            }

                            foreach (var tool in BasicHandTools.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Circuit":
                            exists = CircuitProtection.search(aTool);

                            while (exists)
                            {
                                Console.WriteLine("Tool already in system. Please use 'Add new pieces of an existing tool'");
                                break;
                            }

                            while (!exists)
                            {
                                CircuitProtection.add(aTool);
                                break;
                            }

                            foreach (var tool in CircuitProtection.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Cable":
                            exists = CableTools.search(aTool);

                            while (exists)
                            {
                                Console.WriteLine("Tool already in system. Please use 'Add new pieces of an existing tool'");
                                break;
                            }

                            while (!exists)
                            {
                                CableTools.add(aTool);
                                break;
                            }

                            foreach (var tool in CableTools.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                    }
                    break;
                case "Auto":
                    switch (type)
                    {
                        case "Jacks":
                            bool exists = Jacks.search(aTool);

                            while (exists)
                            {
                                Console.WriteLine("Tool already in system. Please use 'Add new pieces of an existing tool'");
                                break;
                            }

                            while (!exists)
                            {
                                Jacks.add(aTool);
                                break;
                            }

                            foreach (var tool in Jacks.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Air":
                            exists = AirCompressors.search(aTool);

                            while (exists)
                            {
                                Console.WriteLine("Tool already in system. Please use 'Add new pieces of an existing tool'");
                                break;
                            }

                            while (!exists)
                            {
                                AirCompressors.add(aTool);
                                break;
                            }

                            foreach (var tool in AirCompressors.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Battery":
                            exists = BatteryChargers.search(aTool);

                            while (exists)
                            {
                                Console.WriteLine("Tool already in system. Please use 'Add new pieces of an existing tool'");
                                break;
                            }

                            while (!exists)
                            {
                                BatteryChargers.add(aTool);
                                break;
                            }

                            foreach (var tool in BatteryChargers.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Socket":
                            exists = SocketTools.search(aTool);

                            while (exists)
                            {
                                Console.WriteLine("Tool already in system. Please use 'Add new pieces of an existing tool'");
                                break;
                            }

                            while (!exists)
                            {
                                SocketTools.add(aTool);
                                break;
                            }

                            foreach (var tool in SocketTools.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Brake":
                            exists = Braking.search(aTool);

                            while (exists)
                            {
                                Console.WriteLine("Tool already in system. Please use 'Add new pieces of an existing tool'");
                                break;
                            }

                            while (!exists)
                            {
                                Braking.add(aTool);
                                break;
                            }

                            foreach (var tool in Braking.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Drive":
                            exists = Drivetrain.search(aTool);

                            while (exists)
                            {
                                Console.WriteLine("Tool already in system. Please use 'Add new pieces of an existing tool'");
                                break;
                            }

                            while (!exists)
                            {
                                Drivetrain.add(aTool);
                                break;
                            }

                            foreach (var tool in Drivetrain.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                    }
                    break;
            }
        }

        public void add(iTool aTool, int quantity, string category, string type)
        {
            Console.Clear();
            Console.WriteLine("Adding " + quantity + " additional items to " + aTool.Name);

            switch (category)
            {
                case "Garden":
                    switch (type)
                    {
                        case "Line":
                            bool exists = LineTrimmers.search(aTool);

                            while (exists)
                            {
                                for (int i = 0; i < quantity; i++)
                                {
                                    foreach (var tool in LineTrimmers.tools)
                                    {
                                        if (tool.Name == aTool.Name)
                                        {
                                            tool.Quantity++;
                                            tool.AvailableQuantity++;
                                        }
                                    }
                                }
                                break;
                            }

                            while (!exists)
                            {
                                Console.WriteLine("Tool not in system. Please use 'Add a new tool'");
                                break;
                            }

                            foreach (var tool in LineTrimmers.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Mower":
                            exists = LawnMowers.search(aTool);

                            while (exists)
                            {
                                for (int i = 0; i < quantity; i++)
                                {
                                    foreach (var tool in LawnMowers.tools)
                                    {
                                        if (tool.Name == aTool.Name)
                                        {
                                            tool.Quantity++;
                                            tool.AvailableQuantity++;
                                        }
                                    }
                                }
                                break;
                            }

                            while (!exists)
                            {
                                Console.WriteLine("Tool not in system. Please use 'Add a new tool'");
                                break;
                            }

                            foreach (var tool in LawnMowers.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Hand":
                            exists = GHandTools.search(aTool);

                            while (exists)
                            {
                                for (int i = 0; i < quantity; i++)
                                {
                                    foreach (var tool in GHandTools.tools)
                                    {
                                        if (tool.Name == aTool.Name)
                                        {
                                            tool.Quantity++;
                                            tool.AvailableQuantity++;
                                        }
                                    }
                                }
                                break;
                            }

                            while (!exists)
                            {
                                Console.WriteLine("Tool not in system. Please use 'Add a new tool'");
                                break;
                            }

                            foreach (var tool in GHandTools.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "wheelbarrow":
                            exists = WheelBarrows.search(aTool);

                            while (exists)
                            {
                                for (int i = 0; i < quantity; i++)
                                {
                                    foreach (var tool in WheelBarrows.tools)
                                    {
                                        if (tool.Name == aTool.Name)
                                        {
                                            tool.Quantity++;
                                            tool.AvailableQuantity++;
                                        }
                                    }
                                }
                                break;
                            }

                            while (!exists)
                            {
                                Console.WriteLine("Tool not in system. Please use 'Add a new tool'");
                                break;
                            }

                            foreach (var tool in WheelBarrows.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Power":
                            exists = GardenPowerTools.search(aTool);

                            while (exists)
                            {
                                for (int i = 0; i < quantity; i++)
                                {
                                    foreach (var tool in GardenPowerTools.tools)
                                    {
                                        if (tool.Name == aTool.Name)
                                        {
                                            tool.Quantity++;
                                            tool.AvailableQuantity++;
                                        }
                                    }
                                }
                                break;
                            }

                            while (!exists)
                            {
                                Console.WriteLine("Tool not in system. Please use 'Add a new tool'");
                                break;
                            }

                            foreach (var tool in GardenPowerTools.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                    }
                    break;
                case "Floor":
                    switch (type)
                    {
                        case "Scraper":
                            bool exists = Scrapers.search(aTool);

                            while (exists)
                            {
                                for (int i = 0; i < quantity; i++)
                                {
                                    foreach (var tool in Scrapers.tools)
                                    {
                                        if (tool.Name == aTool.Name)
                                        {
                                            tool.Quantity++;
                                            tool.AvailableQuantity++;
                                        }
                                    }
                                }
                                break;
                            }

                            while (!exists)
                            {
                                Console.WriteLine("Tool not in system. Please use 'Add a new tool'");
                                break;
                            }

                            foreach (var tool in Scrapers.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Laser":
                            exists = FloorLasers.search(aTool);

                            while (exists)
                            {
                                for (int i = 0; i < quantity; i++)
                                {
                                    foreach (var tool in FloorLasers.tools)
                                    {
                                        if (tool.Name == aTool.Name)
                                        {
                                            tool.Quantity++;
                                            tool.AvailableQuantity++;
                                        }
                                    }
                                }
                                break;
                            }

                            while (!exists)
                            {
                                Console.WriteLine("Tool not in system. Please use 'Add a new tool'");
                                break;
                            }

                            foreach (var tool in FloorLasers.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Tools":
                            exists = FloorLevellingTools.search(aTool);

                            while (exists)
                            {
                                for (int i = 0; i < quantity; i++)
                                {
                                    foreach (var tool in FloorLevellingTools.tools)
                                    {
                                        if (tool.Name == aTool.Name)
                                        {
                                            tool.Quantity++;
                                            tool.AvailableQuantity++;
                                        }
                                    }
                                }
                                break;
                            }

                            while (!exists)
                            {
                                Console.WriteLine("Tool not in system. Please use 'Add a new tool'");
                                break;
                            }

                            foreach (var tool in FloorLevellingTools.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Materials":
                            exists = FloorLevellingMaterials.search(aTool);

                            while (exists)
                            {
                                for (int i = 0; i < quantity; i++)
                                {
                                    foreach (var tool in FloorLevellingMaterials.tools)
                                    {
                                        if (tool.Name == aTool.Name)
                                        {
                                            tool.Quantity++;
                                            tool.AvailableQuantity++;
                                        }
                                    }
                                }
                                break;
                            }

                            while (!exists)
                            {
                                Console.WriteLine("Tool not in system. Please use 'Add a new tool'");
                                break;
                            }

                            foreach (var tool in FloorLevellingMaterials.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Hand":
                            exists = FloorHandTools.search(aTool);

                            while (exists)
                            {
                                for (int i = 0; i < quantity; i++)
                                {
                                    foreach (var tool in FloorHandTools.tools)
                                    {
                                        if (tool.Name == aTool.Name)
                                        {
                                            tool.Quantity++;
                                            tool.AvailableQuantity++;
                                        }
                                    }
                                }
                                break;
                            }

                            while (!exists)
                            {
                                Console.WriteLine("Tool not in system. Please use 'Add a new tool'");
                                break;
                            }

                            foreach (var tool in FloorHandTools.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Tiling":
                            exists = TilingTools.search(aTool);

                            while (exists)
                            {
                                for (int i = 0; i < quantity; i++)
                                {
                                    foreach (var tool in TilingTools.tools)
                                    {
                                        if (tool.Name == aTool.Name)
                                        {
                                            tool.Quantity++;
                                            tool.AvailableQuantity++;
                                        }
                                    }
                                }
                                break;
                            }

                            while (!exists)
                            {
                                Console.WriteLine("Tool not in system. Please use 'Add a new tool'");
                                break;
                            }

                            foreach (var tool in TilingTools.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                    }
                    break;
                case "Fence":
                    switch (type)
                    {
                        case "Hand":
                            bool exists = FHandTools.search(aTool);

                            while (exists)
                            {
                                for (int i = 0; i < quantity; i++)
                                {
                                    foreach (var tool in FHandTools.tools)
                                    {
                                        if (tool.Name == aTool.Name)
                                        {
                                            tool.Quantity++;
                                            tool.AvailableQuantity++;
                                        }
                                    }
                                }
                                break;
                            }

                            while (!exists)
                            {
                                Console.WriteLine("Tool not in system. Please use 'Add a new tool'");
                                break;
                            }

                            foreach (var tool in FHandTools.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Electric":
                            exists = ElectricFencing.search(aTool);

                            while (exists)
                            {
                                for (int i = 0; i < quantity; i++)
                                {
                                    foreach (var tool in ElectricFencing.tools)
                                    {
                                        if (tool.Name == aTool.Name)
                                        {
                                            tool.Quantity++;
                                            tool.AvailableQuantity++;
                                        }
                                    }
                                }
                                break;
                            }

                            while (!exists)
                            {
                                Console.WriteLine("Tool not in system. Please use 'Add a new tool'");
                                break;
                            }

                            foreach (var tool in ElectricFencing.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Steel":
                            exists = SteelFencing.search(aTool);

                            while (exists)
                            {
                                for (int i = 0; i < quantity; i++)
                                {
                                    foreach (var tool in SteelFencing.tools)
                                    {
                                        if (tool.Name == aTool.Name)
                                        {
                                            tool.Quantity++;
                                            tool.AvailableQuantity++;
                                        }
                                    }
                                }
                                break;
                            }

                            while (!exists)
                            {
                                Console.WriteLine("Tool not in system. Please use 'Add a new tool'");
                                break;
                            }

                            foreach (var tool in SteelFencing.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Power":
                            exists = PowerTools.search(aTool);

                            while (exists)
                            {
                                for (int i = 0; i < quantity; i++)
                                {
                                    foreach (var tool in PowerTools.tools)
                                    {
                                        if (tool.Name == aTool.Name)
                                        {
                                            tool.Quantity++;
                                            tool.AvailableQuantity++;
                                        }
                                    }
                                }
                                break;
                            }

                            while (!exists)
                            {
                                Console.WriteLine("Tool not in system. Please use 'Add a new tool'");
                                break;
                            }

                            foreach (var tool in PowerTools.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Accessories":
                            exists = FencingAccessories.search(aTool);

                            while (exists)
                            {
                                for (int i = 0; i < quantity; i++)
                                {
                                    foreach (var tool in FencingAccessories.tools)
                                    {
                                        if (tool.Name == aTool.Name)
                                        {
                                            tool.Quantity++;
                                            tool.AvailableQuantity++;
                                        }
                                    }
                                }
                                break;
                            }

                            while (!exists)
                            {
                                Console.WriteLine("Tool not in system. Please use 'Add a new tool'");
                                break;
                            }

                            foreach (var tool in FencingAccessories.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                    }
                    break;
                case "Measure":
                    switch (type)
                    {
                        case "Distance":
                            bool exists = DistanceTools.search(aTool);

                            while (exists)
                            {
                                for (int i = 0; i < quantity; i++)
                                {
                                    foreach (var tool in DistanceTools.tools)
                                    {
                                        if (tool.Name == aTool.Name)
                                        {
                                            tool.Quantity++;
                                            tool.AvailableQuantity++;
                                        }
                                    }
                                }
                                break;
                            }

                            while (!exists)
                            {
                                Console.WriteLine("Tool not in system. Please use 'Add a new tool'");
                                break;
                            }

                            foreach (var tool in DistanceTools.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Laser":
                            exists = LaserMeasurer.search(aTool);

                            while (exists)
                            {
                                for (int i = 0; i < quantity; i++)
                                {
                                    foreach (var tool in LaserMeasurer.tools)
                                    {
                                        if (tool.Name == aTool.Name)
                                        {
                                            tool.Quantity++;
                                            tool.AvailableQuantity++;
                                        }
                                    }
                                }
                                break;
                            }

                            while (!exists)
                            {
                                Console.WriteLine("Tool not in system. Please use 'Add a new tool'");
                                break;
                            }

                            foreach (var tool in LaserMeasurer.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Jug":
                            exists = MeasuringJugs.search(aTool);

                            while (exists)
                            {
                                for (int i = 0; i < quantity; i++)
                                {
                                    foreach (var tool in MeasuringJugs.tools)
                                    {
                                        if (tool.Name == aTool.Name)
                                        {
                                            tool.Quantity++;
                                            tool.AvailableQuantity++;
                                        }
                                    }
                                }
                                break;
                            }

                            while (!exists)
                            {
                                Console.WriteLine("Tool not in system. Please use 'Add a new tool'");
                                break;
                            }

                            foreach (var tool in MeasuringJugs.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Temp":
                            exists = Temp_HumidityTools.search(aTool);

                            while (exists)
                            {
                                for (int i = 0; i < quantity; i++)
                                {
                                    foreach (var tool in Temp_HumidityTools.tools)
                                    {
                                        if (tool.Name == aTool.Name)
                                        {
                                            tool.Quantity++;
                                            tool.AvailableQuantity++;
                                        }
                                    }
                                }
                                break;
                            }

                            while (!exists)
                            {
                                Console.WriteLine("Tool not in system. Please use 'Add a new tool'");
                                break;
                            }

                            foreach (var tool in Temp_HumidityTools.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Level":
                            exists = LevellingTools.search(aTool);

                            while (exists)
                            {
                                for (int i = 0; i < quantity; i++)
                                {
                                    foreach (var tool in LevellingTools.tools)
                                    {
                                        if (tool.Name == aTool.Name)
                                        {
                                            tool.Quantity++;
                                            tool.AvailableQuantity++;
                                        }
                                    }
                                }
                                break;
                            }

                            while (!exists)
                            {
                                Console.WriteLine("Tool not in system. Please use 'Add a new tool'");
                                break;
                            }

                            foreach (var tool in LevellingTools.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Markers":
                            exists = Markers.search(aTool);

                            while (exists)
                            {
                                for (int i = 0; i < quantity; i++)
                                {
                                    foreach (var tool in Markers.tools)
                                    {
                                        if (tool.Name == aTool.Name)
                                        {
                                            tool.Quantity++;
                                            tool.AvailableQuantity++;
                                        }
                                    }
                                }
                                break;
                            }

                            while (!exists)
                            {
                                Console.WriteLine("Tool not in system. Please use 'Add a new tool'");
                                break;
                            }

                            foreach (var tool in Markers.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                    }
                    break;
                case "Clean":
                    switch (type)
                    {
                        case "Drain":
                            bool exists = Draining.search(aTool);

                            while (exists)
                            {
                                for (int i = 0; i < quantity; i++)
                                {
                                    foreach (var tool in Draining.tools)
                                    {
                                        if (tool.Name == aTool.Name)
                                        {
                                            tool.Quantity++;
                                            tool.AvailableQuantity++;
                                        }
                                    }
                                }
                                break;
                            }

                            while (!exists)
                            {
                                Console.WriteLine("Tool not in system. Please use 'Add a new tool'");
                                break;
                            }

                            foreach (var tool in Draining.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Car":
                            exists = CarCleaning.search(aTool);

                            while (exists)
                            {
                                for (int i = 0; i < quantity; i++)
                                {
                                    foreach (var tool in CarCleaning.tools)
                                    {
                                        if (tool.Name == aTool.Name)
                                        {
                                            tool.Quantity++;
                                            tool.AvailableQuantity++;
                                        }
                                    }
                                }
                                break;
                            }

                            while (!exists)
                            {
                                Console.WriteLine("Tool not in system. Please use 'Add a new tool'");
                                break;
                            }

                            foreach (var tool in CarCleaning.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Vacuum":
                            exists = Vacuum.search(aTool);

                            while (exists)
                            {
                                for (int i = 0; i < quantity; i++)
                                {
                                    foreach (var tool in Vacuum.tools)
                                    {
                                        if (tool.Name == aTool.Name)
                                        {
                                            tool.Quantity++;
                                            tool.AvailableQuantity++;
                                        }
                                    }
                                }
                                break;
                            }

                            while (!exists)
                            {
                                Console.WriteLine("Tool not in system. Please use 'Add a new tool'");
                                break;
                            }

                            foreach (var tool in Vacuum.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Pressure":
                            exists = PressureCleaners.search(aTool);

                            while (exists)
                            {
                                for (int i = 0; i < quantity; i++)
                                {
                                    foreach (var tool in PressureCleaners.tools)
                                    {
                                        if (tool.Name == aTool.Name)
                                        {
                                            tool.Quantity++;
                                            tool.AvailableQuantity++;
                                        }
                                    }
                                }
                                break;
                            }

                            while (!exists)
                            {
                                Console.WriteLine("Tool not in system. Please use 'Add a new tool'");
                                break;
                            }

                            foreach (var tool in PressureCleaners.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Pool":
                            exists = PoolCleaning.search(aTool);

                            while (exists)
                            {
                                for (int i = 0; i < quantity; i++)
                                {
                                    foreach (var tool in PoolCleaning.tools)
                                    {
                                        if (tool.Name == aTool.Name)
                                        {
                                            tool.Quantity++;
                                            tool.AvailableQuantity++;
                                        }
                                    }
                                }
                                break;
                            }

                            while (!exists)
                            {
                                Console.WriteLine("Tool not in system. Please use 'Add a new tool'");
                                break;
                            }

                            foreach (var tool in PoolCleaning.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Floor":
                            exists = FloorCleaning.search(aTool);

                            while (exists)
                            {
                                for (int i = 0; i < quantity; i++)
                                {
                                    foreach (var tool in FloorCleaning.tools)
                                    {
                                        if (tool.Name == aTool.Name)
                                        {
                                            tool.Quantity++;
                                            tool.AvailableQuantity++;
                                        }
                                    }
                                }
                                break;
                            }

                            while (!exists)
                            {
                                Console.WriteLine("Tool not in system. Please use 'Add a new tool'");
                                break;
                            }

                            foreach (var tool in FloorCleaning.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                    }
                    break;
                case "Paint":
                    switch (type)
                    {
                        case "Sanding":
                            bool exists = SandingTools.search(aTool);

                            while (exists)
                            {
                                for (int i = 0; i < quantity; i++)
                                {
                                    foreach (var tool in SandingTools.tools)
                                    {
                                        if (tool.Name == aTool.Name)
                                        {
                                            tool.Quantity++;
                                            tool.AvailableQuantity++;
                                        }
                                    }
                                }
                                break;
                            }

                            while (!exists)
                            {
                                Console.WriteLine("Tool not in system. Please use 'Add a new tool'");
                                break;
                            }

                            foreach (var tool in SandingTools.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Brushes":
                            exists = Brushes.search(aTool);

                            while (exists)
                            {
                                for (int i = 0; i < quantity; i++)
                                {
                                    foreach (var tool in Brushes.tools)
                                    {
                                        if (tool.Name == aTool.Name)
                                        {
                                            tool.Quantity++;
                                            tool.AvailableQuantity++;
                                        }
                                    }
                                }
                                break;
                            }

                            while (!exists)
                            {
                                Console.WriteLine("Tool not in system. Please use 'Add a new tool'");
                                break;
                            }

                            foreach (var tool in Brushes.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Rollers":
                            exists = Rollers.search(aTool);

                            while (exists)
                            {
                                for (int i = 0; i < quantity; i++)
                                {
                                    foreach (var tool in Rollers.tools)
                                    {
                                        if (tool.Name == aTool.Name)
                                        {
                                            tool.Quantity++;
                                            tool.AvailableQuantity++;
                                        }
                                    }
                                }
                                break;
                            }

                            while (!exists)
                            {
                                Console.WriteLine("Tool not in system. Please use 'Add a new tool'");
                                break;
                            }

                            foreach (var tool in Rollers.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Removal":
                            exists = PaintRemovalTools.search(aTool);

                            while (exists)
                            {
                                for (int i = 0; i < quantity; i++)
                                {
                                    foreach (var tool in PaintRemovalTools.tools)
                                    {
                                        if (tool.Name == aTool.Name)
                                        {
                                            tool.Quantity++;
                                            tool.AvailableQuantity++;
                                        }
                                    }
                                }
                                break;
                            }

                            while (!exists)
                            {
                                Console.WriteLine("Tool not in system. Please use 'Add a new tool'");
                                break;
                            }

                            foreach (var tool in PaintRemovalTools.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Scraper":
                            exists = PaintScrapers.search(aTool);

                            while (exists)
                            {
                                for (int i = 0; i < quantity; i++)
                                {
                                    foreach (var tool in PaintScrapers.tools)
                                    {
                                        if (tool.Name == aTool.Name)
                                        {
                                            tool.Quantity++;
                                            tool.AvailableQuantity++;
                                        }
                                    }
                                }
                                break;
                            }

                            while (!exists)
                            {
                                Console.WriteLine("Tool not in system. Please use 'Add a new tool'");
                                break;
                            }

                            foreach (var tool in PaintScrapers.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Spray":
                            exists = Sprayers.search(aTool);

                            while (exists)
                            {
                                for (int i = 0; i < quantity; i++)
                                {
                                    foreach (var tool in Sprayers.tools)
                                    {
                                        if (tool.Name == aTool.Name)
                                        {
                                            tool.Quantity++;
                                            tool.AvailableQuantity++;
                                        }
                                    }
                                }
                                break;
                            }

                            while (!exists)
                            {
                                Console.WriteLine("Tool not in system. Please use 'Add a new tool'");
                                break;
                            }

                            foreach (var tool in Sprayers.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                    }
                    break;
                case "Electronic":
                    switch (type)
                    {
                        case "Voltage":
                            bool exists = VoltageTester.search(aTool);

                            while (exists)
                            {
                                for (int i = 0; i < quantity; i++)
                                {
                                    foreach (var tool in VoltageTester.tools)
                                    {
                                        if (tool.Name == aTool.Name)
                                        {
                                            tool.Quantity++;
                                            tool.AvailableQuantity++;
                                        }
                                    }
                                }
                                break;
                            }

                            while (!exists)
                            {
                                Console.WriteLine("Tool not in system. Please use 'Add a new tool'");
                                break;
                            }

                            foreach (var tool in VoltageTester.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Oscill":
                            exists = Oscilloscopes.search(aTool);

                            while (exists)
                            {
                                for (int i = 0; i < quantity; i++)
                                {
                                    foreach (var tool in Oscilloscopes.tools)
                                    {
                                        if (tool.Name == aTool.Name)
                                        {
                                            tool.Quantity++;
                                            tool.AvailableQuantity++;
                                        }
                                    }
                                }
                                break;
                            }

                            while (!exists)
                            {
                                Console.WriteLine("Tool not in system. Please use 'Add a new tool'");
                                break;
                            }

                            foreach (var tool in Oscilloscopes.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Therm":
                            exists = ThermalImaging.search(aTool);

                            while (exists)
                            {
                                for (int i = 0; i < quantity; i++)
                                {
                                    foreach (var tool in ThermalImaging.tools)
                                    {
                                        if (tool.Name == aTool.Name)
                                        {
                                            tool.Quantity++;
                                            tool.AvailableQuantity++;
                                        }
                                    }
                                }
                                break;
                            }

                            while (!exists)
                            {
                                Console.WriteLine("Tool not in system. Please use 'Add a new tool'");
                                break;
                            }

                            foreach (var tool in ThermalImaging.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Test":
                            exists = DataTestTool.search(aTool);

                            while (exists)
                            {
                                for (int i = 0; i < quantity; i++)
                                {
                                    foreach (var tool in DataTestTool.tools)
                                    {
                                        if (tool.Name == aTool.Name)
                                        {
                                            tool.Quantity++;
                                            tool.AvailableQuantity++;
                                        }
                                    }
                                }
                                break;
                            }

                            while (!exists)
                            {
                                Console.WriteLine("Tool not in system. Please use 'Add a new tool'");
                                break;
                            }

                            foreach (var tool in DataTestTool.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Insul":
                            exists = InsulationTesters.search(aTool);

                            while (exists)
                            {
                                for (int i = 0; i < quantity; i++)
                                {
                                    foreach (var tool in InsulationTesters.tools)
                                    {
                                        if (tool.Name == aTool.Name)
                                        {
                                            tool.Quantity++;
                                            tool.AvailableQuantity++;
                                        }
                                    }
                                }
                                break;
                            }

                            while (!exists)
                            {
                                Console.WriteLine("Tool not in system. Please use 'Add a new tool'");
                                break;
                            }

                            foreach (var tool in InsulationTesters.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                    }
                    break;
                case "Electric":
                    switch (type)
                    {
                        case "Test":
                            bool exists = TestEquipment.search(aTool);

                            while (exists)
                            {
                                for (int i = 0; i < quantity; i++)
                                {
                                    foreach (var tool in TestEquipment.tools)
                                    {
                                        if (tool.Name == aTool.Name)
                                        {
                                            tool.Quantity++;
                                            tool.AvailableQuantity++;
                                        }
                                    }
                                }
                                break;
                            }

                            while (!exists)
                            {
                                Console.WriteLine("Tool not in system. Please use 'Add a new tool'");
                                break;
                            }

                            foreach (var tool in TestEquipment.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Safety":
                            exists = SafetyEquipment.search(aTool);

                            while (exists)
                            {
                                for (int i = 0; i < quantity; i++)
                                {
                                    foreach (var tool in SafetyEquipment.tools)
                                    {
                                        if (tool.Name == aTool.Name)
                                        {
                                            tool.Quantity++;
                                            tool.AvailableQuantity++;
                                        }
                                    }
                                }
                                break;
                            }

                            while (!exists)
                            {
                                Console.WriteLine("Tool not in system. Please use 'Add a new tool'");
                                break;
                            }

                            foreach (var tool in SafetyEquipment.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Hand":
                            exists = BasicHandTools.search(aTool);

                            while (exists)
                            {
                                for (int i = 0; i < quantity; i++)
                                {
                                    foreach (var tool in BasicHandTools.tools)
                                    {
                                        if (tool.Name == aTool.Name)
                                        {
                                            tool.Quantity++;
                                            tool.AvailableQuantity++;
                                        }
                                    }
                                }
                                break;
                            }

                            while (!exists)
                            {
                                Console.WriteLine("Tool not in system. Please use 'Add a new tool'");
                                break;
                            }

                            foreach (var tool in BasicHandTools.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Circuit":
                            exists = CircuitProtection.search(aTool);

                            while (exists)
                            {
                                for (int i = 0; i < quantity; i++)
                                {
                                    foreach (var tool in CircuitProtection.tools)
                                    {
                                        if (tool.Name == aTool.Name)
                                        {
                                            tool.Quantity++;
                                            tool.AvailableQuantity++;
                                        }
                                    }
                                }
                                break;
                            }

                            while (!exists)
                            {
                                Console.WriteLine("Tool not in system. Please use 'Add a new tool'");
                                break;
                            }

                            foreach (var tool in CircuitProtection.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Cable":
                            exists = CableTools.search(aTool);

                            while (exists)
                            {
                                for (int i = 0; i < quantity; i++)
                                {
                                    foreach (var tool in CableTools.tools)
                                    {
                                        if (tool.Name == aTool.Name)
                                        {
                                            tool.Quantity++;
                                            tool.AvailableQuantity++;
                                        }
                                    }
                                }
                                break;
                            }

                            while (!exists)
                            {
                                Console.WriteLine("Tool not in system. Please use 'Add a new tool'");
                                break;
                            }

                            foreach (var tool in CableTools.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                    }
                    break;
                case "Auto":
                    switch (type)
                    {
                        case "Jacks":
                            bool exists = Jacks.search(aTool);

                            while (exists)
                            {
                                for (int i = 0; i < quantity; i++)
                                {
                                    foreach (var tool in Jacks.tools)
                                    {
                                        if (tool.Name == aTool.Name)
                                        {
                                            tool.Quantity++;
                                            tool.AvailableQuantity++;
                                        }
                                    }
                                }
                                break;
                            }

                            while (!exists)
                            {
                                Console.WriteLine("Tool not in system. Please use 'Add a new tool'");
                                break;
                            }

                            foreach (var tool in Jacks.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Air":
                            exists = AirCompressors.search(aTool);

                            while (exists)
                            {
                                for (int i = 0; i < quantity; i++)
                                {
                                    foreach (var tool in AirCompressors.tools)
                                    {
                                        if (tool.Name == aTool.Name)
                                        {
                                            tool.Quantity++;
                                            tool.AvailableQuantity++;
                                        }
                                    }
                                }
                                break;
                            }

                            while (!exists)
                            {
                                Console.WriteLine("Tool not in system. Please use 'Add a new tool'");
                                break;
                            }

                            foreach (var tool in AirCompressors.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Battery":
                            exists = BatteryChargers.search(aTool);

                            while (exists)
                            {
                                for (int i = 0; i < quantity; i++)
                                {
                                    foreach (var tool in BatteryChargers.tools)
                                    {
                                        if (tool.Name == aTool.Name)
                                        {
                                            tool.Quantity++;
                                            tool.AvailableQuantity++;
                                        }
                                    }
                                }
                                break;
                            }

                            while (!exists)
                            {
                                Console.WriteLine("Tool not in system. Please use 'Add a new tool'");
                                break;
                            }

                            foreach (var tool in BatteryChargers.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Socket":
                            exists = SocketTools.search(aTool);

                            while (exists)
                            {
                                for (int i = 0; i < quantity; i++)
                                {
                                    foreach (var tool in SocketTools.tools)
                                    {
                                        if (tool.Name == aTool.Name)
                                        {
                                            tool.Quantity++;
                                            tool.AvailableQuantity++;
                                        }
                                    }
                                }
                                break;
                            }

                            while (!exists)
                            {
                                Console.WriteLine("Tool not in system. Please use 'Add a new tool'");
                                break;
                            }

                            foreach (var tool in SocketTools.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Brake":
                            exists = Braking.search(aTool);

                            while (exists)
                            {
                                for (int i = 0; i < quantity; i++)
                                {
                                    foreach (var tool in Braking.tools)
                                    {
                                        if (tool.Name == aTool.Name)
                                        {
                                            tool.Quantity++;
                                            tool.AvailableQuantity++;
                                        }
                                    }
                                }
                                break;
                            }

                            while (!exists)
                            {
                                Console.WriteLine("Tool not in system. Please use 'Add a new tool'");
                                break;
                            }

                            foreach (var tool in Braking.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Drive":
                            exists = Drivetrain.search(aTool);

                            while (exists)
                            {
                                for (int i = 0; i < quantity; i++)
                                {
                                    foreach (var tool in Drivetrain.tools)
                                    {
                                        if (tool.Name == aTool.Name)
                                        {
                                            tool.Quantity++;
                                            tool.AvailableQuantity++;
                                        }
                                    }
                                }
                                break;
                            }

                            while (!exists)
                            {
                                Console.WriteLine("Tool not in system. Please use 'Add a new tool'");
                                break;
                            }

                            foreach (var tool in Drivetrain.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                    }
                    break;
            }
        }

        public void add(iMember aMember)
        {
            Console.Clear();
            Console.WriteLine("Adding " + aMember.FirstName + " " + aMember.LastName + " to system");

            bool exists = memberCollection.search(aMember);

            while (exists)
            {
                Console.WriteLine("Member already in system. Please use a different name");
                break;
            }

            while (!exists)
            {
                memberCollection.add(aMember);
                break;
            }

            var members = memberCollection.toArray();

            foreach (var member in members)
            {
                Console.WriteLine(member.FirstName + " " + member.LastName);
            }
        }

        public void delete(iTool aTool, string category, string type)
        {
            Console.Clear();
            Console.WriteLine("Deleting " + aTool.Name + " from system");

            switch (category)
            {
                case "Garden":
                    switch (type)
                    {
                        case "Line":
                            bool exists = LineTrimmers.search(aTool);

                            while (exists)
                            {

                                LineTrimmers.delete(aTool);
                                break;
                            }

                            while (!exists)
                            {
                                Console.Clear();
                                Console.WriteLine("Tool not found in system. Please try a different tool");
                                break;
                            }

                            foreach (var tool in LineTrimmers.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Mower":
                            exists = LawnMowers.search(aTool);

                            while (exists)
                            {

                                LawnMowers.delete(aTool);
                                break;
                            }

                            while (!exists)
                            {
                                Console.Clear();
                                Console.WriteLine("Tool not found in system. Please try a different tool");
                                break;
                            }

                            foreach (var tool in LawnMowers.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Hand":
                            exists = GHandTools.search(aTool);

                            while (exists)
                            {

                                GHandTools.delete(aTool);
                                break;
                            }

                            while (!exists)
                            {
                                Console.Clear();
                                Console.WriteLine("Tool not found in system. Please try a different tool");
                                break;
                            }

                            foreach (var tool in GHandTools.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "wheelbarrow":
                            exists = WheelBarrows.search(aTool);

                            while (exists)
                            {

                                WheelBarrows.delete(aTool);
                                break;
                            }

                            while (!exists)
                            {
                                Console.Clear();
                                Console.WriteLine("Tool not found in system. Please try a different tool");
                                break;
                            }

                            foreach (var tool in WheelBarrows.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Power":
                            exists = GardenPowerTools.search(aTool);

                            while (exists)
                            {

                                GardenPowerTools.delete(aTool);
                                break;
                            }

                            while (!exists)
                            {
                                Console.Clear();
                                Console.WriteLine("Tool not found in system. Please try a different tool");
                                break;
                            }

                            foreach (var tool in GardenPowerTools.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                    }
                    break;
                case "Floor":
                    switch (type)
                    {
                        case "Scraper":
                            bool exists = Scrapers.search(aTool);

                            while (exists)
                            {

                                Scrapers.delete(aTool);
                                break;
                            }

                            while (!exists)
                            {
                                Console.Clear();
                                Console.WriteLine("Tool not found in system. Please try a different tool");
                                break;
                            }

                            foreach (var tool in Scrapers.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Laser":
                            exists = FloorLasers.search(aTool);

                            while (exists)
                            {

                                FloorLasers.delete(aTool);
                                break;
                            }

                            while (!exists)
                            {
                                Console.Clear();
                                Console.WriteLine("Tool not found in system. Please try a different tool");
                                break;
                            }

                            foreach (var tool in FloorLasers.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Tools":
                            exists = FloorLevellingTools.search(aTool);

                            while (exists)
                            {

                                FloorLevellingTools.delete(aTool);
                                break;
                            }

                            while (!exists)
                            {
                                Console.Clear();
                                Console.WriteLine("Tool not found in system. Please try a different tool");
                                break;
                            }

                            foreach (var tool in FloorLevellingTools.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Materials":
                            exists = FloorLevellingMaterials.search(aTool);

                            while (exists)
                            {

                                FloorLevellingMaterials.delete(aTool);
                                break;
                            }

                            while (!exists)
                            {
                                Console.Clear();
                                Console.WriteLine("Tool not found in system. Please try a different tool");
                                break;
                            }

                            foreach (var tool in FloorLevellingMaterials.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Hand":
                            exists = FloorHandTools.search(aTool);

                            while (exists)
                            {

                                FloorHandTools.delete(aTool);
                                break;
                            }

                            while (!exists)
                            {
                                Console.Clear();
                                Console.WriteLine("Tool not found in system. Please try a different tool");
                                break;
                            }

                            foreach (var tool in FloorHandTools.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Tiling":
                            exists = TilingTools.search(aTool);

                            while (exists)
                            {

                                TilingTools.delete(aTool);
                                break;
                            }

                            while (!exists)
                            {
                                Console.Clear();
                                Console.WriteLine("Tool not found in system. Please try a different tool");
                                break;
                            }

                            foreach (var tool in TilingTools.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                    }
                    break;
                case "Fence":
                    switch (type)
                    {
                        case "Hand":
                            bool exists = FHandTools.search(aTool);

                            while (exists)
                            {

                                FHandTools.delete(aTool);
                                break;
                            }

                            while (!exists)
                            {
                                Console.Clear();
                                Console.WriteLine("Tool not found in system. Please try a different tool");
                                break;
                            }

                            foreach (var tool in FHandTools.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Electric":
                            exists = ElectricFencing.search(aTool);

                            while (exists)
                            {

                                ElectricFencing.delete(aTool);
                                break;
                            }

                            while (!exists)
                            {
                                Console.Clear();
                                Console.WriteLine("Tool not found in system. Please try a different tool");
                                break;
                            }

                            foreach (var tool in ElectricFencing.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Steel":
                            exists = SteelFencing.search(aTool);

                            while (exists)
                            {

                                SteelFencing.delete(aTool);
                                break;
                            }

                            while (!exists)
                            {
                                Console.Clear();
                                Console.WriteLine("Tool not found in system. Please try a different tool");
                                break;
                            }

                            foreach (var tool in SteelFencing.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Power":
                            exists = PowerTools.search(aTool);

                            while (exists)
                            {

                                PowerTools.delete(aTool);
                                break;
                            }

                            while (!exists)
                            {
                                Console.Clear();
                                Console.WriteLine("Tool not found in system. Please try a different tool");
                                break;
                            }

                            foreach (var tool in PowerTools.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Accessories":
                            exists = FencingAccessories.search(aTool);

                            while (exists)
                            {

                                FencingAccessories.delete(aTool);
                                break;
                            }

                            while (!exists)
                            {
                                Console.Clear();
                                Console.WriteLine("Tool not found in system. Please try a different tool");
                                break;
                            }

                            foreach (var tool in FencingAccessories.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                    }
                    break;
                case "Measure":
                    switch (type)
                    {
                        case "Distance":
                            bool exists = DistanceTools.search(aTool);

                            while (exists)
                            {

                                DistanceTools.delete(aTool);
                                break;
                            }

                            while (!exists)
                            {
                                Console.Clear();
                                Console.WriteLine("Tool not found in system. Please try a different tool");
                                break;
                            }

                            foreach (var tool in DistanceTools.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Laser":
                            exists = LaserMeasurer.search(aTool);

                            while (exists)
                            {

                                LaserMeasurer.delete(aTool);
                                break;
                            }

                            while (!exists)
                            {
                                Console.Clear();
                                Console.WriteLine("Tool not found in system. Please try a different tool");
                                break;
                            }

                            foreach (var tool in LaserMeasurer.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Jug":
                            exists = MeasuringJugs.search(aTool);

                            while (exists)
                            {

                                MeasuringJugs.delete(aTool);
                                break;
                            }

                            while (!exists)
                            {
                                Console.Clear();
                                Console.WriteLine("Tool not found in system. Please try a different tool");
                                break;
                            }

                            foreach (var tool in MeasuringJugs.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Temp":
                            exists = Temp_HumidityTools.search(aTool);

                            while (exists)
                            {

                                Temp_HumidityTools.delete(aTool);
                                break;
                            }

                            while (!exists)
                            {
                                Console.Clear();
                                Console.WriteLine("Tool not found in system. Please try a different tool");
                                break;
                            }

                            foreach (var tool in Temp_HumidityTools.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Level":
                            exists = LevellingTools.search(aTool);

                            while (exists)
                            {

                                LevellingTools.delete(aTool);
                                break;
                            }

                            while (!exists)
                            {
                                Console.Clear();
                                Console.WriteLine("Tool not found in system. Please try a different tool");
                                break;
                            }

                            foreach (var tool in LevellingTools.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Markers":
                            exists = Markers.search(aTool);

                            while (exists)
                            {

                                Markers.delete(aTool);
                                break;
                            }

                            while (!exists)
                            {
                                Console.Clear();
                                Console.WriteLine("Tool not found in system. Please try a different tool");
                                break;
                            }

                            foreach (var tool in Markers.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                    }
                    break;
                case "Clean":
                    switch (type)
                    {
                        case "Drain":
                            bool exists = Draining.search(aTool);

                            while (exists)
                            {

                                Draining.delete(aTool);
                                break;
                            }

                            while (!exists)
                            {
                                Console.Clear();
                                Console.WriteLine("Tool not found in system. Please try a different tool");
                                break;
                            }

                            foreach (var tool in Draining.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Car":
                            exists = CarCleaning.search(aTool);

                            while (exists)
                            {

                                CarCleaning.delete(aTool);
                                break;
                            }

                            while (!exists)
                            {
                                Console.Clear();
                                Console.WriteLine("Tool not found in system. Please try a different tool");
                                break;
                            }

                            foreach (var tool in CarCleaning.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Vacuum":
                            exists = Vacuum.search(aTool);

                            while (exists)
                            {

                                CarCleaning.delete(aTool);
                                break;
                            }

                            while (!exists)
                            {
                                Console.Clear();
                                Console.WriteLine("Tool not found in system. Please try a different tool");
                                break;
                            }

                            foreach (var tool in CarCleaning.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Pressure":
                            exists = PressureCleaners.search(aTool);

                            while (exists)
                            {

                                PressureCleaners.delete(aTool);
                                break;
                            }

                            while (!exists)
                            {
                                Console.Clear();
                                Console.WriteLine("Tool not found in system. Please try a different tool");
                                break;
                            }

                            foreach (var tool in PressureCleaners.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Pool":
                            exists = PoolCleaning.search(aTool);

                            while (exists)
                            {

                                PoolCleaning.delete(aTool);
                                break;
                            }

                            while (!exists)
                            {
                                Console.Clear();
                                Console.WriteLine("Tool not found in system. Please try a different tool");
                                break;
                            }

                            foreach (var tool in PoolCleaning.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Floor":
                            exists = FloorCleaning.search(aTool);

                            while (exists)
                            {

                                FloorCleaning.delete(aTool);
                                break;
                            }

                            while (!exists)
                            {
                                Console.Clear();
                                Console.WriteLine("Tool not found in system. Please try a different tool");
                                break;
                            }

                            foreach (var tool in FloorCleaning.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                    }
                    break;
                case "Paint":
                    switch (type)
                    {
                        case "Sanding":
                            bool exists = SandingTools.search(aTool);

                            while (exists)
                            {

                                SandingTools.delete(aTool);
                                break;
                            }

                            while (!exists)
                            {
                                Console.Clear();
                                Console.WriteLine("Tool not found in system. Please try a different tool");
                                break;
                            }

                            foreach (var tool in SandingTools.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Brushes":
                            exists = Brushes.search(aTool);

                            while (exists)
                            {

                                Brushes.delete(aTool);
                                break;
                            }

                            while (!exists)
                            {
                                Console.Clear();
                                Console.WriteLine("Tool not found in system. Please try a different tool");
                                break;
                            }

                            foreach (var tool in Brushes.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Rollers":
                            exists = Rollers.search(aTool);

                            while (exists)
                            {

                                Rollers.delete(aTool);
                                break;
                            }

                            while (!exists)
                            {
                                Console.Clear();
                                Console.WriteLine("Tool not found in system. Please try a different tool");
                                break;
                            }

                            foreach (var tool in Rollers.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Removal":
                            exists = PaintRemovalTools.search(aTool);

                            while (exists)
                            {

                                PaintRemovalTools.delete(aTool);
                                break;
                            }

                            while (!exists)
                            {
                                Console.Clear();
                                Console.WriteLine("Tool not found in system. Please try a different tool");
                                break;
                            }

                            foreach (var tool in PaintRemovalTools.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Scraper":
                            exists = PaintScrapers.search(aTool);

                            while (exists)
                            {

                                PaintScrapers.delete(aTool);
                                break;
                            }

                            while (!exists)
                            {
                                Console.Clear();
                                Console.WriteLine("Tool not found in system. Please try a different tool");
                                break;
                            }

                            foreach (var tool in PaintScrapers.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Spray":
                            exists = Sprayers.search(aTool);

                            while (exists)
                            {

                                Sprayers.delete(aTool);
                                break;
                            }

                            while (!exists)
                            {
                                Console.Clear();
                                Console.WriteLine("Tool not found in system. Please try a different tool");
                                break;
                            }

                            foreach (var tool in Sprayers.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                    }
                    break;
                case "Electronic":
                    switch (type)
                    {
                        case "Voltage":
                            bool exists = VoltageTester.search(aTool);

                            while (exists)
                            {

                                VoltageTester.delete(aTool);
                                break;
                            }

                            while (!exists)
                            {
                                Console.Clear();
                                Console.WriteLine("Tool not found in system. Please try a different tool");
                                break;
                            }

                            foreach (var tool in VoltageTester.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Oscill":
                            exists = Oscilloscopes.search(aTool);

                            while (exists)
                            {

                                Oscilloscopes.delete(aTool);
                                break;
                            }

                            while (!exists)
                            {
                                Console.Clear();
                                Console.WriteLine("Tool not found in system. Please try a different tool");
                                break;
                            }

                            foreach (var tool in Oscilloscopes.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Therm":
                            exists = ThermalImaging.search(aTool);

                            while (exists)
                            {

                                ThermalImaging.delete(aTool);
                                break;
                            }

                            while (!exists)
                            {
                                Console.Clear();
                                Console.WriteLine("Tool not found in system. Please try a different tool");
                                break;
                            }

                            foreach (var tool in ThermalImaging.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Test":
                            exists = DataTestTool.search(aTool);

                            while (exists)
                            {

                                DataTestTool.delete(aTool);
                                break;
                            }

                            while (!exists)
                            {
                                Console.Clear();
                                Console.WriteLine("Tool not found in system. Please try a different tool");
                                break;
                            }

                            foreach (var tool in DataTestTool.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Insul":
                            exists = InsulationTesters.search(aTool);

                            while (exists)
                            {

                                InsulationTesters.delete(aTool);
                                break;
                            }

                            while (!exists)
                            {
                                Console.Clear();
                                Console.WriteLine("Tool not found in system. Please try a different tool");
                                break;
                            }

                            foreach (var tool in InsulationTesters.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                    }
                    break;
                case "Electric":
                    switch (type)
                    {
                        case "Test":
                            bool exists = TestEquipment.search(aTool);

                            while (exists)
                            {

                                TestEquipment.delete(aTool);
                                break;
                            }

                            while (!exists)
                            {
                                Console.Clear();
                                Console.WriteLine("Tool not found in system. Please try a different tool");
                                break;
                            }

                            foreach (var tool in TestEquipment.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Safety":
                            exists = SafetyEquipment.search(aTool);

                            while (exists)
                            {

                                SafetyEquipment.delete(aTool);
                                break;
                            }

                            while (!exists)
                            {
                                Console.Clear();
                                Console.WriteLine("Tool not found in system. Please try a different tool");
                                break;
                            }

                            foreach (var tool in SafetyEquipment.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Hand":
                            exists = BasicHandTools.search(aTool);

                            while (exists)
                            {

                                BasicHandTools.delete(aTool);
                                break;
                            }

                            while (!exists)
                            {
                                Console.Clear();
                                Console.WriteLine("Tool not found in system. Please try a different tool");
                                break;
                            }

                            foreach (var tool in BasicHandTools.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Circuit":
                            exists = CircuitProtection.search(aTool);

                            while (exists)
                            {

                                CircuitProtection.delete(aTool);
                                break;
                            }

                            while (!exists)
                            {
                                Console.Clear();
                                Console.WriteLine("Tool not found in system. Please try a different tool");
                                break;
                            }

                            foreach (var tool in CircuitProtection.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Cable":
                            exists = CableTools.search(aTool);

                            while (exists)
                            {

                                CableTools.delete(aTool);
                                break;
                            }

                            while (!exists)
                            {
                                Console.Clear();
                                Console.WriteLine("Tool not found in system. Please try a different tool");
                                break;
                            }

                            foreach (var tool in CableTools.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                    }
                    break;
                case "Auto":
                    switch (type)
                    {
                        case "Jacks":
                            bool exists = Jacks.search(aTool);

                            while (exists)
                            {

                                Jacks.delete(aTool);
                                break;
                            }

                            while (!exists)
                            {
                                Console.Clear();
                                Console.WriteLine("Tool not found in system. Please try a different tool");
                                break;
                            }

                            foreach (var tool in Jacks.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Air":
                            exists = AirCompressors.search(aTool);

                            while (exists)
                            {

                                AirCompressors.delete(aTool);
                                break;
                            }

                            while (!exists)
                            {
                                Console.Clear();
                                Console.WriteLine("Tool not found in system. Please try a different tool");
                                break;
                            }

                            foreach (var tool in AirCompressors.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Battery":
                            exists = BatteryChargers.search(aTool);

                            while (exists)
                            {

                                BatteryChargers.delete(aTool);
                                break;
                            }

                            while (!exists)
                            {
                                Console.Clear();
                                Console.WriteLine("Tool not found in system. Please try a different tool");
                                break;
                            }

                            foreach (var tool in BatteryChargers.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Socket":
                            exists = SocketTools.search(aTool);

                            while (exists)
                            {

                                SocketTools.delete(aTool);
                                break;
                            }

                            while (!exists)
                            {
                                Console.Clear();
                                Console.WriteLine("Tool not found in system. Please try a different tool");
                                break;
                            }

                            foreach (var tool in SocketTools.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Brake":
                            exists = Braking.search(aTool);

                            while (exists)
                            {

                                Braking.delete(aTool);
                                break;
                            }

                            while (!exists)
                            {
                                Console.Clear();
                                Console.WriteLine("Tool not found in system. Please try a different tool");
                                break;
                            }

                            foreach (var tool in Braking.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Drive":
                            exists = Drivetrain.search(aTool);

                            while (exists)
                            {

                                Drivetrain.delete(aTool);
                                break;
                            }

                            while (!exists)
                            {
                                Console.Clear();
                                Console.WriteLine("Tool not found in system. Please try a different tool");
                                break;
                            }

                            foreach (var tool in Drivetrain.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                    }
                    break;
            }
        }

        public void delete(iTool aTool, int quantity, string category, string type)
        {
            Console.Clear();
            Console.WriteLine("Deleting " + quantity + " " + aTool.Name + "s from system");

            switch (category)
            {
                case "Garden":
                    switch (type)
                    {
                        case "Line":
                            bool exists = LineTrimmers.search(aTool);

                            while (exists)
                            {
                                for (int i = 0; i < quantity; i++)
                                {
                                    foreach (var tool in LineTrimmers.tools)
                                    {
                                        if (tool.Name == aTool.Name)
                                        {
                                            tool.Quantity--;
                                            tool.AvailableQuantity--;
                                        }

                                        if (tool.Quantity <= 0)
                                        {
                                            LineTrimmers.delete(aTool);
                                        }
                                    }
                                }
                                break;
                            }

                            while (!exists)
                            {
                                Console.Clear();
                                Console.WriteLine("Tool not found in system. Please try a different tool");
                                break;
                            }

                            foreach (var tool in LineTrimmers.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Mower":
                            exists = LawnMowers.search(aTool);

                            while (exists)
                            {
                                for (int i = 0; i < quantity; i++)
                                {
                                    foreach (var tool in LawnMowers.tools)
                                    {
                                        if (tool.Name == aTool.Name)
                                        {
                                            tool.Quantity--;
                                            tool.AvailableQuantity--;
                                        }

                                        if (tool.Quantity <= 0)
                                        {
                                            LawnMowers.delete(aTool);
                                        }
                                    }
                                }
                                break;
                            }

                            while (!exists)
                            {
                                Console.Clear();
                                Console.WriteLine("Tool not found in system. Please try a different tool");
                                break;
                            }

                            foreach (var tool in LawnMowers.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Hand":
                            exists = GHandTools.search(aTool);

                            while (exists)
                            {
                                for (int i = 0; i < quantity; i++)
                                {
                                    foreach (var tool in GHandTools.tools)
                                    {
                                        if (tool.Name == aTool.Name)
                                        {
                                            tool.Quantity--;
                                            tool.AvailableQuantity--;
                                        }

                                        if (tool.Quantity <= 0)
                                        {
                                            GHandTools.delete(aTool);
                                        }
                                    }
                                }
                                break;
                            }

                            while (!exists)
                            {
                                Console.Clear();
                                Console.WriteLine("Tool not found in system. Please try a different tool");
                                break;
                            }

                            foreach (var tool in GHandTools.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "wheelbarrow":
                            exists = WheelBarrows.search(aTool);

                            while (exists)
                            {
                                for (int i = 0; i < quantity; i++)
                                {
                                    foreach (var tool in WheelBarrows.tools)
                                    {
                                        if (tool.Name == aTool.Name)
                                        {
                                            tool.Quantity--;
                                            tool.AvailableQuantity--;
                                        }

                                        if (tool.Quantity <= 0)
                                        {
                                            WheelBarrows.delete(aTool);
                                        }
                                    }
                                }
                                break;
                            }

                            while (!exists)
                            {
                                Console.Clear();
                                Console.WriteLine("Tool not found in system. Please try a different tool");
                                break;
                            }

                            foreach (var tool in WheelBarrows.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Power":
                            exists = GardenPowerTools.search(aTool);

                            while (exists)
                            {
                                for (int i = 0; i < quantity; i++)
                                {
                                    foreach (var tool in GardenPowerTools.tools)
                                    {
                                        if (tool.Name == aTool.Name)
                                        {
                                            tool.Quantity--;
                                            tool.AvailableQuantity--;
                                        }

                                        if (tool.Quantity <= 0)
                                        {
                                            GardenPowerTools.delete(aTool);
                                        }
                                    }
                                }
                                break;
                            }

                            while (!exists)
                            {
                                Console.Clear();
                                Console.WriteLine("Tool not found in system. Please try a different tool");
                                break;
                            }

                            foreach (var tool in GardenPowerTools.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                    }
                    break;
                case "Floor":
                    switch (type)
                    {
                        case "Scraper":
                            bool exists = Scrapers.search(aTool);

                            while (exists)
                            {
                                for (int i = 0; i < quantity; i++)
                                {
                                    foreach (var tool in Scrapers.tools)
                                    {
                                        if (tool.Name == aTool.Name)
                                        {
                                            tool.Quantity--;
                                            tool.AvailableQuantity--;
                                        }

                                        if (tool.Quantity <= 0)
                                        {
                                            Scrapers.delete(aTool);
                                        }
                                    }
                                }
                                break;
                            }

                            while (!exists)
                            {
                                Console.Clear();
                                Console.WriteLine("Tool not found in system. Please try a different tool");
                                break;
                            }

                            foreach (var tool in Scrapers.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Laser":
                            exists = FloorLasers.search(aTool);

                            while (exists)
                            {
                                for (int i = 0; i < quantity; i++)
                                {
                                    foreach (var tool in FloorLasers.tools)
                                    {
                                        if (tool.Name == aTool.Name)
                                        {
                                            tool.Quantity--;
                                            tool.AvailableQuantity--;
                                        }

                                        if (tool.Quantity <= 0)
                                        {
                                            FloorLasers.delete(aTool);
                                        }
                                    }
                                }
                                break;
                            }

                            while (!exists)
                            {
                                Console.Clear();
                                Console.WriteLine("Tool not found in system. Please try a different tool");
                                break;
                            }

                            foreach (var tool in FloorLasers.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Tools":
                            exists = FloorLevellingTools.search(aTool);

                            while (exists)
                            {
                                for (int i = 0; i < quantity; i++)
                                {
                                    foreach (var tool in FloorLevellingTools.tools)
                                    {
                                        if (tool.Name == aTool.Name)
                                        {
                                            tool.Quantity--;
                                            tool.AvailableQuantity--;
                                        }

                                        if (tool.Quantity <= 0)
                                        {
                                            FloorLevellingTools.delete(aTool);
                                        }
                                    }
                                }
                                break;
                            }

                            while (!exists)
                            {
                                Console.Clear();
                                Console.WriteLine("Tool not found in system. Please try a different tool");
                                break;
                            }

                            foreach (var tool in FloorLevellingTools.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Materials":
                            exists = FloorLevellingMaterials.search(aTool);

                            while (exists)
                            {
                                for (int i = 0; i < quantity; i++)
                                {
                                    foreach (var tool in FloorLevellingMaterials.tools)
                                    {
                                        if (tool.Name == aTool.Name)
                                        {
                                            tool.Quantity--;
                                            tool.AvailableQuantity--;
                                        }

                                        if (tool.Quantity <= 0)
                                        {
                                            FloorLevellingMaterials.delete(aTool);
                                        }
                                    }
                                }
                                break;
                            }

                            while (!exists)
                            {
                                Console.Clear();
                                Console.WriteLine("Tool not found in system. Please try a different tool");
                                break;
                            }

                            foreach (var tool in FloorLevellingMaterials.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Hand":
                            exists = FloorHandTools.search(aTool);

                            while (exists)
                            {
                                for (int i = 0; i < quantity; i++)
                                {
                                    foreach (var tool in FloorHandTools.tools)
                                    {
                                        if (tool.Name == aTool.Name)
                                        {
                                            tool.Quantity--;
                                            tool.AvailableQuantity--;
                                        }

                                        if (tool.Quantity <= 0)
                                        {
                                            FloorHandTools.delete(aTool);
                                        }
                                    }
                                }
                                break;
                            }

                            while (!exists)
                            {
                                Console.Clear();
                                Console.WriteLine("Tool not found in system. Please try a different tool");
                                break;
                            }

                            foreach (var tool in FloorHandTools.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Tiling":
                            exists = TilingTools.search(aTool);

                            while (exists)
                            {
                                for (int i = 0; i < quantity; i++)
                                {
                                    foreach (var tool in TilingTools.tools)
                                    {
                                        if (tool.Name == aTool.Name)
                                        {
                                            tool.Quantity--;
                                            tool.AvailableQuantity--;
                                        }

                                        if (tool.Quantity <= 0)
                                        {
                                            TilingTools.delete(aTool);
                                        }
                                    }
                                }
                                break;
                            }

                            while (!exists)
                            {
                                Console.Clear();
                                Console.WriteLine("Tool not found in system. Please try a different tool");
                                break;
                            }

                            foreach (var tool in TilingTools.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                    }
                    break;
                case "Fence":
                    switch (type)
                    {
                        case "Hand":
                            bool exists = FHandTools.search(aTool);

                            while (exists)
                            {
                                for (int i = 0; i < quantity; i++)
                                {
                                    foreach (var tool in FHandTools.tools)
                                    {
                                        if (tool.Name == aTool.Name)
                                        {
                                            tool.Quantity--;
                                            tool.AvailableQuantity--;
                                        }

                                        if (tool.Quantity <= 0)
                                        {
                                            FHandTools.delete(aTool);
                                        }
                                    }
                                }
                                break;
                            }

                            while (!exists)
                            {
                                Console.Clear();
                                Console.WriteLine("Tool not found in system. Please try a different tool");
                                break;
                            }

                            foreach (var tool in FHandTools.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Electric":
                            exists = ElectricFencing.search(aTool);

                            while (exists)
                            {
                                for (int i = 0; i < quantity; i++)
                                {
                                    foreach (var tool in ElectricFencing.tools)
                                    {
                                        if (tool.Name == aTool.Name)
                                        {
                                            tool.Quantity--;
                                            tool.AvailableQuantity--;
                                        }

                                        if (tool.Quantity <= 0)
                                        {
                                            ElectricFencing.delete(aTool);
                                        }
                                    }
                                }
                                break;
                            }

                            while (!exists)
                            {
                                Console.Clear();
                                Console.WriteLine("Tool not found in system. Please try a different tool");
                                break;
                            }

                            foreach (var tool in ElectricFencing.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Steel":
                            exists = SteelFencing.search(aTool);

                            while (exists)
                            {
                                for (int i = 0; i < quantity; i++)
                                {
                                    foreach (var tool in SteelFencing.tools)
                                    {
                                        if (tool.Name == aTool.Name)
                                        {
                                            tool.Quantity--;
                                            tool.AvailableQuantity--;
                                        }

                                        if (tool.Quantity <= 0)
                                        {
                                            SteelFencing.delete(aTool);
                                        }
                                    }
                                }
                                break;
                            }

                            while (!exists)
                            {
                                Console.Clear();
                                Console.WriteLine("Tool not found in system. Please try a different tool");
                                break;
                            }

                            foreach (var tool in SteelFencing.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Power":
                            exists = PowerTools.search(aTool);

                            while (exists)
                            {
                                for (int i = 0; i < quantity; i++)
                                {
                                    foreach (var tool in PowerTools.tools)
                                    {
                                        if (tool.Name == aTool.Name)
                                        {
                                            tool.Quantity--;
                                            tool.AvailableQuantity--;
                                        }

                                        if (tool.Quantity <= 0)
                                        {
                                            PowerTools.delete(aTool);
                                        }
                                    }
                                }
                                break;
                            }

                            while (!exists)
                            {
                                Console.Clear();
                                Console.WriteLine("Tool not found in system. Please try a different tool");
                                break;
                            }

                            foreach (var tool in PowerTools.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Accessories":
                            exists = FencingAccessories.search(aTool);

                            while (exists)
                            {
                                for (int i = 0; i < quantity; i++)
                                {
                                    foreach (var tool in FencingAccessories.tools)
                                    {
                                        if (tool.Name == aTool.Name)
                                        {
                                            tool.Quantity--;
                                            tool.AvailableQuantity--;
                                        }

                                        if (tool.Quantity <= 0)
                                        {
                                            FencingAccessories.delete(aTool);
                                        }
                                    }
                                }
                                break;
                            }

                            while (!exists)
                            {
                                Console.Clear();
                                Console.WriteLine("Tool not found in system. Please try a different tool");
                                break;
                            }

                            foreach (var tool in FencingAccessories.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                    }
                    break;
                case "Measure":
                    switch (type)
                    {
                        case "Distance":
                            bool exists = DistanceTools.search(aTool);

                            while (exists)
                            {
                                for (int i = 0; i < quantity; i++)
                                {
                                    foreach (var tool in DistanceTools.tools)
                                    {
                                        if (tool.Name == aTool.Name)
                                        {
                                            tool.Quantity--;
                                            tool.AvailableQuantity--;
                                        }

                                        if (tool.Quantity <= 0)
                                        {
                                            DistanceTools.delete(aTool);
                                        }
                                    }
                                }
                                break;
                            }

                            while (!exists)
                            {
                                Console.Clear();
                                Console.WriteLine("Tool not found in system. Please try a different tool");
                                break;
                            }

                            foreach (var tool in DistanceTools.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Laser":
                            exists = LaserMeasurer.search(aTool);

                            while (exists)
                            {
                                for (int i = 0; i < quantity; i++)
                                {
                                    foreach (var tool in LaserMeasurer.tools)
                                    {
                                        if (tool.Name == aTool.Name)
                                        {
                                            tool.Quantity--;
                                            tool.AvailableQuantity--;
                                        }

                                        if (tool.Quantity <= 0)
                                        {
                                            LaserMeasurer.delete(aTool);
                                        }
                                    }
                                }
                                break;
                            }

                            while (!exists)
                            {
                                Console.Clear();
                                Console.WriteLine("Tool not found in system. Please try a different tool");
                                break;
                            }

                            foreach (var tool in LaserMeasurer.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Jug":
                            exists = MeasuringJugs.search(aTool);

                            while (exists)
                            {
                                for (int i = 0; i < quantity; i++)
                                {
                                    foreach (var tool in MeasuringJugs.tools)
                                    {
                                        if (tool.Name == aTool.Name)
                                        {
                                            tool.Quantity--;
                                            tool.AvailableQuantity--;
                                        }

                                        if (tool.Quantity <= 0)
                                        {
                                            MeasuringJugs.delete(aTool);
                                        }
                                    }
                                }
                                break;
                            }

                            while (!exists)
                            {
                                Console.Clear();
                                Console.WriteLine("Tool not found in system. Please try a different tool");
                                break;
                            }

                            foreach (var tool in MeasuringJugs.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Temp":
                            exists = Temp_HumidityTools.search(aTool);

                            while (exists)
                            {
                                for (int i = 0; i < quantity; i++)
                                {
                                    foreach (var tool in Temp_HumidityTools.tools)
                                    {
                                        if (tool.Name == aTool.Name)
                                        {
                                            tool.Quantity--;
                                            tool.AvailableQuantity--;
                                        }

                                        if (tool.Quantity <= 0)
                                        {
                                            Temp_HumidityTools.delete(aTool);
                                        }
                                    }
                                }
                                break;
                            }

                            while (!exists)
                            {
                                Console.Clear();
                                Console.WriteLine("Tool not found in system. Please try a different tool");
                                break;
                            }

                            foreach (var tool in Temp_HumidityTools.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Level":
                            exists = LevellingTools.search(aTool);

                            while (exists)
                            {
                                for (int i = 0; i < quantity; i++)
                                {
                                    foreach (var tool in LevellingTools.tools)
                                    {
                                        if (tool.Name == aTool.Name)
                                        {
                                            tool.Quantity--;
                                            tool.AvailableQuantity--;
                                        }

                                        if (tool.Quantity <= 0)
                                        {
                                            LevellingTools.delete(aTool);
                                        }
                                    }
                                }
                                break;
                            }

                            while (!exists)
                            {
                                Console.Clear();
                                Console.WriteLine("Tool not found in system. Please try a different tool");
                                break;
                            }

                            foreach (var tool in LevellingTools.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Markers":
                            exists = Markers.search(aTool);

                            while (exists)
                            {
                                for (int i = 0; i < quantity; i++)
                                {
                                    foreach (var tool in Markers.tools)
                                    {
                                        if (tool.Name == aTool.Name)
                                        {
                                            tool.Quantity--;
                                            tool.AvailableQuantity--;
                                        }

                                        if (tool.Quantity <= 0)
                                        {
                                            Markers.delete(aTool);
                                        }
                                    }
                                }
                                break;
                            }

                            while (!exists)
                            {
                                Console.Clear();
                                Console.WriteLine("Tool not found in system. Please try a different tool");
                                break;
                            }

                            foreach (var tool in Markers.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                    }
                    break;
                case "Clean":
                    switch (type)
                    {
                        case "Drain":
                            bool exists = Draining.search(aTool);

                            while (exists)
                            {
                                for (int i = 0; i < quantity; i++)
                                {
                                    foreach (var tool in Draining.tools)
                                    {
                                        if (tool.Name == aTool.Name)
                                        {
                                            tool.Quantity--;
                                            tool.AvailableQuantity--;
                                        }

                                        if (tool.Quantity <= 0)
                                        {
                                            Draining.delete(aTool);
                                        }
                                    }
                                }
                                break;
                            }

                            while (!exists)
                            {
                                Console.Clear();
                                Console.WriteLine("Tool not found in system. Please try a different tool");
                                break;
                            }

                            foreach (var tool in Draining.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Car":
                            exists = CarCleaning.search(aTool);

                            while (exists)
                            {
                                for (int i = 0; i < quantity; i++)
                                {
                                    foreach (var tool in CarCleaning.tools)
                                    {
                                        if (tool.Name == aTool.Name)
                                        {
                                            tool.Quantity--;
                                            tool.AvailableQuantity--;
                                        }

                                        if (tool.Quantity <= 0)
                                        {
                                            CarCleaning.delete(aTool);
                                        }
                                    }
                                }
                                break;
                            }

                            while (!exists)
                            {
                                Console.Clear();
                                Console.WriteLine("Tool not found in system. Please try a different tool");
                                break;
                            }

                            foreach (var tool in CarCleaning.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Vacuum":
                            exists = Vacuum.search(aTool);

                            while (exists)
                            {
                                for (int i = 0; i < quantity; i++)
                                {
                                    foreach (var tool in Vacuum.tools)
                                    {
                                        if (tool.Name == aTool.Name)
                                        {
                                            tool.Quantity--;
                                            tool.AvailableQuantity--;
                                        }

                                        if (tool.Quantity <= 0)
                                        {
                                            Vacuum.delete(aTool);
                                        }
                                    }
                                }
                                break;
                            }

                            while (!exists)
                            {
                                Console.Clear();
                                Console.WriteLine("Tool not found in system. Please try a different tool");
                                break;
                            }

                            foreach (var tool in Vacuum.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Pressure":
                            exists = PressureCleaners.search(aTool);

                            while (exists)
                            {
                                for (int i = 0; i < quantity; i++)
                                {
                                    foreach (var tool in PressureCleaners.tools)
                                    {
                                        if (tool.Name == aTool.Name)
                                        {
                                            tool.Quantity--;
                                            tool.AvailableQuantity--;
                                        }

                                        if (tool.Quantity <= 0)
                                        {
                                            PressureCleaners.delete(aTool);
                                        }
                                    }
                                }
                                break;
                            }

                            while (!exists)
                            {
                                Console.Clear();
                                Console.WriteLine("Tool not found in system. Please try a different tool");
                                break;
                            }

                            foreach (var tool in PressureCleaners.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Pool":
                            exists = PoolCleaning.search(aTool);

                            while (exists)
                            {
                                for (int i = 0; i < quantity; i++)
                                {
                                    foreach (var tool in PoolCleaning.tools)
                                    {
                                        if (tool.Name == aTool.Name)
                                        {
                                            tool.Quantity--;
                                            tool.AvailableQuantity--;
                                        }

                                        if (tool.Quantity <= 0)
                                        {
                                            PoolCleaning.delete(aTool);
                                        }
                                    }
                                }
                                break;
                            }

                            while (!exists)
                            {
                                Console.Clear();
                                Console.WriteLine("Tool not found in system. Please try a different tool");
                                break;
                            }

                            foreach (var tool in PoolCleaning.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Floor":
                            exists = FloorCleaning.search(aTool);

                            while (exists)
                            {
                                for (int i = 0; i < quantity; i++)
                                {
                                    foreach (var tool in FloorCleaning.tools)
                                    {
                                        if (tool.Name == aTool.Name)
                                        {
                                            tool.Quantity--;
                                            tool.AvailableQuantity--;
                                        }

                                        if (tool.Quantity <= 0)
                                        {
                                            FloorCleaning.delete(aTool);
                                        }
                                    }
                                }
                                break;
                            }

                            while (!exists)
                            {
                                Console.Clear();
                                Console.WriteLine("Tool not found in system. Please try a different tool");
                                break;
                            }

                            foreach (var tool in FloorCleaning.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                    }
                    break;
                case "Paint":
                    switch (type)
                    {
                        case "Sanding":
                            bool exists = SandingTools.search(aTool);

                            while (exists)
                            {
                                for (int i = 0; i < quantity; i++)
                                {
                                    foreach (var tool in SandingTools.tools)
                                    {
                                        if (tool.Name == aTool.Name)
                                        {
                                            tool.Quantity--;
                                            tool.AvailableQuantity--;
                                        }

                                        if (tool.Quantity <= 0)
                                        {
                                            SandingTools.delete(aTool);
                                        }
                                    }
                                }
                                break;
                            }

                            while (!exists)
                            {
                                Console.Clear();
                                Console.WriteLine("Tool not found in system. Please try a different tool");
                                break;
                            }

                            foreach (var tool in SandingTools.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Brushes":
                            exists = Brushes.search(aTool);

                            while (exists)
                            {
                                for (int i = 0; i < quantity; i++)
                                {
                                    foreach (var tool in Brushes.tools)
                                    {
                                        if (tool.Name == aTool.Name)
                                        {
                                            tool.Quantity--;
                                            tool.AvailableQuantity--;
                                        }

                                        if (tool.Quantity <= 0)
                                        {
                                            Brushes.delete(aTool);
                                        }
                                    }
                                }
                                break;
                            }

                            while (!exists)
                            {
                                Console.Clear();
                                Console.WriteLine("Tool not found in system. Please try a different tool");
                                break;
                            }

                            foreach (var tool in Brushes.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Rollers":
                            exists = Rollers.search(aTool);

                            while (exists)
                            {
                                for (int i = 0; i < quantity; i++)
                                {
                                    foreach (var tool in Rollers.tools)
                                    {
                                        if (tool.Name == aTool.Name)
                                        {
                                            tool.Quantity--;
                                            tool.AvailableQuantity--;
                                        }

                                        if (tool.Quantity <= 0)
                                        {
                                            Rollers.delete(aTool);
                                        }
                                    }
                                }
                                break;
                            }

                            while (!exists)
                            {
                                Console.Clear();
                                Console.WriteLine("Tool not found in system. Please try a different tool");
                                break;
                            }

                            foreach (var tool in Rollers.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Removal":
                            exists = PaintRemovalTools.search(aTool);

                            while (exists)
                            {
                                for (int i = 0; i < quantity; i++)
                                {
                                    foreach (var tool in PaintRemovalTools.tools)
                                    {
                                        if (tool.Name == aTool.Name)
                                        {
                                            tool.Quantity--;
                                            tool.AvailableQuantity--;
                                        }

                                        if (tool.Quantity <= 0)
                                        {
                                            PaintRemovalTools.delete(aTool);
                                        }
                                    }
                                }
                                break;
                            }

                            while (!exists)
                            {
                                Console.Clear();
                                Console.WriteLine("Tool not found in system. Please try a different tool");
                                break;
                            }

                            foreach (var tool in PaintRemovalTools.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Scraper":
                            exists = PaintScrapers.search(aTool);

                            while (exists)
                            {
                                for (int i = 0; i < quantity; i++)
                                {
                                    foreach (var tool in PaintScrapers.tools)
                                    {
                                        if (tool.Name == aTool.Name)
                                        {
                                            tool.Quantity--;
                                            tool.AvailableQuantity--;
                                        }

                                        if (tool.Quantity <= 0)
                                        {
                                            PaintScrapers.delete(aTool);
                                        }
                                    }
                                }
                                break;
                            }

                            while (!exists)
                            {
                                Console.Clear();
                                Console.WriteLine("Tool not found in system. Please try a different tool");
                                break;
                            }

                            foreach (var tool in PaintScrapers.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Spray":
                            exists = Sprayers.search(aTool);

                            while (exists)
                            {
                                for (int i = 0; i < quantity; i++)
                                {
                                    foreach (var tool in Sprayers.tools)
                                    {
                                        if (tool.Name == aTool.Name)
                                        {
                                            tool.Quantity--;
                                            tool.AvailableQuantity--;
                                        }

                                        if (tool.Quantity <= 0)
                                        {
                                            Sprayers.delete(aTool);
                                        }
                                    }
                                }
                                break;
                            }

                            while (!exists)
                            {
                                Console.Clear();
                                Console.WriteLine("Tool not found in system. Please try a different tool");
                                break;
                            }

                            foreach (var tool in Sprayers.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                    }
                    break;
                case "Electronic":
                    switch (type)
                    {
                        case "Voltage":
                            bool exists = VoltageTester.search(aTool);

                            while (exists)
                            {
                                for (int i = 0; i < quantity; i++)
                                {
                                    foreach (var tool in VoltageTester.tools)
                                    {
                                        if (tool.Name == aTool.Name)
                                        {
                                            tool.Quantity--;
                                            tool.AvailableQuantity--;
                                        }

                                        if (tool.Quantity <= 0)
                                        {
                                            VoltageTester.delete(aTool);
                                        }
                                    }
                                }
                                break;
                            }

                            while (!exists)
                            {
                                Console.Clear();
                                Console.WriteLine("Tool not found in system. Please try a different tool");
                                break;
                            }

                            foreach (var tool in VoltageTester.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Oscill":
                            exists = Oscilloscopes.search(aTool);

                            while (exists)
                            {
                                for (int i = 0; i < quantity; i++)
                                {
                                    foreach (var tool in Oscilloscopes.tools)
                                    {
                                        if (tool.Name == aTool.Name)
                                        {
                                            tool.Quantity--;
                                            tool.AvailableQuantity--;
                                        }

                                        if (tool.Quantity <= 0)
                                        {
                                            Oscilloscopes.delete(aTool);
                                        }
                                    }
                                }
                                break;
                            }

                            while (!exists)
                            {
                                Console.Clear();
                                Console.WriteLine("Tool not found in system. Please try a different tool");
                                break;
                            }

                            foreach (var tool in Oscilloscopes.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Therm":
                            exists = ThermalImaging.search(aTool);

                            while (exists)
                            {
                                for (int i = 0; i < quantity; i++)
                                {
                                    foreach (var tool in ThermalImaging.tools)
                                    {
                                        if (tool.Name == aTool.Name)
                                        {
                                            tool.Quantity--;
                                            tool.AvailableQuantity--;
                                        }

                                        if (tool.Quantity <= 0)
                                        {
                                            ThermalImaging.delete(aTool);
                                        }
                                    }
                                }
                                break;
                            }

                            while (!exists)
                            {
                                Console.Clear();
                                Console.WriteLine("Tool not found in system. Please try a different tool");
                                break;
                            }

                            foreach (var tool in ThermalImaging.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Test":
                            exists = DataTestTool.search(aTool);

                            while (exists)
                            {
                                for (int i = 0; i < quantity; i++)
                                {
                                    foreach (var tool in DataTestTool.tools)
                                    {
                                        if (tool.Name == aTool.Name)
                                        {
                                            tool.Quantity--;
                                            tool.AvailableQuantity--;
                                        }

                                        if (tool.Quantity <= 0)
                                        {
                                            DataTestTool.delete(aTool);
                                        }
                                    }
                                }
                                break;
                            }

                            while (!exists)
                            {
                                Console.Clear();
                                Console.WriteLine("Tool not found in system. Please try a different tool");
                                break;
                            }

                            foreach (var tool in DataTestTool.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Insul":
                            exists = InsulationTesters.search(aTool);

                            while (exists)
                            {
                                for (int i = 0; i < quantity; i++)
                                {
                                    foreach (var tool in InsulationTesters.tools)
                                    {
                                        if (tool.Name == aTool.Name)
                                        {
                                            tool.Quantity--;
                                            tool.AvailableQuantity--;
                                        }

                                        if (tool.Quantity <= 0)
                                        {
                                            InsulationTesters.delete(aTool);
                                        }
                                    }
                                }
                                break;
                            }

                            while (!exists)
                            {
                                Console.Clear();
                                Console.WriteLine("Tool not found in system. Please try a different tool");
                                break;
                            }

                            foreach (var tool in InsulationTesters.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                    }
                    break;
                case "Electric":
                    switch (type)
                    {
                        case "Test":
                            bool exists = TestEquipment.search(aTool);

                            while (exists)
                            {
                                for (int i = 0; i < quantity; i++)
                                {
                                    foreach (var tool in TestEquipment.tools)
                                    {
                                        if (tool.Name == aTool.Name)
                                        {
                                            tool.Quantity--;
                                            tool.AvailableQuantity--;
                                        }

                                        if (tool.Quantity <= 0)
                                        {
                                            TestEquipment.delete(aTool);
                                        }
                                    }
                                }
                                break;
                            }

                            while (!exists)
                            {
                                Console.Clear();
                                Console.WriteLine("Tool not found in system. Please try a different tool");
                                break;
                            }

                            foreach (var tool in TestEquipment.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Safety":
                            exists = SafetyEquipment.search(aTool);

                            while (exists)
                            {
                                for (int i = 0; i < quantity; i++)
                                {
                                    foreach (var tool in SafetyEquipment.tools)
                                    {
                                        if (tool.Name == aTool.Name)
                                        {
                                            tool.Quantity--;
                                            tool.AvailableQuantity--;
                                        }

                                        if (tool.Quantity <= 0)
                                        {
                                            SafetyEquipment.delete(aTool);
                                        }
                                    }
                                }
                                break;
                            }

                            while (!exists)
                            {
                                Console.Clear();
                                Console.WriteLine("Tool not found in system. Please try a different tool");
                                break;
                            }

                            foreach (var tool in SafetyEquipment.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Hand":
                            exists = BasicHandTools.search(aTool);

                            while (exists)
                            {
                                for (int i = 0; i < quantity; i++)
                                {
                                    foreach (var tool in BasicHandTools.tools)
                                    {
                                        if (tool.Name == aTool.Name)
                                        {
                                            tool.Quantity--;
                                            tool.AvailableQuantity--;
                                        }

                                        if (tool.Quantity <= 0)
                                        {
                                            BasicHandTools.delete(aTool);
                                        }
                                    }
                                }
                                break;
                            }

                            while (!exists)
                            {
                                Console.Clear();
                                Console.WriteLine("Tool not found in system. Please try a different tool");
                                break;
                            }

                            foreach (var tool in BasicHandTools.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Circuit":
                            exists = CircuitProtection.search(aTool);

                            while (exists)
                            {
                                for (int i = 0; i < quantity; i++)
                                {
                                    foreach (var tool in CircuitProtection.tools)
                                    {
                                        if (tool.Name == aTool.Name)
                                        {
                                            tool.Quantity--;
                                            tool.AvailableQuantity--;
                                        }

                                        if (tool.Quantity <= 0)
                                        {
                                            CircuitProtection.delete(aTool);
                                        }
                                    }
                                }
                                break;
                            }

                            while (!exists)
                            {
                                Console.Clear();
                                Console.WriteLine("Tool not found in system. Please try a different tool");
                                break;
                            }

                            foreach (var tool in CircuitProtection.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Cable":
                            exists = CableTools.search(aTool);

                            while (exists)
                            {
                                for (int i = 0; i < quantity; i++)
                                {
                                    foreach (var tool in CableTools.tools)
                                    {
                                        if (tool.Name == aTool.Name)
                                        {
                                            tool.Quantity--;
                                            tool.AvailableQuantity--;
                                        }

                                        if (tool.Quantity <= 0)
                                        {
                                            CableTools.delete(aTool);
                                        }
                                    }
                                }
                                break;
                            }

                            while (!exists)
                            {
                                Console.Clear();
                                Console.WriteLine("Tool not found in system. Please try a different tool");
                                break;
                            }

                            foreach (var tool in CableTools.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                    }
                    break;
                case "Auto":
                    switch (type)
                    {
                        case "Jacks":
                            bool exists = Jacks.search(aTool);

                            while (exists)
                            {
                                for (int i = 0; i < quantity; i++)
                                {
                                    foreach (var tool in Jacks.tools)
                                    {
                                        if (tool.Name == aTool.Name)
                                        {
                                            tool.Quantity--;
                                            tool.AvailableQuantity--;
                                        }

                                        if (tool.Quantity <= 0)
                                        {
                                            Jacks.delete(aTool);
                                        }
                                    }
                                }
                                break;
                            }

                            while (!exists)
                            {
                                Console.Clear();
                                Console.WriteLine("Tool not found in system. Please try a different tool");
                                break;
                            }

                            foreach (var tool in Jacks.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Air":
                            exists = AirCompressors.search(aTool);

                            while (exists)
                            {
                                for (int i = 0; i < quantity; i++)
                                {
                                    foreach (var tool in AirCompressors.tools)
                                    {
                                        if (tool.Name == aTool.Name)
                                        {
                                            tool.Quantity--;
                                            tool.AvailableQuantity--;
                                        }

                                        if (tool.Quantity <= 0)
                                        {
                                            AirCompressors.delete(aTool);
                                        }
                                    }
                                }
                                break;
                            }

                            while (!exists)
                            {
                                Console.Clear();
                                Console.WriteLine("Tool not found in system. Please try a different tool");
                                break;
                            }

                            foreach (var tool in AirCompressors.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Battery":
                            exists = BatteryChargers.search(aTool);

                            while (exists)
                            {
                                for (int i = 0; i < quantity; i++)
                                {
                                    foreach (var tool in BatteryChargers.tools)
                                    {
                                        if (tool.Name == aTool.Name)
                                        {
                                            tool.Quantity--;
                                            tool.AvailableQuantity--;
                                        }

                                        if (tool.Quantity <= 0)
                                        {
                                            BatteryChargers.delete(aTool);
                                        }
                                    }
                                }
                                break;
                            }

                            while (!exists)
                            {
                                Console.Clear();
                                Console.WriteLine("Tool not found in system. Please try a different tool");
                                break;
                            }

                            foreach (var tool in BatteryChargers.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Socket":
                            exists = SocketTools.search(aTool);

                            while (exists)
                            {
                                for (int i = 0; i < quantity; i++)
                                {
                                    foreach (var tool in SocketTools.tools)
                                    {
                                        if (tool.Name == aTool.Name)
                                        {
                                            tool.Quantity--;
                                            tool.AvailableQuantity--;
                                        }

                                        if (tool.Quantity <= 0)
                                        {
                                            SocketTools.delete(aTool);
                                        }
                                    }
                                }
                                break;
                            }

                            while (!exists)
                            {
                                Console.Clear();
                                Console.WriteLine("Tool not found in system. Please try a different tool");
                                break;
                            }

                            foreach (var tool in SocketTools.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Brake":
                            exists = Braking.search(aTool);

                            while (exists)
                            {
                                for (int i = 0; i < quantity; i++)
                                {
                                    foreach (var tool in Braking.tools)
                                    {
                                        if (tool.Name == aTool.Name)
                                        {
                                            tool.Quantity--;
                                            tool.AvailableQuantity--;
                                        }

                                        if (tool.Quantity <= 0)
                                        {
                                            Braking.delete(aTool);
                                        }
                                    }
                                }
                                break;
                            }

                            while (!exists)
                            {
                                Console.Clear();
                                Console.WriteLine("Tool not found in system. Please try a different tool");
                                break;
                            }

                            foreach (var tool in Braking.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                        case "Drive":
                            exists = Drivetrain.search(aTool);

                            while (exists)
                            {
                                for (int i = 0; i < quantity; i++)
                                {
                                    foreach (var tool in Drivetrain.tools)
                                    {
                                        if (tool.Name == aTool.Name)
                                        {
                                            tool.Quantity--;
                                            tool.AvailableQuantity--;
                                        }

                                        if (tool.Quantity <= 0)
                                        {
                                            Drivetrain.delete(aTool);
                                        }
                                    }
                                }
                                break;
                            }

                            while (!exists)
                            {
                                Console.Clear();
                                Console.WriteLine("Tool not found in system. Please try a different tool");
                                break;
                            }

                            foreach (var tool in Drivetrain.tools)
                            {
                                Console.WriteLine(tool.Name);
                            }
                            break;
                    }
                    break;
            }
        }

        public void delete(iMember aMember)
        {
            Console.Clear();
            Console.WriteLine("Deleting " + aMember.FirstName + " " + aMember.LastName + " from system");

            bool exists = memberCollection.search(aMember);

            while (exists)
            {
                memberCollection.delete(aMember);
                break;

            }

            while (!exists)
            {
                Console.WriteLine("Member not in system. Please try a different member");
                break;
            }

            var members = memberCollection.toArray();

            foreach (var member in members)
            {
                Console.WriteLine(member.FirstName + " " + member.LastName);
            }
        }

        public void displayBorrowingTools(iMember aMember)
        {
            if (aMember.Tools != null)
            {
                foreach (string tool in aMember.Tools)
                {
                    Console.WriteLine(tool);
                }
            }
            else
            {
                Console.WriteLine("You are not currently borrowing any tools");
            }
        }

        public void displayTools(string aToolType)
        {
            throw new NotImplementedException();
        }

        public void displayTopTHree()
        {
            iTool[][] toolCollections = new iTool[][] { LineTrimmers.toArray(), LawnMowers.toArray(), GHandTools.toArray(),
                WheelBarrows.toArray(), GardenPowerTools.toArray(), Scrapers.toArray(), FloorLasers.toArray(),
                FloorLevellingTools.toArray(), FloorLevellingMaterials.toArray(), FloorHandTools.toArray(), TilingTools.toArray(),
                FHandTools.toArray(), ElectricFencing.toArray(), SteelFencing.toArray(), PowerTools.toArray(), FencingAccessories.toArray(),
                DistanceTools.toArray(), LaserMeasurer.toArray(), MeasuringJugs.toArray(), Temp_HumidityTools.toArray(),
                LevellingTools.toArray(), Markers.toArray(), Draining.toArray(), CarCleaning.toArray(), Vacuum.toArray(),
                PressureCleaners.toArray(), PoolCleaning.toArray(), FloorCleaning.toArray(), SandingTools.toArray(), Brushes.toArray(),
                Rollers.toArray(), PaintRemovalTools.toArray(), PaintScrapers.toArray(), Sprayers.toArray(), VoltageTester.toArray(),
                Oscilloscopes.toArray(), ThermalImaging.toArray(), DataTestTool.toArray(), InsulationTesters.toArray(),
                TestEquipment.toArray(), SafetyEquipment.toArray(), CircuitProtection.toArray(), CableTools.toArray(), Jacks.toArray(),
                AirCompressors.toArray(), BatteryChargers.toArray(), SocketTools.toArray(), Braking.toArray(), Drivetrain.toArray() };

            iTool top1 = new Tool();
            iTool top2 = new Tool();
            iTool top3 = new Tool();

            foreach (var toolcollection in toolCollections)
            {
                foreach (var tool in toolcollection)
                {
                    if (tool.NoBorrowings > top1.NoBorrowings && tool.NoBorrowings > top2.NoBorrowings && tool.NoBorrowings > top3.NoBorrowings)
                    {
                        top1.Name = tool.Name;
                        top1.NoBorrowings = tool.NoBorrowings;
                    }
                    if (top1 != null && tool.NoBorrowings > top2.NoBorrowings && tool.NoBorrowings > top3.NoBorrowings)
                    {
                        if (tool.Name != top1.Name)
                        {
                            top2.Name = tool.Name;
                            top2.NoBorrowings = tool.NoBorrowings;
                        }
                        
                    }
                    if (top1 != null && top2 != null && tool.NoBorrowings > top3.NoBorrowings)
                    {
                        if (tool.Name != top1.Name && tool.Name != top2.Name)
                        {
                            top3.Name = tool.Name;
                            top3.NoBorrowings = tool.NoBorrowings;
                        }
                        
                    }
                }
            }
            Console.WriteLine("Top 3 borrowed tools: ");
            Console.WriteLine(top1.Name + " " + top1.NoBorrowings);
            Console.WriteLine(top2.Name + " " + top2.NoBorrowings);
            Console.WriteLine(top3.Name + " " + top3.NoBorrowings);
        }

        public string[] listTools(iMember aMember)
        {
            throw new NotImplementedException();
        }

        public void borrowTool(iMember aMember, iTool aTool, string category, string type)
        {
                aMember.addTool(aTool);

                string toolcat = GetCategory(category);
                string tooltype = GetType(type);

                switch (toolcat)
                {
                    case "Garden":
                        switch (tooltype)
                        {
                            case "Line":
                                foreach (var tool in LineTrimmers.tools)
                                {
                                    if (tool.Name == aTool.Name)
                                    {
                                        tool.AvailableQuantity--;
                                        tool.NoBorrowings++;
                                    }
                                }
                                break;
                            case "Mower":
                                foreach (var tool in LawnMowers.tools)
                                {
                                    if (tool.Name == aTool.Name)
                                    {
                                        tool.AvailableQuantity--;
                                        tool.NoBorrowings++;
                                    }
                                }
                                break;
                            case "Hand":
                                foreach (var tool in GHandTools.tools)
                                {
                                    if (tool.Name == aTool.Name)
                                    {
                                        tool.AvailableQuantity--;
                                        tool.NoBorrowings++;
                                    }
                                }
                                break;
                            case "wheelbarrow":
                                foreach (var tool in WheelBarrows.tools)
                                {
                                    if (tool.Name == aTool.Name)
                                    {
                                        tool.AvailableQuantity--;
                                        tool.NoBorrowings++;
                                    }
                                }
                                break;
                            case "Power":
                                foreach (var tool in GardenPowerTools.tools)
                                {
                                    if (tool.Name == aTool.Name)
                                    {
                                        tool.AvailableQuantity--;
                                        tool.NoBorrowings++;
                                    }
                                }
                                break;
                        }
                        break;
                    case "Floor":
                        switch (tooltype)
                        {
                            case "Scraper":
                                foreach (var tool in Scrapers.tools)
                                {
                                    if (tool.Name == aTool.Name)
                                    {
                                        tool.AvailableQuantity--;
                                        tool.NoBorrowings++;
                                    }
                                }
                                break;
                            case "Laser":
                                foreach (var tool in FloorLasers.tools)
                                {
                                    if (tool.Name == aTool.Name)
                                    {
                                        tool.AvailableQuantity--;
                                        tool.NoBorrowings++;
                                    }
                                }
                                break;
                            case "Tools":
                                foreach (var tool in FloorLevellingTools.tools)
                                {
                                    if (tool.Name == aTool.Name)
                                    {
                                        tool.AvailableQuantity--;
                                        tool.NoBorrowings++;
                                    }
                                }
                                break;
                            case "Materials":
                                foreach (var tool in FloorLevellingMaterials.tools)
                                {
                                    if (tool.Name == aTool.Name)
                                    {
                                        tool.AvailableQuantity--;
                                        tool.NoBorrowings++;
                                    }
                                }
                                break;
                            case "Hand":
                                foreach (var tool in FloorHandTools.tools)
                                {
                                    if (tool.Name == aTool.Name)
                                    {
                                        tool.AvailableQuantity--;
                                        tool.NoBorrowings++;
                                    }
                                }
                                break;
                            case "Tiling":
                                foreach (var tool in TilingTools.tools)
                                {
                                    if (tool.Name == aTool.Name)
                                    {
                                        tool.AvailableQuantity--;
                                        tool.NoBorrowings++;
                                    }
                                }
                                break;
                        }
                        break;
                    case "Fence":
                        switch (tooltype)
                        {
                            case "Hand":
                                foreach (var tool in FHandTools.tools)
                                {
                                    if (tool.Name == aTool.Name)
                                    {
                                        tool.AvailableQuantity--;
                                        tool.NoBorrowings++;
                                    }
                                }
                                break;
                            case "Electric":
                                foreach (var tool in ElectricFencing.tools)
                                {
                                    if (tool.Name == aTool.Name)
                                    {
                                        tool.AvailableQuantity--;
                                        tool.NoBorrowings++;
                                    }
                                }
                                break;
                            case "Steel":
                                foreach (var tool in SteelFencing.tools)
                                {
                                    if (tool.Name == aTool.Name)
                                    {
                                        tool.AvailableQuantity--;
                                        tool.NoBorrowings++;
                                    }
                                }
                                break;
                            case "Power":
                                foreach (var tool in PowerTools.tools)
                                {
                                    if (tool.Name == aTool.Name)
                                    {
                                        tool.AvailableQuantity--;
                                        tool.NoBorrowings++;
                                    }
                                }
                                break;
                            case "Accessories":
                                foreach (var tool in FencingAccessories.tools)
                                {
                                    if (tool.Name == aTool.Name)
                                    {
                                        tool.AvailableQuantity--;
                                        tool.NoBorrowings++;
                                    }
                                }
                                break;
                        }
                        break;
                    case "Measure":
                        switch (tooltype)
                        {
                            case "Distance":
                                foreach (var tool in DistanceTools.tools)
                                {
                                    if (tool.Name == aTool.Name)
                                    {
                                        tool.AvailableQuantity--;
                                        tool.NoBorrowings++;
                                    }
                                }
                                break;
                            case "Laser":
                                foreach (var tool in LaserMeasurer.tools)
                                {
                                    if (tool.Name == aTool.Name)
                                    {
                                        tool.AvailableQuantity--;
                                        tool.NoBorrowings++;
                                    }
                                }
                                break;
                            case "Jug":
                                foreach (var tool in MeasuringJugs.tools)
                                {
                                    if (tool.Name == aTool.Name)
                                    {
                                        tool.AvailableQuantity--;
                                        tool.NoBorrowings++;
                                    }
                                }
                                break;
                            case "Temp":
                                foreach (var tool in Temp_HumidityTools.tools)
                                {
                                    if (tool.Name == aTool.Name)
                                    {
                                        tool.AvailableQuantity--;
                                        tool.NoBorrowings++;
                                    }
                                }
                                break;
                            case "Level":
                                foreach (var tool in LevellingTools.tools)
                                {
                                    if (tool.Name == aTool.Name)
                                    {
                                        tool.AvailableQuantity--;
                                        tool.NoBorrowings++;
                                    }
                                }
                                break;
                            case "Markers":
                                foreach (var tool in Markers.tools)
                                {
                                    if (tool.Name == aTool.Name)
                                    {
                                        tool.AvailableQuantity--;
                                        tool.NoBorrowings++;
                                    }
                                }
                                break;
                        }
                        break;
                    case "Clean":
                        switch (tooltype)
                        {
                            case "Drain":
                                foreach (var tool in Draining.tools)
                                {
                                    if (tool.Name == aTool.Name)
                                    {
                                        tool.AvailableQuantity--;
                                        tool.NoBorrowings++;
                                    }
                                }
                                break;
                            case "Car":
                                foreach (var tool in CarCleaning.tools)
                                {
                                    if (tool.Name == aTool.Name)
                                    {
                                        tool.AvailableQuantity--;
                                        tool.NoBorrowings++;
                                    }
                                }
                                break;
                            case "Vacuum":
                                foreach (var tool in Vacuum.tools)
                                {
                                    if (tool.Name == aTool.Name)
                                    {
                                        tool.AvailableQuantity--;
                                        tool.NoBorrowings++;
                                    }
                                }
                                break;
                            case "Pressure":
                                foreach (var tool in PressureCleaners.tools)
                                {
                                    if (tool.Name == aTool.Name)
                                    {
                                        tool.AvailableQuantity--;
                                        tool.NoBorrowings++;
                                    }
                                }
                                break;
                            case "Pool":
                                foreach (var tool in PoolCleaning.tools)
                                {
                                    if (tool.Name == aTool.Name)
                                    {
                                        tool.AvailableQuantity--;
                                        tool.NoBorrowings++;
                                    }
                                }
                                break;
                            case "Floor":
                                foreach (var tool in FloorCleaning.tools)
                                {
                                    if (tool.Name == aTool.Name)
                                    {
                                        tool.AvailableQuantity--;
                                        tool.NoBorrowings++;
                                    }
                                }
                                break;
                        }
                        break;
                    case "Paint":
                        switch (tooltype)
                        {
                            case "Sanding":
                                foreach (var tool in SandingTools.tools)
                                {
                                    if (tool.Name == aTool.Name)
                                    {
                                        tool.AvailableQuantity--;
                                        tool.NoBorrowings++;
                                    }
                                }
                                break;
                            case "Brushes":
                                foreach (var tool in Brushes.tools)
                                {
                                    if (tool.Name == aTool.Name)
                                    {
                                        tool.AvailableQuantity--;
                                        tool.NoBorrowings++;
                                    }
                                }
                                break;
                            case "Rollers":
                                foreach (var tool in Rollers.tools)
                                {
                                    if (tool.Name == aTool.Name)
                                    {
                                        tool.AvailableQuantity--;
                                        tool.NoBorrowings++;
                                    }
                                }
                                break;
                            case "Removal":
                                foreach (var tool in PaintRemovalTools.tools)
                                {
                                    if (tool.Name == aTool.Name)
                                    {
                                        tool.AvailableQuantity--;
                                        tool.NoBorrowings++;
                                    }
                                }
                                break;
                            case "Scraper":
                                foreach (var tool in PaintScrapers.tools)
                                {
                                    if (tool.Name == aTool.Name)
                                    {
                                        tool.AvailableQuantity--;
                                        tool.NoBorrowings++;
                                    }
                                }
                                break;
                            case "Spray":
                                foreach (var tool in Sprayers.tools)
                                {
                                    if (tool.Name == aTool.Name)
                                    {
                                        tool.AvailableQuantity--;
                                        tool.NoBorrowings++;
                                    }
                                }
                                break;
                        }
                        break;
                    case "Electronic":
                        switch (tooltype)
                        {
                            case "Voltage":
                                foreach (var tool in VoltageTester.tools)
                                {
                                    if (tool.Name == aTool.Name)
                                    {
                                        tool.AvailableQuantity--;
                                        tool.NoBorrowings++;
                                    }
                                }
                                break;
                            case "Oscill":
                                foreach (var tool in Oscilloscopes.tools)
                                {
                                    if (tool.Name == aTool.Name)
                                    {
                                        tool.AvailableQuantity--;
                                        tool.NoBorrowings++;
                                    }
                                }
                                break;
                            case "Therm":
                                foreach (var tool in ThermalImaging.tools)
                                {
                                    if (tool.Name == aTool.Name)
                                    {
                                        tool.AvailableQuantity--;
                                        tool.NoBorrowings++;
                                    }
                                }
                                break;
                            case "Test":
                                foreach (var tool in DataTestTool.tools)
                                {
                                    if (tool.Name == aTool.Name)
                                    {
                                        tool.AvailableQuantity--;
                                        tool.NoBorrowings++;
                                    }
                                }
                                break;
                            case "Insul":
                                foreach (var tool in InsulationTesters.tools)
                                {
                                    if (tool.Name == aTool.Name)
                                    {
                                        tool.AvailableQuantity--;
                                        tool.NoBorrowings++;
                                    }
                                }
                                break;
                        }
                        break;
                    case "Electric":
                        switch (tooltype)
                        {
                            case "Test":
                                foreach (var tool in TestEquipment.tools)
                                {
                                    if (tool.Name == aTool.Name)
                                    {
                                        tool.AvailableQuantity--;
                                        tool.NoBorrowings++;
                                    }
                                }
                                break;
                            case "Safety":
                                foreach (var tool in SafetyEquipment.tools)
                                {
                                    if (tool.Name == aTool.Name)
                                    {
                                        tool.AvailableQuantity--;
                                        tool.NoBorrowings++;
                                    }
                                }
                                break;
                            case "Hand":
                                foreach (var tool in BasicHandTools.tools)
                                {
                                    if (tool.Name == aTool.Name)
                                    {
                                        tool.AvailableQuantity--;
                                        tool.NoBorrowings++;
                                    }
                                }
                                break;
                            case "Circuit":
                                foreach (var tool in CircuitProtection.tools)
                                {
                                    if (tool.Name == aTool.Name)
                                    {
                                        tool.AvailableQuantity--;
                                        tool.NoBorrowings++;
                                    }
                                }
                                break;
                            case "Cable":
                                foreach (var tool in CableTools.tools)
                                {
                                    if (tool.Name == aTool.Name)
                                    {
                                        tool.AvailableQuantity--;
                                        tool.NoBorrowings++;
                                    }
                                }
                                break;
                        }
                        break;
                    case "Auto":
                        switch (tooltype)
                        {
                            case "Jacks":
                                foreach (var tool in Jacks.tools)
                                {
                                    if (tool.Name == aTool.Name)
                                    {
                                        tool.AvailableQuantity--;
                                        tool.NoBorrowings++;
                                    }
                                }
                                break;
                            case "Air":
                                foreach (var tool in AirCompressors.tools)
                                {
                                    if (tool.Name == aTool.Name)
                                    {
                                        tool.AvailableQuantity--;
                                        tool.NoBorrowings++;
                                    }
                                }
                                break;
                            case "Battery":
                                foreach (var tool in BatteryChargers.tools)
                                {
                                    if (tool.Name == aTool.Name)
                                    {
                                        tool.AvailableQuantity--;
                                        tool.NoBorrowings++;
                                    }
                                }
                                break;
                            case "Socket":
                                foreach (var tool in SocketTools.tools)
                                {
                                    if (tool.Name == aTool.Name)
                                    {
                                        tool.AvailableQuantity--;
                                        tool.NoBorrowings++;
                                    }
                                }
                                break;
                            case "Brake":
                                foreach (var tool in Braking.tools)
                                {
                                    if (tool.Name == aTool.Name)
                                    {
                                        tool.AvailableQuantity--;
                                        tool.NoBorrowings++;
                                    }
                                }
                                break;
                            case "Drive":
                                foreach (var tool in Drivetrain.tools)
                                {
                                    if (tool.Name == aTool.Name)
                                    {
                                        tool.AvailableQuantity--;
                                        tool.NoBorrowings++;
                                    }
                                }
                                break;
                        }
                        break;
            }
            
        }

        public void returnTool(iMember aMember, iTool aTool, string category, string type)
        {
            aMember.deleteTool(aTool);

            string toolcat = GetCategory(category);
            string tooltype = GetType(type);

            switch (toolcat)
            {
                case "Garden":
                    switch (tooltype)
                    {
                        case "Line":
                            foreach (var tool in LineTrimmers.tools)
                            {
                                if (tool.Name == aTool.Name)
                                {
                                    tool.AvailableQuantity++;
                                }
                            }
                            break;
                        case "Mower":
                            foreach (var tool in LawnMowers.tools)
                            {
                                if (tool.Name == aTool.Name)
                                {
                                    tool.AvailableQuantity++;
                                }
                            }
                            break;
                        case "Hand":
                            foreach (var tool in GHandTools.tools)
                            {
                                if (tool.Name == aTool.Name)
                                {
                                    tool.AvailableQuantity++;
                                }
                            }
                            break;
                        case "wheelbarrow":
                            foreach (var tool in WheelBarrows.tools)
                            {
                                if (tool.Name == aTool.Name)
                                {
                                    tool.AvailableQuantity++;
                                }
                            }
                            break;
                        case "Power":
                            foreach (var tool in GardenPowerTools.tools)
                            {
                                if (tool.Name == aTool.Name)
                                {
                                    tool.AvailableQuantity++;
                                }
                            }
                            break;
                    }
                    break;
                case "Floor":
                    switch (tooltype)
                    {
                        case "Scraper":
                            foreach (var tool in Scrapers.tools)
                            {
                                if (tool.Name == aTool.Name)
                                {
                                    tool.AvailableQuantity++;
                                }
                            }
                            break;
                        case "Laser":
                            foreach (var tool in FloorLasers.tools)
                            {
                                if (tool.Name == aTool.Name)
                                {
                                    tool.AvailableQuantity++;
                                }
                            }
                            break;
                        case "Tools":
                            foreach (var tool in FloorLevellingTools.tools)
                            {
                                if (tool.Name == aTool.Name)
                                {
                                    tool.AvailableQuantity++;
                                }
                            }
                            break;
                        case "Materials":
                            foreach (var tool in FloorLevellingMaterials.tools)
                            {
                                if (tool.Name == aTool.Name)
                                {
                                    tool.AvailableQuantity++;
                                }
                            }
                            break;
                        case "Hand":
                            foreach (var tool in FloorHandTools.tools)
                            {
                                if (tool.Name == aTool.Name)
                                {
                                    tool.AvailableQuantity++;
                                }
                            }
                            break;
                        case "Tiling":
                            foreach (var tool in TilingTools.tools)
                            {
                                if (tool.Name == aTool.Name)
                                {
                                    tool.AvailableQuantity++;
                                }
                            }
                            break;
                    }
                    break;
                case "Fence":
                    switch (tooltype)
                    {
                        case "Hand":
                            foreach (var tool in FHandTools.tools)
                            {
                                if (tool.Name == aTool.Name)
                                {
                                    tool.AvailableQuantity++;
                                }
                            }
                            break;
                        case "Electric":
                            foreach (var tool in ElectricFencing.tools)
                            {
                                if (tool.Name == aTool.Name)
                                {
                                    tool.AvailableQuantity++;
                                }
                            }
                            break;
                        case "Steel":
                            foreach (var tool in SteelFencing.tools)
                            {
                                if (tool.Name == aTool.Name)
                                {
                                    tool.AvailableQuantity++;
                                }
                            }
                            break;
                        case "Power":
                            foreach (var tool in PowerTools.tools)
                            {
                                if (tool.Name == aTool.Name)
                                {
                                    tool.AvailableQuantity++;
                                }
                            }
                            break;
                        case "Accessories":
                            foreach (var tool in FencingAccessories.tools)
                            {
                                if (tool.Name == aTool.Name)
                                {
                                    tool.AvailableQuantity++;
                                }
                            }
                            break;
                    }
                    break;
                case "Measure":
                    switch (tooltype)
                    {
                        case "Distance":
                            foreach (var tool in DistanceTools.tools)
                            {
                                if (tool.Name == aTool.Name)
                                {
                                    tool.AvailableQuantity++;
                                }
                            }
                            break;
                        case "Laser":
                            foreach (var tool in LaserMeasurer.tools)
                            {
                                if (tool.Name == aTool.Name)
                                {
                                    tool.AvailableQuantity++;
                                }
                            }
                            break;
                        case "Jug":
                            foreach (var tool in MeasuringJugs.tools)
                            {
                                if (tool.Name == aTool.Name)
                                {
                                    tool.AvailableQuantity++;
                                }
                            }
                            break;
                        case "Temp":
                            foreach (var tool in Temp_HumidityTools.tools)
                            {
                                if (tool.Name == aTool.Name)
                                {
                                    tool.AvailableQuantity++;
                                }
                            }
                            break;
                        case "Level":
                            foreach (var tool in LevellingTools.tools)
                            {
                                if (tool.Name == aTool.Name)
                                {
                                    tool.AvailableQuantity++;
                                }
                            }
                            break;
                        case "Markers":
                            foreach (var tool in Markers.tools)
                            {
                                if (tool.Name == aTool.Name)
                                {
                                    tool.AvailableQuantity++;
                                }
                            }
                            break;
                    }
                    break;
                case "Clean":
                    switch (tooltype)
                    {
                        case "Drain":
                            foreach (var tool in Draining.tools)
                            {
                                if (tool.Name == aTool.Name)
                                {
                                    tool.AvailableQuantity++;
                                }
                            }
                            break;
                        case "Car":
                            foreach (var tool in CarCleaning.tools)
                            {
                                if (tool.Name == aTool.Name)
                                {
                                    tool.AvailableQuantity++;
                                }
                            }
                            break;
                        case "Vacuum":
                            foreach (var tool in Vacuum.tools)
                            {
                                if (tool.Name == aTool.Name)
                                {
                                    tool.AvailableQuantity++;
                                }
                            }
                            break;
                        case "Pressure":
                            foreach (var tool in PressureCleaners.tools)
                            {
                                if (tool.Name == aTool.Name)
                                {
                                    tool.AvailableQuantity++;
                                }
                            }
                            break;
                        case "Pool":
                            foreach (var tool in PoolCleaning.tools)
                            {
                                if (tool.Name == aTool.Name)
                                {
                                    tool.AvailableQuantity++;
                                }
                            }
                            break;
                        case "Floor":
                            foreach (var tool in FloorCleaning.tools)
                            {
                                if (tool.Name == aTool.Name)
                                {
                                    tool.AvailableQuantity++;
                                }
                            }
                            break;
                    }
                    break;
                case "Paint":
                    switch (tooltype)
                    {
                        case "Sanding":
                            foreach (var tool in SandingTools.tools)
                            {
                                if (tool.Name == aTool.Name)
                                {
                                    tool.AvailableQuantity++;
                                }
                            }
                            break;
                        case "Brushes":
                            foreach (var tool in Brushes.tools)
                            {
                                if (tool.Name == aTool.Name)
                                {
                                    tool.AvailableQuantity++;
                                }

                            }
                            break;
                        case "Rollers":
                            foreach (var tool in Rollers.tools)
                            {
                                if (tool.Name == aTool.Name)
                                {
                                    tool.AvailableQuantity++;
                                }
                            }
                            break;
                        case "Removal":
                            foreach (var tool in PaintRemovalTools.tools)
                            {
                                if (tool.Name == aTool.Name)
                                {
                                    tool.AvailableQuantity++;
                                }
                            }
                            break;
                        case "Scraper":
                            foreach (var tool in PaintScrapers.tools)
                            {
                                if (tool.Name == aTool.Name)
                                {
                                    tool.AvailableQuantity++;
                                }
                            }
                            break;
                        case "Spray":
                            foreach (var tool in Sprayers.tools)
                            {
                                if (tool.Name == aTool.Name)
                                {
                                    tool.AvailableQuantity++;
                                }
                            }
                            break;
                    }
                    break;
                case "Electronic":
                    switch (tooltype)
                    {
                        case "Voltage":
                            foreach (var tool in VoltageTester.tools)
                            {
                                if (tool.Name == aTool.Name)
                                {
                                    tool.AvailableQuantity++;
                                }
                            }
                            break;
                        case "Oscill":
                            foreach (var tool in Oscilloscopes.tools)
                            {
                                if (tool.Name == aTool.Name)
                                {
                                    tool.AvailableQuantity++;
                                }
                            }
                            break;
                        case "Therm":
                            foreach (var tool in ThermalImaging.tools)
                            {
                                if (tool.Name == aTool.Name)
                                {
                                    tool.AvailableQuantity++;
                                }
                            }
                            break;
                        case "Test":
                            foreach (var tool in DataTestTool.tools)
                            {
                                if (tool.Name == aTool.Name)
                                {
                                    tool.AvailableQuantity++;
                                }
                            }
                            break;
                        case "Insul":
                            foreach (var tool in InsulationTesters.tools)
                            {
                                if (tool.Name == aTool.Name)
                                {
                                    tool.AvailableQuantity++;
                                }
                            }
                            break;
                    }
                    break;
                case "Electric":
                    switch (tooltype)
                    {
                        case "Test":
                            foreach (var tool in TestEquipment.tools)
                            {
                                if (tool.Name == aTool.Name)
                                {
                                    tool.AvailableQuantity++;
                                }
                            }
                            break;
                        case "Safety":
                            foreach (var tool in SafetyEquipment.tools)
                            {
                                if (tool.Name == aTool.Name)
                                {
                                    tool.AvailableQuantity++;
                                }
                            }
                            break;
                        case "Hand":
                            foreach (var tool in BasicHandTools.tools)
                            {
                                if (tool.Name == aTool.Name)
                                {
                                    tool.AvailableQuantity++;
                                }
                            }
                            break;
                        case "Circuit":
                            foreach (var tool in CircuitProtection.tools)
                            {
                                if (tool.Name == aTool.Name)
                                {
                                    tool.AvailableQuantity++;
                                }
                            }
                            break;
                        case "Cable":
                            foreach (var tool in CableTools.tools)
                            {
                                if (tool.Name == aTool.Name)
                                {
                                    tool.AvailableQuantity++;
                                }
                            }
                            break;
                    }
                    break;
                case "Auto":
                    switch (tooltype)
                    {
                        case "Jacks":
                            foreach (var tool in Jacks.tools)
                            {
                                if (tool.Name == aTool.Name)
                                {
                                    tool.AvailableQuantity++;
                                }
                            }
                            break;
                        case "Air":
                            foreach (var tool in AirCompressors.tools)
                            {
                                if (tool.Name == aTool.Name)
                                {
                                    tool.AvailableQuantity++;
                                }
                            }
                            break;
                        case "Battery":
                            foreach (var tool in BatteryChargers.tools)
                            {
                                if (tool.Name == aTool.Name)
                                {
                                    tool.AvailableQuantity++;
                                }
                            }
                            break;
                        case "Socket":
                            foreach (var tool in SocketTools.tools)
                            {
                                if (tool.Name == aTool.Name)
                                {
                                    tool.AvailableQuantity++;
                                }
                            }
                            break;
                        case "Brake":
                            foreach (var tool in Braking.tools)
                            {
                                if (tool.Name == aTool.Name)
                                {
                                    tool.AvailableQuantity++;
                                }
                            }
                            break;
                        case "Drive":
                            foreach (var tool in Drivetrain.tools)
                            {
                                if (tool.Name == aTool.Name)
                                {
                                    tool.AvailableQuantity++;
                                }
                            }
                            break;
                    }
                    break;
            }
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
    }
}
