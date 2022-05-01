using System;
using System.Collections.Generic;
using System.Text;

namespace Programming.Model
{
    public class Time
    {
        private int _hours;

        private int _minutes;

        private int _seconds;

        public Time()
        {

        }
        public Time(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
        }
        public int Hours
        {
            get
            {
                return _hours;
            }
            set
            {
                if(value < 0)
                {
                    Validator.AssertOnPositiveValue(nameof(Hours), value);
                }
                if(value > 23)
                {
                    throw new ArgumentException("Количество часов не может превышать значение 23");
                }
                _hours = value;
            }
        }
        public int Minutes
        {
            get
            {
                return _minutes;
            }
            set
            {
                if (value < 0.0)
                {
                    Validator.AssertOnPositiveValue(nameof(Minutes), value);
                }
                if (value > 60)
                {
                    throw new ArgumentException("Количество минут не может превышать значение 60");
                }
                _minutes = value;
            }
        }
        public int Seconds
        {
            get
            {
                return _seconds;
            }
            set
            {
                if (value < 0.0)
                {
                    Validator.AssertOnPositiveValue(nameof(Seconds), value);
                }
                if (value > 60)
                {
                    throw new ArgumentException("Количество секунд не может превышать значение 60");
                }
                _seconds = value;
            }
        }
    }
}
