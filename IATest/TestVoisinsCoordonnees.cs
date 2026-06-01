using GalacticGraph.Metier.Cartes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IATest
{
    public class TestVoisinsCoordonnees
    {
        [Fact]
        //Test pour les voisins de (3,3)
        public void TestGetVoisinsCoordonnees_3_3()
        {
            Coordonnees coordonnees = new Coordonnees(3, 3);
            Assert.Equal(new Coordonnees(3, 2), coordonnees.GetVoisin(Direction.GAUCHE));
            Assert.Equal(new Coordonnees(2, 3), coordonnees.GetVoisin(Direction.HAUTGAUCHE));
            Assert.Equal(new Coordonnees(2, 4), coordonnees.GetVoisin(Direction.HAUTDROITE));
            Assert.Equal(new Coordonnees(3, 4), coordonnees.GetVoisin(Direction.DROITE));
            Assert.Equal(new Coordonnees(4, 4), coordonnees.GetVoisin(Direction.BASDROITE));
            Assert.Equal(new Coordonnees(4, 3), coordonnees.GetVoisin(Direction.BASGAUCHE));
        }

        [Fact]
        //Test pour les voisins de (6,4)
        public void TestGetVoisinsCoordonnees_6_4()
        {
            Coordonnees coordonnees = new Coordonnees(6, 4);
            Assert.Equal(new Coordonnees(6, 3), coordonnees.GetVoisin(Direction.GAUCHE));
            Assert.Equal(new Coordonnees(5, 3), coordonnees.GetVoisin(Direction.HAUTGAUCHE));
            Assert.Equal(new Coordonnees(5, 4), coordonnees.GetVoisin(Direction.HAUTDROITE));
            Assert.Equal(new Coordonnees(6, 5), coordonnees.GetVoisin(Direction.DROITE));
            Assert.Equal(new Coordonnees(7, 4), coordonnees.GetVoisin(Direction.BASDROITE));
            Assert.Equal(new Coordonnees(7, 3), coordonnees.GetVoisin(Direction.BASGAUCHE));
        }


        [Fact]
        //Test pour les voisins de (2,7)
        public void TestGetVoisinsCoordonnees_2_7()
        {
            Coordonnees coordonnees = new Coordonnees(2, 7);
            Assert.Equal(new Coordonnees(2, 6), coordonnees.GetVoisin(Direction.GAUCHE));
            Assert.Equal(new Coordonnees(1, 6), coordonnees.GetVoisin(Direction.HAUTGAUCHE));
            Assert.Equal(new Coordonnees(1, 7), coordonnees.GetVoisin(Direction.HAUTDROITE));
            Assert.Equal(new Coordonnees(2, 8), coordonnees.GetVoisin(Direction.DROITE));
            Assert.Equal(new Coordonnees(3, 7), coordonnees.GetVoisin(Direction.BASDROITE));
            Assert.Equal(new Coordonnees(3, 6), coordonnees.GetVoisin(Direction.BASGAUCHE));
        }


        [Fact]
        //Test pour les voisins de (7,12)
        public void TestGetVoisinsCoordonnees_7_12()
        {
            Coordonnees coordonnees = new Coordonnees(7, 12);
            Assert.Equal(new Coordonnees(7, 11), coordonnees.GetVoisin(Direction.GAUCHE));
            Assert.Equal(new Coordonnees(6, 12), coordonnees.GetVoisin(Direction.HAUTGAUCHE));
            Assert.Equal(new Coordonnees(6, 13), coordonnees.GetVoisin(Direction.HAUTDROITE));
            Assert.Equal(new Coordonnees(7, 13), coordonnees.GetVoisin(Direction.DROITE));
            Assert.Equal(new Coordonnees(8, 13), coordonnees.GetVoisin(Direction.BASDROITE));
            Assert.Equal(new Coordonnees(8, 12), coordonnees.GetVoisin(Direction.BASGAUCHE));
        }

        [Fact]
        //Test pour les voisins de (0,0)
        public void TestGetVoisinsCoordonnees_0_0()
        {
            Coordonnees coordonnees = new Coordonnees(0, 0);
            Assert.Equal(new Coordonnees(0, -1), coordonnees.GetVoisin(Direction.GAUCHE));
            Assert.Equal(new Coordonnees(-1, -1), coordonnees.GetVoisin(Direction.HAUTGAUCHE));
            Assert.Equal(new Coordonnees(-1, 0), coordonnees.GetVoisin(Direction.HAUTDROITE));
            Assert.Equal(new Coordonnees(0, 1), coordonnees.GetVoisin(Direction.DROITE));
            Assert.Equal(new Coordonnees(1, 0), coordonnees.GetVoisin(Direction.BASDROITE));
            Assert.Equal(new Coordonnees(1, -1), coordonnees.GetVoisin(Direction.BASGAUCHE));
        }

    }
}
