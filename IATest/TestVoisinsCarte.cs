using GalacticGraph.Metier.Cartes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IATest
{
    public class TestVoisinsCarte
    {

        private Carte carte;

        public TestVoisinsCarte()
        {
            this.carte = new Carte("VVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVAAAAAAAVVVVVVAAAAVVVVVVVVVVVVVVVVVVVVVVVVAAAVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVAAAAAAAVVVVVAAAAVVVVVVVVVVVVVVVVVVVVVVVVVAAAVAVVVVVVVVVVVVVVAVAVVVVVVVVVVVVVVVVVAAAAAAAAVVVVVAAAVVVVAAVVVVVVVVVVVVVVVVVVVAAAAAVVVVVVVVVAVAAAAAAVVVVVVVVVVVVVVVVVVAAAAAAVVVVVVAVVVAVAAAAAVVAVVVVVVVAAAVVVVAAAAAVVVVVVVVVAAAAAAAAVVVVSVVVVVVVVVVVVVVVVVAAAVVVVVVVVAAAAAAAAAVAAVVVVVVAAAVVVVAAAVVVVVAAVAVVAAAAAAAAVVVVVPVVVAVVVVVVVVVVVVAAAVVVVVVVAAAAAAAAVVAAAVVVVVAAAAVVVVAAAAVVVVAAAAAVAAAAAAAAAVVVVVVVVVAVVVVAVAAAVAAAAAVVVVVVVAAAAAAAVVAAAAVVVVAAAAVVVVAAAAVVVAAAAAAAAAAAAAAVVVVVVVAAAAAAVVAAAAAAAAAAAAVVVVVVVAAAVVVVVAAAAAVVVAAAAAAVVVAVAAVVVVAAAAVVVAAAAAAAVVVVVVAAAAAVVVVAAAAAAAAAAAVVVVVVVVVAAVVVVVAAAAVVVVAAAAAAAAVVVVVVVAAAVAVVVAAAVVAVVVVVVVVAAAAVVAAAAAAAAAAAAAVVVVVVVVVVVVAVVVVVVAVVVVAAAAAAAAVVVVVVVVVVAVAVVVVVVVVAAAAVVVVVVAAAVVVAAAAAAAVVAAVVVVVVVVVVVAAVAAVVAAAVVVAAAAAAAAVVVVVVVVVVVVVVVVVVVVVAAAAAVVVVVAAVVVAAAAAAAVVVVVVVVVVVVVVAAAAAAAVVAAAVVVVVAAAAAAVVVVVVVVVVVVVVVVVVVVVAAAAVVVVVVVVVVVVVVVVVAAVVVVVVVVVVVVVAAAAAAAAVAAAAVVVVVVAAAAAAAAVVVVVVVVVVVVVVVVVAAAVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVAAAAAAAAAAAAVVVVVVVAAVVAAAAAAVVVVVVVVVVVVVVVVAAAVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVAAAAAVVVAAVAVVVVVVVVVAVAAAAAAVVVVVAAVVVVVAAAVVVVVVVVVVSVVVVVVVVVVVVVVVVVVVVVVVVAAAAAVVVVAVVAVAVVVVAVAAVVAAAAAVVVAVAAAVVVVAAAAAVVVVVVVVVVVVVVVVVVVVVVAAVVVVVVVVVVAAAAVVVAVVVAAAAVVVAAAAAVAAAVVVVVAAAAAVVVVAAAAVVAVVVVVPVVVVVVVVVVVVAAAAVVVVVVVVVAAAVVVAAVVVAAAAVVVAAAAAVVVAVVVVVVVAAAAAVVVAAAAAAAAVVVVVVVVAAAAVVVVVAVAAAAVVVVVVVVVVAVAAAAAVVAAAVVVVAAAAVVVVVVVVVVVAAAAVVVVAAAAAAAVVVVVVVVAAAAAVVVVVAAAAAVVVVVVVVVVVVAAAAAVVVAVAVVVVAAAVVVVVVVVVVVVVVAAVVVVVAVAAAAAVVVVVVVAAAAAVVVVVVVAAAVVVVVVVVVVVVVAAAAVVVAVAAAVVVAAAVVVVAAAVVAAVVVVVVVVVVAAAAAVVVVVVVVAAAAAVVVVVVVVVAVVVVVVVVAAAVAAAAVVVVAAAAAAAAAAAVVVVVAAAVAAAAVVVVVVVVAAAAAVVVVVVVVVAAAAAAVVVVVVVVVVVVVVVVAAAVVAVAVVVVAAAAAAAAAAAAVVVAAAAAAAAAVVVVVVVVVVVAAVVVVAAVVVAAAAAAAVVVVVVVVVVVVVVAAAAVAVVVVVVVVAAAAAVAAAVVVVVVAAAAAAAAAAVVVVVVVVVVVVVVAAAVVVVVAAAAAVVVVSVVVVVVVVAAAAAVVVVVVVVVVAAAAAAAAAAVVVVVAVAVAAAAAVVVVVVVVVVVVVVAAAAAVVVAAAAVVVVVVPVVVVVVAAAAAAAVVVVVVVVVVVVAAAAAAAVVVVVVVVVAAAAAVVVVVVVVVVVVVVVAAAAAVVVVVVVVVVVVVVVVVVVVVVAAAAVVVAVAVVVVVVVVVAAAAAVVVVVVVVVVVVAVVVVVVVVVVVVVVVVAAAAVVVVVVVVVVVVVVPVVVVVVVAAAVVVVAAAVVVVVVVVVVVVAVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVAAAAVVVVVVVVVVVVVVVVVVVVVAAAVVVAAAAAAVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVAVAVVVVVAVVVVVVVVVVVVVVVAAVVVVVAAAVVVAAAAAVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVAAAAVVVVVVVVVVVVVVVVVVVAAAVVVVVAAVVVVAAAAAVVVVVVVVVVAAVVVVVPVVVVVVVVBVVVVVVVVVVAAAAVVVVVVVVVVVVVVVVVVVAAAAAVVVVVVVVVVAAAAVVVVVVVVVVAAAVVVVVVVVPVVVVVVVVVVVVVVVVVAAAAAVVVVVVVVVVVVVVVVVAAAAAAVVVVVVVVVVAAAAAVVVVVVVVAAAAVVVVVSVVVVVVVVVVVVVVVVVVVAAAAVVVVVVVVSVVVVVVVVVVAAAAAVVVVVVVVVVAAAAVVVVVVVVVAAVVVVVVVVVVVVVVVVVVVVVVVVVVVAAAVVVVVVVVVVVVVVVVVVVVVVAAVVAAVVVVVVVAAAAVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVAVVVVVVVVVVPVVVVVVVVVVAAVVAAAVVVVVVVAAVVVVVVVVAAAVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVAVAVVVVVVVAAAVVVVVAAAVAAAAVVVVVVVVVVVVAVVAAAAAAVVPVVVVVVVVVVVVVVVVVVVVVVVVVVVVVAAAAVVVVVVAAAAAVVAAAAAAAAAVVVVVVVVVVVVAAAAAAAAVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVVAAAAAVVVVVVAAAAAVVAAAAAAAAVAVVVVVVVVVVVAAAAAAAAAVVVPVVVVVVVVVVVVVVVVVVVVVVVVVVVVVAAAVVVVVVVAAAVVVVAAAAAAAVVVVVVVVVVVVVVAAAAAAAAVVPSVVV");
        }

        private void TestVoisin(Direction d, Coordonnees coordonnees, Case? maCase)
        {
            Case? voisin = this.carte.GetCaseAt(coordonnees.GetVoisin(d));
            Assert.NotNull(voisin);
            Assert.Contains<Case>(voisin, maCase.Voisins);
        }

        [Fact]
        //Test pour les voisins de (3,3)
        public void TestGetVoisinsCoordonnees_3_3()
        {
            Coordonnees coordonnees = new Coordonnees(3, 3);
            Case maCase = this.carte.GetCaseAt(coordonnees);

            //Nombres de voisins
            Assert.Equal(6, maCase.Voisins.Length);

            //Test des voisins
            TestVoisin(Direction.GAUCHE, coordonnees, maCase);
            TestVoisin(Direction.HAUTGAUCHE, coordonnees, maCase);
            TestVoisin(Direction.HAUTDROITE, coordonnees, maCase);
            TestVoisin(Direction.DROITE, coordonnees, maCase);
            TestVoisin(Direction.BASDROITE, coordonnees, maCase);
            TestVoisin(Direction.BASGAUCHE, coordonnees, maCase);
        }

        [Fact]
        //Test pour les voisins de (6,4)
        public void TestGetVoisinsCoordonnees_6_4()
        {
            Coordonnees coordonnees = new Coordonnees(6, 4);
            Case? maCase = this.carte.GetCaseAt(coordonnees);

            //Nombres de voisins
            Assert.NotNull(maCase);

            //Test des voisins
            TestVoisin(Direction.GAUCHE, coordonnees, maCase);
            TestVoisin(Direction.HAUTGAUCHE, coordonnees, maCase);
            TestVoisin(Direction.HAUTDROITE, coordonnees, maCase);
            TestVoisin(Direction.DROITE, coordonnees, maCase);
            TestVoisin(Direction.BASDROITE, coordonnees, maCase);
            TestVoisin(Direction.BASGAUCHE, coordonnees, maCase);
        }

        [Fact]
        //Test pour les voisins de (0,0) - coin haut gauche
        public void TestGetVoisinsCoordonnees_0_0()
        {
            Coordonnees coordonnees = new Coordonnees(0, 0);
            Case? maCase = this.carte.GetCaseAt(coordonnees);

            Assert.NotNull(maCase);

            //Nombres de voisins
            Assert.Equal(2, maCase.Voisins.Length);

            //Test des voisins
            TestVoisin(Direction.DROITE, coordonnees, maCase);
            TestVoisin(Direction.BASDROITE, coordonnees, maCase);
        }

        [Fact]
        //Test pour les voisins de (0,5) - Bord haut
        public void TestGetVoisinsCoordonnees_0_5()
        {
            Coordonnees coordonnees = new Coordonnees(0, 5);
            Case? maCase = this.carte.GetCaseAt(coordonnees);

            Assert.NotNull(maCase);

            //Nombres de voisins
            Assert.Equal(4, maCase.Voisins.Length);

            //Test des voisins
            TestVoisin(Direction.GAUCHE, coordonnees, maCase);
            TestVoisin(Direction.DROITE, coordonnees, maCase);
            TestVoisin(Direction.BASDROITE, coordonnees, maCase);
            TestVoisin(Direction.BASGAUCHE, coordonnees, maCase);
        }

        [Fact]
        //Test pour les voisins de (0,79) - Coin haut droite
        public void TestGetVoisinsCoordonnees_0_79()
        {
            Coordonnees coordonnees = new Coordonnees(0, 79);
            Case? maCase = this.carte.GetCaseAt(coordonnees);

            Assert.NotNull(maCase);

            //Nombres de voisins
            Assert.Equal(3, maCase.Voisins.Length);

            //Test des voisins
            TestVoisin(Direction.GAUCHE, coordonnees, maCase);
            TestVoisin(Direction.BASDROITE, coordonnees, maCase);
            TestVoisin(Direction.BASGAUCHE, coordonnees, maCase);
        }

        [Fact]
        //Test pour les voisins de (9,79) - Bord droit impair
        public void TestGetVoisinsCoordonnees_9_79()
        {
            Coordonnees coordonnees = new Coordonnees(9, 79);
            Case? maCase = this.carte.GetCaseAt(coordonnees);

            Assert.NotNull(maCase);

            //Nombres de voisins
            Assert.Equal(3, maCase.Voisins.Length);

            //Test des voisins
            TestVoisin(Direction.GAUCHE, coordonnees, maCase);
            TestVoisin(Direction.HAUTGAUCHE, coordonnees, maCase);
            TestVoisin(Direction.BASGAUCHE, coordonnees, maCase);
        }

        [Fact]
        //Test pour les voisins de (8,79) - Bord droit pair
        public void TestGetVoisinsCoordonnees_8_79()
        {
            Coordonnees coordonnees = new Coordonnees(8, 79);
            Case? maCase = this.carte.GetCaseAt(coordonnees);

            Assert.NotNull(maCase);

            //Nombres de voisins
            Assert.Equal(5, maCase.Voisins.Length);

            //Test des voisins
            TestVoisin(Direction.GAUCHE, coordonnees, maCase);
            TestVoisin(Direction.HAUTGAUCHE, coordonnees, maCase);
            TestVoisin(Direction.BASGAUCHE, coordonnees, maCase);
            TestVoisin(Direction.HAUTDROITE, coordonnees, maCase);
            TestVoisin(Direction.BASDROITE, coordonnees, maCase);
        }
        //Test pour les voisins de (39,79) - coin bas droit 
        public void TestGetVoisinsCoordonnees_39_79()
        {
            Coordonnees coordonnees = new Coordonnees(39, 79);
            Case? maCase = this.carte.GetCaseAt(coordonnees);

            Assert.NotNull(maCase);

            //Nombres de voisins
            Assert.Equal(2, maCase.Voisins.Length);

            //Test des voisins
            TestVoisin(Direction.GAUCHE, coordonnees, maCase);
            TestVoisin(Direction.HAUTGAUCHE, coordonnees, maCase);
        }

        [Fact]
        //Test pour les voisins de (39,5) - Bord bas
        public void TestGetVoisinsCoordonnees_39_5()
        {
            Coordonnees coordonnees = new Coordonnees(39, 5);
            Case? maCase = this.carte.GetCaseAt(coordonnees);

            Assert.NotNull(maCase);

            //Nombres de voisins
            Assert.Equal(4, maCase.Voisins.Length);

            //Test des voisins
            TestVoisin(Direction.GAUCHE, coordonnees, maCase);
            TestVoisin(Direction.DROITE, coordonnees, maCase);
            TestVoisin(Direction.HAUTDROITE, coordonnees, maCase);
            TestVoisin(Direction.HAUTGAUCHE, coordonnees, maCase);
        }

        //Test pour les voisins de (39,0) - coin bas gauche 
        public void TestGetVoisinsCoordonnees_39_0()
        {
            Coordonnees coordonnees = new Coordonnees(39, 0);
            Case? maCase = this.carte.GetCaseAt(coordonnees);

            Assert.NotNull(maCase);

            //Nombres de voisins
            Assert.Equal(3, maCase.Voisins.Length);

            //Test des voisins
            TestVoisin(Direction.DROITE, coordonnees, maCase);
            TestVoisin(Direction.HAUTGAUCHE, coordonnees, maCase);
            TestVoisin(Direction.HAUTDROITE, coordonnees, maCase);
        }

        [Fact]
        //Test pour les voisins de (9,0) - Bord gauche impair
        public void TestGetVoisinsCoordonnees_9_0()
        {
            Coordonnees coordonnees = new Coordonnees(9, 0);
            Case? maCase = this.carte.GetCaseAt(coordonnees);

            Assert.NotNull(maCase);

            //Nombres de voisins
            Assert.Equal(5, maCase.Voisins.Length);

            //Test des voisins
            TestVoisin(Direction.DROITE, coordonnees, maCase);
            TestVoisin(Direction.HAUTGAUCHE, coordonnees, maCase);
            TestVoisin(Direction.BASGAUCHE, coordonnees, maCase);
            TestVoisin(Direction.HAUTDROITE, coordonnees, maCase);
            TestVoisin(Direction.BASDROITE, coordonnees, maCase);
        }

        [Fact]
        //Test pour les voisins de (8,0) - Bord gauche pair
        public void TestGetVoisinsCoordonnees_8_0()
        {
            Coordonnees coordonnees = new Coordonnees(8, 0);
            Case? maCase = this.carte.GetCaseAt(coordonnees);

            Assert.NotNull(maCase);

            //Nombres de voisins
            Assert.Equal(3, maCase.Voisins.Length);

            //Test des voisins
            TestVoisin(Direction.DROITE, coordonnees, maCase);
            TestVoisin(Direction.HAUTDROITE, coordonnees, maCase);
            TestVoisin(Direction.BASDROITE, coordonnees, maCase);
        }
    }
}
