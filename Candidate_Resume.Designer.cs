namespace HR_Ahentsiia
{
    partial class Candidate_Resume
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Candidate_Resume));
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.MaskedTextBox();
            this.foreign_language = new System.Windows.Forms.RichTextBox();
            this.skills = new System.Windows.Forms.RichTextBox();
            this.education = new System.Windows.Forms.RichTextBox();
            this.experience = new System.Windows.Forms.RichTextBox();
            this.save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.SkyBlue;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 340);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Телефон";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.SkyBlue;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(0, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Професійні навички";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.SkyBlue;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(73, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "Освіта";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.SkyBlue;
            this.label8.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(31, 269);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 15);
            this.label8.TabIndex = 10;
            this.label8.Text = "Іноземна мова";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.SkyBlue;
            this.label9.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(31, 199);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 15);
            this.label9.TabIndex = 12;
            this.label9.Text = "Досвід роботи";
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(125, 340);
            this.phone.Mask = "(999) 000-0000";
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(93, 20);
            this.phone.TabIndex = 17;
            // 
            // foreign_language
            // 
            this.foreign_language.Location = new System.Drawing.Point(125, 267);
            this.foreign_language.Name = "foreign_language";
            this.foreign_language.Size = new System.Drawing.Size(215, 53);
            this.foreign_language.TabIndex = 18;
            this.foreign_language.Text = "";
            // 
            // skills
            // 
            this.skills.Location = new System.Drawing.Point(125, 22);
            this.skills.Name = "skills";
            this.skills.Size = new System.Drawing.Size(215, 78);
            this.skills.TabIndex = 19;
            this.skills.Text = "";
            // 
            // education
            // 
            this.education.Location = new System.Drawing.Point(125, 116);
            this.education.Name = "education";
            this.education.Size = new System.Drawing.Size(215, 74);
            this.education.TabIndex = 20;
            this.education.Text = "";
            // 
            // experience
            // 
            this.experience.Location = new System.Drawing.Point(125, 199);
            this.experience.Name = "experience";
            this.experience.Size = new System.Drawing.Size(215, 62);
            this.experience.TabIndex = 21;
            this.experience.Text = "";
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.Gold;
            this.save.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.Location = new System.Drawing.Point(125, 379);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(95, 25);
            this.save.TabIndex = 22;
            this.save.Text = "Зберегти";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // Candidate_Resume
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(363, 416);
            this.Controls.Add(this.save);
            this.Controls.Add(this.experience);
            this.Controls.Add(this.education);
            this.Controls.Add(this.skills);
            this.Controls.Add(this.foreign_language);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Candidate_Resume";
            this.Text = "Створення резюме";
            this.Load += new System.EventHandler(this.Candidate_Resume_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox phone;
        private System.Windows.Forms.RichTextBox foreign_language;
        private System.Windows.Forms.RichTextBox skills;
        private System.Windows.Forms.RichTextBox education;
        private System.Windows.Forms.RichTextBox experience;
        private System.Windows.Forms.Button save;
    }
}