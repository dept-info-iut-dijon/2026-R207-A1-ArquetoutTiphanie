using GalacticGraph.Metier.Cartes.Terrains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalacticGraph.Metier.Cartes
{
    /// <summary>
    /// Classe représentant une case de la carte
    /// </summary>
    public class Case
    {
        #region --- Attributs ---
        private Terrain terrain;
        private List<Case> voisins;
        private Coordonnees coordonnees;
        #endregion

        #region --- Propriétés ---
        /// <summary>
        /// Tableau des cases voisines de cette case
        /// </summary>
        public Case[] Voisins => this.voisins.ToArray();

        /// <summary>
        /// Indique si la case est accessible par un vaisseau
        /// </summary>
        public bool EstAccessible => this.terrain.EstAccessible;

        /// <summary>
        /// Retourne les coordonnées de la case
        /// </summary>
        public Coordonnees Coordonnees
        {
            get { return this.coordonnees; }
        }
        public bool EstInconnue => this.terrain.Type == TypeTerrain.INCONNU;

        /// <summary>
        /// Détermine si la case a un voisin dont le terrain est inconnu
        /// </summary>
        /// <returns>True si un voisin est inconnu, False sinon</returns>
        public bool HasVoisinInconnu()
        {
            foreach (Case voisin in this.voisins)
            {
                if (voisin.EstInconnue)
                    return true;
            }
            return false;
        }
        #endregion

        #region --- Constructeur ---
        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        /// <param name="terrain">Le terrain de la case</param>
        public Case(Terrain terrain, Coordonnees coordonnees)
        {
            this.coordonnees = coordonnees;
            this.terrain = terrain;
            this.voisins = new List<Case>();
        }
        #endregion

        #region --- Méthodes ---
        /// <summary>
        /// Ajoute une case voisine à la liste des voisins
        /// </summary>
        /// <param name="voisin">La case voisine à ajouter</param>
        public void AjouterVoisin(Case voisin)
        {
            this.voisins.Add(voisin);
        }

        /// <summary>
        /// Renvoie la représentation textuelle du terrain de la case
        /// </summary>
        public override string ToString()
        {
            return this.terrain.ToString();
        }

        public Direction GetDirectionPourAllerEn(Case caseArrivee)
        {
            return this.coordonnees.GetDirectionPourAllerEn(caseArrivee.Coordonnees);
        }
        #endregion
    }
}