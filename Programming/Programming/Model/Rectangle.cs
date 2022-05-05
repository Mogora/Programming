using System;
using System.Collections.Generic;
using System.Text;

namespace Programming.Model
{
    public class Rectangle
    {
        private double _length;

        private double _width;

        private static int _allRectanglesCount;

        private int _id;

        public Rectangle()
        {
            _allRectanglesCount++;
        }

        public Rectangle (double length, double width, string color, Point2D center, int allRectanglesCount)
        {
            Length = length;
            Width = width;
            Color = color;
            Center = center;
            AllRectanglesCount = allRectanglesCount;
            _allRectanglesCount++;
            _id = _allRectanglesCount;
        }
        public string Color { get; set; }

        public Point2D Center { get; set; }

        public int Id
        {
            get
            {
                return _id;
            }
        }

        public static int AllRectanglesCount
        {
            get
            {
                return _allRectanglesCount;
            }
            set { }
        }
            

        public double Length
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
        public double Width
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
