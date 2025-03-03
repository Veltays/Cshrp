using System;
using MyShapeLibrary;

namespace MyShapeLibrary
{
    /*
     * Créer une classe Rectangle qui hérite de Forme 
     * et décrite par, des valeurs entières représentant les longueurs et largeurs (variable membre et propriété), 
     * un constructeur d’initialisation, 
     * un constructeur par défaut, 
     * la surcharge de la méthode ToString().
     * 
    */
    public class Rectangle : Forme, IEstDans, IPolygon
    {

        public int Longueur { get; set; }
        public int Largeur { get; set; }

        public int NbSomments
        {
            get { return 4; }
        }


        public Rectangle(Coordonnee PointA,int longueur, int largeur) : base(PointA)
        {
            if (longueur > 0 && largeur > 0)
            {
                Longueur = longueur;
                Largeur = largeur;
            }

            else
            {
                Console.WriteLine("Une des vos donnée est négatif");
            }
        }

        public Rectangle() : this(new Coordonnee(0,0), 0, 0)
        {

        }


        public override string ToString()
        {
            return $"Votre Rectangle de Longeur {Longueur} et de  Largeur {Largeur} et comme point d'accroche {PointAccroche.ToString()} ";
        }

        public bool CoordonneeEstDans(Coordonnee p)
        {
            Console.WriteLine($"Votre point X - (X,Y)");
            Console.WriteLine($"Votre point 1 - ({PointAccroche.X},{PointAccroche.Y})");
            Console.WriteLine($"Votre point 2 - ({PointAccroche.X + Longueur},{PointAccroche.Y})");
            Console.WriteLine($"Votre point 3 - ({PointAccroche.X},{PointAccroche.Y - Largeur})");
            Console.WriteLine($"Votre point 4 - ({PointAccroche.X + Longueur},{PointAccroche.Y - Largeur})");

            if (PointAccroche.X <= p.X && (PointAccroche.X + Longueur) >= p.X)
                if (PointAccroche.Y >= p.Y && (PointAccroche.Y - Largeur) <= p.Y)
                    return true;
            return false;
        }
    }
}
