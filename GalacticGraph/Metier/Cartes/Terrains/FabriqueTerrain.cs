using GalacticGraph.Metier.Cartes.Terrains.Realisations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalacticGraph.Metier.Cartes.Terrains
{
    public class FabriqueTerrain
    {
        /// <summary>
        /// Crée un terrain en fonction du caractère reçu du serveur
        /// </summary>
        /// <param name="caractere">Caractère représentant le type de terrain (protocole réseau)</param>
        /// <returns>Un terrain du bon type</returns>
        public static Terrain Creer(char caractere)
        {
            switch (caractere)
            {
                case 'V': return new TerrainVide();
                case 'A': return new TerrainAsteroides();
                case 'B': return new TerrainBase();
                case 'S': return new TerrainSoleil();
                case 'P': return new TerrainPlanete();
                default: return new TerrainInconnu(); 
            }
        }
    }
}