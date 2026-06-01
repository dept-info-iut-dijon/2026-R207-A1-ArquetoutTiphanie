using GalacticGraph.Metier.Cartes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IATest
{
    public class TestDirectionCoordonnees
    {
        [Fact]
        //Test pour les voisins de (3,3)
        public void TestDirectionCoordonnees_3_3()
        {
            Coordonnees coordonnees = new Coordonnees(3, 3);
            Assert.Equal(Direction.GAUCHE, coordonnees.GetDirectionPourAllerEn(new Coordonnees(3, 2)));
            Assert.Equal(Direction.HAUTGAUCHE, coordonnees.GetDirectionPourAllerEn(new Coordonnees(2, 3)));
            Assert.Equal(Direction.HAUTDROITE, coordonnees.GetDirectionPourAllerEn(new Coordonnees(2, 4)));
            Assert.Equal(Direction.DROITE, coordonnees.GetDirectionPourAllerEn(new Coordonnees(3, 4)));
            Assert.Equal(Direction.BASDROITE, coordonnees.GetDirectionPourAllerEn(new Coordonnees(4, 4)));
            Assert.Equal(Direction.BASGAUCHE, coordonnees.GetDirectionPourAllerEn(new Coordonnees(4, 3)));
        }

        [Fact]
        //Test pour les voisins de (6,4)
        public void TestDirectionCoordonnees_6_4()
        {
            Coordonnees coordonnees = new Coordonnees(6, 4);
            Assert.Equal(Direction.GAUCHE, coordonnees.GetDirectionPourAllerEn(new Coordonnees(6, 3)));
            Assert.Equal(Direction.HAUTGAUCHE, coordonnees.GetDirectionPourAllerEn(new Coordonnees(5, 3)));
            Assert.Equal(Direction.HAUTDROITE, coordonnees.GetDirectionPourAllerEn(new Coordonnees(5, 4)));
            Assert.Equal(Direction.DROITE, coordonnees.GetDirectionPourAllerEn(new Coordonnees(6, 5)));
            Assert.Equal(Direction.BASDROITE, coordonnees.GetDirectionPourAllerEn(new Coordonnees(7, 4)));
            Assert.Equal(Direction.BASGAUCHE, coordonnees.GetDirectionPourAllerEn(new Coordonnees(7, 3)));
        }


        [Fact]
        //Test pour les voisins de (2,7)
        public void TestDirectionCoordonnees_2_7()
        {
            Coordonnees coordonnees = new Coordonnees(2, 7);
            Assert.Equal(Direction.GAUCHE, coordonnees.GetDirectionPourAllerEn(new Coordonnees(2, 6)));
            Assert.Equal(Direction.HAUTGAUCHE, coordonnees.GetDirectionPourAllerEn(new Coordonnees(1, 6)));
            Assert.Equal(Direction.HAUTDROITE, coordonnees.GetDirectionPourAllerEn(new Coordonnees(1, 7)));
            Assert.Equal(Direction.DROITE, coordonnees.GetDirectionPourAllerEn(new Coordonnees(2, 8)));
            Assert.Equal(Direction.BASDROITE, coordonnees.GetDirectionPourAllerEn(new Coordonnees(3, 7)));
            Assert.Equal(Direction.BASGAUCHE, coordonnees.GetDirectionPourAllerEn(new Coordonnees(3, 6)));
        }


        [Fact]
        //Test pour les voisins de (7,12)
        public void TestDirectionCoordonnees_7_12()
        {
            Coordonnees coordonnees = new Coordonnees(7, 12);
            Assert.Equal(Direction.GAUCHE, coordonnees.GetDirectionPourAllerEn(new Coordonnees(7, 11)));
            Assert.Equal(Direction.HAUTGAUCHE, coordonnees.GetDirectionPourAllerEn(new Coordonnees(6, 12)));
            Assert.Equal(Direction.HAUTDROITE, coordonnees.GetDirectionPourAllerEn(new Coordonnees(6, 13)));
            Assert.Equal(Direction.DROITE, coordonnees.GetDirectionPourAllerEn(new Coordonnees(7, 13)));
            Assert.Equal(Direction.BASDROITE, coordonnees.GetDirectionPourAllerEn(new Coordonnees(8, 13)));
            Assert.Equal(Direction.BASGAUCHE, coordonnees.GetDirectionPourAllerEn(new Coordonnees(8, 12)));
        }

        [Fact]
        //Test pour les voisins de (0,0)
        public void TestDirectionCoordonnees_0_0()
        {
            Coordonnees coordonnees = new Coordonnees(0, 0);
            Assert.Equal(Direction.GAUCHE, coordonnees.GetDirectionPourAllerEn(new Coordonnees(0, -1)));
            Assert.Equal(Direction.HAUTGAUCHE, coordonnees.GetDirectionPourAllerEn(new Coordonnees(-1, -1)));
            Assert.Equal(Direction.HAUTDROITE, coordonnees.GetDirectionPourAllerEn(new Coordonnees(-1, 0)));
            Assert.Equal(Direction.DROITE, coordonnees.GetDirectionPourAllerEn(new Coordonnees(0, 1)));
            Assert.Equal(Direction.BASDROITE, coordonnees.GetDirectionPourAllerEn(new Coordonnees(1, 0)));
            Assert.Equal(Direction.BASGAUCHE, coordonnees.GetDirectionPourAllerEn(new Coordonnees(1, -1)));
        }

    }
}
