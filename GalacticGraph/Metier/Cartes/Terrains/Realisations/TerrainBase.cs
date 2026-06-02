using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalacticGraph.Metier.Cartes.Terrains.Realisations
{
    public class TerrainBase : Terrain
    {
        public override TypeTerrain Type => TypeTerrain.BASE;
        public override bool EstAccessible => true;
        public override string ToString() => "B";
    }
}
