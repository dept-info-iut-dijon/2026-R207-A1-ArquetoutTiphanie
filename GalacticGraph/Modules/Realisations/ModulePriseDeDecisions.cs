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
            this.ArreterLaCommunication();
            return "FIN";
        }
        #endregion
    }
}
