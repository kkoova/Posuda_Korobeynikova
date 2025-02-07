namespace DemoPosuda.Forms
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelKolvoToar = new System.Windows.Forms.Label();
            this.pictureBoxCan = new System.Windows.Forms.PictureBox();
            this.labelUserFio = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelStats = new System.Windows.Forms.Label();
            this.comboBoxProizvod = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.radioButtonDown = new System.Windows.Forms.RadioButton();
            this.radioButtonUp = new System.Windows.Forms.RadioButton();
            this.textBoxFindName = new System.Windows.Forms.TextBox();
            this.flowLayoutPanelTovar = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.товарыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddТоварToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.акаунтToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотрПользователейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.labelKolvoToar);
            this.panel1.Controls.Add(this.pictureBoxCan);
            this.panel1.Controls.Add(this.labelUserFio);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(14, 14);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(850, 115);
            this.panel1.TabIndex = 1;
            // 
            // labelKolvoToar
            // 
            this.labelKolvoToar.AutoSize = true;
            this.labelKolvoToar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(196)))), ((int)(((byte)(197)))));
            this.labelKolvoToar.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelKolvoToar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelKolvoToar.Location = new System.Drawing.Point(823, 87);
            this.labelKolvoToar.Name = "labelKolvoToar";
            this.labelKolvoToar.Size = new System.Drawing.Size(17, 19);
            this.labelKolvoToar.TabIndex = 4;
            this.labelKolvoToar.Text = "4";
            this.labelKolvoToar.Visible = false;
            // 
            // pictureBoxCan
            // 
            this.pictureBoxCan.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxCan.Image = global::DemoPosuda.Properties.Resources.bucet1;
            this.pictureBoxCan.Location = new System.Drawing.Point(789, 59);
            this.pictureBoxCan.Name = "pictureBoxCan";
            this.pictureBoxCan.Size = new System.Drawing.Size(32, 35);
            this.pictureBoxCan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCan.TabIndex = 3;
            this.pictureBoxCan.TabStop = false;
            this.pictureBoxCan.Visible = false;
            this.pictureBoxCan.Click += new System.EventHandler(this.pictureBoxCan_Click);
            // 
            // labelUserFio
            // 
            this.labelUserFio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelUserFio.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelUserFio.Location = new System.Drawing.Point(465, 15);
            this.labelUserFio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUserFio.Name = "labelUserFio";
            this.labelUserFio.Size = new System.Drawing.Size(371, 23);
            this.labelUserFio.TabIndex = 2;
            this.labelUserFio.Text = "Гость";
            this.labelUserFio.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 10.25F);
            this.label2.Location = new System.Drawing.Point(121, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Главная";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 24.25F);
            this.label1.Location = new System.Drawing.Point(117, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "ООО «Посуда»";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DemoPosuda.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(19, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(91, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.labelStats);
            this.panel2.Controls.Add(this.comboBoxProizvod);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.textBoxFindName);
            this.panel2.Controls.Add(this.flowLayoutPanelTovar);
            this.panel2.Controls.Add(this.menuStrip1);
            this.panel2.Location = new System.Drawing.Point(14, 135);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(850, 399);
            this.panel2.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(404, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Производитель товара";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(3, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Название товара";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelStats
            // 
            this.labelStats.Location = new System.Drawing.Point(647, 31);
            this.labelStats.Name = "labelStats";
            this.labelStats.Size = new System.Drawing.Size(197, 15);
            this.labelStats.TabIndex = 5;
            this.labelStats.Text = "Количество товара";
            this.labelStats.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxProizvod
            // 
            this.comboBoxProizvod.FormattingEnabled = true;
            this.comboBoxProizvod.Location = new System.Drawing.Point(407, 49);
            this.comboBoxProizvod.Name = "comboBoxProizvod";
            this.comboBoxProizvod.Size = new System.Drawing.Size(234, 23);
            this.comboBoxProizvod.TabIndex = 4;
            this.comboBoxProizvod.SelectedIndexChanged += new System.EventHandler(this.comboBoxProizvod_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.radioButtonDown);
            this.panel3.Controls.Add(this.radioButtonUp);
            this.panel3.Location = new System.Drawing.Point(647, 49);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 22);
            this.panel3.TabIndex = 3;
            // 
            // radioButtonDown
            // 
            this.radioButtonDown.AutoSize = true;
            this.radioButtonDown.Location = new System.Drawing.Point(105, 4);
            this.radioButtonDown.Name = "radioButtonDown";
            this.radioButtonDown.Size = new System.Drawing.Size(78, 19);
            this.radioButtonDown.TabIndex = 1;
            this.radioButtonDown.TabStop = true;
            this.radioButtonDown.Text = "Убывание";
            this.radioButtonDown.UseVisualStyleBackColor = true;
            this.radioButtonDown.CheckedChanged += new System.EventHandler(this.radioButtonDown_CheckedChanged);
            // 
            // radioButtonUp
            // 
            this.radioButtonUp.AutoSize = true;
            this.radioButtonUp.Location = new System.Drawing.Point(3, 4);
            this.radioButtonUp.Name = "radioButtonUp";
            this.radioButtonUp.Size = new System.Drawing.Size(92, 19);
            this.radioButtonUp.TabIndex = 0;
            this.radioButtonUp.TabStop = true;
            this.radioButtonUp.Text = "Возрастание";
            this.radioButtonUp.UseVisualStyleBackColor = true;
            this.radioButtonUp.CheckedChanged += new System.EventHandler(this.radioButtonUp_CheckedChanged);
            // 
            // textBoxFindName
            // 
            this.textBoxFindName.Location = new System.Drawing.Point(3, 49);
            this.textBoxFindName.Name = "textBoxFindName";
            this.textBoxFindName.Size = new System.Drawing.Size(398, 23);
            this.textBoxFindName.TabIndex = 2;
            this.textBoxFindName.TextChanged += new System.EventHandler(this.textBoxFindName_TextChanged);
            // 
            // flowLayoutPanelTovar
            // 
            this.flowLayoutPanelTovar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelTovar.AutoScroll = true;
            this.flowLayoutPanelTovar.Location = new System.Drawing.Point(3, 79);
            this.flowLayoutPanelTovar.Name = "flowLayoutPanelTovar";
            this.flowLayoutPanelTovar.Size = new System.Drawing.Size(844, 317);
            this.flowLayoutPanelTovar.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.товарыToolStripMenuItem,
            this.акаунтToolStripMenuItem,
            this.pfToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(850, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip";
            // 
            // товарыToolStripMenuItem
            // 
            this.товарыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddТоварToolStripMenuItem});
            this.товарыToolStripMenuItem.Name = "товарыToolStripMenuItem";
            this.товарыToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.товарыToolStripMenuItem.Text = "Товары";
            // 
            // AddТоварToolStripMenuItem
            // 
            this.AddТоварToolStripMenuItem.Name = "AddТоварToolStripMenuItem";
            this.AddТоварToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.AddТоварToolStripMenuItem.Text = "Добавить товар";
            this.AddТоварToolStripMenuItem.Visible = false;
            this.AddТоварToolStripMenuItem.Click += new System.EventHandler(this.AddТоварToolStripMenuItem_Click);
            // 
            // акаунтToolStripMenuItem
            // 
            this.акаунтToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExitToolStripMenuItem,
            this.просмотрПользователейToolStripMenuItem});
            this.акаунтToolStripMenuItem.Name = "акаунтToolStripMenuItem";
            this.акаунтToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.акаунтToolStripMenuItem.Text = "Пользователи";
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.ExitToolStripMenuItem.Text = "Авторизация";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // просмотрПользователейToolStripMenuItem
            // 
            this.просмотрПользователейToolStripMenuItem.Name = "просмотрПользователейToolStripMenuItem";
            this.просмотрПользователейToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
            this.просмотрПользователейToolStripMenuItem.Text = "Просмотр пользователей";
            this.просмотрПользователейToolStripMenuItem.Click += new System.EventHandler(this.просмотрПользователейToolStripMenuItem_Click);
            // 
            // pfToolStripMenuItem
            // 
            this.pfToolStripMenuItem.Name = "pfToolStripMenuItem";
            this.pfToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.pfToolStripMenuItem.Text = "Заказы";
            this.pfToolStripMenuItem.Click += new System.EventHandler(this.pfToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(876, 546);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Main";
            this.Text = "Главная";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelUserFio;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelTovar;
        private System.Windows.Forms.ToolStripMenuItem товарыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem акаунтToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxFindName;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton radioButtonDown;
        private System.Windows.Forms.RadioButton radioButtonUp;
        private System.Windows.Forms.ComboBox comboBoxProizvod;
        private System.Windows.Forms.Label labelStats;
        private System.Windows.Forms.ToolStripMenuItem AddТоварToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem просмотрПользователейToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBoxCan;
        private System.Windows.Forms.Label labelKolvoToar;
        private System.Windows.Forms.ToolStripMenuItem pfToolStripMenuItem;
    }
}