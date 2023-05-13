using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ObjectOrientedPractics.Model; 
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.View.Controls
{
    /// <summary>
    /// Предоставляет методы для обработки адресов.
    /// </summary>
    public partial class AddressControl : UserControl
    {
        /// <summary>
        /// Адрес покупателя.
        /// </summary>
        private Address _address;

        /// <summary>
        /// Создает эклемпляр класса <see cref="AddressControl"/>.
        /// </summary>
        public AddressControl()
        {
            InitializeComponent();

            Address = new Address();
        }

        /// <summary>
        /// Возвращает и задает адрес покупателя.
        /// </summary>
        public Address Address
        {
            get
            {
                return _address;
            }
            set
            {
                _address = value;
                UpdateAddressTextBox(_address);
            }
        }

       /// <summary>
       /// Обновляет информацию о адресе в текстовых полях.
       /// </summary>
       /// <param name="address"></param>
        public void UpdateAddressTextBox(Address address)
        {
            PostIndexTextBox.Text = address.Index.ToString();
            CountryTextBox.Text = address.Country;
            CityTextBox.Text = address.City;
            StreetTextBox.Text = address.Street;
            BuildingTextBox.Text = address.Building;
            ApartmentTextBox.Text = address.Apartment;
        }

        /// <summary>
        /// Очищает текстовые поля, содержащие информацию про адрес.
        /// </summary>
        public void ClearAddressInfo()
        {
            PostIndexTextBox.Clear();
            CountryTextBox.Clear();
            CityTextBox.Clear();
            StreetTextBox.Clear();
            BuildingTextBox.Clear();
            ApartmentTextBox.Clear();
            PostIndexTextBox.BackColor = AppColor.CorrectColor;
            CountryTextBox.BackColor = AppColor.CorrectColor;
            CityTextBox.BackColor = AppColor.CorrectColor;
            StreetTextBox.BackColor = AppColor.CorrectColor;
            BuildingTextBox.BackColor = AppColor.CorrectColor;
            ApartmentTextBox.BackColor = AppColor.CorrectColor;
        }
        
        private void PostIndexTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _address.Index = int.Parse(PostIndexTextBox.Text);
                PostIndexTextBox.BackColor = AppColor.CorrectColor;
            }
            catch
            {
                PostIndexTextBox.BackColor = AppColor.ErrorColor;
            }
        }

        private void CountryTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _address.Country = CountryTextBox.Text;
                CountryTextBox.BackColor = AppColor.CorrectColor;
            }
            catch
            {
                CountryTextBox.BackColor = AppColor.ErrorColor;
            }
        }

        private void StreetTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _address.Street = StreetTextBox.Text;
                StreetTextBox.BackColor = AppColor.CorrectColor;
            }
            catch
            {
                StreetTextBox.BackColor = AppColor.ErrorColor;
            }
        }

        private void CityTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _address.City = CityTextBox.Text;
                CityTextBox.BackColor = AppColor.CorrectColor;
            }
            catch
            {
                CityTextBox.BackColor = AppColor.ErrorColor;
            }
        }

        private void BuildingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _address.Building = BuildingTextBox.Text;
                BuildingTextBox.BackColor = AppColor.CorrectColor;
            }
            catch
            {
                BuildingTextBox.BackColor = AppColor.ErrorColor;
            }
        }

        private void ApartmentTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _address.Apartment = ApartmentTextBox.Text;
                ApartmentTextBox.BackColor = AppColor.CorrectColor;
            }
            catch
            {
                ApartmentTextBox.BackColor = AppColor.ErrorColor;
            }
        }
    }
}
