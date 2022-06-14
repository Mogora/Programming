using System;
using System.Collections.Generic;
using System.Text;
using Color = Programming.Model.Enums.Colors;

namespace Programming.Model.Geometry
{
    public class RectangleFactory
    {
        private const int Margin = 15;

        private static Random _random = new Random();

        public static Rectangle Randomize(int widthCanvas, int lengthCanvas)
        {
            var colors = Enum.GetValues(typeof(Color));
            Rectangle rectangle = new Rectangle();
            rectangle.Width = _random.Next(10, 110);
            rectangle.Length = _random.Next(10, 110);
            rectangle.Center = new Point2D(_random.Next(Margin, widthCanvas - rectangle.Width),
                _random.Next(Margin, lengthCanvas - rectangle.Length));
            rectangle.Color = colors.GetValue(_random.Next(0, colors.Length)).ToString();

            return rectangle;
        }

        public static Rectangle Randomize()
        {
            var colors = Enum.GetValues(typeof(Color));
            Rectangle rectangle = new Rectangle();
            rectangle.Center = new Point2D(_random.Next(Margin, 500), _random.Next(Margin, 500));
            rectangle.Width = _random.Next(1, 1001);
            rectangle.Length = _random.Next(1, 1001);
            rectangle.Color = colors.GetValue(_random.Next(0, colors.Length)).ToString();

            return rectangle;
        }
    }
}

