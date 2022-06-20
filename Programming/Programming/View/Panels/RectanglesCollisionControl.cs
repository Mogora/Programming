using Programming.Model.Classes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Rectangle = Programming.Model.Geometry.Rectangle;


namespace Programming.View.Panels
{
    /// <summary>
    /// Реализация представления прямоугольников.
    /// </summary>
    public partial class RectanglesCollisionControl : UserControl
    {
        /// <summary>
        /// Коллекция прямоугольников.
        /// </summary>
        private List<Rectangle> _rectangles;

        /// <summary>
        /// Коллекция отоброжаемых прямоугольников.
        /// </summary>
        private List<Panel> _rectanglePanels;

        /// <summary>
        /// Выбранный прямоугольник.
        /// </summary>
        private Rectangle _currentRectangle;

        /// <summary>
        /// Создает экземпляр класса <see cref="RectanglesCollisionControl"/>.
        /// </summary>
        public RectanglesCollisionControl()
        {
            InitializeComponent();

            _rectangles = new List<Rectangle>();

            _rectanglePanels = new List<Panel>();
        }

        /// <summary>
        /// Находит пересекающиеся прямоугольники и перекрашивает их.
        /// </summary>
        private void FindCollisions()
        {
            for (int k = 0; k < _rectangles.Count; k++)
            {
                CanvasPanel.Controls[k].BackColor = AppColors.UnCollisions;
            }

            for (int i = 0; i < _rectangles.Count - 1; i++)
            {
                for (int j = i + 1; j < _rectangles.Count; j++)
                {
                    if (Model.Geometry.CollisionManager.IsCollision(_rectangles[i], _rectangles[j]))
                    {
                        CanvasPanel.Controls[i].BackColor = AppColors.InCollisions;
                        CanvasPanel.Controls[j].BackColor = AppColors.InCollisions;
                    }
                }
            }
        }

        /// <summary>
        /// На значения прямоугольника задаются параметры.
        /// </summary>
        /// <param name="rectangle"> Прямоугольник. </param>
        /// <returns> Возвращает форматированный текс. </returns>
        private string RectangleParameters(Rectangle rectangle)
        {
            return $"{rectangle.Id}: " +
                   $"(X: {rectangle.Center.X};" +
                   $" Y: {rectangle.Center.Y};" +
                   $" W: {rectangle.Width};" +
                   $" H: {rectangle.Length})";
        }

        /// <summary>
        /// Обновляет информацию в списке.
        /// </summary>
        /// <param name="rectangle">Прямоугольник.</param>
        private void UpdateRectangleInfo(Rectangle rectangle)
        {
            int index = Rectangles2ListBox.FindString(rectangle.Id.ToString());

            if (index == -1) return;

            Rectangles2ListBox.Items[index] = RectangleParameters(rectangle);
        }

        /// <summary>
        /// Очищает информациюю о прямоугольниках из списка и текстовых полей.
        /// </summary>
        private void ClearRectangleInfo()
        {
            Rectangles2ListBox.Items.Clear();
            Id2RectangleTextBox.Clear();
            RectangleX2TextBox.Clear();
            RectangleY2TextBox.Clear();
            Width2TextBox.Clear();
            Length2TextBox.Clear();
            RectangleX2TextBox.BackColor = AppColors.CorrectColor;
            RectangleY2TextBox.BackColor = AppColors.CorrectColor;
            Width2TextBox.BackColor = AppColors.CorrectColor;
            Length2TextBox.BackColor = AppColors.CorrectColor;
            Rectangles2ListBox.Items.Clear();
        }

        private Panel CreatePanel()
        {
            Panel panel = new Panel();
            panel.Width = _currentRectangle.Width;
            panel.Height = _currentRectangle.Length;
            panel.Location = new Point(_currentRectangle.Center.X, _currentRectangle.Center.Y);
            panel.BackColor = AppColors.UnCollisions;

            return panel;
        }

        private void AddRectangleButton_Click(object sender, EventArgs e)
        {
            _currentRectangle = Model.Geometry.RectangleFactory.Randomize(CanvasPanel.Width, CanvasPanel.Height);
            _rectangles.Add(_currentRectangle);
            Rectangles2ListBox.Items.Add(RectangleParameters(_currentRectangle));

            Panel rectanglePanel = CreatePanel();
            _rectanglePanels.Add(rectanglePanel);
            CanvasPanel.Controls.Add(rectanglePanel);
            FindCollisions();
        }

