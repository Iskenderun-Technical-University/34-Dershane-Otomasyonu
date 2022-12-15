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


namespace GirisPaneli
{
    public partial class FormOgrKayıt : Form
    {
        public FormOgrKayıt()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=EMIR\\SQLEXPRESS;Initial Catalog=OgrenciKayit;Integrated Security=True");
       
        void temizle()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            maskedTextBox1.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            maskedTextBox2.Text = "";
            comboBox3.Text = "";
            maskedTextBox3.Text = "";
            textBox1.Focus();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormAnaSayfa fr =new FormAnaSayfa();
            fr.Show();
            this.Close();
        }

        bool tutus;
        int fareX,fareY;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (tutus == true)
            {
                this.Left = Cursor.Position.X - fareX;
                this.Top = Cursor.Position.Y - fareY;
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            tutus = false;
            fareX = 0;
            fareY = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            baglanti.Open();
            
            SqlCommand komut = new SqlCommand("insert into Ogr_Kayit (OgrAd,OgrSoyad,OgrNo,OgrSinif,OgrDal,OgrCinsiyet,OgrAdres,VeliAd,VeliSoyad,VeliTel,VeliYakinlik,VeliGelir) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12)", baglanti);
            komut.Parameters.AddWithValue("@p1", textBox1.Text);
            komut.Parameters.AddWithValue("@p2", textBox2.Text);
            komut.Parameters.AddWithValue("@p3", maskedTextBox1.Text);
            komut.Parameters.AddWithValue("@p4", comboBox2.Text);
            komut.Parameters.AddWithValue("@p5", comboBox1.Text);
            komut.Parameters.AddWithValue("@p6", label13.Text);
            komut.Parameters.AddWithValue("@p7", textBox3.Text);
            komut.Parameters.AddWithValue("@p8", textBox5.Text);
            komut.Parameters.AddWithValue("@p9", textBox4.Text);
            komut.Parameters.AddWithValue("@p10", maskedTextBox2.Text);
            komut.Parameters.AddWithValue("@p11", comboBox3.Text);
            komut.Parameters.AddWithValue("@p12", maskedTextBox3.Text);
            
            komut.ExecuteNonQuery();  
            
            baglanti.Close();
            MessageBox.Show("Ogrenci Kaydı Yapıldı");


            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked==true)
            {
                label13.Text = radioButton1.Text;
            }
           
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                label13.Text = radioButton2.Text;
            }
        }

        private void buttonTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            tutus = true;
            fareX = Cursor.Position.X - this.Left;
            fareY = Cursor.Position.Y - this.Top;

        }
    }
}
