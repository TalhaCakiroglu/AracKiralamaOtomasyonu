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
    public partial class Uye_olmayan : Form
    {
        public Uye_olmayan()
        {
            InitializeComponent();
        }
        static String constring = @"Server=TALHA;Database=arac_kiralama;Trusted_Connection=True;";
        SqlConnection baglanti = new SqlConnection(constring);
        public void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void uye_olmyn_k_Click(object sender, EventArgs e)
        {
            /*
             Bu buton üye olmak istemeyen kullanıcıların bilgilerini veritabanına kayıt ederek
             olası sorunların önüne geçecektir.
             */
            String e1 = textBox1.Text, e2 = textBox2.Text, e3 = textBox3.Text;
            if (e1 == "" || e2 == "" || e3 == "")
            {
                errorProvider1.SetError(textBox1, "Bu Alan Boş Geçilemez");
                errorProvider2.SetError(textBox2, "Bu Alan Boş Geçilemez");
                errorProvider3.SetError(textBox3, "Bu alan boş geçilmez");
            }
            else
            {
                baglanti.Open();
                String sql = "INSERT INTO uye_olmayan (TC_no,ad,soyad,eposta,sürücü_lisans_no,telefon_no,dogum_tar) values (@a,@b,@c,@d,@e,@f,@g)";
                SqlCommand cmd = new SqlCommand(sql, baglanti);

                cmd.Parameters.AddWithValue("@a", textBox1.Text);
                cmd.Parameters.AddWithValue("@b", textBox2.Text);
                cmd.Parameters.AddWithValue("@c", textBox3.Text);
                cmd.Parameters.AddWithValue("@d", textBox5.Text);
                cmd.Parameters.AddWithValue("@e", textBox7.Text);
                cmd.Parameters.AddWithValue("@f", uye_ol_tel.Text);
                cmd.Parameters.AddWithValue("@g", maskedTextBox1.Text);

                MessageBox.Show("Yeni Üye Kaydı Oluşturuldu");

                cmd.ExecuteNonQuery();
                baglanti.Close();









                this.Hide();
                Form f1 = new rezervasyon();
                f1.Show();
            }
           
        }

        private void textBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void uye_ol_tel_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void maskedTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }
    }
}
