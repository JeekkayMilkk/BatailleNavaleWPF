using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatailleNavale
{
    class PorteAvion : Navire
    {
        public static int Taille { get; } = 5;

        public PorteAvion(Case[] carres): base('A', carres, Taille)
        {

        }
    }
}
