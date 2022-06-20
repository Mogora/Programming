using System;
using System.Text.RegularExpressions;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит данные о контактных данных человека.
    /// </summary>
    public class Contact
    {
        /// <summary>
        /// Имя контакта.
        /// </summary>
        private string _name;

        /// <summary>
        /// Фамилия контакта.
        /// </summary>
        private string _surname;

        /// <summary>
        /// Номер телефона.
        /// </summary>
        private string _phoneNumber;

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Contact"/>.
        /// </summary>
        public Contact()
        {

        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Contact"/>.
        /// </summary>
        /// <param name="name"> Имя контакта. Должна состоять только из букв английского алфавита.</param>
        /// <param name="surname"> Фамилия контакта. Должна состоять только из букв английского алфавита.</param>
        /// <param name="phoneNumber"> Номер телефона. Должен состоять только из цифр. Количество символолов должно быть равно 11. </param>
        public Contact(string name, string surname, string phoneNumber)
        {
            Name = name;
            Surname = surname;
            PhoneNumber = phoneNumber;
        }

        /// <summary>
        /// Возвращает и задаёт имя контакта. Должна состоять только из букв английского алфавита.
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = AssertStringContainsOnlyLetters(nameof(Name), value);
            }
        }

        /// <summary>
        /// Возвращает и задаёт фамилию контакта. Должна состоять только из букв английского алфавита.
        /// </summary>
        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                _surname = AssertStringContainsOnlyLetters(nameof(Surname), value);
            }
        }

        /// <summary>
        /// Возвращает и задаёт номер телефона контакта. Должен состоять только из цифр. Количество символолов должно быть равно 11.
        /// </summary>
        public string PhoneNumber
        {
            get
            {
                return _phoneNumber;
            }
            set
            {
                bool isSuccess = int.TryParse(value, out int finalNumber);
                if (!isSuccess)
                {
                    throw new ArgumentException("Номер должен состоять только из цифр");
                }
                _phoneNumber = value;
            }
        }

        public string AssertStringContainsOnlyLetters(string nameProperty, string value)
        {
            if (!Regex.IsMatch(value, @"^[a-zA-Z]+$"))
            {
                throw new System.ArgumentException($"Значение {nameProperty} должно состоять только из букв английского алфавита");
            }
            return value;
        }
    }
}
