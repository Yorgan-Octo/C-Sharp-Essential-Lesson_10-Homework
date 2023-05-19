using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_v2
{
    public interface IBeing
    {
        string Type { get; }
    }

    class Human : IBeing
    {
        public string Type { get; }

        public Human(string type)
        {
            Type = type;
        }
    }

    class Animal : IBeing
    {
        public string Type { get; }

        public Animal(string type)
        {
            Type = type;
        }
    }

}
