using System;

namespace BatailleNavale
{
    class Navire : INavire
    {
        public int Type { get; }
        public bool Coule { get => EstCoule(); }

        private readonly Case[] cases;

        public Navire (int type, Case[] carres)
        {
            Type = type;
            cases = carres;

            foreach (Case carre in cases)
            {
                carre.Navire = this;
            }
        }

        public bool EstCoule()
        {
            foreach (Case carre in cases)
            {
                if (!carre.Touche) return false;
            }
            return true;
        }
    }
}
