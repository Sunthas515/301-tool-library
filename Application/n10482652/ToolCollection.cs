using System;

namespace n10482652
{
    class ToolCollection : iToolCollection
    {
        public int Number => throw new NotImplementedException();

        public iTool[] tools = new iTool[0];

        public void add(iTool aTool)
        {
            Array.Resize(ref tools, tools.Length + 1);
            tools[tools.Length - 1] = aTool;
        }

        public void delete(iTool aTool)
        {
            int index = 0;

            foreach (var tool in tools)
            {
                if (tool.Name == aTool.Name)
                    index = Array.IndexOf(tools, tool);
            }

            for (int i = index; i < tools.Length - 1; i++)
            {
                tools[i] = tools[i + 1];
            }

            Array.Resize(ref tools, tools.Length - 1);
        }

        public bool search(iTool aTool)
        {
            foreach (var tool in tools)
            {
                if (tool.Name == aTool.Name)
                    return true;
            }
            return false;
        }

        public iTool[] toArray()
        {
            return tools;
        }
    }
}