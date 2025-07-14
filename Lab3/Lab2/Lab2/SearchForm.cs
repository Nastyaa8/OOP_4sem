using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Lab2
{
    public partial class SearchForm: Form
    {
        private readonly List<FileBook> _bookFiles = new List<FileBook>();
        public SearchForm()
        {
            InitializeComponent();
        }
        public void GetBookFilesFromBaseListbox(ListBox.ObjectCollection items)
        {
            _bookFiles.Clear();
            foreach (object item in items) _bookFiles.Add(item as FileBook);
        }
        private void SearchForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxName.Text)) return;
            listBoxInfo.Items.Clear();

            string name = textBoxName.Text;

            foreach (var bookFile in _bookFiles.Where(bookFile => bookFile.Name == name))
            {
                listBoxInfo.Items.Add(bookFile);
            }
        }
        private void SearchForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            (sender as SearchForm).Hide();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxRangeOfPages.Text)) return;
            var regex = new Regex(@"^(\d+)-(\d+)$");
            if (regex.IsMatch(textBoxRangeOfPages.Text) == false)
            {
                MessageBox.Show("Неправильный формат ввода диапазона");
                return;
            }
            listBoxInfo.Items.Clear();
            var separatedNumbers = textBoxRangeOfPages.Text.Split('-');
            var firstNumber = int.Parse(separatedNumbers[0]);
            var secondNumber = int.Parse(separatedNumbers[1]);

            foreach (var bookFile in _bookFiles.Where(bookFile => bookFile.NumOfPages >= firstNumber && bookFile.NumOfPages <= secondNumber))
            {
                listBoxInfo.Items.Add(bookFile);
            }
        }

        private void listBoxInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedBookFile = ((ListBox)sender).SelectedItem as FileBook;

            if (selectedBookFile == null) return;
        }
    }
    }
    
    

