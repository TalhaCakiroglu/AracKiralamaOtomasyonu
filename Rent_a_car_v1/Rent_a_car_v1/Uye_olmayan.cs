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
    public partial class Uye_olmayan : Form
    {
        public Uye_olmayan()
        {
            InitializeComponent();
        }

        private void uye_olmyn_k_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f1 = new rezervasyon();
            f1.Show();
        }
    }
}
