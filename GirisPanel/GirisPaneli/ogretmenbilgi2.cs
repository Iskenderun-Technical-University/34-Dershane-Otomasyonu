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
    public partial class ogretmenbilgi2 : Form
    {
        public ogretmenbilgi2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAnaSayfa fr = new FormAnaSayfa();
            fr.Show();
            this.Hide();
        }
    }
}
