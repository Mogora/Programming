
namespace ObjectOrientedPractics.View.Tabs
{
    partial class ItemsTab
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
            this.ItemsGenetalPanel = new System.Windows.Forms.Panel();
            this.SelectedItemPanel = new System.Windows.Forms.Panel();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.CostTextBox = new System.Windows.Forms.TextBox();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.CostLabel = new System.Windows.Forms.Label();
            this.IdLabel = new System.Windows.Forms.Label();
            this.SelectedItemLabel = new System.Windows.Forms.Label();
            this.ItemsPanel = new System.Windows.Forms.Panel();
            this.ButtonsPanel = new System.Windows.Forms.Panel();
            this.RemoveButtonPanel = new System.Windows.Forms.Panel();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.AddButtonPanel = new System.Windows.Forms.Panel();
            this.AddButton = new System.Windows.Forms.Button();
            this.ItemsLabel = new System.Windows.Forms.Label();
            this.ItemsListBox = new System.Windows.Forms.ListBox();
            this.ItemsGenetalPanel.SuspendLayout();
            this.SelectedItemPanel.SuspendLayout();
            this.ItemsPanel.SuspendLayout();
            this.ButtonsPanel.SuspendLayout();
            this.RemoveButtonPanel.SuspendLayout();
            this.AddButtonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ItemsGenetalPanel
            // 
            this.ItemsGenetalPanel.Controls.Add(this.SelectedItemPanel);
            this.ItemsGenetalPanel.Controls.Add(this.ItemsPanel);
            this.ItemsGenetalPanel.Location = new System.Drawing.Point(3, 3);
            this.ItemsGenetalPanel.Name = "ItemsGenetalPanel";
            this.ItemsGenetalPanel.Size = new System.Drawing.Size(969, 631);
            this.ItemsGenetalPanel.TabIndex = 0;
            // 
            // SelectedItemPanel
            // 
            this.SelectedItemPanel.Controls.Add(this.CategoryComboBox);
            this.SelectedItemPanel.Controls.Add(this.CategoryLabel);
            this.SelectedItemPanel.Controls.Add(this.DescriptionTextBox);
            this.SelectedItemPanel.Controls.Add(this.DescriptionLabel);
            this.SelectedItemPanel.Controls.Add(this.NameTextBox);
            this.SelectedItemPanel.Controls.Add(this.NameLabel);
            this.SelectedItemPanel.Controls.Add(this.CostTextBox);
            this.SelectedItemPanel.Controls.Add(this.IdTextBox);
            this.SelectedItemPanel.Controls.Add(this.CostLabel);
            this.SelectedItemPanel.Controls.Add(this.IdLabel);
            this.SelectedItemPanel.Controls.Add(this.SelectedItemLabel);
            this.SelectedItemPanel.Location = new System.Drawing.Point(411, 3);
            this.SelectedItemPanel.Name = "SelectedItemPanel";
            this.SelectedItemPanel.Size = new System.Drawing.Size(555, 625);
            this.SelectedItemPanel.TabIndex = 1;
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(83, 115);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(156, 28);
            this.CategoryComboBox.TabIndex = 10;
            this.CategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.CategoryComboBox_SelectedIndexChanged);
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Location = new System.Drawing.Point(5, 118);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(72, 20);
            this.CategoryLabel.TabIndex = 9;
            this.CategoryLabel.Text = "Category:";
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Location = new System.Drawing.Point(5, 360);
            this.DescriptionTextBox.Multiline = true;
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(536, 150);
            this.DescriptionTextBox.TabIndex = 8;
            this.DescriptionTextBox.TextChanged += new System.EventHandler(this.DescriptionTextBox_TextChanged);
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(5, 337);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(88, 20);
            this.DescriptionLabel.TabIndex = 7;
            this.DescriptionLabel.Text = "Description:";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(5, 210);
            this.NameTextBox.Multiline = true;
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(536, 94);
            this.NameTextBox.TabIndex = 6;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(5, 187);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(52, 20);
            this.NameLabel.TabIndex = 5;
            this.NameLabel.Text = "Name:";
            // 
            // CostTextBox
            // 
            this.CostTextBox.Location = new System.Drawing.Point(83, 78);
            this.CostTextBox.Name = "CostTextBox";
            this.CostTextBox.Size = new System.Drawing.Size(156, 27);
            this.CostTextBox.TabIndex = 4;
            this.CostTextBox.TextChanged += new System.EventHandler(this.CostTextBox_TextChanged);
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(83, 41);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.ReadOnly = true;
            this.IdTextBox.Size = new System.Drawing.Size(156, 27);
            this.IdTextBox.TabIndex = 3;
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Location = new System.Drawing.Point(5, 81);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(41, 20);
            this.CostLabel.TabIndex = 2;
            this.CostLabel.Text = "Cost:";
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Location = new System.Drawing.Point(5, 44);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(27, 20);
            this.IdLabel.TabIndex = 1;
            this.IdLabel.Text = "ID:";
            // 
            // SelectedItemLabel
            // 
            this.SelectedItemLabel.AutoSize = true;
            this.SelectedItemLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SelectedItemLabel.Location = new System.Drawing.Point(3, 6);
            this.SelectedItemLabel.Name = "SelectedItemLabel";
            this.SelectedItemLabel.Size = new System.Drawing.Size(104, 20);
            this.SelectedItemLabel.TabIndex = 0;
            this.SelectedItemLabel.Text = "Selected Item";
            // 
            // ItemsPanel
            // 
            this.ItemsPanel.Controls.Add(this.ButtonsPanel);
            this.ItemsPanel.Controls.Add(this.ItemsLabel);
            this.ItemsPanel.Controls.Add(this.ItemsListBox);
            this.ItemsPanel.Location = new System.Drawing.Point(3, 3);
            this.ItemsPanel.Name = "ItemsPanel";
            this.ItemsPanel.Size = new System.Drawing.Size(402, 625);
            this.ItemsPanel.TabIndex = 0;
            // 
            // ButtonsPanel
            // 
            this.ButtonsPanel.Controls.Add(this.RemoveButtonPanel);
            this.ButtonsPanel.Controls.Add(this.AddButtonPanel);
            this.ButtonsPanel.Location = new System.Drawing.Point(3, 559);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.Size = new System.Drawing.Size(396, 63);
            this.ButtonsPanel.TabIndex = 1;
            // 
            // RemoveButtonPanel
            // 
            this.RemoveButtonPanel.Controls.Add(this.RemoveButton);
            this.RemoveButtonPanel.Location = new System.Drawing.Point(136, 3);
            this.RemoveButtonPanel.Name = "RemoveButtonPanel";
            this.RemoveButtonPanel.Size = new System.Drawing.Size(127, 57);
            this.RemoveButtonPanel.TabIndex = 3;
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(3, 3);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(121, 51);
            this.RemoveButton.TabIndex = 2;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // AddButtonPanel
            // 
            this.AddButtonPanel.Controls.Add(this.AddButton);
            this.AddButtonPanel.Location = new System.Drawing.Point(3, 3);
            this.AddButtonPanel.Name = "AddButtonPanel";
            this.AddButtonPanel.Size = new System.Drawing.Size(127, 57);
            this.AddButtonPanel.TabIndex = 2;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(3, 3);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(121, 51);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ItemsLabel
            // 
            this.ItemsLabel.AutoSize = true;
            this.ItemsLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ItemsLabel.Location = new System.Drawing.Point(3, 6);
            this.ItemsLabel.Name = "ItemsLabel";
            this.ItemsLabel.Size = new System.Drawing.Size(49, 20);
            this.ItemsLabel.TabIndex = 1;
            this.ItemsLabel.Text = "Items";
            // 
            // ItemsListBox
            // 
            this.ItemsListBox.FormattingEnabled = true;
            this.ItemsListBox.ItemHeight = 20;
            this.ItemsListBox.Location = new System.Drawing.Point(3, 29);
            this.ItemsListBox.Name = "ItemsListBox";
            this.ItemsListBox.Size = new System.Drawing.Size(396, 524);
            this.ItemsListBox.TabIndex = 1;
            this.ItemsListBox.SelectedIndexChanged += new System.EventHandler(this.ItemsListBox_SelectedIndexChanged);
            // 
            // ItemsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ItemsGenetalPanel);
            this.Name = "ItemsTab";
            this.Size = new System.Drawing.Size(975, 637);
            this.ItemsGenetalPanel.ResumeLayout(false);
            this.SelectedItemPanel.ResumeLayout(false);
            this.SelectedItemPanel.PerformLayout();
            this.ItemsPanel.ResumeLayout(false);
            this.ItemsPanel.PerformLayout();
            this.ButtonsPanel.ResumeLayout(false);
            this.RemoveButtonPanel.ResumeLayout(false);
            this.AddButtonPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ItemsGenetalPanel;
        private System.Windows.Forms.Panel SelectedItemPanel;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox CostTextBox;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.Label SelectedItemLabel;
        private System.Windows.Forms.Panel ItemsPanel;
        private System.Windows.Forms.Panel ButtonsPanel;
        private System.Windows.Forms.Panel RemoveButtonPanel;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Panel AddButtonPanel;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label ItemsLabel;
        private System.Windows.Forms.ListBox ItemsListBox;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.Label CategoryLabel;
    }
}
