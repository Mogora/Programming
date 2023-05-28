using System;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using System.ComponentModel;
using View.Model;
using View.Model.Services;

namespace View.ViewModel
{
    public class MainVM: INotifyPropertyChanged
    {
        /// <summary>
        /// Событие изменения свойства.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Контакт.
        /// </summary>
        public Contact Contact { get; private set; } = new Contact();

        /// <summary>
        /// Возвращает и задаёт путь сериализации. По умолчанию - папка "Мои документы".
        /// </summary>
        public string Path { get; set; } =
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            + @"\Contacts\contacts.json";

        /// <summary>
        /// Возвращает и задаёт имя контакта.
        /// </summary>
        public string Name
        {
            Contacts = _serializer.Load();
            AddCommand = new RelayCommand(AddContact);
            EditCommand = new RelayCommand(EditContact);
            RemoveCommand = new RelayCommand(RemoveContact);
            ApplyCommand = new RelayCommand(ApplyChangesContact);
            IsReadOnly = true;
            IsEdit = false;
        }
        
        /// <summary>
        /// Возвращает и задает исходную версию редактируемого контакта.
        /// </summary>
        public ContactVM ContactClone { get; set; }

        /// <summary>
        /// Возвращает и задает коллекцию контактов.
        /// </summary>
        public ObservableCollection<ContactVM> Contacts { get; set; }

        /// <summary>
        /// Возвращает и задает выбранный контакт.
        /// </summary>
        public ContactVM CurrentContact
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
        /// Возвращает и задаёт электронную почту контакта.
        /// </summary>
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
        /// Возвращает и задаёт номер телефона контакта.
        /// </summary>
        public string PhoneNumber
        {
            get
            {
                return Contact.Phone;
            }
            set
            {
                Contact.Phone = value;
                OnPropertyChanged(nameof(PhoneNumber));
            }
        }

        /// <summary>
        /// Команда сериализации контакта.
        /// </summary>
        //public ICommand SaveCommand
        //{
        //    get
        //    {
        //        return new RelayCommand((obj) =>
        //        {
        //            ContactSerializer.Serialize(Contact, Path);
        //        });
        //    }
        //}

        /// <summary>
        /// Команда десериализации контакта.
        /// </summary>
        private void RemoveContact()
        {
            if (Contacts.Count == 1)
            {
                Contacts.Remove(CurrentContact);
            }
            else if (CurrentIndex < Contacts.Count - 1)
            {
                Contacts.Remove(CurrentContact);
                CurrentContact = Contacts[CurrentIndex];
            }
            else
            {
                Contacts.Remove(CurrentContact);
                CurrentContact = Contacts[CurrentIndex - 1];
            }
        }

        /// <summary>
        /// При вызове зажигает событие <see cref="PropertyChanged"/>.
        /// </summary>
        /// <param name="prop">Имя свойства, вызвавшего метод.</param>
        protected void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
