
namespace IndividualTask
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
            this.BuildingsListBox = new System.Windows.Forms.ListBox();
            this.BuildingsGroupBox = new System.Windows.Forms.GroupBox();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.RatingLabel = new System.Windows.Forms.Label();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.RatingTextBox = new System.Windows.Forms.TextBox();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.AddBuildingButton = new System.Windows.Forms.Button();
            this.RemoveBuildingButton = new System.Windows.Forms.Button();
            this.BuildingsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // BuildingsListBox
            // 
            this.BuildingsListBox.FormattingEnabled = true;
            this.BuildingsListBox.ItemHeight = 18;
            this.BuildingsListBox.Location = new System.Drawing.Point(4, 8);
            this.BuildingsListBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BuildingsListBox.Name = "BuildingsListBox";
            this.BuildingsListBox.Size = new System.Drawing.Size(253, 418);
            this.BuildingsListBox.TabIndex = 0;
            this.BuildingsListBox.SelectedIndexChanged += new System.EventHandler(this.BuildingsListBox_SelectedIndexChanged);
            // 
            // BuildingsGroupBox
            // 
            this.BuildingsGroupBox.Controls.Add(this.CategoryComboBox);
            this.BuildingsGroupBox.Controls.Add(this.RatingLabel);
            this.BuildingsGroupBox.Controls.Add(this.CategoryLabel);
            this.BuildingsGroupBox.Controls.Add(this.AddressLabel);
            this.BuildingsGroupBox.Controls.Add(this.TitleLabel);
            this.BuildingsGroupBox.Controls.Add(this.RatingTextBox);
            this.BuildingsGroupBox.Controls.Add(this.AddressTextBox);
            this.BuildingsGroupBox.Controls.Add(this.TitleTextBox);
            this.BuildingsGroupBox.Location = new System.Drawing.Point(262, 8);
            this.BuildingsGroupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BuildingsGroupBox.Name = "BuildingsGroupBox";
            this.BuildingsGroupBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BuildingsGroupBox.Size = new System.Drawing.Size(393, 179);
            this.BuildingsGroupBox.TabIndex = 1;
            this.BuildingsGroupBox.TabStop = false;
            this.BuildingsGroupBox.Text = "Selected buildings:";
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(110, 83);
            this.CategoryComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(218, 26);
            this.CategoryComboBox.TabIndex = 2;
            // 
            // RatingLabel
            // 
            this.RatingLabel.AutoSize = true;
            this.RatingLabel.Location = new System.Drawing.Point(20, 114);
            this.RatingLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RatingLabel.Name = "RatingLabel";
            this.RatingLabel.Size = new System.Drawing.Size(54, 18);
            this.RatingLabel.TabIndex = 7;
            this.RatingLabel.Text = "Rating:";
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Location = new System.Drawing.Point(20, 83);
            this.CategoryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(72, 18);
            this.CategoryLabel.TabIndex = 6;
            this.CategoryLabel.Text = "Category:";
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Location = new System.Drawing.Point(20, 55);
            this.AddressLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(66, 18);
            this.AddressLabel.TabIndex = 5;
            this.AddressLabel.Text = "Address:";
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(20, 25);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(39, 18);
            this.TitleLabel.TabIndex = 4;
            this.TitleLabel.Text = "Title:";
            // 
            // RatingTextBox
            // 
            this.RatingTextBox.Location = new System.Drawing.Point(110, 114);
            this.RatingTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RatingTextBox.Name = "RatingTextBox";
            this.RatingTextBox.Size = new System.Drawing.Size(218, 24);
            this.RatingTextBox.TabIndex = 3;
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Location = new System.Drawing.Point(110, 55);
            this.AddressTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(218, 24);
            this.AddressTextBox.TabIndex = 1;
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(110, 25);
            this.TitleTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(218, 24);
            this.TitleTextBox.TabIndex = 0;
            // 
            // AddBuildingButton
            // 
            this.AddBuildingButton.Location = new System.Drawing.Point(306, 200);
            this.AddBuildingButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddBuildingButton.Name = "AddBuildingButton";
            this.AddBuildingButton.Size = new System.Drawing.Size(99, 29);
            this.AddBuildingButton.TabIndex = 2;
            this.AddBuildingButton.Text = "Add";
            this.AddBuildingButton.UseVisualStyleBackColor = true;
            this.AddBuildingButton.Click += new System.EventHandler(this.AddBuildingButton_Click);
            // 
            // RemoveBuildingButton
            // 
            this.RemoveBuildingButton.Location = new System.Drawing.Point(465, 200);
            this.RemoveBuildingButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RemoveBuildingButton.Name = "RemoveBuildingButton";
            this.RemoveBuildingButton.Size = new System.Drawing.Size(95, 31);
            this.RemoveBuildingButton.TabIndex = 3;
            this.RemoveBuildingButton.Text = "Remove";
            this.RemoveBuildingButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 619);
            this.Controls.Add(this.RemoveBuildingButton);
            this.Controls.Add(this.AddBuildingButton);
            this.Controls.Add(this.BuildingsGroupBox);
            this.Controls.Add(this.BuildingsListBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "Directory of places";
            this.BuildingsGroupBox.ResumeLayout(false);
            this.BuildingsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox BuildingsListBox;
        private System.Windows.Forms.GroupBox BuildingsGroupBox;
        private System.Windows.Forms.Label RatingLabel;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.TextBox RatingTextBox;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.Button AddBuildingButton;
        private System.Windows.Forms.Button RemoveBuildingButton;
    }
}

