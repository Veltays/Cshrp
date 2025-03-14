using System;
using System.Collections;
using MyShapeLibrary;

namespace MyShapeLibrary
{
    /*
     * Créer une classe Carre qui hérite de Forme 
     * et décrite par : une valeur entière représentant la longueur du coté (variable membre et propriété), 
     * un constructeur d’initialisation utilisant le constructeur de la classe mère,
     * un constructeur par défaut, 
     * la surcharge de la méthode ToString().
    */
    public class Carre : Forme, IEstDans, IPolygon, IComparable<Carre>
    {



        public int LongueurCot { get; set; }
        public int NbSomments
        {
            get { return 4; }
        }

        public Carre(Coordonnee PointAccroche, int longueurCot) : base(PointAccroche) // base fait réference a la classe parent
        {
          
            if (longueurCot > 0)
            {
                LongueurCot = longueurCot;
            }
            else
            {
                Console.WriteLine("La longueur de votre cotées est négatif");
            }
        }

        public Carre() :this(new Coordonnee(0,0),0)
        {

        }
   
        public override string ToString()
        {
            return $"Voici les coordonée de votre carré {PointAccroche.ToString()} avec comme longueur d'angle {LongueurCot}";
        }



        public bool CoordonneeEstDans(Coordonnee p)
        {
            Console.WriteLine($"Votre point  - (X,Y)");
            Console.WriteLine($"Votre point 1 - ({PointAccroche.X},{PointAccroche.Y})");
            Console.WriteLine($"Votre point 2 - ({PointAccroche.X + LongueurCot},{PointAccroche.Y})");
            Console.WriteLine($"Votre point 3 - ({PointAccroche.X},{PointAccroche.Y - LongueurCot})");
            Console.WriteLine($"Votre point 4 - ({PointAccroche.X + LongueurCot},{PointAccroche.Y - LongueurCot})");



            if (PointAccroche.X <= p.X && (PointAccroche.X + LongueurCot) >= p.X)
                if(PointAccroche.Y >= p.Y && (PointAccroche.Y - LongueurCot) <= p.Y)
                    return true ;
            return false;
        }


        public int CompareTo(Carre C2)
        {
            if (C2 == null)   // Si c'est null alors c forcement plus grand
                return 1;

            if (LongueurCot > C2.LongueurCot)
                return 1;
            else if (LongueurCot < C2.LongueurCot)
                return -1;

            return 0;

        }
    }
}
