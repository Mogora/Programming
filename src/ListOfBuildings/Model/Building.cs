﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOfBuildings.Model
{
    public class Building
    {
        /// <summary>
        ///  Уникальный идентификатор для всех объектов данного класса.
        /// </summary>
        private readonly int _id;

        /// <summary>
        /// Название здания.
        /// </summary>
        private string _title;

        /// <summary>
        /// Адрес здания.
        /// </summary>
        private string _address;

        /// <summary>
        /// Рейтинг здания.
        /// </summary>
        private double _rating;

        /// <summary>
        /// Количество зданий. 
        /// </summary>
        private static int _allBuildingsCount;

        /// <summary>
        /// Создает экземпляр класса <see cref="Building"/>.
        /// </summary>
        public Building ()
        {
            _allBuildingsCount++;
            _id = _allBuildingsCount;
            Title = "Title";
            Address = "Address";
            Rating = 5;
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Building"/>.
        /// </summary>
        /// <param name="title"> Название здания. </param>
        /// <param name="address"> Адрес здания. </param>
        /// <param name="rating"> Рейтинг здания. </param>
        /// <param name="category"> Категория здания. </param>
        public Building (string title, string address, double rating, Category category)
        {
            Title = title;
            Address = address;
            Rating = rating;
            Category = category;
        }

        /// <summary>
        /// Возвращает и задет название здания.
        /// Должно состоять только из букв английского алфавита.
        /// Строка не должна превышать 200 символов.
        /// </summary>
        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                Validator.AssertNoMoreThan(value, 200, nameof(Title));
                Validator.AssertStringContainsOnlyLetters(nameof(Title), value);
                _title = value;
            }
        }

        /// <summary>
        /// Возвращает и задет рейтинг здания.
        /// Должнен быть в промежутке от 0 до 5.
        /// </summary>
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

        /// <summary>
        /// Возвращает и задет адрес здания.
        /// Должно состоять только из букв английского алфавита.
        /// Строка не должна превышать 100 символов.
        /// </summary>
        public string Address
        {
            get
            {
                return _address;
            }
            set
            {
                Validator.AssertNoMoreThan(value, 100, nameof(Address));
                Validator.AssertStringContainsOnlyLetters(nameof(Address), value);
                _address = value;
            }
        }

        /// <summary>
        /// Возвращает категорию здания.
        /// </summary>
        public Category Category { get; set; }

        /// <summary>
        /// Возвращает уникальный индифекатор.
        /// </summary>
        public int Id => _id;
    }
}
