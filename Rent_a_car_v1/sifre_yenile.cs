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
            String e1 = tc_no_txt_1.Text, e2 = adi_txt_1.Text, e3 = soyad_txt_1.Text, e4 = soru_cmbx_1.Text, e5 = cevap_txt_1.Text, e6 = yeni_sif_tx_1.Text, e7 = tekr_sif_tx_1.Text;
            if (e1 == "" || e2 == "" || e3 == "" || e4 == "" || e5 == "" || e6 == "" || e7 == "")
            {
                errorProvider1.SetError(tc_no_txt_1, "Bu Alan Boş Geçilemez");
                errorProvider2.SetError(adi_txt_1, "Bu Alan Boş Geçilemez");
                errorProvider3.SetError(soyad_txt_1, "Bu alan boş geçilmez");
                errorProvider4.SetError(soru_cmbx_1, "Bu Alan Boş Geçilemez");
                errorProvider5.SetError(cevap_txt_1, "Bu Alan Boş Geçilemez");
                errorProvider6.SetError(yeni_sif_tx_1, "Bu alan boş geçilmez");
                errorProvider7.SetError(tekr_sif_tx_1, "Bu Alan Boş Geçilemez");
                
            }
            else
            {
                this.Hide();
                MessageBox.Show("Şifre Yenilendi");
                Form f2 = new Giris();
                f2.Show();
            }


           

        }

        private void Krmsl_sfr_yenile_Click(object sender, EventArgs e)
        {
            String e1 = textBox1.Text, e2 = textBox2.Text, e3 = textBox3.Text, e4 = textBox5.Text, e5 = textBox6.Text;
            if (e1 == "" || e2 == "" || e3 == "" || e4 == "" || e5 == "")
            {
                errorProvider8.SetError(textBox1, "Bu Alan Boş Geçilemez");
                errorProvider9.SetError(textBox2, "Bu Alan Boş Geçilemez");
                errorProvider10.SetError(textBox3, "Bu alan boş geçilmez");
                errorProvider11.SetError(textBox5, "Bu Alan Boş Geçilemez");
                errorProvider12.SetError(textBox6, "Bu Alan Boş Geçilemez");
              

            }

            else
            {
                this.Hide();
                MessageBox.Show("Şifre Yenilendi");
                Form f2 = new Giris();
                f2.Show();
            }

           
        }

        private void brysl_u_s_s_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            groupBox1.Visible = true;
            groupBox2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            brysl_u_s_s.Visible = false;
            groupBox2.Visible = true;
            groupBox1.Visible = false;
        }

        private void tc_no_txt_1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void adi_txt_1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void soyad_txt_1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
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
