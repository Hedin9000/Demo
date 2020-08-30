using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using AreaCalculator.Shapes;

namespace AreaCalculator.Tests
{
    public class RectangleTestData: IEnumerable<object[]>
    {
        public IEnumerator<object[]> GetEnumerator()
        {
            yield return new object[] {(new Rectangle(new Vector2(0, 0), new Vector2(2, 2)), 4.0f)};
            yield return new object[] {(new Rectangle(new Vector2(-1, -1), new Vector2(-2, -6)), 5.0f)};
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}