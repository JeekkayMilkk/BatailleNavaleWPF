﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatailleNavale
{
    class SousMarin : Navire
    {
        public const int Taille = 1;
        public SousMarin(Case[] carres) : base('S', carres, Taille)
        {
                
        }
    }
}
