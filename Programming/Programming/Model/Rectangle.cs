using System;
using System.Collections.Generic;
using System.Text;

namespace Programming.Model
{
    public class Rectangle
    {
        private float _length;

        private float _width;
       
        public Rectangle()
        {

        }

        public Rectangle(float length, float width, string color)
        {
            Length = length;
            Width = width;
            Color = color;
        }
        public string Color { get; set; }

        public float Length
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
        public float Width
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
