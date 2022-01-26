
namespace MobileStoreAutomation.KullaniciYetki
{
    partial class UC_MüsteriKayitlari
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_MüsteriKayitlari));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_Secim = new System.Windows.Forms.Label();
            this.cb_AramaTürü = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txt_Arama = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_Arama = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.Btn_Sifirla = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 50);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(83, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 45);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kullanıcı Kayıtları";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(373, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "Arama Türü";
            // 
            // lbl_Secim
            // 
            this.lbl_Secim.AutoSize = true;
            this.lbl_Secim.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Secim.Location = new System.Drawing.Point(373, 232);
            this.lbl_Secim.Name = "lbl_Secim";
            this.lbl_Secim.Size = new System.Drawing.Size(117, 28);
            this.lbl_Secim.TabIndex = 7;
            this.lbl_Secim.Text = "Müşteri Adı";
            // 
            // cb_AramaTürü
            // 
            this.cb_AramaTürü.BackColor = System.Drawing.Color.Transparent;
            this.cb_AramaTürü.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_AramaTürü.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_AramaTürü.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_AramaTürü.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_AramaTürü.FocusedState.Parent = this.cb_AramaTürü;
            this.cb_AramaTürü.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cb_AramaTürü.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cb_AramaTürü.HoverState.Parent = this.cb_AramaTürü;
            this.cb_AramaTürü.ItemHeight = 30;
            this.cb_AramaTürü.Items.AddRange(new object[] {
            "Müşteri Adı",
            "IMEI"});
            this.cb_AramaTürü.ItemsAppearance.Parent = this.cb_AramaTürü;
            this.cb_AramaTürü.Location = new System.Drawing.Point(378, 163);
            this.cb_AramaTürü.Name = "cb_AramaTürü";
            this.cb_AramaTürü.ShadowDecoration.Parent = this.cb_AramaTürü;
            this.cb_AramaTürü.Size = new System.Drawing.Size(361, 36);
            this.cb_AramaTürü.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cb_AramaTürü.TabIndex = 8;
            this.cb_AramaTürü.SelectedIndexChanged += new System.EventHandler(this.cb_AramaTürü_SelectedIndexChanged);
            // 
            // txt_Arama
            // 
            this.txt_Arama.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Arama.DefaultText = "";
            this.txt_Arama.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Arama.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Arama.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Arama.DisabledState.Parent = this.txt_Arama;
            this.txt_Arama.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Arama.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Arama.FocusedState.Parent = this.txt_Arama;
            this.txt_Arama.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Arama.HoverState.Parent = this.txt_Arama;
            this.txt_Arama.Location = new System.Drawing.Point(378, 278);
            this.txt_Arama.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Arama.Name = "txt_Arama";
            this.txt_Arama.PasswordChar = '\0';
            this.txt_Arama.PlaceholderText = "";
            this.txt_Arama.SelectedText = "";
            this.txt_Arama.ShadowDecoration.Parent = this.txt_Arama;
            this.txt_Arama.Size = new System.Drawing.Size(361, 37);
            this.txt_Arama.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txt_Arama.TabIndex = 9;
            // 
            // btn_Arama
            // 
            this.btn_Arama.CheckedState.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_Arama.CheckedState.Parent = this.btn_Arama;
            this.btn_Arama.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_Arama.HoverState.Parent = this.btn_Arama;
            this.btn_Arama.Image = ((System.Drawing.Image)(resources.GetObject("btn_Arama.Image")));
            this.btn_Arama.ImageRotate = 0F;
            this.btn_Arama.ImageSize = new System.Drawing.Size(40, 40);
            this.btn_Arama.Location = new System.Drawing.Point(758, 278);
            this.btn_Arama.Name = "btn_Arama";
            this.btn_Arama.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_Arama.PressedState.Parent = this.btn_Arama;
            this.btn_Arama.Size = new System.Drawing.Size(50, 37);
            this.btn_Arama.TabIndex = 10;
            this.btn_Arama.Click += new System.EventHandler(this.btn_Arama_Click);
            // 
            // guna2DataGridView1
            // 
            this.guna2DataGridView1.AllowUserToAddRows = false;
            this.guna2DataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.guna2DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.guna2DataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.guna2DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.guna2DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.guna2DataGridView1.EnableHeadersVisualStyles = false;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(6, 373);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.ReadOnly = true;
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.RowHeadersWidth = 51;
            this.guna2DataGridView1.RowTemplate.Height = 24;
            this.guna2DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.guna2DataGridView1.Size = new System.Drawing.Size(1169, 334);
            this.guna2DataGridView1.TabIndex = 11;
            this.guna2DataGridView1.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 4;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = true;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 24;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 26;
            this.guna2Elipse1.TargetControl = this;
            // 
            // Btn_Sifirla
            // 
            this.Btn_Sifirla.BorderRadius = 26;
            this.Btn_Sifirla.CheckedState.Parent = this.Btn_Sifirla;
            this.Btn_Sifirla.CustomImages.Parent = this.Btn_Sifirla;
            this.Btn_Sifirla.FillColor = System.Drawing.Color.Orange;
            this.Btn_Sifirla.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_Sifirla.ForeColor = System.Drawing.Color.Black;
            this.Btn_Sifirla.HoverState.Parent = this.Btn_Sifirla;
            this.Btn_Sifirla.Location = new System.Drawing.Point(883, 269);
            this.Btn_Sifirla.Name = "Btn_Sifirla";
            this.Btn_Sifirla.ShadowDecoration.Parent = this.Btn_Sifirla;
            this.Btn_Sifirla.Size = new System.Drawing.Size(143, 45);
            this.Btn_Sifirla.TabIndex = 12;
            this.Btn_Sifirla.Text = "SIFIRLA";
            this.Btn_Sifirla.Click += new System.EventHandler(this.Btn_Sifirla_Click);
            // 
            // UC_MüsteriKayitlari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.Btn_Sifirla);
            this.Controls.Add(this.guna2DataGridView1);
            this.Controls.Add(this.btn_Arama);
            this.Controls.Add(this.txt_Arama);
            this.Controls.Add(this.cb_AramaTürü);
            this.Controls.Add(this.lbl_Secim);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "UC_MüsteriKayitlari";
            this.Size = new System.Drawing.Size(1282, 781);
            this.Load += new System.EventHandler(this.UC_MüsteriKayitlari_Load);
            this.Enter += new System.EventHandler(this.UC_MüsteriKayitlari_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_Secim;
        private Guna.UI2.WinForms.Guna2ComboBox cb_AramaTürü;
        private Guna.UI2.WinForms.Guna2TextBox txt_Arama;
        private Guna.UI2.WinForms.Guna2ImageButton btn_Arama;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button Btn_Sifirla;
    }
}
