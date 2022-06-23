using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividuallTask.Model
{
    public class Building
    {
        /// <summary>
        /// Название здания.
        /// </summary>
        private string _title = "None";

        /// <summary>
        /// Адрес здания.
        /// </summary>
        private string _address = "None";

        /// <summary>
        /// Категория здания.
        /// </summary>
        private string _category;

        /// <summary>
        /// Рейтинг здания.
        /// </summary>
        private double _rating;

        public Building ()
        {

        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Building">.
        /// </summary>
        /// <param name="title"> Название здания. Должно состоять только из букв английского алфавита. Не более 200 символов. </param>
        /// <param name="address"> Адрес здания. Не более 100 символов. </param>
        /// <param name="category"> Категория здания. Должно состоять только из букв английского алфавита. </param>
        /// <param name="rating"> Рейтинг здания. Должен быть от 0 до 5. </param>
        public Building (string title, string address, string category, double rating)
        {
            Title = title;
            Address = address;
            Category = category;
            Rating = rating;
        }

        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                Validator.AssertStringContainsOnlyLetters(nameof(Title), value);
                Validator.AssertNumberContainsNoMoreTwoHaundredDigit(nameof(Title), value);
                _title = value;
            }
        }

        public string Address
        {
            get
            {
                return _address;
            }
            set
            {
                Validator.AssertStringContainsOnlyLetters(nameof(Address), value);
                Validator.AssertNumberContainsNoMoreOneHaundredDigit(nameof(Address), value);
                _address = value;
            }
        }

        public string Category
        {
            get
            {
                return _category;
            }
            set
            {
                Validator.AssertStringContainsOnlyLetters(nameof(Category), value);
                _category = value;
            }
        }

        public double Rating
        {
            get
            {
                return _rating;
            }
            set
            {
                Validator.AssertValueInRange(nameof(Rating), value, 0, 5);
                _rating = value;
            }
        }

    }
}
