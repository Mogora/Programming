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
        /// Коллекция отображаемых прямоугольников.
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
            int index = RectanglesListBox.FindString(rectangle.Id.ToString());

            if (index == -1) return;

            RectanglesListBox.Items[index] = RectangleParameters(rectangle);
        }

        /// <summary>
        /// Очищает информациюю о прямоугольниках из списка и текстовых полей.
        /// </summary>
        private void ClearRectangleInfo()
        {
            RectanglesListBox.Items.Clear();
            Id2RectangleTextBox.Clear();
            RectangleXTextBox.Clear();
            RectangleYTextBox.Clear();
            WidthTextBox.Clear();
            LengthTextBox.Clear();
            RectangleXTextBox.BackColor = AppColors.CorrectColor;
            RectangleYTextBox.BackColor = AppColors.CorrectColor;
            WidthTextBox.BackColor = AppColors.CorrectColor;
            LengthTextBox.BackColor = AppColors.CorrectColor;
            RectanglesListBox.Items.Clear();
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
            RectanglesListBox.Items.Add(RectangleParameters(_currentRectangle));

            Panel rectanglePanel = CreatePanel();
            _rectanglePanels.Add(rectanglePanel);
            CanvasPanel.Controls.Add(rectanglePanel);
            FindCollisions();
        }

        private void RemoveRectangleButton_Click(object sender, EventArgs e)
        {
            int indexSelectedRectangle = RectanglesListBox.SelectedIndex;

            if (indexSelectedRectangle == -1) return;

            _rectanglePanels.RemoveAt(indexSelectedRectangle);
            _rectangles.RemoveAt(indexSelectedRectangle);
            ClearRectangleInfo();

            foreach (var rectangle in _rectangles)
            {
                RectanglesListBox.Items.Add(RectangleParameters(rectangle));
                RectanglesListBox.SelectedIndex = 0;
            }

            CanvasPanel.Controls.RemoveAt(indexSelectedRectangle);
            FindCollisions();
        }

        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RectanglesListBox.SelectedIndex != -1)
            {
                int indexSelectedRectangle = RectanglesListBox.SelectedIndex;
                _currentRectangle = _rectangles[indexSelectedRectangle];
                LengthTextBox.Text = _currentRectangle.Length.ToString();
                WidthTextBox.Text = _currentRectangle.Width.ToString();
                RectangleXTextBox.Text = _currentRectangle.Center.X.ToString();
                RectangleYTextBox.Text = _currentRectangle.Center.Y.ToString();
                Id2RectangleTextBox.Text = _currentRectangle.Id.ToString();
            }
        }

        private void RectangleXTextBox_TextChanged(object sender, EventArgs e)
        {

            if (RectanglesListBox.SelectedIndex == -1) return;

            try
            {
                string xRectangleAsString = RectangleXTextBox.Text;
                int rectangleX = int.Parse(xRectangleAsString);
                _currentRectangle.Center.X = rectangleX;
                UpdateRectangleInfo(_currentRectangle);
                int index = RectanglesListBox.FindString(_currentRectangle.Id.ToString());
                RectanglesListBox.Items[index] = RectangleParameters(_currentRectangle);
                CanvasPanel.Controls[RectanglesListBox.SelectedIndex].Location =
                    new Point(_currentRectangle.Center.X, _currentRectangle.Center.Y);
            }
            catch
            {
                RectangleXTextBox.BackColor = AppColors.ErrorColor;
                return;
            }
            RectangleXTextBox.BackColor = AppColors.CorrectColor;
        }

        private void RectangleYTextBox_TextChanged(object sender, EventArgs e)
        {
            if (RectanglesListBox.SelectedIndex == -1) return;
            try
            {
                string yRectangleAsString = RectangleYTextBox.Text;
                int rectangleY = int.Parse(yRectangleAsString);
                _currentRectangle.Center.Y = rectangleY;
                UpdateRectangleInfo(_currentRectangle);
                int index = RectanglesListBox.FindString(_currentRectangle.Id.ToString());
                RectanglesListBox.Items[index] = RectangleParameters(_currentRectangle);
                CanvasPanel.Controls[RectanglesListBox.SelectedIndex].Location =
                     new Point(_currentRectangle.Center.X, _currentRectangle.Center.Y);
            }
            catch
            {
                RectangleYTextBox.BackColor = AppColors.ErrorColor;
                return;
            }
            RectangleYTextBox.BackColor = AppColors.CorrectColor;
        }

        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {
            if (RectanglesListBox.SelectedIndex == -1) return;
            try
            {
                string widthRectangleAsString = WidthTextBox.Text;
                int rectangleWidth = int.Parse(widthRectangleAsString);
                _currentRectangle.Width = rectangleWidth;
                UpdateRectangleInfo(_currentRectangle);
                int index = RectanglesListBox.FindString(_currentRectangle.Id.ToString());
                RectanglesListBox.Items[index] = RectangleParameters(_currentRectangle);
                CanvasPanel.Controls[RectanglesListBox.SelectedIndex].Width = _currentRectangle.Width;
            }
            catch
            {
                WidthTextBox.BackColor = AppColors.ErrorColor;
                return;
            }
            WidthTextBox.BackColor = AppColors.CorrectColor;
        }

        private void LengthTextBox_TextChanged(object sender, EventArgs e)
        {
            if (RectanglesListBox.SelectedIndex == -1) return;
            try
            {
                string lengthRectangleAsString = LengthTextBox.Text;
                int rectangleLength = int.Parse(lengthRectangleAsString);
                _currentRectangle.Length = rectangleLength;
                UpdateRectangleInfo(_currentRectangle);
                int index = RectanglesListBox.FindString(_currentRectangle.Id.ToString());
                RectanglesListBox.Items[index] = RectangleParameters(_currentRectangle);
                CanvasPanel.Controls[RectanglesListBox.SelectedIndex].Height = _currentRectangle.Length;
            }
            catch
            {
                LengthTextBox.BackColor = AppColors.ErrorColor;
                return;
            }
            LengthTextBox.BackColor = AppColors.CorrectColor;
        }

        private void AddRectangleButton_MouseEnter(object sender, EventArgs e)
        {
            AddRectangleButton.Image = Properties.Resources.rectangle_add_24x24;
        }

        private void AddRectangleButton_MouseLeave(object sender, EventArgs e)
        {
            AddRectangleButton.Image = Properties.Resources.rectangle_add_24x24_uncolor;
        }

        private void RemoveButton_MouseEnter(object sender, EventArgs e)
        {
            RemoveRectangleButton.Image = Properties.Resources.rectangle_remove_24x24;
        }

        private void RemoveButton_MouseLeave(object sender, EventArgs e)
        {
            RemoveRectangleButton.Image = Properties.Resources.rectangle_remove_24x24_uncolor;
        }
    }
}
