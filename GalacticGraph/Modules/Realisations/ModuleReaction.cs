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
        /// Réagit au dernier message reçu du serveur
        /// </summary>
        /// <param name="messageEnvoye">Le dernier message envoyé par l'IA</param>
        /// <param name="messageRecu">La réponse du serveur</param>
        public void ReagirAuMessageRecu(string messageEnvoye, string messageRecu)
        {
            switch (messageEnvoye)
            {
                case "CARTE":
                    ReactionCarte(messageRecu);
                    break;
                case "CREER":
                    ReactionCreationVaisseau();
                    break;
            }
        }

        /// <summary>
        /// Génère la carte à partir de la réponse du serveur
        /// </summary>
        /// <param name="messageRecu">Le message contenant la carte</param>
        private void ReactionCarte(string messageRecu)
        {
            this.ModuleMemoire.GenererCarte(messageRecu);
        }

        /// <summary>
        /// Génère le vaisseau à la position de la base
        /// </summary>
        private void ReactionCreationVaisseau()
        {
            this.ModuleMemoire.GenererVaisseau();
        }
        #endregion
    }
}
