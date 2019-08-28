using System;

namespace MindboxTask
{
    public class Triangle : Figure
    {
        public Triangle(double pointA, double pointB, double pointC)
        {
            _pointA = pointA;
            _pointB = pointB;
            _pointC = pointC;
            
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
            return _edgeAB > _edgeBC && _edgeAB > _edgeAC
                   || _edgeAC > _edgeBC && _edgeAC > _edgeAB
                   || _edgeBC > _edgeAB && _edgeBC > _edgeAC;
        }

        private void CalculateEdges()
        {
            var pointASquare = Math.Pow(_pointA, 2);
            var pointBSquare = Math.Pow(_pointB, 2);
            var pointCSquare = Math.Pow(_pointC, 2);
            
            _edgeAB = Math.Sqrt(pointASquare - pointBSquare);
            _edgeAC = Math.Sqrt(pointASquare - pointCSquare);
            _edgeBC = Math.Sqrt(pointBSquare - pointCSquare);
        }

        private double _edgeAB;
        private double _edgeAC;
        private double _edgeBC;
        
        private readonly double _pointA;
        private readonly double _pointB;
        private readonly double _pointC;
    }
}