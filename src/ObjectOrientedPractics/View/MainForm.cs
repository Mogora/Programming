using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics
{
    /// <summary>
    /// Реализует представление главного окна.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Покупатели и товары.
        /// </summary>
        private Store _store;

        /// <summary>
        /// Создает экземпляр класса <see cref="MainForm"/>.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            _store = new Store();

            ItemsTab.Items = _store.Items;
            CustomersTab.Customer = _store.Customers;
        }
    }
}
