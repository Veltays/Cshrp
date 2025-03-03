using System;
using System.Reflection.Metadata.Ecma335;

/*
 * Créer une classe Cercle qui hérite de Forme et 
 * décrite par : une valeur entière représentant le rayon (variable membre et propriété), 
 * une propriété calculée Diamètre en lecture seule, 
 * un constructeur d’initialisation, 
 * un constructeur par défaut, 
 * la surcharge de la méthode ToString().

 */
namespace MyShapeLibrary
{
    public class Cercle : Forme, IEstDans
    {

        public int Rayon { get; set; }

        public double Diametre
        {
            get
            {
                return 2 * Rayon;
            }
        }

        public Cercle(Coordonnee PointAccroch, int rayon) : base(PointAccroch)
        {
            if (rayon > 0)
            {
                Rayon = rayon;
            }
            else
            {
                Console.WriteLine("Votre Rayon est négatif");
            }
        }


        public Cercle() : this(new Coordonnee(0, 0), 0)
        {

        }


        public override string ToString()
        {
            return $"Votre cercle de Rayon {Rayon} avec comme diamètre {Diametre} et comme point d'accroche {PointAccroche.ToString()} ";
        }
    
        public bool CoordonneeEstDans(Coordonnee p)
        {
            Console.WriteLine($"Votre point X - (X,Y)");
            Console.WriteLine($"Votre Centre                 - ({PointAccroche})");
            Console.WriteLine($"Votre Point le plus haut     - ({PointAccroche.X},{PointAccroche.Y + Rayon})");
            Console.WriteLine($"Votre Point le plus à droite - ({PointAccroche.X + Rayon},{PointAccroche.Y})");
            Console.WriteLine($"Votre Point le plus bas      - ({PointAccroche.X - Rayon},{PointAccroche.Y})");
            Console.WriteLine($"Votre point le plus à gauche - ({PointAccroche.X},{PointAccroche.Y - Rayon})");


            double distanceCarré = Math.Pow(p.X - PointAccroche.X,2) + Math.Pow(p.Y - PointAccroche.Y, 2);
            return distanceCarré <= Math.Pow(Rayon,2);


        }
    }


}