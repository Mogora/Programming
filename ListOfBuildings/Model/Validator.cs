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
        /// Проверка на то, что строка по длине не больше, чем максимальная возможная длина.
        /// </summary>
        /// <param name="value"> Строка. </param>
        /// <param name="maxLength"> Максимальная длина. </param>
        /// <param name="nameProperty"> Имя свойства, откуда был вызван метод .</param>
        /// <exception cref="ArgumentException"> Выбрасывается, когда строка превышает максимально
        /// возможную длину.</exception>
        public static void NoMoreThan(string value, int maxLength, string nameProperty)
        {
            if (value.Length > maxLength)
            {
                throw new ArgumentException($"the value of the {nameProperty} more than {maxLength}");
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
