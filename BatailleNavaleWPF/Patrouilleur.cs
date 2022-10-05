using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatailleNavale
{
    class Patrouilleur : Navire
    {
        private const int _taille = 3;

        public Patrouilleur(Case[] carres) :  base(_taille, carres)
        {

        }
    }
}
