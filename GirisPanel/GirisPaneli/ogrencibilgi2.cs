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
    public partial class ogrencibilgi2 : Form
    {
        public ogrencibilgi2()
        {
            InitializeComponent();
        }

        private void ogrencibilgi2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ogrenciKayitDataSet3.Ogr_Kayit' table. You can move, or remove it, as needed.
            this.ogr_KayitTableAdapter1.Fill(this.ogrenciKayitDataSet3.Ogr_Kayit);
         

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAnaSayfa fr = new FormAnaSayfa();
            fr.Show();
            this.Hide();
        }
    }
}
