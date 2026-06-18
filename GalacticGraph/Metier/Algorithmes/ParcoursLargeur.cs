using GalacticGraph.Metier.Cartes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalacticGraph.Metier.Algorithmes
{
    public class ParcoursLargeur : AlgorithmeCalculDistance
    {
        #region --- Constructeur ---
        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        /// <param name="carte">La carte du jeu</param>
        public ParcoursLargeur(Carte carte) : base(carte)
        {
        }
        #endregion

        #region --- Méthodes ---
        /// <summary>
        /// Calcule les distances depuis la case de départ par parcours en largeur
        /// </summary>
        /// <param name="depart">La case de départ</param>
        public override void CalculerDistancesDepuis(Case depart)
        {
            //remettre à zéro les distances
            List<Case> aTraiter = new List<Case>();
            this.ReinitialisationDistances();

            //initilisation de la distance de la case de départ à 0
            aTraiter.Add(depart);
            this.SetDistance(depart, 0);

            while (aTraiter.Count > 0)
            {
                Case caseEnCours = aTraiter[0];
                aTraiter.RemoveAt(0);

                // On parcourt tous les voisins
                foreach (Case v in caseEnCours.Voisins)
                {
                    if (this.GetDistance(v) == -1 && v.EstAccessible)
                    {
                        this.SetDistance(v, this.GetDistance(caseEnCours) + 1);
                        aTraiter.Add(v);
                    }
                }

            }
            
        }

        /// <summary>
        /// Renvoie la séquence de directions pour aller jusqu'à la case arrivée
        /// </summary>
        /// <param name="arrivee">La case de destination</param>
        /// <returns>La liste des directions à suivre</returns>
        public override List<Direction> GetChemin(Case arrivee)
        {
            List<Direction> resultat = new List<Direction>();
            Case caseEnCours = arrivee;

            if (this.GetDistance(caseEnCours) != -1)
            {
                while (this.GetDistance(caseEnCours) > 0)
                {
                    Case casePrecedente = null;
                    foreach (Case v in caseEnCours.Voisins)
                    {
                        if (this.GetDistance(v) == this.GetDistance(caseEnCours) - 1)
                        {
                            casePrecedente = v;
                            break;
                        }
                    }
                    resultat.Add(casePrecedente.GetDirectionPourAllerEn(caseEnCours));
                    caseEnCours = casePrecedente;
                }
                resultat.Reverse();
            }

            return resultat;
        }
        #endregion
    }
}
