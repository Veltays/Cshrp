using MyShapeLibrary;
using MathHelpers;
namespace MathHelpers
{
    public class MathCalculation 
    {


        // Calcul de la surface du carré
        public static double CalculerSurfaceCarre(Carre carrer)
        {
            return carrer.LongueurCot * carrer.LongueurCot;
        }

        // Calcul de la surface du cercle
        public static double CalculerSurfaceCercle(Cercle cercle)
        {
            return Math.PI * cercle.Rayon * cercle.Rayon;
        }

        // Calcul de la surface du rectangle
        public static double CalculerSurfaceRectangle(Rectangle Rect)
        {
            return Rect.Longueur * Rect.Largeur; 
        }


        public static bool isBetween(double x, double min, double max)
        {
            if (x > min && x < max)
                return true;
            return false;

        }
    }
}
