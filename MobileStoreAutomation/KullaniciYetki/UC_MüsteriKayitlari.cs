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

namespace MobileStoreAutomation.KullaniciYetki
{
    public partial class UC_MüsteriKayitlari : UserControl
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-BCV2AJ1;Initial Catalog=MobilMagazaOtomasyon;Integrated Security=True");
        public UC_MüsteriKayitlari()
        {
            InitializeComponent();
        }

        void MüsteriVeriGetir()
        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM MusteriSatis", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut); //veri tabanındaki müsterileri getirip adapter ile oku ve data set ile datadgridview e yerlestir
            DataSet ds = new DataSet();
            da.Fill(ds);
            guna2DataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();
        }
        private void UC_MüsteriKayitlari_Load(object sender, EventArgs e)
        {
            MüsteriVeriGetir();
        }

        Boolean secim;
        private void cb_AramaTürü_SelectedIndexChanged(object sender, EventArgs e)//Arama türüne göre labeldaki yazı değişecek ve secim değişkenine göre butonda arama yapılacak
        {
            if (cb_AramaTürü.SelectedIndex == 0)
            {
                secim = false;
                lbl_Secim.Text = "Müşteri Adı Girin";

            }
            else if (cb_AramaTürü.SelectedIndex == 1)
            {
                secim = true;
                lbl_Secim.Text = "IMEI Numarası Girin";
            }
        }

        private void btn_Arama_Click(object sender, EventArgs e)//secim degiskeninde ki degere göre arama türü yapılacak 
        {
            if (secim == false)
            {
                baglanti.Open();
                SqlCommand komut2 = new SqlCommand("SELECT * FROM MusteriSatis WHERE MusteriAd like '"+ txt_Arama.Text + "%'", baglanti);
                SqlDataAdapter da2 = new SqlDataAdapter(komut2);
                DataSet ds2 = new DataSet();
                da2.Fill(ds2);
                guna2DataGridView1.DataSource = ds2.Tables[0];
                baglanti.Close();
            }
            else
            {
                baglanti.Open();
                SqlCommand komut3 = new SqlCommand("SELECT * FROM MusteriSatis Where imei like '" + txt_Arama.Text + "%'", baglanti);
                SqlDataAdapter da3 = new SqlDataAdapter(komut3);
                DataSet ds3 = new DataSet();
                da3.Fill(ds3);
                guna2DataGridView1.DataSource = ds3.Tables[0];
                baglanti.Close();
            }
        }

        private void Btn_Sifirla_Click(object sender, EventArgs e)
        {
            MüsteriVeriGetir();
        }

        private void UC_MüsteriKayitlari_Enter(object sender, EventArgs e)
        {
            MüsteriVeriGetir();
        }
    }
}
