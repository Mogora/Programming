
namespace IndividuallTask
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.AddBuildingButton = new System.Windows.Forms.Button();
            this.RemoveBuildingButton = new System.Windows.Forms.Button();
            this.BuildingGroupBox = new System.Windows.Forms.GroupBox();
            this.CategoryBuildingComboBox = new System.Windows.Forms.ComboBox();
            this.RatingBuildingTextBox = new System.Windows.Forms.TextBox();
            this.AddressBuildingTextBox = new System.Windows.Forms.TextBox();
            this.TitleBuildingTextBox = new System.Windows.Forms.TextBox();
            this.RatingBuildingLabel = new System.Windows.Forms.Label();
            this.CategoryBuildingLabel = new System.Windows.Forms.Label();
            this.AddressBuildingLabel = new System.Windows.Forms.Label();
            this.TitleBuildingLabel = new System.Windows.Forms.Label();
            this.BuildingListBox = new System.Windows.Forms.ListBox();
            this.BuildingGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // AddBuildingButton
            // 
            this.AddBuildingButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.AddBuildingButton.BackgroundImage = global::IndividuallTask.Properties.Resources.remove_building_grey;
            this.AddBuildingButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AddBuildingButton.FlatAppearance.BorderSize = 0;
            this.AddBuildingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBuildingButton.Location = new System.Drawing.Point(527, 288);
            this.AddBuildingButton.Name = "AddBuildingButton";
            this.AddBuildingButton.Size = new System.Drawing.Size(102, 59);
            this.AddBuildingButton.TabIndex = 0;
            this.AddBuildingButton.UseVisualStyleBackColor = true;
            this.AddBuildingButton.MouseEnter += new System.EventHandler(this.AddBuildingButton_MouseEnter);
            this.AddBuildingButton.MouseLeave += new System.EventHandler(this.AddRectangleButton_MouseLeave);
            // 
            // RemoveBuildingButton
            // 
            this.RemoveBuildingButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.RemoveBuildingButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RemoveBuildingButton.BackgroundImage")));
            this.RemoveBuildingButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RemoveBuildingButton.FlatAppearance.BorderSize = 0;
            this.RemoveBuildingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveBuildingButton.Location = new System.Drawing.Point(692, 288);
            this.RemoveBuildingButton.Name = "RemoveBuildingButton";
            this.RemoveBuildingButton.Size = new System.Drawing.Size(102, 59);
            this.RemoveBuildingButton.TabIndex = 1;
            this.RemoveBuildingButton.UseVisualStyleBackColor = true;
            this.RemoveBuildingButton.MouseEnter += new System.EventHandler(this.RemoveButton_MouseEnter);
            this.RemoveBuildingButton.MouseLeave += new System.EventHandler(this.RemoveBuildingButton_MouseLeave);
            // 
            // BuildingGroupBox
            // 
            this.BuildingGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BuildingGroupBox.Controls.Add(this.CategoryBuildingComboBox);
            this.BuildingGroupBox.Controls.Add(this.RatingBuildingTextBox);
            this.BuildingGroupBox.Controls.Add(this.AddressBuildingTextBox);
            this.BuildingGroupBox.Controls.Add(this.TitleBuildingTextBox);
            this.BuildingGroupBox.Controls.Add(this.RatingBuildingLabel);
            this.BuildingGroupBox.Controls.Add(this.CategoryBuildingLabel);
            this.BuildingGroupBox.Controls.Add(this.AddressBuildingLabel);
            this.BuildingGroupBox.Controls.Add(this.TitleBuildingLabel);
            this.BuildingGroupBox.Location = new System.Drawing.Point(389, 12);
            this.BuildingGroupBox.Name = "BuildingGroupBox";
            this.BuildingGroupBox.Size = new System.Drawing.Size(596, 262);
            this.BuildingGroupBox.TabIndex = 3;
            this.BuildingGroupBox.TabStop = false;
            this.BuildingGroupBox.Text = "Selected Building:";
            // 
            // CategoryBuildingComboBox
            // 
            this.CategoryBuildingComboBox.FormattingEnabled = true;
            this.CategoryBuildingComboBox.Location = new System.Drawing.Point(138, 171);
            this.CategoryBuildingComboBox.Name = "CategoryBuildingComboBox";
            this.CategoryBuildingComboBox.Size = new System.Drawing.Size(138, 24);
            this.CategoryBuildingComboBox.TabIndex = 7;
            // 
            // RatingBuildingTextBox
            // 
            this.RatingBuildingTextBox.Location = new System.Drawing.Point(138, 131);
            this.RatingBuildingTextBox.Name = "RatingBuildingTextBox";
            this.RatingBuildingTextBox.Size = new System.Drawing.Size(336, 22);
            this.RatingBuildingTextBox.TabIndex = 6;
            // 
            // AddressBuildingTextBox
            // 
            this.AddressBuildingTextBox.Location = new System.Drawing.Point(138, 90);
            this.AddressBuildingTextBox.Name = "AddressBuildingTextBox";
            this.AddressBuildingTextBox.Size = new System.Drawing.Size(338, 22);
            this.AddressBuildingTextBox.TabIndex = 5;
            // 
            // TitleBuildingTextBox
            // 
            this.TitleBuildingTextBox.Location = new System.Drawing.Point(138, 53);
            this.TitleBuildingTextBox.Name = "TitleBuildingTextBox";
            this.TitleBuildingTextBox.Size = new System.Drawing.Size(338, 22);
            this.TitleBuildingTextBox.TabIndex = 4;
            // 
            // RatingBuildingLabel
            // 
            this.RatingBuildingLabel.AutoSize = true;
            this.RatingBuildingLabel.Location = new System.Drawing.Point(60, 134);
            this.RatingBuildingLabel.Name = "RatingBuildingLabel";
            this.RatingBuildingLabel.Size = new System.Drawing.Size(53, 17);
            this.RatingBuildingLabel.TabIndex = 3;
            this.RatingBuildingLabel.Text = "Rating:";
            // 
            // CategoryBuildingLabel
            // 
            this.CategoryBuildingLabel.AutoSize = true;
            this.CategoryBuildingLabel.Location = new System.Drawing.Point(60, 171);
            this.CategoryBuildingLabel.Name = "CategoryBuildingLabel";
            this.CategoryBuildingLabel.Size = new System.Drawing.Size(69, 17);
            this.CategoryBuildingLabel.TabIndex = 2;
            this.CategoryBuildingLabel.Text = "Category:";
            // 
            // AddressBuildingLabel
            // 
            this.AddressBuildingLabel.AutoSize = true;
            this.AddressBuildingLabel.Location = new System.Drawing.Point(60, 90);
            this.AddressBuildingLabel.Name = "AddressBuildingLabel";
            this.AddressBuildingLabel.Size = new System.Drawing.Size(64, 17);
            this.AddressBuildingLabel.TabIndex = 1;
            this.AddressBuildingLabel.Text = "Address:";
            // 
            // TitleBuildingLabel
            // 
            this.TitleBuildingLabel.AutoSize = true;
            this.TitleBuildingLabel.Location = new System.Drawing.Point(60, 53);
            this.TitleBuildingLabel.Name = "TitleBuildingLabel";
            this.TitleBuildingLabel.Size = new System.Drawing.Size(39, 17);
            this.TitleBuildingLabel.TabIndex = 0;
            this.TitleBuildingLabel.Text = "Title:";
            // 
            // BuildingListBox
            // 
            this.BuildingListBox.FormattingEnabled = true;
            this.BuildingListBox.ItemHeight = 16;
            this.BuildingListBox.Location = new System.Drawing.Point(5, 11);
            this.BuildingListBox.Name = "BuildingListBox";
            this.BuildingListBox.Size = new System.Drawing.Size(374, 628);
            this.BuildingListBox.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 696);
            this.Controls.Add(this.BuildingGroupBox);
            this.Controls.Add(this.BuildingListBox);
            this.Controls.Add(this.RemoveBuildingButton);
            this.Controls.Add(this.AddBuildingButton);
            this.MinimumSize = new System.Drawing.Size(1006, 743);
            this.Name = "MainForm";
            this.Text = "ListOfBuildings";
            this.BuildingGroupBox.ResumeLayout(false);
            this.BuildingGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddBuildingButton;
        private System.Windows.Forms.Button RemoveBuildingButton;
        private System.Windows.Forms.GroupBox BuildingGroupBox;
        private System.Windows.Forms.ComboBox CategoryBuildingComboBox;
        private System.Windows.Forms.TextBox RatingBuildingTextBox;
        private System.Windows.Forms.TextBox AddressBuildingTextBox;
        private System.Windows.Forms.TextBox TitleBuildingTextBox;
        private System.Windows.Forms.Label RatingBuildingLabel;
        private System.Windows.Forms.Label CategoryBuildingLabel;
        private System.Windows.Forms.Label AddressBuildingLabel;
        private System.Windows.Forms.Label TitleBuildingLabel;
        private System.Windows.Forms.ListBox BuildingListBox;
    }
}

