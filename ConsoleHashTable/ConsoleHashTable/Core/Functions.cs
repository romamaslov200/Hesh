using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleHashTable.Core
{
    internal class Functions
    {
        HeshTable<string> heshTable = new HeshTable<string>();
        public void Display()
        {
            heshTable.Add("22", "33");
            Console.WriteLine(heshTable.Peek());
        }
    }
}
