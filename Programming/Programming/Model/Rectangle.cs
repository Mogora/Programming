using System;
using System.Collections.Generic;
using System.Text;

namespace Programming.Model
{
    public class Rectangle
    {
        private double _length;

        private double _width;
       
        public Rectangle()
        {

        }

        public Rectangle (double length, double width, string color, Point2D center)
        {
            Length = length;
            Width = width;
            Color = color;
            Center = center;
        }
        public string Color { get; set; }

        public Point2D Center { get; set; }

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
