using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_3_3
{
    /// <summary>
    /// Klassen Ellipse ärver från den abstrakta basklassen Shape.
    /// </summary>
    class Ellipse : Shape
    {

        //Publik egenskapen av typen double som ska ge en ellips area. 
        public override double Area
        {

            get { return Math.PI * Width * Length; }    //return (double)Math.PI * Width * Length; }
        }

        //Publik egenskapen av typen double som ska ge en ellips omkrets. 
        public override double Perimeter
        {
            get { return Math.PI * Math.Sqrt(2 * Width * Width + 2 * Length * Length); }    //(double) Math.PI *Math.Sqrt(2*Width*Width +2*Length*Length);}
        }

        
 
        // Publik konstruktor som genom anrop av basklassens konstruktor ser till att det nya objektets längd och bredd sätts. 
        public Ellipse(double length, double width)
            :base(length, width)
        {
        }
    }
}
