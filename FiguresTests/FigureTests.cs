using System;
using MindboxTask;
using NUnit.Framework;

namespace FiguresTests
{
    public class FigureTests
    {
        [Test]
        public void TriangleWithPositivePoints_GetArea()
        {
            //Arrange
            var triangle = new Triangle(0, 0, 0, 10, 10, 0);
            const double rightArea = 50.0;
            
            //Act
            var area = triangle.GetArea();
            
            //Assert
            Assert.AreEqual(rightArea, area);
        }
        
        [Test]
        public void TriangleWithNegativePoints_GetArea()
        {
            //Arrange
            var triangle = new Triangle(0, 0, 0, -10, -10, 0);
            const double rightArea = 50.0;
            
            //Act
            var area = triangle.GetArea();
            
            //Assert
            Assert.AreEqual(rightArea, area);
        }
        
        [Test]
        public void TriangleWithPositivePoints_TriangleIsRight()
        {
            //Arrange
            var triangle = new Triangle(0, 0, 0, 10, 10, 0);
            
            //Act
            var isRight = triangle.IsRightTriangle();
            
            //Assert
            Assert.IsTrue(isRight);
        }
        
        [Test]
        public void TriangleWithNegativePoints_TriangleIsRight()
        {
            //Arrange
            var triangle = new Triangle(0, 0, 0, -10, -10, 0);
            
            //Act
            var isRight = triangle.IsRightTriangle();
            
            //Assert
            Assert.IsTrue(isRight);
        }
        
        [Test]
        public void Triangle_IsNotRight()
        {
            //Arrange
            var triangle = new Triangle(1, 1, 0, 10, 10, 0);
            
            //Act
            var isRight = triangle.IsRightTriangle();
            
            //Assert
            Assert.IsFalse(isRight);
        }
        
        [Test]
        public void Circle_AreaIsRight()
        {
            //Arrange
            const int radius = 10;
            
            var circle = new Circle(radius);
            var rightArea = Math.PI * Math.Pow(radius, 2);
            
            //Act
            var area = circle.GetArea();
            
            Assert.AreEqual(rightArea, area);
        }

        [Test]
        public void Figures_AreasAreRight()
        {
            //Arrange
            Figure firstFigure = new Triangle(0, 0, 0, 10, 10, 0);
            var firstFigureRightArea = 50;
            
            const int radius = 20;
            Figure secondFigure = new Circle(radius);
            var secondFigureRightArea = Math.PI * Math.Pow(radius, 2);
            
            //Act
            var firstFigureArea = firstFigure.GetArea();
            var secondFigureArea = secondFigure.GetArea();
            
            //Assert
            Assert.AreEqual(firstFigureRightArea, firstFigureArea);
            Assert.AreEqual(secondFigureRightArea, secondFigureArea);
        }
    }
}