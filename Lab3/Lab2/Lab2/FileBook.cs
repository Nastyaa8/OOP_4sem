using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
namespace Lab2
{
    [Serializable]
    public class FileBook
    {
        [Required]
        //Валидация для всех полей
        
        public string Genre { get; set; }
        [Required]
        [Range(1, 100, ErrorMessage = "Превышение значение размера")]
        public int Size { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Длина названия от 3 до 50")]
        public string Name { get; set; }

        [StringLength(100, ErrorMessage = "Длина издательства не должна превышать 100 символов")] 
        public string PublishingHouse { get; set; }
        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Цена должна быть положительным числом")] 
        public decimal Price { get; set; }

        [Required]
        [Range(1, 1000, ErrorMessage = "Значение числа страниц от 1 до 1000 ")]
        public int NumOfPages { get; set; }

      
        [YearNotInFuture]
        public int Year { get; set; }

        [Required(ErrorMessage = "Автор обязателен для заполнения")]
        public Author Authors { get; set; }
        public string FilePath { get; set; }


        public FileBook() { }

        public FileBook(string genre, int size, string name, int numofpages, int year, decimal price, string publishingHouse, string fio, string country, int id)
        {
            Genre = genre;
            Size = size;
            Name = name;
            NumOfPages = numofpages;
            Year = year;
            Price = price;
            PublishingHouse = publishingHouse;
            Authors = new Author(fio, country, id);
        }

        public override string ToString()
        {
            return $"Name: {Name}, Genre: {Genre}, size: {Size},Year: {Year}, Price: {Price}, PublishingHouse: {PublishingHouse}, Author: {Authors?.FIO},numofpages: {NumOfPages}";
        }
        // Метод для расчета отчислений автору
        public decimal CalculateAuthorRoyalties(decimal royaltyPercentage = 0.10m) // 10% по умолчанию
        {
            return Price * royaltyPercentage;
        }
    }
}