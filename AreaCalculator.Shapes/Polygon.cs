using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;

namespace AreaCalculator.Shapes
{
    public class Polygon
    {
        private readonly List<Vector2> _dots;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dots">Вершины фигуры</param>
        public Polygon(params Vector2[] dots) : this(dots.ToList())
        {
        }

        /// <summary>
        /// Создает произвольный многоугольник из 3 и более вершин.
        /// </summary>
        /// <param name="dots">Вершины фигуры</param>
        public Polygon(List<Vector2> dots)
        {
            // Одна вершина может быть у круга, для него нужна специльная обработка
            if (!dots.Any() && dots.Count != 2)
                throw new InvalidEnumArgumentException(
                    "У фигуры должно быть минимум 3 точки, для создания круга используйте AreaCalculator.Shapes.Circle");
            _dots = dots;
        }

        /// <summary>
        /// Список всех вершин многоугольника
        /// </summary>
        /// <returns></returns>
        public List<Vector2> GetDots()
            => _dots;
    }
}