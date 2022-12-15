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
    public partial class ogrodevbilgii : Form
    {
        public ogrodevbilgii()
        {
            InitializeComponent();
        }

        private void ogrodevbilgi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ogrenciKayitDataSet6.Ogr_Kayit' table. You can move, or remove it, as needed.
            this.ogr_KayitTableAdapter.Fill(this.ogrenciKayitDataSet6.Ogr_Kayit);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ogrenciformu fr =new ogrenciformu();
            fr.Show();
            this.Hide();
        }
    }
}
