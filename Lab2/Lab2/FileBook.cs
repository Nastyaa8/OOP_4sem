using System;

namespace Lab2
{
    [Serializable]
    public class FileBook
    {
        public string Genre { get; set; }
        public int Size { get; set; }
        public string Name { get; set; }
        public string PublishingHouse { get; set; }
        public decimal Price { get; set; }
        public int NumOfPages { get; set; }
        public int Year { get; set; }
        public Author Authors { get; set; }

        // Конструктор по умолчанию, необходим для десериализации JSON
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