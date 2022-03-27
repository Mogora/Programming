using System;
using System.Collections.Generic;
using System.Text;

namespace Programming3.Model
{
    public class Film
    {
        private string _nameOfTheFilm;
        private int _durationInMinutes;
        private int _yearOfRealese;
        private string _genre;
        private float _rating;

        public Film(string nameOfTheFilm, int durationInMinutes, int yearOfRealese, string genre, float rating)
        {
            NameOfTheFilm = nameOfTheFilm;
            Genree = genre;
            Rating = rating;
            YearOfRealese = yearOfRealese;
            DurationInMinutes = durationInMinutes;
        }

        public string NameOfTheFilm { get; private set; }
        public string Genree { get; private set; }
        public float Rating { get; }
        public int YearOfRealese { get; }
        public int DurationInMinutes { get; }
    }
}
