using System;
using System.Collections.Generic;
using System.Text;

namespace GeometricShapes
{
    class Square
    {
        public int side1 { get; set; }

        public int Perimeter()
        {
            return side1 * 4;
        }

        public int Area()
        {
            return side1 * side1;
        }

        public Square()
        {
        }

        public Square( int s1)
        {
            side1 = s1;
        }

    }
}
