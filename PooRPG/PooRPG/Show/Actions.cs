using System;
using System.Collections.Generic;
using System.Text;

namespace PooRPG
{
    interface IActions// on crée une interface et on y met les signatures des méthodes qui vont implémenter la classe Arme
    {
        public int LanceFleches(); 
        public int Swords();
        public int Soigner();
        public int Protect();
        public int Magicboom();
    }
}
