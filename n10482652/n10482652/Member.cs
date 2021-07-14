using System;

namespace n10482652
{
    class Member : iMember
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactNumber { get; set; }
        public string PIN { get; set; }

        

        private string[] tools = new string[0];
        public string[] Tools
        {
            get { return tools; }
        }

        public void addTool(iTool aTool)
        {
            Array.Resize(ref tools, tools.Length + 1);
            tools[tools.Length - 1] = aTool.Name;
            Console.WriteLine("Borrowing " + aTool.Name + " from system");
        }

        public void deleteTool(iTool aTool)
        {
            int index = 0;

            foreach (var tool in tools)
            {
                if (tool == aTool.Name)
                    index = Array.IndexOf(tools, tool);
            }

            for (int i = index; i < tools.Length - 1; i++)
            {
                tools[i] = tools[i + 1];
            }

            Array.Resize(ref tools, tools.Length - 1);
        }
    }
}