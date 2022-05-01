using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

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

        public string PhoneNumber
        {
            get
            {
                return _phoneNumber;                
            }
            set
            {
                bool isSuccess = int.TryParse(value, out int finalnumber);
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
