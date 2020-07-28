using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rent_a_car_v1
{
    public partial class sifre_yenile : Form
    {
        public sifre_yenile()
        {
            InitializeComponent();
        }

        private void brys_sfr_yenile_Click(object sender, EventArgs e)
        {
            this.Hide();
            MessageBox.Show("Şifre Yenilendi");
            Form f2 = new Giris();
            f2.Show();

        }

        private void Krmsl_sfr_yenile_Click(object sender, EventArgs e)
        {
            this.Hide();
            MessageBox.Show("Şifre Yenilendi");
            Form f2 = new Giris();
            f2.Show();
        }

        private void brysl_u_s_s_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
        }
    }
}
