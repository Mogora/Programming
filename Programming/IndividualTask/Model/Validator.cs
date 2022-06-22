using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace IndividualTask.Model
{
    public class Validator
    {
        /// <summary>
        /// Проверяет, что строка состоит только из букв английского алфавита.
        /// </summary>
        /// <param name="nameProperty"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public string AssertStringContainsOnlyLetters(string nameProperty, string value)
        {
            if (!Regex.IsMatch(value, @"^[a-zA-Z]+$"))
            {
                throw new System.ArgumentException($"Значение {nameProperty} должно состоять только из букв английского алфавита");
            }
            return value;
        }

        /// <summary>
        /// Проверяет, что строка содержит не больше 200 символов.
        /// </summary>
        /// <param name="nameProperty"></param>
        /// <param name="value"></param>
        public static void AssertNumberContainsNoMoreTwoHundredDigit(string nameProperty, string value)
        {
            if (value.Length > 200)
            {
                throw new System.ArgumentException(
                    $" Значение {nameProperty} не должно");
            }
        }
    }
}
