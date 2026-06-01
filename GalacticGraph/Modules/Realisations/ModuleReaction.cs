using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalacticGraph.Modules.Realisations
{
    /// <summary>
    /// Module en charge des réactions aux réponses de l'IA
    /// </summary>
    public class ModuleReaction : Module
    {
        #region --- Attributs ---
        #endregion

        #region --- Propriétés ---
        #endregion

        #region --- Constructeur ---
        public ModuleReaction(IA ia) : base(ia)
        {
        }
        #endregion

        #region --- Méthodes ---
        /// <summary>
        /// Méthode réagissant à la dernière réponse du serveur
        /// </summary>
        /// <param name="messageEnvoye">Dernier message envoyé au serveur par l'IA</param>
        /// <param name="messageRecu">Réponse du serveur à ce message</param>
        public void ReagirAuMessageRecu(string messageEnvoye, string messageRecu)
        {
           
        }
        #endregion
    }
}
