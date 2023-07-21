using Shapes.Models;
using System;

namespace Shapes
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Shape circle = new Circle(5);
            Shape rectangle = new Rectangle(10, 15);

            Console.WriteLine(circle.Draw(circle));
        }
    }
}
