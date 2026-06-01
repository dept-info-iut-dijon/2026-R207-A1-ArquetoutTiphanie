using GalacticGraph.Modules.Realisations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalacticGraph
{
    /// <summary>
    /// Classe représentant le coeur de l'IA. Elle joue le rôle de "médiateur" entre les différents modules
    /// </summary>
    public class IA
    {
        #region --- Attributs ---
        private ModuleCommunication moduleCommunication;
        private ModuleMemoire moduleMemoire;
        private ModulePriseDeDecisions modulePriseDeDecisions;
        private ModuleReaction moduleReaction;

        private bool aFiniDeCommuniquer;
        #endregion

        #region --- Propriétés ---
        /// <summary>
        /// Module en charge de la communication avec le serveur
        /// </summary>
        public ModuleCommunication ModuleCommunication => this.moduleCommunication;
        /// <summary>
        /// Module en charge de la sauvegarde des informations
        /// </summary>
        public ModuleMemoire ModuleMemoire => this.moduleMemoire;
        /// <summary>
        /// Module en charge de la prise de décisions
        /// </summary>
        public ModulePriseDeDecisions ModulePriseDeDecisions => this.modulePriseDeDecisions;
        /// <summary>
        /// Module en charge des réactions aux réponses du serveur
        /// </summary>
        public ModuleReaction ModuleReaction => this.moduleReaction;
        #endregion

        #region --- Constructeur ---
        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public IA()
        {
            this.moduleCommunication = new ModuleCommunication(this);
            this.moduleMemoire = new ModuleMemoire(this);
            this.modulePriseDeDecisions = new ModulePriseDeDecisions(this);
            this.moduleReaction = new ModuleReaction(this);

            this.aFiniDeCommuniquer = false;
        }
        #endregion

        #region --- Méthodes ---
        /// <summary>
        /// Démarre l'IA
        /// </summary>
        public void Start()
        {
            //Initialisation
            this.aFiniDeCommuniquer = false;
            string messageRecu = "";
            string messageEnvoye = "";

            //Mise en place de la connexion au serveur
            this.ModuleCommunication.EtablirConnexion();

            //Boucle de discussion
            while (!this.aFiniDeCommuniquer)
            {
                //Détermination de la prochaine action
                messageEnvoye = this.ModulePriseDeDecisions.DeterminerNouvelleAction(messageRecu);
                //Envoi du message au serveur
                if(messageEnvoye != "FIN")
                {
                    this.moduleCommunication.EnvoyerMessage(messageEnvoye);
                    //Réception du message du serveur
                    messageRecu = this.ModuleCommunication.RecevoirMessage();
                    //Réaction au message 
                    this.ModuleReaction.ReagirAuMessageRecu(messageEnvoye, messageRecu);
                }
            }
            //Fermeture de la connexion
            this.ModuleCommunication.FermerConnexion();
        }

        /// <summary>
        /// Méthode appelée quand on souhaite arrêter la communication avec le serveur
        /// </summary>
        public void ArreterLaCommunication()
        {
            this.aFiniDeCommuniquer = true;
        }
        #endregion

    }
}
