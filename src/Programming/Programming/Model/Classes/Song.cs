namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит данные о песне.
    /// </summary>
    public class Song
    {
        /// <summary>
        /// Автор песни.
        /// </summary>
        private string _author;

        /// <summary>
        /// Название песни.
        /// </summary>
        private string _title;

        /// <summary>
        /// Продолжительность песни в секундах.
        /// </summary>
        private int _timeSeconds;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Song"/>.
        /// </summary>
        public Song()
        {

        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Song"/>.
        /// </summary>
        /// <param name="author">  Автор песни. </param>
        /// <param name="title"> Название песни. </param>
        /// <param name="timeInSeconds"> Продолжительность песни в секундах. </param>
        public Song(string author, string title, int timeInSeconds)
        {
            Author = author;
            Title = title;
            TimeInSeconds = timeInSeconds;
        }

        /// <summary>
        /// Возвращает и задает автора песни.
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        /// Возвращает и задает название песни.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Возвращает и задаёт продолжительность песни в секундах. Должно быть положительным числом.
        /// </summary>
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
