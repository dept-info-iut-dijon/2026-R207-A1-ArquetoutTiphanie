using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalacticGraph.Metier.Cartes.Terrains.Realisations
{
    public class TerrainInconnu : Terrain
    {
        public override TypeTerrain Type => TypeTerrain.INCONNU;
        public override bool EstAccessible => true;
        public override string ToString() => "X";
    }
}
