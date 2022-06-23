using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace IndividuallTask.Model
{
    public class Validator
    {
        /// <summary>
        /// Проверяет, что строка состоит только из букв английского алфавита.
        /// </summary>
        /// <param name="nameProperty"> Имя свойства, откуда был вызван метод. </param>
        /// <param name="value"> Строка. </param>
        /// <exception cref="System.ArgumentException"> Выбрасывается, если строка состоит не только из 
        /// букв английского алфавита
        /// </exception> 
        public static void AssertStringContainsOnlyLetters(string nameProperty, string value)
        {
            if (!Regex.IsMatch(value, @"^[a-zA-Z]+$"))
            {
                throw new System.ArgumentException($"Значение {nameProperty} должно состоять только из букв английского алфавита");
            }

        }

        /// <summary>
        /// Проверяет, что в строке не больше 200 символов.
        /// </summary>
        /// <param name="nameProperty"> Имя свойства, откуда был вызван метод. </param>
        /// <param name="value"> Строка. </param>
        public static void AssertNumberContainsNoMoreTwoHaundredDigit(string nameProperty, string value)
        {
            if (value.Length > 200)
            {
                throw new System.ArgumentException(
                    $" Количество символов значения {nameProperty} не должно быть больше 200");
            }
        }

        /// <summary>
        /// Проверяет, что в строке не больше 100 символов.
        /// </summary>
        /// <param name="nameProperty"> Имя свойства, откуда был вызван метод. </param>
        /// <param name="value"> Строка. </param>
        public static void AssertNumberContainsNoMoreOneHaundredDigit(string nameProperty, string value)
        {
            if (value.Length > 100)
            {
                throw new System.ArgumentException(
                    $" Количество символов значения {nameProperty} не должно быть больше 100");
            }
        }

        /// <summary>
        /// Проверяет, что число находится в определённом промежутке.
        /// </summary>
        /// <param name="nameProperty">Имя свойства, откуда был вызван метод.</param>
        /// <param name="value">Число.</param>
        /// <param name="min">Левая граница промежутка.</param>
        /// <param name="max">Правая граница промежутка.</param>
        public static void AssertValueInRange(string nameProperty, double value, double min, double max)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException($"Значение {nameProperty} не должно быть меньше {min} и превышать {max} ");
            }
        }
    }
}
