using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_v3
{
    public class MagicalBag<T> where T : IAnimal
    {
        private DateTime todayDate;

        public void OpenMagicalBag(T animal)
        {
            todayDate = DateTime.Now;



            if (animal.LastOpenMB.Date < todayDate.Date)
            {
                Random random = new Random();
                int present;

                int chance = (int)animal.TypeEnimal; // Шанс випадання залежно від типу істоти можно булоб також выкорыстовуввати масив
                int randomNumber = random.Next(1, 101);

                if (randomNumber <= chance)
                {
                    present = new Random().Next(20, 50);
                }
                else
                {
                    present = 10;
                }

                meseg(ConsoleColor.DarkGreen, $"Вам Подарок {present} монет");
                animal.LastOpenMB = todayDate;
            }
            else
            {
                meseg(ConsoleColor.Red, "Вы уже получил подарок. Возвращайтесь завтра!");
            }
        }

        Action<ConsoleColor, string> meseg = (ConsoleColor color, string info) =>
        {
            Console.ForegroundColor = color;
            Console.WriteLine(info);
            Console.ResetColor();
        };
    }
}
