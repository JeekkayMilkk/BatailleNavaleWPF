﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatailleNavale
{
    class Cuirasse : Navire
    {
        private const int _taille = 4;
        public Cuirasse(Case[] carres) : base(_taille, carres)
        {

        }
    }
}
