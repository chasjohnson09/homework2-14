using System;
using System.Collections.Generic;
using System.Text;

namespace GeometricShapes
{
    class Rectangle
    {
        public int side1 { get; set; }
        public int side2 { get; set; }
    
        public int Perimeter()
        {
            return 2 * (side2 + side1);
        }

        public int Area()   // how to return area for the variale
        {
            return side1 * side2;
        }

        public Rectangle()
        {
        }  
        public Rectangle( int s1, int s2)
        {
            side1 = s1;
            side2 = s2;
        }
        
    }
}
