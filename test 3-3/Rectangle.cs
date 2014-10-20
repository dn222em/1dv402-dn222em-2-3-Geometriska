using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_3_3
{
    /// <summary>
    /// Klassen Rectangle ärver från den abstrakta basklassen Shape. I och med att det går att instansiera objekt av klassen, 
    /// d.v.s. den är konkret, implementerar de abstrakta egenskaperna Area och Perimeter i basklassen. 
    /// </summary>
    class Rectangle : Shape
    {
        ////Publik egenskapen av typen double som ska ge en rektangels area.
        public override double Area
        {
            
            get{ return (double.Parse(String.Format("{0:0.00}", Width * Length)));}
        }

        //Publik egenskapen av typen double som ska ge en rektangels omkrets.
        public override double Perimeter
        {
            get
            { return (double.Parse(String.Format("{0:0.00}", 2*(Width + Length))));}
        }

        //Publik konstruktor som genom anrop av basklassens konstruktor ser till att det nya objektets längd och bredd sätts. 
        public Rectangle(double length, double width)
            :base(0d, 0d)
        {
            Length = length;

            Width = width;
            
                    
        }
    }
}
