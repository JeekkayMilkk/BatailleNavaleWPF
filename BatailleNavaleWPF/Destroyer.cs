using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatailleNavale
{
    class Destroyer : Navire
    {
        private const int _taille = 2;

        public Destroyer(Case[] carres) : base(_taille, carres)
        {

        }
    }
}
