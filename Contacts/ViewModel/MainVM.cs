using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Model;
using Model.Services;

namespace ViewModel
{
    /// <summary>
    /// ViewModel для главного окна.
    /// </summary>
    public class MainVM: ObservableObject
    {
        /// <summary>
        /// Поле, хранящее значение для свойства окна ReadOnly.
        /// </summary>
        private bool _isReadOnly;

        /// <summary>
        /// Поле, отвечающее за состояние кнопки Edit.
        /// </summary>
        private bool _isEdit;

        /// <summary>
        /// Текущий контакт.
        /// </summary>
        private ContactVM _currentContact;

        /// <summary>
        /// Создает экземпляр класса <see cref="MainVM"/>.
        /// </summary>
        public MainVM()
        {
            Contacts = new ObservableCollection<ContactVM>(ContactSerializer.Load().Select(c => new ContactVM(c)));
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
                return _currentContact;
            }
            set
            {
                if (ContactClone != null && Contacts.IndexOf(CurrentContact) != -1)
                {
                    Contacts[Contacts.IndexOf(CurrentContact)] = ContactClone;
                    ContactClone = null;
                }

                _currentContact = value;
                
                if (CurrentContact != null)
                {
                    IsEdit = true;
                }

                OnPropertyChanged();
            }
        }

        /// <summary>
        /// Возвращает команду добавления контакта.
        /// </summary>
        public ICommand AddCommand { get; }

        /// <summary>
        /// Возвращает команду редактирования контакта.
        /// </summary>
        public ICommand EditCommand { get; }

        /// <summary>
        /// Возвращает команду удаления контакта.
        /// </summary>
        public ICommand RemoveCommand { get; }

        /// <summary>
        /// Возвращает команду принятия изменений.
        /// </summary>
        public ICommand ApplyCommand { get; }

        /// <summary>
        /// Возвращает и задает значение доступностик кнопки редактирования.
        /// </summary>
        public bool IsEdit
        {
            get
            {
                return _isEdit;
            }
            set
            {
                SetProperty(ref _isEdit, value);
            }
        }

        /// <summary>
        /// Возвращает и задает значение доступности редактирования текстовых полей.
        /// </summary>
        public bool IsReadOnly
        {
            get
            {
                return _isReadOnly;
            }
            set
            {
                SetProperty(ref _isReadOnly, value);
            }
        }

        /// <summary>
        /// Добавляет контакт.
        /// </summary>
        private void AddContact()
        {
            CurrentContact = null;
            CurrentContact = new ContactVM(new Contact());
            IsReadOnly = false;
            IsEdit = false;
        }

        /// <summary>
        /// Изменяет контакт.
        /// </summary>
        private void EditContact()
        {
            ContactClone = (ContactVM)CurrentContact.Clone();
            IsReadOnly = false;
            IsEdit = false;
        }

        /// <summary>
        /// Удаляет выбранный контакт.
        /// </summary>
        private void RemoveContact()
        {
            if (CurrentContact == null)
            {
                return;
            }

            int index = Contacts.IndexOf(CurrentContact);
            Contacts.RemoveAt(index);

            if (Contacts.Count == 0)
            {
                CurrentContact = null;
            }
            else if (index == Contacts.Count)
            {
                CurrentContact = Contacts[index - 1];
            }
            else
            {
                CurrentContact = Contacts[index];
            }

            ContactSerializer.Save(new ObservableCollection<Contact>(
                Contacts.Select(c => new Contact
                {
                    Name = c.Name,
                    Phone = c.Phone,
                    Email = c.Email
                })));
        }

        /// <summary>
        /// Принимает изменения редактирования контакта.
        /// </summary>
        private void ApplyChangesContact()
        {
            if (!Contacts.Contains(CurrentContact))
            {
                Contacts.Add(CurrentContact);
            }
            ContactClone = null;
            IsEdit = true;
            IsReadOnly = true;
            ContactSerializer.Save(new ObservableCollection<Contact>(
                Contacts.Select(c => new Contact
                {
                    Name = c.Name,
                    Phone = c.Phone,
                    Email = c.Email
                })));
        }
    }
}
