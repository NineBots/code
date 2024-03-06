

namespace Personnel_Accounting
{
    using System.Data.Entity.Core.EntityClient;

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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.приложениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.посмотретьОтчетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.форма1кадрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.управлениеДаннымиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.гражданствоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.местоРожденияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отделениеМВДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.семейноеПоложениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.типРодтсвеннойСвязиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.должностьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.типТрудовогоДоговораToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.трудовойДоговорToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.квалификацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.образовательнаяОрганизацияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.специальностьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.типОбразованияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.руководствоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button_cancelChanges = new System.Windows.Forms.Button();
            this.button_saveChanges = new System.Windows.Forms.Button();
            this.button_deleteWorker = new System.Windows.Forms.Button();
            this.button_changeWorker = new System.Windows.Forms.Button();
            this.button_addWorker = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_word = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel_changePass = new System.Windows.Forms.Panel();
            this.panel_changeCareer = new System.Windows.Forms.Panel();
            this.comboBox_tdCareer = new System.Windows.Forms.ComboBox();
            this.label24 = new System.Windows.Forms.Label();
            this.maskedTextBox_numCareer = new System.Windows.Forms.MaskedTextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.comboBox_jobCareer = new System.Windows.Forms.ComboBox();
            this.maskedTextBox_salaryCareer = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_dateCareer = new System.Windows.Forms.MaskedTextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.panel_changeRelative = new System.Windows.Forms.Panel();
            this.maskedTextBox_birthdayRel = new System.Windows.Forms.MaskedTextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.maskedTextBox_fathnameRel = new System.Windows.Forms.MaskedTextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.maskedTextBox_surnameRel = new System.Windows.Forms.MaskedTextBox();
            this.label38 = new System.Windows.Forms.Label();
            this.comboBox_typeRel = new System.Windows.Forms.ComboBox();
            this.maskedTextBox_nameRel = new System.Windows.Forms.MaskedTextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.panel_changeEducation = new System.Windows.Forms.Panel();
            this.comboBox_ooEdu = new System.Windows.Forms.ComboBox();
            this.comboBox_specialityEdu = new System.Windows.Forms.ComboBox();
            this.label26 = new System.Windows.Forms.Label();
            this.comboBox_typeEdu = new System.Windows.Forms.ComboBox();
            this.label36 = new System.Windows.Forms.Label();
            this.maskedTextBox_seriaEdu = new System.Windows.Forms.MaskedTextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.comboBox_qualificationEdu = new System.Windows.Forms.ComboBox();
            this.maskedTextBox_numberEdu = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_dateEdu = new System.Windows.Forms.MaskedTextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.maskedTextBox_addrPass = new System.Windows.Forms.MaskedTextBox();
            this.comboBox_famPass = new System.Windows.Forms.ComboBox();
            this.maskedTextBox_numberPass = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_seriaPass = new System.Windows.Forms.MaskedTextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.comboBox_citizenshipPass = new System.Windows.Forms.ComboBox();
            this.comboBox_wherePass = new System.Windows.Forms.ComboBox();
            this.maskedTextBox_dateGivenPass = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_fathnamePass = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_namePass = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_surnamePass = new System.Windows.Forms.MaskedTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.comboBox_inp_gender = new System.Windows.Forms.ComboBox();
            this.comboBox_inp_job = new System.Windows.Forms.ComboBox();
            this.maskedTextBox_inp_mail = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_inp_phone = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_inp_birthday = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_inp_snils = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxinp_inn = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_fathName = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_name = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox_surname = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox_image = new System.Windows.Forms.PictureBox();
            this.textBox_mail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_phone = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_snils = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox_inn = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox_addr = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_birthday = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_gender = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_job = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_fathname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_surname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_city = new System.Windows.Forms.TextBox();
            this.comboBox_inp_city = new System.Windows.Forms.ComboBox();
            this.maskedTextBox_inp_addr = new System.Windows.Forms.MaskedTextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.общееToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.паспортToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.карьераToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.образованиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.семьяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel_changePass.SuspendLayout();
            this.panel_changeCareer.SuspendLayout();
            this.panel_changeRelative.SuspendLayout();
            this.panel_changeEducation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel4.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.приложениеToolStripMenuItem,
            this.посмотретьОтчетToolStripMenuItem,
            this.управлениеДаннымиToolStripMenuItem,
            this.руководствоToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1056, 24);
            this.menuStrip1.TabIndex = 1;
            // 
            // приложениеToolStripMenuItem
            // 
            this.приложениеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.закрытьToolStripMenuItem});
            this.приложениеToolStripMenuItem.Name = "приложениеToolStripMenuItem";
            this.приложениеToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.приложениеToolStripMenuItem.Text = "Приложение";
            // 
            // закрытьToolStripMenuItem
            // 
            this.закрытьToolStripMenuItem.Name = "закрытьToolStripMenuItem";
            this.закрытьToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.закрытьToolStripMenuItem.Text = "Закрыть";
            this.закрытьToolStripMenuItem.Click += new System.EventHandler(this.закрытьToolStripMenuItem_Click);
            // 
            // посмотретьОтчетToolStripMenuItem
            // 
            this.посмотретьОтчетToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.форма1кадрыToolStripMenuItem});
            this.посмотретьОтчетToolStripMenuItem.Name = "посмотретьОтчетToolStripMenuItem";
            this.посмотретьОтчетToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.посмотретьОтчетToolStripMenuItem.Text = "Посмотреть отчет";
            // 
            // форма1кадрыToolStripMenuItem
            // 
            this.форма1кадрыToolStripMenuItem.Name = "форма1кадрыToolStripMenuItem";
            this.форма1кадрыToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.форма1кадрыToolStripMenuItem.Text = "Форма №1 (кадры)";
            this.форма1кадрыToolStripMenuItem.Click += new System.EventHandler(this.форма1кадрыToolStripMenuItem_Click);
            // 
            // управлениеДаннымиToolStripMenuItem
            // 
            this.управлениеДаннымиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.гражданствоToolStripMenuItem,
            this.местоРожденияToolStripMenuItem,
            this.отделениеМВДToolStripMenuItem,
            this.toolStripSeparator3,
            this.семейноеПоложениеToolStripMenuItem,
            this.типРодтсвеннойСвязиToolStripMenuItem,
            this.toolStripSeparator1,
            this.должностьToolStripMenuItem,
            this.типТрудовогоДоговораToolStripMenuItem,
            this.трудовойДоговорToolStripMenuItem,
            this.toolStripSeparator2,
            this.квалификацияToolStripMenuItem,
            this.образовательнаяОрганизацияToolStripMenuItem,
            this.специальностьToolStripMenuItem,
            this.типОбразованияToolStripMenuItem});
            this.управлениеДаннымиToolStripMenuItem.Name = "управлениеДаннымиToolStripMenuItem";
            this.управлениеДаннымиToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.управлениеДаннымиToolStripMenuItem.Text = "Данные";
            // 
            // гражданствоToolStripMenuItem
            // 
            this.гражданствоToolStripMenuItem.Name = "гражданствоToolStripMenuItem";
            this.гражданствоToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.гражданствоToolStripMenuItem.Text = "Гражданство";
            this.гражданствоToolStripMenuItem.Click += new System.EventHandler(this.гражданствоToolStripMenuItem_Click);
            // 
            // местоРожденияToolStripMenuItem
            // 
            this.местоРожденияToolStripMenuItem.Name = "местоРожденияToolStripMenuItem";
            this.местоРожденияToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.местоРожденияToolStripMenuItem.Text = "Место_Рождения";
            this.местоРожденияToolStripMenuItem.Click += new System.EventHandler(this.местоРожденияToolStripMenuItem_Click);
            // 
            // отделениеМВДToolStripMenuItem
            // 
            this.отделениеМВДToolStripMenuItem.Name = "отделениеМВДToolStripMenuItem";
            this.отделениеМВДToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.отделениеМВДToolStripMenuItem.Text = "Отделение МВД";
            this.отделениеМВДToolStripMenuItem.Click += new System.EventHandler(this.отделениеМВДToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(240, 6);
            // 
            // семейноеПоложениеToolStripMenuItem
            // 
            this.семейноеПоложениеToolStripMenuItem.Name = "семейноеПоложениеToolStripMenuItem";
            this.семейноеПоложениеToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.семейноеПоложениеToolStripMenuItem.Text = "Семейное положение";
            this.семейноеПоложениеToolStripMenuItem.Click += new System.EventHandler(this.семейноеПоложениеToolStripMenuItem_Click);
            // 
            // типРодтсвеннойСвязиToolStripMenuItem
            // 
            this.типРодтсвеннойСвязиToolStripMenuItem.Name = "типРодтсвеннойСвязиToolStripMenuItem";
            this.типРодтсвеннойСвязиToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.типРодтсвеннойСвязиToolStripMenuItem.Text = "Тип родственной связи";
            this.типРодтсвеннойСвязиToolStripMenuItem.Click += new System.EventHandler(this.типРодтсвеннойСвязиToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(240, 6);
            // 
            // должностьToolStripMenuItem
            // 
            this.должностьToolStripMenuItem.Name = "должностьToolStripMenuItem";
            this.должностьToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.должностьToolStripMenuItem.Text = "Должность";
            this.должностьToolStripMenuItem.Click += new System.EventHandler(this.должностьToolStripMenuItem_Click);
            // 
            // типТрудовогоДоговораToolStripMenuItem
            // 
            this.типТрудовогоДоговораToolStripMenuItem.Name = "типТрудовогоДоговораToolStripMenuItem";
            this.типТрудовогоДоговораToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.типТрудовогоДоговораToolStripMenuItem.Text = "Тип трудового договора";
            this.типТрудовогоДоговораToolStripMenuItem.Click += new System.EventHandler(this.типТрудовогоДоговораToolStripMenuItem_Click);
            // 
            // трудовойДоговорToolStripMenuItem
            // 
            this.трудовойДоговорToolStripMenuItem.Name = "трудовойДоговорToolStripMenuItem";
            this.трудовойДоговорToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.трудовойДоговорToolStripMenuItem.Text = "Трудовой договор";
            this.трудовойДоговорToolStripMenuItem.Click += new System.EventHandler(this.трудовойДоговорToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(240, 6);
            // 
            // квалификацияToolStripMenuItem
            // 
            this.квалификацияToolStripMenuItem.Name = "квалификацияToolStripMenuItem";
            this.квалификацияToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.квалификацияToolStripMenuItem.Text = "Квалификация";
            this.квалификацияToolStripMenuItem.Click += new System.EventHandler(this.квалификацияToolStripMenuItem_Click);
            // 
            // образовательнаяОрганизацияToolStripMenuItem
            // 
            this.образовательнаяОрганизацияToolStripMenuItem.Name = "образовательнаяОрганизацияToolStripMenuItem";
            this.образовательнаяОрганизацияToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.образовательнаяОрганизацияToolStripMenuItem.Text = "Образовательная организация";
            this.образовательнаяОрганизацияToolStripMenuItem.Click += new System.EventHandler(this.образовательнаяОрганизацияToolStripMenuItem_Click);
            // 
            // специальностьToolStripMenuItem
            // 
            this.специальностьToolStripMenuItem.Name = "специальностьToolStripMenuItem";
            this.специальностьToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.специальностьToolStripMenuItem.Text = "Специальность";
            this.специальностьToolStripMenuItem.Click += new System.EventHandler(this.специальностьToolStripMenuItem_Click);
            // 
            // типОбразованияToolStripMenuItem
            // 
            this.типОбразованияToolStripMenuItem.Name = "типОбразованияToolStripMenuItem";
            this.типОбразованияToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.типОбразованияToolStripMenuItem.Text = "Тип образования";
            this.типОбразованияToolStripMenuItem.Click += new System.EventHandler(this.типОбразованияToolStripMenuItem_Click);
            // 
            // руководствоToolStripMenuItem
            // 
            this.руководствоToolStripMenuItem.Name = "руководствоToolStripMenuItem";
            this.руководствоToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.руководствоToolStripMenuItem.Text = "Справка";
            this.руководствоToolStripMenuItem.Click += new System.EventHandler(this.руководствоToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1043, 206);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.textBox_search);
            this.panel3.Location = new System.Drawing.Point(0, 25);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1056, 247);
            this.panel3.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Personnel_Accounting.Properties.Resources.discover;
            this.pictureBox1.Location = new System.Drawing.Point(757, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // textBox_search
            // 
            this.textBox_search.Location = new System.Drawing.Point(787, 8);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(231, 20);
            this.textBox_search.TabIndex = 0;
            this.textBox_search.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.button_cancelChanges);
            this.panel2.Controls.Add(this.button_saveChanges);
            this.panel2.Controls.Add(this.button_deleteWorker);
            this.panel2.Controls.Add(this.button_changeWorker);
            this.panel2.Controls.Add(this.button_addWorker);
            this.panel2.Location = new System.Drawing.Point(919, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(132, 180);
            this.panel2.TabIndex = 24;
            // 
            // button_cancelChanges
            // 
            this.button_cancelChanges.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_cancelChanges.Location = new System.Drawing.Point(5, 70);
            this.button_cancelChanges.Name = "button_cancelChanges";
            this.button_cancelChanges.Size = new System.Drawing.Size(120, 40);
            this.button_cancelChanges.TabIndex = 4;
            this.button_cancelChanges.Text = "Отмена";
            this.button_cancelChanges.UseVisualStyleBackColor = true;
            this.button_cancelChanges.Visible = false;
            this.button_cancelChanges.Click += new System.EventHandler(this.button_cancelChanges_Click);
            // 
            // button_saveChanges
            // 
            this.button_saveChanges.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_saveChanges.Location = new System.Drawing.Point(5, 5);
            this.button_saveChanges.Name = "button_saveChanges";
            this.button_saveChanges.Size = new System.Drawing.Size(120, 59);
            this.button_saveChanges.TabIndex = 3;
            this.button_saveChanges.Text = "Сохранить";
            this.button_saveChanges.UseVisualStyleBackColor = true;
            this.button_saveChanges.Visible = false;
            this.button_saveChanges.Click += new System.EventHandler(this.button_saveChanges_Click);
            // 
            // button_deleteWorker
            // 
            this.button_deleteWorker.Location = new System.Drawing.Point(5, 133);
            this.button_deleteWorker.Name = "button_deleteWorker";
            this.button_deleteWorker.Size = new System.Drawing.Size(120, 40);
            this.button_deleteWorker.TabIndex = 2;
            this.button_deleteWorker.Text = "Удалить";
            this.button_deleteWorker.UseVisualStyleBackColor = true;
            this.button_deleteWorker.Click += new System.EventHandler(this.button3_Click);
            // 
            // button_changeWorker
            // 
            this.button_changeWorker.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_changeWorker.Location = new System.Drawing.Point(5, 70);
            this.button_changeWorker.Name = "button_changeWorker";
            this.button_changeWorker.Size = new System.Drawing.Size(120, 40);
            this.button_changeWorker.TabIndex = 1;
            this.button_changeWorker.Text = "Изменить";
            this.button_changeWorker.UseVisualStyleBackColor = true;
            this.button_changeWorker.Click += new System.EventHandler(this.button_changeWorker_Click);
            // 
            // button_addWorker
            // 
            this.button_addWorker.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_addWorker.Location = new System.Drawing.Point(5, 5);
            this.button_addWorker.Name = "button_addWorker";
            this.button_addWorker.Size = new System.Drawing.Size(120, 59);
            this.button_addWorker.TabIndex = 0;
            this.button_addWorker.Text = "Добавить\r\nсотрудника";
            this.button_addWorker.UseVisualStyleBackColor = true;
            this.button_addWorker.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_word);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panel1.Location = new System.Drawing.Point(0, 297);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1056, 274);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button_word
            // 
            this.button_word.Location = new System.Drawing.Point(924, 223);
            this.button_word.Name = "button_word";
            this.button_word.Size = new System.Drawing.Size(120, 40);
            this.button_word.TabIndex = 5;
            this.button_word.Text = "Word";
            this.button_word.UseVisualStyleBackColor = true;
            this.button_word.Visible = false;
            this.button_word.Click += new System.EventHandler(this.button_word_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.panel_changePass);
            this.panel7.Controls.Add(this.comboBox_inp_gender);
            this.panel7.Controls.Add(this.comboBox_inp_job);
            this.panel7.Controls.Add(this.maskedTextBox_inp_mail);
            this.panel7.Controls.Add(this.maskedTextBox_inp_phone);
            this.panel7.Controls.Add(this.maskedTextBox_inp_birthday);
            this.panel7.Controls.Add(this.maskedTextBox_inp_snils);
            this.panel7.Controls.Add(this.maskedTextBoxinp_inn);
            this.panel7.Controls.Add(this.maskedTextBox_fathName);
            this.panel7.Controls.Add(this.maskedTextBox_name);
            this.panel7.Controls.Add(this.maskedTextBox_surname);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Controls.Add(this.pictureBox_image);
            this.panel7.Controls.Add(this.textBox_mail);
            this.panel7.Controls.Add(this.label9);
            this.panel7.Controls.Add(this.textBox_phone);
            this.panel7.Controls.Add(this.label10);
            this.panel7.Controls.Add(this.textBox_snils);
            this.panel7.Controls.Add(this.label11);
            this.panel7.Controls.Add(this.textBox_inn);
            this.panel7.Controls.Add(this.label12);
            this.panel7.Controls.Add(this.textBox_addr);
            this.panel7.Controls.Add(this.label);
            this.panel7.Controls.Add(this.label6);
            this.panel7.Controls.Add(this.textBox_birthday);
            this.panel7.Controls.Add(this.label7);
            this.panel7.Controls.Add(this.textBox_gender);
            this.panel7.Controls.Add(this.label8);
            this.panel7.Controls.Add(this.textBox_job);
            this.panel7.Controls.Add(this.label4);
            this.panel7.Controls.Add(this.textBox_fathname);
            this.panel7.Controls.Add(this.label3);
            this.panel7.Controls.Add(this.textBox_name);
            this.panel7.Controls.Add(this.label2);
            this.panel7.Controls.Add(this.textBox_surname);
            this.panel7.Controls.Add(this.label1);
            this.panel7.Controls.Add(this.textBox_city);
            this.panel7.Controls.Add(this.comboBox_inp_city);
            this.panel7.Controls.Add(this.maskedTextBox_inp_addr);
            this.panel7.Controls.Add(this.dataGridView2);
            this.panel7.Location = new System.Drawing.Point(5, 31);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(899, 229);
            this.panel7.TabIndex = 40;
            // 
            // panel_changePass
            // 
            this.panel_changePass.Controls.Add(this.panel_changeCareer);
            this.panel_changePass.Controls.Add(this.maskedTextBox_addrPass);
            this.panel_changePass.Controls.Add(this.comboBox_famPass);
            this.panel_changePass.Controls.Add(this.maskedTextBox_numberPass);
            this.panel_changePass.Controls.Add(this.maskedTextBox_seriaPass);
            this.panel_changePass.Controls.Add(this.label21);
            this.panel_changePass.Controls.Add(this.label22);
            this.panel_changePass.Controls.Add(this.comboBox_citizenshipPass);
            this.panel_changePass.Controls.Add(this.comboBox_wherePass);
            this.panel_changePass.Controls.Add(this.maskedTextBox_dateGivenPass);
            this.panel_changePass.Controls.Add(this.maskedTextBox_fathnamePass);
            this.panel_changePass.Controls.Add(this.maskedTextBox_namePass);
            this.panel_changePass.Controls.Add(this.maskedTextBox_surnamePass);
            this.panel_changePass.Controls.Add(this.label13);
            this.panel_changePass.Controls.Add(this.label14);
            this.panel_changePass.Controls.Add(this.label15);
            this.panel_changePass.Controls.Add(this.label16);
            this.panel_changePass.Controls.Add(this.label17);
            this.panel_changePass.Controls.Add(this.label18);
            this.panel_changePass.Controls.Add(this.label19);
            this.panel_changePass.Controls.Add(this.label20);
            this.panel_changePass.Location = new System.Drawing.Point(-1, 0);
            this.panel_changePass.Name = "panel_changePass";
            this.panel_changePass.Size = new System.Drawing.Size(900, 232);
            this.panel_changePass.TabIndex = 79;
            this.panel_changePass.Visible = false;
            // 
            // panel_changeCareer
            // 
            this.panel_changeCareer.Controls.Add(this.comboBox_tdCareer);
            this.panel_changeCareer.Controls.Add(this.label24);
            this.panel_changeCareer.Controls.Add(this.maskedTextBox_numCareer);
            this.panel_changeCareer.Controls.Add(this.label23);
            this.panel_changeCareer.Controls.Add(this.comboBox_jobCareer);
            this.panel_changeCareer.Controls.Add(this.maskedTextBox_salaryCareer);
            this.panel_changeCareer.Controls.Add(this.maskedTextBox_dateCareer);
            this.panel_changeCareer.Controls.Add(this.label29);
            this.panel_changeCareer.Controls.Add(this.label30);
            this.panel_changeCareer.Controls.Add(this.label32);
            this.panel_changeCareer.Controls.Add(this.panel_changeRelative);
            this.panel_changeCareer.Controls.Add(this.panel_changeEducation);
            this.panel_changeCareer.Location = new System.Drawing.Point(1, 0);
            this.panel_changeCareer.Name = "panel_changeCareer";
            this.panel_changeCareer.Size = new System.Drawing.Size(900, 232);
            this.panel_changeCareer.TabIndex = 99;
            this.panel_changeCareer.Visible = false;
            // 
            // comboBox_tdCareer
            // 
            this.comboBox_tdCareer.DropDownWidth = 200;
            this.comboBox_tdCareer.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_tdCareer.FormattingEnabled = true;
            this.comboBox_tdCareer.Location = new System.Drawing.Point(458, 52);
            this.comboBox_tdCareer.Name = "comboBox_tdCareer";
            this.comboBox_tdCareer.Size = new System.Drawing.Size(251, 27);
            this.comboBox_tdCareer.TabIndex = 98;
            this.comboBox_tdCareer.Visible = false;
            // 
            // label24
            // 
            this.label24.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label24.Location = new System.Drawing.Point(324, 42);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(128, 45);
            this.label24.TabIndex = 97;
            this.label24.Text = "Трудовой\r\nдоговор\r\n";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label24.Visible = false;
            // 
            // maskedTextBox_numCareer
            // 
            this.maskedTextBox_numCareer.AsciiOnly = true;
            this.maskedTextBox_numCareer.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBox_numCareer.Location = new System.Drawing.Point(157, 99);
            this.maskedTextBox_numCareer.Mask = "000";
            this.maskedTextBox_numCareer.Name = "maskedTextBox_numCareer";
            this.maskedTextBox_numCareer.Size = new System.Drawing.Size(149, 26);
            this.maskedTextBox_numCareer.TabIndex = 96;
            this.maskedTextBox_numCareer.Visible = false;
            // 
            // label23
            // 
            this.label23.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label23.Location = new System.Drawing.Point(2, 99);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(149, 24);
            this.label23.TabIndex = 94;
            this.label23.Text = "Номер Бригады";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label23.Visible = false;
            // 
            // comboBox_jobCareer
            // 
            this.comboBox_jobCareer.DropDownWidth = 450;
            this.comboBox_jobCareer.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_jobCareer.FormattingEnabled = true;
            this.comboBox_jobCareer.Location = new System.Drawing.Point(458, 1);
            this.comboBox_jobCareer.Name = "comboBox_jobCareer";
            this.comboBox_jobCareer.Size = new System.Drawing.Size(148, 27);
            this.comboBox_jobCareer.TabIndex = 91;
            this.comboBox_jobCareer.Visible = false;
            this.comboBox_jobCareer.SelectedIndexChanged += new System.EventHandler(this.comboBox_jobCareer_SelectedIndexChanged);
            this.comboBox_jobCareer.SelectionChangeCommitted += new System.EventHandler(this.comboBox_jobCareer_SelectionChangeCommitted);
            this.comboBox_jobCareer.SelectedValueChanged += new System.EventHandler(this.comboBox_jobCareer_SelectedValueChanged);
            // 
            // maskedTextBox_salaryCareer
            // 
            this.maskedTextBox_salaryCareer.AsciiOnly = true;
            this.maskedTextBox_salaryCareer.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBox_salaryCareer.Location = new System.Drawing.Point(157, 52);
            this.maskedTextBox_salaryCareer.Name = "maskedTextBox_salaryCareer";
            this.maskedTextBox_salaryCareer.ReadOnly = true;
            this.maskedTextBox_salaryCareer.Size = new System.Drawing.Size(149, 26);
            this.maskedTextBox_salaryCareer.TabIndex = 89;
            this.maskedTextBox_salaryCareer.Visible = false;
            // 
            // maskedTextBox_dateCareer
            // 
            this.maskedTextBox_dateCareer.AsciiOnly = true;
            this.maskedTextBox_dateCareer.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBox_dateCareer.Location = new System.Drawing.Point(157, 2);
            this.maskedTextBox_dateCareer.Mask = "00/00/0000";
            this.maskedTextBox_dateCareer.Name = "maskedTextBox_dateCareer";
            this.maskedTextBox_dateCareer.ReadOnly = true;
            this.maskedTextBox_dateCareer.Size = new System.Drawing.Size(149, 26);
            this.maskedTextBox_dateCareer.TabIndex = 87;
            this.maskedTextBox_dateCareer.ValidatingType = typeof(System.DateTime);
            this.maskedTextBox_dateCareer.Visible = false;
            // 
            // label29
            // 
            this.label29.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label29.Location = new System.Drawing.Point(324, 3);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(128, 24);
            this.label29.TabIndex = 80;
            this.label29.Text = "Должность";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label29.Visible = false;
            // 
            // label30
            // 
            this.label30.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label30.Location = new System.Drawing.Point(50, 52);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(101, 24);
            this.label30.TabIndex = 79;
            this.label30.Text = "Зарплата";
            this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label30.Visible = false;
            // 
            // label32
            // 
            this.label32.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label32.Location = new System.Drawing.Point(23, 2);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(127, 23);
            this.label32.TabIndex = 77;
            this.label32.Text = "Дата Записи";
            this.label32.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label32.Visible = false;
            // 
            // panel_changeRelative
            // 
            this.panel_changeRelative.Controls.Add(this.maskedTextBox_birthdayRel);
            this.panel_changeRelative.Controls.Add(this.label37);
            this.panel_changeRelative.Controls.Add(this.maskedTextBox_fathnameRel);
            this.panel_changeRelative.Controls.Add(this.label25);
            this.panel_changeRelative.Controls.Add(this.maskedTextBox_surnameRel);
            this.panel_changeRelative.Controls.Add(this.label38);
            this.panel_changeRelative.Controls.Add(this.comboBox_typeRel);
            this.panel_changeRelative.Controls.Add(this.maskedTextBox_nameRel);
            this.panel_changeRelative.Controls.Add(this.label39);
            this.panel_changeRelative.Controls.Add(this.label41);
            this.panel_changeRelative.Location = new System.Drawing.Point(2, 3);
            this.panel_changeRelative.Name = "panel_changeRelative";
            this.panel_changeRelative.Size = new System.Drawing.Size(900, 232);
            this.panel_changeRelative.TabIndex = 106;
            this.panel_changeRelative.Visible = false;
            // 
            // maskedTextBox_birthdayRel
            // 
            this.maskedTextBox_birthdayRel.AsciiOnly = true;
            this.maskedTextBox_birthdayRel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBox_birthdayRel.Location = new System.Drawing.Point(155, 150);
            this.maskedTextBox_birthdayRel.Mask = "00/00/0000";
            this.maskedTextBox_birthdayRel.Name = "maskedTextBox_birthdayRel";
            this.maskedTextBox_birthdayRel.Size = new System.Drawing.Size(149, 26);
            this.maskedTextBox_birthdayRel.TabIndex = 109;
            this.maskedTextBox_birthdayRel.ValidatingType = typeof(System.DateTime);
            this.maskedTextBox_birthdayRel.Visible = false;
            this.maskedTextBox_birthdayRel.Leave += new System.EventHandler(this.maskedTextBox_birthdayRel_Leave);
            // 
            // label37
            // 
            this.label37.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label37.Location = new System.Drawing.Point(4, 150);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(144, 24);
            this.label37.TabIndex = 108;
            this.label37.Text = "Дата Рождения";
            this.label37.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label37.Visible = false;
            // 
            // maskedTextBox_fathnameRel
            // 
            this.maskedTextBox_fathnameRel.AsciiOnly = true;
            this.maskedTextBox_fathnameRel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBox_fathnameRel.Location = new System.Drawing.Point(155, 98);
            this.maskedTextBox_fathnameRel.Name = "maskedTextBox_fathnameRel";
            this.maskedTextBox_fathnameRel.Size = new System.Drawing.Size(149, 26);
            this.maskedTextBox_fathnameRel.TabIndex = 107;
            this.maskedTextBox_fathnameRel.Visible = false;
            this.maskedTextBox_fathnameRel.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox_fathnameRel_MaskInputRejected);
            // 
            // label25
            // 
            this.label25.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label25.Location = new System.Drawing.Point(25, 98);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(123, 24);
            this.label25.TabIndex = 106;
            this.label25.Text = "Отчество";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label25.Visible = false;
            this.label25.Click += new System.EventHandler(this.label25_Click);
            // 
            // maskedTextBox_surnameRel
            // 
            this.maskedTextBox_surnameRel.AsciiOnly = true;
            this.maskedTextBox_surnameRel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBox_surnameRel.Location = new System.Drawing.Point(157, 0);
            this.maskedTextBox_surnameRel.Name = "maskedTextBox_surnameRel";
            this.maskedTextBox_surnameRel.Size = new System.Drawing.Size(149, 26);
            this.maskedTextBox_surnameRel.TabIndex = 100;
            this.maskedTextBox_surnameRel.Visible = false;
            // 
            // label38
            // 
            this.label38.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label38.Location = new System.Drawing.Point(27, 0);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(123, 24);
            this.label38.TabIndex = 99;
            this.label38.Text = "Фамилия";
            this.label38.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label38.Visible = false;
            // 
            // comboBox_typeRel
            // 
            this.comboBox_typeRel.DropDownWidth = 450;
            this.comboBox_typeRel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_typeRel.FormattingEnabled = true;
            this.comboBox_typeRel.Location = new System.Drawing.Point(559, 0);
            this.comboBox_typeRel.Name = "comboBox_typeRel";
            this.comboBox_typeRel.Size = new System.Drawing.Size(148, 27);
            this.comboBox_typeRel.TabIndex = 91;
            this.comboBox_typeRel.Visible = false;
            // 
            // maskedTextBox_nameRel
            // 
            this.maskedTextBox_nameRel.AsciiOnly = true;
            this.maskedTextBox_nameRel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBox_nameRel.Location = new System.Drawing.Point(157, 51);
            this.maskedTextBox_nameRel.Name = "maskedTextBox_nameRel";
            this.maskedTextBox_nameRel.Size = new System.Drawing.Size(149, 26);
            this.maskedTextBox_nameRel.TabIndex = 88;
            this.maskedTextBox_nameRel.Visible = false;
            // 
            // label39
            // 
            this.label39.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label39.Location = new System.Drawing.Point(386, -9);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(167, 59);
            this.label39.TabIndex = 80;
            this.label39.Text = "Кем\r\nприходится";
            this.label39.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label39.Visible = false;
            this.label39.Click += new System.EventHandler(this.label39_Click);
            // 
            // label41
            // 
            this.label41.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label41.Location = new System.Drawing.Point(27, 51);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(123, 24);
            this.label41.TabIndex = 78;
            this.label41.Text = "Имя";
            this.label41.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label41.Visible = false;
            // 
            // panel_changeEducation
            // 
            this.panel_changeEducation.Controls.Add(this.comboBox_ooEdu);
            this.panel_changeEducation.Controls.Add(this.comboBox_specialityEdu);
            this.panel_changeEducation.Controls.Add(this.label26);
            this.panel_changeEducation.Controls.Add(this.comboBox_typeEdu);
            this.panel_changeEducation.Controls.Add(this.label36);
            this.panel_changeEducation.Controls.Add(this.maskedTextBox_seriaEdu);
            this.panel_changeEducation.Controls.Add(this.label35);
            this.panel_changeEducation.Controls.Add(this.comboBox_qualificationEdu);
            this.panel_changeEducation.Controls.Add(this.maskedTextBox_numberEdu);
            this.panel_changeEducation.Controls.Add(this.maskedTextBox_dateEdu);
            this.panel_changeEducation.Controls.Add(this.label27);
            this.panel_changeEducation.Controls.Add(this.label28);
            this.panel_changeEducation.Controls.Add(this.label33);
            this.panel_changeEducation.Controls.Add(this.label34);
            this.panel_changeEducation.Location = new System.Drawing.Point(2, 3);
            this.panel_changeEducation.Name = "panel_changeEducation";
            this.panel_changeEducation.Size = new System.Drawing.Size(900, 232);
            this.panel_changeEducation.TabIndex = 100;
            this.panel_changeEducation.Visible = false;
            // 
            // comboBox_ooEdu
            // 
            this.comboBox_ooEdu.DropDownWidth = 450;
            this.comboBox_ooEdu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_ooEdu.FormattingEnabled = true;
            this.comboBox_ooEdu.Location = new System.Drawing.Point(512, 48);
            this.comboBox_ooEdu.Name = "comboBox_ooEdu";
            this.comboBox_ooEdu.Size = new System.Drawing.Size(268, 27);
            this.comboBox_ooEdu.TabIndex = 105;
            this.comboBox_ooEdu.Visible = false;
            // 
            // comboBox_specialityEdu
            // 
            this.comboBox_specialityEdu.DropDownWidth = 450;
            this.comboBox_specialityEdu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_specialityEdu.FormattingEnabled = true;
            this.comboBox_specialityEdu.Location = new System.Drawing.Point(159, 154);
            this.comboBox_specialityEdu.Name = "comboBox_specialityEdu";
            this.comboBox_specialityEdu.Size = new System.Drawing.Size(148, 27);
            this.comboBox_specialityEdu.TabIndex = 104;
            this.comboBox_specialityEdu.Visible = false;
            // 
            // label26
            // 
            this.label26.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label26.Location = new System.Drawing.Point(4, 156);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(149, 24);
            this.label26.TabIndex = 103;
            this.label26.Text = "Специальность";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label26.Visible = false;
            // 
            // comboBox_typeEdu
            // 
            this.comboBox_typeEdu.DropDownWidth = 450;
            this.comboBox_typeEdu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_typeEdu.FormattingEnabled = true;
            this.comboBox_typeEdu.Location = new System.Drawing.Point(158, 101);
            this.comboBox_typeEdu.Name = "comboBox_typeEdu";
            this.comboBox_typeEdu.Size = new System.Drawing.Size(148, 27);
            this.comboBox_typeEdu.TabIndex = 102;
            this.comboBox_typeEdu.Visible = false;
            // 
            // label36
            // 
            this.label36.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label36.Location = new System.Drawing.Point(25, 95);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(128, 41);
            this.label36.TabIndex = 101;
            this.label36.Text = "Тип\r\nобразования";
            this.label36.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label36.Visible = false;
            // 
            // maskedTextBox_seriaEdu
            // 
            this.maskedTextBox_seriaEdu.AsciiOnly = true;
            this.maskedTextBox_seriaEdu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBox_seriaEdu.Location = new System.Drawing.Point(157, 0);
            this.maskedTextBox_seriaEdu.Mask = "000000";
            this.maskedTextBox_seriaEdu.Name = "maskedTextBox_seriaEdu";
            this.maskedTextBox_seriaEdu.Size = new System.Drawing.Size(149, 26);
            this.maskedTextBox_seriaEdu.TabIndex = 100;
            this.maskedTextBox_seriaEdu.Visible = false;
            this.maskedTextBox_seriaEdu.Leave += new System.EventHandler(this.maskedTextBox_seriaEdu_Leave);
            // 
            // label35
            // 
            this.label35.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label35.Location = new System.Drawing.Point(27, 0);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(123, 24);
            this.label35.TabIndex = 99;
            this.label35.Text = "Серия";
            this.label35.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label35.Visible = false;
            // 
            // comboBox_qualificationEdu
            // 
            this.comboBox_qualificationEdu.DropDownWidth = 450;
            this.comboBox_qualificationEdu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_qualificationEdu.FormattingEnabled = true;
            this.comboBox_qualificationEdu.Location = new System.Drawing.Point(514, 1);
            this.comboBox_qualificationEdu.Name = "comboBox_qualificationEdu";
            this.comboBox_qualificationEdu.Size = new System.Drawing.Size(148, 27);
            this.comboBox_qualificationEdu.TabIndex = 91;
            this.comboBox_qualificationEdu.Visible = false;
            // 
            // maskedTextBox_numberEdu
            // 
            this.maskedTextBox_numberEdu.AsciiOnly = true;
            this.maskedTextBox_numberEdu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBox_numberEdu.Location = new System.Drawing.Point(157, 51);
            this.maskedTextBox_numberEdu.Mask = "0000000";
            this.maskedTextBox_numberEdu.Name = "maskedTextBox_numberEdu";
            this.maskedTextBox_numberEdu.Size = new System.Drawing.Size(149, 26);
            this.maskedTextBox_numberEdu.TabIndex = 88;
            this.maskedTextBox_numberEdu.Visible = false;
            this.maskedTextBox_numberEdu.Leave += new System.EventHandler(this.maskedTextBox_numberEdu_Leave);
            // 
            // maskedTextBox_dateEdu
            // 
            this.maskedTextBox_dateEdu.AsciiOnly = true;
            this.maskedTextBox_dateEdu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBox_dateEdu.Location = new System.Drawing.Point(512, 103);
            this.maskedTextBox_dateEdu.Mask = "00/00/0000";
            this.maskedTextBox_dateEdu.Name = "maskedTextBox_dateEdu";
            this.maskedTextBox_dateEdu.Size = new System.Drawing.Size(149, 26);
            this.maskedTextBox_dateEdu.TabIndex = 87;
            this.maskedTextBox_dateEdu.ValidatingType = typeof(System.DateTime);
            this.maskedTextBox_dateEdu.Visible = false;
            this.maskedTextBox_dateEdu.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox4_MaskInputRejected);
            this.maskedTextBox_dateEdu.Leave += new System.EventHandler(this.maskedTextBox_dateEdu_Leave);
            // 
            // label27
            // 
            this.label27.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label27.Location = new System.Drawing.Point(341, 3);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(167, 24);
            this.label27.TabIndex = 80;
            this.label27.Text = "Квалификация";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label27.Visible = false;
            // 
            // label28
            // 
            this.label28.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label28.Location = new System.Drawing.Point(335, 41);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(171, 49);
            this.label28.TabIndex = 79;
            this.label28.Text = "Образовательная\r\nорганизация";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label28.Visible = false;
            // 
            // label33
            // 
            this.label33.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label33.Location = new System.Drawing.Point(27, 51);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(123, 24);
            this.label33.TabIndex = 78;
            this.label33.Text = "Номер";
            this.label33.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label33.Visible = false;
            // 
            // label34
            // 
            this.label34.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label34.Location = new System.Drawing.Point(340, 103);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(165, 23);
            this.label34.TabIndex = 77;
            this.label34.Text = "Дата окончания";
            this.label34.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label34.Visible = false;
            this.label34.Click += new System.EventHandler(this.label34_Click);
            // 
            // maskedTextBox_addrPass
            // 
            this.maskedTextBox_addrPass.AsciiOnly = true;
            this.maskedTextBox_addrPass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBox_addrPass.Location = new System.Drawing.Point(383, 198);
            this.maskedTextBox_addrPass.Name = "maskedTextBox_addrPass";
            this.maskedTextBox_addrPass.Size = new System.Drawing.Size(220, 26);
            this.maskedTextBox_addrPass.TabIndex = 98;
            this.maskedTextBox_addrPass.Text = "Регион. Район.  Г.  Ул.  Д.";
            this.maskedTextBox_addrPass.Visible = false;
            // 
            // comboBox_famPass
            // 
            this.comboBox_famPass.DropDownWidth = 400;
            this.comboBox_famPass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_famPass.FormattingEnabled = true;
            this.comboBox_famPass.Location = new System.Drawing.Point(454, 148);
            this.comboBox_famPass.Name = "comboBox_famPass";
            this.comboBox_famPass.Size = new System.Drawing.Size(148, 27);
            this.comboBox_famPass.TabIndex = 97;
            this.comboBox_famPass.Visible = false;
            // 
            // maskedTextBox_numberPass
            // 
            this.maskedTextBox_numberPass.AsciiOnly = true;
            this.maskedTextBox_numberPass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBox_numberPass.Location = new System.Drawing.Point(123, 198);
            this.maskedTextBox_numberPass.Mask = "000000";
            this.maskedTextBox_numberPass.Name = "maskedTextBox_numberPass";
            this.maskedTextBox_numberPass.Size = new System.Drawing.Size(149, 26);
            this.maskedTextBox_numberPass.TabIndex = 96;
            this.maskedTextBox_numberPass.Visible = false;
            this.maskedTextBox_numberPass.Leave += new System.EventHandler(this.maskedTextBox_numberPass_Leave);
            // 
            // maskedTextBox_seriaPass
            // 
            this.maskedTextBox_seriaPass.AsciiOnly = true;
            this.maskedTextBox_seriaPass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBox_seriaPass.Location = new System.Drawing.Point(124, 148);
            this.maskedTextBox_seriaPass.Mask = "00 00";
            this.maskedTextBox_seriaPass.Name = "maskedTextBox_seriaPass";
            this.maskedTextBox_seriaPass.Size = new System.Drawing.Size(149, 26);
            this.maskedTextBox_seriaPass.TabIndex = 95;
            this.maskedTextBox_seriaPass.Visible = false;
            this.maskedTextBox_seriaPass.Leave += new System.EventHandler(this.maskedTextBox_seriaPass_Leave);
            // 
            // label21
            // 
            this.label21.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label21.Location = new System.Drawing.Point(16, 198);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(101, 24);
            this.label21.TabIndex = 94;
            this.label21.Text = "Номер";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label21.Visible = false;
            // 
            // label22
            // 
            this.label22.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label22.Location = new System.Drawing.Point(34, 148);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(83, 24);
            this.label22.TabIndex = 93;
            this.label22.Text = "Серия";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label22.Visible = false;
            // 
            // comboBox_citizenshipPass
            // 
            this.comboBox_citizenshipPass.DropDownWidth = 465;
            this.comboBox_citizenshipPass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_citizenshipPass.FormattingEnabled = true;
            this.comboBox_citizenshipPass.Location = new System.Drawing.Point(454, 46);
            this.comboBox_citizenshipPass.Name = "comboBox_citizenshipPass";
            this.comboBox_citizenshipPass.Size = new System.Drawing.Size(148, 27);
            this.comboBox_citizenshipPass.TabIndex = 92;
            this.comboBox_citizenshipPass.Visible = false;
            // 
            // comboBox_wherePass
            // 
            this.comboBox_wherePass.DropDownWidth = 450;
            this.comboBox_wherePass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_wherePass.FormattingEnabled = true;
            this.comboBox_wherePass.Location = new System.Drawing.Point(454, 1);
            this.comboBox_wherePass.Name = "comboBox_wherePass";
            this.comboBox_wherePass.Size = new System.Drawing.Size(148, 27);
            this.comboBox_wherePass.TabIndex = 91;
            this.comboBox_wherePass.Visible = false;
            // 
            // maskedTextBox_dateGivenPass
            // 
            this.maskedTextBox_dateGivenPass.AsciiOnly = true;
            this.maskedTextBox_dateGivenPass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBox_dateGivenPass.Location = new System.Drawing.Point(454, 100);
            this.maskedTextBox_dateGivenPass.Mask = "00/00/0000";
            this.maskedTextBox_dateGivenPass.Name = "maskedTextBox_dateGivenPass";
            this.maskedTextBox_dateGivenPass.Size = new System.Drawing.Size(149, 26);
            this.maskedTextBox_dateGivenPass.TabIndex = 90;
            this.maskedTextBox_dateGivenPass.ValidatingType = typeof(System.DateTime);
            this.maskedTextBox_dateGivenPass.Visible = false;
            this.maskedTextBox_dateGivenPass.Leave += new System.EventHandler(this.maskedTextBox_dateGivenPass_Leave);
            // 
            // maskedTextBox_fathnamePass
            // 
            this.maskedTextBox_fathnamePass.AsciiOnly = true;
            this.maskedTextBox_fathnamePass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBox_fathnamePass.Location = new System.Drawing.Point(123, 100);
            this.maskedTextBox_fathnamePass.Name = "maskedTextBox_fathnamePass";
            this.maskedTextBox_fathnamePass.Size = new System.Drawing.Size(149, 26);
            this.maskedTextBox_fathnamePass.TabIndex = 89;
            this.maskedTextBox_fathnamePass.Visible = false;
            // 
            // maskedTextBox_namePass
            // 
            this.maskedTextBox_namePass.AsciiOnly = true;
            this.maskedTextBox_namePass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBox_namePass.Location = new System.Drawing.Point(124, 50);
            this.maskedTextBox_namePass.Name = "maskedTextBox_namePass";
            this.maskedTextBox_namePass.Size = new System.Drawing.Size(149, 26);
            this.maskedTextBox_namePass.TabIndex = 88;
            this.maskedTextBox_namePass.Visible = false;
            // 
            // maskedTextBox_surnamePass
            // 
            this.maskedTextBox_surnamePass.AsciiOnly = true;
            this.maskedTextBox_surnamePass.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBox_surnamePass.Location = new System.Drawing.Point(124, 0);
            this.maskedTextBox_surnamePass.Name = "maskedTextBox_surnamePass";
            this.maskedTextBox_surnamePass.Size = new System.Drawing.Size(149, 26);
            this.maskedTextBox_surnamePass.TabIndex = 87;
            this.maskedTextBox_surnamePass.Visible = false;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(276, 200);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 24);
            this.label13.TabIndex = 85;
            this.label13.Text = "Прописка";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label13.Visible = false;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(316, 139);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(125, 47);
            this.label14.TabIndex = 83;
            this.label14.Text = "Семейное\r\n Положение";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label14.Visible = false;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(291, 100);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(151, 24);
            this.label15.TabIndex = 82;
            this.label15.Text = "Дата Выдачи";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label15.Visible = false;
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(313, 46);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(128, 23);
            this.label16.TabIndex = 81;
            this.label16.Text = "Гражданство";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label16.Visible = false;
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(319, 1);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(128, 24);
            this.label17.TabIndex = 80;
            this.label17.Text = "Кем Выдан";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label17.Visible = false;
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.Location = new System.Drawing.Point(16, 100);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(101, 24);
            this.label18.TabIndex = 79;
            this.label18.Text = "Отчество";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label18.Visible = false;
            // 
            // label19
            // 
            this.label19.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label19.Location = new System.Drawing.Point(34, 50);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(83, 24);
            this.label19.TabIndex = 78;
            this.label19.Text = "Имя";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label19.Visible = false;
            // 
            // label20
            // 
            this.label20.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label20.Location = new System.Drawing.Point(20, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(97, 23);
            this.label20.TabIndex = 77;
            this.label20.Text = "Фамилия";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label20.Visible = false;
            // 
            // comboBox_inp_gender
            // 
            this.comboBox_inp_gender.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_inp_gender.FormattingEnabled = true;
            this.comboBox_inp_gender.Location = new System.Drawing.Point(110, 197);
            this.comboBox_inp_gender.Name = "comboBox_inp_gender";
            this.comboBox_inp_gender.Size = new System.Drawing.Size(148, 27);
            this.comboBox_inp_gender.TabIndex = 76;
            this.comboBox_inp_gender.Visible = false;
            // 
            // comboBox_inp_job
            // 
            this.comboBox_inp_job.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_inp_job.FormattingEnabled = true;
            this.comboBox_inp_job.Location = new System.Drawing.Point(110, 152);
            this.comboBox_inp_job.Name = "comboBox_inp_job";
            this.comboBox_inp_job.Size = new System.Drawing.Size(148, 27);
            this.comboBox_inp_job.TabIndex = 75;
            this.comboBox_inp_job.Visible = false;
            // 
            // maskedTextBox_inp_mail
            // 
            this.maskedTextBox_inp_mail.AsciiOnly = true;
            this.maskedTextBox_inp_mail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBox_inp_mail.Location = new System.Drawing.Point(750, 52);
            this.maskedTextBox_inp_mail.Name = "maskedTextBox_inp_mail";
            this.maskedTextBox_inp_mail.Size = new System.Drawing.Size(149, 26);
            this.maskedTextBox_inp_mail.TabIndex = 74;
            this.maskedTextBox_inp_mail.Visible = false;
            // 
            // maskedTextBox_inp_phone
            // 
            this.maskedTextBox_inp_phone.AsciiOnly = true;
            this.maskedTextBox_inp_phone.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBox_inp_phone.Location = new System.Drawing.Point(750, 2);
            this.maskedTextBox_inp_phone.Mask = "(999) 000-0000";
            this.maskedTextBox_inp_phone.Name = "maskedTextBox_inp_phone";
            this.maskedTextBox_inp_phone.Size = new System.Drawing.Size(149, 26);
            this.maskedTextBox_inp_phone.TabIndex = 73;
            this.maskedTextBox_inp_phone.Visible = false;
            // 
            // maskedTextBox_inp_birthday
            // 
            this.maskedTextBox_inp_birthday.AsciiOnly = true;
            this.maskedTextBox_inp_birthday.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBox_inp_birthday.Location = new System.Drawing.Point(440, 102);
            this.maskedTextBox_inp_birthday.Mask = "00/00/0000";
            this.maskedTextBox_inp_birthday.Name = "maskedTextBox_inp_birthday";
            this.maskedTextBox_inp_birthday.Size = new System.Drawing.Size(149, 26);
            this.maskedTextBox_inp_birthday.TabIndex = 71;
            this.maskedTextBox_inp_birthday.ValidatingType = typeof(System.DateTime);
            this.maskedTextBox_inp_birthday.Visible = false;
            this.maskedTextBox_inp_birthday.Leave += new System.EventHandler(this.maskedTextBox_inp_birthday_Leave);
            // 
            // maskedTextBox_inp_snils
            // 
            this.maskedTextBox_inp_snils.AsciiOnly = true;
            this.maskedTextBox_inp_snils.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBox_inp_snils.Location = new System.Drawing.Point(440, 52);
            this.maskedTextBox_inp_snils.Mask = "000-000-000-00";
            this.maskedTextBox_inp_snils.Name = "maskedTextBox_inp_snils";
            this.maskedTextBox_inp_snils.Size = new System.Drawing.Size(149, 26);
            this.maskedTextBox_inp_snils.TabIndex = 70;
            this.maskedTextBox_inp_snils.Visible = false;
            this.maskedTextBox_inp_snils.Leave += new System.EventHandler(this.maskedTextBox_inp_snils_Leave);
            // 
            // maskedTextBoxinp_inn
            // 
            this.maskedTextBoxinp_inn.AsciiOnly = true;
            this.maskedTextBoxinp_inn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBoxinp_inn.Location = new System.Drawing.Point(440, 1);
            this.maskedTextBoxinp_inn.Mask = "000000000000";
            this.maskedTextBoxinp_inn.Name = "maskedTextBoxinp_inn";
            this.maskedTextBoxinp_inn.Size = new System.Drawing.Size(149, 26);
            this.maskedTextBoxinp_inn.TabIndex = 69;
            this.maskedTextBoxinp_inn.Visible = false;
            this.maskedTextBoxinp_inn.Leave += new System.EventHandler(this.maskedTextBoxinp_inn_Leave);
            // 
            // maskedTextBox_fathName
            // 
            this.maskedTextBox_fathName.AsciiOnly = true;
            this.maskedTextBox_fathName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBox_fathName.Location = new System.Drawing.Point(109, 102);
            this.maskedTextBox_fathName.Name = "maskedTextBox_fathName";
            this.maskedTextBox_fathName.Size = new System.Drawing.Size(149, 26);
            this.maskedTextBox_fathName.TabIndex = 68;
            this.maskedTextBox_fathName.Visible = false;
            // 
            // maskedTextBox_name
            // 
            this.maskedTextBox_name.AsciiOnly = true;
            this.maskedTextBox_name.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBox_name.Location = new System.Drawing.Point(110, 52);
            this.maskedTextBox_name.Name = "maskedTextBox_name";
            this.maskedTextBox_name.Size = new System.Drawing.Size(149, 26);
            this.maskedTextBox_name.TabIndex = 67;
            this.maskedTextBox_name.Visible = false;
            // 
            // maskedTextBox_surname
            // 
            this.maskedTextBox_surname.AsciiOnly = true;
            this.maskedTextBox_surname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBox_surname.Location = new System.Drawing.Point(110, 2);
            this.maskedTextBox_surname.Name = "maskedTextBox_surname";
            this.maskedTextBox_surname.Size = new System.Drawing.Size(149, 26);
            this.maskedTextBox_surname.TabIndex = 66;
            this.maskedTextBox_surname.Visible = false;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(642, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 24);
            this.label5.TabIndex = 65;
            this.label5.Text = "Фото";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox_image
            // 
            this.pictureBox_image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_image.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox_image.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox_image.ErrorImage")));
            this.pictureBox_image.Location = new System.Drawing.Point(749, 102);
            this.pictureBox_image.Name = "pictureBox_image";
            this.pictureBox_image.Size = new System.Drawing.Size(100, 120);
            this.pictureBox_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_image.TabIndex = 64;
            this.pictureBox_image.TabStop = false;
            // 
            // textBox_mail
            // 
            this.textBox_mail.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_mail.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox_mail.Location = new System.Drawing.Point(749, 51);
            this.textBox_mail.Name = "textBox_mail";
            this.textBox_mail.ReadOnly = true;
            this.textBox_mail.Size = new System.Drawing.Size(150, 26);
            this.textBox_mail.TabIndex = 63;
            this.textBox_mail.Text = "Неизвестно";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(642, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 24);
            this.label9.TabIndex = 62;
            this.label9.Text = "Эл. Почта";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_phone
            // 
            this.textBox_phone.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_phone.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox_phone.Location = new System.Drawing.Point(749, 1);
            this.textBox_phone.Name = "textBox_phone";
            this.textBox_phone.ReadOnly = true;
            this.textBox_phone.Size = new System.Drawing.Size(150, 26);
            this.textBox_phone.TabIndex = 61;
            this.textBox_phone.Text = "Неизвестно";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(629, 1);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 24);
            this.label10.TabIndex = 60;
            this.label10.Text = "Телефон";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_snils
            // 
            this.textBox_snils.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_snils.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox_snils.Location = new System.Drawing.Point(440, 52);
            this.textBox_snils.Name = "textBox_snils";
            this.textBox_snils.ReadOnly = true;
            this.textBox_snils.Size = new System.Drawing.Size(150, 26);
            this.textBox_snils.TabIndex = 59;
            this.textBox_snils.Text = "Неизвестно";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(320, 52);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 24);
            this.label11.TabIndex = 58;
            this.label11.Text = "СНИЛС";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_inn
            // 
            this.textBox_inn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_inn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox_inn.Location = new System.Drawing.Point(440, 2);
            this.textBox_inn.Name = "textBox_inn";
            this.textBox_inn.ReadOnly = true;
            this.textBox_inn.Size = new System.Drawing.Size(150, 26);
            this.textBox_inn.TabIndex = 57;
            this.textBox_inn.Text = "Неизвестно";
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(324, 2);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(110, 23);
            this.label12.TabIndex = 56;
            this.label12.Text = "ИНН";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_addr
            // 
            this.textBox_addr.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_addr.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox_addr.Location = new System.Drawing.Point(370, 202);
            this.textBox_addr.Name = "textBox_addr";
            this.textBox_addr.ReadOnly = true;
            this.textBox_addr.Size = new System.Drawing.Size(220, 26);
            this.textBox_addr.TabIndex = 55;
            this.textBox_addr.Text = "Неизвестно";
            this.textBox_addr.MouseHover += new System.EventHandler(this.textBox_addr_MouseHover);
            // 
            // label
            // 
            this.label.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label.Location = new System.Drawing.Point(296, 202);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(62, 24);
            this.label.TabIndex = 54;
            this.label.Text = "Адрес";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(266, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 24);
            this.label6.TabIndex = 52;
            this.label6.Text = "Место Рождения";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_birthday
            // 
            this.textBox_birthday.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_birthday.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox_birthday.Location = new System.Drawing.Point(440, 102);
            this.textBox_birthday.Name = "textBox_birthday";
            this.textBox_birthday.ReadOnly = true;
            this.textBox_birthday.Size = new System.Drawing.Size(150, 26);
            this.textBox_birthday.TabIndex = 51;
            this.textBox_birthday.Text = "Неизвестно";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(277, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 24);
            this.label7.TabIndex = 50;
            this.label7.Text = "Дата Рождения";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_gender
            // 
            this.textBox_gender.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_gender.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox_gender.Location = new System.Drawing.Point(109, 197);
            this.textBox_gender.Name = "textBox_gender";
            this.textBox_gender.ReadOnly = true;
            this.textBox_gender.Size = new System.Drawing.Size(150, 26);
            this.textBox_gender.TabIndex = 49;
            this.textBox_gender.Text = "Неизвестно";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(5, 197);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 23);
            this.label8.TabIndex = 48;
            this.label8.Text = "Пол";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_job
            // 
            this.textBox_job.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_job.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox_job.Location = new System.Drawing.Point(109, 152);
            this.textBox_job.Name = "textBox_job";
            this.textBox_job.ReadOnly = true;
            this.textBox_job.Size = new System.Drawing.Size(150, 26);
            this.textBox_job.TabIndex = 47;
            this.textBox_job.Text = "Неизвестно";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(-5, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 24);
            this.label4.TabIndex = 46;
            this.label4.Text = "Должность";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_fathname
            // 
            this.textBox_fathname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_fathname.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox_fathname.Location = new System.Drawing.Point(109, 102);
            this.textBox_fathname.Name = "textBox_fathname";
            this.textBox_fathname.ReadOnly = true;
            this.textBox_fathname.Size = new System.Drawing.Size(150, 26);
            this.textBox_fathname.TabIndex = 45;
            this.textBox_fathname.Text = "Неизвестно";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(2, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 24);
            this.label3.TabIndex = 44;
            this.label3.Text = "Отчество";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_name
            // 
            this.textBox_name.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_name.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox_name.Location = new System.Drawing.Point(109, 52);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.ReadOnly = true;
            this.textBox_name.Size = new System.Drawing.Size(150, 26);
            this.textBox_name.TabIndex = 43;
            this.textBox_name.Text = "Неизвестно";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(20, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 24);
            this.label2.TabIndex = 42;
            this.label2.Text = "Имя";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_surname
            // 
            this.textBox_surname.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_surname.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox_surname.Location = new System.Drawing.Point(109, 2);
            this.textBox_surname.Name = "textBox_surname";
            this.textBox_surname.ReadOnly = true;
            this.textBox_surname.Size = new System.Drawing.Size(150, 26);
            this.textBox_surname.TabIndex = 41;
            this.textBox_surname.Text = "Неизвестно";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 23);
            this.label1.TabIndex = 40;
            this.label1.Text = "Фамилия";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox_city
            // 
            this.textBox_city.AccessibleDescription = "";
            this.textBox_city.AllowDrop = true;
            this.textBox_city.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_city.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBox_city.Location = new System.Drawing.Point(440, 152);
            this.textBox_city.Name = "textBox_city";
            this.textBox_city.ReadOnly = true;
            this.textBox_city.Size = new System.Drawing.Size(150, 26);
            this.textBox_city.TabIndex = 53;
            this.textBox_city.Text = "Неизвестно";
            this.textBox_city.MouseHover += new System.EventHandler(this.textBox_city_MouseHover);
            // 
            // comboBox_inp_city
            // 
            this.comboBox_inp_city.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_inp_city.FormattingEnabled = true;
            this.comboBox_inp_city.Location = new System.Drawing.Point(441, 152);
            this.comboBox_inp_city.Name = "comboBox_inp_city";
            this.comboBox_inp_city.Size = new System.Drawing.Size(148, 27);
            this.comboBox_inp_city.TabIndex = 77;
            this.comboBox_inp_city.Visible = false;
            // 
            // maskedTextBox_inp_addr
            // 
            this.maskedTextBox_inp_addr.AsciiOnly = true;
            this.maskedTextBox_inp_addr.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBox_inp_addr.Location = new System.Drawing.Point(370, 202);
            this.maskedTextBox_inp_addr.Name = "maskedTextBox_inp_addr";
            this.maskedTextBox_inp_addr.Size = new System.Drawing.Size(219, 26);
            this.maskedTextBox_inp_addr.TabIndex = 72;
            this.maskedTextBox_inp_addr.Text = "Регион. Район.  Г.  Ул.  Д.";
            this.maskedTextBox_inp_addr.Visible = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(-1, 1);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(900, 228);
            this.dataGridView2.TabIndex = 78;
            this.dataGridView2.Visible = false;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            this.dataGridView2.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView2_RowsAdded);
            this.dataGridView2.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridView2_RowsRemoved);
            this.dataGridView2.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dataGridView2_RowStateChanged);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.menuStrip2);
            this.panel4.Location = new System.Drawing.Point(0, 275);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1068, 22);
            this.panel4.TabIndex = 11;
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.общееToolStripMenuItem,
            this.паспортToolStripMenuItem,
            this.карьераToolStripMenuItem,
            this.образованиеToolStripMenuItem,
            this.семьяToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1068, 24);
            this.menuStrip2.TabIndex = 0;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // общееToolStripMenuItem
            // 
            this.общееToolStripMenuItem.Name = "общееToolStripMenuItem";
            this.общееToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.общееToolStripMenuItem.Text = "Общее";
            this.общееToolStripMenuItem.Click += new System.EventHandler(this.общееToolStripMenuItem_Click_1);
            // 
            // паспортToolStripMenuItem
            // 
            this.паспортToolStripMenuItem.Name = "паспортToolStripMenuItem";
            this.паспортToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.паспортToolStripMenuItem.Text = "Паспорт";
            this.паспортToolStripMenuItem.Click += new System.EventHandler(this.паспортToolStripMenuItem_Click_2);
            // 
            // карьераToolStripMenuItem
            // 
            this.карьераToolStripMenuItem.Name = "карьераToolStripMenuItem";
            this.карьераToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.карьераToolStripMenuItem.Text = "Карьера";
            this.карьераToolStripMenuItem.Click += new System.EventHandler(this.карьераToolStripMenuItem_Click);
            // 
            // образованиеToolStripMenuItem
            // 
            this.образованиеToolStripMenuItem.Name = "образованиеToolStripMenuItem";
            this.образованиеToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.образованиеToolStripMenuItem.Text = "Образование";
            this.образованиеToolStripMenuItem.Click += new System.EventHandler(this.образованиеToolStripMenuItem_Click);
            // 
            // семьяToolStripMenuItem
            // 
            this.семьяToolStripMenuItem.Name = "семьяToolStripMenuItem";
            this.семьяToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.семьяToolStripMenuItem.Text = "Семья";
            this.семьяToolStripMenuItem.Click += new System.EventHandler(this.семьяToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 572);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel3);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1072, 611);
            this.MinimumSize = new System.Drawing.Size(1072, 611);
            this.Name = "Form1";
            this.Text = "Система Учета Кадров";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel_changePass.ResumeLayout(false);
            this.panel_changePass.PerformLayout();
            this.panel_changeCareer.ResumeLayout(false);
            this.panel_changeCareer.PerformLayout();
            this.panel_changeRelative.ResumeLayout(false);
            this.panel_changeRelative.PerformLayout();
            this.panel_changeEducation.ResumeLayout(false);
            this.panel_changeEducation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem приложениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem посмотретьОтчетToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem управлениеДаннымиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem руководствоToolStripMenuItem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_cancelChanges;
        private System.Windows.Forms.Button button_saveChanges;
        private System.Windows.Forms.Button button_deleteWorker;
        private System.Windows.Forms.Button button_changeWorker;
        private System.Windows.Forms.Button button_addWorker;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem общееToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem паспортToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem карьераToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem образованиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem семьяToolStripMenuItem;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.ComboBox comboBox_inp_city;
        private System.Windows.Forms.ComboBox comboBox_inp_gender;
        private System.Windows.Forms.ComboBox comboBox_inp_job;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_inp_mail;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_inp_phone;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_inp_addr;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_inp_birthday;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_inp_snils;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxinp_inn;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_fathName;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_name;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_surname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox_image;
        private System.Windows.Forms.TextBox textBox_mail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_phone;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_snils;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox_inn;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox_addr;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox textBox_city;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_birthday;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_gender;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_job;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_fathname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_surname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_changePass;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_addrPass;
        private System.Windows.Forms.ComboBox comboBox_famPass;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_numberPass;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_seriaPass;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox comboBox_citizenshipPass;
        private System.Windows.Forms.ComboBox comboBox_wherePass;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_dateGivenPass;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_fathnamePass;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_namePass;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_surnamePass;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Panel panel_changeCareer;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_numCareer;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox comboBox_jobCareer;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_salaryCareer;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_dateCareer;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.ComboBox comboBox_tdCareer;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Panel panel_changeEducation;
        private System.Windows.Forms.ComboBox comboBox_specialityEdu;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.ComboBox comboBox_typeEdu;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_seriaEdu;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.ComboBox comboBox_qualificationEdu;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_numberEdu;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_dateEdu;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.ComboBox comboBox_ooEdu;
        private System.Windows.Forms.Panel panel_changeRelative;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_fathnameRel;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_surnameRel;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.ComboBox comboBox_typeRel;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_nameRel;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_birthdayRel;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.ToolStripMenuItem гражданствоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem местоРожденияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отделениеМВДToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem семейноеПоложениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem типРодтсвеннойСвязиToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem должностьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem типТрудовогоДоговораToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem трудовойДоговорToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem квалификацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem образовательнаяОрганизацияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem специальностьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem типОбразованияToolStripMenuItem;
        private System.Windows.Forms.Button button_word;
        public System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ToolStripMenuItem форма1кадрыToolStripMenuItem;
    }
}

