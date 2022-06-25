
namespace ListOfBuildings.View
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
            this.AddBuildingButton = new System.Windows.Forms.Button();
            this.RemoveBuildingButton = new System.Windows.Forms.Button();
            this.BuildingListBox = new System.Windows.Forms.ListBox();
            this.BuildingGroupBox = new System.Windows.Forms.GroupBox();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.RatingBuildingTextBox = new System.Windows.Forms.TextBox();
            this.TitleBuildingTextBox = new System.Windows.Forms.TextBox();
            this.RatingBuildingLabel = new System.Windows.Forms.Label();
            this.CategoryBuildingLabel = new System.Windows.Forms.Label();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.TitleBuildingLabel = new System.Windows.Forms.Label();
            this.CategoryBuildingComboBox = new System.Windows.Forms.ComboBox();
            this.BuildingGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddBuildingButton
            // 
            this.AddBuildingButton.BackgroundImage = global::ListOfBuildings.Properties.Resources.add_building_grey;
            this.AddBuildingButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AddBuildingButton.FlatAppearance.BorderSize = 0;
            this.AddBuildingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBuildingButton.Location = new System.Drawing.Point(386, 285);
            this.AddBuildingButton.Name = "AddBuildingButton";
            this.AddBuildingButton.Size = new System.Drawing.Size(103, 68);
            this.AddBuildingButton.TabIndex = 0;
            this.AddBuildingButton.UseVisualStyleBackColor = true;
            this.AddBuildingButton.Click += new System.EventHandler(this.AddBuildingButton_Click);
            this.AddBuildingButton.MouseEnter += new System.EventHandler(this.AddBuildingButton_MouseEnter);
            this.AddBuildingButton.MouseLeave += new System.EventHandler(this.AddRectangleButton_MouseLeave);
            // 
            // RemoveBuildingButton
            // 
            this.RemoveBuildingButton.BackgroundImage = global::ListOfBuildings.Properties.Resources.remove_building_grey;
            this.RemoveBuildingButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RemoveBuildingButton.FlatAppearance.BorderSize = 0;
            this.RemoveBuildingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveBuildingButton.Location = new System.Drawing.Point(554, 285);
            this.RemoveBuildingButton.Name = "RemoveBuildingButton";
            this.RemoveBuildingButton.Size = new System.Drawing.Size(98, 68);
            this.RemoveBuildingButton.TabIndex = 1;
            this.RemoveBuildingButton.UseVisualStyleBackColor = true;
            this.RemoveBuildingButton.Click += new System.EventHandler(this.RemoveBuildingButton_Click);
            this.RemoveBuildingButton.MouseEnter += new System.EventHandler(this.RemoveButton_MouseEnter);
            this.RemoveBuildingButton.MouseLeave += new System.EventHandler(this.RemoveButton_MouseLeave);
            // 
            // BuildingListBox
            // 
            this.BuildingListBox.FormattingEnabled = true;
            this.BuildingListBox.ItemHeight = 16;
            this.BuildingListBox.Location = new System.Drawing.Point(5, 11);
            this.BuildingListBox.Name = "BuildingListBox";
            this.BuildingListBox.Size = new System.Drawing.Size(307, 532);
            this.BuildingListBox.TabIndex = 2;
            this.BuildingListBox.SelectedIndexChanged += new System.EventHandler(this.BuildingListBox_SelectedIndexChanged);
            // 
            // BuildingGroupBox
            // 
            this.BuildingGroupBox.Controls.Add(this.AddressTextBox);
            this.BuildingGroupBox.Controls.Add(this.RatingBuildingTextBox);
            this.BuildingGroupBox.Controls.Add(this.TitleBuildingTextBox);
            this.BuildingGroupBox.Controls.Add(this.RatingBuildingLabel);
            this.BuildingGroupBox.Controls.Add(this.CategoryBuildingLabel);
            this.BuildingGroupBox.Controls.Add(this.AddressLabel);
            this.BuildingGroupBox.Controls.Add(this.TitleBuildingLabel);
            this.BuildingGroupBox.Controls.Add(this.CategoryBuildingComboBox);
            this.BuildingGroupBox.Location = new System.Drawing.Point(327, 12);
            this.BuildingGroupBox.Name = "BuildingGroupBox";
            this.BuildingGroupBox.Size = new System.Drawing.Size(539, 251);
            this.BuildingGroupBox.TabIndex = 3;
            this.BuildingGroupBox.TabStop = false;
            this.BuildingGroupBox.Text = "Selected Building:";
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Location = new System.Drawing.Point(147, 70);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(244, 22);
            this.AddressTextBox.TabIndex = 7;
            this.AddressTextBox.TextChanged += new System.EventHandler(this.AddressTextBox_TextChanged);
            // 
            // RatingBuildingTextBox
            // 
            this.RatingBuildingTextBox.Location = new System.Drawing.Point(147, 106);
            this.RatingBuildingTextBox.Name = "RatingBuildingTextBox";
            this.RatingBuildingTextBox.Size = new System.Drawing.Size(244, 22);
            this.RatingBuildingTextBox.TabIndex = 6;
            this.RatingBuildingTextBox.TextChanged += new System.EventHandler(this.RatingBuildingTextBox_TextChanged);
            // 
            // TitleBuildingTextBox
            // 
            this.TitleBuildingTextBox.Location = new System.Drawing.Point(147, 37);
            this.TitleBuildingTextBox.Name = "TitleBuildingTextBox";
            this.TitleBuildingTextBox.Size = new System.Drawing.Size(244, 22);
            this.TitleBuildingTextBox.TabIndex = 5;
            this.TitleBuildingTextBox.TextChanged += new System.EventHandler(this.TitleBuildingTextBox_TextChanged);
            // 
            // RatingBuildingLabel
            // 
            this.RatingBuildingLabel.AutoSize = true;
            this.RatingBuildingLabel.Location = new System.Drawing.Point(56, 106);
            this.RatingBuildingLabel.Name = "RatingBuildingLabel";
            this.RatingBuildingLabel.Size = new System.Drawing.Size(53, 17);
            this.RatingBuildingLabel.TabIndex = 4;
            this.RatingBuildingLabel.Text = "Rating:";
            // 
            // CategoryBuildingLabel
            // 
            this.CategoryBuildingLabel.AutoSize = true;
            this.CategoryBuildingLabel.Location = new System.Drawing.Point(56, 143);
            this.CategoryBuildingLabel.Name = "CategoryBuildingLabel";
            this.CategoryBuildingLabel.Size = new System.Drawing.Size(69, 17);
            this.CategoryBuildingLabel.TabIndex = 3;
            this.CategoryBuildingLabel.Text = "Category:";
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Location = new System.Drawing.Point(56, 70);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(64, 17);
            this.AddressLabel.TabIndex = 2;
            this.AddressLabel.Text = "Address:";
            // 
            // TitleBuildingLabel
            // 
            this.TitleBuildingLabel.AutoSize = true;
            this.TitleBuildingLabel.Location = new System.Drawing.Point(56, 37);
            this.TitleBuildingLabel.Name = "TitleBuildingLabel";
            this.TitleBuildingLabel.Size = new System.Drawing.Size(39, 17);
            this.TitleBuildingLabel.TabIndex = 1;
            this.TitleBuildingLabel.Text = "Title:";
            // 
            // CategoryBuildingComboBox
            // 
            this.CategoryBuildingComboBox.FormattingEnabled = true;
            this.CategoryBuildingComboBox.Location = new System.Drawing.Point(147, 143);
            this.CategoryBuildingComboBox.Name = "CategoryBuildingComboBox";
            this.CategoryBuildingComboBox.Size = new System.Drawing.Size(121, 24);
            this.CategoryBuildingComboBox.TabIndex = 0;
            this.CategoryBuildingComboBox.SelectedIndexChanged += new System.EventHandler(this.CategoryBuildingComboBox_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 619);
            this.Controls.Add(this.BuildingGroupBox);
            this.Controls.Add(this.BuildingListBox);
            this.Controls.Add(this.RemoveBuildingButton);
            this.Controls.Add(this.AddBuildingButton);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List of Buildings";
            this.BuildingGroupBox.ResumeLayout(false);
            this.BuildingGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddBuildingButton;
        private System.Windows.Forms.Button RemoveBuildingButton;
        private System.Windows.Forms.ListBox BuildingListBox;
        private System.Windows.Forms.GroupBox BuildingGroupBox;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.TextBox RatingBuildingTextBox;
        private System.Windows.Forms.TextBox TitleBuildingTextBox;
        private System.Windows.Forms.Label RatingBuildingLabel;
        private System.Windows.Forms.Label CategoryBuildingLabel;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.Label TitleBuildingLabel;
        private System.Windows.Forms.ComboBox CategoryBuildingComboBox;
    }
}

