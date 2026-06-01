using GalacticGraph.Metier.Cartes.Terrains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalacticGraph.Metier.Cartes
{
    /// <summary>
    /// Fabrique permettant de créer une case à partir d'un caractère
    /// </summary>
    public class FabriqueCase
    {
        /// <summary>
        /// Crée une case en fonction du caractère reçu du serveur
        /// </summary>
        /// <param name="caractere">Le caractère représentant le type de case</param>
        /// <returns>Une case avec le bon terrain</returns>
        public static Case Creer(char caractere)
        {
            Terrain terrain = FabriqueTerrain.Creer(caractere);
            Case laCase = new Case(terrain);
            return laCase;
        }
    }
}
