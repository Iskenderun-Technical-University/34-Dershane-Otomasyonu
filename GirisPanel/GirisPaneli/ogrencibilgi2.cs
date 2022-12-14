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
    public partial class ogrencibilgi2 : Form
    {
        public ogrencibilgi2()
        {
            InitializeComponent();
        }

        private void ogrencibilgi2_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'ogrenciKayitDataSet2.Ogr_Kayit' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ogr_KayitTableAdapter.Fill(this.ogrenciKayitDataSet2.Ogr_Kayit);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAnaSayfa fr = new FormAnaSayfa();
            fr.Show();
            this.Hide();
        }
    }
}
