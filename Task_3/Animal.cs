using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    public enum TypeEnimalEnum
    {
        Centaur = 12,
        Elf = 21,
        Dragon = 36,
    }

    public class Animal : IAnimal
    {
        public string Name { get; }
        public TypeEnimalEnum TypeEnimal { get; }
        public Animal(TypeEnimalEnum typeEnimal, string name)
        {
            TypeEnimal = typeEnimal;
            Name = name;
        }
    }
}