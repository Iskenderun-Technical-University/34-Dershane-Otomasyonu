using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GirisPaneli
{
    public partial class ogrencibilgi : Form
    {
        public ogrencibilgi()
        {
            InitializeComponent();
        }

        private void ogrencibilgi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ogrenciKayitDataSet7.Ogr_Kayit' table. You can move, or remove it, as needed.
            this.ogr_KayitTableAdapter.Fill(this.ogrenciKayitDataSet7.Ogr_Kayit);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ogrenciformu fr =new ogrenciformu();
            fr.Show();
            this.Hide();
        }
    }
}
