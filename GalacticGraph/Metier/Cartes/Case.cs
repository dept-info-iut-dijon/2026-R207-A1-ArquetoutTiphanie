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
        #endregion

        #region --- Constructeur ---
        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        /// <param name="terrain">Le terrain de la case</param>
        public Case(Terrain terrain)
        {
            this.terrain = terrain;
        }
        #endregion

        #region --- Méthodes ---
        public override string ToString()
        {
            return this.terrain.ToString();
        }
        #endregion
    }
}