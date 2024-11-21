using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleHashTable.Core
{
    internal class ClassSwich
    {
        static Functions functions = new Functions();
        public void Chage(int i)
        {
            switch(i)
            {
                case 1:
                    functions.Display();
                    break;
                default:
                    Console.WriteLine("Введите коректное значение");
                    break;
            }
        }
    }
}
