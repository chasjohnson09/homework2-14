using System;
using System.Collections.Generic;
using System.Text;

namespace GeometricShapes
{
    class Quad
    {
        public int side1 { get; set; }  // properties for the new class
        public int side2 { get; set; }
        public int side3 { get; set; }
        public int side4 { get; set; }
        
        public int Perimeter()
        {
            return (side1 + side2 + side3 + side4);
        }

        public Quad()
        {
            
        }
        public Quad(int s1, int s2, int s3, int s4) // constructor for creating properties for new class
        {
            side1 = s1;
            side2 = s2;
            side3 = s3;
            side4 = s4;

        }

    }
}
