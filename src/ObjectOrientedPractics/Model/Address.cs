using System;
using System.Collections.Generic;
using System.Text;
using static ObjectOrientedPractics.Services.ValueValidator;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Хранит данные о адресе покупателя.
    /// </summary>
    public class Address
    {
        /// <summary>
        /// Почтовый индекс покупателя.
        /// </summary>
        private int _index;

        /// <summary>
        /// Страна покупателя.
        /// </summary>
        private string _country;

        /// <summary>
        /// Город покупателя.
        /// </summary>
        private string _city;

        /// <summary>
        /// Улица покупателя.
        /// </summary>
        private string _street;

        /// <summary>
        /// Номер дома покупателя.
        /// </summary>
        private string _building;

        /// <summary>
        /// Номер квартиры покупателя.
        /// </summary>
        private string _apartment;

        /// <summary>
        /// Создает экземпляр класса <see cref="Address"/>.
        /// </summary>
        /// <param name="index">Почтовый индекс покупателя. 
        /// Должно находится в диапазоне от 100000 до 999999 (включительно).</param>
        /// <param name="country">Возвращает и задает страну покупателя.
        /// Должно содержать до 50 символов (включительно).</param>
        /// <param name="city">Возвращает и задает город покупателя.
        /// Должно содержать до 50 символов (включительно).</param>
        /// <param name="street">Возвращает и задает улицу покупателя.
        /// Должно содержать до 100 символов (включительно).</param>
        /// <param name="building">Возвращает и задаёт номер дома покупателя.
        /// Должно содержать до 10 символов (включительно).</param>
        /// <param name="apartmennt">Возвращает и задаёт номер квартиры покупателя.
        /// Должно содержать до 10 символов (включительно).</param>
        public Address (int index, string country, string city, 
            string street, string building, string apartmennt)
        {
            Index = index;
            Country = country;
            City = city;
            Street = street;
            Building = building;
            Apartment = apartmennt;
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Address"/>.
        /// </summary>
        public Address()
        {
            Index = 100000;
            Country = "";
            City = "";
            Street = "";
            Building = "";
            Apartment = "";
        }

        /// <summary>
        /// Возвращает и задает почтовый индекс покупателя.
        /// Должно находится в диапазоне от 100000 до 999999 (включительно).
        /// </summary>
        public int Index
        {
            get
            {
                return _index;
            }
            set
            {
                AssertValueInRange(nameof(Index), value, 100000, 999999);
                _index = value;
            }
        }

        /// <summary>
        /// Возвращает и задает страну покупателя.
        /// Должно содержать до 50 символов (включительно).
        /// </summary>
        public string Country
        {
            get
            {
                return _country;
            }
            set
            {
                AssertStringOnLength(nameof(Country), value, 50);
                _country = value;
            }
        }

        /// <summary>
        /// Возвращает и задает город покупателя магазина.
        /// Должно содержать до 50 символов (включительно).
        /// </summary>
        public string City
        {
            get
            {
                return _city;
            }
            set
            {
                AssertStringOnLength(nameof(City), value, 50);
                _city = value;
            }
        }

        /// <summary>
        /// Возвращает и задает улицу покупателя.
        /// Должно содержать до 100 символов (включительно).
        /// </summary>
        public string Street
        {
            get
            {
                return _street;
            }
            set
            {
                AssertStringOnLength(nameof(Street), value, 100);
                _street = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт номер дома покупателя.
        /// Должно содержать до 10 символов (включительно).
        /// </summary>
        public string Building
        {
            get
            {
                return _building;
            }
            set
            {
                AssertStringOnLength(nameof(Building), value, 10);
                _building = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт номер квартиры покупателя.
        /// Должно содержать до 10 символов (включительно).
        /// </summary>
        public string Apartment
        {
            get
            {
                return _apartment;
            }
            set
            {
                AssertStringOnLength(nameof(Apartment), value, 10);
                _apartment = value;
            }
        }
    }
}
