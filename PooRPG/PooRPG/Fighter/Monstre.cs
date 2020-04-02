using System;
using System.Collections.Generic;
using System.Text;

namespace PooRPG.Fighter
{
    class Monstre:Personnage
    {
        public Arme Arme;
        public Personnage personnage;

        public int Protect()
        {
            return personnage.vie += 25;
        }
    }
}
