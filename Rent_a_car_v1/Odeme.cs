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
    public partial class Odeme : Form
    {
        public Odeme()
        {
            InitializeComponent();
        }
        static String constring = @"Server=TALHA;Database=arac_kiralama;Trusted_Connection=True;";
        SqlConnection baglanti = new SqlConnection(constring);

        private void Odeme_son_btn_Click(object sender, EventArgs e)
        {
            String e1 = textBox1.Text, e2 = textBox2.Text, e3 = textBox3.Text, e4 = textBox4.Text, e5 = textBox5.Text, e6 = textBox6.Text, e7 = comboBox1.Text, e8 = comboBox2.Text;
            if (e1 == "" || e2 == "" || e3 == "" || e4 == "" || e5 == "" || e6 == "" || e7 == "" || e8 == "")
            {
                errorProvider1.SetError(textBox1, "Bu Alan Boş Geçilemez");
                errorProvider2.SetError(textBox2, "Bu Alan Boş Geçilemez");
                errorProvider3.SetError(textBox3, "Bu alan boş geçilmez");
                errorProvider4.SetError(textBox4, "Bu Alan Boş Geçilemez");
                errorProvider5.SetError(textBox5, "Bu Alan Boş Geçilemez");
                errorProvider6.SetError(textBox6, "Bu alan boş geçilmez");
                errorProvider7.SetError(comboBox1, "Bu alan boş geçilmez");
                errorProvider8.SetError(comboBox2, "Bu alan boş geçilmez");
            }
            else {

                baglanti.Open();
                String sql = "INSERT INTO odeme (kart1,kart2,kart3,kart4,kart_isim,cvc_kod,ay,yıl) values (@a,@b,@c,@d,@e,@f,@g,@h)";
                SqlCommand cmd = new SqlCommand(sql, baglanti);

                cmd.Parameters.AddWithValue("@a", textBox1.Text);
                cmd.Parameters.AddWithValue("@b", textBox2.Text);
                cmd.Parameters.AddWithValue("@c", textBox3.Text);
                cmd.Parameters.AddWithValue("@d", textBox4.Text);
                cmd.Parameters.AddWithValue("@e", textBox5.Text);
                cmd.Parameters.AddWithValue("@f", textBox6.Text);
                cmd.Parameters.AddWithValue("@g", comboBox1.Text);
                cmd.Parameters.AddWithValue("@h", comboBox2.Text);

                cmd.ExecuteNonQuery();
                baglanti.Close();






                MessageBox.Show("ÖDEME TAMAMLANDI");


            }
           
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                 && !char.IsSeparator(e.KeyChar);
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 4)
            {
                textBox2.Focus();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text.Length == 4)
            {
                textBox3.Focus();
            }
           
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text.Length == 4)
            {
                textBox4.Focus();
            }
            
        }
    }
}
