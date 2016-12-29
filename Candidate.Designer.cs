namespace HR_Ahentsiia
{
    partial class Candidate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Candidate));
            this.section = new System.Windows.Forms.ComboBox();
            this.list_applications = new System.Windows.Forms.DataGridView();
            this.send_resume = new System.Windows.Forms.Button();
            this.change_resume = new System.Windows.Forms.Button();
            this.message = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lower_limit = new System.Windows.Forms.NumericUpDown();
            this.upper_limit = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.importance_salary = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.city = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.list_applications)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.message)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lower_limit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upper_limit)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // section
            // 
            this.section.FormattingEnabled = true;
            this.section.Items.AddRange(new object[] {
            "HRспециалисты",
            "IT",
            "Банки - Финансы",
            "Бухгалтерия Аудит ",
            "Гостиницы Рестораны ",
            "Дизайнерское дело",
            "Закупки и снабжение",
            "Культура - Мода",
            "Логистика - Таможня - Склад",
            "Маркетинг - Реклама - PR",
            "Медиа - Издательское дело",
            "Медицина - Здравоохранение",
            "Наука - Образование - Перевод",
            "Недвижимость",
            "Охрана и безопасность",
            "Промышленность - Производство",
            "Секретариат - Офис - АХО",
            "Сетевой маркетинг и MLM",
            "Страхование",
            "Строительство и Архитектура",
            "Сфера обслуживания",
            "Телекоммуникации и связь",
            "ТОП-Менеджмент",
            "Торговля и Продажи",
            "Транспорт - Авто ",
            "Туризм и Путешествия",
            "Фармация",
            "Юриспруденция",
            "Работа для студентов",
            "Фриланс и Удаленная работа",
            "Другие виды заработка"});
            this.section.Location = new System.Drawing.Point(63, 16);
            this.section.Name = "section";
            this.section.Size = new System.Drawing.Size(121, 21);
            this.section.TabIndex = 0;
            this.section.SelectedIndexChanged += new System.EventHandler(this.section_SelectedIndexChanged);
            // 
            // list_applications
            // 
            this.list_applications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.list_applications.Location = new System.Drawing.Point(15, 183);
            this.list_applications.Name = "list_applications";
            this.list_applications.Size = new System.Drawing.Size(550, 150);
            this.list_applications.TabIndex = 1;
            // 
            // send_resume
            // 
            this.send_resume.BackColor = System.Drawing.Color.YellowGreen;
            this.send_resume.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.send_resume.Location = new System.Drawing.Point(394, 71);
            this.send_resume.Name = "send_resume";
            this.send_resume.Size = new System.Drawing.Size(171, 23);
            this.send_resume.TabIndex = 2;
            this.send_resume.Text = "Відправити резюме";
            this.send_resume.UseVisualStyleBackColor = false;
            this.send_resume.Click += new System.EventHandler(this.send_resume_Click);
            // 
            // change_resume
            // 
            this.change_resume.BackColor = System.Drawing.Color.Orange;
            this.change_resume.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.change_resume.Location = new System.Drawing.Point(394, 18);
            this.change_resume.Name = "change_resume";
            this.change_resume.Size = new System.Drawing.Size(171, 23);
            this.change_resume.TabIndex = 3;
            this.change_resume.Text = "Редагувати резюме";
            this.change_resume.UseVisualStyleBackColor = false;
            this.change_resume.Click += new System.EventHandler(this.change_resume_Click);
            // 
            // message
            // 
            this.message.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.message.Location = new System.Drawing.Point(15, 402);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(550, 150);
            this.message.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SkyBlue;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(211, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Список заявок";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SkyBlue;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(153, 358);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Ви можете бути прийняті на такі посади";
            // 
            // lower_limit
            // 
            this.lower_limit.Increment = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.lower_limit.Location = new System.Drawing.Point(41, 32);
            this.lower_limit.Maximum = new decimal(new int[] {
            15000,
            0,
            0,
            0});
            this.lower_limit.Name = "lower_limit";
            this.lower_limit.Size = new System.Drawing.Size(120, 20);
            this.lower_limit.TabIndex = 7;
            this.lower_limit.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.lower_limit.ValueChanged += new System.EventHandler(this.upper_limit_ValueChanged);
            // 
            // upper_limit
            // 
            this.upper_limit.Increment = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.upper_limit.Location = new System.Drawing.Point(41, 61);
            this.upper_limit.Maximum = new decimal(new int[] {
            15000,
            0,
            0,
            0});
            this.upper_limit.Name = "upper_limit";
            this.upper_limit.Size = new System.Drawing.Size(120, 20);
            this.upper_limit.TabIndex = 8;
            this.upper_limit.Value = new decimal(new int[] {
            12000,
            0,
            0,
            0});
            this.upper_limit.ValueChanged += new System.EventHandler(this.upper_limit_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.SkyBlue;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Заробітна платня";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.SkyBlue;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "від";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.SkyBlue;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "до";
            // 
            // importance_salary
            // 
            this.importance_salary.AutoSize = true;
            this.importance_salary.BackColor = System.Drawing.Color.Aqua;
            this.importance_salary.Location = new System.Drawing.Point(203, 52);
            this.importance_salary.Name = "importance_salary";
            this.importance_salary.Size = new System.Drawing.Size(87, 17);
            this.importance_salary.TabIndex = 12;
            this.importance_salary.Text = "Не важливо";
            this.importance_salary.UseVisualStyleBackColor = false;
            this.importance_salary.CheckedChanged += new System.EventHandler(this.importance_salary_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lower_limit);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.upper_limit);
            this.panel1.Location = new System.Drawing.Point(15, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(172, 100);
            this.panel1.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.SkyBlue;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Розділ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.SkyBlue;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(211, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Місто";
            // 
            // city
            // 
            this.city.FormattingEnabled = true;
            this.city.Items.AddRange(new object[] {
            "Киев     ",
            "Харьков     ",
            "Одесса     ",
            "Днепропетровск     ",
            "Донецк     ",
            "Запорожье     ",
            "Львов     ",
            "Кривой Рог     ",
            "Николаев     ",
            "Мариуполь     ",
            "Луганск     ",
            "Севастополь     ",
            "Винница",
            "Макеевка     ",
            "Симферополь     ",
            "Херсон     ",
            "Полтава     ",
            "Чернигов     ",
            "Черкассы     ",
            "Житомир     ",
            "Сумы     ",
            "Хмельницкий     ",
            "Горловка     ",
            "Ровно     ",
            "Кировоград",
            "Днепродзержинск     ",
            "Черновцы     ",
            "Кременчуг     ",
            "Ивано-Франковск     ",
            "Тернополь     ",
            "Белая Церковь     ",
            "Луцк     ",
            "Краматорск     ",
            "Мелитополь     ",
            "Керчь     ",
            "Никополь     ",
            "Северодонецк     ",
            "Славянск     ",
            "Бердянск     ",
            "Ужгород     ",
            "Алчевск     ",
            "Павлоград     ",
            "Евпатория     ",
            "Лисичанск     ",
            "Каменец-Подольский"});
            this.city.Location = new System.Drawing.Point(252, 15);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(121, 21);
            this.city.TabIndex = 16;
            this.city.SelectedIndexChanged += new System.EventHandler(this.city_SelectedIndexChanged);
            // 
            // Candidate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(586, 572);
            this.Controls.Add(this.city);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.importance_salary);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.message);
            this.Controls.Add(this.change_resume);
            this.Controls.Add(this.send_resume);
            this.Controls.Add(this.list_applications);
            this.Controls.Add(this.section);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Candidate";
            this.Text = "Претендент";
            this.Load += new System.EventHandler(this.Candidate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.list_applications)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.message)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lower_limit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upper_limit)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox section;
        private System.Windows.Forms.DataGridView list_applications;
        private System.Windows.Forms.Button send_resume;
        private System.Windows.Forms.Button change_resume;
        private System.Windows.Forms.DataGridView message;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown lower_limit;
        private System.Windows.Forms.NumericUpDown upper_limit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox importance_salary;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox city;
    }
}