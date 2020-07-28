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
    public partial class Uye_Ol : Form
    {
        public Uye_Ol()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MessageBox.Show("Yeni Üye Kaydı Oluşturuldu");
            Form f2 = new Giris();
            f2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }

        private void Kurumsal_uye_ol_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MessageBox.Show("Yeni Üye Kaydı Oluşturuldu");
            Form f2 = new Giris();
            f2.Show();
        }
    }
}
