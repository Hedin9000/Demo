using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using AreaCalculator.Shapes;

namespace AreaCalculator.Core
{
    public static class AdvancedMath
    {
        /// <summary>
        /// Возвращает площадь фигуры
        /// </summary>
        /// <param name="shape"></param>
        /// <returns></returns>
        public static float Area(Polygon shape)
        {
            // Специальная обработка для круга, так как он единственная фигура, которая не является многоугольником.
            if (shape is Circle circle)
                return Convert.ToSingle(Math.PI * Math.Pow(circle.Radius, 2));
            return Area(shape.GetDots());
        }
        /// <summary>
        /// Возвращает площадь произвольного простого многоугольника, по списку его вершин
        /// </summary>
        /// <param name="dots"></param>
        /// <returns></returns>
        public static float Area(List<Vector2> dots)
        {
            //Формула площади Гаусса
            //https://ru.wikipedia.org/wiki/%D0%A4%D0%BE%D1%80%D0%BC%D1%83%D0%BB%D0%B0_%D0%BF%D0%BB%D0%BE%D1%89%D0%B0%D0%B4%D0%B8_%D0%93%D0%B0%D1%83%D1%81%D1%81%D0%B0
            var area = default(float);

            for (var i = 0; i < dots.Count - 1; i++) 
                area += dots[i].X * dots[i + 1].Y - dots[i].Y * dots[i + 1].X;

            area += dots[^1].X * dots[0].Y - dots[^1].Y * dots[0].X;

            return Math.Abs(area) / 2f;
        }
    }
}