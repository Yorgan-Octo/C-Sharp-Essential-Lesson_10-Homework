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

    public class SafariAnimal : IAnimal
    {
        public TypeEnimalEnum TypeEnimal { get; }

        public DateTime LastOpenMB { get; set; }

        public SafariAnimal(TypeEnimalEnum typeEnimal) => TypeEnimal = typeEnimal;

    }

}