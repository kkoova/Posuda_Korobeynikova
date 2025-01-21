namespace DemoPosuda.Contrrols
{
    partial class UserControlTovar
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxTovar = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelPriseTovar = new System.Windows.Forms.Label();
            this.labelProizvTovar = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelDeckTovar = new System.Windows.Forms.Label();
            this.labelNameTovar = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonDellTovar = new System.Windows.Forms.Button();
            this.labelKolSclad = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTovar)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxTovar
            // 
            this.pictureBoxTovar.BackColor = System.Drawing.Color.White;
            this.pictureBoxTovar.Location = new System.Drawing.Point(21, 16);
            this.pictureBoxTovar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBoxTovar.Name = "pictureBoxTovar";
            this.pictureBoxTovar.Size = new System.Drawing.Size(168, 115);
            this.pictureBoxTovar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxTovar.TabIndex = 0;
            this.pictureBoxTovar.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelPriseTovar);
            this.panel1.Controls.Add(this.labelProizvTovar);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.labelDeckTovar);
            this.panel1.Controls.Add(this.labelNameTovar);
            this.panel1.Location = new System.Drawing.Point(197, 16);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(480, 115);
            this.panel1.TabIndex = 1;
            // 
            // labelPriseTovar
            // 
            this.labelPriseTovar.Font = new System.Drawing.Font("Comic Sans MS", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPriseTovar.Location = new System.Drawing.Point(97, 85);
            this.labelPriseTovar.Name = "labelPriseTovar";
            this.labelPriseTovar.Size = new System.Drawing.Size(290, 15);
            this.labelPriseTovar.TabIndex = 5;
            this.labelPriseTovar.Text = "1000";
            // 
            // labelProizvTovar
            // 
            this.labelProizvTovar.Font = new System.Drawing.Font("Comic Sans MS", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelProizvTovar.Location = new System.Drawing.Point(97, 71);
            this.labelProizvTovar.Name = "labelProizvTovar";
            this.labelProizvTovar.Size = new System.Drawing.Size(365, 14);
            this.labelProizvTovar.TabIndex = 4;
            this.labelProizvTovar.Text = "654";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(13, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Цена:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(13, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "Производитель:";
            // 
            // labelDeckTovar
            // 
            this.labelDeckTovar.Font = new System.Drawing.Font("Comic Sans MS", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDeckTovar.ForeColor = System.Drawing.Color.Black;
            this.labelDeckTovar.Location = new System.Drawing.Point(12, 34);
            this.labelDeckTovar.Name = "labelDeckTovar";
            this.labelDeckTovar.Size = new System.Drawing.Size(450, 31);
            this.labelDeckTovar.TabIndex = 1;
            this.labelDeckTovar.Text = "Описание";
            // 
            // labelNameTovar
            // 
            this.labelNameTovar.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold);
            this.labelNameTovar.Location = new System.Drawing.Point(12, 12);
            this.labelNameTovar.Name = "labelNameTovar";
            this.labelNameTovar.Size = new System.Drawing.Size(450, 22);
            this.labelNameTovar.TabIndex = 0;
            this.labelNameTovar.Text = "NAME";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.panel2.Controls.Add(this.buttonDellTovar);
            this.panel2.Controls.Add(this.labelKolSclad);
            this.panel2.Location = new System.Drawing.Point(685, 16);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(103, 115);
            this.panel2.TabIndex = 2;
            // 
            // buttonDellTovar
            // 
            this.buttonDellTovar.Enabled = false;
            this.buttonDellTovar.Location = new System.Drawing.Point(28, 92);
            this.buttonDellTovar.Name = "buttonDellTovar";
            this.buttonDellTovar.Size = new System.Drawing.Size(75, 23);
            this.buttonDellTovar.TabIndex = 6;
            this.buttonDellTovar.Text = "Удалить";
            this.buttonDellTovar.UseVisualStyleBackColor = true;
            this.buttonDellTovar.Click += new System.EventHandler(this.buttonDellTovar_Click);
            // 
            // labelKolSclad
            // 
            this.labelKolSclad.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelKolSclad.Location = new System.Drawing.Point(12, 12);
            this.labelKolSclad.Name = "labelKolSclad";
            this.labelKolSclad.Size = new System.Drawing.Size(79, 73);
            this.labelKolSclad.TabIndex = 6;
            this.labelKolSclad.Text = "0";
            this.labelKolSclad.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserControlTovar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(227)))), ((int)(((byte)(131)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBoxTovar);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "UserControlTovar";
            this.Size = new System.Drawing.Size(811, 149);
            this.Click += new System.EventHandler(this.UserControlTovar_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTovar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxTovar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelPriseTovar;
        private System.Windows.Forms.Label labelProizvTovar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelDeckTovar;
        private System.Windows.Forms.Label labelNameTovar;
        private System.Windows.Forms.Label labelKolSclad;
        private System.Windows.Forms.Button buttonDellTovar;
    }
}
