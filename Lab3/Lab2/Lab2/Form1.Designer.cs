
using System.Drawing;

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
            this.components = new System.ComponentModel.Container();
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
            this.price = new System.Windows.Forms.TextBox();
            this.dateTimePickerYear = new System.Windows.Forms.DateTimePicker();
            this.buttonCalculateRoyalties = new System.Windows.Forms.Button();
            this.textBoxNumberOfPages = new System.Windows.Forms.NumericUpDown();
            this.trackBarSize = new System.Windows.Forms.TrackBar();
            this.поискToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сортировкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поНазваниюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поИздательствуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.инструментыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelObjectCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelLastAction = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelDateTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerDateTime = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.textBoxNumberOfPages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSize)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
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
            this.authors.Location = new System.Drawing.Point(477, 488);
            this.authors.Name = "authors";
            this.authors.Size = new System.Drawing.Size(140, 63);
            this.authors.TabIndex = 1;
            this.authors.Text = "Авторы";
            this.authors.UseVisualStyleBackColor = false;
            this.authors.Click += new System.EventHandler(this.authors_Click);
            // 
            // listBoxInfo
            // 
            this.listBoxInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(225)))), ((int)(((byte)(235)))));
            this.listBoxInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listBoxInfo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.listBoxInfo.FormattingEnabled = true;
            this.listBoxInfo.HorizontalScrollbar = true;
            this.listBoxInfo.ItemHeight = 16;
            this.listBoxInfo.Location = new System.Drawing.Point(435, 193);
            this.listBoxInfo.Name = "listBoxInfo";
            this.listBoxInfo.ScrollAlwaysVisible = true;
            this.listBoxInfo.Size = new System.Drawing.Size(519, 208);
            this.listBoxInfo.TabIndex = 2;
            this.listBoxInfo.SelectedIndexChanged += new System.EventHandler(this.listBoxInfo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(12, 192);
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
            this.labelFileSize.Location = new System.Drawing.Point(12, 244);
            this.labelFileSize.Name = "labelFileSize";
            this.labelFileSize.Size = new System.Drawing.Size(203, 34);
            this.labelFileSize.TabIndex = 8;
            this.labelFileSize.Text = "Размер файла(мб)";
            this.labelFileSize.Click += new System.EventHandler(this.labelFileSize_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxName.Location = new System.Drawing.Point(222, 306);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(175, 26);
            this.textBoxName.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label3.Location = new System.Drawing.Point(12, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 34);
            this.label3.TabIndex = 10;
            this.label3.Text = "Название книги";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // buttonLoad
            // 
            this.buttonLoad.Font = new System.Drawing.Font("Monotype Corsiva", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLoad.Location = new System.Drawing.Point(641, 420);
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
            this.buttonSave.Location = new System.Drawing.Point(809, 420);
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
            this.buttonAdd.Location = new System.Drawing.Point(477, 420);
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
            this.label4.Location = new System.Drawing.Point(12, 363);
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
            this.label5.Location = new System.Drawing.Point(12, 420);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 34);
            this.label5.TabIndex = 15;
            this.label5.Text = "Издательство";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Monotype Corsiva", 25.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label6.Location = new System.Drawing.Point(244, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(434, 52);
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
            this.comboBoxGenre.IntegralHeight = false;
            this.comboBoxGenre.ItemHeight = 27;
            this.comboBoxGenre.Location = new System.Drawing.Point(222, 193);
            this.comboBoxGenre.Name = "comboBoxGenre";
            this.comboBoxGenre.Size = new System.Drawing.Size(175, 35);
            this.comboBoxGenre.TabIndex = 22;
            this.comboBoxGenre.SelectedIndexChanged += new System.EventHandler(this.жанр_книги_SelectedIndexChanged);
            // 
            // textBoxPublishingHouse
            // 
            this.textBoxPublishingHouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPublishingHouse.Location = new System.Drawing.Point(222, 426);
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
            this.год.Location = new System.Drawing.Point(12, 478);
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
            this.Стоимость_книги.Location = new System.Drawing.Point(12, 536);
            this.Стоимость_книги.Name = "Стоимость_книги";
            this.Стоимость_книги.Size = new System.Drawing.Size(204, 34);
            this.Стоимость_книги.TabIndex = 25;
            this.Стоимость_книги.Text = "Стоимость книги";
            // 
            // price
            // 
            this.price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.price.Location = new System.Drawing.Point(222, 542);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(175, 26);
            this.price.TabIndex = 26;
            this.price.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dateTimePickerYear
            // 
            this.dateTimePickerYear.CustomFormat = "yyyy";
            this.dateTimePickerYear.Font = new System.Drawing.Font("Monotype Corsiva", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePickerYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerYear.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePickerYear.Location = new System.Drawing.Point(222, 486);
            this.dateTimePickerYear.MaxDate = new System.DateTime(2025, 2, 26, 0, 0, 0, 0);
            this.dateTimePickerYear.MaximumSize = new System.Drawing.Size(175, 26);
            this.dateTimePickerYear.MinDate = new System.DateTime(1920, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerYear.Name = "dateTimePickerYear";
            this.dateTimePickerYear.Size = new System.Drawing.Size(175, 26);
            this.dateTimePickerYear.TabIndex = 19;
            this.dateTimePickerYear.Value = new System.DateTime(2025, 2, 1, 0, 0, 0, 0);
            // 
            // buttonCalculateRoyalties
            // 
            this.buttonCalculateRoyalties.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic);
            this.buttonCalculateRoyalties.Location = new System.Drawing.Point(687, 502);
            this.buttonCalculateRoyalties.Name = "buttonCalculateRoyalties";
            this.buttonCalculateRoyalties.Size = new System.Drawing.Size(267, 49);
            this.buttonCalculateRoyalties.TabIndex = 27;
            this.buttonCalculateRoyalties.Text = "Отчисления автору";
            this.buttonCalculateRoyalties.UseVisualStyleBackColor = true;
            this.buttonCalculateRoyalties.Click += new System.EventHandler(this.buttonCalculateRoyalties_Click);
            // 
            // textBoxNumberOfPages
            // 
            this.textBoxNumberOfPages.AutoSize = true;
            this.textBoxNumberOfPages.Location = new System.Drawing.Point(222, 373);
            this.textBoxNumberOfPages.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.textBoxNumberOfPages.MaximumSize = new System.Drawing.Size(175, 0);
            this.textBoxNumberOfPages.MinimumSize = new System.Drawing.Size(175, 0);
            this.textBoxNumberOfPages.Name = "textBoxNumberOfPages";
            this.textBoxNumberOfPages.Size = new System.Drawing.Size(175, 22);
            this.textBoxNumberOfPages.TabIndex = 28;
            this.textBoxNumberOfPages.ThousandsSeparator = true;
            this.textBoxNumberOfPages.ValueChanged += new System.EventHandler(this.textBoxNumberOfPages_ValueChanged);
            this.textBoxNumberOfPages.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNumberOfPages_KeyPress);
            // 
            // trackBarSize
            // 
            this.trackBarSize.Location = new System.Drawing.Point(293, 244);
            this.trackBarSize.Name = "trackBarSize";
            this.trackBarSize.Size = new System.Drawing.Size(104, 56);
            this.trackBarSize.TabIndex = 29;
            this.trackBarSize.Scroll += new System.EventHandler(this.trackBarSize_Scroll);
            // 
            // поискToolStripMenuItem
            // 
            this.поискToolStripMenuItem.BackColor = System.Drawing.Color.MistyRose;
            this.поискToolStripMenuItem.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.поискToolStripMenuItem.Name = "поискToolStripMenuItem";
            this.поискToolStripMenuItem.Size = new System.Drawing.Size(57, 21);
            this.поискToolStripMenuItem.Text = "Поиск";
            this.поискToolStripMenuItem.Click += new System.EventHandler(this.поискToolStripMenuItem_Click);
            // 
            // сортировкаToolStripMenuItem
            // 
            this.сортировкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поНазваниюToolStripMenuItem,
            this.поИздательствуToolStripMenuItem});
            this.сортировкаToolStripMenuItem.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.сортировкаToolStripMenuItem.Name = "сортировкаToolStripMenuItem";
            this.сортировкаToolStripMenuItem.Size = new System.Drawing.Size(91, 21);
            this.сортировкаToolStripMenuItem.Text = "Сортировка";
            this.сортировкаToolStripMenuItem.Click += new System.EventHandler(this.сортировкаToolStripMenuItem_Click);
            // 
            // поНазваниюToolStripMenuItem
            // 
            this.поНазваниюToolStripMenuItem.Name = "поНазваниюToolStripMenuItem";
            this.поНазваниюToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.поНазваниюToolStripMenuItem.Text = "по названию";
            this.поНазваниюToolStripMenuItem.Click += new System.EventHandler(this.поНазваниюToolStripMenuItem_Click);
            // 
            // поИздательствуToolStripMenuItem
            // 
            this.поИздательствуToolStripMenuItem.Name = "поИздательствуToolStripMenuItem";
            this.поИздательствуToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.поИздательствуToolStripMenuItem.Text = "по издательству";
            this.поИздательствуToolStripMenuItem.Click += new System.EventHandler(this.поИздательствуToolStripMenuItem_Click);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(96, 21);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // инструментыToolStripMenuItem
            // 
            this.инструментыToolStripMenuItem.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.инструментыToolStripMenuItem.Name = "инструментыToolStripMenuItem";
            this.инструментыToolStripMenuItem.Size = new System.Drawing.Size(106, 21);
            this.инструментыToolStripMenuItem.Text = "Инструменты";
            this.инструментыToolStripMenuItem.Click += new System.EventHandler(this.инструментыToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.MistyRose;
            this.menuStrip1.Font = new System.Drawing.Font("Monotype Corsiva", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.поискToolStripMenuItem,
            this.сортировкаToolStripMenuItem,
            this.оПрограммеToolStripMenuItem,
            this.инструментыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(987, 25);
            this.menuStrip1.TabIndex = 30;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.MistyRose;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButtonDelete,
            this.toolStripButton4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(987, 27);
            this.toolStrip1.TabIndex = 31;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton1.Text = "Поиск книги";
            this.toolStripButton1.Click += new System.EventHandler(this.поискToolStripMenuItem_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton2.Text = "Сортировать по названию";
            this.toolStripButton2.Click += new System.EventHandler(this.поНазваниюToolStripMenuItem_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton3.Text = "Сортировать по издательству";
            this.toolStripButton3.Click += new System.EventHandler(this.поИздательствуToolStripMenuItem_Click);
            // 
            // toolStripButtonDelete
            // 
            this.toolStripButtonDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonDelete.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonDelete.Image")));
            this.toolStripButtonDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonDelete.Name = "toolStripButtonDelete";
            this.toolStripButtonDelete.Size = new System.Drawing.Size(29, 24);
            this.toolStripButtonDelete.Text = "Удалить книгу";
            this.toolStripButtonDelete.Click += new System.EventHandler(this.toolStripButtonDelete_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(29, 24);
            this.toolStripButton4.Text = "Сохранить";
            this.toolStripButton4.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(705, 69);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelObjectCount,
            this.toolStripStatusLabelLastAction,
            this.toolStripStatusLabelDateTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 575);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(987, 24);
            this.statusStrip1.TabIndex = 33;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelObjectCount
            // 
            this.toolStripStatusLabelObjectCount.Name = "toolStripStatusLabelObjectCount";
            this.toolStripStatusLabelObjectCount.Size = new System.Drawing.Size(0, 18);
            // 
            // toolStripStatusLabelLastAction
            // 
            this.toolStripStatusLabelLastAction.Name = "toolStripStatusLabelLastAction";
            this.toolStripStatusLabelLastAction.Size = new System.Drawing.Size(0, 18);
            // 
            // toolStripStatusLabelDateTime
            // 
            this.toolStripStatusLabelDateTime.Name = "toolStripStatusLabelDateTime";
            this.toolStripStatusLabelDateTime.Size = new System.Drawing.Size(0, 20);
            // 
            // timerDateTime
            // 
            this.timerDateTime.Enabled = true;
            this.timerDateTime.Interval = 1000;
            this.timerDateTime.Tick += new System.EventHandler(this.timerDateTime_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(987, 599);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.trackBarSize);
            this.Controls.Add(this.textBoxNumberOfPages);
            this.Controls.Add(this.buttonCalculateRoyalties);
            this.Controls.Add(this.price);
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
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Электронная библиотека";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textBoxNumberOfPages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSize)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
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
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.DateTimePicker dateTimePickerYear;
        private System.Windows.Forms.Button buttonCalculateRoyalties;
        private System.Windows.Forms.NumericUpDown textBoxNumberOfPages;
        private System.Windows.Forms.TrackBar trackBarSize;
        private System.Windows.Forms.ToolStripMenuItem поискToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сортировкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem инструментыToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButtonDelete;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem поНазваниюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поИздательствуToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelObjectCount;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelLastAction;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelDateTime;
        private System.Windows.Forms.Timer timerDateTime;
    }
}

