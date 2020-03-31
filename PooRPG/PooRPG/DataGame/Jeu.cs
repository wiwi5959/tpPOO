using System;
using System.Collections.Generic;
using System.Text;
using PooRPG.Fighter;

namespace PooRPG
{

    static class Jeu
    {
        public static Personnage personnage;
        public static Monstre monstre;


        public static Personnage NouveauPersonnage()
        {
            Console.Write("nom du personnage ");
            return new Personnage(100, Console.ReadLine());

        }

        public static void Fight()
        {
            int viemonstre = monstre.vie;
            int viepersonnage = personnage.vie;
            bool tour = false;

            while (viepersonnage > 0 && viemonstre > 0)
            {
                if (tour == true)
                {

                    tour = false;
                    Console.WriteLine(monstre.nom + " lance une attaque sur " + personnage.nom + " et inflige des dégats");
                    viepersonnage -= monstre.attaque;
                    Console.WriteLine(personnage.nom + " détient désormais " + viepersonnage + " points de vie");


                }
                else if (tour == false)
                {
                    tour = true;
                    Console.WriteLine(personnage.nom + " lance une attaque sur " + monstre.nom + " et inflige des dégats");
                    viemonstre -= personnage.attaque;
                    Console.WriteLine(monstre.nom + " détient désormais " + viemonstre + " points de vie ");
                }


                if (viepersonnage == 0)
                {
                    Console.WriteLine(monstre.nom + " a gagné le combat");
                }
                else if (viemonstre == 0)
                {
                    Console.WriteLine(personnage.nom + " a gagné le combat");
                }
            }

        }
    }
}