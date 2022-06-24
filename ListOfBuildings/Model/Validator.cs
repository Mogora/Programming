using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ListOfBuildings.Model
{
    public class Validator
    {
        /// <summary>
        /// Проверяет, что число находится в определённом промежутке.
        /// </summary>
        /// <param name="nameProperty">Имя свойства, откуда был вызван метод.</param>
        /// <param name="value">Число.</param>
        /// <param name="min">Левая граница промежутка.</param>
        /// <param name="max">Правая граница промежутка.</param>
        public static void AssertValueInRange(string nameProperty, double value, int min, int max)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException($"Значение {nameProperty} не должно быть меньше {min} и превышать {max} ");
            }
        }

        /// <summary>
        /// Проверяет, что в строке не больше 200 символов.
        /// </summary>
        /// <param name="nameProperty">Имя свойства, откуда был вызван метод.</param>
        /// <param name="value">Строка.</param>
        /// <exception cref="System.ArgumentException">Выбрасывается, если в строке больше 200 символов.</exception>
        public static void AssertNumberContainsNoMoreTwoHundredDigit(string nameProperty, string value)
        {
            if (value.Length > 200)
            {
                throw new System.ArgumentException($"У значения {nameProperty} строка не должна превышать 200 символов.");
            }
        }

        /// <summary>
        /// Проверяет, что в строке не больше 100 символов.
        /// </summary>
        /// <param name="nameProperty">Имя свойства, откуда был вызван метод.</param>
        /// <param name="value">Строка.</param>
        /// <exception cref="System.ArgumentException">Выбрасывается, если в строке больше 100 символов.</exception>
        public static void AssertNumberContainsNoMoreOneHundredDigit(string nameProperty, string value)
        {
            if (value.Length > 100)
            {
                throw new System.ArgumentException($"У значения {nameProperty} строка не должна превышать 100 символов.");
            }
        }

        // <summary>
        /// Проверяет, что строка состоит только из букв английского алфавита.
        /// </summary>
        /// <param name="nameProperty">Имя свойства, откуда был вызван метод.</param>
        /// <param name="value">Строка.</param>
        /// <exception cref="System.ArgumentException">Выбрасывается, если строка состоит не только из
        /// букв английского алфавита.</exception>
        public static void AssertStringContainsOnlyLetters(string nameProperty, string value)
        {
            if (!Regex.IsMatch(value, @"^[a-zA-Z]+$"))
            {
                throw new System.ArgumentException(
                    $"Значение {nameProperty} должно состоять только из букв английского алфавита.");
            }
        }
    }
}
