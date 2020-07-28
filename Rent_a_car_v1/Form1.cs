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
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-V5RV78R;Initial Catalog=arac_kiralama;Integrated Security=True"); 

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
        {  /*
                Bu buton giriş ekranında girilen değerleri veritabanında sorgusunu yaparak 
                bireysel müşterilerin sisteme girmesini sağlayacaktır.
             */


            try
            {
                String e1 = k_adi_text.Text, e2 = sifre_text.Text, e3 = guvenlik_sifre_cvp.Text;
                if (e1 == "" || e2 == "" || e3 == "")
                {
                    errorProvider1.SetError(k_adi_text, "Bu Alan Boş Geçilemez");
                    errorProvider2.SetError(sifre_text, "Bu Alan Boş Geçilemez");
                    errorProvider3.SetError(guvenlik_sifre_cvp, "Bu alan boş geçilmez");
                }
                baglanti.Open();
                string sql = "Select * From uye_bireyesel where ad=@ad AND sifre=@sifre";
                SqlParameter prm1 = new SqlParameter("ad", k_adi_text.Text.Trim());
                SqlParameter prm2 = new SqlParameter("sifre", sifre_text.Text.Trim());
                SqlCommand komut = new SqlCommand(sql, baglanti);
                komut.Parameters.Add(prm1);
                komut.Parameters.Add(prm2);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(dt);

                if(dt.Rows.Count > 0)
                {
                    this.Hide();
                    Form f1 = new rezervasyon();
                    f1.Show();
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Hatali giriş");
            }
          

        }

        private void Krmsl_btn_Click(object sender, EventArgs e)
        {
            try
            {
                String e1 = k_adi_text.Text, e2 = sifre_text.Text, e3 = guvenlik_sifre_cvp.Text;
                if (e1 == "" || e2 == "" || e3 == "")
                {
                    errorProvider1.SetError(k_adi_text, "Bu Alan Boş Geçilemez");
                    errorProvider2.SetError(sifre_text, "Bu Alan Boş Geçilemez");
                    errorProvider3.SetError(guvenlik_sifre_cvp, "Bu alan boş geçilmez");
                }
                baglanti.Open();
                string sql = "Select * From uye_kurumsal where sirket_adi=@sirket_adi AND sifre=@sifre";
                SqlParameter prm1 = new SqlParameter("sirket_adi", k_adi_text.Text.Trim());
                SqlParameter prm2 = new SqlParameter("sifre", sifre_text.Text.Trim());
                SqlCommand komut = new SqlCommand(sql, baglanti);
                komut.Parameters.Add(prm1);
                komut.Parameters.Add(prm2);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    this.Hide();
                    Form f1 = new rezervasyon();
                    f1.Show();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hatali giriş");
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

        private void guvenlik_sfr_rnd_TextChanged(object sender, EventArgs e)
        {

        }

        private void Giris_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
