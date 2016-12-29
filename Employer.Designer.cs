namespace HR_Ahentsiia
{
    partial class Employer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employer));
            this.my_statement = new System.Windows.Forms.DataGridView();
            this.candidates = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.new_statement = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.my_statement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.candidates)).BeginInit();
            this.SuspendLayout();
            // 
            // my_statement
            // 
            this.my_statement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.my_statement.Location = new System.Drawing.Point(25, 84);
            this.my_statement.Name = "my_statement";
            this.my_statement.Size = new System.Drawing.Size(240, 150);
            this.my_statement.TabIndex = 14;
            this.my_statement.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.my_statement_CellClick);
            // 
            // candidates
            // 
            this.candidates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.candidates.Location = new System.Drawing.Point(289, 83);
            this.candidates.Name = "candidates";
            this.candidates.Size = new System.Drawing.Size(240, 150);
            this.candidates.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.SkyBlue;
            this.label8.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(327, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 15);
            this.label8.TabIndex = 17;
            this.label8.Text = "Список претендентів";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.SkyBlue;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(40, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 15);
            this.label7.TabIndex = 31;
            this.label7.Text = "Мої заявки";
            // 
            // new_statement
            // 
            this.new_statement.BackColor = System.Drawing.Color.Gold;
            this.new_statement.Font = new System.Drawing.Font("Modern No. 20", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_statement.Location = new System.Drawing.Point(74, 267);
            this.new_statement.Name = "new_statement";
            this.new_statement.Size = new System.Drawing.Size(134, 23);
            this.new_statement.TabIndex = 32;
            this.new_statement.Text = "Створити заявку";
            this.new_statement.UseVisualStyleBackColor = false;
            this.new_statement.Click += new System.EventHandler(this.new_statement_Click);
            // 
            // Employer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(588, 330);
            this.Controls.Add(this.new_statement);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.candidates);
            this.Controls.Add(this.my_statement);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Employer";
            this.Text = "Роботодавець";
            this.Load += new System.EventHandler(this.Employer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.my_statement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.candidates)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView my_statement;
        private System.Windows.Forms.DataGridView candidates;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button new_statement;
    }
}