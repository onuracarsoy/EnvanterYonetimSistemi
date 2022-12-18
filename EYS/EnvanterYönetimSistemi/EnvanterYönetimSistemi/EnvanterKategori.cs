using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EnvanterYönetimSistemi
{
    public partial class EnvanterKategori : Form
    {
        public EnvanterKategori()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=WINDEV2209EVAL;Initial Catalog=Envanterdb;Integrated Security=True");

        void kategoriveri()
        {
            string sorgular = "SELECT kategorino AS KATEGORİ_NO, kategoriad AS KATEGORİ_ADI FROM kategori";
            SqlDataAdapter da = new SqlDataAdapter(sorgular, Con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            kategoriGV.DataSource = ds.Tables[0];

        }
        private void kullaniciGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void EnvanterKategori_Load(object sender, EventArgs e)
        {
            kategoriveri();
        }

        private void yenile_Click(object sender, EventArgs e)
        {
            kategoriveri();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (kategorinoTb.Text == "")
            {
                MessageBox.Show("Lütfen Katergori No Giriniz!");
            }


            else
            {

                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO kategori values('" + kategorinoTb.Text + "','" + kategoriadTb.Text + "')", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Kategori Eklendi!");
                    Con.Close();
                }
                catch
                {

                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (kategorinoTb.Text == "")
            {
                MessageBox.Show("lütfen Kategori No Girin!");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE kategori SET kategoriad='" + kategoriadTb.Text + "' WHERE kategorino='" + kategorinoTb.Text + "'", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Kategori Düzenlendi!");
                    Con.Close();
                }
                catch
                {

                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (kategorinoTb.Text == "")
            {
                MessageBox.Show("Lütfen Bir Kategori No Giriniz!");
            }
            else
            {
                Con.Open();
                string silmesorgu = "DELETE FROM kategori WHERE kategorino = '" + kategorinoTb.Text + "';";
                SqlCommand cmd = new SqlCommand(silmesorgu, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Kategori Silindi!");
                Con.Close();
                kategoriveri();
            }
        }

        private void kategoriadTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void anasayfa_Click(object sender, EventArgs e)
        {
            AnaSayfa ans = new AnaSayfa();
            ans.Show();
            this.Hide();

        }
    }
}




