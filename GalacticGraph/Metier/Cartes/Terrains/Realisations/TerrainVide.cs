using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalacticGraph.Metier.Cartes.Terrains.Realisations
{
    public class TerrainVide : Terrain
    {
        public override TypeTerrain Type => TypeTerrain.VIDE;
        public override bool EstAccessible => true;
        public override string ToString() => " ";
    }
}
