using GalacticGraph.Metier.Algorithmes;
using GalacticGraph.Metier.Cartes;
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
        public string DeterminerNouvelleAction(string messageRecu)
        {
            string messageAEnvoyer = "FIN";

            if (!this.ModuleMemoire.HasCarte)
            {
                messageAEnvoyer = "CARTE";
            }
            else if (!this.ModuleMemoire.HasVaisseau)
            {
                messageAEnvoyer = "CREER";
            }
            else
            {
                if (!this.ModuleMemoire.Vaisseau.HasOrdres)
                {
                    ParcoursLargeur algo = new ParcoursLargeur(this.ModuleMemoire.Carte);
                    Case caseVaisseau = this.ModuleMemoire.Carte.GetCaseAt(this.ModuleMemoire.Vaisseau.Coordonnees);
                    algo.CalculerDistancesDepuis(caseVaisseau);
                    List<Direction> chemin = algo.GetChemin(this.ModuleMemoire.Carte.GetCaseAt(new Coordonnees(0, 0)));
                    this.ModuleMemoire.Vaisseau.AjouterOrdres(chemin);
                }

                if (this.ModuleMemoire.Vaisseau.HasOrdres)
                {
                    Direction direction = this.ModuleMemoire.Vaisseau.ExecuterOrdre();
                    messageAEnvoyer = "BOUGER|0|" + direction.ToString();
                }
                else
                {
                    this.ArreterLaCommunication(); // méthode protégée de Module
                }
            }

            return messageAEnvoyer;
        }

        #endregion
    }
}
