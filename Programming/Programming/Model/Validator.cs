using System;
using System.Collections.Generic;
using System.Text;

namespace Programming.Model
{
    /// <summary>
    /// Предоставляет методы для проверки входных данных.
    /// </summary>
    public static class Validator
    {
        /// <summary>
        /// Проверяет, является ли число положительным.
        /// </summary>
        /// <param name="nameProperty"> Имя свойства, откуда был вызван метод. </param>
        /// <param name="value"> Число. </param>
        public static void AssertOnPositiveValue(string nameProperty, int value)
        {
            if (value < 0)
            {
                throw new ArgumentException($"Значение {nameProperty} не должно быть отрицательным");
            }
        }

        /// <summary>
        /// Проверяет, является ли число положительным.
        /// </summary>
        /// <param name="nameProperty"> Имя свойства, откуда был вызван метод. </param>
        /// <param name="value"> Число. </param>
        public static void AssertOnPositiveValue(string nameProperty, double value)
        {
            if (value < 0)
            {
                throw new ArgumentException($"Значение {nameProperty} не должно быть отрицательным");
            }
        }

        /// <summary>
        /// Проверяет, что число находится в определённом промежутке.
        /// </summary>
        /// <param name="nameProperty">Имя свойства, откуда был вызван метод.</param>
        /// <param name="value">Число.</param>
        /// <param name="min">Левая граница промежутка.</param>
        /// <param name="max">Правая граница промежутка.</param>
        public static void AssertValueInRange(string nameProperty, int value, int min, int max)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException($"Значение {nameProperty} не должно быть меньше {min} и превышать {max} ");
            }
        }

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
