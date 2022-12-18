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
    public partial class SiparişYönetim : Form
    {
        public SiparişYönetim()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=WINDEV2209EVAL;Initial Catalog=Envanterdb;Integrated Security=True");
        private void SiparişYönetim_Load(object sender, EventArgs e)
        {
            musteriveri();
            urunveri();
            kategorisırala();
            siparisveri();

        }


        void musteriveri()
        {

            string sorgular = "SELECT musterino as MÜŞTERİ_NO, musteriadsoyad AS MÜŞTERİ_AD_SOYAD, musteritelefon AS MÜŞTERİ_TELEFON  FROM musteri";
            SqlDataAdapter da = new SqlDataAdapter(sorgular, Con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            musterilisteGV.DataSource = ds.Tables[0];


        }
        void urunveri()
        {

            string sorgular = "SELECT urunno AS ÜRÜN_NO, urunad AS ÜRÜN_ADI, urunadet AS ÜRÜN_ADETİ, urunfiyat AS ÜRÜN_FİYATI, urunaciklama AS ÜRÜN_AÇIKLAMA,urunkategori AS ÜRÜN_KATEGORİSİ FROM urun";
            SqlDataAdapter da = new SqlDataAdapter(sorgular, Con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            urunGV.DataSource = ds.Tables[0];


        }
        void istenilenmusteri()
        {

            string urunsorgular = "SELECT musterino as MÜŞTERİ_NO, musteriadsoyad AS MÜŞTERİ_AD_SOYAD, musteritelefon AS MÜŞTERİ_TELEFON FROM musteri WHERE musterino='" + musterinoTb.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(urunsorgular, Con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            musterilisteGV.DataSource = ds.Tables[0];



        }
        void istenilenurun()
        {

            string urunsorgular = "SELECT urunno AS ÜRÜN_NO, urunad AS ÜRÜN_ADI, urunadet AS ÜRÜN_ADETİ, urunfiyat AS ÜRÜN_FİYATI, urunaciklama AS ÜRÜN_AÇIKLAMA,urunkategori AS ÜRÜN_KATEGORİSİ FROM urun WHERE urunno='" + urunnoaraTb.Text + "'";
            SqlDataAdapter da = new SqlDataAdapter(urunsorgular, Con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            urunGV.DataSource = ds.Tables[0];



        }
        void kategorisırala()
        {
            string sorgu = "SELECT * FROM kategori";
            SqlCommand cmd = new SqlCommand(sorgu, Con);
            SqlDataReader rdr;
            try
            {
                Con.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("kategoriad", typeof(string));
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                //urunkategoriCb.ValueMember = "kategoriad";
                //urunkategoriCb.DataSource = dt;
                araCb.ValueMember = "kategoriad";
                araCb.DataSource = dt;
                Con.Close();
            }
            catch
            {

            }
        }
        void siparisveri()
        {

            string siparissorgu = "SELECT siparisno AS SİPARİŞ_NO, musterino AS MÜŞTERİ_NO, urunno AS ÜRÜN_NO,adet AS ADET, toplamfiyat AS TOPLAM_FİYAT FROM siparis";
            SqlDataAdapter da = new SqlDataAdapter(siparissorgu, Con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            siparisGv.DataSource = ds.Tables[0];
        }


        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void musterilisteGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void yenile_Click(object sender, EventArgs e)
        {
            urunveri();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            istenilenmusteri();
            istenilenurun();

        }
        private void araCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void araCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                string sorgular = "SELECT * FROM urun where urunkategori = '" + araCb.SelectedValue.ToString() + "'";
                SqlDataAdapter da = new SqlDataAdapter(sorgular, Con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                urunGV.DataSource = ds.Tables[0];
            }
            catch
            {

            }
        }

        private void urunGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (siparisnoekleTb.Text == "")
            {
                MessageBox.Show("Lütfen Sipariş No Giriniz!");
            }
            else if (urunnoTb.Text == "")
            {
                MessageBox.Show("Lütfen Ürün No Giriniz!");
            }
            else if (musterinoekleTb.Text == "")
            {
                MessageBox.Show("Lütfen Müşteri No Giriniz!");
            }
            else if (siparisadetTb.Text == "")
            {
                MessageBox.Show("Lütfen Sipariş Adeti Giriniz!");
            }
            else if (toplamfiyatTb.Text == "")
            {
                MessageBox.Show("Lütfen Ürün Fiyat Giriniz!");
            }
            else
            {

                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO siparis values('" + siparisnoekleTb.Text + "','" + musterinoekleTb.Text + "','" + urunnoTb.Text + "','" + siparisadetTb.Text + "','" + toplamfiyatTb.Text + "')", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Sipariş Oluşturuldu!");
                    Con.Close();
                    siparisveri();
                }
                catch
                {

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (siparisnoekleTb.Text == "")
            {
                MessageBox.Show("Lütfen Bir Sipariş No Giriniz!");
            }
            else
            {
                Con.Open();
                string silmesorgu = "DELETE FROM siparis WHERE siparisno = '" + siparisnoekleTb.Text + "';";
                SqlCommand cmd = new SqlCommand(silmesorgu, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sipariş Silindi!");
                Con.Close();
                siparisveri();
            }
        }

        private void siparisGv_CellContentClick(object sender, DataGridViewCellEventArgs e)
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


