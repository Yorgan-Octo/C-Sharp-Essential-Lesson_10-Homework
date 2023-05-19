using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_v3
{
    public interface IAnimal
    {
        TypeEnimalEnum TypeEnimal { get; }

        DateTime LastOpenMB { get; set; }

    }

}
