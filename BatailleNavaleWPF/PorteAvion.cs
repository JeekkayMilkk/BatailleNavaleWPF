using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatailleNavale
{
    class PorteAvion : Navire
    {
        private const int _taille = 5;

        public PorteAvion(Case[] carres): base(_taille, carres)
        {

        }
    }
}
