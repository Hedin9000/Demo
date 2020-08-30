using System.Collections.Generic;
using System.Numerics;

namespace AreaCalculator.Shapes
{
    public class Circle: Polygon
    {
        /// <summary>
        /// Радиус
        /// </summary>
        public float Radius { get; }
        /// <summary>
        /// Положение в пространстве
        /// </summary>
        public Vector2 Position { get; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="radius">Радиус</param>
        /// <param name="position"><Положение в пространстве/param>
        public Circle(float radius, Vector2 position) 
        :base(position)
        {
            Radius = radius;
            Position = position;
        }

       
    }
}