using System;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит данные о фильме.
    /// </summary>
    public class Movie
    {
        /// <summary>
        /// Название фильма.
        /// </summary>
        private string _name;

        /// <summary>
        /// Продолжительность фильма в минутах.
        /// </summary>
        private int _duration;

        /// <summary>
        /// Год выпуска фильма. Должен быть в промежутке от 1900 до 2022.
        /// </summary>
        private int _releaseYear;

        /// <summary>
        /// Жанр фильма.
        /// </summary>
        private string _genre;

        /// <summary>
        /// Рейтинг фильма. Должен быть в промежутке от 0 до 10.
        /// </summary>
        private float _rating;

        /// <summary>
        /// Создает экземпляр класса <see cref="Movie"/>.
        /// </summary>
        public Movie()
        {

        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Movie"/>.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="movietime"></param>
        /// <param name="releaseYear"> Год выпуска фильма. Должен быть в промежутке от 1900 до 2022. </param>
        /// <param name="genre"> Жанр фильма. </param>
        /// <param name="rating"> Рейтинг фильма. Должен быть в промежутке от 0 до 10. </param>
        public Movie(string name, int duration, int releaseYear, string genre, float rating)
        {
            Name = name;
            Duration = duration;
            ReleaseYear = releaseYear;
            Genre = genre;
            Rating = rating;
        }

        /// <summary>
        /// Возвращает и задает название фильма.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Возвращает и задает жанр фильма.
        /// </summary>
        public string Genre { get; set; }

        /// <summary>
        /// Возвращает и задает время фильма в минутах.  Должно быть положительным числом.
        /// </summary>
        public int Duration
        {
            get
            {
                return _duration;
            }
            set
            {
                Validator.AssertOnPositiveValue(nameof(Duration), value);
                _duration = value;
            }
        }

        /// <summary>
        /// Возвращает и задает год релиза фильма. Должен быть в промежутке от 1900 до 2022.
        /// </summary>
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

        /// <summary>
        /// Возвращает и задает рейтинг фильма. Должен быть в промежутке от 0 до 10.
        /// </summary>
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
