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
    public partial class UC_Satis : UserControl
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-BCV2AJ1;Initial Catalog=MobilMagazaOtomasyon;Integrated Security=True");
        public UC_Satis()
        {
            InitializeComponent();

            ComboBoxAyarla();

        }

        public void ComboBoxAyarla() // markaları getirme
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT distinct MarkaAd FROM YeniTelefon",baglanti);
            
            SqlDataReader dr = komut.ExecuteReader();

            while (dr.Read())
            {
                for (int i = 0; i < dr.FieldCount; i++) // okuma işlemi yapılıyor 
                {
                    cb_Marka.Items.Add(dr.GetString(i)); // combobox a veriler ekleniyor
                }
            }
            baglanti.Close();
        }

        private void UC_Satis_Enter(object sender, EventArgs e)
        {

            

        }

        private void cb_Marka_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Marka seçildiğinde seçilen markanın modelini getirme işlemleri
            cb_Model.Items.Clear();
            String MarkaAd = cb_Marka.Text;
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("SELECT ModelAd FROM YeniTelefon WHERE MarkaAd='"+MarkaAd+"'", baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();

            while (dr2.Read())
            {
                for (int i=0; i < dr2.FieldCount; i++)
                {
                    cb_Model.Items.Add(dr2.GetString(i));
                }
            }
            baglanti.Close();
        }

        private void cb_Model_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Model seçildiğinde seçilen modelin bilgilerini getirme işlemi
            
          
            SqlCommand komut3 = new SqlCommand("SELECT * FROM YeniTelefon where ModelAd= '" +cb_Model.Text+ "'", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut3);
            DataSet ds = new DataSet();
            da.Fill(ds);

            lbl_Ram.Text = ds.Tables[0].Rows[0][3].ToString();
            lbl_Depolama.Text = ds.Tables[0].Rows[0][4].ToString();
            lbl_MaksDepo.Text = ds.Tables[0].Rows[0][5].ToString();
            lbl_ArkaKamera.Text = ds.Tables[0].Rows[0][7].ToString();
            lbl_OnKamera.Text = ds.Tables[0].Rows[0][8].ToString();
            lbl_Parmak.Text = ds.Tables[0].Rows[0][9].ToString();
            lbl_Fiyat.Text = ds.Tables[0].Rows[0][12].ToString();



        }

        private void Btn_SatinAl_Click(object sender, EventArgs e)
        {
            if(txt_MusteriAd.Text !="" 
                && cb_MusteriCins.Text !=""
                && msk_MusteriNum.Text !=""
                && txt_MusteriMail.Text !=""
                && txt_MusteriAdres.Text !=""
                && cb_Marka.Text !=""
                && cb_Model.Text !=""
                && msk_imei.Text !=""
                )
            {
                baglanti.Open();
                SqlCommand komut4 = new SqlCommand("insert into MusteriSatis(MusteriAd,Cinsiyet,Numara,Mail,Adres,MarkaAd,ModelAd,imei) " +
                    "values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", baglanti);
                komut4.Parameters.AddWithValue("@p1", txt_MusteriAd.Text);
                komut4.Parameters.AddWithValue("@p2", cb_MusteriCins.Text);
                komut4.Parameters.AddWithValue("@p3", msk_MusteriNum.Text);
                komut4.Parameters.AddWithValue("@p4", txt_MusteriMail.Text);
                komut4.Parameters.AddWithValue("@p5", txt_MusteriAdres.Text);
                komut4.Parameters.AddWithValue("@p6", cb_Marka.Text);
                komut4.Parameters.AddWithValue("@p7", cb_Model.Text);
                komut4.Parameters.AddWithValue("@p8", msk_imei.Text);
                komut4.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Satış İşlemi Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information); // 2:50:55

                txt_MusteriAd.Clear();
                cb_MusteriCins.SelectedIndex = -1;
                msk_MusteriNum.Clear();
                txt_MusteriMail.Clear();
                txt_MusteriAdres.Clear();
                msk_imei.Clear();
            }
            else{
                MessageBox.Show("Bütün alanları doldurun.", "Hata",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            } 
            
        }
    }
}
