using GalacticGraph.Metier.Cartes;
using System.Collections.Generic;

namespace GalacticGraph.Metier.Algorithmes
{
    /// <summary>
    /// Implémentation de l'algorithme de Dijkstra pour le calcul
    /// du plus court chemin dans un graphe pondéré
    /// </summary>
    public class Dijkstra : AlgorithmeCalculDistance
    {
        #region --- Attributs ---
        /// <summary>
        /// Dictionnaire indiquant si une case a déjà été visitée
        /// </summary>
        private Dictionary<Case, bool> estVisite;

        /// <summary>
        /// Dictionnaire mémorisant le prédécesseur de chaque case dans le chemin trouvé
        /// </summary>
        private Dictionary<Case, Case> predecesseur;
        #endregion

        #region --- Constructeur ---
        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        /// <param name="carte">La carte du jeu</param>
        public Dijkstra(Carte carte) : base(carte)
        {
            this.estVisite = new Dictionary<Case, bool>();
            this.predecesseur = new Dictionary<Case, Case>();
        }
        #endregion

        #region --- Méthodes privées ---
        /// <summary>
        /// Renvoie si la case a déjà été visitée ou non
        /// Renvoie faux si la case n'est pas dans le dictionnaire
        /// </summary>
        private bool EstVisite(Case c)
        {
            if (this.estVisite.ContainsKey(c))
                return this.estVisite[c];
            return false;
        }

        /// <summary>
        /// Renvoie le prédécesseur de la case c dans le chemin trouvé
        /// Renvoie null si la case n'est pas dans le dictionnaire
        /// </summary>
        private Case? Predecesseur(Case c)
        {
            if (this.predecesseur.ContainsKey(c))
                return this.predecesseur[c];
            return null;
        }

        /// <summary>
        /// Réinitialise les distances et les dictionnaires,
        /// puis fixe la distance de la case de départ à 0
        /// </summary>
        private void Initialisation(Case depart)
        {
            this.ReinitialisationDistances();
            this.estVisite.Clear();
            this.predecesseur.Clear();
            this.SetDistance(depart, 0);
        }

        /// <summary>
        /// Relâche l'arc entre A et B :
        /// met à jour la distance de B si on trouve un meilleur chemin via A
        /// </summary>
        private void Relachement(Case a, Case b)
        {
            if (this.GetDistance(b) == -1 || this.GetDistance(b) > this.GetDistance(a) + b.CoutDeplacement)
            {
                this.SetDistance(b, this.GetDistance(a) + b.CoutDeplacement);
                this.predecesseur[b] = a;
            }
        }

        /// <summary>
        /// Renvoie la case non encore visitée ayant la plus petite distance
        /// Renvoie null si toutes les cases ont été visitées ou ont une distance de -1
        /// </summary>
        private Case? CaseNonVisiteDeDistanceMinimale()
        {
            Case? res = null;
            int distanceMin = -1;

            foreach (Case c in this.GetCases())
            {
                if (!this.EstVisite(c) && this.GetDistance(c) != -1)
                {
                    if (distanceMin == -1 || this.GetDistance(c) < distanceMin)
                    {
                        res = c;
                        distanceMin = this.GetDistance(c);
                    }
                }
            }

            return res;
        }
        #endregion

        #region --- Méthodes publiques ---
        /// <summary>
        /// Calcule les distances depuis la case de départ
        /// en utilisant l'algorithme de Dijkstra
        /// S'arrête dès qu'une case inconnue est considérée
        /// </summary>
        public override void CalculerDistancesDepuis(Case depart)
        {
            this.Initialisation(depart);

            Case? caseSuivante;
            while ((caseSuivante = CaseNonVisiteDeDistanceMinimale()) != null && !caseSuivante.EstInconnue)
            {
                this.estVisite[caseSuivante] = true;

                foreach (Case voisin in caseSuivante.Voisins)
                {
                    if (voisin.EstAccessible)
                        this.Relachement(caseSuivante, voisin);
                }
            }
        }

        /// <summary>
        /// Renvoie le chemin depuis le départ jusqu'à la case arrivée
        /// sous forme d'une liste de directions à suivre
        /// </summary>
        public override List<Direction> GetChemin(Case arrivee)
        {
            List<Direction> chemin = new List<Direction>();
            Case? courant = arrivee;

            while (this.Predecesseur(courant) != null)
            {
                Case pred = this.Predecesseur(courant)!;
                chemin.Insert(0, pred.Coordonnees.GetDirectionPourAllerEn(courant.Coordonnees));
                courant = pred;
            }

            return chemin;
        }
        #endregion
    }
}