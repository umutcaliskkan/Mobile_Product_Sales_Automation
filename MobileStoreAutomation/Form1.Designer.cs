
namespace MobileStoreAutomation
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_İptal = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Onayla = new Guna.UI2.WinForms.Guna2Button();
            this.txt_Sifre = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_UrunSil = new Guna.UI2.WinForms.Guna2Button();
            this.Btn_Musteriler = new Guna.UI2.WinForms.Guna2Button();
            this.Btn_Stok = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Satis = new Guna.UI2.WinForms.Guna2Button();
            this.Btn_UrunEkle = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.uC_UrunSil1 = new MobileStoreAutomation.KullaniciYetki.UC_UrunSil();
            this.uC_MüsteriKayitlari1 = new MobileStoreAutomation.KullaniciYetki.UC_MüsteriKayitlari();
            this.uC_Stok1 = new MobileStoreAutomation.KullaniciYetki.UC_Stok();
            this.uC_Satis1 = new MobileStoreAutomation.KullaniciYetki.UC_Satis();
            this.uC_YeniUrunEkle1 = new MobileStoreAutomation.KullaniciYetki.UC_YeniUrunEkle();
            this.Btn_Cikis = new System.Windows.Forms.Button();
            this.btn_Kucult = new System.Windows.Forms.Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse4 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse5 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse7 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse8 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.uC_Login1 = new MobileStoreAutomation.KullaniciYetki.UC_Login();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btn_İptal);
            this.panel1.Controls.Add(this.btn_Onayla);
            this.panel1.Controls.Add(this.txt_Sifre);
            this.panel1.Controls.Add(this.btn_UrunSil);
            this.panel1.Controls.Add(this.Btn_Musteriler);
            this.panel1.Controls.Add(this.Btn_Stok);
            this.panel1.Controls.Add(this.btn_Satis);
            this.panel1.Controls.Add(this.Btn_UrunEkle);
            this.panel1.Location = new System.Drawing.Point(3, 40);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 728);
            this.panel1.TabIndex = 1;
            // 
            // btn_İptal
            // 
            this.btn_İptal.CheckedState.Parent = this.btn_İptal;
            this.btn_İptal.CustomImages.Parent = this.btn_İptal;
            this.btn_İptal.FillColor = System.Drawing.Color.Orange;
            this.btn_İptal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_İptal.ForeColor = System.Drawing.Color.White;
            this.btn_İptal.HoverState.Parent = this.btn_İptal;
            this.btn_İptal.Location = new System.Drawing.Point(195, 599);
            this.btn_İptal.Name = "btn_İptal";
            this.btn_İptal.ShadowDecoration.Parent = this.btn_İptal;
            this.btn_İptal.Size = new System.Drawing.Size(165, 60);
            this.btn_İptal.TabIndex = 6;
            this.btn_İptal.Text = "İptal";
            this.btn_İptal.Click += new System.EventHandler(this.btn_İptal_Click);
            // 
            // btn_Onayla
            // 
            this.btn_Onayla.CheckedState.Parent = this.btn_Onayla;
            this.btn_Onayla.CustomImages.Parent = this.btn_Onayla;
            this.btn_Onayla.FillColor = System.Drawing.Color.Orange;
            this.btn_Onayla.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Onayla.ForeColor = System.Drawing.Color.White;
            this.btn_Onayla.HoverState.Parent = this.btn_Onayla;
            this.btn_Onayla.Location = new System.Drawing.Point(9, 600);
            this.btn_Onayla.Name = "btn_Onayla";
            this.btn_Onayla.ShadowDecoration.Parent = this.btn_Onayla;
            this.btn_Onayla.Size = new System.Drawing.Size(172, 59);
            this.btn_Onayla.TabIndex = 5;
            this.btn_Onayla.Text = "Onayla";
            this.btn_Onayla.Click += new System.EventHandler(this.btn_Onayla_Click);
            // 
            // txt_Sifre
            // 
            this.txt_Sifre.BorderColor = System.Drawing.Color.Transparent;
            this.txt_Sifre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Sifre.DefaultText = "";
            this.txt_Sifre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Sifre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Sifre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Sifre.DisabledState.Parent = this.txt_Sifre;
            this.txt_Sifre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Sifre.FillColor = System.Drawing.Color.Orange;
            this.txt_Sifre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Sifre.FocusedState.Parent = this.txt_Sifre;
            this.txt_Sifre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Sifre.ForeColor = System.Drawing.Color.Black;
            this.txt_Sifre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Sifre.HoverState.Parent = this.txt_Sifre;
            this.txt_Sifre.Location = new System.Drawing.Point(11, 555);
            this.txt_Sifre.Margin = new System.Windows.Forms.Padding(5);
            this.txt_Sifre.Name = "txt_Sifre";
            this.txt_Sifre.PasswordChar = '*';
            this.txt_Sifre.PlaceholderText = "";
            this.txt_Sifre.SelectedText = "";
            this.txt_Sifre.ShadowDecoration.Parent = this.txt_Sifre;
            this.txt_Sifre.Size = new System.Drawing.Size(343, 43);
            this.txt_Sifre.TabIndex = 4;
            this.txt_Sifre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_UrunSil
            // 
            this.btn_UrunSil.BorderRadius = 35;
            this.btn_UrunSil.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_UrunSil.CheckedState.FillColor = System.Drawing.Color.White;
            this.btn_UrunSil.CheckedState.Parent = this.btn_UrunSil;
            this.btn_UrunSil.CustomImages.Parent = this.btn_UrunSil;
            this.btn_UrunSil.FillColor = System.Drawing.Color.Orange;
            this.btn_UrunSil.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_UrunSil.ForeColor = System.Drawing.Color.Black;
            this.btn_UrunSil.HoverState.Parent = this.btn_UrunSil;
            this.btn_UrunSil.Image = ((System.Drawing.Image)(resources.GetObject("btn_UrunSil.Image")));
            this.btn_UrunSil.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_UrunSil.ImageSize = new System.Drawing.Size(50, 50);
            this.btn_UrunSil.Location = new System.Drawing.Point(3, 476);
            this.btn_UrunSil.Name = "btn_UrunSil";
            this.btn_UrunSil.ShadowDecoration.Parent = this.btn_UrunSil;
            this.btn_UrunSil.Size = new System.Drawing.Size(357, 71);
            this.btn_UrunSil.TabIndex = 4;
            this.btn_UrunSil.Text = "ÜRÜN SİL";
            this.btn_UrunSil.Click += new System.EventHandler(this.btn_UrunSil_Click);
            // 
            // Btn_Musteriler
            // 
            this.Btn_Musteriler.BorderRadius = 35;
            this.Btn_Musteriler.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.Btn_Musteriler.CheckedState.FillColor = System.Drawing.Color.White;
            this.Btn_Musteriler.CheckedState.Parent = this.Btn_Musteriler;
            this.Btn_Musteriler.CustomImages.Parent = this.Btn_Musteriler;
            this.Btn_Musteriler.FillColor = System.Drawing.Color.Orange;
            this.Btn_Musteriler.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_Musteriler.ForeColor = System.Drawing.Color.Black;
            this.Btn_Musteriler.HoverState.Parent = this.Btn_Musteriler;
            this.Btn_Musteriler.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Musteriler.Image")));
            this.Btn_Musteriler.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Btn_Musteriler.ImageSize = new System.Drawing.Size(50, 50);
            this.Btn_Musteriler.Location = new System.Drawing.Point(3, 390);
            this.Btn_Musteriler.Name = "Btn_Musteriler";
            this.Btn_Musteriler.ShadowDecoration.Parent = this.Btn_Musteriler;
            this.Btn_Musteriler.Size = new System.Drawing.Size(357, 71);
            this.Btn_Musteriler.TabIndex = 3;
            this.Btn_Musteriler.Text = "MÜŞTERİ KAYITLARI";
            this.Btn_Musteriler.Click += new System.EventHandler(this.Btn_Musteriler_Click);
            // 
            // Btn_Stok
            // 
            this.Btn_Stok.BorderRadius = 35;
            this.Btn_Stok.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.Btn_Stok.CheckedState.FillColor = System.Drawing.Color.White;
            this.Btn_Stok.CheckedState.Parent = this.Btn_Stok;
            this.Btn_Stok.CustomImages.Parent = this.Btn_Stok;
            this.Btn_Stok.FillColor = System.Drawing.Color.Orange;
            this.Btn_Stok.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_Stok.ForeColor = System.Drawing.Color.Black;
            this.Btn_Stok.HoverState.Parent = this.Btn_Stok;
            this.Btn_Stok.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Stok.Image")));
            this.Btn_Stok.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Btn_Stok.ImageSize = new System.Drawing.Size(50, 50);
            this.Btn_Stok.Location = new System.Drawing.Point(3, 299);
            this.Btn_Stok.Name = "Btn_Stok";
            this.Btn_Stok.ShadowDecoration.Parent = this.Btn_Stok;
            this.Btn_Stok.Size = new System.Drawing.Size(357, 71);
            this.Btn_Stok.TabIndex = 2;
            this.Btn_Stok.Text = "STOK";
            this.Btn_Stok.Click += new System.EventHandler(this.Btn_Stok_Click);
            // 
            // btn_Satis
            // 
            this.btn_Satis.BorderRadius = 35;
            this.btn_Satis.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_Satis.CheckedState.FillColor = System.Drawing.Color.White;
            this.btn_Satis.CheckedState.Parent = this.btn_Satis;
            this.btn_Satis.CustomImages.Parent = this.btn_Satis;
            this.btn_Satis.FillColor = System.Drawing.Color.Orange;
            this.btn_Satis.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Satis.ForeColor = System.Drawing.Color.Black;
            this.btn_Satis.HoverState.Parent = this.btn_Satis;
            this.btn_Satis.Image = ((System.Drawing.Image)(resources.GetObject("btn_Satis.Image")));
            this.btn_Satis.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_Satis.ImageSize = new System.Drawing.Size(50, 50);
            this.btn_Satis.Location = new System.Drawing.Point(0, 213);
            this.btn_Satis.Name = "btn_Satis";
            this.btn_Satis.ShadowDecoration.Parent = this.btn_Satis;
            this.btn_Satis.Size = new System.Drawing.Size(354, 71);
            this.btn_Satis.TabIndex = 1;
            this.btn_Satis.Text = "MÜŞTERİLER";
            this.btn_Satis.Click += new System.EventHandler(this.btn_Satis_Click);
            // 
            // Btn_UrunEkle
            // 
            this.Btn_UrunEkle.BorderRadius = 35;
            this.Btn_UrunEkle.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.Btn_UrunEkle.CheckedState.FillColor = System.Drawing.Color.White;
            this.Btn_UrunEkle.CheckedState.Parent = this.Btn_UrunEkle;
            this.Btn_UrunEkle.CustomImages.Parent = this.Btn_UrunEkle;
            this.Btn_UrunEkle.FillColor = System.Drawing.Color.Orange;
            this.Btn_UrunEkle.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_UrunEkle.ForeColor = System.Drawing.Color.Black;
            this.Btn_UrunEkle.HoverState.Parent = this.Btn_UrunEkle;
            this.Btn_UrunEkle.Image = ((System.Drawing.Image)(resources.GetObject("Btn_UrunEkle.Image")));
            this.Btn_UrunEkle.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Btn_UrunEkle.ImageSize = new System.Drawing.Size(50, 50);
            this.Btn_UrunEkle.Location = new System.Drawing.Point(-3, 119);
            this.Btn_UrunEkle.Name = "Btn_UrunEkle";
            this.Btn_UrunEkle.ShadowDecoration.Parent = this.Btn_UrunEkle;
            this.Btn_UrunEkle.Size = new System.Drawing.Size(357, 71);
            this.Btn_UrunEkle.TabIndex = 0;
            this.Btn_UrunEkle.Text = "ÜRÜN EKLE";
            this.Btn_UrunEkle.Click += new System.EventHandler(this.Btn_UrunEkle_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.uC_Login1);
            this.panel2.Controls.Add(this.uC_Stok1);
            this.panel2.Controls.Add(this.uC_Satis1);
            this.panel2.Controls.Add(this.uC_YeniUrunEkle1);
            this.panel2.Controls.Add(this.uC_UrunSil1);
            this.panel2.Controls.Add(this.uC_MüsteriKayitlari1);
            this.panel2.Location = new System.Drawing.Point(371, 40);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(903, 742);
            this.panel2.TabIndex = 2;
            // 
            // uC_UrunSil1
            // 
            this.uC_UrunSil1.BackColor = System.Drawing.Color.White;
            this.uC_UrunSil1.Location = new System.Drawing.Point(-1, 0);
            this.uC_UrunSil1.Margin = new System.Windows.Forms.Padding(4);
            this.uC_UrunSil1.Name = "uC_UrunSil1";
            this.uC_UrunSil1.Size = new System.Drawing.Size(1282, 781);
            this.uC_UrunSil1.TabIndex = 4;
            // 
            // uC_MüsteriKayitlari1
            // 
            this.uC_MüsteriKayitlari1.BackColor = System.Drawing.Color.White;
            this.uC_MüsteriKayitlari1.Location = new System.Drawing.Point(-1, 0);
            this.uC_MüsteriKayitlari1.Margin = new System.Windows.Forms.Padding(4);
            this.uC_MüsteriKayitlari1.Name = "uC_MüsteriKayitlari1";
            this.uC_MüsteriKayitlari1.Size = new System.Drawing.Size(1282, 781);
            this.uC_MüsteriKayitlari1.TabIndex = 3;
            // 
            // uC_Stok1
            // 
            this.uC_Stok1.BackColor = System.Drawing.Color.White;
            this.uC_Stok1.Location = new System.Drawing.Point(-1, 0);
            this.uC_Stok1.Margin = new System.Windows.Forms.Padding(4);
            this.uC_Stok1.Name = "uC_Stok1";
            this.uC_Stok1.Size = new System.Drawing.Size(1282, 781);
            this.uC_Stok1.TabIndex = 2;
            // 
            // uC_Satis1
            // 
            this.uC_Satis1.BackColor = System.Drawing.Color.White;
            this.uC_Satis1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.uC_Satis1.Location = new System.Drawing.Point(0, 0);
            this.uC_Satis1.Margin = new System.Windows.Forms.Padding(4);
            this.uC_Satis1.Name = "uC_Satis1";
            this.uC_Satis1.Size = new System.Drawing.Size(1282, 781);
            this.uC_Satis1.TabIndex = 1;
            // 
            // uC_YeniUrunEkle1
            // 
            this.uC_YeniUrunEkle1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.uC_YeniUrunEkle1.BackColor = System.Drawing.Color.White;
            this.uC_YeniUrunEkle1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.uC_YeniUrunEkle1.Location = new System.Drawing.Point(0, 0);
            this.uC_YeniUrunEkle1.Margin = new System.Windows.Forms.Padding(4);
            this.uC_YeniUrunEkle1.Name = "uC_YeniUrunEkle1";
            this.uC_YeniUrunEkle1.Size = new System.Drawing.Size(1347, 912);
            this.uC_YeniUrunEkle1.TabIndex = 0;
            // 
            // Btn_Cikis
            // 
            this.Btn_Cikis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Cikis.BackColor = System.Drawing.Color.Transparent;
            this.Btn_Cikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Cikis.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Cikis.Image")));
            this.Btn_Cikis.Location = new System.Drawing.Point(1242, 1);
            this.Btn_Cikis.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_Cikis.Name = "Btn_Cikis";
            this.Btn_Cikis.Size = new System.Drawing.Size(27, 31);
            this.Btn_Cikis.TabIndex = 3;
            this.Btn_Cikis.UseVisualStyleBackColor = false;
            this.Btn_Cikis.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Kucult
            // 
            this.btn_Kucult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Kucult.BackColor = System.Drawing.Color.Transparent;
            this.btn_Kucult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Kucult.Image = ((System.Drawing.Image)(resources.GetObject("btn_Kucult.Image")));
            this.btn_Kucult.Location = new System.Drawing.Point(1207, 1);
            this.btn_Kucult.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Kucult.Name = "btn_Kucult";
            this.btn_Kucult.Size = new System.Drawing.Size(27, 31);
            this.btn_Kucult.TabIndex = 4;
            this.btn_Kucult.UseVisualStyleBackColor = false;
            this.btn_Kucult.Click += new System.EventHandler(this.btn_Kucult_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 30;
            this.guna2Elipse2.TargetControl = this;
            // 
            // guna2Elipse4
            // 
            this.guna2Elipse4.BorderRadius = 30;
            this.guna2Elipse4.TargetControl = this;
            // 
            // guna2Elipse5
            // 
            this.guna2Elipse5.BorderRadius = 30;
            this.guna2Elipse5.TargetControl = this;
            // 
            // guna2Elipse7
            // 
            this.guna2Elipse7.BorderRadius = 30;
            this.guna2Elipse7.TargetControl = this.panel2;
            // 
            // guna2Elipse8
            // 
            this.guna2Elipse8.BorderRadius = 26;
            this.guna2Elipse8.TargetControl = this.panel2;
            // 
            // uC_Login1
            // 
            this.uC_Login1.BackColor = System.Drawing.Color.Orange;
            this.uC_Login1.Location = new System.Drawing.Point(-1, 0);
            this.uC_Login1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.uC_Login1.Name = "uC_Login1";
            this.uC_Login1.Size = new System.Drawing.Size(1241, 663);
            this.uC_Login1.TabIndex = 5;
            this.uC_Login1.VisibleChanged += new System.EventHandler(this.uC_Login1_VisibleChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Orange;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1282, 781);
            this.Controls.Add(this.btn_Kucult);
            this.Controls.Add(this.Btn_Cikis);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Btn_Cikis;
        private Guna.UI2.WinForms.Guna2Button Btn_UrunEkle;
        private Guna.UI2.WinForms.Guna2Button btn_Satis;
        private Guna.UI2.WinForms.Guna2Button btn_UrunSil;
        private Guna.UI2.WinForms.Guna2Button Btn_Musteriler;
        private Guna.UI2.WinForms.Guna2Button Btn_Stok;
        private System.Windows.Forms.Button btn_Kucult;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private KullaniciYetki.UC_YeniUrunEkle uC_YeniUrunEkle1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private KullaniciYetki.UC_Satis uC_Satis1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse4;
        private KullaniciYetki.UC_Stok uC_Stok1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse5;
        private KullaniciYetki.UC_MüsteriKayitlari uC_MüsteriKayitlari1;
        private Guna.UI2.WinForms.Guna2Button btn_İptal;
        private Guna.UI2.WinForms.Guna2Button btn_Onayla;
        private Guna.UI2.WinForms.Guna2TextBox txt_Sifre;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse7;
        private KullaniciYetki.UC_UrunSil uC_UrunSil1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse8;
        private KullaniciYetki.UC_Login uC_Login1;
    }
}

