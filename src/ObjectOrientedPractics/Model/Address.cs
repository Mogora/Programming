using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{
    public class Address
    {
        /// <summary>
        /// Почтовый индекс.
        /// </summary>
        private int _index;

        /// <summary>
        /// Страна или регион доставки.
        /// </summary>
        private string _country;

        /// <summary>
        /// Город доставки.
        /// </summary>
        private string _city;

        /// <summary>
        /// Улица доставки.
        /// </summary>
        private string _street;

        /// <summary>
        /// Номер дома.
        /// </summary>
        private string _building;

        /// <summary>
        /// Номер квартиры.
        /// </summary>
        private string _apartment;

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
        /// Создает экземпляр класса <see cref="Address"/>.
        /// </summary>
        /// <param name="index">Почтовый индекс. Должен содержать 6 символов.</param>
        /// <param name="country">Страна или регион доставки. Должно быть не более 50 символов.</param>
        /// <param name="city">Город доставки.Должно быть не более 50 символов.</param>
        /// <param name="street">Улица доставки. Должно быть не более 100 символов.</param>
        /// <param name="building">Номер дома. Должно быть не более 10 символов.</param>
        /// <param name="apartment">Номер квартиры. Должно быть не более 10 символов.</param>
        public Address(int index, string country, string city, string street, string building, string apartment)
        {
            Index = index;
            Country = country;
            City = city;
            Street = street;
            Building = building;
            Apartment = apartment;
        }

        public int Index
        {
            get
            {
                return _index;
            }
            set
            {
                ValueValidator.AssertSpecifiedNumberCharacters(nameof(Index), value, 6);
                _index = value;
            }
        }

        public string Country
        {
            get
            {
                return _country;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 50, nameof(Country));
                _country = value;
            }
        }

        public string City
        {
            get
            {
                return _city;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 50, nameof(City));
                _city = value;
            }
        }

        public string Street
        {
            get
            {
                return _street;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 100, nameof(Street));
                _street = value;
            }
        }

        public string Building
        {
            get
            {
                return _building;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 10, nameof(Building));
                _building = value;
            }
        }

        public string Apartment
        {
            get
            {
                return _apartment;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 10, nameof(Apartment));
            }
        }
    }
}
