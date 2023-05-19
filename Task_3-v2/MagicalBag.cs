using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_v2
{
    internal class MagicalBag<T> where T : IBeing
    {

        List<string> openedToday;

        public MagicalBag()
        {
            openedToday = new List<string>();
        }

        public void OpenBag(T being)
        {
            if (!openedToday.Contains(being.Type))
            {
                Console.WriteLine($"Подарунок з'являється у чарівному мішечку для {being.Type}!");
                openedToday.Add(being.Type);
            }
            else
            {
                Console.WriteLine($"Вибачте, {being.Type}, сьогодні ви вже отримали подарунок з чарівного мішечка.");
            }
        }

    }
}
