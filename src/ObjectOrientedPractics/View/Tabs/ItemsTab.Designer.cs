
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
            this.ItemsListBox = new System.Windows.Forms.ListBox();
            this.ItemsLabel = new System.Windows.Forms.Label();
            this.SelectedItemLabel = new System.Windows.Forms.Label();
            this.IdLabel = new System.Windows.Forms.Label();
            this.CostLabel = new System.Windows.Forms.Label();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.CostTextBox = new System.Windows.Forms.TextBox();
            this.ItemsPanel = new System.Windows.Forms.Panel();
            this.ButtonsPanel = new System.Windows.Forms.Panel();
            this.RemoveButtonPanel = new System.Windows.Forms.Panel();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.AddButtonPanel = new System.Windows.Forms.Panel();
            this.AddButton = new System.Windows.Forms.Button();
            this.SelectedItemPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.DescriptioLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.ItemsGeneralPanel = new System.Windows.Forms.Panel();
            this.ItemsPanel.SuspendLayout();
            this.ButtonsPanel.SuspendLayout();
            this.RemoveButtonPanel.SuspendLayout();
            this.AddButtonPanel.SuspendLayout();
            this.SelectedItemPanel.SuspendLayout();
            this.ItemsGeneralPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ItemsListBox
            // 
            this.ItemsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ItemsListBox.FormattingEnabled = true;
            this.ItemsListBox.ItemHeight = 16;
            this.ItemsListBox.Location = new System.Drawing.Point(3, 29);
            this.ItemsListBox.Name = "ItemsListBox";
            this.ItemsListBox.Size = new System.Drawing.Size(331, 596);
            this.ItemsListBox.TabIndex = 0;
            this.ItemsListBox.SelectedIndexChanged += new System.EventHandler(this.ItemsListBox_SelectedIndexChanged);
            // 
            // ItemsLabel
            // 
            this.ItemsLabel.AutoSize = true;
            this.ItemsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ItemsLabel.Location = new System.Drawing.Point(3, 9);
            this.ItemsLabel.Name = "ItemsLabel";
            this.ItemsLabel.Size = new System.Drawing.Size(46, 17);
            this.ItemsLabel.TabIndex = 1;
            this.ItemsLabel.Text = "Items";
            // 
            // SelectedItemLabel
            // 
            this.SelectedItemLabel.AutoSize = true;
            this.SelectedItemLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectedItemLabel.Location = new System.Drawing.Point(3, 9);
            this.SelectedItemLabel.Name = "SelectedItemLabel";
            this.SelectedItemLabel.Size = new System.Drawing.Size(106, 17);
            this.SelectedItemLabel.TabIndex = 2;
            this.SelectedItemLabel.Text = "Selected Item";
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Location = new System.Drawing.Point(3, 45);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(25, 17);
            this.IdLabel.TabIndex = 3;
            this.IdLabel.Text = "ID:";
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Location = new System.Drawing.Point(3, 73);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(40, 17);
            this.CostLabel.TabIndex = 4;
            this.CostLabel.Text = "Cost:";
            // 
            // IdTextBox
            // 
            this.IdTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IdTextBox.Location = new System.Drawing.Point(78, 45);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.ReadOnly = true;
            this.IdTextBox.Size = new System.Drawing.Size(179, 22);
            this.IdTextBox.TabIndex = 5;
            // 
            // CostTextBox
            // 
            this.CostTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CostTextBox.Location = new System.Drawing.Point(78, 73);
            this.CostTextBox.Name = "CostTextBox";
            this.CostTextBox.Size = new System.Drawing.Size(179, 22);
            this.CostTextBox.TabIndex = 6;
            this.CostTextBox.TextChanged += new System.EventHandler(this.CostTextBox_TextChanged);
            // 
            // ItemsPanel
            // 
            this.ItemsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemsPanel.Controls.Add(this.ButtonsPanel);
            this.ItemsPanel.Controls.Add(this.ItemsLabel);
            this.ItemsPanel.Controls.Add(this.ItemsListBox);
            this.ItemsPanel.Location = new System.Drawing.Point(3, 3);
            this.ItemsPanel.Name = "ItemsPanel";
            this.ItemsPanel.Size = new System.Drawing.Size(338, 701);
            this.ItemsPanel.TabIndex = 7;
            // 
            // ButtonsPanel
            // 
            this.ButtonsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonsPanel.Controls.Add(this.RemoveButtonPanel);
            this.ButtonsPanel.Controls.Add(this.AddButtonPanel);
            this.ButtonsPanel.Location = new System.Drawing.Point(3, 631);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.Size = new System.Drawing.Size(334, 59);
            this.ButtonsPanel.TabIndex = 14;
            // 
            // RemoveButtonPanel
            // 
            this.RemoveButtonPanel.Controls.Add(this.RemoveButton);
            this.RemoveButtonPanel.Location = new System.Drawing.Point(123, 0);
            this.RemoveButtonPanel.Name = "RemoveButtonPanel";
            this.RemoveButtonPanel.Size = new System.Drawing.Size(118, 59);
            this.RemoveButtonPanel.TabIndex = 16;
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(3, 4);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(111, 52);
            this.RemoveButton.TabIndex = 14;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // AddButtonPanel
            // 
            this.AddButtonPanel.Controls.Add(this.AddButton);
            this.AddButtonPanel.Location = new System.Drawing.Point(0, 0);
            this.AddButtonPanel.Name = "AddButtonPanel";
            this.AddButtonPanel.Size = new System.Drawing.Size(118, 59);
            this.AddButtonPanel.TabIndex = 15;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(3, 4);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(111, 52);
            this.AddButton.TabIndex = 13;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // SelectedItemPanel
            // 
            this.SelectedItemPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectedItemPanel.Controls.Add(this.label1);
            this.SelectedItemPanel.Controls.Add(this.CategoryComboBox);
            this.SelectedItemPanel.Controls.Add(this.DescriptionTextBox);
            this.SelectedItemPanel.Controls.Add(this.NameTextBox);
            this.SelectedItemPanel.Controls.Add(this.DescriptioLabel);
            this.SelectedItemPanel.Controls.Add(this.NameLabel);
            this.SelectedItemPanel.Controls.Add(this.SelectedItemLabel);
            this.SelectedItemPanel.Controls.Add(this.IdLabel);
            this.SelectedItemPanel.Controls.Add(this.CostLabel);
            this.SelectedItemPanel.Controls.Add(this.CostTextBox);
            this.SelectedItemPanel.Controls.Add(this.IdTextBox);
            this.SelectedItemPanel.Location = new System.Drawing.Point(347, 3);
            this.SelectedItemPanel.Name = "SelectedItemPanel";
            this.SelectedItemPanel.Size = new System.Drawing.Size(479, 700);
            this.SelectedItemPanel.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Category:";
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(78, 101);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(179, 24);
            this.CategoryComboBox.TabIndex = 15;
            this.CategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.CategoryComboBox_SelectedIndexChanged);
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DescriptionTextBox.Location = new System.Drawing.Point(6, 334);
            this.DescriptionTextBox.Multiline = true;
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(470, 94);
            this.DescriptionTextBox.TabIndex = 14;
            this.DescriptionTextBox.TextChanged += new System.EventHandler(this.DescriptionTextBox_TextChanged);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NameTextBox.Location = new System.Drawing.Point(6, 159);
            this.NameTextBox.Multiline = true;
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(470, 133);
            this.NameTextBox.TabIndex = 13;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // DescriptioLabel
            // 
            this.DescriptioLabel.AutoSize = true;
            this.DescriptioLabel.Location = new System.Drawing.Point(3, 314);
            this.DescriptioLabel.Name = "DescriptioLabel";
            this.DescriptioLabel.Size = new System.Drawing.Size(83, 17);
            this.DescriptioLabel.TabIndex = 10;
            this.DescriptioLabel.Text = "Description:";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(3, 139);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(49, 17);
            this.NameLabel.TabIndex = 9;
            this.NameLabel.Text = "Name:";
            // 
            // ItemsGeneralPanel
            // 
            this.ItemsGeneralPanel.Controls.Add(this.ItemsPanel);
            this.ItemsGeneralPanel.Controls.Add(this.SelectedItemPanel);
            this.ItemsGeneralPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ItemsGeneralPanel.Location = new System.Drawing.Point(0, 0);
            this.ItemsGeneralPanel.Name = "ItemsGeneralPanel";
            this.ItemsGeneralPanel.Size = new System.Drawing.Size(830, 709);
            this.ItemsGeneralPanel.TabIndex = 17;
            // 
            // ItemsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ItemsGeneralPanel);
            this.Name = "ItemsTab";
            this.Size = new System.Drawing.Size(830, 709);
            this.ItemsPanel.ResumeLayout(false);
            this.ItemsPanel.PerformLayout();
            this.ButtonsPanel.ResumeLayout(false);
            this.RemoveButtonPanel.ResumeLayout(false);
            this.AddButtonPanel.ResumeLayout(false);
            this.SelectedItemPanel.ResumeLayout(false);
            this.SelectedItemPanel.PerformLayout();
            this.ItemsGeneralPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ItemsListBox;
        private System.Windows.Forms.Label ItemsLabel;
        private System.Windows.Forms.Label SelectedItemLabel;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.TextBox CostTextBox;
        private System.Windows.Forms.Panel ItemsPanel;
        private System.Windows.Forms.Panel SelectedItemPanel;
        private System.Windows.Forms.Label DescriptioLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Panel ButtonsPanel;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Panel AddButtonPanel;
        private System.Windows.Forms.Panel RemoveButtonPanel;
        private System.Windows.Forms.Panel ItemsGeneralPanel;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CategoryComboBox;
    }
}
