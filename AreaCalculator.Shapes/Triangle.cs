using System;
using System.Collections.Generic;
using System.Numerics;


namespace AreaCalculator.Shapes
{
    
    public class Triangle : Polygon
    {
        public Vector2 FirstDot { get; }
        public Vector2 SecondDot { get;  }
        public Vector2 ThirdDot { get; }

        public Triangle(Vector2 firstDot, Vector2 secondDot, Vector2 thirdDot)
        :base(firstDot, secondDot, thirdDot)
        {
            FirstDot = firstDot;
            SecondDot = secondDot;
            ThirdDot = thirdDot;
        }


       
            
    }
}