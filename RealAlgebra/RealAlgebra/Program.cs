using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShapeAreaLib;

namespace RealAlgebra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose a shape:");
            Console.WriteLine("1. Rectangle");
            Console.WriteLine("2. Square");
            Console.WriteLine("3. Circle");
            Console.WriteLine("4. Triangle");

            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter length: ");
                    double length = double.Parse(Console.ReadLine());
                    Console.Write("Enter width: ");
                    double width = double.Parse(Console.ReadLine());

                    Rectangle rectangle = new Rectangle();
                    double rectangleArea = rectangle.Area(length, width);
                    Console.WriteLine($"Area of Rectangle: {rectangleArea}");
                    break;

                case 2:
                    Console.Write("Enter side: ");
                    double side = double.Parse(Console.ReadLine());

                    Square square = new Square();
                    double squareArea = square.Area(side);
                    Console.WriteLine($"Area of Square: {squareArea}");
                    break;

                case 3:
                    Console.Write("Enter radius: ");
                    double radius = double.Parse(Console.ReadLine());

                    Circle circle = new Circle();
                    double circleArea = circle.Area(radius);
                    Console.WriteLine($"Area of Circle: {circleArea}");
                    break;

                case 4:
                    Console.Write("Enter base: ");
                    double triangleBase = double.Parse(Console.ReadLine());
                    Console.Write("Enter height: ");
                    double height = double.Parse(Console.ReadLine());

                    Triangle triangle = new Triangle();
                    double triangleArea = triangle.Area(triangleBase, height);
                    Console.WriteLine($"Area of Triangle: {triangleArea}");
                    break;

                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }

            Console.ReadKey();
        }
    }
}
