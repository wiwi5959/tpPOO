using System;
using System.Collections.Generic;
using System.Text;

namespace PooRPG
{
    class Archer : Personnage 
    {
            public Arme Arme;
            public Personnage personnage;

        public int LanceFleches()
        {
            return personnage.vie -= 17;
        }

    }
}


