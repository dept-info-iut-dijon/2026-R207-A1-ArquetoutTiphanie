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
        private Coordonnees coordonneesBase;
        #endregion

        #region --- Propriétés ---
        /// <summary>
        /// Coordonnées de la base sur la carte
        /// </summary>
        public Coordonnees CoordonneesBase => this.coordonneesBase;
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

            for (int ligne = 0; ligne < this.hauteur; ligne++)
            {
                for (int colonne = 0; colonne < this.largeur; colonne++)
                {
                    Coordonnees cooCase = new Coordonnees(ligne, colonne);
                    foreach (Direction direction in Enum.GetValues(typeof(Direction)))
                    {
                        Coordonnees cooVoisin = cooCase.GetVoisin(direction);
                        if (this.cases.ContainsKey(cooVoisin))
                        {
                            this.cases[cooCase].AjouterVoisin(this.cases[cooVoisin]);
                        }
                    }
                }
            }

            this.AffichageConsole();
        }
        #endregion

        #region --- Méthodes ---
        /// <summary>
        /// Crée une case à partir d'un caractère et l'ajoute au dictionnaire.
        /// Mémorise les coordonnées si la case est une base.
        /// </summary>
        /// <param name="caractere">Le caractère représentant le type de case</param>
        /// <param name="coordonnees">Les coordonnées de la case</param>
        private void AjouterCase(char caractere, Coordonnees coordonnees)
        {
            this.cases[coordonnees] = FabriqueCase.Creer(caractere);

            // On mémorise les coordonnées de la base
            if (caractere == 'B')
                this.coordonneesBase = coordonnees;
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

        /// <summary>
        /// Renvoie la case aux coordonnées données, ou null si elle n'existe pas
        /// </summary>
        /// <param name="coordonnees">Les coordonnées de la case recherchée</param>
        /// <returns>La case correspondante ou null</returns>
        public Case? GetCaseAt(Coordonnees coordonnees)
        {
            if (this.cases.ContainsKey(coordonnees))
                return this.cases[coordonnees];
            return null;
        }
        #endregion
    }
}