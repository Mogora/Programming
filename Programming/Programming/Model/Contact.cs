using System;
using System.Collections.Generic;
using System.Text;

namespace Programming.Model
{
    public class Contact
    {
        private string _name;
        private string _surname;
        private string _phoneNumber;

        public Contact()
        {

        }
        public Contact(string name, string surname, string phoneNumber)
        {
            Name = name;
            Surname = surname;
            PhoneNumber = phoneNumber;
        }

        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber
        {
            get
            {
                return _phoneNumber;                
            }
            set
            {
                bool isSuccess = int.TryParse(value, out int finalnumber);
                if (isSuccess == false)
                {
                    throw new ArgumentException("Номер должен состоять только из цифр");
                }
                _phoneNumber = value;
            }
        }    
    }
}
