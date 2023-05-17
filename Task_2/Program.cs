using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            MyList<int> list = new MyList<int>();

            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);
            list.Add(6);
            list.Add(7);

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine($"Значення елемента MyList: {list[i]}");
            }

            Console.ReadKey();
        }
    }
}
