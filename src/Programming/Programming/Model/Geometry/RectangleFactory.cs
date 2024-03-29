﻿using System;
using Color = Programming.Model.Enums.Colors;

namespace Programming.Model.Geometry
{
    /// <summary>
    /// Предоставляет методы для создания прямоугольников.
    /// </summary>
    public class RectangleFactory
    {
        /// <summary>
        /// Отступ внутри элемента размещения прямоугольников.
        /// </summary>
        private const int Margin = 15;

        /// <summary>
        /// Случайные значения.
        /// </summary>
        private static Random _random = new Random();

        /// <summary>
        /// Создаёт прямоугольник со случайными значениями длины, ширины и координат.
        /// </summary>
        /// <param name="widthCanvas">Ширина элемента размещения. </param>
        /// <param name="lengthCanvas"> Длина элемента размещения. </param>
        /// <returns> Возвращает объект <see cref="Rectangle". </returns>
        public static Rectangle Randomize(int widthCanvas, int lengthCanvas)
        {
            var colors = Enum.GetValues(typeof(Color));
            Rectangle rectangle = new Rectangle();
            rectangle.Width = _random.Next(10, 110);
            rectangle.Length = _random.Next(10, 110);
            rectangle.Center = new Point2D(_random.Next(Margin, widthCanvas - rectangle.Width - Margin),
                                           _random.Next(Margin, lengthCanvas - rectangle.Length - Margin));
            rectangle.Color = colors.GetValue(_random.Next(0, colors.Length)).ToString();
            return rectangle;
        }
    }
}

