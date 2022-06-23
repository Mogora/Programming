
namespace IndividuallTask.View
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
            this.BuildingListBox = new System.Windows.Forms.ListBox();
            this.BuildingGroupBox = new System.Windows.Forms.GroupBox();
            this.CategoryBuildingComboBox = new System.Windows.Forms.ComboBox();
            this.RatingBuildingTextBox = new System.Windows.Forms.TextBox();
            this.AddressBuildingTextBox = new System.Windows.Forms.TextBox();
            this.TitleBuildingTextBox = new System.Windows.Forms.TextBox();
            this.RatingBuildingLabel = new System.Windows.Forms.Label();
            this.CategoryBuildingLabel = new System.Windows.Forms.Label();
            this.AddressBuildingLabel = new System.Windows.Forms.Label();
            this.TitleBuildingLabel = new System.Windows.Forms.Label();
            this.RemoveBuildingsButton = new System.Windows.Forms.Button();
            this.AddBuildingsButton = new System.Windows.Forms.Button();
            this.BuildingGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // BuildingListBox
            // 
            this.BuildingListBox.FormattingEnabled = true;
            this.BuildingListBox.ItemHeight = 18;
            this.BuildingListBox.Location = new System.Drawing.Point(6, 12);
            this.BuildingListBox.Name = "BuildingListBox";
            this.BuildingListBox.Size = new System.Drawing.Size(374, 634);
            this.BuildingListBox.TabIndex = 0;
            // 
            // BuildingGroupBox
            // 
            this.BuildingGroupBox.Controls.Add(this.CategoryBuildingComboBox);
            this.BuildingGroupBox.Controls.Add(this.RatingBuildingTextBox);
            this.BuildingGroupBox.Controls.Add(this.AddressBuildingTextBox);
            this.BuildingGroupBox.Controls.Add(this.TitleBuildingTextBox);
            this.BuildingGroupBox.Controls.Add(this.RatingBuildingLabel);
            this.BuildingGroupBox.Controls.Add(this.CategoryBuildingLabel);
            this.BuildingGroupBox.Controls.Add(this.AddressBuildingLabel);
            this.BuildingGroupBox.Controls.Add(this.TitleBuildingLabel);
            this.BuildingGroupBox.Location = new System.Drawing.Point(393, 12);
            this.BuildingGroupBox.Name = "BuildingGroupBox";
            this.BuildingGroupBox.Size = new System.Drawing.Size(590, 299);
            this.BuildingGroupBox.TabIndex = 1;
            this.BuildingGroupBox.TabStop = false;
            this.BuildingGroupBox.Text = "Selected Building:";
            // 
            // CategoryBuildingComboBox
            // 
            this.CategoryBuildingComboBox.FormattingEnabled = true;
            this.CategoryBuildingComboBox.Location = new System.Drawing.Point(138, 171);
            this.CategoryBuildingComboBox.Name = "CategoryBuildingComboBox";
            this.CategoryBuildingComboBox.Size = new System.Drawing.Size(138, 26);
            this.CategoryBuildingComboBox.TabIndex = 7;
            this.CategoryBuildingComboBox.SelectedIndexChanged += new System.EventHandler(this.CategoryBuildingComboBox_SelectedIndexChanged);
            // 
            // RatingBuildingTextBox
            // 
            this.RatingBuildingTextBox.Location = new System.Drawing.Point(138, 131);
            this.RatingBuildingTextBox.Name = "RatingBuildingTextBox";
            this.RatingBuildingTextBox.Size = new System.Drawing.Size(336, 24);
            this.RatingBuildingTextBox.TabIndex = 6;
            // 
            // AddressBuildingTextBox
            // 
            this.AddressBuildingTextBox.Location = new System.Drawing.Point(138, 90);
            this.AddressBuildingTextBox.Name = "AddressBuildingTextBox";
            this.AddressBuildingTextBox.Size = new System.Drawing.Size(338, 24);
            this.AddressBuildingTextBox.TabIndex = 5;
            // 
            // TitleBuildingTextBox
            // 
            this.TitleBuildingTextBox.Location = new System.Drawing.Point(138, 53);
            this.TitleBuildingTextBox.Name = "TitleBuildingTextBox";
            this.TitleBuildingTextBox.Size = new System.Drawing.Size(338, 24);
            this.TitleBuildingTextBox.TabIndex = 4;
            // 
            // RatingBuildingLabel
            // 
            this.RatingBuildingLabel.AutoSize = true;
            this.RatingBuildingLabel.Location = new System.Drawing.Point(60, 134);
            this.RatingBuildingLabel.Name = "RatingBuildingLabel";
            this.RatingBuildingLabel.Size = new System.Drawing.Size(54, 18);
            this.RatingBuildingLabel.TabIndex = 3;
            this.RatingBuildingLabel.Text = "Rating:";
            // 
            // CategoryBuildingLabel
            // 
            this.CategoryBuildingLabel.AutoSize = true;
            this.CategoryBuildingLabel.Location = new System.Drawing.Point(60, 171);
            this.CategoryBuildingLabel.Name = "CategoryBuildingLabel";
            this.CategoryBuildingLabel.Size = new System.Drawing.Size(72, 18);
            this.CategoryBuildingLabel.TabIndex = 2;
            this.CategoryBuildingLabel.Text = "Category:";
            // 
            // AddressBuildingLabel
            // 
            this.AddressBuildingLabel.AutoSize = true;
            this.AddressBuildingLabel.Location = new System.Drawing.Point(60, 90);
            this.AddressBuildingLabel.Name = "AddressBuildingLabel";
            this.AddressBuildingLabel.Size = new System.Drawing.Size(66, 18);
            this.AddressBuildingLabel.TabIndex = 1;
            this.AddressBuildingLabel.Text = "Address:";
            // 
            // TitleBuildingLabel
            // 
            this.TitleBuildingLabel.AutoSize = true;
            this.TitleBuildingLabel.Location = new System.Drawing.Point(60, 53);
            this.TitleBuildingLabel.Name = "TitleBuildingLabel";
            this.TitleBuildingLabel.Size = new System.Drawing.Size(39, 18);
            this.TitleBuildingLabel.TabIndex = 0;
            this.TitleBuildingLabel.Text = "Title:";
            // 
            // RemoveBuildingsButton
            // 
            this.RemoveBuildingsButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RemoveBuildingsButton.BackgroundImage")));
            this.RemoveBuildingsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RemoveBuildingsButton.FlatAppearance.BorderSize = 0;
            this.RemoveBuildingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveBuildingsButton.Location = new System.Drawing.Point(710, 317);
            this.RemoveBuildingsButton.Name = "RemoveBuildingsButton";
            this.RemoveBuildingsButton.Size = new System.Drawing.Size(102, 59);
            this.RemoveBuildingsButton.TabIndex = 3;
            this.RemoveBuildingsButton.UseVisualStyleBackColor = true;
            // 
            // AddBuildingsButton
            // 
            this.AddBuildingsButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddBuildingsButton.BackgroundImage")));
            this.AddBuildingsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AddBuildingsButton.FlatAppearance.BorderSize = 0;
            this.AddBuildingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddBuildingsButton.Location = new System.Drawing.Point(541, 317);
            this.AddBuildingsButton.Name = "AddBuildingsButton";
            this.AddBuildingsButton.Size = new System.Drawing.Size(102, 59);
            this.AddBuildingsButton.TabIndex = 2;
            this.AddBuildingsButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(988, 696);
            this.Controls.Add(this.RemoveBuildingsButton);
            this.Controls.Add(this.AddBuildingsButton);
            this.Controls.Add(this.BuildingGroupBox);
            this.Controls.Add(this.BuildingListBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "MainForm";
            this.Text = "ListOfBuildings";
            this.BuildingGroupBox.ResumeLayout(false);
            this.BuildingGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox BuildingListBox;
        private System.Windows.Forms.GroupBox BuildingGroupBox;
        private System.Windows.Forms.ComboBox CategoryBuildingComboBox;
        private System.Windows.Forms.TextBox RatingBuildingTextBox;
        private System.Windows.Forms.TextBox AddressBuildingTextBox;
        private System.Windows.Forms.TextBox TitleBuildingTextBox;
        private System.Windows.Forms.Label RatingBuildingLabel;
        private System.Windows.Forms.Label CategoryBuildingLabel;
        private System.Windows.Forms.Label AddressBuildingLabel;
        private System.Windows.Forms.Label TitleBuildingLabel;
        private System.Windows.Forms.Button AddBuildingsButton;
        private System.Windows.Forms.Button RemoveBuildingsButton;
    }
}

