using System;
using System.Collections.Generic;
using System.Text;
using PooRPG.Fighter;

namespace PooRPG
{

    static class Jeu
    {
        public static Personnage personnage; // on donne comme champs à notre classe jeu , les objets Personnage et Monstre 
        public static Monstre monstre;

        public static void AfficherInfo() // cette méthode permet uniquement d'afficher la description des objets personnages/monstres 
        {
            Console.WriteLine(personnage.ToString()); // write+line veut dire écrit + à la ligne 
            Console.WriteLine(monstre.ToString()); // il n'y a pas de concaténation , on demande simplement à la console de nous afficher "en chaine de caractères"(ToString) l'objet créé
        }


        public static void StartGame()  // cette méthode va permettre de lancer en une fois  toutes les autres méthodes nécessaires pour le déroulement complet de notre jeu
        {
            personnage = NouveauPersonnage();
            Fight();
        }
        public static Personnage NouveauPersonnage() // cette méthode va renvoyer l'objet personnage ainsi créé
        {
            Console.WriteLine("nom du personnage ");
            return new Personnage(100, Console.ReadLine(),500); // l'ordre des paramètres doit être respecté 

        }

        public static void Fight() // cette méthode va décrire le déroulement de l'affrontement entre nos objets monstres et personnages
        {
            int viemonstre = monstre.vie; 
            int viepersonnage = personnage.vie;
            bool tour = false; // on attribue toujours une valeur False par défaut à notre booléen , pour déterminer "par Tour" l'action des combattants

            while (viepersonnage > 0 && viemonstre > 0) // on créé une boucle while car on ne connaît d'avance la fin du combat , on lui insère une condition
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