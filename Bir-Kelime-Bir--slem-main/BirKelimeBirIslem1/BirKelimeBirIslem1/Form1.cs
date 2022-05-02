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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnIslemOyunu_Click(object sender, EventArgs e)
        {
            IslemKismi islem1 = new IslemKismi();
            islem1.Show();
            this.Hide();
        }
    }
}
