using ConsoleHashTable.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RomanLib;

namespace ConsoleHashTable
{
    internal class Program
    {
        static Proverka proverka = new Proverka();
        static ClassSwich classSwich = new ClassSwich();
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1. Вывод всех значений из хеш таблици");
                classSwich.Chage(proverka.Type<int>("==> "));
            }
        }
    }
}
