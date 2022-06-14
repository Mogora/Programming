namespace Programming.View
{
    partial class MainForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.EnumsTabPage = new System.Windows.Forms.TabPage();
            this.seasonsHandleControl1 = new Programming.View.Panels.SeasonsHandleControl();
            this.weekdayParsingControl1 = new Programming.View.Panels.WeekdayParsingControl();
            this.enumerationsControl1 = new Programming.View.Panels.EnumerationsControl();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.ClassestabPage = new System.Windows.Forms.TabPage();
            this.MoviesGroupBox = new System.Windows.Forms.GroupBox();
            this.MovieTimeLabel = new System.Windows.Forms.Label();
            this.MovieTimeTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.FindMovieButton_Click = new System.Windows.Forms.Button();
            this.GenreTextBox = new System.Windows.Forms.TextBox();
            this.ReleaseYearTextBox = new System.Windows.Forms.TextBox();
            this.RatingTextBox = new System.Windows.Forms.TextBox();
            this.GenreLabel = new System.Windows.Forms.Label();
            this.ReleaseYearLabel = new System.Windows.Forms.Label();
            this.RatingLabel = new System.Windows.Forms.Label();
            this.MoviesListBox = new System.Windows.Forms.ListBox();
            this.RectanglesTabPage = new System.Windows.Forms.TabPage();
            this.rectanglesCollisionControl1 = new Programming.View.Panels.RectanglesCollisionControl();
            this.rectangleControl1 = new Programming.View.Panels.RectangleControl();
            this.EnumsTabPage.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.ClassestabPage.SuspendLayout();
            this.MoviesGroupBox.SuspendLayout();
            this.RectanglesTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // EnumsTabPage
            // 
            this.EnumsTabPage.Controls.Add(this.seasonsHandleControl1);
            this.EnumsTabPage.Controls.Add(this.weekdayParsingControl1);
            this.EnumsTabPage.Controls.Add(this.enumerationsControl1);
            this.EnumsTabPage.Location = new System.Drawing.Point(4, 24);
            this.EnumsTabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EnumsTabPage.Name = "EnumsTabPage";
            this.EnumsTabPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EnumsTabPage.Size = new System.Drawing.Size(760, 436);
            this.EnumsTabPage.TabIndex = 0;
            this.EnumsTabPage.Text = "Enums";
            this.EnumsTabPage.UseVisualStyleBackColor = true;
            // 
            // seasonsHandleControl1
            // 
            this.seasonsHandleControl1.Location = new System.Drawing.Point(382, 291);
            this.seasonsHandleControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.seasonsHandleControl1.Name = "seasonsHandleControl1";
            this.seasonsHandleControl1.Size = new System.Drawing.Size(368, 130);
            this.seasonsHandleControl1.TabIndex = 5;
            // 
            // weekdayParsingControl1
            // 
            this.weekdayParsingControl1.Location = new System.Drawing.Point(4, 291);
            this.weekdayParsingControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.weekdayParsingControl1.Name = "weekdayParsingControl1";
            this.weekdayParsingControl1.Size = new System.Drawing.Size(374, 130);
            this.weekdayParsingControl1.TabIndex = 4;
            // 
            // enumerationsControl1
            // 
            this.enumerationsControl1.Location = new System.Drawing.Point(4, 8);
            this.enumerationsControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.enumerationsControl1.Name = "enumerationsControl1";
            this.enumerationsControl1.Size = new System.Drawing.Size(746, 277);
            this.enumerationsControl1.TabIndex = 3;
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.EnumsTabPage);
            this.TabControl.Controls.Add(this.ClassestabPage);
            this.TabControl.Controls.Add(this.RectanglesTabPage);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(768, 464);
            this.TabControl.TabIndex = 0;
            // 
            // ClassestabPage
            // 
            this.ClassestabPage.Controls.Add(this.rectangleControl1);
            this.ClassestabPage.Controls.Add(this.MoviesGroupBox);
            this.ClassestabPage.Location = new System.Drawing.Point(4, 24);
            this.ClassestabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ClassestabPage.Name = "ClassestabPage";
            this.ClassestabPage.Size = new System.Drawing.Size(760, 436);
            this.ClassestabPage.TabIndex = 1;
            this.ClassestabPage.Text = "Classes";
            this.ClassestabPage.UseVisualStyleBackColor = true;
            // 
            // MoviesGroupBox
            // 
            this.MoviesGroupBox.Controls.Add(this.MovieTimeLabel);
            this.MoviesGroupBox.Controls.Add(this.MovieTimeTextBox);
            this.MoviesGroupBox.Controls.Add(this.NameLabel);
            this.MoviesGroupBox.Controls.Add(this.NameTextBox);
            this.MoviesGroupBox.Controls.Add(this.FindMovieButton_Click);
            this.MoviesGroupBox.Controls.Add(this.GenreTextBox);
            this.MoviesGroupBox.Controls.Add(this.ReleaseYearTextBox);
            this.MoviesGroupBox.Controls.Add(this.RatingTextBox);
            this.MoviesGroupBox.Controls.Add(this.GenreLabel);
            this.MoviesGroupBox.Controls.Add(this.ReleaseYearLabel);
            this.MoviesGroupBox.Controls.Add(this.RatingLabel);
            this.MoviesGroupBox.Controls.Add(this.MoviesListBox);
            this.MoviesGroupBox.Location = new System.Drawing.Point(381, 8);
            this.MoviesGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MoviesGroupBox.Name = "MoviesGroupBox";
            this.MoviesGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MoviesGroupBox.Size = new System.Drawing.Size(372, 413);
            this.MoviesGroupBox.TabIndex = 1;
            this.MoviesGroupBox.TabStop = false;
            this.MoviesGroupBox.Text = "Movies";
            // 
            // MovieTimeLabel
            // 
            this.MovieTimeLabel.AutoSize = true;
            this.MovieTimeLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MovieTimeLabel.Location = new System.Drawing.Point(189, 218);
            this.MovieTimeLabel.Name = "MovieTimeLabel";
            this.MovieTimeLabel.Size = new System.Drawing.Size(72, 15);
            this.MovieTimeLabel.TabIndex = 11;
            this.MovieTimeLabel.Text = "Movie Time:";
            // 
            // MovieTimeTextBox
            // 
            this.MovieTimeTextBox.Location = new System.Drawing.Point(189, 235);
            this.MovieTimeTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MovieTimeTextBox.Name = "MovieTimeTextBox";
            this.MovieTimeTextBox.Size = new System.Drawing.Size(134, 23);
            this.MovieTimeTextBox.TabIndex = 10;
            this.MovieTimeTextBox.TextChanged += new System.EventHandler(this.MovieTimeTextBox_TextChanged);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NameLabel.Location = new System.Drawing.Point(189, 32);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(42, 15);
            this.NameLabel.TabIndex = 9;
            this.NameLabel.Text = "Name:";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(189, 50);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(134, 23);
            this.NameTextBox.TabIndex = 8;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // FindMovieButton_Click
            // 
            this.FindMovieButton_Click.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FindMovieButton_Click.Location = new System.Drawing.Point(189, 366);
            this.FindMovieButton_Click.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FindMovieButton_Click.Name = "FindMovieButton_Click";
            this.FindMovieButton_Click.Size = new System.Drawing.Size(133, 29);
            this.FindMovieButton_Click.TabIndex = 7;
            this.FindMovieButton_Click.Text = "Find";
            this.FindMovieButton_Click.UseVisualStyleBackColor = true;
            this.FindMovieButton_Click.Click += new System.EventHandler(this.FindMovieButton_Click_Click);
            // 
            // GenreTextBox
            // 
            this.GenreTextBox.Location = new System.Drawing.Point(189, 141);
            this.GenreTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GenreTextBox.Name = "GenreTextBox";
            this.GenreTextBox.Size = new System.Drawing.Size(134, 23);
            this.GenreTextBox.TabIndex = 6;
            this.GenreTextBox.TextChanged += new System.EventHandler(this.GenreTextBox_TextChanged);
            // 
            // ReleaseYearTextBox
            // 
            this.ReleaseYearTextBox.Location = new System.Drawing.Point(189, 95);
            this.ReleaseYearTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ReleaseYearTextBox.Name = "ReleaseYearTextBox";
            this.ReleaseYearTextBox.Size = new System.Drawing.Size(134, 23);
            this.ReleaseYearTextBox.TabIndex = 5;
            this.ReleaseYearTextBox.TextChanged += new System.EventHandler(this.ReleaseYearTextBox_TextChanged);
            // 
            // RatingTextBox
            // 
            this.RatingTextBox.Location = new System.Drawing.Point(189, 187);
            this.RatingTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RatingTextBox.Name = "RatingTextBox";
            this.RatingTextBox.Size = new System.Drawing.Size(134, 23);
            this.RatingTextBox.TabIndex = 4;
            this.RatingTextBox.TextChanged += new System.EventHandler(this.RatingTextBox_TextChanged);
            // 
            // GenreLabel
            // 
            this.GenreLabel.AutoSize = true;
            this.GenreLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GenreLabel.Location = new System.Drawing.Point(189, 124);
            this.GenreLabel.Name = "GenreLabel";
            this.GenreLabel.Size = new System.Drawing.Size(41, 15);
            this.GenreLabel.TabIndex = 3;
            this.GenreLabel.Text = "Genre:";
            // 
            // ReleaseYearLabel
            // 
            this.ReleaseYearLabel.AutoSize = true;
            this.ReleaseYearLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ReleaseYearLabel.Location = new System.Drawing.Point(189, 78);
            this.ReleaseYearLabel.Name = "ReleaseYearLabel";
            this.ReleaseYearLabel.Size = new System.Drawing.Size(74, 15);
            this.ReleaseYearLabel.TabIndex = 2;
            this.ReleaseYearLabel.Text = "Release year:";
            // 
            // RatingLabel
            // 
            this.RatingLabel.AutoSize = true;
            this.RatingLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RatingLabel.Location = new System.Drawing.Point(189, 170);
            this.RatingLabel.Name = "RatingLabel";
            this.RatingLabel.Size = new System.Drawing.Size(44, 15);
            this.RatingLabel.TabIndex = 1;
            this.RatingLabel.Text = "Rating:";
            // 
            // MoviesListBox
            // 
            this.MoviesListBox.FormattingEnabled = true;
            this.MoviesListBox.ItemHeight = 15;
            this.MoviesListBox.Location = new System.Drawing.Point(5, 32);
            this.MoviesListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MoviesListBox.Name = "MoviesListBox";
            this.MoviesListBox.Size = new System.Drawing.Size(173, 364);
            this.MoviesListBox.TabIndex = 0;
            this.MoviesListBox.SelectedIndexChanged += new System.EventHandler(this.MoviesListBox_SelectedIndexChanged);
            // 
            // RectanglesTabPage
            // 
            this.RectanglesTabPage.Controls.Add(this.rectanglesCollisionControl1);
            this.RectanglesTabPage.Location = new System.Drawing.Point(4, 24);
            this.RectanglesTabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RectanglesTabPage.Name = "RectanglesTabPage";
            this.RectanglesTabPage.Size = new System.Drawing.Size(760, 436);
            this.RectanglesTabPage.TabIndex = 2;
            this.RectanglesTabPage.Text = " Rectangles";
            this.RectanglesTabPage.UseVisualStyleBackColor = true;
            // 
            // rectanglesCollisionControl1
            // 
            this.rectanglesCollisionControl1.AllowDrop = true;
            this.rectanglesCollisionControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rectanglesCollisionControl1.Location = new System.Drawing.Point(0, 0);
            this.rectanglesCollisionControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rectanglesCollisionControl1.Name = "rectanglesCollisionControl1";
            this.rectanglesCollisionControl1.Size = new System.Drawing.Size(760, 436);
            this.rectanglesCollisionControl1.TabIndex = 0;
            // 
            // RectanglesListBox
            // 
            this.RectanglesListBox.FormattingEnabled = true;
            this.RectanglesListBox.ItemHeight = 20;
            this.RectanglesListBox.Location = new System.Drawing.Point(9, 43);
            this.RectanglesListBox.Name = "RectanglesListBox";
            this.RectanglesListBox.Size = new System.Drawing.Size(197, 484);
            this.RectanglesListBox.TabIndex = 0;
            this.RectanglesListBox.SelectedIndexChanged += new System.EventHandler(this.RectanglesListBox_SelectedIndexChanged_1);
            // 
            // LengthTextBox
            // 
            this.LengthTextBox.Location = new System.Drawing.Point(216, 66);
            this.LengthTextBox.Name = "LengthTextBox";
            this.LengthTextBox.Size = new System.Drawing.Size(152, 27);
            this.LengthTextBox.TabIndex = 1;
            this.LengthTextBox.TextChanged += new System.EventHandler(this.LengthTextBox_TextChanged);
            // 
            // WidthTextBox
            // 
            this.WidthTextBox.Location = new System.Drawing.Point(216, 127);
            this.WidthTextBox.Name = "WidthTextBox";
            this.WidthTextBox.Size = new System.Drawing.Size(152, 27);
            this.WidthTextBox.TabIndex = 2;
            this.WidthTextBox.TextChanged += new System.EventHandler(this.WidthTextBox_TextChanged);
            // 
            // ColorTextBox
            // 
            this.ColorTextBox.Location = new System.Drawing.Point(216, 188);
            this.ColorTextBox.Name = "ColorTextBox";
            this.ColorTextBox.Size = new System.Drawing.Size(152, 27);
            this.ColorTextBox.TabIndex = 3;
            this.ColorTextBox.TextChanged += new System.EventHandler(this.ColorTextBox_TextChanged);
            // 
            // LenghtLabel
            // 
            this.LenghtLabel.AutoSize = true;
            this.LenghtLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LenghtLabel.Location = new System.Drawing.Point(216, 43);
            this.LenghtLabel.Name = "LenghtLabel";
            this.LenghtLabel.Size = new System.Drawing.Size(57, 20);
            this.LenghtLabel.TabIndex = 4;
            this.LenghtLabel.Text = "Length:";
            // 
            // WidhtLabel
            // 
            this.WidhtLabel.AutoSize = true;
            this.WidhtLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WidhtLabel.Location = new System.Drawing.Point(216, 104);
            this.WidhtLabel.Name = "WidhtLabel";
            this.WidhtLabel.Size = new System.Drawing.Size(52, 20);
            this.WidhtLabel.TabIndex = 5;
            this.WidhtLabel.Text = "Width:";
            // 
            // ColorLabel
            // 
            this.ColorLabel.AutoSize = true;
            this.ColorLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ColorLabel.Location = new System.Drawing.Point(216, 165);
            this.ColorLabel.Name = "ColorLabel";
            this.ColorLabel.Size = new System.Drawing.Size(48, 20);
            this.ColorLabel.TabIndex = 6;
            this.ColorLabel.Text = "Color:";
            // 
            // FindRectangleButton
            // 
            this.FindRectangleButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FindRectangleButton.Location = new System.Drawing.Point(216, 488);
            this.FindRectangleButton.Name = "FindRectangleButton";
            this.FindRectangleButton.Size = new System.Drawing.Size(152, 39);
            this.FindRectangleButton.TabIndex = 7;
            this.FindRectangleButton.Text = "Find";
            this.FindRectangleButton.UseVisualStyleBackColor = true;
            this.FindRectangleButton.Click += new System.EventHandler(this.FindRectangleButton_Click);
            // 
            // RectangleXTextBox
            // 
            this.RectangleXTextBox.Location = new System.Drawing.Point(216, 249);
            this.RectangleXTextBox.Name = "RectangleXTextBox";
            this.RectangleXTextBox.ReadOnly = true;
            this.RectangleXTextBox.Size = new System.Drawing.Size(152, 27);
            this.RectangleXTextBox.TabIndex = 8;
            // 
            // RectangleXLabel
            // 
            this.RectangleXLabel.AutoSize = true;
            this.RectangleXLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RectangleXLabel.Location = new System.Drawing.Point(216, 226);
            this.RectangleXLabel.Name = "RectangleXLabel";
            this.RectangleXLabel.Size = new System.Drawing.Size(21, 20);
            this.RectangleXLabel.TabIndex = 9;
            this.RectangleXLabel.Text = "X:";
            // 
            // RectangleYTextBox
            // 
            this.RectangleYTextBox.Location = new System.Drawing.Point(216, 313);
            this.RectangleYTextBox.Name = "RectangleYTextBox";
            this.RectangleYTextBox.ReadOnly = true;
            this.RectangleYTextBox.Size = new System.Drawing.Size(152, 27);
            this.RectangleYTextBox.TabIndex = 10;
            // 
            // RectangleYLabel
            // 
            this.RectangleYLabel.AutoSize = true;
            this.RectangleYLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RectangleYLabel.Location = new System.Drawing.Point(217, 290);
            this.RectangleYLabel.Name = "RectangleYLabel";
            this.RectangleYLabel.Size = new System.Drawing.Size(20, 20);
            this.RectangleYLabel.TabIndex = 11;
            this.RectangleYLabel.Text = "Y:";
            // 
            // IdRectangleTextBox
            // 
            this.IdRectangleTextBox.Location = new System.Drawing.Point(217, 376);
            this.IdRectangleTextBox.Name = "IdRectangleTextBox";
            this.IdRectangleTextBox.ReadOnly = true;
            this.IdRectangleTextBox.Size = new System.Drawing.Size(152, 27);
            this.IdRectangleTextBox.TabIndex = 12;
            // 
            // IdRectangleLabel
            // 
            this.IdRectangleLabel.AutoSize = true;
            this.IdRectangleLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IdRectangleLabel.Location = new System.Drawing.Point(217, 353);
            this.IdRectangleLabel.Name = "IdRectangleLabel";
            this.IdRectangleLabel.Size = new System.Drawing.Size(25, 20);
            this.IdRectangleLabel.TabIndex = 13;
            this.IdRectangleLabel.Text = "Id:";
            // 
            // RectanglesGroupBox
            // 
            this.RectanglesGroupBox.Controls.Add(this.IdRectangleLabel);
            this.RectanglesGroupBox.Controls.Add(this.IdRectangleTextBox);
            this.RectanglesGroupBox.Controls.Add(this.RectangleYLabel);
            this.RectanglesGroupBox.Controls.Add(this.RectangleYTextBox);
            this.RectanglesGroupBox.Controls.Add(this.RectangleXLabel);
            this.RectanglesGroupBox.Controls.Add(this.RectangleXTextBox);
            this.RectanglesGroupBox.Controls.Add(this.FindRectangleButton);
            this.RectanglesGroupBox.Controls.Add(this.ColorLabel);
            this.RectanglesGroupBox.Controls.Add(this.WidhtLabel);
            this.RectanglesGroupBox.Controls.Add(this.LenghtLabel);
            this.RectanglesGroupBox.Controls.Add(this.ColorTextBox);
            this.RectanglesGroupBox.Controls.Add(this.WidthTextBox);
            this.RectanglesGroupBox.Controls.Add(this.LengthTextBox);
            this.RectanglesGroupBox.Controls.Add(this.RectanglesListBox);
            this.RectanglesGroupBox.Location = new System.Drawing.Point(5, 11);
            this.RectanglesGroupBox.Name = "RectanglesGroupBox";
            this.RectanglesGroupBox.Size = new System.Drawing.Size(424, 551);
            this.RectanglesGroupBox.TabIndex = 0;
            this.RectanglesGroupBox.TabStop = false;
            this.RectanglesGroupBox.Text = "Rectangles";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 464);
            this.Controls.Add(this.TabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(784, 503);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Programming";
            this.EnumsTabPage.ResumeLayout(false);
            this.TabControl.ResumeLayout(false);
            this.ClassestabPage.ResumeLayout(false);
            this.MoviesGroupBox.ResumeLayout(false);
            this.MoviesGroupBox.PerformLayout();
            this.RectanglesTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage EnumsTabPage;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage ClassestabPage;
        private System.Windows.Forms.GroupBox MoviesGroupBox;
        private System.Windows.Forms.ListBox MoviesListBox;
        private System.Windows.Forms.TextBox RatingTextBox;
        private System.Windows.Forms.Label GenreLabel;
        private System.Windows.Forms.Label ReleaseYearLabel;
        private System.Windows.Forms.Label RatingLabel;
        private System.Windows.Forms.Button FindMovieButton_Click;
        private System.Windows.Forms.TextBox GenreTextBox;
        private System.Windows.Forms.TextBox ReleaseYearTextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label MovieTimeLabel;
        private System.Windows.Forms.TextBox MovieTimeTextBox;
        private System.Windows.Forms.TabPage RectanglesTabPage;
        private Panels.RectanglesCollisionControl rectanglesCollisionControl1;
        private Panels.EnumerationsControl enumerationsControl1;
        private Panels.WeekdayParsingControl weekdayParsingControl1;
        private Panels.SeasonsHandleControl seasonsHandleControl1;
        private Panels.RectangleControl rectangleControl1;
    }
}