using System;
using System.Collections.Generic;
using System.Text;

namespace PooRPG
{
    class Soigneur : Personnage
    {
        public Arme Arme;
        public Personnage personnage;

        public int Soigner()
        {
            return personnage.vie += 50;
        }
    }
}
