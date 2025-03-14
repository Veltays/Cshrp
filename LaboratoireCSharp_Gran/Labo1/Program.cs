using MyShapeLibrary;
using System;
using MathHelpers;


namespace Labo1
{
    internal class Program
    {

        static List<Forme> ListeDeForme = new List<Forme>();

        static void Main(string[] args)
        {
            string choix;
            do
            {
                Console.WriteLine("\n=== Menu ===");
                Console.WriteLine("- 1. Créer un coordonner");
                Console.WriteLine("- 2. Créer un carré");
                Console.WriteLine("- 3. Créer un cercle");
                Console.WriteLine("- 4. Créer un rectangle");
                Console.WriteLine("- 5. Tester si un point est dans un carré");
                Console.WriteLine("- 6. Tester si un point est dans un rectangle");
                Console.WriteLine("- 7. Tester si un point est dans un Cercle");
                Console.WriteLine("- 8. Tester NombrePolygone");
                Console.WriteLine("- 9. Calculer Surface");
                Console.WriteLine("- 10. IsBetween");
                Console.WriteLine("- 11. Afficher Liste");
                Console.WriteLine("- 12. ListeTrier");



                Console.WriteLine("- 15. Quitter");
                Console.Write("Votre choix : ");

                choix = Console.ReadLine();
                Console.WriteLine("\n");

                switch (choix)
                {
                    case "1":
                        CreerCoordonner();
                        break;
                    case "2":
                        CreerCarrer();
                        break;
                    case "3":
                        CreerCercle();
                        break;
                    case "4":
                        CreerRectangle();
                        break;
                    case "5":
                        TesterPointDansFormeCarre();
                        break;
                    case "6":
                        TesterPointDansFormeRectangle();
                        break;
                    case "7":
                        TesterPointDansFormeCercle();
                        break;
                    case "8":
                        TesterNbrPolygon();
                        break;
                    case "9":
                        CalculeSurface();
                        break;
                    case "10":
                        EntreVal();
                        break;
                    case "11":
                        AfficheListe();
                        break;
                    case "12":
                        ListeTrier();
                        break;
                    case "15":
                        Console.WriteLine("Fin du programme.");
                        break;
                    default:
                        Console.WriteLine("Choix invalide, veuillez réessayer.");
                        break;
                }
            } while (choix != "15");

        }
        static void CreerCoordonner()
        {
            Coordonnee c1 = new Coordonnee(10, 20);
            Coordonnee c2 = new Coordonnee();
            //Création de coordonner
            Console.WriteLine("Coordonnee c1: " + c1.ToString());
            Console.WriteLine("Coordonnee c2 (defaut): " + c2.ToString());

        }



        static void CreerCarrer()
        {
            //Création d'un carré

            Coordonnee c1 = new Coordonnee(10, 20);
            Carre Car1 = new Carre(c1, 10);
            Console.WriteLine(Car1.ToString());
            ListeDeForme.Add(Car1);



            Coordonnee c2 = new Coordonnee(0, 0);
            Carre Car2 = new Carre(c1, 20);
            Console.WriteLine(Car1.ToString());
            ListeDeForme.Add(Car2);

        }


        static void CreerCercle()
        {
            //Création d'un cercle
            Coordonnee c1 = new Coordonnee(10, 20);
            Cercle Cerc1 = new Cercle(c1, 5);
            Console.WriteLine(Cerc1.ToString());
            ListeDeForme.Add(Cerc1);

            Coordonnee c2 = new Coordonnee(0, 0);
            Cercle Cerc2 = new Cercle(c1, 10);
            Console.WriteLine(Cerc1.ToString());
            ListeDeForme.Add(Cerc2);
        }

        static void CreerRectangle()
        {
            // Création d'un rectangle
            Coordonnee r1 = new Coordonnee(10, 20);
            Rectangle Rect1 = new Rectangle(r1, 5, 10);
            Console.WriteLine(Rect1.ToString());
            ListeDeForme.Add(Rect1);

            Coordonnee r2 = new Coordonnee(10, 20);
            Rectangle Rect2 = new Rectangle(r2, 5, 10);
            Console.WriteLine(Rect1.ToString());
            ListeDeForme.Add(Rect2);


        }

