using System;
using System.Collections.Generic;
using System.Text;

namespace Programming.Model
{
    public class Movie
    {
        private string _nameMovie;
        private int _timeMovie;
        private int _releaseYear;
        private string _genre;
        private float _rating;

        public Movie()
        {

        }
        public Movie(string nameMovie, int timeMovie, int releaseYear, string genre, float rating)
        {
            NameMovie = nameMovie;
            MovieTime = timeMovie;
            ReleaseYear = releaseYear;
            Genre = genre;
            Rating = rating;
        }
        public string NameMovie { get; set; }
        public string Genre { get; set; }
        
        public int MovieTime
        {
            get
            {
                return _timeMovie;
            }
            set
            {
                if(value < 0.0)
                {
                    throw new AggregateException("Продолжительность фильма не может быть отрицательной");
                }
                _timeMovie = value;
            }
        }
        public int ReleaseYear
        {
            get
            {
                return _releaseYear;
            }
            set
            {
                if(value < 1900 || value > 2022)
                {
                    throw new ArgumentException("Год выпуска фильма должен быть не раннее 1900 и не позже 2022 года");
                }
                _releaseYear = value;
            }
        }
        public float Rating
        {
            get
            {
                return _rating;
            }
            set
            {
                if (value < 0 || value > 10)
                {
                    throw new ArgumentException("Оценка в рейтинге не может быть меньше 0 или больше 10");
                }
                _rating = value;
            }
        }

    }
}
