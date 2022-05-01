using System;
using System.Collections.Generic;
using System.Text;

namespace Programming.Model
{
    public static class Validator
    {
        public static void AssertOnPositiveValue(string nameProperty, int value)
        {
            if (value <= 0)
            {
                throw new ArgumentException($"Значение {nameProperty} не должно быть отрицательным");
            }
        }

        public static void AssertOnPositiveValue(string nameProperty, float value)
        {
            if (value <= 0)
            {
                throw new ArgumentException($"Значение {nameProperty} не должно быть отрицательным");
            }
        }

         public static void AssertValueInRange(string nameProperty, int value, int min, int max)
         {
            if (value < min || value > max)
            {
                throw new ArgumentException($"Значение {nameProperty} не должно быть меньше {min} и превышать {max} ");
            }
         }

        public static void AssertValueInRange(string nameProperty, float value, int min, int max)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException($"Значение {nameProperty} не должно быть меньше {min} и превышать {max} ");
            }
        }

    }
}
