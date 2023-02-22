using Programming.Model.Classes;
using System;
using System.Windows.Forms;
using Rectangle = Programming.Model.Geometry.Rectangle;


namespace Programming.View.Panels
{
    /// <summary>
    /// Реализация представления прямоугольников, релизуемых программой.
    /// </summary>
    public partial class RectangleControl : UserControl
    {
        /// <summary>
        /// Количество элементов в массиве.
        /// </summary>
        private const int ElementsCount = 5;

        /// <summary>
        /// Массив прямоугольников.
        /// </summary>
        private Rectangle[] _rectangles;

        /// <summary>
        /// Текущий прямоугольник.
        /// </summary>
        private Rectangle _currentRectangle;

        /// <summary>
        /// Создает экземпляр класса <see cref="RectangleControl"/>.
        /// </summary>
        public RectangleControl()
        {
            InitializeComponent();

            _rectangles = GenerateRectangles();

            RectanglesListBox.SelectedIndex = 0;

        }

        /// <summary>
        /// Создает массив прямоугольников.
        /// </summary>
        /// <returns> Возвращает массив прямоугольников. </returns>
        private Rectangle[] GenerateRectangles()
        {
            Rectangle[] rectangles = new Rectangle[ElementsCount];
            for (int i = 0; i < ElementsCount; i++)
            {
                _currentRectangle = Model.Geometry.RectangleFactory.Randomize(300, 300);
                rectangles[i] = _currentRectangle;
                RectanglesListBox.Items.Add($"Rectangle {_currentRectangle.Id}");
            }
            return rectangles;
        }

        /// <summary>
        /// Находит прямоугольник с наибольшей шириной.
        /// </summary>
        /// <param name="rectangles"> Массив прямоугольников. </param>
        /// <returns> Возвращает индекс прямоугольника с наибольшей шириной. </returns>
        private int FindRectangleWithMaxWidth(Rectangle[] rectangles)
        {
            int maxWidthIndex = 0;
            int maxWidth = 0;
            for (int i = 0; i < ElementsCount; i++)
            {
                if (rectangles[i].Width > maxWidth)
                {
                    maxWidth = rectangles[i].Width;
                    maxWidthIndex = i;
                }
            }
            return maxWidthIndex;
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
                LengthTextBox.BackColor = AppColors.ErrorColor;
                return;
            }
            LengthTextBox.BackColor = AppColors.CorrectColor;
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
                WidthTextBox.BackColor = AppColors.ErrorColor;
                return;
            }
            WidthTextBox.BackColor = AppColors.CorrectColor;
        }

        private void ColorTextBox_TextChanged(object sender, EventArgs e)
        {
            string colorRectangleValue = ColorTextBox.Text;
            _currentRectangle.Color = colorRectangleValue;
        }

        private void FindRectangleButton_Click(object sender, EventArgs e)
        {
            int findMaxWidthIndex = FindRectangleWithMaxWidth(_rectangles);
            RectanglesListBox.SelectedIndex = findMaxWidthIndex;
        }
    }
}
