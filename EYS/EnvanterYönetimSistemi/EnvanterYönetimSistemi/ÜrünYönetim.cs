using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace EnvanterYönetimSistemi
{
    public partial class ÜrünYönetim : Form
    {
        public ÜrünYönetim()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=WINDEV2209EVAL;Initial Catalog=Envanterdb;Integrated Security=True");
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
                urunkategoriCb.ValueMember = "kategoriad";
                urunkategoriCb.DataSource = dt;
               
                Con.Close();
            }
            catch
            {
            }


        }
        void kategoriara()
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
               
                araCb.ValueMember = "kategoriad";
                araCb.DataSource = dt;
                Con.Close();
            }
            catch
            {
            }


        }



        void urunveri()
        {

            string sorgular = "SELECT * FROM urun";
            SqlDataAdapter da = new SqlDataAdapter(sorgular, Con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            urunGV.DataSource = ds.Tables[0];


        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ÜrünYönetim_Load(object sender, EventArgs e)
        {
            kategorisırala();
            urunveri();
            kategoriara();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (urunnoTb.Text == "")
            {
                MessageBox.Show("Lütfen Ürün No Giriniz!");
            }
            else if (urunadTb.Text == "")
            {
                MessageBox.Show("Lütfen Ürün Adı Adı Giriniz!");
            }
            else if (urunadetTb.Text == "")
            {
                MessageBox.Show("Lütfen Ürün Adeti Giriniz!");
            }
            else if (urunfiyatTb.Text == "")
            {
                MessageBox.Show("Lütfen Ürün Fiyat Giriniz!");
            }
            else
            {

                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO urun values('" + urunnoTb.Text + "','" + urunadTb.Text + "','" + urunadetTb.Text + "','" + urunfiyatTb.Text + "','" + urunaciklamaTb.Text + "','" + urunkategoriCb.SelectedValue.ToString() + "')", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Ürün Eklendi!");
                   
                    urunveri();
                    
                    Con.Close();
                }
                catch
                {

                }
            }
        }

        private void yenile_Click(object sender, EventArgs e)
        {
            urunveri();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (urunnoTb.Text == "")
            {
                MessageBox.Show("lütfen Ürün No Girin!");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE urun SET urunad='" + urunadTb.Text + "',urunadet='" + urunadetTb.Text + "',urunfiyat='" + urunfiyatTb.Text + "',urunaciklama ='" + urunaciklamaTb.Text + "',urunkategori = '" + urunkategoriCb.SelectedValue.ToString() + "' WHERE urunno='" + urunnoTb.Text + "'", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Ürün Düzenlendi!");
                    Con.Close();
                    urunveri();
                }
                catch
                {

                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (urunnoTb.Text == "")
            {
                MessageBox.Show("Lütfen Bir Ürün No Giriniz!");
            }
            else
            {
                Con.Open();
                string silmesorgu = "DELETE FROM urun WHERE urunno = '" + urunnoTb.Text + "';";
                SqlCommand cmd = new SqlCommand(silmesorgu, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Ürün Silindi!");
                Con.Close();
                urunveri();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            kategoriara();
    }

        private void urunkategoriCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void anasayfa_Click(object sender, EventArgs e)
        {
            AnaSayfa ans = new AnaSayfa();
            ans.Show();
            this.Hide();

        }

        private void araCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
