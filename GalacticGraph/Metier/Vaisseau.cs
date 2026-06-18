using GalacticGraph.Metier.Cartes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalacticGraph.Metier
{
    /// <summary>
    /// Classe représentant un vaisseau sur la carte
    /// </summary>
    public class Vaisseau
    {
        #region --- Attributs ---
        private Coordonnees coordonnees;
        private List<Direction> ordres;
        #endregion

        #region --- Propriétés ---
        /// <summary>
        /// Coordonnées actuelles du vaisseau sur la carte
        /// </summary>
        public Coordonnees Coordonnees => this.coordonnees;

        /// <summary>
        /// Indique si le vaisseau a des ordres à réaliser
        /// </summary>
        public bool HasOrdres
        {
            get { return this.ordres.Count > 0; }
        }
        #endregion

        #region --- Constructeur ---
        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        /// <param name="coordonnees">Les coordonnées initiales du vaisseau</param>
        public Vaisseau(Coordonnees coordonnees)
        {
            this.coordonnees = coordonnees;
            this.ordres = new List<Direction>();
        }
        #endregion

        #region --- Méthodes ---
        /// <summary>
        /// Ajoute une liste d'ordres à réaliser au vaisseau
        /// </summary>
        /// <param name="nouveauxOrdres">La liste des ordres à ajouter</param>
        public void AjouterOrdres(List<Direction> nouveauxOrdres)
        {
            this.ordres.AddRange(nouveauxOrdres);
        }

        /// <summary>
        /// Déplace le vaisseau dans la direction donnée
        /// </summary>
        /// <param name="direction">La direction du déplacement</param>
        private void Deplacer(Direction direction)
        {
            this.coordonnees = this.coordonnees.GetVoisin(direction);
        }

        /// <summary>
        /// Exécute le premier ordre, le retire de la liste et renvoie la direction réalisée
        /// </summary>
        /// <returns>La direction exécutée</returns>
        public Direction ExecuterOrdre()
        {
            Direction direction = this.ordres[0];
            this.ordres.RemoveAt(0);
            this.Deplacer(direction);
            return direction;
        }
        #endregion
    }
}