using System.Collections.Generic;
using System.Numerics;

namespace AreaCalculator.Shapes
{
    public class Circle: Polygon
    {
        public float Radius { get; }
        
        public Vector2 Position { get; }

        public Circle(float radius, Vector2 position) 
        :base(position)
        {
            Radius = radius;
            Position = position;
        }

       
    }
}