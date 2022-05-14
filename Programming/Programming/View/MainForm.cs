using Programming.Model;
using System;
using System.Drawing;
using System.Windows.Forms;
using Rectangle = Programming.Model.Rectangle;
using System.Collections.Generic;
using Movie = Programming.Model.Movie;

namespace Programming.View
{
    public partial class MainForm : Form
    {
        private const int ElementsCount = 5;

        private readonly Color ErrorColor = Color.LightPink;

        private readonly Color CorrectColor = Color.White;

        private Rectangle[] _rectangles;
            
        private Rectangle _currentRectangle;
        
        private Random _random;

        private Movie[] _movies;

        private Movie _currentMovie;
 
        public MainForm()
        {
            InitializeComponent();
            Array typeValues = Enum.GetValues(typeof(Enums));
            foreach (Enums value in typeValues) 
            {
                EnumsListBox.Items.Add(value);
            }
            EnumsListBox.SelectedIndex = 0;

            Array seasons = Enum.GetValues(typeof(Seasons));
            foreach (Seasons value in seasons)
            {
                SeasonsComboBox.Items.Add(value);
            }
            SeasonsComboBox.SelectedIndex = 0;

            _random = new Random();

            GenerateRectangles();

            GenerateMovies();           
        }

        private void GenerateRectangles()
        {          
            _rectangles = new Rectangle[ElementsCount];
            var colors = Enum.GetValues(typeof(Colors));
            for (int i = 0; i < ElementsCount; i++)
            {              
                _currentRectangle = new Rectangle();
                _currentRectangle.Width = _random.Next(1, 1001);
                _currentRectangle.Length = _random.Next(1, 1001);
                _currentRectangle.Color = colors.GetValue(_random.Next(0, colors.Length)).ToString();
                _currentRectangle.Center = new Point2D(_random.Next(1, 100), _random.Next(1, 100));
                _rectangles[i] = _currentRectangle;
                RectanglesListBox.Items.Add($"Rectangle {_currentRectangle.Id}");
            }
            RectanglesListBox.SelectedIndex = 0;
        }    
        
        private void GenerateMovies ()
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

        private int FindRectangleWithMaxWidth(Rectangle[] restangles)
        {
            int maxWidthIndex = 0;
            double maxWidthRestangle = 0;
            for (int i = 0; i < ElementsCount; i++)
            {
                if (restangles[i].Width > maxWidthRestangle)
                {
                    maxWidthRestangle = restangles[i].Width;
                    maxWidthIndex = i;
                }
            }
            return maxWidthIndex;
        }

        private int FindMovieWithMaxRating(Movie [] movies)
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
          
        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValuesListBox.Items.Clear();
            Array enumValues;

            switch ((Enums)EnumsListBox.SelectedItem)
            {
                case Enums.Weekday:
                    enumValues = Enum.GetValues(typeof(Weekday));
                    break;

                case Enums.Genre:
                    enumValues = Enum.GetValues(typeof(Genre));
                    break;

                case Enums.Colors:
                    enumValues = Enum.GetValues(typeof(Colors));
                    break;

                case Enums.EducationForm:
                    enumValues = Enum.GetValues(typeof(EducationForm));
                    break;

                case Enums.Smartphones:
                    enumValues = Enum.GetValues(typeof(Smartphones));
                    break;

                case Enums.Seasons:
                    enumValues = Enum.GetValues(typeof(Seasons));
                    break;

                default:
                    throw new NotImplementedException();
            }
            foreach (var value in enumValues)
            {
                ValuesListBox.Items.Add(value);
            }
        }

        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            IntValueTextBox.Text = ((int)(ValuesListBox.SelectedItem)).ToString();
        }

        private void WeekdayParseButton_Click(object sender, EventArgs e)
        {
            string textWeekdayTextBox = WeekdayTextBox.Text;
            Weekday weekday;
            if (Enum.TryParse(textWeekdayTextBox, out weekday))
            {
                OutputWeekdayLabel.Text = $"Это день недели ({weekday} - {(int)weekday})";
            }
            else
            {
                OutputWeekdayLabel.Text = "Нет такого дня недели";
            }
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            switch (SeasonsComboBox.SelectedItem)
            {
                case Seasons.Winter:
                    this.BackColor = DefaultBackColor;
                    MessageBox.Show("Бррр! Холодно! Куда бежать согреваться??");
                    break;
                case Seasons.Spring:
                    this.BackColor = ColorTranslator.FromHtml("#559c45");
                    break;
                case Seasons.Summer:
                    this.BackColor = DefaultBackColor;
                    MessageBox.Show(" Ура! Солнце! Тепло!");
                    break;
                case Seasons.Autumn:
                    this.BackColor = ColorTranslator.FromHtml("#e29c45");
                    break;
            }
        }

        private void RectanglesListBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int selectedIndexRectangle = RectanglesListBox.SelectedIndex;
            _currentRectangle = _rectangles[selectedIndexRectangle];
            LengthTextBox.Text = _currentRectangle.Length.ToString();
            WidthTextBox.Text = _currentRectangle.Width.ToString();
            ColorTextBox.Text = _currentRectangle.Color;
            RectangleXTextBox.Text = _currentRectangle.Center.X.ToString();
            RectangleYTextBox.Text = _currentRectangle.Center.Y.ToString();
            IdRectangleTextBox.Text = _currentRectangle.Id.ToString();
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

        private void LengthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string currentLength = LengthTextBox.Text;
                float lengthRectangleValue = float.Parse(currentLength);
                _currentRectangle.Length = lengthRectangleValue;
            }
            catch
            {
                LengthTextBox.BackColor = ErrorColor;
                return;
            }
            LengthTextBox.BackColor = CorrectColor;
        }

        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string currentWidth = WidthTextBox.Text;
                float widthRectangleValue = float.Parse(currentWidth);
                _currentRectangle.Width = widthRectangleValue;
            }
            catch
            {
                WidthTextBox.BackColor = ErrorColor;
                return;
            }
            WidthTextBox.BackColor = CorrectColor;
        }

        private void ColorTextBox_TextChanged(object sender, EventArgs e)
        {
            string colorRectangleValue = ColorTextBox.Text;
            _currentRectangle.Color = colorRectangleValue;
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
                RatingTextBox.BackColor = ErrorColor;
                return;
            }
            RatingTextBox.BackColor = CorrectColor;
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
                ReleaseYearTextBox.BackColor = ErrorColor;
                return;
            }
            ReleaseYearTextBox.BackColor = CorrectColor;
        }

        private void GenreTextBox_TextChanged(object sender, EventArgs e)
        {
            string genreMovieValue = GenreTextBox.Text;
            _currentMovie.Genre = genreMovieValue;
        }

        private void FindRectangleButton_Click(object sender, EventArgs e)
        {
            int findMaxWidthIndex = FindRectangleWithMaxWidth(_rectangles);
            RectanglesListBox.SelectedIndex = findMaxWidthIndex;
        }

        private void FindMovieButton_Click_Click(object sender, EventArgs e)
        {
            int findMaxRatingIndex = FindMovieWithMaxRating(_movies);
            MoviesListBox.SelectedIndex = findMaxRatingIndex;
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            string nameValue = NameTextBox.Text;
            _currentMovie.Name = nameValue;
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
                MovieTimeTextBox.BackColor = ErrorColor;
                return;
            }
            MovieTimeTextBox.BackColor = CorrectColor;
        }
    }
}

