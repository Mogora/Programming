using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные о покупателях и магазинах.
    /// </summary>
    public class Store
    {
        /// <summary>
        /// Товар.
        /// </summary>
        private List<Item> _items;

        /// <summary>
        /// Покупатель.
        /// </summary>
        private List<Customer> _customers;

        public Store(List<Item> items, List<Customer> customers)
        {
            Items = items;
            Customers = customers;
        }

        public Store()
        {
            Items = new List<Item>();
            Customers = new List<Customer>();
        }

        /// <summary>
        /// Возвращает и задает товар.
        /// </summary>
        public List<Item> Items
        {
            get
            {
                return _items;
            }
            set
            {
                _items = value;
            }
        }

        /// <summary>
        /// Возвращает и задает покупателя. 
        /// </summary>
        public List<Customer> Customers
        {
            get
            {
                return _customers;
            }
            set
            {
                _customers = value;
            }
        }

    }
}
