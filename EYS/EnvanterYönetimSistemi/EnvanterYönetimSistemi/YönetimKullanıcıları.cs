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
using System.Data.Common;


namespace EnvanterYönetimSistemi
{
    public partial class YönetimKullanıcıları : Form
    {
        public YönetimKullanıcıları()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=WINDEV2209EVAL;Initial Catalog=Envanterdb;Integrated Security=True");

        private void label2_Click(object sender, EventArgs e)
        {
          

        }
        void veriler()
        {
            
            string sorgular = "SELECT kullaniciadi AS KULLANICI_ADI, adsoyad AS AD_SOYAD, sifre AS ŞİFRE, telefon AS TELEFON FROM kullanici";
            SqlDataAdapter da = new SqlDataAdapter(sorgular, Con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            kullaniciGV.DataSource = ds.Tables[0];
            





        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            if (telefonTb.Text == "")
            {
                MessageBox.Show("Lütfen Telefon Giriniz!");
            }
            else if (kulllaniciTb.Text == "")
            {
                MessageBox.Show("Lütfen Kullanıcı Adı Giriniz!");
            }
            else if (adsoyadTb.Text == "")
            {
                MessageBox.Show("Lütfen Ad Soyad Giriniz!");
            }
            else if (sifreTb.Text == "")
            {
                MessageBox.Show("Lütfen Şifre Giriniz!");
            }
            else
            {

                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO kullanici values('" + kulllaniciTb.Text + "','" + adsoyadTb.Text + "','" + sifreTb.Text + "','" + telefonTb.Text + "')", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Kullanıcı Eklendi!");
                    Con.Close();
                }
                catch
                {

                }
            }
        }

 

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //kulllaniciTb.Text = kullaniciGV.SelectedRows[0].Cells[0].Value.ToString();
            //adsoyadTb.Text = kullaniciGV.SelectedRows[0].Cells[1].Value.ToString();
            //sifreTb.Text = kullaniciGV.SelectedRows[0].Cells[2].Value.ToString();
            //telefonTb.Text = kullaniciGV.SelectedRows[0].Cells[3].Value.ToString();



        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            if(telefonTb.Text == "")
            {
                MessageBox.Show("Lütfen Bir Telefon Numarası Giriniz!");
            }
            else
            {
                Con.Open();
                string silmesorgu = "DELETE FROM kullanici WHERE telefon = '" + telefonTb.Text + "';";
                SqlCommand cmd = new SqlCommand(silmesorgu, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Kullanıcı Silindi!");
                Con.Close();
                veriler();
            }
        }

        private void YönetimKullanıcıları_Load(object sender, EventArgs e)
        {
            veriler();
        }

        private void yenile_Click(object sender, EventArgs e)
        {
            veriler();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (telefonTb.Text == "")
            { MessageBox.Show("lütfen Telefon Girin!");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE kullanici SET kullaniciadi='" + kulllaniciTb.Text + "',adsoyad='" + adsoyadTb.Text + "',sifre='" + sifreTb.Text + "' WHERE telefon='" + telefonTb.Text + "'", Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Kullanıcı Düzenlendi!");
                    Con.Close();
                }
                catch
                {

                }
            }

        }

        private void telefonTb_TextChanged(object sender, EventArgs e)
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

