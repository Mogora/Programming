using System;
using System.Collections.Generic;
using System.Text;

namespace Programming.Model
{
    public class Song
    {
        private string _author;
        private string _title;
        private int _timeMitutes;
        private int _timeSeconds;

        public Song()
        {

        }

        public Song(string author, string title, int timeInMitutes, int timeInSeconds)
        {
            Author = author;
            Title = title;
            TimeInMitutes = timeInMitutes;
            TimeInSeconds = timeInSeconds;
        }
        public string Author { get; set; }
        public string Title { get;  set; }
        public int TimeInMitutes
        {
            get
            {
                return _timeMitutes;   
            }
            set
            {
                if(value < 0.0)
                {
                    throw new ArgumentException("Время не может быть отрицательным");
                }
                _timeMitutes = value;
            }
        }
        public int TimeInSeconds
        {
            get
            {
                return _timeSeconds;
            }
            set
            {
                if (value < 0.0)
                {
                    throw new ArgumentException("Время не может быть отрицательным");
                }
                _timeSeconds = value;
            }
        }
    }
}
