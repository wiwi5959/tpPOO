using System;
using System.Collections.Generic;
using System.Text; // using signifie import , il s'agit d'importer le code nécessaire pour notre programme

namespace PooRPG // l'espace de noms ou package(enJava) est un répertoire permettant de classer correctement le code
{
    class Personnage  // cette classe(schéma) est celle des personnages de notre jeu
    {
        public string nom;   // Ceci est le champs/variable d'instance "nom"(string , chaîne de caractères de la classe parmi les autres champs en entier(int)
        public int vie;
        public int attaque; // on n'a pas donné volontairement de valeur aux champs dès maintenant , elles seront données dans la méthode NouveauPersonnage de la classe Jeu


        public Personnage()  // ceci est le constructeur implicite que l'on écrit pour le rendre "explicite"
        {

        }
        public Personnage(int vie, string nom, int attaque) // ceci est le constructeur qui prend en compte donc pour la création des objets en paramètre les champs ci-dessus
        {

        }
        public void SetVie(int vie) // ceci est la 1ère écriture/ligne de coe /signature de la méthode nommée SetVie de type publique, qui ne retourne rien (void) et qui prend en paramètre le champs vie
        {
            this.vie = vie; // "this"  veut dire que l'on fait référence à la variable de l'instance de la classe Personnage
        }

        public void SetNom(string nom) // Set est un mutateur c'est à dire que cette méthode permet de modifier la valeur du champs
        {
            this.nom = nom;
        }
        public void SetVieSetAttaque(int attaque)
        {
            this.attaque = attaque;
        }
        public int GetVie() // Get est un accesseur c'est à dire que cette méthode permet d'obtenir la variable du champs
        {
            int result = this.vie;
            return result;
        }
        public string GetNom() // les méthodes Get/Set sont utilisées pour sécuriser légèrement et manuellement le travail entre développeurs uniquement
        {
            string result = this.nom; // par exemple , on pourrait rajouter une condition qui imposait une contrainte sur un nombre minimal ou maximal de caractère pour un nom 
            return result;
        }
        public int GetAttaque()
        {
            int result = this.attaque;
            return result;
        }
        public override string ToString()// la méthode ToString est une méthode qui permet de concaténer les variables en plus d'afficher des chaînes de caractères, contrairement au simple affichage réalisé avec un console.writeline
        {
            string info = "ton nom est " + this.GetNom() + " et ton attaque a " + this.GetAttaque() + " ta vie est de " + this.GetVie();
            return info;
        }

    }
}

