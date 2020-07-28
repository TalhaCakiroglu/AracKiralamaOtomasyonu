namespace Rent_a_car_v1
{
    partial class Giris
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giris));
            this.Brysl_btn = new System.Windows.Forms.Button();
            this.Krmsl_btn = new System.Windows.Forms.Button();
            this.uye_btn = new System.Windows.Forms.Button();
            this.k_adi_text = new System.Windows.Forms.TextBox();
            this.sifre_text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.guvenlik_sfr_rnd = new System.Windows.Forms.TextBox();
            this.guvenlik_sifre_cvp = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axShockwaveFlash1)).BeginInit();
            this.SuspendLayout();
            // 
            // Brysl_btn
            // 
            this.Brysl_btn.Font = new System.Drawing.Font("Mistral", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Brysl_btn.Location = new System.Drawing.Point(40, 246);
            this.Brysl_btn.Name = "Brysl_btn";
            this.Brysl_btn.Size = new System.Drawing.Size(126, 36);
            this.Brysl_btn.TabIndex = 0;
            this.Brysl_btn.Text = "BİREYSEL/GİRİŞ";
            this.Brysl_btn.UseVisualStyleBackColor = true;
            this.Brysl_btn.Click += new System.EventHandler(this.Brysl_btn_Click);
            // 
            // Krmsl_btn
            // 
            this.Krmsl_btn.Font = new System.Drawing.Font("Mistral", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Krmsl_btn.Location = new System.Drawing.Point(208, 246);
            this.Krmsl_btn.Name = "Krmsl_btn";
            this.Krmsl_btn.Size = new System.Drawing.Size(123, 36);
            this.Krmsl_btn.TabIndex = 1;
            this.Krmsl_btn.Text = "KURUMSAL/GİRİŞ";
            this.Krmsl_btn.UseVisualStyleBackColor = true;
            this.Krmsl_btn.Click += new System.EventHandler(this.Krmsl_btn_Click);
            // 
            // uye_btn
            // 
            this.uye_btn.Font = new System.Drawing.Font("Mistral", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.uye_btn.Location = new System.Drawing.Point(375, 246);
            this.uye_btn.Name = "uye_btn";
            this.uye_btn.Size = new System.Drawing.Size(126, 36);
            this.uye_btn.TabIndex = 2;
            this.uye_btn.Text = "ÜYE OL";
            this.uye_btn.UseVisualStyleBackColor = true;
            this.uye_btn.Click += new System.EventHandler(this.uye_btn_Click);
            // 
            // k_adi_text
            // 
            this.k_adi_text.Location = new System.Drawing.Point(199, 46);
            this.k_adi_text.Name = "k_adi_text";
            this.k_adi_text.Size = new System.Drawing.Size(100, 20);
            this.k_adi_text.TabIndex = 3;
            // 
            // sifre_text
            // 
            this.sifre_text.Location = new System.Drawing.Point(199, 86);
            this.sifre_text.Name = "sifre_text";
            this.sifre_text.Size = new System.Drawing.Size(100, 20);
            this.sifre_text.TabIndex = 4;
            this.sifre_text.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(16, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Kullanıcı/Firma Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(16, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Şifre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(16, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Güvenlik Şifresi:";
            // 
            // guvenlik_sfr_rnd
            // 
            this.guvenlik_sfr_rnd.Enabled = false;
            this.guvenlik_sfr_rnd.Location = new System.Drawing.Point(199, 142);
            this.guvenlik_sfr_rnd.Name = "guvenlik_sfr_rnd";
            this.guvenlik_sfr_rnd.ReadOnly = true;
            this.guvenlik_sfr_rnd.Size = new System.Drawing.Size(100, 20);
            this.guvenlik_sfr_rnd.TabIndex = 8;
            this.guvenlik_sfr_rnd.Text = "q4F8oP";
            this.guvenlik_sfr_rnd.TextChanged += new System.EventHandler(this.guvenlik_sfr_rnd_TextChanged);
            // 
            // guvenlik_sifre_cvp
            // 
            this.guvenlik_sifre_cvp.Location = new System.Drawing.Point(330, 142);
            this.guvenlik_sifre_cvp.Name = "guvenlik_sifre_cvp";
            this.guvenlik_sifre_cvp.Size = new System.Drawing.Size(100, 20);
            this.guvenlik_sifre_cvp.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Mistral", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(330, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 36);
            this.button1.TabIndex = 10;
            this.button1.Text = "ŞİFREMİ UNUTTUM";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Mistral", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(159, 204);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(225, 36);
            this.button2.TabIndex = 11;
            this.button2.Text = "ÜYE OLMADAN DEVAM ET";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // axShockwaveFlash1
            // 
            this.axShockwaveFlash1.Enabled = true;
            this.axShockwaveFlash1.Location = new System.Drawing.Point(626, 69);
            this.axShockwaveFlash1.Name = "axShockwaveFlash1";
            this.axShockwaveFlash1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axShockwaveFlash1.OcxState")));
            this.axShockwaveFlash1.Size = new System.Drawing.Size(192, 192);
            this.axShockwaveFlash1.TabIndex = 12;
            this.axShockwaveFlash1.Visible = false;
            // 
            // Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(553, 325);
            this.Controls.Add(this.axShockwaveFlash1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.guvenlik_sifre_cvp);
            this.Controls.Add(this.guvenlik_sfr_rnd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sifre_text);
            this.Controls.Add(this.k_adi_text);
            this.Controls.Add(this.uye_btn);
            this.Controls.Add(this.Krmsl_btn);
            this.Controls.Add(this.Brysl_btn);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Giris";
            this.Text = "GİRİŞ";
            this.Load += new System.EventHandler(this.Giris_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Giris_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axShockwaveFlash1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Brysl_btn;
        private System.Windows.Forms.Button Krmsl_btn;
        private System.Windows.Forms.Button uye_btn;
        private System.Windows.Forms.TextBox k_adi_text;
        private System.Windows.Forms.TextBox sifre_text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox guvenlik_sfr_rnd;
        private System.Windows.Forms.TextBox guvenlik_sifre_cvp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private AxShockwaveFlashObjects.AxShockwaveFlash axShockwaveFlash1;
    }
}

