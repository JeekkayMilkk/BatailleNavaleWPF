using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatailleNavale
{
    class Patrouilleur : Navire
    {
        public static int Taille { get; } = 3;

        public Patrouilleur(Case[] carres) :  base(Taille, carres)
        {

        }
    }
}
