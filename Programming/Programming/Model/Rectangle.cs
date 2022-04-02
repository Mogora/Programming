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
                if(value < 0)
                {
                    throw new ArgumentException("Длина не может быть меньше 0");
                }
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
                if (value < 0)
                {
                    throw new ArgumentException("Ширина не может быть меньше 0");
                }
                _width = value;
            }
        }
    }
}
