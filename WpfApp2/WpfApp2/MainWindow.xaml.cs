using System.Text.RegularExpressions;
using System.Windows;

namespace WpfApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MyTextBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            string text = MyTextBox.Text;

            if (Regex.IsMatch(text, "[A-Za-z]"))
            {
                ErrorTextBlock.Text = "Английские буквы запрещены!";
                MyTextBox.BorderBrush = System.Windows.Media.Brushes.Red;
                MyTextBox.BorderThickness = new Thickness(2);
            }
            else
            {
                ErrorTextBlock.Text = "";
                MyTextBox.ClearValue(System.Windows.Controls.Control.BorderBrushProperty);
                MyTextBox.ClearValue(System.Windows.Controls.Control.BorderThicknessProperty);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Вы ввели: " + MyTextBox.Text);
        }
    }
}
