namespace HR_Ahentsiia
{
    partial class Agency_worker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agency_worker));
            this.list_vacancu = new System.Windows.Forms.DataGridView();
            this.list_candidate = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.all_users = new System.Windows.Forms.Button();
            this.confirm = new System.Windows.Forms.Button();
            this.noconfirm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.list_vacancu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.list_candidate)).BeginInit();
            this.SuspendLayout();
            // 
            // list_vacancu
            // 
            this.list_vacancu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.list_vacancu.Location = new System.Drawing.Point(12, 27);
            this.list_vacancu.Name = "list_vacancu";
            this.list_vacancu.Size = new System.Drawing.Size(562, 176);
            this.list_vacancu.TabIndex = 0;
            this.list_vacancu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.list_vacancu_CellClick);
            // 
            // list_candidate
            // 
            this.list_candidate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.list_candidate.Location = new System.Drawing.Point(15, 234);
            this.list_candidate.Name = "list_candidate";
            this.list_candidate.Size = new System.Drawing.Size(598, 181);
            this.list_candidate.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SkyBlue;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Cписок заявок";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SkyBlue;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cписок претендентов";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gold;
            this.button2.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(614, 138);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Переглянути звіт";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // all_users
            // 
            this.all_users.BackColor = System.Drawing.Color.Gold;
            this.all_users.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.all_users.Location = new System.Drawing.Point(614, 68);
            this.all_users.Name = "all_users";
            this.all_users.Size = new System.Drawing.Size(138, 50);
            this.all_users.TabIndex = 8;
            this.all_users.Text = "Переглянути всіх користувачів";
            this.all_users.UseVisualStyleBackColor = false;
            this.all_users.Click += new System.EventHandler(this.all_users_Click);
            // 
            // confirm
            // 
            this.confirm.BackColor = System.Drawing.Color.Orchid;
            this.confirm.Location = new System.Drawing.Point(639, 234);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(104, 43);
            this.confirm.TabIndex = 10;
            this.confirm.Text = "Прийняти резюме";
            this.confirm.UseVisualStyleBackColor = false;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // noconfirm
            // 
            this.noconfirm.BackColor = System.Drawing.Color.Tomato;
            this.noconfirm.Location = new System.Drawing.Point(639, 303);
            this.noconfirm.Name = "noconfirm";
            this.noconfirm.Size = new System.Drawing.Size(104, 43);
            this.noconfirm.TabIndex = 11;
            this.noconfirm.Text = "Не прийняти резюме";
            this.noconfirm.UseVisualStyleBackColor = false;
            this.noconfirm.Click += new System.EventHandler(this.noconfirm_Click);
            // 
            // Agency_worker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(764, 423);
            this.Controls.Add(this.noconfirm);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.all_users);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.list_candidate);
            this.Controls.Add(this.list_vacancu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Agency_worker";
            this.Text = "Працівник кадрової агенції";
            this.Load += new System.EventHandler(this.Agency_worker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.list_vacancu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.list_candidate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView list_vacancu;
        private System.Windows.Forms.DataGridView list_candidate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button all_users;
        private System.Windows.Forms.Button confirm;
        private System.Windows.Forms.Button noconfirm;
    }
}