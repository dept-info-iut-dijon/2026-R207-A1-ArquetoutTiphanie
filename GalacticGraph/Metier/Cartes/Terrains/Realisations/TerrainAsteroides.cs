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
        public override bool EstAccessible => true;
        public override string ToString() => "A";

        /// <summary>
        /// Coût de déplacement pour traverser un astéroïde
        /// Vaut 2 car les astéroïdes consomment plus de mouvement
        /// </summary>
        public override int CoutDeplacement => 2;


    }
}
