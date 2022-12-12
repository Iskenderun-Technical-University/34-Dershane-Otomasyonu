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

namespace GirisPaneli
{
    public partial class FormKullaniciGiris : Form
    {
        SqlConnection con1;
        SqlDataReader dr1;
        SqlCommand com1;
        public FormKullaniciGiris()
        {
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnKucult_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Kullanıcı Adı")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.White;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Parola")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.White;
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = textBox1.Text;
            string password = textBox2.Text;
            con1 = new SqlConnection("Data Source=LAPTOP-JC99FFNO\\SQLEXPRESS02;Initial Catalog=KullaniciGiris;Integrated Security=True ");
            com1 = new SqlCommand();
            con1.Open();
            com1.Connection = con1;
            com1.CommandText = "select * from table_KullaniciGiris where Kullanici_adi ='" + textBox1.Text + "'And sifre='" + textBox2.Text + "'";
            dr1 = com1.ExecuteReader();
            if (dr1.Read())
            {

                FormAnaSayfa fr = new FormAnaSayfa();
                fr.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı adı veya Şifre.");
            }
            con1.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormGiris frm = new FormGiris();
            frm.Show();
            this.Hide();
        }
    }
}
