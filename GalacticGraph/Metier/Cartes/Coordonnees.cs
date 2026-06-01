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

        /// <summary>
        /// Renvoie les coordonnées de la case voisine dans la direction donnée
        /// </summary>
        /// <param name="direction">La direction souhaitée</param>
        /// <returns>Les coordonnées de la case voisine</returns>
        public Coordonnees GetVoisin(Direction direction)
        {
            // Ligne paire
            if (this.Ligne % 2 == 0)
            {
                switch (direction)
                {
                    case Direction.GAUCHE: return new Coordonnees(Ligne, Colonne - 1);
                    case Direction.DROITE: return new Coordonnees(Ligne, Colonne + 1);
                    case Direction.HAUTGAUCHE: return new Coordonnees(Ligne - 1, Colonne - 1);
                    case Direction.HAUTDROITE: return new Coordonnees(Ligne - 1, Colonne);
                    case Direction.BASGAUCHE: return new Coordonnees(Ligne + 1, Colonne - 1);
                    case Direction.BASDROITE: return new Coordonnees(Ligne + 1, Colonne);
                    default: return null;
                }
            }
            // Ligne impaire
            else
            {
                switch (direction)
                {
                    case Direction.GAUCHE: return new Coordonnees(Ligne, Colonne - 1);
                    case Direction.DROITE: return new Coordonnees(Ligne, Colonne + 1);
                    case Direction.HAUTGAUCHE: return new Coordonnees(Ligne - 1, Colonne);
                    case Direction.HAUTDROITE: return new Coordonnees(Ligne - 1, Colonne + 1);
                    case Direction.BASGAUCHE: return new Coordonnees(Ligne + 1, Colonne);
                    case Direction.BASDROITE: return new Coordonnees(Ligne + 1, Colonne + 1);
                    default: return null;
                }
            }
        }

        /// <summary>
        /// Renvoie la direction à suivre pour aller aux coordonnées d'arrivée
        /// </summary>
        /// <param name="coordonneesArrivee">Les coordonnées de la case destination (supposée voisine)</param>
        /// <returns>La direction à suivre</returns>
        public Direction GetDirectionPourAllerEn(Coordonnees coordonneesArrivee)
        {
            // On teste chaque direction jusqu'à trouver celle qui mène aux coordonnées d'arrivée
            foreach (Direction direction in Enum.GetValues(typeof(Direction)))
            {
                if (this.GetVoisin(direction).Equals(coordonneesArrivee))
                    return direction;
            }
            throw new Exception("Les coordonnées données ne sont pas voisines !");
        }
        #endregion
    }
}
