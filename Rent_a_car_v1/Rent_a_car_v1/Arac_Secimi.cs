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
    public partial class Arac_Secimi : Form
    {
        public Arac_Secimi()
        {
            InitializeComponent();
        }

        private void ek_hzmt_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f1 = new Ek_hizmet();
            f1.Show();
        }

        private void ödemeye_gec_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f1 = new Odeme();
            f1.Show();
        }
    }
}
