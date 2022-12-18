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
    public partial class MüşteriYönetim : Form
    {
        public MüşteriYönetim()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=WINDEV2209EVAL;Initial Catalog=Envanterdb;Integrated Security=True");
        void musteriveri()
        {

            string sorgular = "SELECT musterino as MÜŞTERİ_NO, musteriadsoyad AS MÜŞTERİ_AD_SOYAD, musteritelefon AS MÜŞTERİ_TELEFON FROM musteri";
            SqlDataAdapter da = new SqlDataAdapter(sorgular, Con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            musteriGV.DataSource = ds.Tables[0];
        }
        private void MüşteriYönetim_Load(object sender, EventArgs e)
        {
            musteriveri();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void kulllaniciTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (musterinoTb.Text == "")
            {
                MessageBox.Show("Lütfen Müşteri No Giriniz!");
            }
            else if (musteriadsoyadTb.Text == "")
            {
                MessageBox.Show("Lütfen Müşteri Ad Soyad Giriniz!");
            }
            else if (musteritelefonTb.Text == "")
            {
                MessageBox.Show("Lütfen Müşteri Telefon Giriniz!");
            }

            else
            {

                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO musteri values('" + musterinoTb.Text + "','" + musteriadsoyadTb.Text + "','" + musteritelefonTb.Text + "')", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Müşteri Eklendi!");
                    Con.Close();
                }
                catch
                {

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (musterinoTb.Text == "")
            {
                MessageBox.Show("lütfen Müşteri No Girin!");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE musteri SET musteriadsoyad='" + musteriadsoyadTb.Text + "',musteritelefon='" + musteritelefonTb.Text + "' WHERE musterino='" + musterinoTb.Text + "'", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Müşteri Düzenlendi!");
                    Con.Close();
                }
                catch
                {

                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (musterinoTb.Text == "")
            {
                MessageBox.Show("Lütfen Bir Müşteri No Giriniz!");
            }
            else
            {
                Con.Open();
                string silmesorgu = "DELETE FROM musteri WHERE musterino = '" + musterinoTb.Text + "';";
                SqlCommand cmd = new SqlCommand(silmesorgu, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Müşteri Silindi!");
                Con.Close();
                musteriveri();
            }
        }

        private void yenile_Click(object sender, EventArgs e)
        {
            musteriveri();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void anasayfa_Click(object sender, EventArgs e)
        {
            AnaSayfa ans = new AnaSayfa();
            ans.Show();
            this.Hide();

        }
    }
}
