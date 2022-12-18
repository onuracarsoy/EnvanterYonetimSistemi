namespace EnvanterYönetimSistemi
{
    partial class SiparişYönetim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SiparişYönetim));
            this.panel1 = new System.Windows.Forms.Panel();
            this.anasayfa = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.musterilisteGV = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.urunnoaraTb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.musterinoTb = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.araCb = new System.Windows.Forms.ComboBox();
            this.yenile = new System.Windows.Forms.Button();
            this.urunGV = new System.Windows.Forms.DataGridView();
            this.siparisadetTb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.siparisGv = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.siparisnoekleTb = new System.Windows.Forms.TextBox();
            this.musterinoekleTb = new System.Windows.Forms.TextBox();
            this.toplamfiyatTb = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.urunnoTb = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.musterilisteGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.siparisGv)).BeginInit();
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
            this.anasayfa.Location = new System.Drawing.Point(12, 8);
            this.anasayfa.Name = "anasayfa";
            this.anasayfa.Size = new System.Drawing.Size(152, 61);
            this.anasayfa.TabIndex = 52;
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
            this.label1.Location = new System.Drawing.Point(621, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sipariş";
            this.label1.UseMnemonic = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(430, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(516, 41);
            this.label2.TabIndex = 1;
            this.label2.Text = "ENVANTER YÖNETİM SİSTEMİ";
            this.label2.UseMnemonic = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 808);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1346, 25);
            this.panel2.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(1034, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(247, 37);
            this.label3.TabIndex = 15;
            this.label3.Text = "Müşteri Listesi";
            this.label3.UseMnemonic = false;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // musterilisteGV
            // 
            this.musterilisteGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.musterilisteGV.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.musterilisteGV.Location = new System.Drawing.Point(982, 177);
            this.musterilisteGV.Name = "musterilisteGV";
            this.musterilisteGV.ReadOnly = true;
            this.musterilisteGV.RowTemplate.Height = 25;
            this.musterilisteGV.Size = new System.Drawing.Size(352, 221);
            this.musterilisteGV.TabIndex = 16;
            this.musterilisteGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.musterilisteGV_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(29, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 19);
            this.label4.TabIndex = 18;
            this.label4.Text = "Urun No:";
            this.label4.UseMnemonic = false;
            // 
            // urunnoaraTb
            // 
            this.urunnoaraTb.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.urunnoaraTb.Location = new System.Drawing.Point(29, 202);
            this.urunnoaraTb.Name = "urunnoaraTb";
            this.urunnoaraTb.Size = new System.Drawing.Size(265, 29);
            this.urunnoaraTb.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(29, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 19);
            this.label5.TabIndex = 20;
            this.label5.Text = "Müşteri No:";
            this.label5.UseMnemonic = false;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // musterinoTb
            // 
            this.musterinoTb.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.musterinoTb.Location = new System.Drawing.Point(29, 256);
            this.musterinoTb.Name = "musterinoTb";
            this.musterinoTb.Size = new System.Drawing.Size(265, 29);
            this.musterinoTb.TabIndex = 19;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.SlateGray;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(30, 327);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(126, 43);
            this.button4.TabIndex = 36;
            this.button4.Text = "Ara";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // araCb
            // 
            this.araCb.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.araCb.FormattingEnabled = true;
            this.araCb.Location = new System.Drawing.Point(535, 141);
            this.araCb.Name = "araCb";
            this.araCb.Size = new System.Drawing.Size(200, 30);
            this.araCb.TabIndex = 35;
            this.araCb.Text = "Kategori Seç";
            this.araCb.SelectedIndexChanged += new System.EventHandler(this.araCb_SelectedIndexChanged);
            this.araCb.SelectionChangeCommitted += new System.EventHandler(this.araCb_SelectionChangeCommitted);
            // 
            // yenile
            // 
            this.yenile.BackColor = System.Drawing.Color.SlateGray;
            this.yenile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yenile.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.yenile.Location = new System.Drawing.Point(169, 327);
            this.yenile.Name = "yenile";
            this.yenile.Size = new System.Drawing.Size(126, 43);
            this.yenile.TabIndex = 34;
            this.yenile.Text = "Yenile";
            this.yenile.UseVisualStyleBackColor = false;
            this.yenile.Click += new System.EventHandler(this.yenile_Click);
            // 
            // urunGV
            // 
            this.urunGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.urunGV.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.urunGV.Location = new System.Drawing.Point(315, 177);
            this.urunGV.Name = "urunGV";
            this.urunGV.ReadOnly = true;
            this.urunGV.RowTemplate.Height = 25;
            this.urunGV.Size = new System.Drawing.Size(661, 221);
            this.urunGV.TabIndex = 33;
            this.urunGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.urunGV_CellContentClick);
            // 
            // siparisadetTb
            // 
            this.siparisadetTb.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.siparisadetTb.Location = new System.Drawing.Point(30, 588);
            this.siparisadetTb.Name = "siparisadetTb";
            this.siparisadetTb.Size = new System.Drawing.Size(265, 29);
            this.siparisadetTb.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(29, 566);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 19);
            this.label8.TabIndex = 38;
            this.label8.Text = "Adet:";
            this.label8.UseMnemonic = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SlateGray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(26, 677);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 69);
            this.button1.TabIndex = 40;
            this.button1.Text = "Sipariş Ekle";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // siparisGv
            // 
            this.siparisGv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.siparisGv.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.siparisGv.Location = new System.Drawing.Point(315, 404);
            this.siparisGv.Name = "siparisGv";
            this.siparisGv.ReadOnly = true;
            this.siparisGv.RowTemplate.Height = 25;
            this.siparisGv.Size = new System.Drawing.Size(1019, 388);
            this.siparisGv.TabIndex = 41;
            this.siparisGv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.siparisGv_CellContentClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(30, 458);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 19);
            this.label9.TabIndex = 44;
            this.label9.Text = "Müşteri No:";
            this.label9.UseMnemonic = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(26, 404);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 19);
            this.label10.TabIndex = 43;
            this.label10.Text = "Sipariş No:";
            this.label10.UseMnemonic = false;
            // 
            // siparisnoekleTb
            // 
            this.siparisnoekleTb.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.siparisnoekleTb.Location = new System.Drawing.Point(29, 426);
            this.siparisnoekleTb.Name = "siparisnoekleTb";
            this.siparisnoekleTb.Size = new System.Drawing.Size(265, 29);
            this.siparisnoekleTb.TabIndex = 42;
            // 
            // musterinoekleTb
            // 
            this.musterinoekleTb.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.musterinoekleTb.Location = new System.Drawing.Point(30, 480);
            this.musterinoekleTb.Name = "musterinoekleTb";
            this.musterinoekleTb.Size = new System.Drawing.Size(265, 29);
            this.musterinoekleTb.TabIndex = 45;
            // 
            // toplamfiyatTb
            // 
            this.toplamfiyatTb.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toplamfiyatTb.Location = new System.Drawing.Point(30, 642);
            this.toplamfiyatTb.Name = "toplamfiyatTb";
            this.toplamfiyatTb.Size = new System.Drawing.Size(265, 29);
            this.toplamfiyatTb.TabIndex = 46;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(26, 620);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 19);
            this.label11.TabIndex = 47;
            this.label11.Text = "Toplam Fiyat:";
            this.label11.UseMnemonic = false;
            // 
            // urunnoTb
            // 
            this.urunnoTb.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.urunnoTb.Location = new System.Drawing.Point(30, 534);
            this.urunnoTb.Name = "urunnoTb";
            this.urunnoTb.Size = new System.Drawing.Size(265, 29);
            this.urunnoTb.TabIndex = 49;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(30, 512);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 19);
            this.label12.TabIndex = 48;
            this.label12.Text = "Ürün No:";
            this.label12.UseMnemonic = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SlateGray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(177, 677);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 69);
            this.button2.TabIndex = 50;
            this.button2.Text = "Sipariş Sil";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(315, 137);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(204, 37);
            this.label13.TabIndex = 51;
            this.label13.Text = "Ürün Listesi";
            this.label13.UseMnemonic = false;
            // 
            // SiparişYönetim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1346, 833);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.urunnoTb);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.toplamfiyatTb);
            this.Controls.Add(this.musterinoekleTb);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.siparisnoekleTb);
            this.Controls.Add(this.siparisGv);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.siparisadetTb);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.araCb);
            this.Controls.Add(this.yenile);
            this.Controls.Add(this.urunGV);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.musterinoTb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.urunnoaraTb);
            this.Controls.Add(this.musterilisteGV);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SiparişYönetim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SiparişYönetim";
            this.Load += new System.EventHandler(this.SiparişYönetim_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.musterilisteGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.urunGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.siparisGv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label7;
        private Label label1;
        private Label label2;
        private Panel panel2;
        private Label label3;
        private DataGridView musterilisteGV;
        private Label label4;
        public TextBox urunnoaraTb;
        private Label label5;
        public TextBox musterinoTb;
        private Button button4;
        private ComboBox araCb;
        private Button yenile;
        private DataGridView urunGV;
        public TextBox siparisadetTb;
        private Label label8;
        private Button button1;
        private DataGridView siparisGv;
        private Label label9;
        private Label label10;
        public TextBox siparisnoekleTb;
        public TextBox musterinoekleTb;
        public TextBox toplamfiyatTb;
        private Label label11;
        public TextBox urunnoTb;
        private Label label12;
        private Button button2;
        private Label label13;
        private Button anasayfa;
    }
}