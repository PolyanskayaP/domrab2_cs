namespace dz2_cs
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
            this.vvod = new System.Windows.Forms.TextBox();
            this.tb_ot = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.vivod = new System.Windows.Forms.TextBox();
            this.tb_do = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // vvod
            // 
            this.vvod.Location = new System.Drawing.Point(12, 36);
            this.vvod.Name = "vvod";
            this.vvod.Size = new System.Drawing.Size(552, 22);
            this.vvod.TabIndex = 0;
            this.vvod.TextChanged += new System.EventHandler(this.vvod_TextChanged);
            // 
            // tb_ot
            // 
            this.tb_ot.Location = new System.Drawing.Point(12, 129);
            this.tb_ot.Name = "tb_ot";
            this.tb_ot.Size = new System.Drawing.Size(100, 22);
            this.tb_ot.TabIndex = 1;
            this.tb_ot.TextChanged += new System.EventHandler(this.tb_ot_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(238, 286);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 94);
            this.button1.TabIndex = 3;
            this.button1.Text = "Изменить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // vivod
            // 
            this.vivod.Location = new System.Drawing.Point(12, 231);
            this.vivod.Name = "vivod";
            this.vivod.ReadOnly = true;
            this.vivod.Size = new System.Drawing.Size(552, 22);
            this.vivod.TabIndex = 5;
            this.vivod.TextChanged += new System.EventHandler(this.vivod_TextChanged);
            // 
            // tb_do
            // 
            this.tb_do.Location = new System.Drawing.Point(208, 129);
            this.tb_do.Name = "tb_do";
            this.tb_do.Size = new System.Drawing.Size(100, 22);
            this.tb_do.TabIndex = 6;
            this.tb_do.TextChanged += new System.EventHandler(this.tb_do_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Исходная строка";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Изменённая строка";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "1ая граница";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(222, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "2ая граница";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 402);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_do);
            this.Controls.Add(this.vivod);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_ot);
            this.Controls.Add(this.vvod);
            this.Name = "Form1";
            this.Text = "dz2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox vvod;
        private System.Windows.Forms.TextBox tb_ot;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox vivod;
        private System.Windows.Forms.TextBox tb_do;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}

