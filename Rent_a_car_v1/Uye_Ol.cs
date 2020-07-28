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
    public partial class Uye_Ol : Form
    {
        public Uye_Ol()
        {
            InitializeComponent();
        }/*
        SqlConnection baglanti = new SqlConnection("Data Source=TALHA;Initial Catalog=arac_kiralama;Integrated Security=True"); */
        
        static String constring = @"Server=TALHA;Database=arac_kiralama;Trusted_Connection=True;";
        SqlConnection baglanti = new SqlConnection(constring);
        


        private void button3_Click(object sender, EventArgs e)
        {
            Kurumsal_uye_ol.Visible = false;
            groupBox1.Visible = true;
            groupBox2.Visible = false;
        }
        
        /*Bu buton bireysel üye olmak isteyen müşterilerin bilgilerini veritabanına kaydetmeyi sağlar.*/
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {   /*
                if (baglanti.State == ConnectionState.Closed)
                {
                   
                }*/
                baglanti.Open();
                String kayit = "insert into uye_bireyesel (TC_no,ad,soyad,sifre,eposta,gizli_soru,cevap,lisans_no,telefon,dogum_tarihi,sehir,ulke,adres) VALUES (@TC_no,@ad,@soyad,@sifre,@eposta,@gizli_soru,@cevap,@lisans_no,@telefon,@dogum_tarihi,@sehir,@ulke,@adres)";
                    SqlCommand cmd = new SqlCommand(kayit, baglanti);

                    cmd.Parameters.AddWithValue("@TC_no", textBox1.Text);
                    cmd.Parameters.AddWithValue("@ad", textBox2.Text);
                    cmd.Parameters.AddWithValue("@soyad", textBox3.Text);
                    cmd.Parameters.AddWithValue("@sifre", textBox4.Text);
                    cmd.Parameters.AddWithValue("@eposta", textBox5.Text);
                    cmd.Parameters.AddWithValue("@gizli_soru", comboBox1.Text);
                    cmd.Parameters.AddWithValue("@cevap", textBox6.Text);
                    cmd.Parameters.AddWithValue("@lisans_no", textBox7.Text);
                    cmd.Parameters.AddWithValue("@telefon", textBox16.Text);
                    cmd.Parameters.AddWithValue("@dogum_tarihi", textBox19.Text);
                    cmd.Parameters.AddWithValue("@sehir", textBox10.Text);
                    cmd.Parameters.AddWithValue("@ulke", textBox11.Text);
                    cmd.Parameters.AddWithValue("@adres", textBox12.Text);
                    cmd.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Yeni Üye Kaydı Oluşturuldu");
                    this.Hide();

                    Form f2 = new Giris();
                    f2.Show();
                
               
                
                

            }
            catch (Exception)
            {
                MessageBox.Show("Hata");
            }    
        }

      

        private void Kurumsal_uye_ol_Click(object sender, EventArgs e)
        {
            button3.Visible = false;
            groupBox2.Visible = true;
            groupBox1.Visible = false;
        }

      

        

        private void button2_Click(object sender, EventArgs e)
        {
            String e1 = textBox13.Text, e2 = textBox14.Text, e3 = textBox15.Text, e4=textBox8.Text;
            if (e1 == "" || e2 == "" || e3 == "" || e4=="")
            {
                errorProvider4.SetError(textBox13, "Bu Alan Boş Geçilemez");
                errorProvider5.SetError(textBox14, "Bu Alan Boş Geçilemez");
                errorProvider6.SetError(textBox15, "Bu alan boş geçilmez");
                errorProvider14.SetError(textBox8, "Bu alan boş geçilemez");
            }
            else {
                baglanti.Open();
                String sql = "INSERT INTO uye_kurumsal (sirket_adi,yetkili_adi,yetkili_soyadi,sifre,sirket_tel,basvuru_tipi,vergi_dairesi,vergi_no) values (@a,@b,@c,@d,@e,@f,@g,@h)";
                SqlCommand cmd = new SqlCommand(sql, baglanti);

                cmd.Parameters.AddWithValue("@a", textBox13.Text);
                cmd.Parameters.AddWithValue("@b", textBox14.Text);
                cmd.Parameters.AddWithValue("@c", textBox15.Text);
                cmd.Parameters.AddWithValue("@d", textBox8.Text);
                cmd.Parameters.AddWithValue("@e", textBox9.Text);
                cmd.Parameters.AddWithValue("@f", comboBox2.Text);
                cmd.Parameters.AddWithValue("@g", textBox17.Text);
                cmd.Parameters.AddWithValue("@h", textBox18.Text);


                cmd.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Yeni Üye Kaydı Oluşturuldu");
                


                this.Hide();
                Form f2 = new Giris();
                f2.Show();
            }
        }



        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void textBox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void textBox12_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void textBox13_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void textBox14_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void textBox15_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar)
                && !char.IsSeparator(e.KeyChar);
        }

        private void textBox17_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox18_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
