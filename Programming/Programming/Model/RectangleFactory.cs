﻿using System;
using System.Collections.Generic;
using System.Text;
using Color = Programming.Model.Colors;

namespace Programming.Model
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
    }
}

