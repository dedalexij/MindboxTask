using System;

namespace MindboxTask
{
    public class Triangle : Figure
    {
        public Triangle(double pointAx, double pointAy, double pointBx, double pointBy, double pointCx, double pointCy)
        {
            _pointA = new Point(pointAx, pointAy);
            _pointB = new Point(pointBx, pointBy);
            _pointC = new Point(pointCx, pointCy);
            
            CalculateEdges();
        }

        public override double GetArea()
        {
            var halfPerimeter = 0.5 * (_edgeAB + _edgeAC + _edgeBC);

            return Math.Sqrt(
                halfPerimeter * (halfPerimeter - _edgeAB) * (halfPerimeter - _edgeAC) * (halfPerimeter - _edgeBC));
        }

        public bool IsRightTriangle()
        {
            return IsHypotenuseEqualLegs(_edgeAB, _edgeAC, _edgeBC)
                   || IsHypotenuseEqualLegs(_edgeAC, _edgeAB, _edgeBC)
                   || IsHypotenuseEqualLegs(_edgeBC, _edgeAC, _edgeAB);
        }

        private void CalculateEdges()
        {
            _edgeAB = CalculateEdge(_pointA, _pointB);
            _edgeAC = CalculateEdge(_pointA, _pointC);
            _edgeBC = CalculateEdge(_pointB, _pointC);
        }

        private double CalculateEdge(Point pointA, Point pointB)
        {
            return Math.Sqrt(Math.Pow(pointB.X - pointA.X, 2) + Math.Pow(pointB.Y - pointA.Y, 2));
        }

        private bool IsHypotenuseEqualLegs(double hypotenuse, double leg1, double leg2)
        {
            return Math.Abs(Math.Pow(hypotenuse, 2) - (Math.Pow(leg1, 2) + Math.Pow(leg2, 2))) < 0.0000008;
        }

        private double _edgeAB;
        private double _edgeAC;
        private double _edgeBC;
        
        private readonly Point _pointA;
        private readonly Point _pointB;
        private readonly Point _pointC;
    }
}