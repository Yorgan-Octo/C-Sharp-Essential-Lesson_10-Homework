using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_v2
{
    internal class MagicalBag<T> where T : IBeing
    {

        Dictionary<string, DateTime> openedToday;

        public MagicalBag()
        {
            openedToday = new Dictionary<string, DateTime>();
        }

        public void OpenBag(T being)
        {
            if (!openedToday.ContainsKey(being.Type) || openedToday[being.Type] != DateTime.Today)
            {

                Console.WriteLine($"Подарунок з'являється у чарівному мішечку для {being.Type}!");

                if (!openedToday.ContainsKey(being.Type))
                {
                    openedToday.Add(being.Type, DateTime.Today);
                }
            }
            else
            {
                Console.WriteLine($"Вибачте, {being.Type}, сьогодні ви вже отримали подарунок з чарівного мішечка.");
            }
        }

    }
}
