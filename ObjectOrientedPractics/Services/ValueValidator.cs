using System;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Класс для валидации значений
    /// </summary>
    public static class ValueValidator
    {
        /// <summary>
        /// Проверяет строку на максимальную длину
        /// </summary>
        public static void AssertStringOnLength(string value, int maxLength, string propertyName)
        {
            if (value != null && value.Length > maxLength)
            {
                throw new ArgumentException($"{propertyName} должен быть меньше {maxLength} символов");
            }
        }
    }
}