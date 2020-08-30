using System;
using System.Collections.Generic;
using System.Numerics;


namespace AreaCalculator.Shapes
{
    
    public class Triangle : Polygon
    {
        /// <summary>
        /// Первая вершина
        /// </summary>
        public Vector2 FirstDot { get; }
        /// <summary>
        /// Вторая вершина
        /// </summary>
        public Vector2 SecondDot { get;  }
        /// <summary>
        /// Третья вершина
        /// </summary>
        public Vector2 ThirdDot { get; }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="firstDot">Первая вершина</param>
        /// <param name="secondDot">Вторая вершина</param>
        /// <param name="thirdDot">Третья вершина</param>
        public Triangle(Vector2 firstDot, Vector2 secondDot, Vector2 thirdDot)
        :base(firstDot, secondDot, thirdDot)
        {
            FirstDot = firstDot;
            SecondDot = secondDot;
            ThirdDot = thirdDot;
        }


       
            
    }
}