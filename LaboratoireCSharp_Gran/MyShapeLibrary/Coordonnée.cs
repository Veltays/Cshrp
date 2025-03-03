using MyShapeLibrary;
using System;

namespace MyShapeLibrary
{

    /*
     * Créer une classe Coordonnee décrite par : deux coordonnées de type entier X et Y (variable membre et propriété), 
     * un constructeur d'initialisation, 
     * un constructeur par défaut (qui utilise le constructeur d'initialisation). 
     * La surcharge de la méthode ToString() en utilisant le format : (X,Y)
    */
    public class Coordonnee
    {
        private int _X;    // _ pour les priver
        private int _Y;

        public int X { get; set; }
        public int Y { get; set; }



        // Constructeur d'initialisation
        public Coordonnee(int x, int y)
        {
            X = x;
            Y = y;
        }


        // constructeur par défaut 
        public Coordonnee() : this(0, 0)   // il va appeler le constructeur d'initialisation en mettant 0,0 (this call himself)
        {

        }

        public override string ToString()
        {
            return $"{X},{Y}";
        }
    }

}