using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            MagicalBag<IAnimal> magicalBag = new MagicalBag<IAnimal>();
            Animal elf = new Animal(TypeEnimalEnum.Elf, "Самуель");
            Animal dragon = new Animal(TypeEnimalEnum.Dragon, "Алдуин");

            // я поставыв 4 секунди для ручности перевірки а там можно поставіти 4 або 24 години
            Timer timer = new Timer(magicalBag.ClearTodayList, null, TimeSpan.FromSeconds(4), TimeSpan.FromSeconds(4));

            while (true)
            {
                magicalBag.OpenMagicalBag(elf);
                magicalBag.OpenMagicalBag(dragon);
                Console.WriteLine("------------------------");
                magicalBag.OpenMagicalBag(elf);
                magicalBag.OpenMagicalBag(dragon);

                Console.ReadKey();
                Console.Clear();
            }





        }
    }
}