        private void RemoveRectangleButton_Click(object sender, EventArgs e)
        {
            int indexSelectedRectangle = Rectangles2ListBox.SelectedIndex;

            if (indexSelectedRectangle == -1) return;

            _rectanglePanels.RemoveAt(indexSelectedRectangle);
            _rectangles.RemoveAt(indexSelectedRectangle);
            ClearRectangleInfo();

            foreach (var rectangle in _rectangles)
            {
                Rectangles2ListBox.Items.Add(RectangleParameters(rectangle));
                Rectangles2ListBox.SelectedIndex = 0;
            }

            CanvasPanel.Controls.RemoveAt(indexSelectedRectangle);
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
                string xRectangleAsString = RectangleX2TextBox.Text;
                int rectangleX = int.Parse(xRectangleAsString);
                _currentRectangle.Center.X = rectangleX;
                UpdateRectangleInfo(_currentRectangle);
                int index = Rectangles2ListBox.FindString(_currentRectangle.Id.ToString());
                Rectangles2ListBox.Items[index] = RectangleParameters(_currentRectangle);
                CanvasPanel.Controls[Rectangles2ListBox.SelectedIndex].Location =
                    new Point(_currentRectangle.Center.X, _currentRectangle.Center.Y);
            }
            catch
            {
                RectangleX2TextBox.BackColor = AppColors.ErrorColor;
                return;
            }
            RectangleX2TextBox.BackColor = AppColors.CorrectColor;
        }

        private void RectangleY2TextBox_TextChanged(object sender, EventArgs e)
        {
            if (Rectangles2ListBox.SelectedIndex == -1) return;
            try
            {
                string yRectangleAsString = RectangleY2TextBox.Text;
                int rectangleY = int.Parse(yRectangleAsString);
                _currentRectangle.Center.Y = rectangleY;
                UpdateRectangleInfo(_currentRectangle);
                int index = Rectangles2ListBox.FindString(_currentRectangle.Id.ToString());
                Rectangles2ListBox.Items[index] = RectangleParameters(_currentRectangle);
                CanvasPanel.Controls[Rectangles2ListBox.SelectedIndex].Location =
                     new Point(_currentRectangle.Center.X, _currentRectangle.Center.Y);
            }
            catch
            {
                RectangleY2TextBox.BackColor = AppColors.ErrorColor;
                return;
            }
            RectangleY2TextBox.BackColor = AppColors.CorrectColor;
        }

        private void Width2TextBox_TextChanged(object sender, EventArgs e)
        {
            if (Rectangles2ListBox.SelectedIndex == -1) return;
            try
            {
                string widthRectangleAsString = Width2TextBox.Text;
                int rectangleWidth = int.Parse(widthRectangleAsString);
                _currentRectangle.Width = rectangleWidth;
                UpdateRectangleInfo(_currentRectangle);
                int index = Rectangles2ListBox.FindString(_currentRectangle.Id.ToString());
                Rectangles2ListBox.Items[index] = RectangleParameters(_currentRectangle);
                CanvasPanel.Controls[Rectangles2ListBox.SelectedIndex].Width = _currentRectangle.Width;
            }
            catch
            {
                Width2TextBox.BackColor = AppColors.ErrorColor;
                return;
            }
            Width2TextBox.BackColor = AppColors.CorrectColor;
        }

        private void Length2TextBox_TextChanged(object sender, EventArgs e)
        {
            if (Rectangles2ListBox.SelectedIndex == -1) return;
            try
            {
                string lengthRectangleAsString = Length2TextBox.Text;
                int rectangleLength = int.Parse(lengthRectangleAsString);
                _currentRectangle.Length = rectangleLength;
                UpdateRectangleInfo(_currentRectangle);
                int index = Rectangles2ListBox.FindString(_currentRectangle.Id.ToString());
                Rectangles2ListBox.Items[index] = RectangleParameters(_currentRectangle);
                CanvasPanel.Controls[Rectangles2ListBox.SelectedIndex].Height = _currentRectangle.Length;
            }
            catch
            {
                Length2TextBox.BackColor = AppColors.ErrorColor;
                return;
            }
            Length2TextBox.BackColor = AppColors.CorrectColor;
        }
    }
}
