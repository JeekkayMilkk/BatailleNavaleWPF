using System;

namespace BatailleNavale
{
    class Navire : INavire
    {
        public int Longueur { get; }
        public char Type { get; }
        public bool Coule { get => EstCoule(); }

        private readonly Case[] cases;

        public Navire (char type, Case[] carres, int longueur)
        {
            Type = type;
            cases = carres;
            Longueur = longueur;

            foreach (Case carre in cases)
            {
                carre.Navire = this;
            }
        }

        private bool EstCoule()
        {
            foreach (Case carre in cases)
            {
                if (!carre.Touche) return false;
            }
            return true;
        }
    }
}
