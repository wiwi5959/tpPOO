using System;
using System.Collections.Generic;
using System.Text;

namespace PooRPG
{
    class Arme: IActions // l'interface actions va implémenter à la class Arme ses méthodes qui vont donc utiliser les variables de cette classe 
    {
        public int epee;
        public int bouclier;
        public int sort;
        public int fleche;
        public int soin;


        public int LanceFleches()
        {
            throw new NotImplementedException();
        }

        public int Magicboom()
        {
            throw new NotImplementedException();
        }

        public int Protect()
        {
            throw new NotImplementedException();
        }

        public int Soigner()
        {
            throw new NotImplementedException();
        }

        public int Swords()
        {
            throw new NotImplementedException();
        }
    }
}
