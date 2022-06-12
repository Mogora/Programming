using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Rectangle = Programming.Model.Geometry.Rectangle;


namespace Programming.Panels
{
    public partial class RectanglesCollisionControl : UserControl
    {
        private readonly System.Drawing.Color ErrorColor = System.Drawing.Color.LightPink;

        private readonly System.Drawing.Color CorrectColor = System.Drawing.Color.White;

        private readonly Color _inContact = Color.FromArgb(127, 255, 127, 127);

        private readonly Color _unContact = Color.FromArgb(127, 127, 255, 127);

        private List<Rectangle> _rectangles;

        private List<Panel> _rectanglePanels;

        private Rectangle _currentRectangle;

        public RectanglesCollisionControl()
        {
            InitializeComponent();

            _rectangles = new List<Rectangle>();

            _rectanglePanels = new List<Panel>();
        }

        private void FindCollisions()
        {
            for (int k = 0; k < _rectangles.Count; k++)
            {
                CanvasPanel.Controls[k].BackColor = _unContact;
            }

            for (int i = 0; i < _rectangles.Count - 1; i++)
            {
                for (int j = i + 1; j < _rectangles.Count; j++)
                {
                    if (Model.Geometry.CollisionManager.IsCollision(_rectangles[i], _rectangles[j]))
                    {
                        CanvasPanel.Controls[i].BackColor = _inContact;
                        CanvasPanel.Controls[j].BackColor = _inContact;
                    }
                }
            }
        }

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

        private void ClearRectangleInfo()
        {
            Rectangles2ListBox.Items.Clear();
            Id2RectangleTextBox.Clear();
            RectangleX2TextBox.Clear();
            RectangleY2TextBox.Clear();
            Width2TextBox.Clear();
            Length2TextBox.Clear();
            RectangleX2TextBox.BackColor = CorrectColor;
            RectangleY2TextBox.BackColor = CorrectColor;
            Width2TextBox.BackColor = CorrectColor;
            Length2TextBox.BackColor = CorrectColor;
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
            rectanglePanel.BackColor = _unContact;
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
                string yRectangleAsString = RectangleY2TextBox.Text;
                int rectangleY = int.Parse(yRectangleAsString);
                _currentRectangle.Center.Y = rectangleY;
                UpdateRectangleInfo(_currentRectangle);
                int index = Rectangles2ListBox.FindString(_currentRectangle.Id.ToString());
                Rectangles2ListBox.Items[index] = RectangleParameters(_currentRectangle);
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
                string widthRectangleAsString = Width2TextBox.Text;
                int rectangleWidth = int.Parse(widthRectangleAsString);
                _currentRectangle.Width = rectangleWidth;
                UpdateRectangleInfo(_currentRectangle);
                int index = Rectangles2ListBox.FindString(_currentRectangle.Id.ToString());
                Rectangles2ListBox.Items[index] = RectangleParameters(_currentRectangle);
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
                string lengthRectangleAsString = Length2TextBox.Text;
                int rectangleLength = int.Parse(lengthRectangleAsString);
                _currentRectangle.Length = rectangleLength;
                UpdateRectangleInfo(_currentRectangle);
                int index = Rectangles2ListBox.FindString(_currentRectangle.Id.ToString());
                Rectangles2ListBox.Items[index] = RectangleParameters(_currentRectangle);
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
