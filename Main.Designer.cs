namespace HR_Ahentsiia
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.login = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.registration = new System.Windows.Forms.Label();
            this.about_program = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Логін";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Пароль";
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Gold;
            this.exit.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.Color.DarkGreen;
            this.exit.Location = new System.Drawing.Point(89, 124);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(110, 23);
            this.exit.TabIndex = 2;
            this.exit.Text = "Вхід";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.button1_Click);
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(76, 35);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(164, 20);
            this.login.TabIndex = 3;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(76, 66);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(164, 20);
            this.password.TabIndex = 4;
            // 
            // registration
            // 
            this.registration.BackColor = System.Drawing.Color.LightCyan;
            this.registration.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registration.ForeColor = System.Drawing.Color.DodgerBlue;
            this.registration.Location = new System.Drawing.Point(99, 98);
            this.registration.Name = "registration";
            this.registration.Size = new System.Drawing.Size(100, 23);
            this.registration.TabIndex = 0;
            this.registration.Text = "Рєеєстрація";
            this.registration.Click += new System.EventHandler(this.registration_Click_1);
            // 
            // about_program
            // 
            this.about_program.AutoSize = true;
            this.about_program.Font = new System.Drawing.Font("Modern No. 20", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.about_program.ForeColor = System.Drawing.Color.BlueViolet;
            this.about_program.Location = new System.Drawing.Point(99, 159);
            this.about_program.Name = "about_program";
            this.about_program.Size = new System.Drawing.Size(79, 15);
            this.about_program.TabIndex = 5;
            this.about_program.Text = "Про програму";
            this.about_program.Click += new System.EventHandler(this.about_program_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(259, 193);
            this.Controls.Add(this.about_program);
            this.Controls.Add(this.registration);
            this.Controls.Add(this.password);
            this.Controls.Add(this.login);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Кадрова агенція";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label registration;
        private System.Windows.Forms.Label about_program;
    }
}

