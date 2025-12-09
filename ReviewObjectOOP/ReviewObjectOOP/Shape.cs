using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewObjectOOP
{
    abstract class Shape
    {
        public string Color { get; set; }

        public abstract double GetArea(); 
    }

    class Circle : Shape // Derived class for Circle
    {
        public double Radius { get; set; }

        public override double GetArea()
        {
            return Math.PI * Radius * Radius; // Formula: Area = π × radius × radius
        }
    }

    class Rectangle : Shape // Derived class for Rectangle
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public override double GetArea()
        {
            return Width * Height; // Formula: Area = width × height
        }
    }
}
