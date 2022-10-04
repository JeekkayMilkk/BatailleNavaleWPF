using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatailleNavale
{
    class SousMarin : Navire
    {
        private const int _taille = 1;
        public SousMarin(Case[] carres) : base(_taille, carres)
        {
                
        }
    }
}
