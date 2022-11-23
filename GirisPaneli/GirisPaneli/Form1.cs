using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace GirisPaneli
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlDataReader dr;
        SqlCommand com;


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = textBox1.Text;
            string password = textBox2.Text;
            con = new SqlConnection("\r\nData Source=LAPTOP-JC99FFNO\\SQLEXPRESS02;Initial Catalog=Ornek;Integrated Security=True");
            com = new SqlCommand();
            con.Open();
            com.Connection = con;
            com.CommandText = "select * from Kullanici_Bilgi where kullanici_adi ='" + textBox1.Text + "'And sifre='" + textBox2.Text + "'";
            dr = com.ExecuteReader();
             if(dr.Read())
            {
                MessageBox.Show("Giriş Başarılı.");
            }
             else
            {
                MessageBox.Show("Hatalı Kullanıcı adı veya Şifre.");
            }
             con.Close();
        }

        private void btnKucult_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if(textBox1.Text == "Kullanıcı Adı")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.White;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if(textBox2.Text=="Parola")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.White;
                textBox2.UseSystemPasswordChar= true;
            }
        }
    }
}
