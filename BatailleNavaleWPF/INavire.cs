using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatailleNavale
{
    interface INavire
    {
        int Longueur { get; }
        char Type { get; }
        bool Coule { get; }
    }
}
