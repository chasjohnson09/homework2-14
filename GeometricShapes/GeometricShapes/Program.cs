using System;

namespace GeometricShapes
{
    class Program
    {
        static void Main(string[] args)
        {
            var rect1 = new Rectangle(4,6);
            var Rperimeter = rect1.Perimeter();
            Console.WriteLine($"rect1 perimeter = {rect1.Perimeter()} area is {rect1.Area()}");
            var rect2 = new Rectangle(5, 8);
            Console.WriteLine($"rect2 perimeter = {rect2.Perimeter()} area is {rect2.Area()}");

            var quad1 = new Quad(3, 4, 5, 6);
            var Qperimeter = quad1.Perimeter();
            Console.WriteLine($" quad1's perimeter = {Qperimeter}");
            var quad2 = new Quad(2, 5, 3, 5);
            Console.WriteLine($" quad2's perimeter = {quad2.Perimeter()}");

            var square1 = new Square(5);
            var Sperimter = square1.Perimeter();
            Console.WriteLine($"square1 perimeter = {square1.Perimeter()} area is {square1.Area()}");

        }

    }
}
