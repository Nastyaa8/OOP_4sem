namespace Lab1
{
    public partial class Form1 : Form
    {
        Calculator calculator_calories = new Calculator();

        public Form1()
        {
            InitializeComponent();
        }

        private void send_button_Click(object sender, EventArgs e)
        {
            try
            {
                bool isMan = man_radio.Checked;
                double weight = 0;
                weight = Convert.ToDouble(weight_textbox.Text);
                int height = 0;
                height = Convert.ToInt32(height_textbox.Text);
                int age = 0;
                age = Convert.ToInt32(age_textbox.Text);
                int days = 0;
                days = Convert.ToInt32(days_textbox.Text);
                double targetWeight = 0;
                targetWeight = Convert.ToDouble(newWeight_textbox.Text);
                if (age < 18 || height < 140 || height > 251 || weight < 28 || weight > 1000 || age > 120 || days <= 0 || targetWeight < 28 || targetWeight > 1000)
                {
                    MessageBox.Show("Введите правильные данные в поля ввода!");
                    return; // Выходим из функции

                }
                int target = 0;// 0 - поддержание, 1 - набор, -1 - снижение
                if ((!man_radio.Checked && !woman_radio.Checked) || (!maintain_weight.Checked && !more_weight.Checked && !less_weight.Checked))
                {
                    MessageBox.Show("Выберите один из нескольких вариантов");
                    return;
                }
                if (maintain_weight.Checked)
                    target = 0;
                else if (more_weight.Checked)
                    target = 1;
                else if (less_weight.Checked)
                    target = -1;
                calculator_calories.analyze_weight(isMan, weight, height, age, target, targetWeight, days, ref result_label);
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (UncorrectChooseException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void more_weight_CheckedChanged(object sender, EventArgs e)
        {
            if (more_weight.Checked)
            {
                newWeight_label.Visible = true;
                newWeight_textbox.Visible = true;
                days_label.Visible = true;
                days_textbox.Visible = true;
            }
            if (!more_weight.Checked)
            {
                newWeight_label.Visible = false;
                newWeight_textbox.Visible = false;
                days_label.Visible = false;
                days_textbox.Visible = false;
            }
        }

        private void less_weight_CheckedChanged(object sender, EventArgs e)
        {
            if (less_weight.Checked)
            {
                newWeight_label.Visible = true;//определяет, отображается ли элемент управления 
                newWeight_textbox.Visible = true;
                days_label.Visible = true;
                days_textbox.Visible = true;
            }
            if (!less_weight.Checked)
            {
                newWeight_label.Visible = false;
                newWeight_textbox.Visible = false;
                days_label.Visible = false;
                days_textbox.Visible = false;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void result_label_Click(object sender, EventArgs e)
        {

        }

        private void age_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void age_label_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void man_radio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void weight_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void newWeight_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void result_label_Click_1(object sender, EventArgs e)
        {

        }

        private void days_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void weight_textbox_Click(object sender, EventArgs e)
        {

        }

        private void gender_label_Click(object sender, EventArgs e)
        {

        }

        private void maintain_weight_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void woman_radio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void height_textbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}