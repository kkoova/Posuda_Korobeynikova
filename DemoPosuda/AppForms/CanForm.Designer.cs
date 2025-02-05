namespace DemoPosuda.AppForms
{
    partial class CanForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CanForm));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanelTovar = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxDataStart = new System.Windows.Forms.TextBox();
            this.textBoxDataEdn = new System.Windows.Forms.TextBox();
            this.comboBoxPunkt = new System.Windows.Forms.ComboBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelKode = new System.Windows.Forms.Label();
            this.labelCost = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 10.25F);
            this.label2.Location = new System.Drawing.Point(115, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Корзина";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 24.25F);
            this.label1.Location = new System.Drawing.Point(111, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 46);
            this.label1.TabIndex = 4;
            this.label1.Text = "ООО «Посуда»";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DemoPosuda.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(13, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(91, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // flowLayoutPanelTovar
            // 
            this.flowLayoutPanelTovar.AutoScroll = true;
            this.flowLayoutPanelTovar.Location = new System.Drawing.Point(13, 114);
            this.flowLayoutPanelTovar.Name = "flowLayoutPanelTovar";
            this.flowLayoutPanelTovar.Size = new System.Drawing.Size(624, 380);
            this.flowLayoutPanelTovar.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelCost);
            this.groupBox1.Controls.Add(this.labelKode);
            this.groupBox1.Controls.Add(this.textBoxName);
            this.groupBox1.Controls.Add(this.comboBoxPunkt);
            this.groupBox1.Controls.Add(this.textBoxDataEdn);
            this.groupBox1.Controls.Add(this.textBoxDataStart);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(652, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(193, 482);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Данные о заказе";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(196)))), ((int)(((byte)(197)))));
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(6, 429);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 47);
            this.button1.TabIndex = 0;
            this.button1.Text = "Оформить заказ";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // textBoxDataStart
            // 
            this.textBoxDataStart.Enabled = false;
            this.textBoxDataStart.Location = new System.Drawing.Point(6, 162);
            this.textBoxDataStart.Name = "textBoxDataStart";
            this.textBoxDataStart.Size = new System.Drawing.Size(181, 26);
            this.textBoxDataStart.TabIndex = 1;
            // 
            // textBoxDataEdn
            // 
            this.textBoxDataEdn.Enabled = false;
            this.textBoxDataEdn.Location = new System.Drawing.Point(6, 194);
            this.textBoxDataEdn.Name = "textBoxDataEdn";
            this.textBoxDataEdn.Size = new System.Drawing.Size(181, 26);
            this.textBoxDataEdn.TabIndex = 2;
            // 
            // comboBoxPunkt
            // 
            this.comboBoxPunkt.FormattingEnabled = true;
            this.comboBoxPunkt.Location = new System.Drawing.Point(6, 60);
            this.comboBoxPunkt.Name = "comboBoxPunkt";
            this.comboBoxPunkt.Size = new System.Drawing.Size(181, 26);
            this.comboBoxPunkt.TabIndex = 3;
            // 
            // textBoxName
            // 
            this.textBoxName.Enabled = false;
            this.textBoxName.Location = new System.Drawing.Point(6, 28);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(181, 26);
            this.textBoxName.TabIndex = 4;
            // 
            // labelKode
            // 
            this.labelKode.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelKode.Location = new System.Drawing.Point(6, 102);
            this.labelKode.Name = "labelKode";
            this.labelKode.Size = new System.Drawing.Size(181, 31);
            this.labelKode.TabIndex = 5;
            this.labelKode.Text = "label3";
            this.labelKode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCost
            // 
            this.labelCost.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCost.Location = new System.Drawing.Point(6, 383);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(181, 31);
            this.labelCost.TabIndex = 6;
            this.labelCost.Text = "label3";
            this.labelCost.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 506);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.flowLayoutPanelTovar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CanForm";
            this.Text = "Корзина";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelTovar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelKode;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.ComboBox comboBoxPunkt;
        private System.Windows.Forms.TextBox textBoxDataEdn;
        private System.Windows.Forms.TextBox textBoxDataStart;
        private System.Windows.Forms.Label labelCost;
    }
}