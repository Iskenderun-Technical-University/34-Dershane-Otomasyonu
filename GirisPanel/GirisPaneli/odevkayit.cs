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
    public partial class odevkayit : Form
    {
        public odevkayit()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=EMIR\\SQLEXPRESS;Initial Catalog=OgrenciKayit;Integrated Security=True"); // SQL BAGLANTISI 
        private void odevkayit_Load(object sender, EventArgs e)
        {
            /*
            // TODO: This line of code loads data into the 'ogrenciKayitDataSet5.Ogr_Kayit' table. You can move, or remove it, as needed.
            this.ogr_KayitTableAdapter1.Fill(this.ogrenciKayitDataSet5.Ogr_Kayit);
            // TODO: This line of code loads data into the 'ogrenciKayitDataSet4.Ogr_Kayit' table. You can move, or remove it, as needed.
            this.ogr_KayitTableAdapter.Fill(this.ogrenciKayitDataSet4.Ogr_Kayit);
            */
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            this.ogr_KayitTableAdapter1.Fill(this.ogrenciKayitDataSet5.Ogr_Kayit);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Ogr_kayit (OgrNo,OgrAd,OgrSoyad,OgrDal,YKSDenemePuanı,YKSDenemeNeti) values (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtNo.Text);
            komut.Parameters.AddWithValue("@p2", txtAd.Text);
            komut.Parameters.AddWithValue("@p3", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p4", cmbAlan.Text);           // KAYDET
            komut.Parameters.AddWithValue("@p5", txtPuani.Text);
            komut.Parameters.AddWithValue("@p6", txtNeti.Text);

            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Personel Eklendi");

        }


        void temizle()
        {
            txtNo.Text = " ";
            txtAd.Text = " ";
            txtSoyad.Text = " ";                             // İÇİNDEKİ KUTUCUKLARI TEMİZLEME
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            cmbAlan.Text = " ";
            txtPuani.Text = " ";
            txtNeti.Text = " ";
            txtNo.Focus();

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand guncelle = new SqlCommand("Update Ogr_Kayit Set OgrNo=@p1,OgrAd=@p2,OgrSoyad=@p3,OgreniOdevDurumu=@p4,OgrDal=@p5,YKSDenemePuanı=@p6,YKSDenemeNeti=@p7 where Id=@p8 ", baglanti);
            guncelle.Parameters.AddWithValue("p1", txtNo.Text);
            guncelle.Parameters.AddWithValue("p2", txtAd.Text);
            guncelle.Parameters.AddWithValue("p3", txtSoyad.Text);    //GÜNCELLE
            guncelle.Parameters.AddWithValue("p4", label8.Text);
            guncelle.Parameters.AddWithValue("p5", cmbAlan.Text);
            guncelle.Parameters.AddWithValue("p6", txtPuani.Text);
            guncelle.Parameters.AddWithValue("p7", txtNeti.Text);
            guncelle.Parameters.AddWithValue("p8", txtid.Text);





            guncelle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Personel Güncellemesi Tamamlandı");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {                                                                         // YAPTI KUTUCUĞU 
                label8.Text = "True";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                label8.Text = "False";
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secim = dataGridView1.SelectedCells[0].RowIndex;
            txtNo.Text = dataGridView1.Rows[secim].Cells[0].Value.ToString();
            txtAd.Text = dataGridView1.Rows[secim].Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[secim].Cells[2].Value.ToString();
            label8.Text = dataGridView1.Rows[secim].Cells[3].Value.ToString();
            cmbAlan.Text = dataGridView1.Rows[secim].Cells[4].Value.ToString();
            txtPuani.Text = dataGridView1.Rows[secim].Cells[5].Value.ToString();
            txtNeti.Text = dataGridView1.Rows[secim].Cells[6].Value.ToString();
            txtid.Text = dataGridView1.Rows[secim].Cells[7].Value.ToString();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand sil = new SqlCommand("Delete From Ogr_Kayit Where OgrNo=@p1", baglanti); //SİL
            sil.Parameters.AddWithValue("@p1", txtNo.Text);
            sil.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("kayıt silindi");

            baglanti.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label8_TextChanged(object sender, EventArgs e)
        {

            if (label8.Text == "True")
            {
                radioButton1.Checked = true;
            }
            if (label8.Text == "False")
            {
                radioButton2.Checked = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAnaSayfa fr = new FormAnaSayfa();
            fr.Show();
            this.Hide();    
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
