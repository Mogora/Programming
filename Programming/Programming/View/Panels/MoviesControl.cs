using Programming.Model.Classes;
using Programming.Model.Enums;
using System;
using System.Windows.Forms;
using Movie = Programming.Model.Classes.Movie;


namespace Programming.View.Panels
{
    /// <summary>
    /// Реализация представления фильмов.
    /// </summary>
    public partial class MoviesControl : UserControl
    {
        /// <summary>
        /// Количество элементов в массиве.
        /// </summary>
        private const int ElementsCount = 5;

        /// <summary>
        /// Массив фильмов.
        /// </summary>
        private Movie[] _movies;

        /// <summary>
        /// Выбранный фильм.
        /// </summary>
        private Movie _currentMovie;

        /// <summary>
        /// Рандомно сгенированное значение.
        /// </summary>
        private Random _random;

        /// <summary>
        /// Создает экземпляр класса <see cref="MoviesControl"/>.
        /// </summary>
        public MoviesControl()
        {
            InitializeComponent();

            _random = new Random();

            GenerateMovies();

        }

        /// <summary>
        /// Инициализирует массив фильмов.
        /// </summary>
        /// <returns> Возвращает массив фильмов. </returns>
        private void GenerateMovies()
        {
            _movies = new Movie[ElementsCount];
            var genres = Enum.GetValues(typeof(Genre));
            for (int i = 0; i < ElementsCount; i++)
            {
                _currentMovie = new Movie();
                _currentMovie.Rating = _random.Next(101) / 10;
                _currentMovie.ReleaseYear = _random.Next(1900, 2022);
                _currentMovie.Genre = genres.GetValue(_random.Next(0, genres.Length)).ToString();
                _currentMovie.MovieTime = _random.Next(40, 200);
                _currentMovie.Name = $"Film {_currentMovie.Genre} {_currentMovie.ReleaseYear}";
                _movies[i] = _currentMovie;
                MoviesListBox.Items.Add($"Movie {i + 1}");
            }
            MoviesListBox.SelectedIndex = 0;
        }

        /// <summary>
        /// Находит фильм с наивысшим рейтингом.
        /// </summary>
        /// <param name="movies"> Массив фильмов.</param>
        /// <returns> Возвращает индекс фильма с наибольшим рейтингом.</returns>
        private int FindMovieWithMaxRating(Movie[] movies)
        {
            int maxRatingIndex = 0;
            float maxRatingMovie = 0;
            for (int i = 0; i < ElementsCount; i++)
            {
                if (movies[i].Rating > maxRatingMovie)
                {
                    maxRatingMovie = movies[i].Rating;
                    maxRatingIndex = i;
                }
            }
            return maxRatingIndex;
        }

        private void MoviesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndexMovie = MoviesListBox.SelectedIndex;
            _currentMovie = _movies[selectedIndexMovie];
            RatingTextBox.Text = _currentMovie.Rating.ToString();
            ReleaseYearTextBox.Text = _currentMovie.ReleaseYear.ToString();
            GenreTextBox.Text = _currentMovie.Genre;
            NameTextBox.Text = _currentMovie.Name;
            MovieTimeTextBox.Text = _currentMovie.MovieTime.ToString();
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            string nameValue = NameTextBox.Text;
            _currentMovie.Name = nameValue;
        }

        private void RatingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string currentRating = RatingTextBox.Text;
                float ratingMovieValue = float.Parse(currentRating);
                _currentMovie.Rating = ratingMovieValue;
            }
            catch
            {
                RatingTextBox.BackColor = AppColors.ErrorColor;
                return;
            }
            RatingTextBox.BackColor = AppColors.CorrectColor;
        }

        private void MovieTimeTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string currentMovieTime = MovieTimeTextBox.Text;
                int movieTimeValue = int.Parse(currentMovieTime);
                _currentMovie.MovieTime = movieTimeValue;
            }
            catch
            {
                MovieTimeTextBox.BackColor = AppColors.ErrorColor;
                return;
            }
            MovieTimeTextBox.BackColor = AppColors.CorrectColor;
        }

        private void GenreTextBox_TextChanged(object sender, EventArgs e)
        {
            string genreMovieValue = GenreTextBox.Text;
            _currentMovie.Genre = genreMovieValue;
        }

        private void ReleaseYearTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string currentReleaseYear = ReleaseYearTextBox.Text;
                int releaseYearMovieValue = int.Parse(currentReleaseYear);
                _currentMovie.ReleaseYear = releaseYearMovieValue;
            }
            catch
            {
                ReleaseYearTextBox.BackColor = AppColors.ErrorColor;
                return;
            }
            ReleaseYearTextBox.BackColor = AppColors.CorrectColor;
        }

        private void FindMovieButton_Click_Click(object sender, EventArgs e)
        {
            int findMaxRatingIndex = FindMovieWithMaxRating(_movies);
            MoviesListBox.SelectedIndex = findMaxRatingIndex;
        }
    }
}
