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
        #endregion

        #region --- Propriétés ---
        /// <summary>
        /// Coordonnées actuelles du vaisseau sur la carte
        /// </summary>
        public Coordonnees Coordonnees => this.coordonnees;
        #endregion

        #region --- Constructeur ---
        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        /// <param name="coordonnees">Les coordonnées initiales du vaisseau</param>
        public Vaisseau(Coordonnees coordonnees)
        {
            this.coordonnees = coordonnees;
        }
        #endregion
    }
}
