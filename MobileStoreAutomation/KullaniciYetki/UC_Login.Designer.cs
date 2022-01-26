
namespace MobileStoreAutomation.KullaniciYetki
{
    partial class UC_Login
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

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Login));
            this.guna2WinProgressIndicator1 = new Guna.UI2.WinForms.Guna2WinProgressIndicator();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_KullaniciAd = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_Sifre = new Guna.UI2.WinForms.Guna2TextBox();
            this.Btn_Giris = new Guna.UI2.WinForms.Guna2Button();
            this.lbl_Hata = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2WinProgressIndicator1
            // 
            this.guna2WinProgressIndicator1.CircleSize = 5F;
            this.guna2WinProgressIndicator1.Location = new System.Drawing.Point(616, 238);
            this.guna2WinProgressIndicator1.Name = "guna2WinProgressIndicator1";
            this.guna2WinProgressIndicator1.ProgressColor = System.Drawing.Color.Black;
            this.guna2WinProgressIndicator1.Size = new System.Drawing.Size(140, 140);
            this.guna2WinProgressIndicator1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lbl_Hata);
            this.panel1.Controls.Add(this.Btn_Giris);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_Sifre);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_KullaniciAd);
            this.panel1.Location = new System.Drawing.Point(244, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(331, 452);
            this.panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(123, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(102, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Giriş Ekranı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(13, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kullanıcı Adı :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(13, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 28);
            this.label4.TabIndex = 6;
            this.label4.Text = "Şifre :";
            // 
            // txt_KullaniciAd
            // 
            this.txt_KullaniciAd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_KullaniciAd.DefaultText = "";
            this.txt_KullaniciAd.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_KullaniciAd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_KullaniciAd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_KullaniciAd.DisabledState.Parent = this.txt_KullaniciAd;
            this.txt_KullaniciAd.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_KullaniciAd.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_KullaniciAd.FocusedState.Parent = this.txt_KullaniciAd;
            this.txt_KullaniciAd.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_KullaniciAd.HoverState.Parent = this.txt_KullaniciAd;
            this.txt_KullaniciAd.Location = new System.Drawing.Point(18, 194);
            this.txt_KullaniciAd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_KullaniciAd.Name = "txt_KullaniciAd";
            this.txt_KullaniciAd.PasswordChar = '\0';
            this.txt_KullaniciAd.PlaceholderText = "Kullanıcı Adınızı Girin";
            this.txt_KullaniciAd.SelectedText = "";
            this.txt_KullaniciAd.ShadowDecoration.Parent = this.txt_KullaniciAd;
            this.txt_KullaniciAd.Size = new System.Drawing.Size(278, 34);
            this.txt_KullaniciAd.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_KullaniciAd.TabIndex = 7;
            // 
            // txt_Sifre
            // 
            this.txt_Sifre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Sifre.DefaultText = "";
            this.txt_Sifre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Sifre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Sifre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Sifre.DisabledState.Parent = this.txt_Sifre;
            this.txt_Sifre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Sifre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Sifre.FocusedState.Parent = this.txt_Sifre;
            this.txt_Sifre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Sifre.HoverState.Parent = this.txt_Sifre;
            this.txt_Sifre.Location = new System.Drawing.Point(18, 277);
            this.txt_Sifre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Sifre.Name = "txt_Sifre";
            this.txt_Sifre.PasswordChar = '\0';
            this.txt_Sifre.PlaceholderText = "Şifrenizi Girin";
            this.txt_Sifre.SelectedText = "";
            this.txt_Sifre.ShadowDecoration.Parent = this.txt_Sifre;
            this.txt_Sifre.Size = new System.Drawing.Size(278, 37);
            this.txt_Sifre.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_Sifre.TabIndex = 8;
            // 
            // Btn_Giris
            // 
            this.Btn_Giris.BorderRadius = 26;
            this.Btn_Giris.CheckedState.Parent = this.Btn_Giris;
            this.Btn_Giris.CustomImages.Parent = this.Btn_Giris;
            this.Btn_Giris.FillColor = System.Drawing.Color.Orange;
            this.Btn_Giris.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_Giris.ForeColor = System.Drawing.Color.Black;
            this.Btn_Giris.HoverState.Parent = this.Btn_Giris;
            this.Btn_Giris.Location = new System.Drawing.Point(83, 335);
            this.Btn_Giris.Name = "Btn_Giris";
            this.Btn_Giris.ShadowDecoration.Parent = this.Btn_Giris;
            this.Btn_Giris.Size = new System.Drawing.Size(164, 41);
            this.Btn_Giris.TabIndex = 9;
            this.Btn_Giris.Text = "GİRİŞ";
            this.Btn_Giris.Click += new System.EventHandler(this.Btn_Giris_Click);
            // 
            // lbl_Hata
            // 
            this.lbl_Hata.AutoSize = true;
            this.lbl_Hata.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Hata.ForeColor = System.Drawing.Color.Red;
            this.lbl_Hata.Location = new System.Drawing.Point(41, 396);
            this.lbl_Hata.Name = "lbl_Hata";
            this.lbl_Hata.Size = new System.Drawing.Size(288, 28);
            this.lbl_Hata.TabIndex = 7;
            this.lbl_Hata.Text = "Eksik veya Hatalı Bilgi Girdiniz.";
            this.lbl_Hata.Visible = false;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 26;
            this.guna2Elipse1.TargetControl = this;
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // UC_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.guna2WinProgressIndicator1);
            this.Name = "UC_Login";
            this.Size = new System.Drawing.Size(1241, 663);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2WinProgressIndicator guna2WinProgressIndicator1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button Btn_Giris;
        private Guna.UI2.WinForms.Guna2TextBox txt_Sifre;
        private Guna.UI2.WinForms.Guna2TextBox txt_KullaniciAd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_Hata;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Timer timer1;
    }
}
