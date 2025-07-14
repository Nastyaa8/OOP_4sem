using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab2
{
    public partial class Form1 : Form
    {
        private List<FileBook> bookFiles = new List<FileBook>();
        private readonly AuthorsForm _authorsForm = new AuthorsForm();
        private readonly SearchForm _searchForm = new SearchForm();
        private BindingSource bindingSource = new BindingSource();
        // Единицы измерения (например, мегабайты)
        private const double MB_FACTOR = 1024 * 1024;

        // Текущий размер файла (в байтах)
        private double _fileSizeInBytes = 0;

        // Минимальный и максимальный размер файла (в мегабайтах)
        private const int MIN_FILE_SIZE_MB = 1;
        private const int MAX_FILE_SIZE_MB = 100;

        public decimal Price { get; private set; }

        public Form1()
        {
            InitializeComponent();
            // Теперь bookFiles доступна здесь
            timerDateTime.Start();
            LoadBooksFromJson();
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
        private void timerDateTime_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabelDateTime.Text = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");
        }
        private void LoadBooksFromJson()
        {
            string filePath = @"D:\Универ\OOP\Lab3\Lab2\Lab2\JSON\Lab2.json"; // Замените на путь к вашему JSON файлу

            if (File.Exists(filePath))
            {
                try
                {
                    string json = File.ReadAllText(filePath);
                    bookFiles = JsonConvert.DeserializeObject<List<FileBook>>(json) ?? new List<FileBook>();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при загрузке книг из JSON: {ex.Message}");
                }
            }
        }

        private void UpdateObjectCountStatus()
        {
            toolStripStatusLabelObjectCount.Text = "Количество книг: " + bookFiles.Count; // Предполагаем, что bookList - это список FileBook
        }
        private void UpdateLastActionStatus(string action)
        {
            toolStripStatusLabelLastAction.Text = "Последнее действие: " + action;
        }
        private void SaveBooksToJson()
        {
            string filePath = @"D:\Универ\OOP\Lab3\Lab2\Lab2\JSON\Lab2.json"; // Замените на путь к вашему JSON файлу

            try
            {
                string json = JsonConvert.SerializeObject(bookFiles, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText(filePath, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении книг в JSON: {ex.Message}");
            }
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

            using (var reader = new StreamWriter(@"D:\Универ\OOP\Lab3\Lab2\Lab2\JSON\Lab2.json"))
            {
                string jsonString = JsonConvert.SerializeObject(BookFilesList);
                reader.Write(jsonString);
            }
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            var BookFilesList = new List<FileBook>();
            using (var reader = new StreamReader(@"D:\Универ\OOP\Lab3\Lab2\Lab2\JSON\Lab2.json"))
            {
                BookFilesList = JsonConvert.DeserializeObject<List<FileBook>>(reader.ReadToEnd());
            }

            foreach (var bookFile in BookFilesList)
                listBoxInfo.Items.Add(bookFile);
        }
        private void buttonLoadFromFile_Click(object sender, EventArgs e)
        {
            var BookFilesList = new List<FileBook>();
            using (var reader = new StreamReader(@"../../Json/DB.json"))
            {
                BookFilesList = JsonConvert.DeserializeObject<List<FileBook>>(reader.ReadToEnd());
            }

            foreach (var bookFile in BookFilesList) listBoxInfo.Items.Add(bookFile);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
           


            var name = textBoxName.Text;
            var size = (int)trackBarSize.Value;
            var numberOfPages = 0;
            decimal price ;
            string priceText = this.price.Text;
            string publishingHouse = "";
            string genre = "";
            int year = DateTime.Now.Year;
            string authorName = "";
            string authorCountry = "";
            int authorId = 0;
            // Пытаемся преобразовать текст в decimal
            if (decimal.TryParse(priceText, out price))
            {
                // Преобразование успешно
            }
            else
            {
                // Преобразование не удалось, сообщаем об ошибке
                MessageBox.Show("Неверный формат цены. Пожалуйста, введите число.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Прерываем выполнение метода или делаем что-то еще для обработки ошибки
            }

            int numOfPagesValue = 0;
            if (!int.TryParse(textBoxNumberOfPages.Text, out numOfPagesValue))
            {
                MessageBox.Show("Неверный формат количества страниц. Пожалуйста, введите целое число.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FileBook book = new FileBook
            {
                Genre = comboBoxGenre.Text,  // Замените на реальные имена ваших элементов управления
                Size = (int)trackBarSize.Value,
                Name = textBoxName.Text,
                PublishingHouse = textBoxPublishingHouse.Text,
                Price= price,
                NumOfPages = (int)textBoxNumberOfPages.Value,
                Year = dateTimePickerYear.Value.Year,
                // Пример, замените на ваши элементы управления
              
            };
            if (_authorsForm.CurrentAuthorsList == null) return;
            bookFiles.Add(book);
            UpdateObjectCountStatus();
            UpdateLastActionStatus("Книга добавлена");
            // 2. Выполните валидацию
            var results = new List<ValidationResult>();
            var context = new ValidationContext(book, serviceProvider: null, items: null);
            bool isValid = Validator.TryValidateObject(book, context, results, validateAllProperties: true);

            // 3. Обработайте результаты валидации
            if (isValid)
            {
                // Книга прошла валидацию, сохраняем
                MessageBox.Show("Книга успешно добавлена!");
              
            }
            else
            {
                // Книга не прошла валидацию, отображаем ошибки
                string errorMessage = string.Join(Environment.NewLine, results.Select(v => v.ErrorMessage));
                MessageBox.Show("Ошибка валидации:" + Environment.NewLine + errorMessage, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        
            //// Валидация:
            //if (string.IsNullOrWhiteSpace(textBoxName.Text))
            //{
            //    MessageBox.Show("Пожалуйста, введите название книги.");
            //    return;

            //}
            //if (string.IsNullOrWhiteSpace(textBoxPublishingHouse.Text))
            //{
            //    MessageBox.Show("Пожалуйста, введите название издательства.");
            //    return;
            //}

            //if (comboBoxGenre.SelectedItem == null)
            //{
            //    MessageBox.Show("Пожалуйста, выберите жанр.");
            //    return;
            //}
            //if (size < trackBarSize.Minimum) // Замените на логику, которая вам нужна
            //{
            //    MessageBox.Show("Пожалуйста, выберите размер файла.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    return;
            //}
            //if (string.IsNullOrWhiteSpace(textBoxNumberOfPages.Text))
            //{
            //    MessageBox.Show("Пожалуйста, введите количество страниц.");
            //    return;
            //}
            //if (string.IsNullOrWhiteSpace(textBoxPrice.Text))
            //{
            //    MessageBox.Show("Пожалуйста, введите цену книги.");
            //    return;
            //}
            //// Валидация длины текста
            //if (textBoxName.Text.Length > 100)
            //{
            //    MessageBox.Show("Название книги не должно превышать 100 символов.");
            //    return;
            //}
            //if (textBoxPublishingHouse.Text.Length > 50) // Более реалистичное ограничение
            //{
            //    MessageBox.Show("Название издательства не должно превышать 50 символов.");
            //    return;
            //}
            //if (trackBarSize.Text.Length > 10) // Более реалистичное ограничение
            //{
            //    MessageBox.Show("Размер файла не должен превышать 10 символов.");
            //    return;
            //}
            //if (textBoxNumberOfPages.Text.Length > 6) // Более реалистичное ограничение
            //{
            //    MessageBox.Show("Количество страниц не должно превышать 6 символов.");
            //    return;
            //}
            // Преобразование значений и обработка ошибок:
            try
            {
                name = textBoxName.Text;

             

                if (!int.TryParse(textBoxNumberOfPages.Text, out numberOfPages))
                {
                    MessageBox.Show("Неверный формат для количества страниц. Введите целое число.");
                    return;
                }

                if (decimal.TryParse(priceText, out price)) // Пытаемся преобразовать текст в decimal
                {
                    // Преобразование успешно, теперь price содержит числовое значение
                    Price = price; // Присваиваем значение переменной Price (типа decimal)
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

        private void поискToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _searchForm.Show();
            _searchForm.GetBookFilesFromBaseListbox(listBoxInfo.Items);
        }

        private void инструментыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip1.Visible = toolStrip1.Visible == false;
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Автор : Настяя8  , Версия : 1.0");
        }

        private void сортировкаToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void поНазваниюToolStripMenuItem_Click(object sender, EventArgs e)
        {
      
            var sortedBookFiles = listBoxInfo.Items.OfType<FileBook>().OrderBy(x => x.Name).ToList();//метод LINQ
            listBoxInfo.Items.Clear();

            foreach (var sortedBookFile in sortedBookFiles)
            {
                listBoxInfo.Items.Add(sortedBookFile);
            }
        }

        private void поИздательствуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sortedBookFiles = listBoxInfo.Items.OfType<FileBook>().OrderBy(x => x.PublishingHouse).ToList();//метод LINQ
            listBoxInfo.Items.Clear();

            foreach (var sortedBookFile in sortedBookFiles)
            {
                listBoxInfo.Items.Add(sortedBookFile);
            }
        }

        private void toolStripButtonDelete_Click(object sender, EventArgs e)
        {
            if (listBoxInfo.SelectedItem != null)
            {
                FileBook selectedBook = (FileBook)listBoxInfo.SelectedItem;

                // Удалите книгу из BindingSource (и, следовательно, из списка bookFiles)
                bindingSource.Remove(selectedBook);

                // Сохраниизменения в JSON файл
                SaveBooksToJson();

                MessageBox.Show($"Книга \"{selectedBook.Name}\" успешно удалена.");
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите книгу для удаления.");
            }
        }

      

       
    }
    }
