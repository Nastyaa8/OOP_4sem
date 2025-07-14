using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false, Inherited = true)]
    public class YearNotInFutureAttribute : ValidationAttribute // 1. Наследуемся от ValidationAttribute
    {
        public YearNotInFutureAttribute() : base("Год издания не может быть в будущем.") // 2. Вызываем конструктор базового класса
        {
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext) // 3. Правильная сигнатура метода
        {
            if (value == null)
            {
                return ValidationResult.Success; // Считаем null допустимым, если Required используется
            }

            if (!(value is int year))
            {
                return new ValidationResult("Значение года должно быть целым числом.");
            }

            if (year > DateTime.Now.Year)
            {
                return new ValidationResult(ErrorMessageString); // Используем сообщение об ошибке, установленное в конструкторе
            }

            return ValidationResult.Success; // Валидация прошла успешно
        }
    }
}