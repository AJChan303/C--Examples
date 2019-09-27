using System;

namespace OOPShapesProject {
    class Program {
        static void Main(string[] args) {

            var sqrcomp = new SquareCompt(5);
            var p = sqrcomp.GetPerimeter();
            var a = sqrcomp.Area();
            Console.WriteLine($"The Perimeter of sqrComp is {p} the area is {a}");


            var quad1 = new Quad(5, 7, 13, 6);

            var perimeter = quad1.GetPerimeter();
            Console.WriteLine($"The quad Perimeter is { perimeter}m");
            var rect1 = new Rect(5, 13);
            perimeter = rect1.GetPerimeter();
            Console.WriteLine($"The rect Perimeter is { perimeter}m");
            var square = new Square(7);
            perimeter = square.GetPerimeter();
            Console.WriteLine($"The square perimeter is {perimeter}m");
            var area = rect1.Area();
            Console.WriteLine($"Rectangle area is {area}m");
            area = square.Area();
            Console.WriteLine($"Area of the square is {area}m");
            //area = quad1.Area();
            var n = square.side3;
            Console.WriteLine($"{n}");
        }
    }
}
