using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalacticGraph.Metier.Cartes
{
    /// <summary>
    /// Classe représentant les coordonnées d'une case sur la carte
    /// </summary>
    public class Coordonnees
    {
        #region --- Propriétés ---
        /// <summary>Numéro de la ligne</summary>
        public int Ligne { get; }

        /// <summary>Numéro de la colonne</summary>
        public int Colonne { get; }
        #endregion

        #region --- Constructeur ---
        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public Coordonnees(int ligne, int colonne)
        {
            this.Ligne = ligne;
            this.Colonne = colonne;
        }
        #endregion

        #region --- Méthodes ---
        public override bool Equals(object obj)
        {
            return obj is Coordonnees coordonnees &&
                   Ligne == coordonnees.Ligne &&
                   Colonne == coordonnees.Colonne;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Ligne, Colonne);
        }
        #endregion
    }
}
