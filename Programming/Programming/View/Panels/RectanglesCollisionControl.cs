using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Rectangle = Programming.Model.Geometry.Rectangle;
using Programming.Model.Classes;


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
                CanvasPanel.Controls[k].BackColor = AppColors.UnContact;
            }

            for (int i = 0; i < _rectangles.Count - 1; i++)
            {
                for (int j = i + 1; j < _rectangles.Count; j++)
                {
                    if (Model.Geometry.CollisionManager.IsCollision(_rectangles[i], _rectangles[j]))
                    {
                        CanvasPanel.Controls[i].BackColor = AppColors.InContact;
                        CanvasPanel.Controls[j].BackColor = AppColors.InContact;
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

        private void UpdatePanel(Rectangle rectangle, int index)
        {
            var control = CanvasPanel.Controls[index];
            control.Location = new Point(rectangle.Center.X, rectangle.Center.Y);
            control.Width = rectangle.Width;
            control.Height = rectangle.Length;
        }

        /// <summary>
        /// Обновляет информацию о прямоугольнике в списке. 
        /// </summary>
        /// <param name="rectangle"> Прямоугольник. </param>
        private void UpdateRectangleInfo(Rectangle rectangle)
        {
            if (rectangle != null)
            {
                var copyRectangle = new Rectangle(rectangle);
                var oldRectangle = _rectangles[Rectangles2ListBox.SelectedIndex];

                var halfDifferenceWidth = Math.Abs(oldRectangle.Width - copyRectangle.Width) / 2;
                var halfDifferenceLength = Math.Abs(oldRectangle.Length - copyRectangle.Length) / 2;

                if (copyRectangle.Center.X == oldRectangle.Center.X && copyRectangle.Center.Y == oldRectangle.Center.Y)
                {
                    copyRectangle.Center.X = oldRectangle.Width >= copyRectangle.Width
                        ? oldRectangle.Center.X + halfDifferenceWidth
                        : oldRectangle.Center.X - halfDifferenceWidth;

                    copyRectangle.Center.Y = oldRectangle.Length >= copyRectangle.Length
                        ? oldRectangle.Center.Y + halfDifferenceLength
                        : oldRectangle.Center.Y - halfDifferenceLength;
                }

                var index = _rectangles.FindIndex(r => r.Id == copyRectangle.Id);
                _rectangles[index] = copyRectangle;

                UpdatePanel(copyRectangle, index);
                FindCollisions();
            }
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

        private void AddRectangleButton_Click(object sender, EventArgs e)
        {
            var rectangle = Model.Geometry.RectangleFactory.Randomize(CanvasPanel.Width, CanvasPanel.Height);
            _rectangles.Add(rectangle);
            Rectangles2ListBox.Items.Add(RectangleParameters(rectangle));

            Panel rectanglePanel = new Panel();
            rectanglePanel.Width = rectangle.Width;
            rectanglePanel.Height = rectangle.Length;
            rectanglePanel.Location = new Point(rectangle.Center.X, rectangle.Center.Y);
            rectanglePanel.BackColor = AppColors.UnContact;
            _rectanglePanels.Add(rectanglePanel);
            CanvasPanel.Controls.Add(rectanglePanel);
        }

        private void RemoveRectangleButton_Click(object sender, EventArgs e)
        {
            int index = Rectangles2ListBox.SelectedIndex;
            if (index == -1) return;
            _rectangles.RemoveAt(index);
            CanvasPanel.Controls.RemoveAt(index);
            ClearRectangleInfo();

            foreach (var rectangle in _rectangles)
            {
                Rectangles2ListBox.Items.Add($"Rectangle {rectangle.Id}");
                Rectangles2ListBox.SelectedIndex = 0;
            }
            FindCollisions();
        }

        private void Rectangles2ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Rectangles2ListBox.SelectedIndex != -1)
            {
                int indexSelectedRectangle = Rectangles2ListBox.SelectedIndex;
                _currentRectangle = _rectangles[indexSelectedRectangle];
                _currentRectangle = new Rectangle(_rectangles[indexSelectedRectangle]);
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
