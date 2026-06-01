using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalacticGraph.Modules.Realisations
{
    /// <summary>
    /// Module en charge de la prise de décisions pour l'IA
    /// </summary>
    public class ModulePriseDeDecisions : Module
    {
        #region --- Attributs ---
        private static Random hasard = new Random();
        private static string[] directions = { "HAUTDROITE", "HAUTGAUCHE", "GAUCHE", "BASGAUCHE", "BASDROITE", "DROITE" };
        #endregion

        #region --- Propriétés ---
        #endregion

        #region --- Constructeur ---
        public ModulePriseDeDecisions(IA ia) : base(ia)
        {
        }
        #endregion

        #region --- Méthodes ---
        /// <summary>
        /// Méthode déterminant la prochaine action à réaliser
        /// </summary>
        /// <param name="messageRecuDuServeur">Le dernier message reçu du serveur</param>
        /// <returns>Le message à envoyer au serveur</returns>
        public string DeterminerNouvelleAction(string messageRecuDuServeur)
        {
            if (messageRecuDuServeur.StartsWith("OK"))
            {
                string choix = directions[hasard.Next(directions.Length)];
                return $"BOUGER|0|{choix}";
            }
            else if (messageRecuDuServeur == "NOK|Déplacement impossible - La case destination n'existe pas")
            {
                this.ArreterLaCommunication();
                return "FIN";
            }
            else
            {
                return "CREER";
            }
        }
        #endregion
    }
}
