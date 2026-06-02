using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalacticGraph.Metier.Cartes;
using System.Collections.Generic;

namespace GalacticGraph.Metier.Algorithmes
{
    /// <summary>
    /// Classe abstraite représentant un algorithme de calcul de distance
    /// </summary>
    public abstract class AlgorithmeCalculDistance
    {
        #region --- Attributs ---
        private Carte carte;
        private Dictionary<Case, int> distances;
        #endregion

        #region --- Constructeur ---
        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        /// <param name="carte">La carte du jeu</param>
        public AlgorithmeCalculDistance(Carte carte)
        {
            this.carte = carte;
            this.distances = new Dictionary<Case, int>();
        }
        #endregion

        #region --- Méthodes ---
        /// <summary>
        /// Fixe la distance d'une case à une valeur donnée
        /// </summary>
        /// <param name="position">La case dont on fixe la distance</param>
        /// <param name="valeur">La distance à fixer</param>
        protected void SetDistance(Case position, int valeur)
        {
            this.distances[position] = valeur;
        }

        /// <summary>
        /// Renvoie la distance d'une case, ou -1 si elle n'est pas dans le dictionnaire
        /// </summary>
        /// <param name="position">La case dont on veut la distance</param>
        /// <returns>La distance ou -1</returns>
        public int GetDistance(Case position)
        {
            if (this.distances.ContainsKey(position))
                return this.distances[position];
            return -1;
        }

        /// <summary>
        /// Vide le dictionnaire des distances
        /// </summary>
        protected void ReinitialisationDistances()
        {
            this.distances.Clear();
        }

        /// <summary>
        /// Calcule les distances depuis la case de départ donnée
        /// </summary>
        /// <param name="depart">La case de départ</param>
        public abstract void CalculerDistancesDepuis(Case depart);

        public abstract List<Direction> GetChemin(Case arrivee);

        #endregion
    }
}

