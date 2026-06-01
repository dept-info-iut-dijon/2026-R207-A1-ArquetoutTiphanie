using GalacticGraph.Modules.Realisations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalacticGraph.Modules
{
    /// <summary>
    /// Classe abstrait représentant un module de l'IA
    /// </summary>
    public abstract class Module
    {
        #region --- Attributs ---
        private IA ia;  //L'IA dont dépend le module
        #endregion


        #region --- Propriétés ---
        /// <summary>
        /// Module en charge de la communication avec le serveur
        /// </summary>
        protected ModuleCommunication ModuleCommunication => this.ia.ModuleCommunication;
        /// <summary>
        /// Module en charge de la sauvegarde des informations
        /// </summary>
        protected ModuleMemoire ModuleMemoire => this.ia.ModuleMemoire;
        /// <summary>
        /// Module en charge de la prise de décisions
        /// </summary>
        protected ModulePriseDeDecisions ModulePriseDeDecisions => this.ia.ModulePriseDeDecisions;
        /// <summary>
        /// Module en charge des réactions aux réponses du serveur
        /// </summary>
        protected ModuleReaction ModuleReaction => this.ia.ModuleReaction;
        #endregion

        #region --- Constructeur ---
        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        /// <param name="ia">IA dont dépend le module</param>
        public Module(IA ia)
        {
            this.ia = ia;
        }
        #endregion

        #region --- Méthodes ---
        /// <summary>
        /// Demande à l'IA de s'arrêter
        /// </summary>
        protected void ArreterLaCommunication()
        {
            this.ia.ArreterLaCommunication();
        }
        #endregion
    }
}
