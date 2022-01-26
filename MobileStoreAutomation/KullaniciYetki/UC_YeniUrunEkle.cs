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
    
    public partial class UC_YeniUrunEkle : UserControl
       
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-BCV2AJ1;Initial Catalog=MobilMagazaOtomasyon;Integrated Security=True");
        public UC_YeniUrunEkle()
        {
            InitializeComponent();
        }

        private void btn_Ekle_Click(object sender, EventArgs e)
        {
            if (txt_Marka.Text != ""
                && txt_Model.Text != ""
                && cb_Ram.Text != ""
                && cb_Depo.Text != ""
                && cb_GenisletHafiza.Text != ""
                && cb_EkranBoyut.Text != ""
                && cb_ArkaKamera.Text != ""
                && cb_OnKamera.Text != ""
                && cb_Parmak.Text != ""
                && cb_Sim.Text != ""
                && cb_AgTip.Text != ""
                && txt_Stok.Text != ""
                && txt_Fiyat.Text != "")
            {
                baglanti.Open();
                string sorgu = "insert into YeniTelefon(MarkaAd,ModelAd,Ram,Hafiza,MaksDepo,Ekran,ArkaKamera,OnKamera,Parmak,Sim,Ag,Stok,Fiyat)" +
                    " values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13)";

                SqlCommand komut = new SqlCommand(sorgu, baglanti);

                komut.Parameters.AddWithValue("@p1", txt_Marka.Text);
                komut.Parameters.AddWithValue("@p2", txt_Model.Text);
                komut.Parameters.AddWithValue("@p3", cb_Ram.Text);
                komut.Parameters.AddWithValue("@p4", cb_Depo.Text);
                komut.Parameters.AddWithValue("@p5", cb_GenisletHafiza.Text);
                komut.Parameters.AddWithValue("@p6", cb_EkranBoyut.Text);
                komut.Parameters.AddWithValue("@p7", cb_ArkaKamera.Text);
                komut.Parameters.AddWithValue("@p8", cb_OnKamera.Text);
                komut.Parameters.AddWithValue("@p9", cb_Parmak.Text);
                komut.Parameters.AddWithValue("@p10", cb_Sim.Text);
                komut.Parameters.AddWithValue("@p11", cb_AgTip.Text);
                komut.Parameters.AddWithValue("@p12", txt_Stok.Text);
                komut.Parameters.AddWithValue("@p13", txt_Fiyat.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Ürün Ekleme BAŞARILI");
            }

            else
            {
                MessageBox.Show("Lütfen Tüm Alanları Doldurun", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            


        }

        private void btn_Sifirla_Click(object sender, EventArgs e)
        {
            txt_Marka.Clear();
            txt_Model.Clear();
            cb_Ram.StartIndex = -1;
            cb_Depo.StartIndex = -1;
            cb_GenisletHafiza.StartIndex = -1;
            cb_EkranBoyut.StartIndex = -1;
            cb_ArkaKamera.StartIndex = -1;
            cb_OnKamera.StartIndex = -1;
            cb_Parmak.StartIndex = -1;
            cb_Sim.StartIndex = -1;
            cb_AgTip.StartIndex = -1;
            txt_Stok.Clear();
            txt_Fiyat.Clear();
        }
    }
}
