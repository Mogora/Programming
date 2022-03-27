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

        public Song(string author, string title, int timeInMitutes, int timeInSeconds)
        {
            Author = author;
            Title = title;
            TimeInMitutes = timeInMitutes;
            TimeInSeconds = timeInSeconds;
        }
        public string Author { get; private set; }
        public string Title { get; private set; }
        public int TimeInMitutes { get; private set; }
        public int TimeInSeconds { get; private set; }
    }
}
