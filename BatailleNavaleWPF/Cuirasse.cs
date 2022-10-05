using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatailleNavale
{
    class Cuirasse : Navire
    {
        public static int Taille = 4;
        public Cuirasse(Case[] carres) : base(Taille, carres)
        {

        }
    }
}
