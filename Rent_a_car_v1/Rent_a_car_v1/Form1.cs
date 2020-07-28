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
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        private void Giris_Load(object sender, EventArgs e)
        {
            axShockwaveFlash1.Movie = Application.StartupPath + "\\VdgG.gif";
            axShockwaveFlash1.Play();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f1 = new sifre_yenile();
            f1.Show();
        }

        private void Brysl_btn_Click(object sender, EventArgs e)
        {
            String e1 = k_adi_text.Text, e2 = sifre_text.Text, e3 = guvenlik_sifre_cvp.Text;
            if(e1== "" || e2 == "" || e3 == "")
            {
                errorProvider1.SetError(k_adi_text, "Bu Alan Boş Geçilemez");
                errorProvider2.SetError(sifre_text, "Bu Alan Boş Geçilemez");
                errorProvider3.SetError(guvenlik_sifre_cvp, "Bu alan boş geçilmez");
            }
           

            else
            {

                string s1 = k_adi_text.Text, s2 = sifre_text.Text, s3 = guvenlik_sifre_cvp.Text;
                guvenlik_sfr_rnd.Text = "aaaa";
                
                if (s1 == "talha" && s2=="1111" && s3=="aaaa")
                {
                    errorProvider1.Clear(); errorProvider2.Clear(); errorProvider3.Clear();
                    this.Hide();
                    Form f1 = new rezervasyon();
                    f1.Show();
                }
                else
                {
                    MessageBox.Show("Yanlış Giriş Yaptınız..");
                }
   

            }

            
        }

        private void Krmsl_btn_Click(object sender, EventArgs e)
        {
            String e1 = k_adi_text.Text, e2 = sifre_text.Text, e3 = guvenlik_sifre_cvp.Text;
            if (e1 == "" || e2 == "" || e3 == "")
            {
                errorProvider1.SetError(k_adi_text, "Bu Alan Boş Geçilemez");
                errorProvider2.SetError(sifre_text, "Bu Alan Boş Geçilemez");
                errorProvider3.SetError(guvenlik_sifre_cvp, "Bu alan boş geçilmez");
            }


            else
            {

                string s1 = k_adi_text.Text, s2 = sifre_text.Text, s3 = guvenlik_sifre_cvp.Text;
                guvenlik_sfr_rnd.Text = "aaaa";

                if (s1 == "talha" && s2 == "1111" && s3 == "aaaa")
                {
                    errorProvider1.Clear(); errorProvider2.Clear(); errorProvider3.Clear();
                    this.Hide();
                    Form f1 = new rezervasyon();
                    f1.Show();
                }
                else
                {
                    MessageBox.Show("Yanlış Giriş Yaptınız..");
                }


            }
        }

        private void uye_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f3 = new Uye_Ol();
            f3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f1 = new Uye_olmayan();
            f1.Show();
        }

    }
}
