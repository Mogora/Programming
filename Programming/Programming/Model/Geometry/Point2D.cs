using System;
using System.Collections.Generic;
using System.Text;

namespace Programming.Model.Geometry
{
    /// <summary>
    /// Хранит данные о координатах центра геометрической фигуры.
    /// </summary>
    public class Point2D
    {
        /// <summary>
        /// Координата х.
        /// </summary>
        private int _x;

        /// <summary>
        /// Координата y.
        /// </summary>
        private int _y;

        /// <summary>
        /// Создает экземпляр класса <see cref="Point2D"/>.
        /// </summary>
        /// <param name="x"> Координата х. Должна быть положительным числом. </param>
        /// <param name="y"> Координата y. Должна быть положительным числом. </param>
        public Point2D (int x, int y)
        {
            X = x;
            Y = y;
        }

        /// <summary>
        /// Возвращает и создает координату х. Должна быть положительным числом.
        /// </summary>
        public int X
        {
            get
            {
                return _x;
            }
            set
            {
                Validator.AssertOnPositiveValue(nameof(X), value);
                _x = value;
            }      
        }

        /// <summary>
        /// Возвращает и создает координату y. Должна быть положительным числом.
        /// </summary>
        public int Y
        {
            get
            {
                return _y;
            }
            set
            {
                Validator.AssertOnPositiveValue(nameof(Y), value);
                _y = value;
            }
        }
    }
}
