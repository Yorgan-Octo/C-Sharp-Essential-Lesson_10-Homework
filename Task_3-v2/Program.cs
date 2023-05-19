using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_v2
{
    public class Program
    {
        static void Main(string[] args)
        {

            MagicalBag<IBeing> magicalBag = new MagicalBag<IBeing>();

            Human john = new Human("John");
            Human mary = new Human("Mary");

            while (true)
            {

                magicalBag.OpenBag(john);
                magicalBag.OpenBag(john);
                magicalBag.OpenBag(mary);

                



                Console.WriteLine("------------------------------------------------------");

                Animal dog = new Animal("Dog");
                Animal cat = new Animal("Cat");

                magicalBag.OpenBag(dog);
                magicalBag.OpenBag(dog);
                magicalBag.OpenBag(cat);


                Console.ReadKey();
            }

        }
    }
}
