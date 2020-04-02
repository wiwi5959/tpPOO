using System;
using System.Collections.Generic;
using System.Text;

namespace PooRPG
{
    
    class Mage :Personnage
    {
        public Arme Arme;
        public Personnage personnage;

        public int Magicboom()
        {
            return personnage.vie -= 70;
        }
    }
}
