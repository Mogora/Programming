using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит колекцию покупателей и товаров.
    /// </summary>
    public class Store
    {
        /// <summary>
        /// Покупатели.
        /// </summary>
        private List<Customer> _customers;

        /// <summary>
        /// Товары.
        /// </summary>
        private List<Item> _items;

        /// <summary>
        /// Создает экземпляр класса <see cref="Store"/>.
        /// </summary>
        public Store()
        {
            _customers = new List<Customer>();
            _items = new List<Item>();
        }

        /// <summary>
        /// Возвращает и задает коллекцию покупателей.
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

        /// <summary>
        /// Возвращает и задает коллекцию товаров.
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
    }
}
