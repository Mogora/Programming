using System;
using View.Model;
using CommunityToolkit.Mvvm.ComponentModel;
using System.ComponentModel.DataAnnotations;
using View.Model.Services;

namespace View.ViewModel
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
            get
            {
                return Contact.Name;
            }
            set
            {
                Contact.Name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        /// <summary>
        /// Возвращает и получает телефон контакта.
        /// </summary>
        [CustomValidation(typeof(ValueValidator), nameof(ValueValidator.ValidateEmail))]
        public string Phone
        {
            get
            {
                return Contact.Phone;
            }
            set
            {
                Contact.Phone = value;
                OnPropertyChanged(nameof(Phone));
            }
        }

        /// <summary>
        /// Возвращает и получает электронную почту контакта.
        /// </summary>
        [CustomValidation(typeof(ValueValidator), nameof(ValueValidator.ValidatePhone))]
        public string Email
        {
            get
            {
                return Contact.Email;
            }
            set
            {
                Contact.Email = value;
                OnPropertyChanged(nameof(Email));
            }
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
