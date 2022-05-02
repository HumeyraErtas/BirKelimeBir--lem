using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BirKelimeBirIslem1
{
    public partial class IslemKismi : Form
    {
        public IslemKismi()
        {
            InitializeComponent();
        }

        private void IslemRandom_Click(object sender, EventArgs e)
        {
            IslemRandom islem = new IslemRandom();
            islem.Show();
            this.Hide();
        }
    }
}
