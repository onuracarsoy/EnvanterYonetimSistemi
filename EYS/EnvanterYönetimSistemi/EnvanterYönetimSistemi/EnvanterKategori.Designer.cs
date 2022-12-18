namespace EnvanterYönetimSistemi
{
    partial class EnvanterKategori
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnvanterKategori));
            this.panel1 = new System.Windows.Forms.Panel();
            this.anasayfa = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.kategoriadTb = new System.Windows.Forms.TextBox();
            this.kategorinoTb = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.kategoriGV = new System.Windows.Forms.DataGridView();
            this.yenile = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kategoriGV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.anasayfa);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1346, 131);
            this.panel1.TabIndex = 1;
            // 
            // anasayfa
            // 
            this.anasayfa.BackColor = System.Drawing.Color.Gray;
            this.anasayfa.Location = new System.Drawing.Point(12, 10);
            this.anasayfa.Name = "anasayfa";
            this.anasayfa.Size = new System.Drawing.Size(152, 61);
            this.anasayfa.TabIndex = 3;
            this.anasayfa.Text = "Ana Sayfa";
            this.anasayfa.UseVisualStyleBackColor = false;
            this.anasayfa.Click += new System.EventHandler(this.anasayfa_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(1303, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 40);
            this.label7.TabIndex = 2;
            this.label7.Text = "X";
            this.label7.UseMnemonic = false;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(581, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategori";
            this.label1.UseMnemonic = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(431, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(516, 41);
            this.label2.TabIndex = 1;
            this.label2.Text = "ENVANTER YÖNETİM SİSTEMİ";
            this.label2.UseMnemonic = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(24, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Kategori Ad:";
            this.label4.UseMnemonic = false;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(24, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Kategori No:";
            this.label3.UseMnemonic = false;
            // 
            // kategoriadTb
            // 
            this.kategoriadTb.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kategoriadTb.Location = new System.Drawing.Point(24, 257);
            this.kategoriadTb.Name = "kategoriadTb";
            this.kategoriadTb.Size = new System.Drawing.Size(265, 29);
            this.kategoriadTb.TabIndex = 8;
            this.kategoriadTb.TextChanged += new System.EventHandler(this.kategoriadTb_TextChanged);
            // 
            // kategorinoTb
            // 
            this.kategorinoTb.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kategorinoTb.Location = new System.Drawing.Point(24, 194);
            this.kategorinoTb.Name = "kategorinoTb";
            this.kategorinoTb.Size = new System.Drawing.Size(265, 29);
            this.kategorinoTb.TabIndex = 7;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(24, 462);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(265, 43);
            this.button3.TabIndex = 14;
            this.button3.Text = "Sil";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Yellow;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(24, 398);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(265, 43);
            this.button2.TabIndex = 13;
            this.button2.Text = "Düzenle";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LimeGreen;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(24, 334);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(265, 43);
            this.button1.TabIndex = 12;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // kategoriGV
            // 
            this.kategoriGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kategoriGV.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.kategoriGV.Location = new System.Drawing.Point(407, 158);
            this.kategoriGV.Name = "kategoriGV";
            this.kategoriGV.ReadOnly = true;
            this.kategoriGV.RowTemplate.Height = 25;
            this.kategoriGV.Size = new System.Drawing.Size(886, 498);
            this.kategoriGV.TabIndex = 15;
            this.kategoriGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.kullaniciGV_CellContentClick);
            // 
            // yenile
            // 
            this.yenile.BackColor = System.Drawing.Color.SlateGray;
            this.yenile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yenile.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.yenile.Location = new System.Drawing.Point(407, 662);
            this.yenile.Name = "yenile";
            this.yenile.Size = new System.Drawing.Size(165, 43);
            this.yenile.TabIndex = 16;
            this.yenile.Text = "Yenile";
            this.yenile.UseVisualStyleBackColor = false;
            this.yenile.Click += new System.EventHandler(this.yenile_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 808);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1346, 25);
            this.panel2.TabIndex = 17;
            // 
            // EnvanterKategori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1346, 833);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.yenile);
            this.Controls.Add(this.kategoriGV);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.kategoriadTb);
            this.Controls.Add(this.kategorinoTb);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EnvanterKategori";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EnvanterKategori";
            this.Load += new System.EventHandler(this.EnvanterKategori_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kategoriGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label7;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label3;
        private TextBox kategoriadTb;
        public TextBox kategorinoTb;
        private Button button3;
        private Button button2;
        private Button button1;
        private DataGridView kategoriGV;
        private Button yenile;
        private Panel panel2;
        private Button anasayfa;
    }
}