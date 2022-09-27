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
        ///  Уникальный идентификатор для всех объектов данного класса.
        /// </summary>
        private readonly int _id;

        public Rectangle(int length, int width, string color, Point2D center)
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
        /// Возвращает уникальный идентификатор прямоугольника.
        /// </summary>
        public int Id => _id;

        /// <summary>
        /// Возвращает и создает цвет прямоугольника. 
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// Возвращает и задаёт координаты центра прямоугольника.
        /// </summary>
        public Point2D Center { get; set; }

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
