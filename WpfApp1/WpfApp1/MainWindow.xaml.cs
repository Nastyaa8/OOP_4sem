using System.IO;
using System.Windows;
using System.Windows.Documents;

namespace RichTextBoxDemo
{
    public partial class MainWindow : Window
    {
        private const string FilePath = "richtext.txt";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            TextRange textRange = new TextRange(richTextBox.Document.ContentStart, richTextBox.Document.ContentEnd);
            using (FileStream fs = new FileStream(FilePath, FileMode.Create))
            {
                textRange.Save(fs, DataFormats.Text);
            }
        }

        private void LoadButton_Click(object sender, RoutedEventArgs e)
        {
            if (File.Exists(FilePath))
            {
                TextRange textRange = new TextRange(richTextBox.Document.ContentStart, richTextBox.Document.ContentEnd);
                using (FileStream fs = new FileStream(FilePath, FileMode.Open))
                {
                    textRange.Load(fs, DataFormats.Text);
                }
            }
            else
            {
                MessageBox.Show("Файл не найден.");
            }
        }
    }
}
