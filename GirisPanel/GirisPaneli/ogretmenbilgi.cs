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
    public partial class ogretmenbilgi : Form
    {
        public ogretmenbilgi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ogrenciformu fr =new ogrenciformu();
            fr.Show();
            this.Hide();
        }

        private void ogretmenbilgi_Load(object sender, EventArgs e)
        {

        }
    }
}
