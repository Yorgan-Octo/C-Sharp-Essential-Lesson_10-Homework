using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_v2
{
    internal class MagicalBag<T> where T : IBeing
    {
        List<string> gifts;
        Dictionary<string, DateTime> openedToday;

        public MagicalBag()
        {
            openedToday = new Dictionary<string, DateTime>();
            //openedToday.Add("John", new DateTime(2023, 5, 20)); //для перевирки

        }

        public void OpenBag(T being)
        {
            RandomListGift(being);

            if (!openedToday.ContainsKey(being.Type) || openedToday[being.Type] != DateTime.Today)
            {

                meseg(ConsoleColor.Green, $"Подарунок: \\{gifts[new Random().Next(gifts.Count)]}\\ у чарівному мішечку для {being.Type}!");

                if (!openedToday.ContainsKey(being.Type))
                {
                    openedToday.Add(being.Type, DateTime.Today);
                }
                else
                {
                    openedToday[being.Type] = DateTime.Today;
                }
            }
            else
            {
                meseg(ConsoleColor.Red, $"Вибачте, {being.Type}, сьогодні ви вже отримали подарунок з чарівного мішечка.");
            }
        }

        public void RandomListGift(T being)
        {
            if (being is Human)
            {
                gifts = new List<string>()
                {
                    "Сумка",
                    "Футболка",
                    "Куртка",
                    "Кроси",
                    "Маска",
                    "Каблучка",
                };
            }
            else if (being is Animal)
            {
                gifts = new List<string>()
                {
                    "Смаколики",
                    "Ошийник",
                    "Пакетики",
                    "Курка Смажена",
                    "Щитка",
                    "Намордник",
                };
            }
            else
            {
                gifts = new List<string>()
                {
                    "Купон на одяг",
                    "Купон на взуття",
                    "Купон На білизну",
                    "КУпон на їжу",
                    "Купон на Смаколики",
                };
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
