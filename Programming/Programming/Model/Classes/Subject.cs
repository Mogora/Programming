using System;
using System.Collections.Generic;
using System.Text;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит данные о предмете.
    /// </summary>
    public class Subject
    {
        /// <summary>
        /// Название песни.
        /// </summary>
        private string _name;

        /// <summary>
        /// Оценка за предмет.
        /// </summary>
        private int _mark;

        /// <summary>
        /// Преподаватель данного предмета.
        /// </summary>
        private string _teacher;
        
        /// <summary>
        /// Создает экземпляр класса <see cref="Subject"/>.
        /// </summary>
        public Subject()
        {

        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Subject"/>.
        /// </summary>
        /// <param name="name"> Название песни. </param>
        /// <param name="mark"> Оценка за предмет. Должна быть положительной. </param>
        /// <param name="teacher"> Преподаватель данного предмета. </param>
        public Subject(string name, int mark, string teacher)
        {
            Name = name;
            Mark = mark;
            Teacher = teacher;
        }

        /// <summary>
        /// Возврщает и создает название песни.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Возвращает и создает оценку за предмет. Должна быть положительной. 
        /// </summary>
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

        /// <summary>
        /// Возвращает и создает фамилию преподавателя.
        /// </summary>
        public string Teacher { get; set; }
    }
}