        static void TesterPointDansFormeCarre()
        {

            /* -------------------------------------------
             *  I est dans Test carré 
             * -------------------------------------------*/

            string choix;

            do
            {



                // récupére les donnée
                Console.WriteLine("Entrez les coordonner désiré du carré (point Supérieur Gauche) X puis Y ->  ");
                int X = int.Parse(Console.ReadLine());
                int Y = int.Parse(Console.ReadLine());
                Console.WriteLine($"Voici vos point ({X},{Y})");
                Console.WriteLine("Entrez la largeur du carré désirée -> ");
                int largeur = int.Parse(Console.ReadLine());

                // crée nos objet
                Coordonnee c3 = new Coordonnee(X, Y);
                Carre carreTestIEstDans = new Carre(c3, largeur);


                // TEST

                do
                {
                    Console.WriteLine("------------------TEST------------------");
                    Console.WriteLine("Entrez les coordonner du point que vous souhaité vérifier \n ->  ");
                    X = int.Parse(Console.ReadLine());
                    Y = int.Parse(Console.ReadLine());
                    Coordonnee Tester1 = new Coordonnee(X, Y);

                    if (carreTestIEstDans.CoordonneeEstDans(Tester1))
                        Console.WriteLine($"Le carré {carreTestIEstDans} est bien dans les coordonnée {Tester1} \n");
                    else
                        Console.WriteLine($"Le carré {carreTestIEstDans} n'est PAS dans les coordonnée {Tester1} \n");
                    Console.WriteLine("Continuez les test avec ces coordonner ? 0 pour arreter");
                    choix = Console.ReadLine();
                } while (choix != "0");

                Console.WriteLine("Changer de carrée? 0 pour arreter autre pour changer");
                choix = Console.ReadLine();
            } while (choix != "0");
        }



        static void TesterPointDansFormeRectangle()
        {
            string choix;
            do
            {



                // récupére les donnée
                Console.WriteLine("Entrez les coordonner désiré du rectangle (point Supérieur Gauche) X puis Y ->  ");
                int X = int.Parse(Console.ReadLine());
                int Y = int.Parse(Console.ReadLine());
                Console.WriteLine($"Voici vos point ({X},{Y})");
                Coordonnee cord = new Coordonnee(X, Y);


                Console.WriteLine("Entrez la largeur du rectangle désirée -> ");
                int largeur = int.Parse(Console.ReadLine());
                Console.WriteLine("Entrez la longueur du rectangle désirée -> ");
                int longueur = int.Parse(Console.ReadLine());

                // instacie le rectangle
                Rectangle RectIEstDans = new Rectangle(cord, longueur, largeur);



                do
                {
                    Console.WriteLine("------------------TEST------------------");
                    Console.WriteLine("Entrez les coordonner du point que vous souhaité vérifier \n ->  ");
                    X = int.Parse(Console.ReadLine());
                    Y = int.Parse(Console.ReadLine());
                    Coordonnee Tester1 = new Coordonnee(X, Y);

                    if (RectIEstDans.CoordonneeEstDans(Tester1))
                        Console.WriteLine($"Le rectangle {RectIEstDans} est bien dans les coordonnée {Tester1} \n");
                    else
                        Console.WriteLine($"Le rectangle {RectIEstDans} n'est PAS dans les coordonnée {Tester1} \n");
                    Console.WriteLine("Continuez les test avec ces coordonner ? 0 pour arreter");
                    choix = Console.ReadLine();
                } while (choix != "0");

                Console.WriteLine("Changer de rectangle ? 0 pour arreter autre pour changer");
                choix = Console.ReadLine();
            } while (choix != "0");
        }




        static void TesterPointDansFormeCercle()
        {
            string choix;
            do
            {



                // récupére les donnée
                Console.WriteLine("Entrez les coordonner désiré du cercle (centre) X puis Y ->  ");
                int X = int.Parse(Console.ReadLine());
                int Y = int.Parse(Console.ReadLine());
                Console.WriteLine($"Voici votre point d'accroche ({X},{Y})");
                Coordonnee cord = new Coordonnee(X, Y);


                Console.WriteLine("Entrez le rayon ru cercle désirée -> ");

                int Rayon = int.Parse(Console.ReadLine());

                // instacie le rectangle
                Cercle CercleIEstDans = new Cercle(cord, Rayon);



                do
                {
                    Console.WriteLine("------------------TEST------------------");
                    Console.WriteLine("Entrez les coordonner du point que vous souhaité vérifier \n ->  ");
                    X = int.Parse(Console.ReadLine());
                    Y = int.Parse(Console.ReadLine());
                    Coordonnee Tester1 = new Coordonnee(X, Y);

                    if (CercleIEstDans.CoordonneeEstDans(Tester1))
                        Console.WriteLine($"Le cercle {CercleIEstDans} est bien dans les coordonnée {Tester1} \n");
                    else
                        Console.WriteLine($"Le cercle {CercleIEstDans} n'est PAS dans les coordonnée {Tester1} \n");
                    Console.WriteLine("Continuez les test avec ces coordonner ? 0 pour arreter");
                    choix = Console.ReadLine();
                } while (choix != "0");

                Console.WriteLine("Changer de cercle ? 0 pour arreter autre pour changer");
                choix = Console.ReadLine();
            } while (choix != "0");
        }


