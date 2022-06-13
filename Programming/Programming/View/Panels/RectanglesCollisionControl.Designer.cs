
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
            this.Rectangles2ListBox = new System.Windows.Forms.ListBox();
            this.CanvasPanel = new System.Windows.Forms.Panel();
            this.Length2TextBox = new System.Windows.Forms.TextBox();
            this.Length2Label = new System.Windows.Forms.Label();
            this.AddRectangleButton = new System.Windows.Forms.Button();
            this.Width2Label = new System.Windows.Forms.Label();
            this.RemoveRectangleButton = new System.Windows.Forms.Button();
            this.RectangleY2Label = new System.Windows.Forms.Label();
            this.Width2TextBox = new System.Windows.Forms.TextBox();
            this.SelectedRectangleLabel = new System.Windows.Forms.Label();
            this.RectangleX2Label = new System.Windows.Forms.Label();
            this.Id2RectangleTextBox = new System.Windows.Forms.TextBox();
            this.IdRectangle2Label = new System.Windows.Forms.Label();
            this.RectangleX2TextBox = new System.Windows.Forms.TextBox();
            this.RectangleY2TextBox = new System.Windows.Forms.TextBox();
            this.Rectangles2GroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Rectangles2GroupBox
            // 
            this.Rectangles2GroupBox.Controls.Add(this.Rectangles2ListBox);
            this.Rectangles2GroupBox.Controls.Add(this.CanvasPanel);
            this.Rectangles2GroupBox.Controls.Add(this.Length2TextBox);
            this.Rectangles2GroupBox.Controls.Add(this.Length2Label);
            this.Rectangles2GroupBox.Controls.Add(this.AddRectangleButton);
            this.Rectangles2GroupBox.Controls.Add(this.Width2Label);
            this.Rectangles2GroupBox.Controls.Add(this.RemoveRectangleButton);
            this.Rectangles2GroupBox.Controls.Add(this.RectangleY2Label);
            this.Rectangles2GroupBox.Controls.Add(this.Width2TextBox);
            this.Rectangles2GroupBox.Controls.Add(this.SelectedRectangleLabel);
            this.Rectangles2GroupBox.Controls.Add(this.RectangleX2Label);
            this.Rectangles2GroupBox.Controls.Add(this.Id2RectangleTextBox);
            this.Rectangles2GroupBox.Controls.Add(this.IdRectangle2Label);
            this.Rectangles2GroupBox.Controls.Add(this.RectangleX2TextBox);
            this.Rectangles2GroupBox.Controls.Add(this.RectangleY2TextBox);
            this.Rectangles2GroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Rectangles2GroupBox.Location = new System.Drawing.Point(0, 0);
            this.Rectangles2GroupBox.Name = "Rectangles2GroupBox";
            this.Rectangles2GroupBox.Size = new System.Drawing.Size(1316, 842);
            this.Rectangles2GroupBox.TabIndex = 17;
            this.Rectangles2GroupBox.TabStop = false;
            this.Rectangles2GroupBox.Text = "Rectangles";
            // 
            // Rectangles2ListBox
            // 
            this.Rectangles2ListBox.FormattingEnabled = true;
            this.Rectangles2ListBox.ItemHeight = 20;
            this.Rectangles2ListBox.Location = new System.Drawing.Point(9, 22);
            this.Rectangles2ListBox.Name = "Rectangles2ListBox";
            this.Rectangles2ListBox.Size = new System.Drawing.Size(414, 204);
            this.Rectangles2ListBox.TabIndex = 0;
            this.Rectangles2ListBox.Click += new System.EventHandler(this.Rectangles2ListBox_SelectedIndexChanged);
            this.Rectangles2ListBox.SelectedIndexChanged += new System.EventHandler(this.Rectangles2ListBox_SelectedIndexChanged);
            // 
            // CanvasPanel
            // 
            this.CanvasPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CanvasPanel.Location = new System.Drawing.Point(429, 18);
            this.CanvasPanel.Name = "CanvasPanel";
            this.CanvasPanel.Size = new System.Drawing.Size(426, 543);
            this.CanvasPanel.TabIndex = 2;
            // 
            // Length2TextBox
            // 
            this.Length2TextBox.Location = new System.Drawing.Point(85, 517);
            this.Length2TextBox.Name = "Length2TextBox";
            this.Length2TextBox.Size = new System.Drawing.Size(152, 27);
            this.Length2TextBox.TabIndex = 10;
            this.Length2TextBox.Click += new System.EventHandler(this.Length2TextBox_TextChanged);
            this.Length2TextBox.TextChanged += new System.EventHandler(this.Length2TextBox_TextChanged);
            // 
            // Length2Label
            // 
            this.Length2Label.AutoSize = true;
            this.Length2Label.Location = new System.Drawing.Point(9, 520);
            this.Length2Label.Name = "Length2Label";
            this.Length2Label.Size = new System.Drawing.Size(57, 20);
            this.Length2Label.TabIndex = 15;
            this.Length2Label.Text = "Length:";
            // 
            // AddRectangleButton
            // 
            this.AddRectangleButton.Location = new System.Drawing.Point(51, 246);
            this.AddRectangleButton.Name = "AddRectangleButton";
            this.AddRectangleButton.Size = new System.Drawing.Size(94, 29);
            this.AddRectangleButton.TabIndex = 3;
            this.AddRectangleButton.Text = "Add";
            this.AddRectangleButton.UseVisualStyleBackColor = true;
            this.AddRectangleButton.Click += new System.EventHandler(this.AddRectangleButton_Click);
            // 
            // Width2Label
            // 
            this.Width2Label.AutoSize = true;
            this.Width2Label.Location = new System.Drawing.Point(11, 476);
            this.Width2Label.Name = "Width2Label";
            this.Width2Label.Size = new System.Drawing.Size(52, 20);
            this.Width2Label.TabIndex = 14;
            this.Width2Label.Text = "Width:";
            // 
            // RemoveRectangleButton
            // 
            this.RemoveRectangleButton.Location = new System.Drawing.Point(192, 246);
            this.RemoveRectangleButton.Name = "RemoveRectangleButton";
            this.RemoveRectangleButton.Size = new System.Drawing.Size(94, 29);
            this.RemoveRectangleButton.TabIndex = 4;
            this.RemoveRectangleButton.Text = "Remove";
            this.RemoveRectangleButton.UseVisualStyleBackColor = true;
            this.RemoveRectangleButton.Click += new System.EventHandler(this.RemoveRectangleButton_Click);
            // 
            // RectangleY2Label
            // 
            this.RectangleY2Label.AutoSize = true;
            this.RectangleY2Label.Location = new System.Drawing.Point(43, 426);
            this.RectangleY2Label.Name = "RectangleY2Label";
            this.RectangleY2Label.Size = new System.Drawing.Size(20, 20);
            this.RectangleY2Label.TabIndex = 13;
            this.RectangleY2Label.Text = "Y:";
            // 
            // Width2TextBox
            // 
            this.Width2TextBox.Location = new System.Drawing.Point(85, 469);
            this.Width2TextBox.Name = "Width2TextBox";
            this.Width2TextBox.Size = new System.Drawing.Size(152, 27);
            this.Width2TextBox.TabIndex = 9;
            this.Width2TextBox.Click += new System.EventHandler(this.Width2TextBox_TextChanged);
            this.Width2TextBox.TextChanged += new System.EventHandler(this.Width2TextBox_TextChanged);
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
            // RectangleX2Label
            // 
            this.RectangleX2Label.AutoSize = true;
            this.RectangleX2Label.Location = new System.Drawing.Point(42, 382);
            this.RectangleX2Label.Name = "RectangleX2Label";
            this.RectangleX2Label.Size = new System.Drawing.Size(21, 20);
            this.RectangleX2Label.TabIndex = 12;
            this.RectangleX2Label.Text = "X:";
            // 
            // Id2RectangleTextBox
            // 
            this.Id2RectangleTextBox.Enabled = false;
            this.Id2RectangleTextBox.Location = new System.Drawing.Point(85, 329);
            this.Id2RectangleTextBox.Name = "Id2RectangleTextBox";
            this.Id2RectangleTextBox.ReadOnly = true;
            this.Id2RectangleTextBox.Size = new System.Drawing.Size(152, 27);
            this.Id2RectangleTextBox.TabIndex = 6;
            // 
            // IdRectangle2Label
            // 
            this.IdRectangle2Label.AutoSize = true;
            this.IdRectangle2Label.Location = new System.Drawing.Point(38, 332);
            this.IdRectangle2Label.Name = "IdRectangle2Label";
            this.IdRectangle2Label.Size = new System.Drawing.Size(25, 20);
            this.IdRectangle2Label.TabIndex = 11;
            this.IdRectangle2Label.Text = "Id:";
            // 
            // RectangleX2TextBox
            // 
            this.RectangleX2TextBox.Location = new System.Drawing.Point(85, 375);
            this.RectangleX2TextBox.Name = "RectangleX2TextBox";
            this.RectangleX2TextBox.Size = new System.Drawing.Size(152, 27);
            this.RectangleX2TextBox.TabIndex = 7;
            this.RectangleX2TextBox.Click += new System.EventHandler(this.RectangleX2TextBox_TextChanged);
            this.RectangleX2TextBox.TextChanged += new System.EventHandler(this.RectangleX2TextBox_TextChanged);
            // 
            // RectangleY2TextBox
            // 
            this.RectangleY2TextBox.Location = new System.Drawing.Point(85, 419);
            this.RectangleY2TextBox.Name = "RectangleY2TextBox";
            this.RectangleY2TextBox.Size = new System.Drawing.Size(152, 27);
            this.RectangleY2TextBox.TabIndex = 8;
            this.RectangleY2TextBox.Click += new System.EventHandler(this.RectangleY2TextBox_TextChanged);
            this.RectangleY2TextBox.TextChanged += new System.EventHandler(this.RectangleY2TextBox_TextChanged);
            // 
            // RectanglesCollisionControl
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Rectangles2GroupBox);
            this.Name = "RectanglesCollisionControl";
            this.Size = new System.Drawing.Size(1316, 842);
            this.Rectangles2GroupBox.ResumeLayout(false);
            this.Rectangles2GroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Rectangles2GroupBox;
        private System.Windows.Forms.ListBox Rectangles2ListBox;
        private System.Windows.Forms.Panel CanvasPanel;
        private System.Windows.Forms.TextBox Length2TextBox;
        private System.Windows.Forms.Label Length2Label;
        private System.Windows.Forms.Button AddRectangleButton;
        private System.Windows.Forms.Label Width2Label;
        private System.Windows.Forms.Button RemoveRectangleButton;
        private System.Windows.Forms.Label RectangleY2Label;
        private System.Windows.Forms.TextBox Width2TextBox;
        private System.Windows.Forms.Label SelectedRectangleLabel;
        private System.Windows.Forms.Label RectangleX2Label;
        private System.Windows.Forms.TextBox Id2RectangleTextBox;
        private System.Windows.Forms.Label IdRectangle2Label;
        private System.Windows.Forms.TextBox RectangleX2TextBox;
        private System.Windows.Forms.TextBox RectangleY2TextBox;
    }
}
