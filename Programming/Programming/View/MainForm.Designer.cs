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
            this.rectangleControl1 = new Programming.View.Panels.RectangleControl();
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
            this.EnumsTabPage.Location = new System.Drawing.Point(4, 29);
            this.EnumsTabPage.Name = "EnumsTabPage";
            this.EnumsTabPage.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.EnumsTabPage.Size = new System.Drawing.Size(870, 586);
            this.EnumsTabPage.TabIndex = 0;
            this.EnumsTabPage.Text = "Enums";
            this.EnumsTabPage.UseVisualStyleBackColor = true;
            // 
            // seasonsHandleControl1
            // 
            this.seasonsHandleControl1.Location = new System.Drawing.Point(437, 388);
            this.seasonsHandleControl1.Name = "seasonsHandleControl1";
            this.seasonsHandleControl1.Size = new System.Drawing.Size(421, 173);
            this.seasonsHandleControl1.TabIndex = 5;
            // 
            // weekdayParsingControl1
            // 
            this.weekdayParsingControl1.Location = new System.Drawing.Point(5, 388);
            this.weekdayParsingControl1.Name = "weekdayParsingControl1";
            this.weekdayParsingControl1.Size = new System.Drawing.Size(427, 173);
            this.weekdayParsingControl1.TabIndex = 4;
            // 
            // enumerationsControl1
            // 
            this.enumerationsControl1.Location = new System.Drawing.Point(5, 11);
            this.enumerationsControl1.Name = "enumerationsControl1";
            this.enumerationsControl1.Size = new System.Drawing.Size(853, 369);
            this.enumerationsControl1.TabIndex = 3;
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.EnumsTabPage);
            this.TabControl.Controls.Add(this.ClassestabPage);
            this.TabControl.Controls.Add(this.RectanglesTabPage);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(878, 619);
            this.TabControl.TabIndex = 0;
            // 
            // ClassestabPage
            // 
            this.ClassestabPage.Controls.Add(this.rectangleControl1);
            this.ClassestabPage.Controls.Add(this.MoviesGroupBox);
            this.ClassestabPage.Location = new System.Drawing.Point(4, 29);
            this.ClassestabPage.Name = "ClassestabPage";
            this.ClassestabPage.Size = new System.Drawing.Size(870, 586);
            this.ClassestabPage.TabIndex = 1;
            this.ClassestabPage.Text = "Classes";
            this.ClassestabPage.UseVisualStyleBackColor = true;
            // 
            // rectangleControl1
            // 
            this.rectangleControl1.Location = new System.Drawing.Point(5, 11);
            this.rectangleControl1.Name = "rectangleControl1";
            this.rectangleControl1.Size = new System.Drawing.Size(424, 551);
            this.rectangleControl1.TabIndex = 0;
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
            this.MoviesGroupBox.Location = new System.Drawing.Point(435, 11);
            this.MoviesGroupBox.Name = "MoviesGroupBox";
            this.MoviesGroupBox.Size = new System.Drawing.Size(425, 551);
            this.MoviesGroupBox.TabIndex = 1;
            this.MoviesGroupBox.TabStop = false;
            this.MoviesGroupBox.Text = "Movies";
            // 
            // MovieTimeLabel
            // 
            this.MovieTimeLabel.AutoSize = true;
            this.MovieTimeLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MovieTimeLabel.Location = new System.Drawing.Point(216, 291);
            this.MovieTimeLabel.Name = "MovieTimeLabel";
            this.MovieTimeLabel.Size = new System.Drawing.Size(90, 20);
            this.MovieTimeLabel.TabIndex = 11;
            this.MovieTimeLabel.Text = "Movie Time:";
            // 
            // MovieTimeTextBox
            // 
            this.MovieTimeTextBox.Location = new System.Drawing.Point(216, 313);
            this.MovieTimeTextBox.Name = "MovieTimeTextBox";
            this.MovieTimeTextBox.Size = new System.Drawing.Size(153, 27);
            this.MovieTimeTextBox.TabIndex = 10;
            this.MovieTimeTextBox.TextChanged += new System.EventHandler(this.MovieTimeTextBox_TextChanged);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NameLabel.Location = new System.Drawing.Point(216, 43);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(52, 20);
            this.NameLabel.TabIndex = 9;
            this.NameLabel.Text = "Name:";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(216, 67);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(153, 27);
            this.NameTextBox.TabIndex = 8;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // FindMovieButton_Click
            // 
            this.FindMovieButton_Click.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FindMovieButton_Click.Location = new System.Drawing.Point(216, 488);
            this.FindMovieButton_Click.Name = "FindMovieButton_Click";
            this.FindMovieButton_Click.Size = new System.Drawing.Size(152, 39);
            this.FindMovieButton_Click.TabIndex = 7;
            this.FindMovieButton_Click.Text = "Find";
            this.FindMovieButton_Click.UseVisualStyleBackColor = true;
            this.FindMovieButton_Click.Click += new System.EventHandler(this.FindMovieButton_Click_Click);
            // 
            // GenreTextBox
            // 
            this.GenreTextBox.Location = new System.Drawing.Point(216, 188);
            this.GenreTextBox.Name = "GenreTextBox";
            this.GenreTextBox.Size = new System.Drawing.Size(153, 27);
            this.GenreTextBox.TabIndex = 6;
            this.GenreTextBox.TextChanged += new System.EventHandler(this.GenreTextBox_TextChanged);
            // 
            // ReleaseYearTextBox
            // 
            this.ReleaseYearTextBox.Location = new System.Drawing.Point(216, 127);
            this.ReleaseYearTextBox.Name = "ReleaseYearTextBox";
            this.ReleaseYearTextBox.Size = new System.Drawing.Size(153, 27);
            this.ReleaseYearTextBox.TabIndex = 5;
            this.ReleaseYearTextBox.TextChanged += new System.EventHandler(this.ReleaseYearTextBox_TextChanged);
            // 
            // RatingTextBox
            // 
            this.RatingTextBox.Location = new System.Drawing.Point(216, 249);
            this.RatingTextBox.Name = "RatingTextBox";
            this.RatingTextBox.Size = new System.Drawing.Size(153, 27);
            this.RatingTextBox.TabIndex = 4;
            this.RatingTextBox.TextChanged += new System.EventHandler(this.RatingTextBox_TextChanged);
            // 
            // GenreLabel
            // 
            this.GenreLabel.AutoSize = true;
            this.GenreLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GenreLabel.Location = new System.Drawing.Point(216, 165);
            this.GenreLabel.Name = "GenreLabel";
            this.GenreLabel.Size = new System.Drawing.Size(51, 20);
            this.GenreLabel.TabIndex = 3;
            this.GenreLabel.Text = "Genre:";
            // 
            // ReleaseYearLabel
            // 
            this.ReleaseYearLabel.AutoSize = true;
            this.ReleaseYearLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ReleaseYearLabel.Location = new System.Drawing.Point(216, 104);
            this.ReleaseYearLabel.Name = "ReleaseYearLabel";
            this.ReleaseYearLabel.Size = new System.Drawing.Size(95, 20);
            this.ReleaseYearLabel.TabIndex = 2;
            this.ReleaseYearLabel.Text = "Release year:";
            // 
            // RatingLabel
            // 
            this.RatingLabel.AutoSize = true;
            this.RatingLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RatingLabel.Location = new System.Drawing.Point(216, 227);
            this.RatingLabel.Name = "RatingLabel";
            this.RatingLabel.Size = new System.Drawing.Size(55, 20);
            this.RatingLabel.TabIndex = 1;
            this.RatingLabel.Text = "Rating:";
            // 
            // MoviesListBox
            // 
            this.MoviesListBox.FormattingEnabled = true;
            this.MoviesListBox.ItemHeight = 20;
            this.MoviesListBox.Location = new System.Drawing.Point(6, 43);
            this.MoviesListBox.Name = "MoviesListBox";
            this.MoviesListBox.Size = new System.Drawing.Size(197, 484);
            this.MoviesListBox.TabIndex = 0;
            this.MoviesListBox.SelectedIndexChanged += new System.EventHandler(this.MoviesListBox_SelectedIndexChanged);
            // 
            // RectanglesTabPage
            // 
            this.RectanglesTabPage.Controls.Add(this.rectanglesCollisionControl1);
            this.RectanglesTabPage.Location = new System.Drawing.Point(4, 29);
            this.RectanglesTabPage.Name = "RectanglesTabPage";
            this.RectanglesTabPage.Size = new System.Drawing.Size(870, 586);
            this.RectanglesTabPage.TabIndex = 2;
            this.RectanglesTabPage.Text = " Rectangles";
            this.RectanglesTabPage.UseVisualStyleBackColor = true;
            // 
            // rectanglesCollisionControl1
            // 
            this.rectanglesCollisionControl1.AllowDrop = true;
            this.rectanglesCollisionControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rectanglesCollisionControl1.Location = new System.Drawing.Point(0, 0);
            this.rectanglesCollisionControl1.Name = "rectanglesCollisionControl1";
            this.rectanglesCollisionControl1.Size = new System.Drawing.Size(870, 586);
            this.rectanglesCollisionControl1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 619);
            this.Controls.Add(this.TabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MinimumSize = new System.Drawing.Size(893, 655);
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