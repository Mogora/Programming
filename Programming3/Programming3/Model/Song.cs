using System;
using System.Collections.Generic;
using System.Text;

namespace Programming3.Model
{
    public class Song
    {
        private string _author;
        private string _title;
        private int _timeInMitutes;
        private int _timmeInSeconds;

        public Song(string author, string title, int timeInMitutes, int timmeInSeconds)
        {
            Author = author;
            Title = title;
            TimeInMitutes = timeInMitutes;
            TimeInSeconds = timmeInSeconds;
        }

        public string Author { get; private set; }
        public string Title { get; private set; }
        public int TimeInMitutes { get; private set; }
        public int TimeInSeconds { get; private set; }
    }
}
