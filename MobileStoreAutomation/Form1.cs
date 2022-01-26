using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileStoreAutomation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            uC_YeniUrunEkle1.Visible = false; // Baslangicta urun ekle formunu gösterme
            uC_Satis1.Visible = false; // baslangica satis sekmesini gösterme
            uC_Stok1.Visible = false; //baslangicta stok sekmesini gösterme
            uC_MüsteriKayitlari1.Visible = false; //baslangicta müsterikayitlari sekmesini gösterme
            uC_UrunSil1.Visible = false; // baslangicta ürünsil sekmesini gösterme
            panel1.Visible = false;
            
            uC_Login1.Visible = true; // baslangıca login ekranını göster

            AcKapa(false, false, false);
        }

        private void Btn_UrunEkle_Click(object sender, EventArgs e)
        {
            uC_YeniUrunEkle1.Visible = true; // UrunEkle formunu getir
            uC_YeniUrunEkle1.BringToFront(); // öne çıkar
        }

        private void btn_Kucult_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_Satis_Click(object sender, EventArgs e)
        {
            uC_Satis1.Visible = true;// Satis formunu aç
            uC_Satis1.BringToFront(); // öne çıkar
        }

        private void Btn_Stok_Click(object sender, EventArgs e)
        {
            uC_Stok1.Visible = true; //stok formunu göster
            uC_Stok1.BringToFront(); // öne çıkar
        }

        private void Btn_Musteriler_Click(object sender, EventArgs e)
        {
            uC_MüsteriKayitlari1.Visible = true; // müsteri kayit sekmesini göster
            uC_MüsteriKayitlari1.BringToFront(); // öne çıkar
        }

        public void AcKapa(Boolean TxtSifre,Boolean Btn1,Boolean Btn2) // ürün sil sekmesini açmak için fonksiyon yazıldı
        {
            txt_Sifre.Visible = TxtSifre;
            btn_Onayla.Visible = Btn1;
            btn_İptal.Visible = Btn2;

        }

        private void btn_UrunSil_Click(object sender, EventArgs e)
        {
            panel2.Enabled = false;
            AcKapa(true, true, true);
        }

        private void btn_İptal_Click(object sender, EventArgs e)
        {
            panel2.Enabled = true;
            AcKapa(false, false, false);
        }

        private void btn_Onayla_Click(object sender, EventArgs e)
        {
            if (txt_Sifre.Text == "admin")
            {
                panel2.Enabled = true;       // urun sil sekmesine giriş için şifre doğu ise formu göster ve öne getir
                uC_UrunSil1.Visible = true;
                uC_UrunSil1.BringToFront();
                AcKapa(false, false, false);//ve urun sil sekmesinin login ekranlarını kapa
                txt_Sifre.Clear();

            }
            else
            {
                txt_Sifre.Clear();
            }
        }

        private void uC_Login1_VisibleChanged(object sender, EventArgs e)
        {
            panel1.Visible = true;
            Btn_UrunEkle.PerformClick();
        }
    }
}
