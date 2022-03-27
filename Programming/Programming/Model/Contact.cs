using System;
using System.Collections.Generic;
using System.Text;

namespace Programming.Model
{
    public class Contact
    {
        private string _name;
        private string _surname;
        private int _phoneNumber;
        public Contact(string name, string surname, int phoneNumber)
        {
            Name = name;
            Surname = surname;
            PhoneNumber = phoneNumber;
        }

        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int PhoneNumber { get; private set; }
    }
}
