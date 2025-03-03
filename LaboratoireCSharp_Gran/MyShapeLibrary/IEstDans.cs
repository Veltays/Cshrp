using System;
using MyShapeLibrary;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MyShapeLibrary
{
    /*
     * Créer une interface IEstDans implémentée par toutes les formes. 
     * Cette interface contiendra une méthode CoordonneeEstDans(Coordonnee p) permettant de déterminer si un point passé en paramètre est ou non dans la forme. 
     * L’implémentation de cette méthode pour nos formes est triviale,
     * un peu de math devrait vous permettre d’y arriver. 
     * 
     * On suppose que le point d’accroche représente le coin supérieur gauche du carré ou du rectangle, ou le centre du cercle. 
     * 
     * Comme dans la manipulation d’images, on notera que l’axe des X est orienté de gauche à droite et l’axe Y est orienté de haut en bas.
     * 
     * L’objectif de cette interface serait par exemple de permettre la sélection d’une forme dessinée dans une interface graphique en cliquant dessus.
     * 
    */
    public interface IEstDans
    {


        bool CoordonneeEstDans(Coordonnee p);



    }
}
