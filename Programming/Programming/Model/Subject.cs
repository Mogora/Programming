using System;
using System.Collections.Generic;
using System.Text;

namespace Programming.Model
{
    public class Subject
    {
        private string _name;
        private int _mark;
        private string _teacher;
        
        public Subject(string name, int mark, string teacher)
        {
            Name = name;
            Mark = mark;
            Teacher = teacher;
        }

        public string Name { get; set; }

        public int Mark
        {
            get
            {
                return _mark;
            }
            set
            {
                if (value < 0.0)
                {
                    throw new ArgumentException("Оценка не может быть отрицательной");
                }
                _mark = value;
            }
        }
        public string Teacher { get; set; }
    }
}
