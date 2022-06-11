using System;
using System.Collections.Generic;
using System.Text;

namespace Programming.Model.Classes
{
    public class Movie
    {
        private string _name;
        private int _movietime;
        private int _releaseYear;
        private string _genre;
        private float _rating;

        public Movie()
        {

        }

        public Movie(string name, int movietime, int releaseYear, string genre, float rating)
        {
            Name = name;
            MovieTime = movietime;
            ReleaseYear = releaseYear;
            Genre = genre;
            Rating = rating;
        }

        public string Name { get; set; }

        public string Genre { get; set; }
        
        public int MovieTime
        {
            get
            {
                return _movietime;
            }
            set
            {
                Validator.AssertOnPositiveValue(nameof(MovieTime), value);
                _movietime = value;
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
                Validator.AssertValueInRange(nameof(ReleaseYear), value, 1900, 2022);
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
                Validator.AssertValueInRange(nameof(Rating), value, 0, 10);
                if (value < 0 || value > 10)
                {
                    throw new ArgumentException("Оценка в рейтинге не может быть меньше 0 или больше 10");
                }
                _rating = value;
            }
        }
    }
}
