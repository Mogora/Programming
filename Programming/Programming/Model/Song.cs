using System;
using System.Collections.Generic;
using System.Text;

namespace Programming.Model
{
    public class Song
    {
        private string _author;

        private string _title;

        private int _timeSeconds;

        public Song()
        {

        }

        public Song(string author, string title, int timeInSeconds)
        {
            Author = author;
            Title = title;
            TimeInSeconds = timeInSeconds;
        }
        public string Author { get; set; }

        public string Title { get;  set; }
        
        public int TimeInSeconds
        {
            get
            {
                return _timeSeconds;
            }
            set
            {
                Validator.AssertOnPositiveValue(nameof(TimeInSeconds), value);
                _timeSeconds = value;
            }
        }
    }
}
