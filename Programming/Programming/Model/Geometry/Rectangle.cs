using System;
using System.Collections.Generic;
using System.Text;

namespace Programming.Model.Geometry
{
    /// <summary>
    /// Хранит данные о прямоугольнике.
    /// </summary>
    public class Rectangle
    {
        /// <summary>
        /// Длина прямоугольника.
        /// </summary>
        private int _length;

        /// <summary>
        /// Ширина прямоугольника.
        /// </summary>
        private int _width;

        /// <summary>
        /// Количество прямоугольников.
        /// </summary>
        private static int _allRectanglesCount;

        /// <summary>
        /// Уникальный идентификатор для всех объектов данного класса.
        /// </summary>
        private int _id;

        /// <summary>
        /// Создает экземпляр класса <see cref="Rectangle"/>.
        /// </summary>
        /// <param name="rectangle"> Прямоугольник. </param>
        public Rectangle(Rectangle rectangle)
        {
            Id = rectangle.Id;
            Length = rectangle.Length;
            Width = rectangle.Width;
            Color = rectangle.Color;
            Center = new Point2D(rectangle.Center.X, rectangle.Center.Y);           
        }

        public Rectangle (int length, int width, string color, Point2D center)
        {
            Length = length;
            Width = width;
            Color = color;
            Center = center;
            _allRectanglesCount++;
            _id = _allRectanglesCount;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Rectangle"/>.
        /// </summary>
        public Rectangle()
        {
            _allRectanglesCount++;
            _id = _allRectanglesCount;
        }

        /// <summary>
        /// Возвращает и создает цвет прямоугольника. 
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// Возвращает и задаёт координаты центра прямоугольника.
        /// </summary>
        public Point2D Center { get; set; }

        /// <summary>
        /// Возвращает и задаёт уникальный идентификатор прямоугольника.
        /// </summary>
        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }

        /// <summary>
        /// Возвращает и создает количество всех прямоугольников.
        /// </summary>
        public static int AllRectanglesCount
        {
            get
            {
                return _allRectanglesCount;
            }
            set { }
        }
        
        /// <summary>
        /// Возвращает и создает длину прямоугольника. Должна быть положительной.
        /// </summary>
        public int Length
        {
            get
            {
                return _length;
            }
            set
            {
                Validator.AssertOnPositiveValue(nameof(Length), value);
                _length = value;
            }
        }

        /// <summary>
        /// Возвращает и создает ширину прямоугольника. Должна быть положительной.
        /// </summary>
        public int Width
        {
            get
            {
                return _width;
            }
            set
            {
                Validator.AssertOnPositiveValue(nameof(Width), value);
                _width = value;
            }
        }
    }
}
