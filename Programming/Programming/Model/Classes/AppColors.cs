﻿using Programming.Model;
using System;
using System.Drawing;
using System.Windows.Forms;
using Rectangle = Programming.Model.Geometry.Rectangle;
using System.Collections.Generic;
using Movie = Programming.Model.Classes.Movie;
using Programming.Model.Enums;
namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит данные о вызываемых цветах. System.Drawing.Color.FromArgb(127, 255, 127, 127);
    /// </summary>
    public static class AppColors
    {
        /// <summary>
        /// Цвет некорректного значения.
        /// </summary>
        public static System.Drawing.Color ErrorColor = System.Drawing.Color.LightPink;

        /// <summary>
        /// Цвет корректного значения.
        /// </summary>
        public static System.Drawing.Color CorrectColor = System.Drawing.Color.White;

        /// <summary>
        /// Цвет пересекающихся фигур.
        /// </summary>
        public static Color InContact = Color.FromArgb(127, 255, 127, 127);

        /// <summary>
        /// Цвет непересекающихся фигур.
        /// </summary>
        public static Color UnContact = Color.FromArgb(127, 127, 255, 127);
    }
}
