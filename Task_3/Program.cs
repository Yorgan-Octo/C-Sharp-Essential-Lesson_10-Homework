using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            MagicalBag<IAnimal> magicalBag = new MagicalBag<IAnimal>();

            SafariAnimal elf = new SafariAnimal(TypeEnimalEnum.Elf);
            SafariAnimal dragon = new SafariAnimal(TypeEnimalEnum.Dragon);


            magicalBag.OpenMagicalBag(elf);
            magicalBag.OpenMagicalBag(dragon);
            Console.WriteLine("------------------------");
            magicalBag.OpenMagicalBag(elf);
            magicalBag.OpenMagicalBag(dragon);


            Console.ReadKey();

        }
    }
}
