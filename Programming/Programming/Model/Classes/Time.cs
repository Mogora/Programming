﻿namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит данные о времени.
    /// </summary>
    public class Time
    {
        /// <summary>
        /// Количество часов.
        /// </summary>
        private int _hours;

        /// <summary>
        /// Количество минут.
        /// </summary>
        private int _minutes;

        /// <summary>
        /// Количество секунд.
        /// </summary>
        private int _seconds;

        /// <summary>
        /// Создает экземпляр класса <see cref="Time"/>.
        /// </summary>
        public Time()
        {

        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Time"/>.
        /// </summary>
        /// <param name="hours"> Количество часов. Должно быть положительным и в промежутку от 0 до 23. </param>
        /// <param name="minutes">  Количество минут. Должно быть положительным и в промежутку от 0 до 59. </param>
        /// <param name="seconds"> Количество секунд. Должно быть положительным и в промежутку от 0 до 59. </param>
        public Time(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }

        /// <summary>
        /// Возвращает и создает количество часов. Должно быть положительным и в промежутку от 0 до 23.
        /// </summary>
        public int Hours
        {
            get
            {
                return _hours;
            }
            set
            {
                Validator.AssertValueInRange(nameof(Hours), value, 0, 23);
                _hours = value;
            }
        }

        /// <summary>
        /// Возвращает и создает количество минут. Должно быть положительным и в промежутку от 0 до 59.
        /// </summary>
        public int Minutes
        {
            get
            {
                return _minutes;
            }
            set
            {
                Validator.AssertValueInRange(nameof(Minutes), value, 0, 59);
                _minutes = value;
            }
        }

        /// <summary>
        /// Возвращает и создает количество секунд. Должно быть положительным и в промежутку от 0 до 59.
        /// </summary>
        public int Seconds
        {
            get
            {
                return _seconds;
            }
            set
            {
                Validator.AssertValueInRange(nameof(Seconds), value, 0, 59);
                _seconds = value;
            }
        }
    }
}
