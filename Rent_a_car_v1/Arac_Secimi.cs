using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

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
            
            Form f1 = new Ek_hizmet();
            f1.Show();
        }

        private void ödemeye_gec_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f1 = new Odeme();
            f1.Show();
        }
        static String constring = @"Server=TALHA;Database=arac_kiralama;Trusted_Connection=True;";
        SqlConnection baglanti = new SqlConnection(constring);
        DataTable tablo = new DataTable();
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            tablo.Clear();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from arac_bilgisi where tipi='ekonomi'", baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
           
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            tablo.Clear();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from arac_bilgisi where tipi='orta'", baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
           
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            tablo.Clear();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from arac_bilgisi where tipi='luks'", baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            tablo.Clear();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from arac_bilgisi where tipi='minibus'", baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            tablo.Clear();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from arac_bilgisi", baglanti);
            adtr.Fill(tablo);
            dataGridView1.DataSource = tablo;
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = comboBox1.SelectedIndex;
            if(selectedIndex == 1)
            {
                label5.Text = "100TL";
            }
            else if(selectedIndex == 2)
            {
                label5.Text = "150tl";
            }
            else if(selectedIndex == 3)
            {
                label5.Text = "200TL";
            }
            else { label5.Text = "300TL"; }
        }
    }
}
