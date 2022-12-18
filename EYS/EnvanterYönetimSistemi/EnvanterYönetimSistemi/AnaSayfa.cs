using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnvanterYönetimSistemi
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            YönetimKullanıcıları yk = new YönetimKullanıcıları();
            yk.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MüşteriYönetim müşt = new MüşteriYönetim();
            müşt.Show();
            this.Hide();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            SiparişYönetim sprs = new SiparişYönetim();
            sprs.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SiparişGörüntüleme sprsg = new SiparişGörüntüleme();
            sprsg.Show();
            this.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ÜrünYönetim ynt = new ÜrünYönetim();
            ynt.Show();
            this.Hide();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            EnvanterKategori ek = new EnvanterKategori();
            ek.Show();
            this.Hide();

        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
