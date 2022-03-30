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
                if(value < 0.0)
                {
                    throw new ArgumentException("Количество часов не может быть отрицательным");
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
                    throw new ArgumentException("Количество минут не может быть отрицательным");
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
                    throw new ArgumentException("Количество секунд не может быть отрицательным");
                }
                _seconds = value;
            }
        }
    }
}
