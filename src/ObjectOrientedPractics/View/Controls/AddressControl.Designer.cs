
namespace ObjectOrientedPractics.View.Controls
{
    partial class AddressControl
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
            this.DeliveryAddressLabel = new System.Windows.Forms.Label();
            this.DeliveryAddressPanel = new System.Windows.Forms.Panel();
            this.ApartmentLabel = new System.Windows.Forms.Label();
            this.ApartmentTextBox = new System.Windows.Forms.TextBox();
            this.StreetLabel = new System.Windows.Forms.Label();
            this.BuildingLabel = new System.Windows.Forms.Label();
            this.CityLabel = new System.Windows.Forms.Label();
            this.BuildingTextBox = new System.Windows.Forms.TextBox();
            this.CityTextBox = new System.Windows.Forms.TextBox();
            this.StreetTextBox = new System.Windows.Forms.TextBox();
            this.CountryTextBox = new System.Windows.Forms.TextBox();
            this.CountryLabel = new System.Windows.Forms.Label();
            this.PostIndexTextBox = new System.Windows.Forms.TextBox();
            this.PostIndexLabel = new System.Windows.Forms.Label();
            this.DeliveryAddressPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // DeliveryAddressLabel
            // 
            this.DeliveryAddressLabel.AutoSize = true;
            this.DeliveryAddressLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DeliveryAddressLabel.Location = new System.Drawing.Point(3, 3);
            this.DeliveryAddressLabel.Name = "DeliveryAddressLabel";
            this.DeliveryAddressLabel.Size = new System.Drawing.Size(128, 20);
            this.DeliveryAddressLabel.TabIndex = 0;
            this.DeliveryAddressLabel.Text = "Delivery Address";
            // 
            // DeliveryAddressPanel
            // 
            this.DeliveryAddressPanel.Controls.Add(this.ApartmentLabel);
            this.DeliveryAddressPanel.Controls.Add(this.ApartmentTextBox);
            this.DeliveryAddressPanel.Controls.Add(this.StreetLabel);
            this.DeliveryAddressPanel.Controls.Add(this.BuildingLabel);
            this.DeliveryAddressPanel.Controls.Add(this.CityLabel);
            this.DeliveryAddressPanel.Controls.Add(this.BuildingTextBox);
            this.DeliveryAddressPanel.Controls.Add(this.CityTextBox);
            this.DeliveryAddressPanel.Controls.Add(this.StreetTextBox);
            this.DeliveryAddressPanel.Controls.Add(this.CountryTextBox);
            this.DeliveryAddressPanel.Controls.Add(this.CountryLabel);
            this.DeliveryAddressPanel.Controls.Add(this.PostIndexTextBox);
            this.DeliveryAddressPanel.Controls.Add(this.PostIndexLabel);
            this.DeliveryAddressPanel.Controls.Add(this.DeliveryAddressLabel);
            this.DeliveryAddressPanel.Location = new System.Drawing.Point(3, 3);
            this.DeliveryAddressPanel.Name = "DeliveryAddressPanel";
            this.DeliveryAddressPanel.Size = new System.Drawing.Size(559, 253);
            this.DeliveryAddressPanel.TabIndex = 1;
            // 
            // ApartmentLabel
            // 
            this.ApartmentLabel.AutoSize = true;
            this.ApartmentLabel.Location = new System.Drawing.Point(210, 149);
            this.ApartmentLabel.Name = "ApartmentLabel";
            this.ApartmentLabel.Size = new System.Drawing.Size(83, 20);
            this.ApartmentLabel.TabIndex = 12;
            this.ApartmentLabel.Text = "Apartment:";
            // 
            // ApartmentTextBox
            // 
            this.ApartmentTextBox.Location = new System.Drawing.Point(299, 146);
            this.ApartmentTextBox.Name = "ApartmentTextBox";
            this.ApartmentTextBox.Size = new System.Drawing.Size(78, 27);
            this.ApartmentTextBox.TabIndex = 11;
            this.ApartmentTextBox.TextChanged += new System.EventHandler(this.ApartmentTextBox_TextChanged);
            // 
            // StreetLabel
            // 
            this.StreetLabel.AutoSize = true;
            this.StreetLabel.Location = new System.Drawing.Point(3, 111);
            this.StreetLabel.Name = "StreetLabel";
            this.StreetLabel.Size = new System.Drawing.Size(51, 20);
            this.StreetLabel.TabIndex = 10;
            this.StreetLabel.Text = "Street:";
            // 
            // BuildingLabel
            // 
            this.BuildingLabel.AutoSize = true;
            this.BuildingLabel.Location = new System.Drawing.Point(3, 149);
            this.BuildingLabel.Name = "BuildingLabel";
            this.BuildingLabel.Size = new System.Drawing.Size(67, 20);
            this.BuildingLabel.TabIndex = 9;
            this.BuildingLabel.Text = "Building:";
            // 
            // CityLabel
            // 
            this.CityLabel.AutoSize = true;
            this.CityLabel.Location = new System.Drawing.Point(329, 72);
            this.CityLabel.Name = "CityLabel";
            this.CityLabel.Size = new System.Drawing.Size(37, 20);
            this.CityLabel.TabIndex = 8;
            this.CityLabel.Text = "City:";
            // 
            // BuildingTextBox
            // 
            this.BuildingTextBox.Location = new System.Drawing.Point(99, 146);
            this.BuildingTextBox.Name = "BuildingTextBox";
            this.BuildingTextBox.Size = new System.Drawing.Size(78, 27);
            this.BuildingTextBox.TabIndex = 7;
            this.BuildingTextBox.TextChanged += new System.EventHandler(this.BuildingTextBox_TextChanged);
            // 
            // CityTextBox
            // 
            this.CityTextBox.Location = new System.Drawing.Point(372, 72);
            this.CityTextBox.Name = "CityTextBox";
            this.CityTextBox.Size = new System.Drawing.Size(168, 27);
            this.CityTextBox.TabIndex = 6;
            this.CityTextBox.TextChanged += new System.EventHandler(this.CityTextBox_TextChanged);
            // 
            // StreetTextBox
            // 
            this.StreetTextBox.Location = new System.Drawing.Point(99, 109);
            this.StreetTextBox.Name = "StreetTextBox";
            this.StreetTextBox.Size = new System.Drawing.Size(441, 27);
            this.StreetTextBox.TabIndex = 5;
            this.StreetTextBox.TextChanged += new System.EventHandler(this.StreetTextBox_TextChanged);
            // 
            // CountryTextBox
            // 
            this.CountryTextBox.Location = new System.Drawing.Point(99, 72);
            this.CountryTextBox.Name = "CountryTextBox";
            this.CountryTextBox.Size = new System.Drawing.Size(210, 27);
            this.CountryTextBox.TabIndex = 4;
            this.CountryTextBox.TextChanged += new System.EventHandler(this.CountryTextBox_TextChanged);
            // 
            // CountryLabel
            // 
            this.CountryLabel.AutoSize = true;
            this.CountryLabel.Location = new System.Drawing.Point(3, 75);
            this.CountryLabel.Name = "CountryLabel";
            this.CountryLabel.Size = new System.Drawing.Size(63, 20);
            this.CountryLabel.TabIndex = 3;
            this.CountryLabel.Text = "Country:";
            // 
            // PostIndexTextBox
            // 
            this.PostIndexTextBox.Location = new System.Drawing.Point(99, 35);
            this.PostIndexTextBox.Name = "PostIndexTextBox";
            this.PostIndexTextBox.Size = new System.Drawing.Size(135, 27);
            this.PostIndexTextBox.TabIndex = 2;
            this.PostIndexTextBox.TextChanged += new System.EventHandler(this.PostIndexTextBox_TextChanged);
            // 
            // PostIndexLabel
            // 
            this.PostIndexLabel.AutoSize = true;
            this.PostIndexLabel.Location = new System.Drawing.Point(3, 38);
            this.PostIndexLabel.Name = "PostIndexLabel";
            this.PostIndexLabel.Size = new System.Drawing.Size(79, 20);
            this.PostIndexLabel.TabIndex = 1;
            this.PostIndexLabel.Text = "Post Index:";
            // 
            // AddressControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DeliveryAddressPanel);
            this.Name = "AddressControl";
            this.Size = new System.Drawing.Size(565, 264);
            this.DeliveryAddressPanel.ResumeLayout(false);
            this.DeliveryAddressPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label DeliveryAddressLabel;
        private System.Windows.Forms.Panel DeliveryAddressPanel;
        private System.Windows.Forms.Label ApartmentLabel;
        private System.Windows.Forms.TextBox ApartmentTextBox;
        private System.Windows.Forms.Label StreetLabel;
        private System.Windows.Forms.Label BuildingLabel;
        private System.Windows.Forms.Label CityLabel;
        private System.Windows.Forms.TextBox BuildingTextBox;
        private System.Windows.Forms.TextBox CityTextBox;
        private System.Windows.Forms.TextBox StreetTextBox;
        private System.Windows.Forms.TextBox CountryTextBox;
        private System.Windows.Forms.Label CountryLabel;
        private System.Windows.Forms.TextBox PostIndexTextBox;
        private System.Windows.Forms.Label PostIndexLabel;
    }
}
