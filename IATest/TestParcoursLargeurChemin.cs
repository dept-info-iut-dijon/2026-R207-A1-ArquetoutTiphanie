using GalacticGraph.Metier.Algorithmes;
using GalacticGraph.Metier.Cartes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IATest
{
    public class TestParcoursLargeurChemin
    {
        private string FinDeLigne()
        {
            return "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA";
        }

        private string Ligne()
        {
            return "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA";
        }




        [Fact]
        public void TestChemin()
        {
            string messageCarte = "";
            messageCarte += "AAAAAAAAAA" + FinDeLigne();
            messageCarte +=  "ABAAVVVVAA" + FinDeLigne();
            messageCarte += "AVSAAAAAVA" + FinDeLigne();
            messageCarte +=  "APSAAAAAVA" + FinDeLigne();
            messageCarte += "AAVXVVVVVA" + FinDeLigne();
            messageCarte += "AAAAAAAAAA" + FinDeLigne();
            for (int i = 6; i < 40; i++) messageCarte += Ligne();

            Carte carte = new Carte(messageCarte);

            ParcoursLargeur parcours = new ParcoursLargeur(carte);
            parcours.CalculerDistancesDepuis(carte.GetCaseAt(new Coordonnees(1, 1)));

            List<Direction> expected = new List<Direction>{
                Direction.BASGAUCHE,
                Direction.BASDROITE,
                Direction.BASDROITE,
                Direction.DROITE,
                Direction.DROITE,
                Direction.DROITE,
                Direction.DROITE,
                Direction.DROITE,
                Direction.DROITE,
                Direction.HAUTDROITE,
                Direction.HAUTGAUCHE,
                Direction.HAUTGAUCHE,
                Direction.GAUCHE,
                Direction.GAUCHE,
                Direction.GAUCHE,
            };

            Assert.Equal(expected, parcours.GetChemin(carte.GetCaseAt(new Coordonnees(1, 4))));
        }
    }
}
