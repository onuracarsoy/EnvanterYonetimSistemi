using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnvanterYönetimSistemi
{
    public partial class SiparişGörüntüleme : Form
    {
        public SiparişGörüntüleme()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
        SqlConnection Con = new SqlConnection(@"Data Source=WINDEV2209EVAL;Initial Catalog=Envanterdb;Integrated Security=True");

        void siparisveri()
        {

            string siparissorgu = "SELECT siparisno AS SİPARİŞ_NO, musterino AS MÜŞTERİ_NO, urunno AS ÜRÜN_NO,adet AS ADET, toplamfiyat AS TOPLAM_FİYAT  FROM siparis";
            SqlDataAdapter da = new SqlDataAdapter(siparissorgu, Con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            siparisGv.DataSource = ds.Tables[0];
        }

        
        private void SiparişGörüntüleme_Load(object sender, EventArgs e)
        {
            siparisveri();
  
        }

        private void anasayfa_Click(object sender, EventArgs e)
        {
            AnaSayfa ans = new AnaSayfa();
            ans.Show();
            this.Hide();

        }

        private void siparisGv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void yenile_Click(object sender, EventArgs e)
        {
            siparisveri();
        }
    }
}
