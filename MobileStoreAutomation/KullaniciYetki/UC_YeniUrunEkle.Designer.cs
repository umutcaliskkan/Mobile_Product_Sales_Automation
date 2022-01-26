
namespace MobileStoreAutomation.KullaniciYetki
{
    partial class UC_YeniUrunEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_YeniUrunEkle));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Marka = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_Model = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_Depo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_GenisletHafiza = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_EkranBoyut = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cb_ArkaKamera = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cb_OnKamera = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cb_Parmak = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cb_Sim = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cb_AgTip = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_Stok = new Guna.UI2.WinForms.Guna2TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_Fiyat = new Guna.UI2.WinForms.Guna2TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btn_Ekle = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Sifirla = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.cb_Ram = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(125, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yeni Ürün Ekle";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(31, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(47, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Marka :";
            // 
            // txt_Marka
            // 
            this.txt_Marka.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Marka.DefaultText = "";
            this.txt_Marka.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Marka.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Marka.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Marka.DisabledState.Parent = this.txt_Marka;
            this.txt_Marka.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Marka.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Marka.FocusedState.Parent = this.txt_Marka;
            this.txt_Marka.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.txt_Marka.ForeColor = System.Drawing.Color.Black;
            this.txt_Marka.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Marka.HoverState.Parent = this.txt_Marka;
            this.txt_Marka.Location = new System.Drawing.Point(206, 173);
            this.txt_Marka.Margin = new System.Windows.Forms.Padding(5);
            this.txt_Marka.Name = "txt_Marka";
            this.txt_Marka.PasswordChar = '\0';
            this.txt_Marka.PlaceholderText = "";
            this.txt_Marka.SelectedText = "";
            this.txt_Marka.ShadowDecoration.Parent = this.txt_Marka;
            this.txt_Marka.Size = new System.Drawing.Size(322, 38);
            this.txt_Marka.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_Marka.TabIndex = 3;
            // 
            // txt_Model
            // 
            this.txt_Model.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Model.DefaultText = "";
            this.txt_Model.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Model.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Model.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Model.DisabledState.Parent = this.txt_Model;
            this.txt_Model.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Model.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Model.FocusedState.Parent = this.txt_Model;
            this.txt_Model.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.txt_Model.ForeColor = System.Drawing.Color.Black;
            this.txt_Model.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Model.HoverState.Parent = this.txt_Model;
            this.txt_Model.Location = new System.Drawing.Point(205, 236);
            this.txt_Model.Margin = new System.Windows.Forms.Padding(5);
            this.txt_Model.Name = "txt_Model";
            this.txt_Model.PasswordChar = '\0';
            this.txt_Model.PlaceholderText = "";
            this.txt_Model.SelectedText = "";
            this.txt_Model.ShadowDecoration.Parent = this.txt_Model;
            this.txt_Model.Size = new System.Drawing.Size(323, 38);
            this.txt_Model.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_Model.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(26, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "Model Adı :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(56, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 30);
            this.label4.TabIndex = 6;
            this.label4.Text = "RAM:";
            // 
            // cb_Depo
            // 
            this.cb_Depo.BackColor = System.Drawing.Color.Transparent;
            this.cb_Depo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_Depo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Depo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_Depo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_Depo.FocusedState.Parent = this.cb_Depo;
            this.cb_Depo.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.cb_Depo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cb_Depo.HoverState.Parent = this.cb_Depo;
            this.cb_Depo.ItemHeight = 30;
            this.cb_Depo.Items.AddRange(new object[] {
            "4 GB",
            "8 GB",
            "16 GB",
            "32 GB",
            "64 GB",
            "128 GB"});
            this.cb_Depo.ItemsAppearance.Parent = this.cb_Depo;
            this.cb_Depo.Location = new System.Drawing.Point(252, 364);
            this.cb_Depo.Name = "cb_Depo";
            this.cb_Depo.ShadowDecoration.Parent = this.cb_Depo;
            this.cb_Depo.Size = new System.Drawing.Size(276, 36);
            this.cb_Depo.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cb_Depo.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(3, 370);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(229, 30);
            this.label5.TabIndex = 8;
            this.label5.Text = "Dahili Depolama :";
            // 
            // cb_GenisletHafiza
            // 
            this.cb_GenisletHafiza.BackColor = System.Drawing.Color.Transparent;
            this.cb_GenisletHafiza.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_GenisletHafiza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_GenisletHafiza.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_GenisletHafiza.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_GenisletHafiza.FocusedState.Parent = this.cb_GenisletHafiza;
            this.cb_GenisletHafiza.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.cb_GenisletHafiza.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cb_GenisletHafiza.HoverState.Parent = this.cb_GenisletHafiza;
            this.cb_GenisletHafiza.ItemHeight = 30;
            this.cb_GenisletHafiza.Items.AddRange(new object[] {
            "16 GB",
            "32 GB",
            "64 GB",
            "128 GB",
            "256 GB"});
            this.cb_GenisletHafiza.ItemsAppearance.Parent = this.cb_GenisletHafiza;
            this.cb_GenisletHafiza.Location = new System.Drawing.Point(298, 427);
            this.cb_GenisletHafiza.Name = "cb_GenisletHafiza";
            this.cb_GenisletHafiza.ShadowDecoration.Parent = this.cb_GenisletHafiza;
            this.cb_GenisletHafiza.Size = new System.Drawing.Size(230, 36);
            this.cb_GenisletHafiza.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cb_GenisletHafiza.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(3, 433);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(273, 30);
            this.label6.TabIndex = 10;
            this.label6.Text = "Genişletilebilir Hafıza :";
            // 
            // cb_EkranBoyut
            // 
            this.cb_EkranBoyut.BackColor = System.Drawing.Color.Transparent;
            this.cb_EkranBoyut.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_EkranBoyut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_EkranBoyut.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_EkranBoyut.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_EkranBoyut.FocusedState.Parent = this.cb_EkranBoyut;
            this.cb_EkranBoyut.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.cb_EkranBoyut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cb_EkranBoyut.HoverState.Parent = this.cb_EkranBoyut;
            this.cb_EkranBoyut.ItemHeight = 30;
            this.cb_EkranBoyut.Items.AddRange(new object[] {
            "5.0 inç",
            "5.1 inç",
            "5.2 inç",
            "5.3 inç",
            "5.4 inç",
            "5.5 inç",
            "5.6 inç",
            "5.7 inç",
            "5.8 inç",
            "5.9 inç",
            "6.0 inç"});
            this.cb_EkranBoyut.ItemsAppearance.Parent = this.cb_EkranBoyut;
            this.cb_EkranBoyut.Location = new System.Drawing.Point(232, 483);
            this.cb_EkranBoyut.Name = "cb_EkranBoyut";
            this.cb_EkranBoyut.ShadowDecoration.Parent = this.cb_EkranBoyut;
            this.cb_EkranBoyut.Size = new System.Drawing.Size(296, 36);
            this.cb_EkranBoyut.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cb_EkranBoyut.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(48, 489);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(178, 30);
            this.label7.TabIndex = 12;
            this.label7.Text = "Ekran Boyutu :";
            // 
            // cb_ArkaKamera
            // 
            this.cb_ArkaKamera.BackColor = System.Drawing.Color.Transparent;
            this.cb_ArkaKamera.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_ArkaKamera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_ArkaKamera.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_ArkaKamera.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_ArkaKamera.FocusedState.Parent = this.cb_ArkaKamera;
            this.cb_ArkaKamera.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.cb_ArkaKamera.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cb_ArkaKamera.HoverState.Parent = this.cb_ArkaKamera;
            this.cb_ArkaKamera.ItemHeight = 30;
            this.cb_ArkaKamera.Items.AddRange(new object[] {
            "5 MP",
            "8 MP",
            "10 MP",
            "15 MP",
            "20 MP",
            "25 MP",
            "30 MP",
            "40 MP"});
            this.cb_ArkaKamera.ItemsAppearance.Parent = this.cb_ArkaKamera;
            this.cb_ArkaKamera.Location = new System.Drawing.Point(822, 175);
            this.cb_ArkaKamera.Name = "cb_ArkaKamera";
            this.cb_ArkaKamera.ShadowDecoration.Parent = this.cb_ArkaKamera;
            this.cb_ArkaKamera.Size = new System.Drawing.Size(323, 36);
            this.cb_ArkaKamera.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cb_ArkaKamera.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(625, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(179, 30);
            this.label8.TabIndex = 14;
            this.label8.Text = "Arka Kamera :";
            // 
            // cb_OnKamera
            // 
            this.cb_OnKamera.BackColor = System.Drawing.Color.Transparent;
            this.cb_OnKamera.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_OnKamera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_OnKamera.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_OnKamera.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_OnKamera.FocusedState.Parent = this.cb_OnKamera;
            this.cb_OnKamera.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.cb_OnKamera.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cb_OnKamera.HoverState.Parent = this.cb_OnKamera;
            this.cb_OnKamera.ItemHeight = 30;
            this.cb_OnKamera.Items.AddRange(new object[] {
            "5 MP",
            "8 MP",
            "10 MP",
            "15 MP",
            "20 MP",
            "25 MP",
            "30 MP",
            "40 MP"});
            this.cb_OnKamera.ItemsAppearance.Parent = this.cb_OnKamera;
            this.cb_OnKamera.Location = new System.Drawing.Point(822, 236);
            this.cb_OnKamera.Name = "cb_OnKamera";
            this.cb_OnKamera.ShadowDecoration.Parent = this.cb_OnKamera;
            this.cb_OnKamera.Size = new System.Drawing.Size(323, 36);
            this.cb_OnKamera.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cb_OnKamera.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(625, 244);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(163, 30);
            this.label9.TabIndex = 16;
            this.label9.Text = "Ön Kamera :";
            // 
            // cb_Parmak
            // 
            this.cb_Parmak.BackColor = System.Drawing.Color.Transparent;
            this.cb_Parmak.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_Parmak.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Parmak.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_Parmak.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_Parmak.FocusedState.Parent = this.cb_Parmak;
            this.cb_Parmak.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.cb_Parmak.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cb_Parmak.HoverState.Parent = this.cb_Parmak;
            this.cb_Parmak.ItemHeight = 30;
            this.cb_Parmak.Items.AddRange(new object[] {
            "Evet",
            "Hayır"});
            this.cb_Parmak.ItemsAppearance.Parent = this.cb_Parmak;
            this.cb_Parmak.Location = new System.Drawing.Point(822, 301);
            this.cb_Parmak.Name = "cb_Parmak";
            this.cb_Parmak.ShadowDecoration.Parent = this.cb_Parmak;
            this.cb_Parmak.Size = new System.Drawing.Size(323, 36);
            this.cb_Parmak.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cb_Parmak.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(625, 307);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(145, 30);
            this.label10.TabIndex = 18;
            this.label10.Text = "Parmak İzi :";
            // 
            // cb_Sim
            // 
            this.cb_Sim.BackColor = System.Drawing.Color.Transparent;
            this.cb_Sim.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_Sim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Sim.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_Sim.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_Sim.FocusedState.Parent = this.cb_Sim;
            this.cb_Sim.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.cb_Sim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cb_Sim.HoverState.Parent = this.cb_Sim;
            this.cb_Sim.ItemHeight = 30;
            this.cb_Sim.Items.AddRange(new object[] {
            "Tek Sim",
            "Çift Sim",
            "Üçlü Sim"});
            this.cb_Sim.ItemsAppearance.Parent = this.cb_Sim;
            this.cb_Sim.Location = new System.Drawing.Point(822, 364);
            this.cb_Sim.Name = "cb_Sim";
            this.cb_Sim.ShadowDecoration.Parent = this.cb_Sim;
            this.cb_Sim.Size = new System.Drawing.Size(323, 36);
            this.cb_Sim.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cb_Sim.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(625, 370);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 30);
            this.label11.TabIndex = 20;
            this.label11.Text = "Sim Tipi :";
            // 
            // cb_AgTip
            // 
            this.cb_AgTip.BackColor = System.Drawing.Color.Transparent;
            this.cb_AgTip.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_AgTip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_AgTip.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_AgTip.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_AgTip.FocusedState.Parent = this.cb_AgTip;
            this.cb_AgTip.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.cb_AgTip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cb_AgTip.HoverState.Parent = this.cb_AgTip;
            this.cb_AgTip.ItemHeight = 30;
            this.cb_AgTip.Items.AddRange(new object[] {
            "2G",
            "2G,3G",
            "2G,3G & 4.5G"});
            this.cb_AgTip.ItemsAppearance.Parent = this.cb_AgTip;
            this.cb_AgTip.Location = new System.Drawing.Point(822, 427);
            this.cb_AgTip.Name = "cb_AgTip";
            this.cb_AgTip.ShadowDecoration.Parent = this.cb_AgTip;
            this.cb_AgTip.Size = new System.Drawing.Size(323, 36);
            this.cb_AgTip.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cb_AgTip.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(625, 433);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 30);
            this.label12.TabIndex = 22;
            this.label12.Text = "Ağ Tipi :";
            // 
            // txt_Stok
            // 
            this.txt_Stok.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Stok.DefaultText = "";
            this.txt_Stok.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Stok.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Stok.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Stok.DisabledState.Parent = this.txt_Stok;
            this.txt_Stok.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Stok.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Stok.FocusedState.Parent = this.txt_Stok;
            this.txt_Stok.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Stok.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Stok.HoverState.Parent = this.txt_Stok;
            this.txt_Stok.Location = new System.Drawing.Point(823, 481);
            this.txt_Stok.Margin = new System.Windows.Forms.Padding(5);
            this.txt_Stok.Name = "txt_Stok";
            this.txt_Stok.PasswordChar = '\0';
            this.txt_Stok.PlaceholderText = "";
            this.txt_Stok.SelectedText = "";
            this.txt_Stok.ShadowDecoration.Parent = this.txt_Stok;
            this.txt_Stok.Size = new System.Drawing.Size(322, 38);
            this.txt_Stok.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_Stok.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(639, 489);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 30);
            this.label13.TabIndex = 24;
            this.label13.Text = "Stok :";
            // 
            // txt_Fiyat
            // 
            this.txt_Fiyat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Fiyat.DefaultText = "";
            this.txt_Fiyat.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Fiyat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Fiyat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Fiyat.DisabledState.Parent = this.txt_Fiyat;
            this.txt_Fiyat.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Fiyat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Fiyat.FocusedState.Parent = this.txt_Fiyat;
            this.txt_Fiyat.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_Fiyat.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Fiyat.HoverState.Parent = this.txt_Fiyat;
            this.txt_Fiyat.Location = new System.Drawing.Point(823, 581);
            this.txt_Fiyat.Margin = new System.Windows.Forms.Padding(5);
            this.txt_Fiyat.Name = "txt_Fiyat";
            this.txt_Fiyat.PasswordChar = '\0';
            this.txt_Fiyat.PlaceholderText = "";
            this.txt_Fiyat.SelectedText = "";
            this.txt_Fiyat.ShadowDecoration.Parent = this.txt_Fiyat;
            this.txt_Fiyat.Size = new System.Drawing.Size(322, 38);
            this.txt_Fiyat.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_Fiyat.TabIndex = 27;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(649, 589);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 30);
            this.label14.TabIndex = 26;
            this.label14.Text = "Fiyat :";
            // 
            // btn_Ekle
            // 
            this.btn_Ekle.BorderRadius = 30;
            this.btn_Ekle.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_Ekle.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.btn_Ekle.CheckedState.Parent = this.btn_Ekle;
            this.btn_Ekle.CustomImages.Parent = this.btn_Ekle;
            this.btn_Ekle.FillColor = System.Drawing.Color.Orange;
            this.btn_Ekle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Ekle.ForeColor = System.Drawing.Color.Black;
            this.btn_Ekle.HoverState.Parent = this.btn_Ekle;
            this.btn_Ekle.Image = ((System.Drawing.Image)(resources.GetObject("btn_Ekle.Image")));
            this.btn_Ekle.ImageSize = new System.Drawing.Size(40, 40);
            this.btn_Ekle.Location = new System.Drawing.Point(780, 677);
            this.btn_Ekle.Name = "btn_Ekle";
            this.btn_Ekle.ShadowDecoration.Parent = this.btn_Ekle;
            this.btn_Ekle.Size = new System.Drawing.Size(180, 45);
            this.btn_Ekle.TabIndex = 28;
            this.btn_Ekle.Text = "EKLE";
            this.btn_Ekle.Click += new System.EventHandler(this.btn_Ekle_Click);
            // 
            // btn_Sifirla
            // 
            this.btn_Sifirla.BorderRadius = 30;
            this.btn_Sifirla.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_Sifirla.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.btn_Sifirla.CheckedState.Parent = this.btn_Sifirla;
            this.btn_Sifirla.CustomImages.Parent = this.btn_Sifirla;
            this.btn_Sifirla.FillColor = System.Drawing.Color.Orange;
            this.btn_Sifirla.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Sifirla.ForeColor = System.Drawing.Color.Black;
            this.btn_Sifirla.HoverState.Parent = this.btn_Sifirla;
            this.btn_Sifirla.Image = ((System.Drawing.Image)(resources.GetObject("btn_Sifirla.Image")));
            this.btn_Sifirla.ImageSize = new System.Drawing.Size(40, 40);
            this.btn_Sifirla.Location = new System.Drawing.Point(988, 677);
            this.btn_Sifirla.Name = "btn_Sifirla";
            this.btn_Sifirla.ShadowDecoration.Parent = this.btn_Sifirla;
            this.btn_Sifirla.Size = new System.Drawing.Size(180, 45);
            this.btn_Sifirla.TabIndex = 29;
            this.btn_Sifirla.Text = "SIFIRLA";
            this.btn_Sifirla.Click += new System.EventHandler(this.btn_Sifirla_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // cb_Ram
            // 
            this.cb_Ram.BackColor = System.Drawing.Color.Transparent;
            this.cb_Ram.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_Ram.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Ram.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_Ram.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_Ram.FocusedState.Parent = this.cb_Ram;
            this.cb_Ram.Font = new System.Drawing.Font("Century Gothic", 13.8F);
            this.cb_Ram.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cb_Ram.HoverState.Parent = this.cb_Ram;
            this.cb_Ram.ItemHeight = 30;
            this.cb_Ram.Items.AddRange(new object[] {
            "1 GB",
            "2 GB",
            "3 GB",
            "4 GB",
            "8 GB",
            "16 GB"});
            this.cb_Ram.ItemsAppearance.Parent = this.cb_Ram;
            this.cb_Ram.Location = new System.Drawing.Point(206, 301);
            this.cb_Ram.Name = "cb_Ram";
            this.cb_Ram.ShadowDecoration.Parent = this.cb_Ram;
            this.cb_Ram.Size = new System.Drawing.Size(322, 36);
            this.cb_Ram.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cb_Ram.TabIndex = 30;
            // 
            // UC_YeniUrunEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.cb_Ram);
            this.Controls.Add(this.btn_Sifirla);
            this.Controls.Add(this.btn_Ekle);
            this.Controls.Add(this.txt_Fiyat);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txt_Stok);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cb_AgTip);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cb_Sim);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cb_Parmak);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cb_OnKamera);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cb_ArkaKamera);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cb_EkranBoyut);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cb_GenisletHafiza);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cb_Depo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Model);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Marka);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_YeniUrunEkle";
            this.Size = new System.Drawing.Size(1282, 781);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txt_Marka;
        private Guna.UI2.WinForms.Guna2TextBox txt_Model;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ComboBox cb_Depo;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2ComboBox cb_GenisletHafiza;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2ComboBox cb_EkranBoyut;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2ComboBox cb_ArkaKamera;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2ComboBox cb_OnKamera;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2ComboBox cb_Parmak;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2ComboBox cb_Sim;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2ComboBox cb_AgTip;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2TextBox txt_Stok;
        private System.Windows.Forms.Label label13;
        private Guna.UI2.WinForms.Guna2TextBox txt_Fiyat;
        private System.Windows.Forms.Label label14;
        private Guna.UI2.WinForms.Guna2Button btn_Ekle;
        private Guna.UI2.WinForms.Guna2Button btn_Sifirla;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2ComboBox cb_Ram;
    }
}
