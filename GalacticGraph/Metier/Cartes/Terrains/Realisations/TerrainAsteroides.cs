using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalacticGraph.Metier.Cartes.Terrains.Realisations
{
    public class TerrainAsteroides : Terrain
    {
        public override TypeTerrain Type => TypeTerrain.ASTEROIDES;
        public override string ToString() => "A";
    }
}
