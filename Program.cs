using System;
namespace Recherche1
{
    class Program
    {
        // Méthode principale de l’application, point d'entrée de l'exécution.
        static void Main(string[] args)
        {
            // Déclaration des variables nécessaires pour l’application.
            int Cnt = 0; // Compteur pour parcourir les tableaux
            bool Trouve = false; // Indicateur si le nom de l'étudiant a été trouvé
            string Test = ""; // Variable pour stocker le nom de l'étudiant saisi par l'utilisateur

            // Déclaration et initialisation des tableaux contenant les noms et les moyennes des étudiants.
            string[] Noms = new string[] { "Marc", "Martine", "François", "Charlotte",
 "Daniel", "Patricia", "Gregory", "Yves", "Louise",
 "Carl" };
            int[] Moyennes = new int[] { 95, 78, 65, 88, 90, 85, 66, 86, 90, 75 };

            // Récupération de la saisie du nom de l'étudiant que l’utilisateur désire trouver.
            Console.Write("Donnez-moi le nom de l'étudiant recherché : ");
            Test = Console.ReadLine().ToLower(); // Conversion de la saisie en minuscules pour la comparaison

            // Code manquant pour parcourir les tableaux et vérifier si le nom saisi correspond à un nom dans le tableau 'Noms'

            // La ligne suivante permet de maintenir la console ouverte jusqu'à ce qu'une touche soit pressée.
            // Utile surtout lors de l'exécution depuis un environnement de développement pour voir le résultat.
            Console.ReadKey();
        }
    }
}
