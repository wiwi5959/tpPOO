using System;
using System.Collections.Generic;
using System.Text;

namespace PooRPG
{
    class Guerrier: Personnage
    {

        public Arme Arme;
        public Personnage personnage;

        public int Swords()
        {
            return personnage.vie -= 25;
        }
    }
}
