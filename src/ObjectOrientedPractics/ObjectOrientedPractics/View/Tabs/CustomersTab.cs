using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CustomersTab : UserControl
    {
        /// <summary>
        /// Коллекция покупателей.
        /// </summary>
        private List<Customer> _customers;

        /// <summary>
        /// Выбранный покупатель.
        /// </summary>
        private Customer _currentCustomer;

        /// <summary>
        /// Реализация представления класса <see cref="Customer"/>.
        /// </summary>
        public CustomersTab()
        {
            _customers = new List<Customer>();

            InitializeComponent();
        }

        /// <summary>
        /// Возвращает и задает коллекцию покупателей.
        /// </summary>
        public List<Customer> Customers { get; set; }

        /// <summary>
        /// Очищает информацию о зданиях из списка и текстовых полей.
        /// </summary>
        /// <param name="customer"></param>
        private void ClearCustomerInfo()
        {
            FullNameTextBox.Clear();
            IdTextBox.Clear();
            CustomersListBox.Items.Clear();
            FullNameTextBox.BackColor = AppColor.CorrectColor;
            AddressControl.ClearAddressInfo();
        }

        /// <summary>
        /// На значения покупателя задаются параметры.
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        private string CustomerDescription(Customer customer)
        {
            return $"{customer.FullName}: - {customer.Id}";
        }

        /// <summary>
        /// Обновляет информацию в списке.
        /// </summary>
        /// <param name="customer"></param>
        private void UpdateCustomerInfo(Customer customer)
        {
            List<Customer> customers = Customers;

            int index = _customers.IndexOf(customer);

            if (index == -1) return;

            CustomersListBox.Items[index] = CustomerDescription(customer);
        }

        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex != -1)
            {
                int index = CustomersListBox.SelectedIndex;
                _currentCustomer = _customers[index];
                IdTextBox.Text = _currentCustomer.Id.ToString();
                FullNameTextBox.Text = _currentCustomer.FullName;
            }
        }

        private void FullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            int index = CustomersListBox.SelectedIndex;

            if (index == -1) return;

            try
            {
                string fullName = FullNameTextBox.Text;
                _currentCustomer.FullName = fullName;
                UpdateCustomerInfo(_currentCustomer);
            }
            catch
            {
                FullNameTextBox.BackColor = AppColor.ErrorColor;
                return;
            }
            FullNameTextBox.BackColor = AppColor.CorrectColor;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            _currentCustomer = new Customer();
            _customers.Add(_currentCustomer);
            CustomersListBox.Items.Add(CustomerDescription(_currentCustomer));
            CustomersListBox.SelectedIndex = _customers.Count - 1;
            UpdateCustomerInfo(_currentCustomer);
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            int index = CustomersListBox.SelectedIndex;

            if (index != -1)
            {
                _customers.RemoveAt(index);
                ClearCustomerInfo();
            }

            foreach (var customer in _customers)
            {
                CustomersListBox.Items.Add(CustomerDescription(customer));
                CustomersListBox.SelectedIndex = 0;
            }

            UpdateCustomerInfo(_currentCustomer);
        }

      
    }
}
   
