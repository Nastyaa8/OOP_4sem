using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Lab2
{
    [Serializable]
    public class Author
    {
  
        [RegularExpression(@"^[А-ЯЁ][а-яё]+\s[А-ЯЁ][а-яё]+\s[А-ЯЁ][а-яё]+$", ErrorMessage = "Неправильный формат ФИО")]
        [Required]
        public string FIO { get; set; }
        [Required(ErrorMessage = "Пожалуйста, введите страну.")]
        public string Country { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "ID должен быть положительным числом.")]
        public int ID { get; set; }

        public Author() { }

        public Author(string fio, string country, int id)
        {
            FIO = fio;
            Country = country;
            ID = id;
        }

        public override string ToString()
        {
            return $"ФИО: {FIO}, Страна: {Country}, ID: {ID}";
        }

    }
}