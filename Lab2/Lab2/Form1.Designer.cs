
namespace Lab2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.authors = new System.Windows.Forms.Button();
            this.listBoxInfo = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelFileSize = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxGenre = new System.Windows.Forms.ComboBox();
            this.textBoxPublishingHouse = new System.Windows.Forms.TextBox();
            this.год = new System.Windows.Forms.Label();
            this.Стоимость_книги = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.dateTimePickerYear = new System.Windows.Forms.DateTimePicker();
            this.buttonCalculateRoyalties = new System.Windows.Forms.Button();
            this.textBoxNumberOfPages = new System.Windows.Forms.NumericUpDown();
            this.trackBarSize = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxNumberOfPages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSize)).BeginInit();
            this.SuspendLayout();
            // 
            // authors
            // 
            this.authors.BackColor = System.Drawing.SystemColors.ControlLight;
            this.authors.Cursor = System.Windows.Forms.Cursors.Hand;
            this.authors.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.authors.FlatAppearance.BorderSize = 0;
            this.authors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.authors.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authors.Location = new System.Drawing.Point(448, 396);
            this.authors.Name = "authors";
            this.authors.Size = new System.Drawing.Size(140, 63);
            this.authors.TabIndex = 1;
            this.authors.Text = "Авторы";
            this.authors.UseVisualStyleBackColor = false;
            this.authors.Click += new System.EventHandler(this.authors_Click);
            // 
            // listBoxInfo
            // 
            this.listBoxInfo.FormattingEnabled = true;
            this.listBoxInfo.HorizontalScrollbar = true;
            this.listBoxInfo.ItemHeight = 16;
            this.listBoxInfo.Location = new System.Drawing.Point(443, 78);
            this.listBoxInfo.Name = "listBoxInfo";
            this.listBoxInfo.ScrollAlwaysVisible = true;
            this.listBoxInfo.Size = new System.Drawing.Size(519, 212);
            this.listBoxInfo.TabIndex = 2;
            this.listBoxInfo.SelectedIndexChanged += new System.EventHandler(this.listBoxInfo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(1, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 34);
            this.label1.TabIndex = 3;
            this.label1.Text = "Жанр книги ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelFileSize
            // 
            this.labelFileSize.AutoSize = true;
            this.labelFileSize.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFileSize.ForeColor = System.Drawing.SystemColors.InfoText;
            this.labelFileSize.Location = new System.Drawing.Point(1, 119);
            this.labelFileSize.Name = "labelFileSize";
            this.labelFileSize.Size = new System.Drawing.Size(203, 34);
            this.labelFileSize.TabIndex = 8;
            this.labelFileSize.Text = "Размер файла(мб)";
            this.labelFileSize.Click += new System.EventHandler(this.labelFileSize_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxName.Location = new System.Drawing.Point(221, 175);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(175, 26);
            this.textBoxName.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label3.Location = new System.Drawing.Point(1, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 34);
            this.label3.TabIndex = 10;
            this.label3.Text = "Название книги";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Font = new System.Drawing.Font("Monotype Corsiva", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLoad.Location = new System.Drawing.Point(631, 330);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(145, 52);
            this.buttonLoad.TabIndex = 12;
            this.buttonLoad.Text = "Загрузить";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Monotype Corsiva", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.Location = new System.Drawing.Point(817, 330);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(145, 52);
            this.buttonSave.TabIndex = 13;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Monotype Corsiva", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(443, 330);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(145, 52);
            this.buttonAdd.TabIndex = 14;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label4.Location = new System.Drawing.Point(1, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 34);
            this.label4.TabIndex = 17;
            this.label4.Text = "Кол-во страниц";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label5.Location = new System.Drawing.Point(1, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 34);
            this.label5.TabIndex = 15;
            this.label5.Text = "Издательство";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Monotype Corsiva", 22.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label6.Location = new System.Drawing.Point(318, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(376, 45);
            this.label6.TabIndex = 20;
            this.label6.Text = "Электронная библиотека";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label7.Location = new System.Drawing.Point(841, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 34);
            this.label7.TabIndex = 21;
            // 
            // comboBoxGenre
            // 
            this.comboBoxGenre.Font = new System.Drawing.Font("Monotype Corsiva", 14F);
            this.comboBoxGenre.FormattingEnabled = true;
            this.comboBoxGenre.Location = new System.Drawing.Point(221, 78);
            this.comboBoxGenre.Name = "comboBoxGenre";
            this.comboBoxGenre.Size = new System.Drawing.Size(175, 35);
            this.comboBoxGenre.TabIndex = 22;
            this.comboBoxGenre.SelectedIndexChanged += new System.EventHandler(this.жанр_книги_SelectedIndexChanged);
            // 
            // textBoxPublishingHouse
            // 
            this.textBoxPublishingHouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPublishingHouse.Location = new System.Drawing.Point(221, 288);
            this.textBoxPublishingHouse.Name = "textBoxPublishingHouse";
            this.textBoxPublishingHouse.Size = new System.Drawing.Size(175, 26);
            this.textBoxPublishingHouse.TabIndex = 23;
            this.textBoxPublishingHouse.TextChanged += new System.EventHandler(this.издательство_TextChanged);
            // 
            // год
            // 
            this.год.AutoSize = true;
            this.год.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.год.ForeColor = System.Drawing.SystemColors.InfoText;
            this.год.Location = new System.Drawing.Point(1, 339);
            this.год.Name = "год";
            this.год.Size = new System.Drawing.Size(143, 34);
            this.год.TabIndex = 24;
            this.год.Text = "Год издания";
            // 
            // Стоимость_книги
            // 
            this.Стоимость_книги.AutoSize = true;
            this.Стоимость_книги.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Стоимость_книги.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Стоимость_книги.Location = new System.Drawing.Point(1, 396);
            this.Стоимость_книги.Name = "Стоимость_книги";
            this.Стоимость_книги.Size = new System.Drawing.Size(204, 34);
            this.Стоимость_книги.TabIndex = 25;
            this.Стоимость_книги.Text = "Стоимость книги";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPrice.Location = new System.Drawing.Point(221, 402);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(175, 26);
            this.textBoxPrice.TabIndex = 26;
            this.textBoxPrice.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dateTimePickerYear
            // 
            this.dateTimePickerYear.CustomFormat = "yyyy";
            this.dateTimePickerYear.Font = new System.Drawing.Font("Monotype Corsiva", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePickerYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerYear.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePickerYear.Location = new System.Drawing.Point(221, 339);
            this.dateTimePickerYear.MaxDate = new System.DateTime(2025, 2, 26, 0, 0, 0, 0);
            this.dateTimePickerYear.MinDate = new System.DateTime(1920, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerYear.Name = "dateTimePickerYear";
            this.dateTimePickerYear.Size = new System.Drawing.Size(175, 34);
            this.dateTimePickerYear.TabIndex = 19;
            this.dateTimePickerYear.Value = new System.DateTime(2025, 2, 1, 0, 0, 0, 0);
            // 
            // buttonCalculateRoyalties
            // 
            this.buttonCalculateRoyalties.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic);
            this.buttonCalculateRoyalties.Location = new System.Drawing.Point(651, 403);
            this.buttonCalculateRoyalties.Name = "buttonCalculateRoyalties";
            this.buttonCalculateRoyalties.Size = new System.Drawing.Size(267, 49);
            this.buttonCalculateRoyalties.TabIndex = 27;
            this.buttonCalculateRoyalties.Text = "Отчисления автору";
            this.buttonCalculateRoyalties.UseVisualStyleBackColor = true;
            this.buttonCalculateRoyalties.Click += new System.EventHandler(this.buttonCalculateRoyalties_Click);
            // 
            // textBoxNumberOfPages
            // 
            this.textBoxNumberOfPages.Location = new System.Drawing.Point(221, 234);
            this.textBoxNumberOfPages.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.textBoxNumberOfPages.Name = "textBoxNumberOfPages";
            this.textBoxNumberOfPages.Size = new System.Drawing.Size(175, 22);
            this.textBoxNumberOfPages.TabIndex = 28;
            this.textBoxNumberOfPages.ValueChanged += new System.EventHandler(this.textBoxNumberOfPages_ValueChanged);
            this.textBoxNumberOfPages.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumberOfPages_KeyPress);
            // 
            // trackBarSize
            // 
            this.trackBarSize.Location = new System.Drawing.Point(292, 115);
            this.trackBarSize.Name = "trackBarSize";
            this.trackBarSize.Size = new System.Drawing.Size(104, 56);
            this.trackBarSize.TabIndex = 29;
            this.trackBarSize.Scroll += new System.EventHandler(this.trackBarSize_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(987, 599);
            this.Controls.Add(this.trackBarSize);
            this.Controls.Add(this.textBoxNumberOfPages);
            this.Controls.Add(this.buttonCalculateRoyalties);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.Стоимость_книги);
            this.Controls.Add(this.год);
            this.Controls.Add(this.textBoxPublishingHouse);
            this.Controls.Add(this.comboBoxGenre);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePickerYear);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelFileSize);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxInfo);
            this.Controls.Add(this.authors);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Electronic Library";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textBoxNumberOfPages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button authors;
        private System.Windows.Forms.ListBox listBoxInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelFileSize;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxGenre;
        private System.Windows.Forms.TextBox textBoxPublishingHouse;
        private System.Windows.Forms.Label год;
        private System.Windows.Forms.Label Стоимость_книги;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.DateTimePicker dateTimePickerYear;
        private System.Windows.Forms.Button buttonCalculateRoyalties;
        private System.Windows.Forms.NumericUpDown textBoxNumberOfPages;
        private System.Windows.Forms.TrackBar trackBarSize;
    }
}

