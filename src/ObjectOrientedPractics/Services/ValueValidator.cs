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
        /// <param name="value"></param>
        /// <param name="maxLength"></param>
        /// <param name="nameProperty"></param>
        public static void AssertStringOnLength(string value, int maxLength, string propertyName)
        {
            if (value.Length > maxLength)
            {
                throw new ArgumentException(
                    $"Кол-во символов в строке {propertyName} не должно превышать {maxLength}");
            }
        }

        public static void AssertValueInRange(string nameProperty, double value, int minValue, int maxValue)
        {
            if (value < minValue || value > maxValue)
            {
                throw new ArgumentException ($"Значение {nameProperty} не должно " +
                    $"быть меньше {minValue} и превышать {maxValue} ");

            }
        }
    }
}
