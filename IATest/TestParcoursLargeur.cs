using GalacticGraph.Metier.Algorithmes;
using GalacticGraph.Metier.Cartes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IATest
{
    public class TestParcoursLargeur
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
        public void TestVideAsteroides()
        {
            string messageCarte = "";
            messageCarte += "AAAAAAAAAA" + FinDeLigne();
            messageCarte += "AVAAVVVVAA" + FinDeLigne();
            messageCarte += "AVAAAAAAVA" + FinDeLigne();
            messageCarte += "AVAAAAAAVA" + FinDeLigne();
            messageCarte += "AAVVVVVVVA" + FinDeLigne();
            messageCarte += "AAAAAAAAAA" + FinDeLigne();
            for (int i = 6; i < 40; i++) messageCarte += Ligne();

            Carte carte = new Carte(messageCarte);

            ParcoursLargeur parcours = new ParcoursLargeur(carte);
            parcours.CalculerDistancesDepuis(carte.GetCaseAt(new Coordonnees(1, 1)));

            int[,] expectedResults =
            {
                {-1,-1,-1,-1,-1,-1,-1,-1,-1,-1},
                {-1, 0,-1,-1,15,14,13,12,-1,-1},
                {-1, 1,-1,-1,-1,-1,-1,-1,11,-1},
                {-1, 2,-1,-1,-1,-1,-1,-1,10,-1},
                {-1,-1, 3, 4, 5, 6, 7, 8, 9,-1},
                {-1,-1,-1,-1,-1,-1,-1,-1,-1,-1},
            };

            for (int i = 0; i < 6; i++)
                for (int j = 0; j < 10; j++)
                    Assert.Equal(expectedResults[i, j], parcours.GetDistance(carte.GetCaseAt(new Coordonnees(i, j))));
        }

        [Fact]
        public void TestBaseEtPlanete()
        {
            string messageCarte = "";
            messageCarte += "AAAAAAAAAA" + FinDeLigne();
            messageCarte += "AVAAVVVVAA" + FinDeLigne();
            messageCarte += "ABAAAAAAVA" + FinDeLigne();
            messageCarte += "AVAAAAAAVA" + FinDeLigne();
            messageCarte += "AAPPPPPPPA" + FinDeLigne();
            messageCarte += "AAAAAAAAAA" + FinDeLigne();
            for (int i = 6; i < 40; i++) messageCarte += Ligne();

            Carte carte = new Carte(messageCarte);

            ParcoursLargeur parcours = new ParcoursLargeur(carte);
            parcours.CalculerDistancesDepuis(carte.GetCaseAt(new Coordonnees(1, 1)));

            int[,] expectedResults =
            {
                {-1,-1,-1,-1,-1,-1,-1,-1,-1,-1},
                {-1, 0,-1,-1,15,14,13,12,-1,-1},
                {-1, 1,-1,-1,-1,-1,-1,-1,11,-1},
                {-1, 2,-1,-1,-1,-1,-1,-1,10,-1},
                {-1,-1, 3, 4, 5, 6, 7, 8, 9,-1},
                {-1,-1,-1,-1,-1,-1,-1,-1,-1,-1},
            };

            for (int i = 0; i < 6; i++)
                for (int j = 0; j < 10; j++)
                    Assert.Equal(expectedResults[i, j], parcours.GetDistance(carte.GetCaseAt(new Coordonnees(i, j))));
        }

        [Fact]
        public void TestInconnuEtSoleil()
        {
            string messageCarte = "";
            messageCarte += "AAAAAAAAAA" + FinDeLigne();
            messageCarte += "AVAAVVVVAA" + FinDeLigne();
            messageCarte += "AVAAAAAASA" + FinDeLigne();
            messageCarte += "AVAAAAAAVA" + FinDeLigne();
            messageCarte += "AAXXXXXXXA" + FinDeLigne();
            messageCarte += "AAAAAAAAAA" + FinDeLigne();
            for (int i = 6; i < 40; i++) messageCarte += Ligne();

            Carte carte = new Carte(messageCarte);

            ParcoursLargeur parcours = new ParcoursLargeur(carte);
            parcours.CalculerDistancesDepuis(carte.GetCaseAt(new Coordonnees(1, 1)));

            int[,] expectedResults =
            {
                {-1,-1,-1,-1,-1,-1,-1,-1,-1,-1},
                {-1, 0,-1,-1,-1,-1,-1,-1,-1,-1},
                {-1, 1,-1,-1,-1,-1,-1,-1,-1,-1},
                {-1, 2,-1,-1,-1,-1,-1,-1,10,-1},
                {-1,-1, 3, 4, 5, 6, 7, 8, 9,-1},
                {-1,-1,-1,-1,-1,-1,-1,-1,-1,-1},
            };

            for (int i = 0; i < 6; i++)
                for (int j = 0; j < 10; j++)
                    Assert.Equal(expectedResults[i, j], parcours.GetDistance(carte.GetCaseAt(new Coordonnees(i, j))));
        }
    }
}

