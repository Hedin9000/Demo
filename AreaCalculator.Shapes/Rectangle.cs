using System;
using System.Collections.Generic;
using System.Numerics;

namespace AreaCalculator.Shapes
{
    public class Rectangle : Polygon
    {
        public Vector2 PositionStart { get; }
        public Vector2 PositionEnd { get; }


        public Rectangle(Vector2 positionStart, Vector2 positionEnd)
            :base(GetDots(positionStart, positionEnd))
        {
            PositionStart = positionStart;
            PositionEnd = positionEnd;
        }

        private static List<Vector2> GetDots(Vector2 positionStart, Vector2 positionEnd)
        {
            return new List<Vector2>()
            {
                new Vector2(positionStart.X, positionStart.Y),
                new Vector2(positionStart.X, positionEnd.Y),
                new Vector2(positionEnd.X, positionEnd.Y),
                new Vector2(positionEnd.X, positionStart.Y)
            };
        }
        


      
    }
}