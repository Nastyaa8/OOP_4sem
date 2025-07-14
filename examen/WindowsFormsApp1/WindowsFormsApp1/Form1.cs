using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            string month = dateTimePicker1.Value.Month.ToString("D2");

            if (month == "01" || month == "02" || month == "12") this.Text = "Зима";
            else if (month == "03" || month == "04" || month == "05") this.Text = "Весна";
            else if (month == "06" || month == "07" || month == "08") this.Text = "Лето";
            else if (month == "09" || month == "10" || month == "11") this.Text = "Осень";
        }
    }
}

