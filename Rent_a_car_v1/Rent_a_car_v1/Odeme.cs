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
    public partial class Odeme : Form
    {
        public Odeme()
        {
            InitializeComponent();
        }

        private void Odeme_son_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ÖDEME TAMAMLANDI");
        }
    }
}
