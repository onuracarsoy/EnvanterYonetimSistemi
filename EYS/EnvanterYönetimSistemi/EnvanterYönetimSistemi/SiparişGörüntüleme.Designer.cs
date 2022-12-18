namespace EnvanterYönetimSistemi
{
    partial class SiparişGörüntüleme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SiparişGörüntüleme));
            this.panel1 = new System.Windows.Forms.Panel();
            this.anasayfa = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.siparisGv = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.yenile = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(1330, 131);
            this.panel1.TabIndex = 2;
            // 
            // anasayfa
            // 
            this.anasayfa.BackColor = System.Drawing.Color.Gray;
            this.anasayfa.Location = new System.Drawing.Point(12, 12);
            this.anasayfa.Name = "anasayfa";
            this.anasayfa.Size = new System.Drawing.Size(152, 61);
            this.anasayfa.TabIndex = 4;
            this.anasayfa.Text = "Ana Sayfa";
            this.anasayfa.UseVisualStyleBackColor = false;
            this.anasayfa.Click += new System.EventHandler(this.anasayfa_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(1287, 9);
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
            this.label1.Location = new System.Drawing.Point(530, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alınan Siparişler";
            this.label1.UseMnemonic = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(424, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(516, 41);
            this.label2.TabIndex = 1;
            this.label2.Text = "ENVANTER YÖNETİM SİSTEMİ";
            this.label2.UseMnemonic = false;
            // 
            // siparisGv
            // 
            this.siparisGv.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.siparisGv.Location = new System.Drawing.Point(12, 171);
            this.siparisGv.Name = "siparisGv";
            this.siparisGv.ReadOnly = true;
            this.siparisGv.RowTemplate.Height = 25;
            this.siparisGv.Size = new System.Drawing.Size(1306, 419);
            this.siparisGv.TabIndex = 42;
            this.siparisGv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.siparisGv_CellContentClick);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 131);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1330, 25);
            this.toolStrip1.TabIndex = 46;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // yenile
            // 
            this.yenile.BackColor = System.Drawing.Color.SlateGray;
            this.yenile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yenile.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.yenile.Location = new System.Drawing.Point(12, 596);
            this.yenile.Name = "yenile";
            this.yenile.Size = new System.Drawing.Size(165, 43);
            this.yenile.TabIndex = 47;
            this.yenile.Text = "Yenile";
            this.yenile.UseVisualStyleBackColor = false;
            this.yenile.Click += new System.EventHandler(this.yenile_Click);
            // 
            // SiparişGörüntüleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1330, 794);
            this.Controls.Add(this.yenile);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.siparisGv);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SiparişGörüntüleme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SiparişGörüntüleme";
            this.Load += new System.EventHandler(this.SiparişGörüntüleme_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.siparisGv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label7;
        private Label label1;
        private Label label2;
        private DataGridView siparisGv;
        private ToolStrip toolStrip1;
        private Button anasayfa;
        private Button yenile;
    }
}