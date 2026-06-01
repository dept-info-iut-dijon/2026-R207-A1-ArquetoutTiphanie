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
        /// <summary>Type du terrain</summary>
        public abstract TypeTerrain Type { get; }
    }
}
