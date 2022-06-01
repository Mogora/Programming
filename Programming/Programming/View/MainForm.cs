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

        private readonly Color _inContact = Color.FromArgb(127, 255, 127, 127);

        private readonly Color _unContact = Color.FromArgb(127, 127, 255, 127);

        private List<Rectangle> _rectangles = new List<Rectangle>();

        private List<Panel> _rectanglePanels = new List<Panel>();

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

            _rectangles = new List<Rectangle>();

            _rectanglePanels = new List<Panel>();

            GenerateMovies();           
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

        private string SetRectangleParameters(Rectangle rectangle)
        {
            return $"{rectangle.Id}: " +
                   $"(X: {rectangle.Center.X};" +
                   $" Y: {rectangle.Center.Y};" +
                   $" W: {rectangle.Width};" +
                   $" H: {rectangle.Length})";
        }

        private void UpdateRectangleInfo(Rectangle rectangle)
        {
            int index = RectanglesListBox.FindString(rectangle.Id.ToString());

            if (index == -1) return;

            RectanglesListBox.Items[index] = SetRectangleParameters(rectangle);
        }

        private Panel InitPanel()
        {
            Panel rectanglePanel = new Panel();
            rectanglePanel.Width = _currentRectangle.Width;
            rectanglePanel.Height = _currentRectangle.Length;
            rectanglePanel.Location = new Point(_currentRectangle.Center.X, _currentRectangle.Center.Y);
            rectanglePanel.BackColor = _unContact;

            return rectanglePanel;
        }

        private int FindRectangleWithMaxWidth(List<Rectangle>restangles)
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

        private void FindCollisions()
        {
            for (int k = 0; k < _rectangles.Count; k++)
            {
                CanvasPanel.Controls[k].BackColor = _unContact;
            }


            for (int i = 0; i < _rectangles.Count-1; i++)
            {
                for (int j = 0; j < _rectangles.Count; j++)
                {
                    if (CollisionManager.IsCollision(_rectangles[i], _rectangles[j]))
                    {
                        CanvasPanel.Controls[i].BackColor = _inContact;
                        CanvasPanel.Controls[j].BackColor = _inContact;
                    }
                }
            }
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
            if (RectanglesListBox.SelectedIndex != -1)
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
                int lengthRectangleValue = int.Parse(currentLength);
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
                int widthRectangleValue = int.Parse(currentWidth);
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

        private void AddRectangleButton_Click(object sender, EventArgs e)
        {
            var colors = Enum.GetValues(typeof(Colors));
            _currentRectangle = new Rectangle();
            var rectangle = _currentRectangle;
            rectangle.Width = _random.Next(10, 110);
            rectangle.Length = _random.Next(10, 110);
            rectangle.Center = new Point2D(_random.Next(0, CanvasPanel.Width - rectangle.Width),
                _random.Next(0, CanvasPanel.Height - rectangle.Length));
            rectangle.Color = colors.GetValue
                    (_random.Next(0, colors.Length)).ToString();
            _rectangles.Add(rectangle);
            RectanglesListBox.Items.Add($"Rectangle {rectangle.Id}");
            Rectangles2ListBox.Items.Add($"{rectangle.Id}: " +
            $"(X: {rectangle.Center.X};" + $" Y: {rectangle.Center.Y};" +
            $" W: {rectangle.Width};" + $" L: {rectangle.Length})");

            Panel rectanglePanel = new Panel();
            rectanglePanel.Width = _currentRectangle.Width;
            rectanglePanel.Height = _currentRectangle.Length;
            rectanglePanel.Location = new Point(_currentRectangle.Center.X, _currentRectangle.Center.Y);
            rectanglePanel.BackColor = _unContact;
            _rectanglePanels.Add(rectanglePanel);
            CanvasPanel.Controls.Add(rectanglePanel);

            FindCollisions();
        }

        private void RemoveRectangleButton_Click(object sender, EventArgs e)
        {
            int index = Rectangles2ListBox.SelectedIndex;
            if (index == -1) return;
            _rectangles.RemoveAt(index);
            CanvasPanel.Controls.RemoveAt(index);
            _rectanglePanels.RemoveAt(index);
            RectanglesListBox.Items.Clear();
            Rectangles2ListBox.Items.Clear();

            foreach (var rectangle in _rectangles)
            {
                RectanglesListBox.Items.Add($"Rectangle {rectangle.Id}");
                Rectangles2ListBox.Items.Add($"{rectangle.Id}: (X: {rectangle.Center.X}; Y: {rectangle.Center.Y}; W: {rectangle.Width}; L: {rectangle.Length})");
                RectanglesListBox.SelectedIndex = 0;
            }

            FindCollisions();
        }

        private void Rectangles2ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Rectangles2ListBox.SelectedIndex != -1)
            {
                int indexSelectedRectangle = Rectangles2ListBox.SelectedIndex;
                _currentRectangle = _rectangles[indexSelectedRectangle];
                Length2TextBox.Text = _currentRectangle.Length.ToString();
                Width2TextBox.Text = _currentRectangle.Width.ToString();
                RectangleX2TextBox.Text = _currentRectangle.Center.X.ToString();
                RectangleY2TextBox.Text = _currentRectangle.Center.Y.ToString();
                Id2RectangleTextBox.Text = _currentRectangle.Id.ToString();
            }
        }

        private void RectangleX2TextBox_TextChanged(object sender, EventArgs e)
        {

            if (Rectangles2ListBox.SelectedIndex == -1) return;

            try
            {
                string currentXRectangle = RectangleX2TextBox.Text;
                int xRectangleValue = int.Parse(currentXRectangle);
                _currentRectangle.Center.X = xRectangleValue;
                CanvasPanel.Controls[RectanglesListBox.SelectedIndex].Location =
                    new Point(_currentRectangle.Center.X, _currentRectangle.Center.Y);
                FindCollisions();
                UpdateRectangleInfo(_currentRectangle);
            }
            catch
            {
                RectangleX2TextBox.BackColor = ErrorColor;
                return;
            }
            RectangleX2TextBox.BackColor = CorrectColor;
        }

        private void RectangleY2TextBox_TextChanged(object sender, EventArgs e)
        {
            if (Rectangles2ListBox.SelectedIndex == -1) return;

            try
            {
                string currentYRectangle = RectangleY2TextBox.Text;
                int yRectangleValue = int.Parse(currentYRectangle);
                _currentRectangle.Center.Y = yRectangleValue;
                CanvasPanel.Controls[RectanglesListBox.SelectedIndex].Location =
                    new Point(_currentRectangle.Center.X, _currentRectangle.Center.Y);
                FindCollisions();
                UpdateRectangleInfo(_currentRectangle);
            }
            catch
            {
                RectangleY2TextBox.BackColor = ErrorColor;
                return;
            }
            RectangleY2TextBox.BackColor = CorrectColor;
        }

        private void Width2TextBox_TextChanged(object sender, EventArgs e)
        {
            if (Rectangles2ListBox.SelectedIndex == -1) return;

            try
            {
                string currentWidthRectangle = Width2TextBox.Text;
                int widthRectangleValue = int.Parse(currentWidthRectangle);
                _currentRectangle.Width = widthRectangleValue;
                CanvasPanel.Controls[RectanglesListBox.SelectedIndex].Width = _currentRectangle.Width;
                FindCollisions();
                UpdateRectangleInfo(_currentRectangle);
            }

            catch
            {
                Width2TextBox.BackColor = ErrorColor;
                return;
            }
            Width2TextBox.BackColor = CorrectColor;
        }

        private void Length2TextBox_TextChanged(object sender, EventArgs e)
        {
            if (Rectangles2ListBox.SelectedIndex == -1) return;

            try
            {
                string currentHeightRectangle = Length2TextBox.Text;
                int heightRectangleValue = int.Parse(currentHeightRectangle);
                _currentRectangle.Length = heightRectangleValue;
                CanvasPanel.Controls[RectanglesListBox.SelectedIndex].Height = _currentRectangle.Length;
                FindCollisions();
                UpdateRectangleInfo(_currentRectangle);
            }

            catch
            {
                Length2TextBox.BackColor = ErrorColor;
                return;
            }
            Length2TextBox.BackColor = CorrectColor;
        }

        
    }
}   

