using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Services
{
    public static class ValueValidator
    {
        /// <summary>
        /// Проверка на то, что строка по длине не больше, чем максимально возможная длина.
        /// </summary>
        /// <param name="value">Строка.</param>
        /// <param name="maxLength">Максимальная длина.</param>
        /// <param name="nameProperty">Имя свойства, откуда был вызван метод.</param>
        public static void AssertStringOnLength(string value, int maxLength, string propertyName)
        {
            if (value.Length > maxLength)
            {
                throw new ArgumentException(
                    $"Кол-во символов в строке {propertyName} не должно превышать {maxLength}");
            }
        }

        /// <summary>
        /// Проверка на то, что значение находится в нужном диапозоне.
        /// </summary>
        /// <param name="nameProperty">Имя свойства, откуда был вызван метод.</param>
        /// <param name="value">Число</param>
        /// <param name="minValue">Минимальное значение.</param>
        /// <param name="maxValue">Максимальное значение.</param>
        public static void AssertValueInRange(string nameProperty, double value, int minValue, int maxValue)
        {
            if (value < minValue || value > maxValue)
            {
                throw new ArgumentException ($"Значение {nameProperty} не должно " +
                    $"быть меньше {minValue} и превышать {maxValue} ");

            }
        }

        /// <summary>
        /// Проверка на то, что строка имеет указанную длину.
        /// </summary>
        /// <param name="nameProperty">Имя свойства, откуда был вызван метод.</param>
        /// <param name="value">Число.</param>
        /// <param name="length">Заданная длина.</param>
        public static void AssertSpecifiedNumberCharacters(string nameProperty, int value, int length)
        {
            if(value.ToString().Length != length)
            {
                throw new ArgumentException($"Количество символов в строке {nameProperty} должно быть " +
                    $"равной 6");
            }
        }
    }
}
