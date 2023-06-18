using System;
using CommunityToolkit.Mvvm.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Model;
using Model.Services;

namespace ViewModel
{
    /// <summary>
    /// ViewModel, агрегирующий в себе класс <see cref="Model.Contact"/>.
    /// </summary>
    public class ContactVM : ObservableValidator, ICloneable
    {
        /// <summary>
        /// Создает экземпляр класса <see cref="ContactVM"/>.
        /// </summary>
        /// <param name="contact"></param>
        public ContactVM(Contact contact)
        {
            Contact = contact;
        }

        /// <summary>
        /// Возвращает и задает объект класса <see cref="Model.Contact"/>.
        /// </summary>
        public Contact Contact { get; set; }

        /// <summary>
        /// Возвращает и получает имя контакта.
        /// </summary>
        [CustomValidation(typeof(ValueValidator), nameof(ValueValidator.ValidateName))]
        public string Name
        {
            get => Contact.Name;
            set => SetProperty(Contact.Name, value, Contact, (contact, name) => Contact.Name = name, true);
        }

        /// <summary>
        /// Возвращает и получает телефон контакта.
        /// </summary>
        [CustomValidation(typeof(ValueValidator), nameof(ValueValidator.ValidatePhone))]
        public string Phone
        {
            get => Contact.Phone;
            set => SetProperty(Contact.Phone, value, Contact, (contact, phone) => Contact.Phone = phone, true);
        }

        /// <summary>
        /// Возвращает и получает электронную почту контакта.
        /// </summary>
        [CustomValidation(typeof(ValueValidator), nameof(ValueValidator.ValidateEmail))]
        public string Email
        {
            get => Contact.Email;
            set => SetProperty(Contact.Email, value, Contact, (contact, email) => Contact.Email = email, true);
        }

        /// <summary>
        /// Создает клон объекта.
        /// </summary>
        /// <returns>Объект класса <see cref="ContactVM"/>.</returns>
        public object Clone()
        {
            return new ContactVM((Contact)Contact.Clone());
        }
    }
}
