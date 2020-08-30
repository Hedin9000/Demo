using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;

namespace AreaCalculator.Shapes
{
    public class Polygon 
    {
        public List<Vector2> Dots { get; }

        public Polygon(params Vector2[] dots) : this(dots.ToList())
        {
        }


        public Polygon(List<Vector2> dots)
        {
            if(!dots.Any()  && dots.Count !=2)
                throw new InvalidEnumArgumentException("У фигуры должно быть минимум 3 точки, для создания круга используйте AreaCalculator.Shapes.Circle");
            Dots = dots;
        }

        public List<Vector2> GetDots()
            => Dots;
    }
}