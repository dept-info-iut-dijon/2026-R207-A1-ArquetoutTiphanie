using GalacticGraph.Metier.Algorithmes;
using GalacticGraph.Metier.Cartes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IATest
{
    public class TestDijkstraChemin
    {
        private string FinDeLigne()
        {
            return "SSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSS";
        }

        private string Ligne()
        {
            return "SSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSS";
        }




        [Fact]
        public void TestVideAsteroides()
        {
            string messageCarte = "";
            messageCarte += "SSSSSSSSSS" + FinDeLigne();
            messageCarte += "SVSSSSSVVS" + FinDeLigne();
            messageCarte += "SVSSVVSVVS" + FinDeLigne();
            messageCarte += "SVAAAAAAVS" + FinDeLigne();
            messageCarte += "SSVVVVVVVS" + FinDeLigne();
            messageCarte += "SSSSSSSSSS" + FinDeLigne();
            for (int i = 6; i < 40; i++) messageCarte += Ligne();

            Carte carte = new Carte(messageCarte);

            Dijkstra parcours = new Dijkstra(carte);
            parcours.CalculerDistancesDepuis(carte.GetCaseAt(new Coordonnees(1, 1)));

            List<Direction> expected = new List<Direction>{
                Direction.BASGAUCHE,
                Direction.BASDROITE,
                Direction.BASDROITE,
                Direction.DROITE,
                Direction.DROITE,
                Direction.DROITE,
                Direction.DROITE,
                Direction.HAUTDROITE,
                Direction.HAUTDROITE,
                Direction.HAUTDROITE
            };

            Assert.Equal(expected, parcours.GetChemin(carte.GetCaseAt(new Coordonnees(1, 7))));
        }
    }
}


