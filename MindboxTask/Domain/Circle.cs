using System;

namespace MindboxTask
{
    public class Circle : Figure
    {
        public Circle(double radius)
        {
            _radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * Math.Pow(_radius, 2);
        }

        private readonly double _radius;
    }
}