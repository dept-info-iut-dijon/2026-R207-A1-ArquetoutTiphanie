using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalacticGraph.Metier.Cartes;

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
        private int distanceMinCaseInconnue;
        private Case? caseInconnueLaPlusProche;
        #endregion

        #region --- Propriétés ---
        /// <summary>
        /// Retourne la case inconnue la plus proche du point de départ
        /// </summary>
        public Case? CaseInconnueLaPlusProche
        {
            get { return this.caseInconnueLaPlusProche; }
        }
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
            this.distanceMinCaseInconnue = 80 * 40 * 3 + 1;
            this.caseInconnueLaPlusProche = null;
        }
        #endregion

        #region --- Méthodes ---
        /// <summary>
        /// Fixe la distance d'une case en mettant à jour la case inconnue la plus proche
        /// </summary>
        protected void SetDistance(Case position, int valeur)
        {
            this.distances[position] = valeur;

            if (position.EstInconnue && this.Heuristique(position, valeur) < this.distanceMinCaseInconnue)
            {
                this.distanceMinCaseInconnue = this.Heuristique(position, valeur);
                this.caseInconnueLaPlusProche = position;
            }
        }

        /// <summary>
        /// Renvoie la distance d'une case, ou -1 si elle n'est pas dans le dictionnaire
        /// </summary>
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
            this.distanceMinCaseInconnue = 80 * 40 * 3 + 1;
            this.caseInconnueLaPlusProche = null;
        }

        /// <summary>
        /// Renvoie la somme de valeur et de la distance de Chebyshev entre position et la base
        /// </summary>
        private int Heuristique(Case position, int valeur)
        {
            Case caseBase = this.carte.GetCaseAt(this.carte.CoordonneesBase);
            return valeur + position.DistanceChebyshevVers(caseBase);
        }

        /// <summary>
        /// Calcule les distances depuis la case de départ donnée
        /// </summary>
        public abstract void CalculerDistancesDepuis(Case depart);

        public abstract List<Direction> GetChemin(Case arrivee);

        /// <summary>
        /// Renvoie l'ensemble des cases de la carte
        /// Délègue à la méthode GetCases de la carte
        /// </summary>
        protected Case[] GetCases()
        {
            return this.carte.GetCases();
        }
        #endregion
    }
}