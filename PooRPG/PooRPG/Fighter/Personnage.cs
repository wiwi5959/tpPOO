using System;
using System.Collections.Generic;
using System.Text;

namespace PooRPG
{
    class Personnage
    {
        public string nom;
        public int vie;
        public int attaque;


        public Personnage()
        {

        }
        public Personnage(int vie, string nom)
        {

        }
        public void SetVie(int vie)
        {
            this.vie = vie;
        }

        public void SetNom(string nom)
        {
            this.nom = nom;
        }
        public int GetVie()
        {
            int result = this.vie;
            return result;
        }
        public string GetNom()
        {
            string result = this.nom;
            return result;
        }

    }
}

