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
            this.RectanglesTabPage = new System.Windows.Forms.TabPage();
            this.rectanglesCollisionControl1 = new Programming.View.Panels.RectanglesCollisionControl();
            this.moviesControl1 = new Programming.View.Panels.MoviesControl();
            this.EnumsTabPage.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.ClassestabPage.SuspendLayout();
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
            this.EnumsTabPage.Padding = new System.Windows.Forms.Padding(3);
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
            this.ClassestabPage.Controls.Add(this.moviesControl1);
            this.ClassestabPage.Controls.Add(this.rectangleControl1);
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
            // moviesControl1
            // 
            this.moviesControl1.Location = new System.Drawing.Point(435, 11);
            this.moviesControl1.Name = "moviesControl1";
            this.moviesControl1.Size = new System.Drawing.Size(425, 551);
            this.moviesControl1.TabIndex = 1;
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
            this.RectanglesTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage EnumsTabPage;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage ClassestabPage;
        private System.Windows.Forms.TabPage RectanglesTabPage;
        private Panels.RectanglesCollisionControl rectanglesCollisionControl1;
        private Panels.EnumerationsControl enumerationsControl1;
        private Panels.WeekdayParsingControl weekdayParsingControl1;
        private Panels.SeasonsHandleControl seasonsHandleControl1;
        private Panels.RectangleControl rectangleControl1;
        private Panels.MoviesControl moviesControl1;
    }
}