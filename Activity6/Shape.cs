using System;

namespace CSharp.Activity.Polymorphism
{
    public abstract class Shape : IPrintable
    {
        public double Area { get; protected set; }

        public abstract double CalculateArea();

        public virtual void Print()
        {
            Console.WriteLine($"The area is: {Area}");

        }
    }

}
