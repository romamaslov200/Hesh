using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleHashTable.Core
{
    internal class HeshTable<T>
    {
        static public int count = 1;  // колво
        private T[,] items = new T[count, 1]; // элементы
        const int n = 1;

        public HeshTable()
        {
            items = new T[n, n];
        }

        public HeshTable(int length)
        {
            items = new T[length, length];
        }

        public void Add(T item, T item2)
        {
            Console.WriteLine(count);
            Console.WriteLine($"{{items.Length}} = {items.Length}");
            Console.ReadLine();
            if (count == items.Length)
            {
                Console.ReadLine();
                Resize(items.Length + 1);
            }
            items[count, 0] = item;
            items[count++, 1] = item2;
        }

        public T dell()
        {
            if (IsEmpty)
            {
                Console.WriteLine("Cтек пуст");
            }
            //throw new InvalidOperationException("Стек пуст");
            else
            {
                T item = items[count, --count];
                items[count, count] = default(T);
                return item;
            }
            return default(T);
        }

        public bool IsEmpty
        {
            get { return count == 0; }
        }

        public T Peek()
        {
            if (IsEmpty)
            {
                Console.WriteLine("Cтек пуст");
            }
            //throw new InvalidOperationException("Стек пуст");
            else
            {
                return items[count - 1, 0];
            }
            return default(T);
        }

        private void Resize(int max)
        {
            T[,] tempItems = new T[max, max];
            for (int i = 0; i < count; i++)
            {
                tempItems[i, i] = items[i, i];
            }
            items = tempItems;
        }
    }
}