        static void TesterNbrPolygon()
        {
            Coordonnee coord = new Coordonnee(0, 0);
            Carre testpolygonCarre = new Carre(coord, 2);

            Console.WriteLine($"Votre carré à {testpolygonCarre.NbSomments} de polygone");

            Rectangle testpolygonRect = new Rectangle(coord, 2, 3);

            Console.WriteLine($"Votre rectangle à {testpolygonRect.NbSomments} de polygone");
        }


        static void CalculeSurface()
        {
            Coordonnee coord = new Coordonnee(0, 0);
            Carre car = new Carre(coord, 2);
            Rectangle rect = new Rectangle(coord, 2, 3);
            Cercle cercl = new Cercle(coord, 2);

            // Calcul des surfaces en utilisant la classe MathHelpers
            double surfaceCarre = MathCalculation.CalculerSurfaceCarre(car);
            double surfaceRectangle = MathCalculation.CalculerSurfaceRectangle(rect);
            double surfaceCercle = MathCalculation.CalculerSurfaceCercle(cercl);


            Console.WriteLine($"Surface du carré: {surfaceCarre}");
            Console.WriteLine($"Surface du rectangle: {surfaceRectangle}");
            Console.WriteLine($"Surface du cercle: {surfaceCercle}");
        }

        static void EntreVal()
        {
            double NombreX;
            double Min;
            double Max;

            Console.WriteLine($"Entrez le nombre rechercher ");
            double.TryParse(Console.ReadLine(), out NombreX);

            Console.WriteLine($"Entrez la borne minimale ");
            double.TryParse(Console.ReadLine(), out Min);

            Console.WriteLine($"Entrez la borne maximale ");
            double.TryParse(Console.ReadLine(), out Max);


            if (MathCalculation.isBetween(NombreX, Min, Max))
                Console.WriteLine($"Votre nombre {NombreX} est bien entre {Min} et {Max}");
            else
                Console.WriteLine($"Votre nombre {NombreX} n'est pas entre {Min} et {Max}");
        }


        static void AfficheListe()
        {
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("Affichage de tous les objets de la liste");
            Console.WriteLine("---------------------------------------------------------------");
            int i = 0;
            foreach (Forme f in ListeDeForme)
            {
                i++;

                Console.WriteLine($"{i} - {f.ToString()}");

            }

            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("Affichage de tous les objets de la liste implémentant Ipolygon");
            Console.WriteLine("---------------------------------------------------------------");
            i = 0;
            foreach (Forme f in ListeDeForme)
            {
                if (f is IPolygon)
                {
                    i++;
                    Console.WriteLine($"{i} - {f.ToString()}");
                }
            }


            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("Affichage de tous les objets de la liste n'implémentant pas Ipolygon");
            Console.WriteLine("---------------------------------------------------------------");
            i = 0;
            foreach (Forme f in ListeDeForme)
            {
                if (f is not IPolygon)
                {
                    i++;
                    Console.WriteLine($"{i} - {f.ToString()}");
                }
            }

        }


        static void ListeTrier()
        {
            List<Carre> ListeDeFormeCarrer = new List<Carre>();

            Coordonnee c1 = new Coordonnee(10, 20);
            Carre Car1 = new Carre(c1, 10);
            ListeDeFormeCarrer.Add(Car1);


            Coordonnee c2 = new Coordonnee(0, 0);
            Carre Car2 = new Carre(c2, 17);
            ListeDeFormeCarrer.Add(Car2);

            Coordonnee c3 = new Coordonnee(5, 5);
            Carre Car3 = new Carre(c3, 4);
            ListeDeFormeCarrer.Add(Car3);


            Coordonnee c4 = new Coordonnee(15, 16);
            Carre Car4 = new Carre(c4, 95);
            ListeDeFormeCarrer.Add(Car4);


            Coordonnee c5 = new Coordonnee(102, 10);
            Carre Car5 = new Carre(c5, 15);
            ListeDeFormeCarrer.Add(Car5);



            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("Affichage avant tri");
            Console.WriteLine("---------------------------------------------------------------");

            int i = 0;
            foreach (Carre Carrer in ListeDeFormeCarrer)
            {
                i++;
                Console.WriteLine($"{i} - {Carrer.ToString()}");
            }

            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("Affichage après tri (des longueur uniquement)");
            Console.WriteLine("---------------------------------------------------------------");
            ListeDeFormeCarrer.Sort();

             i = 0;
            foreach (Carre Carrer in ListeDeFormeCarrer)
            {
                i++;
                Console.WriteLine($"{i} - {Carrer.ToString()}");
            }

            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("Affichage après tri (Des point d'accorche) OrderBy");
            Console.WriteLine("---------------------------------------------------------------");










        }
    }
}
