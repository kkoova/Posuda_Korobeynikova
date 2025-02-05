namespace DemoPosuda.CustomContrrols
{
    partial class ZakazControl
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelKolvo = new System.Windows.Forms.Label();
            this.labelArticul = new System.Windows.Forms.Label();
            this.labelDataStart = new System.Windows.Forms.Label();
            this.labelDataEnd = new System.Windows.Forms.Label();
            this.labelPunct = new System.Windows.Forms.Label();
            this.labelFIO = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelcode = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelKolvo);
            this.panel1.Controls.Add(this.labelArticul);
            this.panel1.Location = new System.Drawing.Point(16, 17);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(195, 102);
            this.panel1.TabIndex = 0;
            // 
            // labelKolvo
            // 
            this.labelKolvo.AutoSize = true;
            this.labelKolvo.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelKolvo.Location = new System.Drawing.Point(18, 57);
            this.labelKolvo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelKolvo.Name = "labelKolvo";
            this.labelKolvo.Size = new System.Drawing.Size(56, 23);
            this.labelKolvo.TabIndex = 1;
            this.labelKolvo.Text = "label2";
            // 
            // labelArticul
            // 
            this.labelArticul.AutoSize = true;
            this.labelArticul.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelArticul.Location = new System.Drawing.Point(18, 18);
            this.labelArticul.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelArticul.Name = "labelArticul";
            this.labelArticul.Size = new System.Drawing.Size(53, 23);
            this.labelArticul.TabIndex = 0;
            this.labelArticul.Text = "label1";
            // 
            // labelDataStart
            // 
            this.labelDataStart.AutoSize = true;
            this.labelDataStart.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDataStart.Location = new System.Drawing.Point(34, 145);
            this.labelDataStart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDataStart.Name = "labelDataStart";
            this.labelDataStart.Size = new System.Drawing.Size(56, 23);
            this.labelDataStart.TabIndex = 2;
            this.labelDataStart.Text = "label3";
            // 
            // labelDataEnd
            // 
            this.labelDataEnd.AutoSize = true;
            this.labelDataEnd.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDataEnd.Location = new System.Drawing.Point(34, 186);
            this.labelDataEnd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDataEnd.Name = "labelDataEnd";
            this.labelDataEnd.Size = new System.Drawing.Size(56, 23);
            this.labelDataEnd.TabIndex = 3;
            this.labelDataEnd.Text = "label4";
            // 
            // labelPunct
            // 
            this.labelPunct.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPunct.Location = new System.Drawing.Point(232, 35);
            this.labelPunct.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPunct.Name = "labelPunct";
            this.labelPunct.Size = new System.Drawing.Size(173, 23);
            this.labelPunct.TabIndex = 4;
            this.labelPunct.Text = "label5";
            this.labelPunct.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelFIO
            // 
            this.labelFIO.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFIO.Location = new System.Drawing.Point(233, 74);
            this.labelFIO.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFIO.Name = "labelFIO";
            this.labelFIO.Size = new System.Drawing.Size(172, 57);
            this.labelFIO.TabIndex = 5;
            this.labelFIO.Text = "label6";
            this.labelFIO.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelStatus
            // 
            this.labelStatus.BackColor = System.Drawing.Color.DarkSlateGray;
            this.labelStatus.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStatus.ForeColor = System.Drawing.SystemColors.Control;
            this.labelStatus.Location = new System.Drawing.Point(293, 186);
            this.labelStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(112, 23);
            this.labelStatus.TabIndex = 6;
            this.labelStatus.Text = "label7";
            this.labelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelcode
            // 
            this.labelcode.BackColor = System.Drawing.SystemColors.Control;
            this.labelcode.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelcode.Location = new System.Drawing.Point(323, 145);
            this.labelcode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelcode.Name = "labelcode";
            this.labelcode.Size = new System.Drawing.Size(82, 23);
            this.labelcode.TabIndex = 7;
            this.labelcode.Text = "454666";
            this.labelcode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ZakazControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(196)))), ((int)(((byte)(197)))));
            this.Controls.Add(this.labelcode);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelFIO);
            this.Controls.Add(this.labelPunct);
            this.Controls.Add(this.labelDataEnd);
            this.Controls.Add(this.labelDataStart);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ZakazControl";
            this.Size = new System.Drawing.Size(445, 249);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelKolvo;
        private System.Windows.Forms.Label labelArticul;
        private System.Windows.Forms.Label labelDataStart;
        private System.Windows.Forms.Label labelDataEnd;
        private System.Windows.Forms.Label labelPunct;
        private System.Windows.Forms.Label labelFIO;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelcode;
    }
}
