using GalacticGraph.Metier.Algorithmes;
using GalacticGraph.Metier.Cartes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IATest
{
    public class TestDijkstra
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

            int[,] expectedResults =
            {
                {-1,-1,-1,-1,-1,-1,-1,-1,-1,-1},
                {-1, 0,-1,-1,-1,-1,-1,11,12,-1},
                {-1, 1,-1,-1, 7, 8,-1,10,11,-1},
                {-1, 2, 4, 6, 7, 8, 9,10,10,-1},
                {-1,-1, 3, 4, 5, 6, 7, 8, 9,-1},
                {-1,-1,-1,-1,-1,-1,-1,-1,-1,-1},
            };

            for (int i = 0; i < 6; i++)
                for (int j = 0; j < 10; j++)
                    Assert.Equal(expectedResults[i, j], parcours.GetDistance(carte.GetCaseAt(new Coordonnees(i, j))));
        }
    }
}

