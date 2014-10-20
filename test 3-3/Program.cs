using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_3_3
{
    /// <summary>
    ///  Applikationen grupperar beräkningarna av olika figurers area och omkrets.
    ///  Ellipse & Rektangel.
    ///  Klassen Program och den uppräkningsbara typen ShapeType används för att skriva den menystyrda delen av applikationen där användaren väljer vilken figur
    ///  för vilken längd och bredd ska matas in, area och omkrets beräknas samt figurens detaljer presenteras. 
    /// </summary>
    class Program
    {
        /// <summary>
        /// Den privata statiska metoden CreateShape läser in en figurs längd och bredd, 
        /// skapar objektet och returnerar en referens till det. 
        /// </summary>
        /// <param name="shapeType"></param>
        /// <returns></returns> 
        private static Shape CreateShape(ShapeType shapeType)
        {
             
           switch (shapeType)
           {
            case ShapeType.Rectangle:

            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" ===================================");
            Console.WriteLine(" =           Rektangel             =");
            Console.WriteLine(" ===================================\n");
            Console.ResetColor();
            Rectangle ab = new Rectangle(0, 0);


            return ab;
                   

            case ShapeType.Ellipse:
           
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" ===================================");
            Console.WriteLine(" =            Ellips               =");
            Console.WriteLine(" ===================================\n");
            Console.ResetColor();
            
            Ellipse cd = new Ellipse(0, 0);

            return cd;
               
               
            default:
            throw new NotImplementedException();
      
           }         
        }
         
        /// <summary>
        /// Den uppräkningsbara typen ShapeType används för att definiera vilka typer av figurer applikationen kan hantera. 
        /// Typen används då metoden Main() anropar metoden CreateShape() för att informera vilken typ av figur som ska skapas.
        /// </summary>
       
        public enum ShapeType {shapeType, Ellipse, Rectangle };


        /// <summary>
        /// Metoden Main anropar metoden ViewMenu() för att visa en meny. Väljer användaren att inte avsluta applikationen,
        /// anropas metoden CreateShape() som skapar och returnerar en referens till ett Ellips- eller Rectangle-objekt. 
        /// Referensen till objektet används sedan vid anrop av ViewDetail() som presenterar figurens detaljer. 
        /// Då en beräkning är gjord visas menyn på nytt. 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.Title = "Geometriska Figurer - nivå A";
            bool exit = false;
            do
            {

                ViewMenu();
                
                int index;
                try 
                { 
               
                    index = int.Parse(Console.ReadLine());
                   
                if (index < 0 || index > 2)
                {
                    throw new ArgumentException();
                }
                
                }
                catch(Exception)
                {
                    
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\nFEL! Ange ett nummer mellan 0 och 2. :  ");
                    Console.ResetColor();

                    Console.BackgroundColor = ConsoleColor.DarkBlue;     // D R Y?
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\nTryck tangent för att fortsätta    \n");
                    Console.ResetColor();
                    if (Console.ReadKey(true).Key == ConsoleKey.Enter)
                    {
                        continue;
                    }
                    return;
                   // return;
                }

               
                if (index == 0)
                {
                    Environment.Exit(index);
                }


                ShapeType shapeType = ShapeType.shapeType;
                //ShapeType shapeType = new ShapeType();


                switch (index)
                {
                    case 0:
                        exit = true;
                        break;
                    case 1:
                        shapeType = ShapeType.Ellipse;
                        break;
                    case 2:
                        shapeType = ShapeType.Rectangle;
                        break;

                }


                Shape anknown = CreateShape(shapeType);


                string line = "Ange längden:   ";
                string brädd = "Ange brädden:   ";
                anknown.Length = ReadDoubbleGreaterThanZero(line);
                anknown.Width = ReadDoubbleGreaterThanZero(brädd);

                ViewShapeDetail(anknown);

                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\nTryck tangent för att fortsätta    \n");
                Console.ResetColor();
                if (Console.ReadKey(true).Key == ConsoleKey.Enter)
                {
                    continue;
                }
                return;
            } while (!exit);
         
        }


        /// <summary>
        /// Den privata statiska metoden ViewMenu() presenterar endast en meny.
        /// </summary>
        private static void ViewMenu()
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" ===================================");
            Console.WriteLine(" =                                 =");
            Console.WriteLine(" =       Geometriska Figurer       =");
            Console.WriteLine(" =                                 =");
            Console.WriteLine(" ===================================");


            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("\n 0. Avsluta.\n");
            Console.WriteLine(" 1. Ellipse.\n");
            Console.WriteLine(" 2. Rektangel.\n");
            Console.WriteLine(" ----------------------------------\n");
            Console.Write(" Ange menyval [0-2]:  ");
            Console.ResetColor();

        }

        /// <summary>
        /// Den privata statiska metoden ReadDoubleGreaterThanZero() returnerar ett värde av typen double som är större än 0. 
        /// Till metoden är det vara möjligt att skicka med ett argument. Argument är en sträng med information som visas i anslutning till där inmatningen av värdet sker.      /// </summary>
        /// <param name="prompt"></param>
        /// <returns></returns>
        private static double ReadDoubbleGreaterThanZero(string prompt)
        {
            
            while (true)
            {
                try
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("\n{0}",prompt);
                    Console.ResetColor();

                    double dimension = double.Parse(Console.ReadLine());

                    if (dimension <= 0)
                    {
                        throw new ArgumentException();
                    }
                    return dimension;
                }
                catch (Exception ex)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("\nFEL! Ange ett flyttal större än 0.\n", ex.Message);
                    Console.ResetColor();
                }
            }
        }

        /// <summary>
        /// Den privata statiska metoden ViewShapewDetail() presenterar en figurs detaljer. När metoden anropas skickas ett argument med,
        /// som refererar till figurens vars detaljer presenteras. Parametern shape av typen Shape refererar till figuren. 
        /// </summary>
        /// <param name="shape"></param>
        private static void ViewShapeDetail(Shape shape)
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" ===================================");
            Console.WriteLine(" =           Detaljer              =");
            Console.WriteLine(" ===================================\n");
            Console.ResetColor();

            String.Format("{0:c}  {1:c}",shape.Area, shape.Perimeter);
            Console.WriteLine(shape);
            Console.WriteLine(" ===================================\n");
        
        }
    }
}         
