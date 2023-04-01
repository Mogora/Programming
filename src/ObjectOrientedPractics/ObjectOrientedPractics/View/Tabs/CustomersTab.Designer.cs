
namespace ObjectOrientedPractics.View.Tabs
{
    partial class CustomersTab
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
            ObjectOrientedPractics.Model.Address address1 = new ObjectOrientedPractics.Model.Address();
            this.CustomersGeneralPanel = new System.Windows.Forms.Panel();
            this.AddressControl = new ObjectOrientedPractics.View.Controls.AddressControl();
            this.ButtonsPanel = new System.Windows.Forms.Panel();
            this.RemoveButtonPanel = new System.Windows.Forms.Panel();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.AddButtonPanel = new System.Windows.Forms.Panel();
            this.AddButton = new System.Windows.Forms.Button();
            this.SelectedCustomerPanel = new System.Windows.Forms.Panel();
            this.FullNameTextBox = new System.Windows.Forms.TextBox();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.FullNameLabel = new System.Windows.Forms.Label();
            this.IDLabel = new System.Windows.Forms.Label();
            this.SelectedCustomerLabel = new System.Windows.Forms.Label();
            this.CustomersLabel = new System.Windows.Forms.Label();
            this.CustomersPanel = new System.Windows.Forms.Panel();
            this.CustomersListBox = new System.Windows.Forms.ListBox();
            this.CustomersGeneralPanel.SuspendLayout();
            this.ButtonsPanel.SuspendLayout();
            this.RemoveButtonPanel.SuspendLayout();
            this.AddButtonPanel.SuspendLayout();
            this.SelectedCustomerPanel.SuspendLayout();
            this.CustomersPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CustomersGeneralPanel
            // 
            this.CustomersGeneralPanel.Controls.Add(this.AddressControl);
            this.CustomersGeneralPanel.Controls.Add(this.ButtonsPanel);
            this.CustomersGeneralPanel.Controls.Add(this.SelectedCustomerPanel);
            this.CustomersGeneralPanel.Controls.Add(this.CustomersLabel);
            this.CustomersGeneralPanel.Controls.Add(this.CustomersPanel);
            this.CustomersGeneralPanel.Location = new System.Drawing.Point(3, 3);
            this.CustomersGeneralPanel.Name = "CustomersGeneralPanel";
            this.CustomersGeneralPanel.Size = new System.Drawing.Size(969, 631);
            this.CustomersGeneralPanel.TabIndex = 0;
            // 
            // AddressControl
            // 
            address1.Apartment = "";
            address1.Building = "";
            address1.City = "";
            address1.Country = "";
            address1.Index = 100000;
            address1.Street = "";
            this.AddressControl.Address = address1;
            this.AddressControl.Location = new System.Drawing.Point(411, 119);
            this.AddressControl.Name = "AddressControl";
            this.AddressControl.Size = new System.Drawing.Size(555, 321);
            this.AddressControl.TabIndex = 4;
            // 
            // ButtonsPanel
            // 
            this.ButtonsPanel.Controls.Add(this.RemoveButtonPanel);
            this.ButtonsPanel.Controls.Add(this.AddButtonPanel);
            this.ButtonsPanel.Location = new System.Drawing.Point(3, 559);
            this.ButtonsPanel.Name = "ButtonsPanel";
            this.ButtonsPanel.Size = new System.Drawing.Size(399, 66);
            this.ButtonsPanel.TabIndex = 3;
            // 
            // RemoveButtonPanel
            // 
            this.RemoveButtonPanel.Controls.Add(this.RemoveButton);
            this.RemoveButtonPanel.Location = new System.Drawing.Point(136, 3);
            this.RemoveButtonPanel.Name = "RemoveButtonPanel";
            this.RemoveButtonPanel.Size = new System.Drawing.Size(127, 57);
            this.RemoveButtonPanel.TabIndex = 5;
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(3, 3);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(121, 51);
            this.RemoveButton.TabIndex = 5;
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
            this.AddButtonPanel.TabIndex = 4;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(3, 3);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(121, 51);
            this.AddButton.TabIndex = 6;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // SelectedCustomerPanel
            // 
            this.SelectedCustomerPanel.Controls.Add(this.FullNameTextBox);
            this.SelectedCustomerPanel.Controls.Add(this.IdTextBox);
            this.SelectedCustomerPanel.Controls.Add(this.FullNameLabel);
            this.SelectedCustomerPanel.Controls.Add(this.IDLabel);
            this.SelectedCustomerPanel.Controls.Add(this.SelectedCustomerLabel);
            this.SelectedCustomerPanel.Location = new System.Drawing.Point(411, 3);
            this.SelectedCustomerPanel.Name = "SelectedCustomerPanel";
            this.SelectedCustomerPanel.Size = new System.Drawing.Size(555, 110);
            this.SelectedCustomerPanel.TabIndex = 2;
            // 
            // FullNameTextBox
            // 
            this.FullNameTextBox.Location = new System.Drawing.Point(101, 72);
            this.FullNameTextBox.Name = "FullNameTextBox";
            this.FullNameTextBox.Size = new System.Drawing.Size(441, 27);
            this.FullNameTextBox.TabIndex = 9;
            this.FullNameTextBox.TextChanged += new System.EventHandler(this.FullNameTextBox_TextChanged);
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(101, 35);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.ReadOnly = true;
            this.IdTextBox.Size = new System.Drawing.Size(141, 27);
            this.IdTextBox.TabIndex = 8;
            // 
            // FullNameLabel
            // 
            this.FullNameLabel.AutoSize = true;
            this.FullNameLabel.Location = new System.Drawing.Point(3, 73);
            this.FullNameLabel.Name = "FullNameLabel";
            this.FullNameLabel.Size = new System.Drawing.Size(79, 20);
            this.FullNameLabel.TabIndex = 6;
            this.FullNameLabel.Text = "Full Name:";
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Location = new System.Drawing.Point(3, 38);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(27, 20);
            this.IDLabel.TabIndex = 5;
            this.IDLabel.Text = "ID:";
            // 
            // SelectedCustomerLabel
            // 
            this.SelectedCustomerLabel.AutoSize = true;
            this.SelectedCustomerLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SelectedCustomerLabel.Location = new System.Drawing.Point(3, 3);
            this.SelectedCustomerLabel.Name = "SelectedCustomerLabel";
            this.SelectedCustomerLabel.Size = new System.Drawing.Size(139, 20);
            this.SelectedCustomerLabel.TabIndex = 4;
            this.SelectedCustomerLabel.Text = "Selected Customer";
            // 
            // CustomersLabel
            // 
            this.CustomersLabel.AutoSize = true;
            this.CustomersLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CustomersLabel.Location = new System.Drawing.Point(3, 6);
            this.CustomersLabel.Name = "CustomersLabel";
            this.CustomersLabel.Size = new System.Drawing.Size(84, 20);
            this.CustomersLabel.TabIndex = 1;
            this.CustomersLabel.Text = "Customers";
            // 
            // CustomersPanel
            // 
            this.CustomersPanel.Controls.Add(this.CustomersListBox);
            this.CustomersPanel.Location = new System.Drawing.Point(3, 3);
            this.CustomersPanel.Name = "CustomersPanel";
            this.CustomersPanel.Size = new System.Drawing.Size(402, 625);
            this.CustomersPanel.TabIndex = 0;
            // 
            // CustomersListBox
            // 
            this.CustomersListBox.FormattingEnabled = true;
            this.CustomersListBox.ItemHeight = 20;
            this.CustomersListBox.Location = new System.Drawing.Point(3, 29);
            this.CustomersListBox.Name = "CustomersListBox";
            this.CustomersListBox.Size = new System.Drawing.Size(396, 524);
            this.CustomersListBox.TabIndex = 0;
            this.CustomersListBox.SelectedIndexChanged += new System.EventHandler(this.CustomersListBox_SelectedIndexChanged);
            // 
            // CustomersTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CustomersGeneralPanel);
            this.Name = "CustomersTab";
            this.Size = new System.Drawing.Size(975, 637);
            this.CustomersGeneralPanel.ResumeLayout(false);
            this.CustomersGeneralPanel.PerformLayout();
            this.ButtonsPanel.ResumeLayout(false);
            this.RemoveButtonPanel.ResumeLayout(false);
            this.AddButtonPanel.ResumeLayout(false);
            this.SelectedCustomerPanel.ResumeLayout(false);
            this.SelectedCustomerPanel.PerformLayout();
            this.CustomersPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel CustomersGeneralPanel;
        private System.Windows.Forms.Panel CustomersPanel;
        private System.Windows.Forms.Label CustomersLabel;
        private System.Windows.Forms.ListBox CustomersListBox;
        private System.Windows.Forms.Panel SelectedCustomerPanel;
        private System.Windows.Forms.Panel ButtonsPanel;
        private System.Windows.Forms.Panel AddButtonPanel;
        private System.Windows.Forms.Panel RemoveButtonPanel;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.Label SelectedCustomerLabel;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.Label FullNameLabel;
        private System.Windows.Forms.TextBox FullNameTextBox;
        private Controls.AddressControl AddressControl;
    }
}
