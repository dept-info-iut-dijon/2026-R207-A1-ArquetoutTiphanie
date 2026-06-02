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
        public static Case Creer(int ligne, int colonne, char caractere)
        {
            Terrain terrain = FabriqueTerrain.Creer(caractere);
            Coordonnees coordonnees = new Coordonnees(ligne, colonne);
            return new Case(terrain, coordonnees);
        }
    }
}
