using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{
    public class Customer
    {
        /// <summary>
        /// Уникальный идентификатор для всех объектов этого класса.
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// Полное имя покупателя.
        /// </summary>
        private string _fullName;

        /// <summary>
        /// Адрес доставки.
        /// </summary>
        private Address _address;

        /// <summary>
        /// Общее количество покупателей.
        /// </summary>
        private static int _allCustomersCount;

        /// <summary>
        /// Создает экземпляр класса <see cref="Customer"/>.
        /// </summary>
        public Customer()
        {
            _allCustomersCount++;
            _id = _allCustomersCount;
            FullName = "Buyer's full name";
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Customer"/>.
        /// </summary>
        /// <param name="fullName"> Полное имя покупателя. </param>
        /// <param name="address"> Адрес доставки. </param>
        public Customer(string fullName, Address address)
        {
            FullName = fullName;
            Address = address;
            _allCustomersCount++;
            _id = _allCustomersCount;
        }

        /// <summary>
        /// Возвращает уникальный идентификатор покупателя.
        /// </summary>
        public int Id
        {
            get
            {
                return _id;
            }
        }
        
        /// <summary>
        /// Возвращает и задает полное имя покупателя.
        /// Должно быть не более 200 символов.
        /// </summary>
        public string FullName
        {
            get
            {
                return _fullName;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 200, nameof(FullName));
                _fullName = value;
            }
        }

        /// <summary>
        /// Возвращает и задает адрес доставки.
        /// Должно быть не более 500 символов.
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
