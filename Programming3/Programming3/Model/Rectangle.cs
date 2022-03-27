using System;
using System.Collections.Generic;
using System.Text;

namespace Programming3.Model
{
    public class Rectangle
    {
        private float _lenght;
        private float _widht;
       

        public Rectangle(float lenght, float widht, string colour)
        {
            Lenght = lenght;
            Widht = widht;
            Colour = colour;
        }

        public float Lenght { get; }
        public float Widht { get; private set; }
        public string Colour { get; private set; }
    }
    
}
