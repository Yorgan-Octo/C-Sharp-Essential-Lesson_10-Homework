using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_2;

namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            MyList<string> list = new MyList<string>();

            list.Add("sdfff");
            list.Add("uyi");
            list.Add("ghjk");
            list.Add("dgg");
            list.Add("ghjk");
            list.Add("uyuuu");
            list.Add("dtee");
            list.Add("wsew");
            list.Add("ewss");

            string[] elements = list.GetArray();

            foreach (var item in elements)
            {
                Console.WriteLine("MyListExtension: " + item);
            }

            Console.ReadKey();

        }
    }
}
