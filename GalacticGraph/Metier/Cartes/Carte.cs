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
        }
        #endregion
    }
}