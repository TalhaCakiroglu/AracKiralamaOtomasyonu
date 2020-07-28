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

    public partial class rezervasyon : Form
    {
        
        public rezervasyon()
        {
            InitializeComponent();
        }
        static String constring = @"Server=TALHA;Database=arac_kiralama;Trusted_Connection=True;";
        SqlConnection baglanti = new SqlConnection(constring);

        /*Bu buton Veritabanında kayıtlı ve müşterilerin girdiği özelliklere göre listeler*/
        private void Arac_goster_Click(object sender, EventArgs e)
        {
            if(dateTimePicker1.Value < dateTimePicker2.Value)
            {
                this.Hide();
                Form f2 = new Arac_Secimi();
                f2.Show();
            }
            else
            {
                MessageBox.Show("Lütfen geçerli tarih giriniz..");
            }
            
        }
    }
}
