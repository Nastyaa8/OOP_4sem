using System;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp3
{
    public partial class MainWindow : Window
    {
        private bool flag = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void CelsiusInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (flag) return;

            if (double.TryParse(CelsiusInput.Text, out double celsius))
            {
                flag = true;
                double fahrenheit = celsius * 9 / 5 + 32;
                FahrenheitInput.Text = fahrenheit.ToString("F2");
                flag = false;
            }
            else if (string.IsNullOrWhiteSpace(CelsiusInput.Text))
            {
                flag = true;
                FahrenheitInput.Text = "";
                flag = false;
            }
        }

        private void FahrenheitInput_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (flag) return;

            if (double.TryParse(FahrenheitInput.Text, out double fahrenheit))
            {
                flag = true;
                double celsius = (fahrenheit - 32) * 5 / 9;
                CelsiusInput.Text = celsius.ToString("F2");
                flag = false;
            }
            else if (string.IsNullOrWhiteSpace(FahrenheitInput.Text))
            {
                flag = true;
                CelsiusInput.Text = "";
                flag = false;
            }
        
        }
    }
}

