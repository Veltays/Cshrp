using System;
using MyShapeLibrary;

namespace MyShapeLibrary
{

    /*
     * Créer une classe abstraite Forme qui décrit toute forme géométrique. 
     * Elle doit contenir une variable membre et sa propriété associée de type Coordonnee qui représente le point d’accroche de la forme
     * ainsi 
     * qu'un constructeur par défaut qui pourra être appelé par les classe filles grâce au mot clé 'base'.

    */
    public abstract class Forme
    {

        public Coordonnee PointAccroche { get; set; }



        protected Forme(Coordonnee pointAccroche)   // Protected uniquement pr les enfant de l'héritage
        {
            PointAccroche = pointAccroche;
        }

        
    }
}
