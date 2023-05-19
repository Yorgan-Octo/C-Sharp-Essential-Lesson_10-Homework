using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{

    public class MagicalBag<T> where T : IAnimal
    {
        List<string> openedToday;

        public MagicalBag()
        {
            openedToday = new List<string>();
        }

        public void OpenMagicalBag(T animal)
        {
            if (!openedToday.Contains(animal.Name))
            {
                Random random = new Random();
                int present;

                int chance = (int)animal.TypeEnimal; // Шанс випадання залежно від типу істоти можно булоб також выкорыстовуввати масив с подарунками
                int randomNumber = random.Next(1, 101);

                if (randomNumber <= chance)
                {
                    present = new Random().Next(20, 50);
                }
                else
                {
                    present = 10;
                }

                meseg(ConsoleColor.DarkGreen, $"Вам {animal.Name} Подарок {present} монет");
                openedToday.Add(animal.Name);
            }
            else
            {
                meseg(ConsoleColor.Red, $"Вы {animal.Name} уже получил подарок. Возвращайтесь завтра!");
            }
        }

        public void ClearTodayList(object state)
        {
            openedToday.Clear();
            Console.WriteLine("Отрымайте новый подарунок!");
        }

        Action<ConsoleColor, string> meseg = (ConsoleColor color, string info) =>
        {
            Console.ForegroundColor = color;
            Console.WriteLine(info);
            Console.ResetColor();
        };
    }
}
