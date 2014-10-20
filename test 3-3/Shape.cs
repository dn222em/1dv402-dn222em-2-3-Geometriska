using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_3_3
{
    /// <summary>
    /// Den abstrakta klassen Shape innehåller såväl konkreta som abstrakta medlemmar gemensamma för figurer som,
    /// ellips och rektangel. 
    /// </summary>
    abstract class Shape
    {
        //Privat fält av typen double representerande en figurs längd. 
        private double _length;
        //Privat fält av typen double representerande en figurs bredd
        private double _width;

        
        // Publik egenskap av typen double som kapslar in fältet _length. 
        public double Length
        {
            get { return _length; }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }
                _length = double.Parse(String.Format("{0:0.00}",value));
            }
        }

        //Publik egenskap av typen double som kapslar in fältet _width. 
        public double Width
        {
            get {return _width;}
            set
            { 
                if (value < 0)
                {
                    throw new ArgumentException();
                }
                _width = double.Parse(String.Format("{0:0.00}",value));                
            }
        }

        // Publik abstrakt egenskap av typen double representerande en figurs area. 
        public abstract double Area {get;}

        //Publik abstrakt egenskap av typen double representerande en figurs omkrets. 
        public abstract  double Perimeter { get;}

        //Konstruktorn, är ”protected”, ansvarar för att fälten, via egenskaperna, tilldelas de värden konstruktorns parametrar har. 
        protected Shape(double length, double width)
        {
            Length = length;
            Width = width;
        }
        
        /// <summary>
        /// Publik metod som överskuggar metoden ToString() i basklassen Object. Metoden returnerar en sträng representerande värdet av en instans.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            
            string horizontalLine = Length.ToString();
            string verticalLine = Width.ToString();

            //String.Format("{0:c}", Area);
           // String.Format("{0:c}", Perimeter);
            //string area = Area.ToString(String.Format("{0:c}",Area - Area));
            //string perimeter = Perimeter.ToString(String.Format("{0:c}",Perimeter - Perimeter));

            string area = Area.ToString();
            string perimeter = Perimeter.ToString();
            
          
            return String.Format(" Längd  :{0, 10}\n Höjd   :{1, 10}\n Omkrets:{2, 10}\n Area   :{3, 10}",horizontalLine, verticalLine, perimeter, area);  //base.ToString();

        }
   }
}
