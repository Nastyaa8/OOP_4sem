namespace Lab1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            send_button = new Button();
            weight_textbox = new TextBox();
            age_textbox = new TextBox();
            height_textbox = new TextBox();
            gender_label = new Label();
            weight_label = new Label();
            height_label = new Label();
            age_label = new Label();
            man_radio = new RadioButton();
            woman_radio = new RadioButton();
            result_label = new Label();
            more_weight = new RadioButton();
            less_weight = new RadioButton();
            maintain_weight = new RadioButton();
            newWeight_label = new Label();
            days_label = new Label();
            newWeight_textbox = new TextBox();
            days_textbox = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // send_button
            // 
            send_button.BackColor = Color.MediumPurple;
            send_button.Location = new Point(213, 491);
            send_button.Name = "send_button";
            send_button.Size = new Size(107, 50);
            send_button.TabIndex = 0;
            send_button.Text = "отправить";
            send_button.UseVisualStyleBackColor = false;
            send_button.Click += send_button_Click;
            // 
            // weight_textbox
            // 
            weight_textbox.BorderStyle = BorderStyle.None;
            weight_textbox.Location = new Point(12, 203);
            weight_textbox.Name = "weight_textbox";
            weight_textbox.Size = new Size(300, 20);
            weight_textbox.TabIndex = 2;
            weight_textbox.Click += weight_textbox_Click;
            weight_textbox.TextChanged += weight_textbox_TextChanged;
            // 
            // age_textbox
            // 
            age_textbox.BorderStyle = BorderStyle.None;
            age_textbox.Location = new Point(12, 333);
            age_textbox.Name = "age_textbox";
            age_textbox.Size = new Size(300, 20);
            age_textbox.TabIndex = 3;
            // 
            // height_textbox
            // 
            height_textbox.BorderStyle = BorderStyle.None;
            height_textbox.Location = new Point(12, 267);
            height_textbox.Name = "height_textbox";
            height_textbox.Size = new Size(300, 20);
            height_textbox.TabIndex = 4;
            height_textbox.TextChanged += height_textbox_TextChanged;
            // 
            // gender_label
            // 
            gender_label.AutoSize = true;
            gender_label.Location = new Point(136, 134);
            gender_label.Name = "gender_label";
            gender_label.Size = new Size(37, 20);
            gender_label.TabIndex = 5;
            gender_label.Text = "Пол";
            gender_label.Click += gender_label_Click;
            // 
            // weight_label
            // 
            weight_label.AutoSize = true;
            weight_label.Location = new Point(136, 178);
            weight_label.Name = "weight_label";
            weight_label.Size = new Size(33, 20);
            weight_label.TabIndex = 6;
            weight_label.Text = "Вес";
            // 
            // height_label
            // 
            height_label.AutoSize = true;
            height_label.Location = new Point(136, 244);
            height_label.Name = "height_label";
            height_label.Size = new Size(39, 20);
            height_label.TabIndex = 7;
            height_label.Text = "Рост";
            // 
            // age_label
            // 
            age_label.AutoSize = true;
            age_label.Location = new Point(121, 310);
            age_label.Name = "age_label";
            age_label.Size = new Size(64, 20);
            age_label.TabIndex = 8;
            age_label.Text = "Возраст";
            age_label.Click += age_label_Click;
            // 
            // man_radio
            // 
            man_radio.AutoSize = true;
            man_radio.Location = new Point(187, 156);
            man_radio.Name = "man_radio";
            man_radio.Size = new Size(93, 24);
            man_radio.TabIndex = 9;
            man_radio.TabStop = true;
            man_radio.Text = "Мужской";
            man_radio.UseVisualStyleBackColor = true;
            man_radio.CheckedChanged += man_radio_CheckedChanged;
            // 
            // woman_radio
            // 
            woman_radio.AutoSize = true;
            woman_radio.Location = new Point(25, 156);
            woman_radio.Name = "woman_radio";
            woman_radio.Size = new Size(92, 24);
            woman_radio.TabIndex = 10;
            woman_radio.TabStop = true;
            woman_radio.Text = "Женский";
            woman_radio.UseVisualStyleBackColor = true;
            woman_radio.CheckedChanged += woman_radio_CheckedChanged;
            // 
            // result_label
            // 
            result_label.AutoSize = true;
            result_label.BackColor = Color.White;
            result_label.Location = new Point(12, 20);
            result_label.MinimumSize = new Size(300, 100);
            result_label.Name = "result_label";
            result_label.Size = new Size(300, 100);
            result_label.TabIndex = 15;
            result_label.Click += result_label_Click_1;
            // 
            // more_weight
            // 
            more_weight.AutoSize = true;
            more_weight.Location = new Point(6, 50);
            more_weight.Name = "more_weight";
            more_weight.Size = new Size(149, 24);
            more_weight.TabIndex = 12;
            more_weight.TabStop = true;
            more_weight.Text = "Увеличение веса";
            more_weight.UseVisualStyleBackColor = true;
            more_weight.CheckedChanged += more_weight_CheckedChanged;
            // 
            // less_weight
            // 
            less_weight.AutoSize = true;
            less_weight.Location = new Point(6, 80);
            less_weight.Name = "less_weight";
            less_weight.Size = new Size(137, 24);
            less_weight.TabIndex = 13;
            less_weight.TabStop = true;
            less_weight.Text = "Снижение веса";
            less_weight.UseVisualStyleBackColor = true;
            less_weight.CheckedChanged += less_weight_CheckedChanged;
            // 
            // maintain_weight
            // 
            maintain_weight.AutoSize = true;
            maintain_weight.Location = new Point(6, 26);
            maintain_weight.Name = "maintain_weight";
            maintain_weight.Size = new Size(163, 24);
            maintain_weight.TabIndex = 11;
            maintain_weight.TabStop = true;
            maintain_weight.Text = "Поддержание веса";
            maintain_weight.UseVisualStyleBackColor = true;
            maintain_weight.CheckedChanged += maintain_weight_CheckedChanged;
            // 
            // newWeight_label
            // 
            newWeight_label.AutoSize = true;
            newWeight_label.Location = new Point(215, 16);
            newWeight_label.Name = "newWeight_label";
            newWeight_label.Size = new Size(33, 20);
            newWeight_label.TabIndex = 14;
            newWeight_label.Text = "Вес";
            newWeight_label.Visible = false;
            // 
            // days_label
            // 
            days_label.AutoSize = true;
            days_label.Location = new Point(188, 69);
            days_label.Name = "days_label";
            days_label.Size = new Size(101, 20);
            days_label.TabIndex = 15;
            days_label.Text = "Срок (в днях)";
            days_label.Visible = false;
            // 
            // newWeight_textbox
            // 
            newWeight_textbox.CausesValidation = false;
            newWeight_textbox.Location = new Point(175, 39);
            newWeight_textbox.Name = "newWeight_textbox";
            newWeight_textbox.Size = new Size(125, 27);
            newWeight_textbox.TabIndex = 16;
            newWeight_textbox.Visible = false;
            newWeight_textbox.TextChanged += newWeight_textbox_TextChanged;
            // 
            // days_textbox
            // 
            days_textbox.CausesValidation = false;
            days_textbox.Location = new Point(175, 92);
            days_textbox.Name = "days_textbox";
            days_textbox.Size = new Size(125, 27);
            days_textbox.TabIndex = 17;
            days_textbox.Visible = false;
            days_textbox.TextChanged += days_textbox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(76, 0);
            label1.Name = "label1";
            label1.Size = new Size(159, 20);
            label1.TabIndex = 18;
            label1.Text = "Калькулятор калорий";
            label1.Click += label1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(maintain_weight);
            groupBox1.Controls.Add(more_weight);
            groupBox1.Controls.Add(days_textbox);
            groupBox1.Controls.Add(newWeight_label);
            groupBox1.Controls.Add(days_label);
            groupBox1.Controls.Add(less_weight);
            groupBox1.Controls.Add(newWeight_textbox);
            groupBox1.Location = new Point(12, 360);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(308, 125);
            groupBox1.TabIndex = 19;
            groupBox1.TabStop = false;
            groupBox1.Text = "Цель";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(332, 553);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(result_label);
            Controls.Add(woman_radio);
            Controls.Add(man_radio);
            Controls.Add(age_label);
            Controls.Add(height_label);
            Controls.Add(weight_label);
            Controls.Add(gender_label);
            Controls.Add(height_textbox);
            Controls.Add(age_textbox);
            Controls.Add(weight_textbox);
            Controls.Add(send_button);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button send_button;
        private TextBox weight_textbox;
        private TextBox age_textbox;
        private TextBox height_textbox;
        private Label gender_label;
        private Label weight_label;
        private Label height_label;
        private Label age_label;
        private RadioButton man_radio;
        private RadioButton woman_radio;
        private Label result_label;
        private RadioButton more_weight;
        private RadioButton less_weight;
        private RadioButton maintain_weight;
        private Label newWeight_label;
        private Label days_label;
        private TextBox newWeight_textbox;
        private TextBox days_textbox;
        private Label label1;
        private GroupBox groupBox1;

        /////
        public Button Send_button
        {
            get { return send_button;}
        }
        public TextBox Weight_textbox
        {
            get { return weight_textbox;}
        }
        public TextBox Age_textbox
        { get { return age_textbox; } }
public TextBox Height_textbox {get{ return height_textbox;}}
public RadioButton Man_radio { get { return man_radio;} }
public RadioButton Woman_radio { get { return woman_radio; } }
public RadioButton Maintain_weight { get { return maintain_weight; } }
public RadioButton More_weight { get { return more_weight; } }
public RadioButton Less_weight { get { return less_weight; } }
public TextBox Days_textbox { get { return days_textbox; } }
public TextBox NewWeight_textbox { get { return newWeight_textbox; } }
public Label Result_label { get { return result_label; } }
    }
}