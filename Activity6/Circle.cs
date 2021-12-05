using System;

namespace CSharp.Activity.Polymorphism
{
    public class Circle : Shape
    {
        public double Radius { get; protected set; }

        public Circle(double Radius) : base()
        {
            this.Radius = Radius;
        }

        public Circle()
        {
        }

        public override void CalculateArea()
        {
            Area = Math.PI * Radius * Radius;

        }


        public override void Print()
        {
        }
    }

}

