using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalacticGraph.Metier.Cartes.Terrains
{
    /// <summary>
    /// Classe abstraite représentant un terrain
    /// </summary>
    public abstract class Terrain
    {
        /// <summary>
        /// Indique si le terrain est accessible par un vaisseau
        /// </summary>
        public abstract TypeTerrain Type { get; }

        /// <summary>
        /// Indique si le vaisseau peut se déplacer sur ce terrain
        /// </summary>
        public abstract bool EstAccessible { get; }

        /// <summary>
        /// Coût de déplacement pour traverser ce terrain
        /// Vaut 1 par défaut pour un terrain normal
        /// </summary>
        public virtual int CoutDeplacement => 1;
    }
}
