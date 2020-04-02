using System;
using System.Collections.Generic;
using System.Text;

namespace PooRPG
{
    class Arme: IActions // l'interface actions va implémenter à la class Arme ses méthodes qui vont donc utiliser les variables de cette classe 
    {
        public Personnage personnage;
        

        public int LanceFleches()
        {
            return personnage.vie-= 17;
        }

        public int Magicboom()
        {
            return personnage.vie -= 70;
        }
            public int Protect()
        {
            return personnage.vie += 25;
        }

        public int Soigner()
        {
            return personnage.vie += 50;
        }

        public int Swords()
        {
            return personnage.vie -= 25;
        }
    }
}
