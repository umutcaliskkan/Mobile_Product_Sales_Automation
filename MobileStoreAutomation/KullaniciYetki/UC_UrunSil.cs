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
    public partial class UC_UrunSil : UserControl
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-BCV2AJ1;Initial Catalog=MobilMagazaOtomasyon;Integrated Security=True");
        public UC_UrunSil()
        {
            InitializeComponent();
        }

        void UrunListele()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM YeniTelefon", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            guna2DataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();
        }
        private void UC_UrunSil_Load(object sender, EventArgs e)
        {
            UrunListele();
        }

        private void txt_Arama_TextChanged(object sender, EventArgs e) // arama çubugu işlemleri
        {
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("SELECT * FROM YeniTelefon where MarkaAd like '" + txt_Arama.Text + "%' OR ModelAd like '"+txt_Arama.Text+"%' ", baglanti);
            SqlDataAdapter da2 = new SqlDataAdapter(komut2);
            DataSet ds2 = new DataSet();
            da2.Fill(ds2);
            guna2DataGridView1.DataSource = ds2.Tables[0];
            baglanti.Close();
        }

        int Urunid;
        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) //secilen hücreyi silme işlemleri
        {
            if(guna2DataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                Urunid = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()); // 0. sütunda secilen degeri Urunid'ye ata
            }


            if(MessageBox.Show("ID si "+Urunid+" Olan Urun Siliniyor","Uyarı",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning)==DialogResult.OK)
            {
                baglanti.Open();
                SqlCommand komut3 = new SqlCommand("DELETE FROM YeniTelefon Where id = " + Urunid + "", baglanti);
                komut3.ExecuteNonQuery();
                baglanti.Close();
                UrunListele();
                MessageBox.Show("Urun Silindi");
            }
        }
    }
}
