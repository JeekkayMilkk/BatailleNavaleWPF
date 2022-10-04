using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatailleNavale
{
    interface INavire
    {
        int Type { get; }
        bool Coule { get; }
        bool EstCoule();
    }
}
