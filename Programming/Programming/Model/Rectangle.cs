using System;
using System.Collections.Generic;
using System.Text;

namespace Programming.Model
{
    public class Rectangle
    {
        private float _lenght;
        private float _widht;
        private string color;

        public Rectangle()
        {

        }

        public Rectangle(float lenght, float widht, string color)
        {
            Lenght = lenght;
            Widht = widht;
            Color = color;
        }
        public string Color { get; set; }
        public float Lenght
        {
            get
            {
                return _lenght;
            }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("Длина не может быть меньше 0");
                }
                _lenght = value;
            }
        }
        public float Widht
        {
            get
            {
                return _widht;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Ширина не может быть меньше 0");
                }
                _widht = value;
            }
        }
    }
}
