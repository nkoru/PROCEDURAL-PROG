using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewObjectOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(); // Instantiate Circle class
            circle.Color = "Red";
            circle.Radius = 5;

            Rectangle rectangle = new Rectangle(); // Instantiate Rectangle class
            rectangle.Color = "Blue";
            rectangle.Width = 10;
            rectangle.Height = 4;

            // Display Circle details
            Console.WriteLine("\tCircle");
            Console.WriteLine("\nColor: " + circle.Color);
            Console.WriteLine("Radius: " + circle.Radius);

            Console.WriteLine("Formula: Area = π × radius × radius");
            Console.WriteLine("Area: " + circle.GetArea().ToString("F2")); // Round to 2 decimals
            Console.WriteLine();

            // Display Rectangle details
            Console.WriteLine("\tRectangle");
            Console.WriteLine("\nColor: " + rectangle.Color);
            Console.WriteLine("Width: " + rectangle.Width);
            Console.WriteLine("Height: " + rectangle.Height);

            Console.WriteLine("Formula: Area = width × height");
            Console.WriteLine("Area: " + rectangle.GetArea().ToString("F2")); // Round to 2 decimals

            Console.ReadKey();
        }
    }
}

