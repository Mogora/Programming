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
            this.SeasonHandleGroupBox = new System.Windows.Forms.GroupBox();
            this.GoButton = new System.Windows.Forms.Button();
            this.SeasonsComboBox = new System.Windows.Forms.ComboBox();
            this.SeasonLabel = new System.Windows.Forms.Label();
            this.WeekdayParsingGroupBox = new System.Windows.Forms.GroupBox();
            this.WeekdayParseButton = new System.Windows.Forms.Button();
            this.OutputWeekdayLabel = new System.Windows.Forms.Label();
            this.WeekdayTextBox = new System.Windows.Forms.TextBox();
            this.ParsingLabel = new System.Windows.Forms.Label();
            this.EnumerationGroupBox = new System.Windows.Forms.GroupBox();
            this.IntValueTextBox = new System.Windows.Forms.TextBox();
            this.IntValueLabel = new System.Windows.Forms.Label();
            this.ValuesListBox = new System.Windows.Forms.ListBox();
            this.EnumsListBox = new System.Windows.Forms.ListBox();
            this.ChooseValueLabel = new System.Windows.Forms.Label();
            this.ChooseEnumerationLabel = new System.Windows.Forms.Label();
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
            this.RectanglesGroupBox = new System.Windows.Forms.GroupBox();
            this.FindRectangleButton = new System.Windows.Forms.Button();
            this.ColorLabel = new System.Windows.Forms.Label();
            this.WidhtLabel = new System.Windows.Forms.Label();
            this.LenghtLabel = new System.Windows.Forms.Label();
            this.ColorTextBox = new System.Windows.Forms.TextBox();
            this.WidthTextBox = new System.Windows.Forms.TextBox();
            this.LengthTextBox = new System.Windows.Forms.TextBox();
            this.RectanglesListBox = new System.Windows.Forms.ListBox();
            this.EnumsTabPage.SuspendLayout();
            this.SeasonHandleGroupBox.SuspendLayout();
            this.WeekdayParsingGroupBox.SuspendLayout();
            this.EnumerationGroupBox.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.ClassestabPage.SuspendLayout();
            this.MoviesGroupBox.SuspendLayout();
            this.RectanglesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // EnumsTabPage
            // 
            this.EnumsTabPage.Controls.Add(this.SeasonHandleGroupBox);
            this.EnumsTabPage.Controls.Add(this.WeekdayParsingGroupBox);
            this.EnumsTabPage.Controls.Add(this.EnumerationGroupBox);
            this.EnumsTabPage.Location = new System.Drawing.Point(4, 29);
            this.EnumsTabPage.Name = "EnumsTabPage";
            this.EnumsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.EnumsTabPage.Size = new System.Drawing.Size(868, 578);
            this.EnumsTabPage.TabIndex = 0;
            this.EnumsTabPage.Text = "Enums";
            this.EnumsTabPage.UseVisualStyleBackColor = true;
            // 
            // SeasonHandleGroupBox
            // 
            this.SeasonHandleGroupBox.Controls.Add(this.GoButton);
            this.SeasonHandleGroupBox.Controls.Add(this.SeasonsComboBox);
            this.SeasonHandleGroupBox.Controls.Add(this.SeasonLabel);
            this.SeasonHandleGroupBox.Location = new System.Drawing.Point(437, 388);
            this.SeasonHandleGroupBox.Name = "SeasonHandleGroupBox";
            this.SeasonHandleGroupBox.Size = new System.Drawing.Size(427, 174);
            this.SeasonHandleGroupBox.TabIndex = 2;
            this.SeasonHandleGroupBox.TabStop = false;
            this.SeasonHandleGroupBox.Text = "Season Handle";
            // 
            // GoButton
            // 
            this.GoButton.Location = new System.Drawing.Point(314, 59);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(100, 35);
            this.GoButton.TabIndex = 9;
            this.GoButton.Text = "Go!";
            this.GoButton.UseVisualStyleBackColor = true;
            this.GoButton.Click += new System.EventHandler(this.GoButton_Click);
            // 
            // SeasonsComboBox
            // 
            this.SeasonsComboBox.FormattingEnabled = true;
            this.SeasonsComboBox.Location = new System.Drawing.Point(9, 63);
            this.SeasonsComboBox.Name = "SeasonsComboBox";
            this.SeasonsComboBox.Size = new System.Drawing.Size(299, 28);
            this.SeasonsComboBox.TabIndex = 3;
            // 
            // SeasonLabel
            // 
            this.SeasonLabel.AutoSize = true;
            this.SeasonLabel.Location = new System.Drawing.Point(5, 38);
            this.SeasonLabel.Name = "SeasonLabel";
            this.SeasonLabel.Size = new System.Drawing.Size(110, 20);
            this.SeasonLabel.TabIndex = 2;
            this.SeasonLabel.Text = "Choose season:";
            // 
            // WeekdayParsingGroupBox
            // 
            this.WeekdayParsingGroupBox.Controls.Add(this.WeekdayParseButton);
            this.WeekdayParsingGroupBox.Controls.Add(this.OutputWeekdayLabel);
            this.WeekdayParsingGroupBox.Controls.Add(this.WeekdayTextBox);
            this.WeekdayParsingGroupBox.Controls.Add(this.ParsingLabel);
            this.WeekdayParsingGroupBox.Location = new System.Drawing.Point(5, 388);
            this.WeekdayParsingGroupBox.Name = "WeekdayParsingGroupBox";
            this.WeekdayParsingGroupBox.Size = new System.Drawing.Size(427, 174);
            this.WeekdayParsingGroupBox.TabIndex = 1;
            this.WeekdayParsingGroupBox.TabStop = false;
            this.WeekdayParsingGroupBox.Text = "Weekday Parsing";
            // 
            // WeekdayParseButton
            // 
            this.WeekdayParseButton.Location = new System.Drawing.Point(314, 59);
            this.WeekdayParseButton.Name = "WeekdayParseButton";
            this.WeekdayParseButton.Size = new System.Drawing.Size(100, 35);
            this.WeekdayParseButton.TabIndex = 8;
            this.WeekdayParseButton.Text = "Parse";
            this.WeekdayParseButton.UseVisualStyleBackColor = true;
            this.WeekdayParseButton.Click += new System.EventHandler(this.WeekdayParseButton_Click);
            // 
            // OutputWeekdayLabel
            // 
            this.OutputWeekdayLabel.AutoSize = true;
            this.OutputWeekdayLabel.Location = new System.Drawing.Point(5, 108);
            this.OutputWeekdayLabel.Name = "OutputWeekdayLabel";
            this.OutputWeekdayLabel.Size = new System.Drawing.Size(0, 20);
            this.OutputWeekdayLabel.TabIndex = 7;
            // 
            // WeekdayTextBox
            // 
            this.WeekdayTextBox.Location = new System.Drawing.Point(9, 63);
            this.WeekdayTextBox.Name = "WeekdayTextBox";
            this.WeekdayTextBox.Size = new System.Drawing.Size(299, 27);
            this.WeekdayTextBox.TabIndex = 6;
            // 
            // ParsingLabel
            // 
            this.ParsingLabel.AutoSize = true;
            this.ParsingLabel.Location = new System.Drawing.Point(5, 38);
            this.ParsingLabel.Name = "ParsingLabel";
            this.ParsingLabel.Size = new System.Drawing.Size(158, 20);
            this.ParsingLabel.TabIndex = 1;
            this.ParsingLabel.Text = "Type value for parsing:";
            // 
            // EnumerationGroupBox
            // 
            this.EnumerationGroupBox.Controls.Add(this.IntValueTextBox);
            this.EnumerationGroupBox.Controls.Add(this.IntValueLabel);
            this.EnumerationGroupBox.Controls.Add(this.ValuesListBox);
            this.EnumerationGroupBox.Controls.Add(this.EnumsListBox);
            this.EnumerationGroupBox.Controls.Add(this.ChooseValueLabel);
            this.EnumerationGroupBox.Controls.Add(this.ChooseEnumerationLabel);
            this.EnumerationGroupBox.Location = new System.Drawing.Point(5, 11);
            this.EnumerationGroupBox.Name = "EnumerationGroupBox";
            this.EnumerationGroupBox.Size = new System.Drawing.Size(853, 369);
            this.EnumerationGroupBox.TabIndex = 0;
            this.EnumerationGroupBox.TabStop = false;
            this.EnumerationGroupBox.Text = "Enumerations";
            // 
            // IntValueTextBox
            // 
            this.IntValueTextBox.Location = new System.Drawing.Point(335, 63);
            this.IntValueTextBox.Name = "IntValueTextBox";
            this.IntValueTextBox.ReadOnly = true;
            this.IntValueTextBox.Size = new System.Drawing.Size(91, 27);
            this.IntValueTextBox.TabIndex = 5;
            // 
            // IntValueLabel
            // 
            this.IntValueLabel.AutoSize = true;
            this.IntValueLabel.Location = new System.Drawing.Point(332, 38);
            this.IntValueLabel.Name = "IntValueLabel";
            this.IntValueLabel.Size = new System.Drawing.Size(68, 20);
            this.IntValueLabel.TabIndex = 4;
            this.IntValueLabel.Text = "Int value:";
            // 
            // ValuesListBox
            // 
            this.ValuesListBox.FormattingEnabled = true;
            this.ValuesListBox.ItemHeight = 20;
            this.ValuesListBox.Location = new System.Drawing.Point(171, 63);
            this.ValuesListBox.Name = "ValuesListBox";
            this.ValuesListBox.Size = new System.Drawing.Size(137, 284);
            this.ValuesListBox.TabIndex = 3;
            this.ValuesListBox.Click += new System.EventHandler(this.ValuesListBox_SelectedIndexChanged);
            // 
            // EnumsListBox
            // 
            this.EnumsListBox.FormattingEnabled = true;
            this.EnumsListBox.ItemHeight = 20;
            this.EnumsListBox.Location = new System.Drawing.Point(9, 63);
            this.EnumsListBox.Name = "EnumsListBox";
            this.EnumsListBox.Size = new System.Drawing.Size(137, 284);
            this.EnumsListBox.TabIndex = 2;
            this.EnumsListBox.Click += new System.EventHandler(this.EnumsListBox_SelectedIndexChanged);
            // 
            // ChooseValueLabel
            // 
            this.ChooseValueLabel.AutoSize = true;
            this.ChooseValueLabel.Location = new System.Drawing.Point(168, 38);
            this.ChooseValueLabel.Name = "ChooseValueLabel";
            this.ChooseValueLabel.Size = new System.Drawing.Size(100, 20);
            this.ChooseValueLabel.TabIndex = 1;
            this.ChooseValueLabel.Text = "Choose value:";
            // 
            // ChooseEnumerationLabel
            // 
            this.ChooseEnumerationLabel.AutoSize = true;
            this.ChooseEnumerationLabel.Location = new System.Drawing.Point(5, 38);
            this.ChooseEnumerationLabel.Name = "ChooseEnumerationLabel";
            this.ChooseEnumerationLabel.Size = new System.Drawing.Size(149, 20);
            this.ChooseEnumerationLabel.TabIndex = 0;
            this.ChooseEnumerationLabel.Text = "Choose enumeration:";
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.EnumsTabPage);
            this.TabControl.Controls.Add(this.ClassestabPage);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(876, 611);
            this.TabControl.TabIndex = 0;
            // 
            // ClassestabPage
            // 
            this.ClassestabPage.Controls.Add(this.MoviesGroupBox);
            this.ClassestabPage.Controls.Add(this.RectanglesGroupBox);
            this.ClassestabPage.Location = new System.Drawing.Point(4, 29);
            this.ClassestabPage.Name = "ClassestabPage";
            this.ClassestabPage.Size = new System.Drawing.Size(868, 578);
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
            this.MovieTimeLabel.Location = new System.Drawing.Point(216, 290);
            this.MovieTimeLabel.Name = "MovieTimeLabel";
            this.MovieTimeLabel.Size = new System.Drawing.Size(90, 20);
            this.MovieTimeLabel.TabIndex = 11;
            this.MovieTimeLabel.Text = "Movie Time:";
            // 
            // MovieTimeTextBox
            // 
            this.MovieTimeTextBox.Location = new System.Drawing.Point(216, 313);
            this.MovieTimeTextBox.Name = "MovieTimeTextBox";
            this.MovieTimeTextBox.Size = new System.Drawing.Size(152, 27);
            this.MovieTimeTextBox.TabIndex = 10;
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
            this.NameTextBox.Location = new System.Drawing.Point(216, 66);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(152, 27);
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
            this.GenreTextBox.Size = new System.Drawing.Size(152, 27);
            this.GenreTextBox.TabIndex = 6;
            this.GenreTextBox.TextChanged += new System.EventHandler(this.GenreTextBox_TextChanged);
            // 
            // ReleaseYearTextBox
            // 
            this.ReleaseYearTextBox.Location = new System.Drawing.Point(216, 127);
            this.ReleaseYearTextBox.Name = "ReleaseYearTextBox";
            this.ReleaseYearTextBox.Size = new System.Drawing.Size(152, 27);
            this.ReleaseYearTextBox.TabIndex = 5;
            this.ReleaseYearTextBox.TextChanged += new System.EventHandler(this.ReleaseYearTextBox_TextChanged);
            // 
            // RatingTextBox
            // 
            this.RatingTextBox.Location = new System.Drawing.Point(216, 249);
            this.RatingTextBox.Name = "RatingTextBox";
            this.RatingTextBox.Size = new System.Drawing.Size(152, 27);
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
            this.RatingLabel.Location = new System.Drawing.Point(216, 226);
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
            // RectanglesGroupBox
            // 
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
            // ColorTextBox
            // 
            this.ColorTextBox.Location = new System.Drawing.Point(216, 188);
            this.ColorTextBox.Name = "ColorTextBox";
            this.ColorTextBox.Size = new System.Drawing.Size(152, 27);
            this.ColorTextBox.TabIndex = 3;
            this.ColorTextBox.TextChanged += new System.EventHandler(this.ColorTextBox_TextChanged);
            // 
            // WidthTextBox
            // 
            this.WidthTextBox.Location = new System.Drawing.Point(216, 127);
            this.WidthTextBox.Name = "WidthTextBox";
            this.WidthTextBox.Size = new System.Drawing.Size(152, 27);
            this.WidthTextBox.TabIndex = 2;
            this.WidthTextBox.TextChanged += new System.EventHandler(this.WidthTextBox_TextChanged);
            // 
            // LengthTextBox
            // 
            this.LengthTextBox.Location = new System.Drawing.Point(216, 66);
            this.LengthTextBox.Name = "LengthTextBox";
            this.LengthTextBox.Size = new System.Drawing.Size(152, 27);
            this.LengthTextBox.TabIndex = 1;
            this.LengthTextBox.TextChanged += new System.EventHandler(this.LengthTextBox_TextChanged);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 611);
            this.Controls.Add(this.TabControl);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Programming";
            this.EnumsTabPage.ResumeLayout(false);
            this.SeasonHandleGroupBox.ResumeLayout(false);
            this.SeasonHandleGroupBox.PerformLayout();
            this.WeekdayParsingGroupBox.ResumeLayout(false);
            this.WeekdayParsingGroupBox.PerformLayout();
            this.EnumerationGroupBox.ResumeLayout(false);
            this.EnumerationGroupBox.PerformLayout();
            this.TabControl.ResumeLayout(false);
            this.ClassestabPage.ResumeLayout(false);
            this.MoviesGroupBox.ResumeLayout(false);
            this.MoviesGroupBox.PerformLayout();
            this.RectanglesGroupBox.ResumeLayout(false);
            this.RectanglesGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage EnumsTabPage;
        private System.Windows.Forms.GroupBox EnumerationGroupBox;
        private System.Windows.Forms.TextBox IntValueTextBox;
        private System.Windows.Forms.Label IntValueLabel;
        private System.Windows.Forms.ListBox ValuesListBox;
        private System.Windows.Forms.ListBox EnumsListBox;
        private System.Windows.Forms.Label ChooseValueLabel;
        private System.Windows.Forms.Label ChooseEnumerationLabel;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.GroupBox SeasonHandleGroupBox;
        private System.Windows.Forms.Button GoButton;
        private System.Windows.Forms.ComboBox SeasonsComboBox;
        private System.Windows.Forms.Label SeasonLabel;
        private System.Windows.Forms.GroupBox WeekdayParsingGroupBox;
        private System.Windows.Forms.Button WeekdayParseButton;
        private System.Windows.Forms.Label OutputWeekdayLabel;
        private System.Windows.Forms.TextBox WeekdayTextBox;
        private System.Windows.Forms.Label ParsingLabel;
        private System.Windows.Forms.TabPage ClassestabPage;
        private System.Windows.Forms.GroupBox RectanglesGroupBox;
        private System.Windows.Forms.ListBox RectanglesListBox;
        private System.Windows.Forms.TextBox LengthTextBox;
        private System.Windows.Forms.Button FindRectangleButton;
        private System.Windows.Forms.Label ColorLabel;
        private System.Windows.Forms.Label WidhtLabel;
        private System.Windows.Forms.Label LenghtLabel;
        private System.Windows.Forms.TextBox ColorTextBox;
        private System.Windows.Forms.TextBox WidthTextBox;
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
    }
}