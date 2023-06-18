using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using ViewModel;

namespace View.Controls
{
    /// <summary>
    /// Логика взаимодействия для ContactControl.xaml
    /// </summary>
    public partial class ContactControl : UserControl
    {
        /// <summary>
        /// Регистрирует свойство зависимости для CurrentContact.
        /// </summary>
        public static readonly DependencyProperty CurrentContactProperty =
            DependencyProperty.Register("CurrentContact", typeof(ContactVM),
            typeof(ContactControl), new UIPropertyMetadata(null));

        public ContactControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Возвращает и задаёт выбранный контакт.
        /// </summary>
        public ContactVM CurrentContact
        {
            get => (ContactVM)GetValue(CurrentContactProperty);
            set => SetValue(CurrentContactProperty, value);
        }

        private void PhoneNumberTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            string pattern = @"[\+\-\(\)\d]";
            if (!Regex.IsMatch(e.Text, pattern))
            {
                e.Handled = true;
            }
        }

        private void PhoneNumberTextBox_Paste(object sender, DataObjectPastingEventArgs e)
        {
            if (e.DataObject.GetDataPresent(typeof(string)))
            {
                string input = (string)e.DataObject.GetData(typeof(string));
                string pattern = @"[\+\-\(\)\d]";
                if (!Regex.IsMatch(input, pattern))
                {
                    e.CancelCommand();
                }
            }
            else
            {
                e.CancelCommand();
            }
        }
    }
}
