using GalacticGraph.Metier;
using GalacticGraph.Metier.Cartes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GalacticGraph.Modules.Realisations
{
    /// <summary>
    /// Module en charge de mémoriser les informations de l'IA
    /// </summary>
    public class ModuleMemoire : Module
    {
        #region --- Attributs ---
        private Carte carte;
        private Vaisseau vaisseau;
        #endregion

        #region --- Propriétés ---
        /// <summary>
        /// Indique si la carte a été générée ou non
        /// </summary>
        public bool HasCarte => this.carte != null;

        public Carte Carte => this.carte;

        public Vaisseau Vaisseau => this.vaisseau;

        public bool HasVaisseau => this.vaisseau != null;
        #endregion

        #region --- Constructeur ---
        public ModuleMemoire(IA ia) : base(ia)
        {
        }
        #endregion

        #region --- Méthodes ---
        /// <summary>
        /// Génère la carte à partir du message reçu du serveur
        /// </summary>
        /// <param name="messageRecu">Le message reçu du serveur</param>
        public void GenererCarte(string messageRecu)
        {
            this.carte = new Carte(messageRecu);
        }

        /// <summary>
        /// Crée le vaisseau aux coordonnées de la base sur la carte
        /// </summary>
        public void GenererVaisseau()
        {
            this.vaisseau = new Vaisseau(this.carte.CoordonneesBase);
        }
        #endregion
    }
}
