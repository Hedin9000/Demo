using System;
using System.Collections.Generic;
using System.Numerics;
using AreaCalculator.Core;
using AreaCalculator.Shapes;
using Xunit;

namespace AreaCalculator.Tests
{
    public class ShapesTest
    {
        [Theory]
        [ClassData(typeof(RectangleTestData))]
        public void Rectangle((Rectangle Rectangle, float Area) data)
        {
            var area = AdvancedMath.Area(data.Rectangle);
            
            Assert.Equal(data.Area, area);
        }

        [Fact]
        public void Triangle()
        {
            var triangle = new Triangle(new Vector2(-1, 0), new Vector2(0, 3), new Vector2(1,0));
            
            var area = AdvancedMath.Area(triangle);
            
            Assert.Equal(3.0f, area);
        }
        
        [Fact]
        public void Polygon()
        {
            var polygon = new Polygon(
                new Vector2(-1, -1),
                new Vector2(-1, 1),
                new Vector2(0, 2),
                new Vector2(1, 1),
                new Vector2(1, -1),
                new Vector2(0, -2)
            );
            
            var area = AdvancedMath.Area(polygon);
            
            Assert.Equal(6.0f, area);
        }
        
        [Fact]
        public void Circle()
        {
            const int radius = 10;
            var circle = new Circle(radius ,Vector2.Zero);

            var area = AdvancedMath.Area(circle);
            var theory = Convert.ToSingle(Math.PI * Math.Pow(radius,2));
            
            Assert.Equal(theory, area);
        }
    }
}