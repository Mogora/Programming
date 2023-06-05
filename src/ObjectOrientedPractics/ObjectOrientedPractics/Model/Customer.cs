using System;
using System.Collections.Generic;
using System.Text;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{
    public class Customer
    {
        /// <summary>
        /// Уникальный идентификатор для всех объектов данного класса.
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// Полное имя покупателя.
        /// </summary>
        private string _fullName;

        /// <summary>
        /// Адрес покупателя.
        /// </summary>
        private Address _address;

        /// <summary>
        /// Количество покупателей.
        /// </summary>
        private static int _allCustomersCount;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Customer"/>.
        /// </summary>
        public Customer()
        {
            _allCustomersCount++;
            _id = _allCustomersCount;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Customer"/>.
        /// </summary>
        /// <param name="fullname">Полное имя. Должно быть не более 200 символов.</param>
        /// <param name="address">Адрес. Должен быть не более 500 символов.</param>
        public Customer(string fullName, Address address)
        {
            FullName = fullName;
            Address = address;
            _allCustomersCount++;
            _id = _allCustomersCount;
        }

        /// <summary>
        /// Возвращает уникальный идентификатор песни.
        /// </summary>
        public int Id => _id;

        /// <summary>
        /// Возвращает и задаёт полное имя покупателя. Должно быть не более 200 символов.
        /// </summary>
        public string FullName
        {
            get => _fullName;
            set
            {
                ValueValidator.AssertStringOnLength(nameof(FullName), value, 200);
                _fullName = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт адрес покупателя. Должно быть не более 500 символов.
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
            }
        }
    }
}
