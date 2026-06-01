using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace GalacticGraph.Metier.Cartes
{
    /// <summary>
    /// Classe représentant la carte du jeu
    /// </summary>
    public class Carte
    {
        #region --- Attributs ---
        private int hauteur;
        private int largeur;
        private Dictionary<Coordonnees, Case> cases;
        #endregion

        #region --- Constructeur ---
        /// <summary>
        /// Constructeur initialisant la carte
        /// </summary>
        /// <param name="messageRecu">Message reçu du serveur (non utilisé pour l'instant)</param>
        public Carte(string messageRecu)
        {
            this.hauteur = 40;
            this.largeur = 80;
            this.cases = new Dictionary<Coordonnees, Case>();

            for (int ligne = 0; ligne < this.hauteur; ligne++)
                for (int colonne = 0; colonne < this.largeur; colonne++)
                    this.AjouterCase(messageRecu[colonne + this.largeur * ligne], new Coordonnees(ligne, colonne));

            this.AffichageConsole();
        }
        #endregion

        #region --- Méthodes ---
        /// <summary>
        /// Crée une case et l'ajoute au dictionnaire
        /// </summary>
        private void AjouterCase(char caractere, Coordonnees coordonnees)
        {
            this.cases[coordonnees] = FabriqueCase.Creer(caractere);
        }

        private void AffichageConsole()
        {
            Console.WriteLine();
            Console.WriteLine("---- AFFICHAGE DE LA CARTE ----");
            Console.WriteLine();
            for (int ligne = 0; ligne < this.hauteur; ligne++)
            {
                for (int colonne = 0; colonne < this.largeur; colonne++)
                {
                    Case c = this.cases[new Coordonnees(ligne, colonne)];
                    Console.Write(c.ToString());
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("-------------------------------");
        }

        #endregion
    }
}