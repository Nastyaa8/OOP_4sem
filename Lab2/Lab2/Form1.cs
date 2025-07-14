using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Lab2
{
    public partial class Form1 : Form
    {
        private readonly AuthorsForm _authorsForm = new AuthorsForm();
        // Единицы измерения (например, мегабайты)
        private const double MB_FACTOR = 1024 * 1024;

        // Текущий размер файла (в байтах)
        private double _fileSizeInBytes = 0;

        // Минимальный и максимальный размер файла (в мегабайтах)
        private const int MIN_FILE_SIZE_MB = 1;
        private const int MAX_FILE_SIZE_MB = 100;

        public Form1()
        {
            InitializeComponent();
            trackBarSize.Scroll += new EventHandler(trackBarSize_Scroll);
            // Настройка TrackBar
            trackBarSize.Minimum = MIN_FILE_SIZE_MB;
            trackBarSize.Maximum = MAX_FILE_SIZE_MB;
            trackBarSize.Value = MIN_FILE_SIZE_MB; // Начальное значение
            UpdateFileSize(); // Обновляем отображение размера файла при запуске
            label1.BackColor = System.Drawing.Color.Transparent;
          
            _authorsForm.Hide();

            // Инициализируем комбобокс с жанрами
            InitializeGenreComboBox();

            // Связываем BindingList с ListBox
          
            
            // Настраиваем DateTimePicker
           
        }
        private void InitializeGenreComboBox()
        {
            comboBoxGenre.Items.Add("Фантастика");
            comboBoxGenre.Items.Add("Детектив");
            comboBoxGenre.Items.Add("Роман");
            comboBoxGenre.Items.Add("Научная литература");
            comboBoxGenre.Items.Add("Ужасы");
            comboBoxGenre.Items.Add("Приключения");
         
            comboBoxGenre.DropDownStyle = ComboBoxStyle.DropDownList; // Запретить ввод текста, только выбор из списка
        }
        private void authors_Click(object sender, EventArgs e)
        {
            _authorsForm.ShowDialog();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            var BookFilesList = (from object item in listBoxInfo.Items select item as FileBook).ToList();

            using (var reader = new StreamWriter(@"D:\Универ\OOP\Lab2\Lab2\JSON\Lab2.json"))
            {
                string jsonString = JsonConvert.SerializeObject(BookFilesList);
                reader.Write(jsonString);
            }
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            var BookFilesList = new List<FileBook>();
            using (var reader = new StreamReader(@"D:\Универ\OOP\Lab2\Lab2\JSON\Lab2.json"))
            {
                BookFilesList = JsonConvert.DeserializeObject<List<FileBook>>(reader.ReadToEnd());
            }

            foreach (var bookFile in BookFilesList)
                listBoxInfo.Items.Add(bookFile);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (_authorsForm.CurrentAuthorsList == null) return;
            //if (Controls.OfType<RadioButton>().Any(r => r.Checked) == false) return;
            

            var name = "";
            var size = trackBarSize.Value;
            var numberOfPages = 0;
            decimal price = 0;
            string publishingHouse = "";
            string genre = "";
            int year = DateTime.Now.Year;
            string authorName = "";
            string authorCountry = "";
            int authorId = 0;
            // Валидация:
            if (string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                MessageBox.Show("Пожалуйста, введите название книги.");
                return;

            }
            if (string.IsNullOrWhiteSpace(textBoxPublishingHouse.Text))
            {
                MessageBox.Show("Пожалуйста, введите название издательства.");
                return;
            }

            if (comboBoxGenre.SelectedItem == null)
            {
                MessageBox.Show("Пожалуйста, выберите жанр.");
                return;
            }
            if (size < trackBarSize.Minimum) // Замените на логику, которая вам нужна
            {
                MessageBox.Show("Пожалуйста, выберите размер файла.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(textBoxNumberOfPages.Text))
            {
                MessageBox.Show("Пожалуйста, введите количество страниц.");
                return;
            }
            if (string.IsNullOrWhiteSpace(textBoxPrice.Text))
            {
                MessageBox.Show("Пожалуйста, введите цену книги.");
                return;
            }
            // Валидация длины текста
            if (textBoxName.Text.Length > 100)
            {
                MessageBox.Show("Название книги не должно превышать 100 символов.");
                return;
            }
            if (textBoxPublishingHouse.Text.Length > 50) // Более реалистичное ограничение
            {
                MessageBox.Show("Название издательства не должно превышать 50 символов.");
                return;
            }
            if (trackBarSize.Text.Length > 10) // Более реалистичное ограничение
            {
                MessageBox.Show("Размер файла не должен превышать 10 символов.");
                return;
            }
            if (textBoxNumberOfPages.Text.Length > 6) // Более реалистичное ограничение
            {
                MessageBox.Show("Количество страниц не должно превышать 6 символов.");
                return;
            }
            // Преобразование значений и обработка ошибок:
            try
            {
                name = textBoxName.Text;

             

                if (!int.TryParse(textBoxNumberOfPages.Text, out numberOfPages))
                {
                    MessageBox.Show("Неверный формат для количества страниц. Введите целое число.");
                    return;
                }
                if (!decimal.TryParse(textBoxPrice.Text, out price))
                {
                    MessageBox.Show("Неверный формат для цены книги. Введите число.");
                    return;
                }
                year = dateTimePickerYear.Value.Year;
                genre = comboBoxGenre.SelectedItem.ToString();
                name = textBoxName.Text;
                publishingHouse = textBoxPublishingHouse.Text;

            }
            catch (OverflowException)
            {
                MessageBox.Show("Числа великоваты");
                return;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return;
            }
            name = textBoxName.Text;
            genre = comboBoxGenre.SelectedItem.ToString();
            publishingHouse = textBoxPublishingHouse.Text; 
            year = dateTimePickerYear.Value.Year;
            // Получение информации об авторе из AuthorsForm
            if (_authorsForm.CurrentAuthorsList != null && _authorsForm.CurrentAuthorsList.Count > 0)
            {
                var author = _authorsForm.CurrentAuthorsList.FirstOrDefault();
                if (author != null)
                {
                    authorName = author.FIO;
                    authorCountry = author.Country;
                    authorId = author.ID;
                }
            }
            else
            {
                MessageBox.Show("Пожалуйста, добавьте информацию об авторе!");
                return;
            }
            var bookFile = new FileBook(genre, size, name, numberOfPages, year, price, publishingHouse, authorName, authorCountry, authorId);
            listBoxInfo.Items.Add(bookFile);

            _authorsForm.Clear();

        }

        private void textBoxSize_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == 8) return;
            e.Handled = true;
        }


        private void textBoxNumberOfPages_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == 8) return;
            e.Handled = true;
        }

        private void listBoxInfo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

       

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void издательство_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void жанр_книги_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNumberOfPages_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonCalculateRoyalties_Click(object sender, EventArgs e)
        {
            if (listBoxInfo.SelectedItem is FileBook selectedBook)
            {
                decimal royalties = selectedBook.CalculateAuthorRoyalties();
                MessageBox.Show($"Отчисления автору для книги '{selectedBook.Name}': {royalties:C}"); // :C форматирует как валюту
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите книгу из списка.");
            }
        }

        private void textBoxNumberOfPages_ValueChanged(object sender, EventArgs e)
        {

        }

        private void trackBarSize_Scroll(object sender, EventArgs e)
        {
            // 1. Получаем значение TrackBar (в мегабайтах)
            int sizeInMb = trackBarSize.Value;

            // 2. Преобразуем в размер файла (в байтах)
            _fileSizeInBytes = sizeInMb * MB_FACTOR;

            // 3. Обновляем отображение размера файла
            UpdateFileSize();

            // 4.  (Здесь вы должны использовать _fileSizeInBytes для создания файла или его размера)
            // Например:
            // CreateFileWithThisSize(_fileSizeInBytes);
        }
        // Метод для обновления отображения размера файла (например, в Label или TextBox)
        private void UpdateFileSize()
        {
            labelFileSize.Text = $"Размер файла: {(_fileSizeInBytes / MB_FACTOR):F2} MB"; // Отображаем в мегабайтах
        }

        private void labelFileSize_Click(object sender, EventArgs e)
        {

        }
    }
}