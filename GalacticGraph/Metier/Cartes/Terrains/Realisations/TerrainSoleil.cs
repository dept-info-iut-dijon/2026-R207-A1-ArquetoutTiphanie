using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalacticGraph.Metier.Cartes.Terrains.Realisations
{
    public class TerrainSoleil : Terrain
    {
        public override TypeTerrain Type => TypeTerrain.SOLEIL;
        public override string ToString() => "S";
    }
}
