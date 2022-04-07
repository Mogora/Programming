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

            _rectangles = GenerateRectangles();
            RectanglesListBox.SelectedIndex = 0;

            _movies = GenerateMovies();
            MoviesListBox.SelectedIndex = 0;
        }
        private Rectangle[] GenerateRectangles()
        {
            Rectangle[] rectangles = new Rectangle[ElementsCount];
            var colors = Enum.GetValues(typeof(Colors));
            for (int i = 0; i < ElementsCount; i++)
            {
                _currentRectangle = new Rectangle();
                _currentRectangle.Width = _random.Next(1, 1001);
                _currentRectangle.Length = _random.Next(1, 1001);
                _currentRectangle.Color = colors.GetValue(_random.Next(0, colors.Length)).ToString();
                rectangles[i] = _currentRectangle;
                RectanglesListBox.Items.Add($"Rectangle {i + 1}");
            }
            return rectangles;
        }
        
        private Movie [] GenerateMovies ()
        {
            Movie[] movies = new Movie[ElementsCount];
            var genres = Enum.GetValues(typeof(Genre));
            for (int i = 0; i < ElementsCount; i++)
            {
                _currentMovie = new Movie();
                _currentMovie.Rating = _random.Next(1, 10);
                _currentMovie.ReleaseYear = _random.Next(1900, 2022);
                _currentMovie.Genre = genres.GetValue(_random.Next(0, genres.Length)).ToString();
                movies[i] = _currentMovie;
                MoviesListBox.Items.Add($"Movie {i + 1}");
            }
            return movies;
        }
        private int FindRectangleWithMaxWidth (Rectangle[] restangles)
        {
            int maxWidthIndex = 0;
            float maxWidthRestangle = 0;
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
            LengthTextBox.Text = _currentRectangle.ToString();
            WidthTextBox.Text = _currentRectangle.Width.ToString();
            ColorTextBox.Text = _currentRectangle.Color;
        }

        private void MoviesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndexMovie = MoviesListBox.SelectedIndex;
            _currentMovie = _movies[selectedIndexMovie];
            RatingTextBox.Text = _currentRectangle.ToString();
            ReleaseYearTextBox.Text = _currentRectangle.ToString();
            GenreTextBox.Text = _currentMovie.Genre;
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
                LengthTextBox.BackColor = Color.LightPink;
                return;
            }
            LengthTextBox.BackColor = Color.White;
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
                WidthTextBox.BackColor = Color.LightPink;
                return;
            }
            WidthTextBox.BackColor = Color.White;
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
                RatingTextBox.BackColor = Color.LightPink;
                return;
            }
            RatingTextBox.BackColor = Color.White;
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
                ReleaseYearTextBox.BackColor = Color.LightPink;
                return;
            }
            ReleaseYearTextBox.BackColor = Color.White;
        }

        private void FindRectangleButton_Click(object sender, EventArgs e)
        {
            int findMaxWidthIndex = FindRectangleWithMaxWidth(_rectangles);
            RectanglesListBox.SelectedIndex = findMaxWidthIndex;
        }

        
    }
}

