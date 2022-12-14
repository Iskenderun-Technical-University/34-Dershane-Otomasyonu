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
    public partial class ogrencibilgiformu : Form
    {
        public ogrencibilgiformu()
        {
            InitializeComponent();
        }

        private void ogrencibilgiformu_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'ogrenciKayitDataSet1.Ogr_Kayit' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ogr_KayitTableAdapter1.Fill(this.ogrenciKayitDataSet1.Ogr_Kayit);
            // TODO: Bu kod satırı 'ogrenciKayitDataSet.Ogr_Kayit' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ogr_KayitTableAdapter.Fill(this.ogrenciKayitDataSet.Ogr_Kayit);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
             ogrenciformu fr = new ogrenciformu();
            fr.Show();
            this.Hide();
        }
    }
}
