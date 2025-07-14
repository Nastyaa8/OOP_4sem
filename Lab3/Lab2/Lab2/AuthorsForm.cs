using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Lab2
{
    public partial class AuthorsForm : Form
    {



        public AuthorsForm()
        {
            InitializeComponent();
            CurrentAuthorsList = new List<Author>();
        }
        public List<Author> CurrentAuthorsList { get; private set; }


        private bool ValidateCountryName(string country)
        {
            if (string.IsNullOrWhiteSpace(country))
            {
                MessageBox.Show("Пожалуйста, введите название страны.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Проверка, что страна начинается с заглавной буквы
            if (!char.IsUpper(country[0]))
            {
                MessageBox.Show("Название страны должно начинаться с заглавной буквы.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // Улучшенное регулярное выражение для проверки названия страны (только буквы, пробелы и дефисы)
            if (!Regex.IsMatch(country, @"^[А-ЯЁ][А-Яа-яё\s-]*$"))  
            {
                MessageBox.Show("Название страны должно содержать только буквы русского алфавита, пробелы и дефисы.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
    

        private bool ValidateAuthorName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Пожалуйста, введите ФИО автора.");
                return false;
            }

            // Проверка формата ФИО: "Фамилия Имя Отчество"
            string[] parts = name.Split(' ');
            if (parts.Length != 3)
            {
                MessageBox.Show("Пожалуйста, введите ФИО автора в формате 'Фамилия Имя Отчество'.");
                return false;
            }

            // Проверяем каждую часть ФИО (Фамилию, Имя, Отчество)
            for (int i = 0; i < parts.Length; i++)
            {
                string part = parts[i];

                if (string.IsNullOrEmpty(part))
                {
                    MessageBox.Show("Все части ФИО должны быть заполнены.");
                    return false;
                }

                // Проверка, что каждая часть начинается с заглавной буквы
                if (!char.IsUpper(part[0]))
                {
                    MessageBox.Show("Каждая часть ФИО должна начинаться с заглавной буквы.");
                    return false;
                }

                // Проверка отчества: должно заканчиваться на "-вич" или "-вна"
                if (i == 2) // Если это отчество (третья часть)
                {
                    if (!Regex.IsMatch(part, "^[А-ЯЁ][а-яё-]+(вич|вна|ич)$"))
                    {
                        MessageBox.Show("Отчество должно содержать только буквы, возможно дефис и заканчиваться на -вич или -вна.");
                        return false;
                    }
                }
                else // Проверка имени и фамилии: только буквы и дефис
                {
                    if (!Regex.IsMatch(part, "^[А-ЯЁ][а-яё-]+$"))
                    {
                        MessageBox.Show("ФИО должно содержать только буквы и, возможно, дефис.");
                        return false;
                    }
                }
            }

            return true;
        }

        private void buttonAddAuthor_Click(object sender, EventArgs e)
        {
            // 1. Получаем значения из текстовых полей
            string fioText = textBoxName.Text;
            string countryText = textBoxCountry.Text;
            string idText = textBoxID.Text;

            // 2. Преобразуем ID в int и проверяем
            if (!int.TryParse(idText, out int idValue))
            {
                MessageBox.Show("Пожалуйста, введите корректный ID (целое число).", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Вызываем валидацию ФИО
            if (!ValidateAuthorName(fioText))
            {
                return; // Прерываем добавление автора, если ФИО не прошло валидацию
            }
            // Вызываем валидацию страны перед созданием объекта Author
            if (!ValidateCountryName(countryText))
            {
                return; // Прерываем добавление автора, если страна не прошла валидацию
            }
            // 3. Создаем экземпляр Author
            var author = new Author(fioText, countryText, idValue);
            // 4. Проверяем, существует ли уже такой автор в списке
            if (CurrentAuthorsList.Any(a => a.FIO == author.FIO && a.Country == author.Country && a.ID == author.ID))
            {
                MessageBox.Show("Такой автор уже существует в списке.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Прерываем добавление автора
            }
            // 4. Создаем ValidationContext и результаты
            var context = new ValidationContext(author, serviceProvider: null, items: null);
            var results = new List<ValidationResult>();

            // 5. Выполняем валидацию
            bool isValid = Validator.TryValidateObject(author, context, results, validateAllProperties: true);

            // 6. Обрабатываем результаты валидации
            if (isValid)
            {
                // Валидация прошла успешно, добавляем автора в список
                CurrentAuthorsList.Add(author);
                listBoxAuthors.Items.Add(author);
                MessageBox.Show("Автор успешно добавлен!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearTextBoxes(); // Очищаем только текстовые поля
            }
            else
            {
                // Валидация не прошла, отображаем сообщения об ошибках
                string errorMessage = "";
                foreach (var result in results)
                {
                    errorMessage += result.ErrorMessage + Environment.NewLine;
                }
                MessageBox.Show(errorMessage, "Ошибка валидации", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClearTextBoxes()
        {
            foreach (Control c in Controls)
            {
                if (c is GroupBox groupBox)
                {
                    foreach (Control control in groupBox.Controls)
                    {
                        if (control is TextBox textBox)
                        {
                            textBox.Text = string.Empty;
                        }
                    }
                }
                else if (c is TextBox textBox)
                {
                    textBox.Text = string.Empty;
                }
            }
        }

        public void Clear()
        {
            CurrentAuthorsList.Clear();
            listBoxAuthors.Items.Clear();
            ClearTextBoxes();
        }
        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            Hide();
        }
      
        private void textBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 32) return;
            e.Handled = true;
        }

        private void textBoxID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == 8) return;
            e.Handled = true;
        }

        private void textBoxCountry_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == 8 || e.KeyChar == 32) return;
            e.Handled = true;
        }

        private void listBoxAuthors_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AuthorsForm_Load(object sender, EventArgs e)
        {

        }

        private void textBoxID_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
