
namespace Programming.View.Panels
{
    partial class RectanglesCollisionControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Rectangles2GroupBox = new System.Windows.Forms.GroupBox();
            this.RectanglesListBox = new System.Windows.Forms.ListBox();
            this.CanvasPanel = new System.Windows.Forms.Panel();
            this.LengthTextBox = new System.Windows.Forms.TextBox();
            this.LengthLabel = new System.Windows.Forms.Label();
            this.AddRectangleButton = new System.Windows.Forms.Button();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.RemoveRectangleButton = new System.Windows.Forms.Button();
            this.RectangleYLabel = new System.Windows.Forms.Label();
            this.WidthTextBox = new System.Windows.Forms.TextBox();
            this.SelectedRectangleLabel = new System.Windows.Forms.Label();
            this.RectangleXLabel = new System.Windows.Forms.Label();
            this.Id2RectangleTextBox = new System.Windows.Forms.TextBox();
            this.IdRectangleLabel = new System.Windows.Forms.Label();
            this.RectangleXTextBox = new System.Windows.Forms.TextBox();
            this.RectangleYTextBox = new System.Windows.Forms.TextBox();
            this.Rectangles2GroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Rectangles2GroupBox
            // 
            this.Rectangles2GroupBox.Controls.Add(this.RectanglesListBox);
            this.Rectangles2GroupBox.Controls.Add(this.CanvasPanel);
            this.Rectangles2GroupBox.Controls.Add(this.LengthTextBox);
            this.Rectangles2GroupBox.Controls.Add(this.LengthLabel);
            this.Rectangles2GroupBox.Controls.Add(this.AddRectangleButton);
            this.Rectangles2GroupBox.Controls.Add(this.WidthLabel);
            this.Rectangles2GroupBox.Controls.Add(this.RemoveRectangleButton);
            this.Rectangles2GroupBox.Controls.Add(this.RectangleYLabel);
            this.Rectangles2GroupBox.Controls.Add(this.WidthTextBox);
            this.Rectangles2GroupBox.Controls.Add(this.SelectedRectangleLabel);
            this.Rectangles2GroupBox.Controls.Add(this.RectangleXLabel);
            this.Rectangles2GroupBox.Controls.Add(this.Id2RectangleTextBox);
            this.Rectangles2GroupBox.Controls.Add(this.IdRectangleLabel);
            this.Rectangles2GroupBox.Controls.Add(this.RectangleXTextBox);
            this.Rectangles2GroupBox.Controls.Add(this.RectangleYTextBox);
            this.Rectangles2GroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Rectangles2GroupBox.Location = new System.Drawing.Point(0, 0);
            this.Rectangles2GroupBox.Name = "Rectangles2GroupBox";
            this.Rectangles2GroupBox.Size = new System.Drawing.Size(870, 586);
            this.Rectangles2GroupBox.TabIndex = 17;
            this.Rectangles2GroupBox.TabStop = false;
            this.Rectangles2GroupBox.Text = "Rectangles";
            // 
            // RectanglesListBox
            // 
            this.RectanglesListBox.FormattingEnabled = true;
            this.RectanglesListBox.ItemHeight = 20;
            this.RectanglesListBox.Location = new System.Drawing.Point(9, 22);
            this.RectanglesListBox.Name = "RectanglesListBox";
            this.RectanglesListBox.Size = new System.Drawing.Size(414, 204);
            this.RectanglesListBox.TabIndex = 0;
            this.RectanglesListBox.Click += new System.EventHandler(this.RectanglesListBox_SelectedIndexChanged);
            this.RectanglesListBox.SelectedIndexChanged += new System.EventHandler(this.RectanglesListBox_SelectedIndexChanged);
            // 
            // CanvasPanel
            // 
            this.CanvasPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CanvasPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CanvasPanel.Location = new System.Drawing.Point(432, 22);
            this.CanvasPanel.Margin = new System.Windows.Forms.Padding(15);
            this.CanvasPanel.Name = "CanvasPanel";
            this.CanvasPanel.Size = new System.Drawing.Size(429, 546);
            this.CanvasPanel.TabIndex = 2;
            // 
            // LengthTextBox
            // 
            this.LengthTextBox.Location = new System.Drawing.Point(85, 446);
            this.LengthTextBox.Name = "LengthTextBox";
            this.LengthTextBox.Size = new System.Drawing.Size(152, 27);
            this.LengthTextBox.TabIndex = 10;
            this.LengthTextBox.Click += new System.EventHandler(this.LengthTextBox_TextChanged);
            this.LengthTextBox.TextChanged += new System.EventHandler(this.LengthTextBox_TextChanged);
            // 
            // LengthLabel
            // 
            this.LengthLabel.AutoSize = true;
            this.LengthLabel.Location = new System.Drawing.Point(14, 449);
            this.LengthLabel.Name = "LengthLabel";
            this.LengthLabel.Size = new System.Drawing.Size(57, 20);
            this.LengthLabel.TabIndex = 15;
            this.LengthLabel.Text = "Length:";
            // 
            // AddRectangleButton
            // 
            this.AddRectangleButton.BackgroundImage = global::Programming.Properties.Resources.rectangle_add_24x24_uncolor;
            this.AddRectangleButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AddRectangleButton.FlatAppearance.BorderSize = 0;
            this.AddRectangleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddRectangleButton.Location = new System.Drawing.Point(51, 246);
            this.AddRectangleButton.Name = "AddRectangleButton";
            this.AddRectangleButton.Size = new System.Drawing.Size(100, 35);
            this.AddRectangleButton.TabIndex = 3;
            this.AddRectangleButton.UseVisualStyleBackColor = true;
            this.AddRectangleButton.Click += new System.EventHandler(this.AddRectangleButton_Click);
            this.AddRectangleButton.MouseEnter += new System.EventHandler(this.AddRectangleButton_MouseEnter);
            this.AddRectangleButton.MouseLeave += new System.EventHandler(this.AddRectangleButton_MouseLeave);
            // 
            // WidthLabel
            // 
            this.WidthLabel.AutoSize = true;
            this.WidthLabel.Location = new System.Drawing.Point(15, 416);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(52, 20);
            this.WidthLabel.TabIndex = 14;
            this.WidthLabel.Text = "Width:";
            // 
            // RemoveRectangleButton
            // 
            this.RemoveRectangleButton.BackgroundImage = global::Programming.Properties.Resources.rectangle_remove_24x24_uncolor;
            this.RemoveRectangleButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RemoveRectangleButton.FlatAppearance.BorderSize = 0;
            this.RemoveRectangleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveRectangleButton.Location = new System.Drawing.Point(192, 246);
            this.RemoveRectangleButton.Name = "RemoveRectangleButton";
            this.RemoveRectangleButton.Size = new System.Drawing.Size(100, 35);
            this.RemoveRectangleButton.TabIndex = 4;
            this.RemoveRectangleButton.UseVisualStyleBackColor = true;
            this.RemoveRectangleButton.Click += new System.EventHandler(this.RemoveRectangleButton_Click);
            this.RemoveRectangleButton.MouseEnter += new System.EventHandler(this.RemoveButton_MouseEnter);
            this.RemoveRectangleButton.MouseLeave += new System.EventHandler(this.RemoveButton_MouseLeave);
            // 
            // RectangleYLabel
            // 
            this.RectangleYLabel.AutoSize = true;
            this.RectangleYLabel.Location = new System.Drawing.Point(47, 383);
            this.RectangleYLabel.Name = "RectangleYLabel";
            this.RectangleYLabel.Size = new System.Drawing.Size(20, 20);
            this.RectangleYLabel.TabIndex = 13;
            this.RectangleYLabel.Text = "Y:";
            // 
            // WidthTextBox
            // 
            this.WidthTextBox.Location = new System.Drawing.Point(85, 413);
            this.WidthTextBox.Name = "WidthTextBox";
            this.WidthTextBox.Size = new System.Drawing.Size(152, 27);
            this.WidthTextBox.TabIndex = 9;
            this.WidthTextBox.Click += new System.EventHandler(this.WidthTextBox_TextChanged);
            this.WidthTextBox.TextChanged += new System.EventHandler(this.WidthTextBox_TextChanged);
            // 
            // SelectedRectangleLabel
            // 
            this.SelectedRectangleLabel.AutoSize = true;
            this.SelectedRectangleLabel.Location = new System.Drawing.Point(11, 291);
            this.SelectedRectangleLabel.Name = "SelectedRectangleLabel";
            this.SelectedRectangleLabel.Size = new System.Drawing.Size(139, 20);
            this.SelectedRectangleLabel.TabIndex = 5;
            this.SelectedRectangleLabel.Text = "Selected Rectangle:";
            // 
            // RectangleXLabel
            // 
            this.RectangleXLabel.AutoSize = true;
            this.RectangleXLabel.Location = new System.Drawing.Point(47, 350);
            this.RectangleXLabel.Name = "RectangleXLabel";
            this.RectangleXLabel.Size = new System.Drawing.Size(21, 20);
            this.RectangleXLabel.TabIndex = 12;
            this.RectangleXLabel.Text = "X:";
            // 
            // Id2RectangleTextBox
            // 
            this.Id2RectangleTextBox.Enabled = false;
            this.Id2RectangleTextBox.Location = new System.Drawing.Point(85, 314);
            this.Id2RectangleTextBox.Name = "Id2RectangleTextBox";
            this.Id2RectangleTextBox.ReadOnly = true;
            this.Id2RectangleTextBox.Size = new System.Drawing.Size(152, 27);
            this.Id2RectangleTextBox.TabIndex = 6;
            // 
            // IdRectangleLabel
            // 
            this.IdRectangleLabel.AutoSize = true;
            this.IdRectangleLabel.Location = new System.Drawing.Point(46, 317);
            this.IdRectangleLabel.Name = "IdRectangleLabel";
            this.IdRectangleLabel.Size = new System.Drawing.Size(25, 20);
            this.IdRectangleLabel.TabIndex = 11;
            this.IdRectangleLabel.Text = "Id:";
            // 
            // RectangleXTextBox
            // 
            this.RectangleXTextBox.Location = new System.Drawing.Point(85, 347);
            this.RectangleXTextBox.Name = "RectangleXTextBox";
            this.RectangleXTextBox.Size = new System.Drawing.Size(152, 27);
            this.RectangleXTextBox.TabIndex = 7;
            this.RectangleXTextBox.Click += new System.EventHandler(this.RectangleXTextBox_TextChanged);
            this.RectangleXTextBox.TextChanged += new System.EventHandler(this.RectangleXTextBox_TextChanged);
            // 
            // RectangleYTextBox
            // 
            this.RectangleYTextBox.Location = new System.Drawing.Point(85, 380);
            this.RectangleYTextBox.Name = "RectangleYTextBox";
            this.RectangleYTextBox.Size = new System.Drawing.Size(152, 27);
            this.RectangleYTextBox.TabIndex = 8;
            this.RectangleYTextBox.Click += new System.EventHandler(this.RectangleYTextBox_TextChanged);
            this.RectangleYTextBox.TextChanged += new System.EventHandler(this.RectangleYTextBox_TextChanged);
            // 
            // RectanglesCollisionControl
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Rectangles2GroupBox);
            this.Name = "RectanglesCollisionControl";
            this.Size = new System.Drawing.Size(870, 586);
            this.Rectangles2GroupBox.ResumeLayout(false);
            this.Rectangles2GroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Rectangles2GroupBox;
        private System.Windows.Forms.ListBox RectanglesListBox;
        private System.Windows.Forms.Panel CanvasPanel;
        private System.Windows.Forms.TextBox LengthTextBox;
        private System.Windows.Forms.Label LengthLabel;
        private System.Windows.Forms.Button AddRectangleButton;
        private System.Windows.Forms.Label WidthLabel;
        private System.Windows.Forms.Button RemoveRectangleButton;
        private System.Windows.Forms.Label RectangleYLabel;
        private System.Windows.Forms.TextBox WidthTextBox;
        private System.Windows.Forms.Label SelectedRectangleLabel;
        private System.Windows.Forms.Label RectangleXLabel;
        private System.Windows.Forms.TextBox Id2RectangleTextBox;
        private System.Windows.Forms.Label IdRectangleLabel;
        private System.Windows.Forms.TextBox RectangleXTextBox;
        private System.Windows.Forms.TextBox RectangleYTextBox;
    }
}
