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

    public partial class rezervasyon : Form
    {
        
        public rezervasyon()
        {
            InitializeComponent();
        }

        private void Arac_goster_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f2 = new Arac_Secimi();
            f2.Show();
        }
    }
}
