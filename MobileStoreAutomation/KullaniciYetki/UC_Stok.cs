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
    public partial class UC_Stok : UserControl
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-BCV2AJ1;Initial Catalog=MobilMagazaOtomasyon;Integrated Security=True");
        public UC_Stok()
        {
            InitializeComponent();
        }

        

        private void UC_Stok_Load(object sender, EventArgs e) // form yüklenirden sql sorgusu ile veriler tabloya getiriliyor
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT * FROM YeniTelefon", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            da.Fill(ds);
            guna2DataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        int Urunid;
        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) //datagridview da secilen satıra göre bilgiler getirilme işlemi
        {
            baglanti.Open();
            if(guna2DataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value !=null)
            {
                Urunid = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            SqlCommand komut2 = new SqlCommand("SELECT * FROM YeniTelefon where id = " + Urunid + "", baglanti);
            SqlDataAdapter da2 = new SqlDataAdapter(komut2);
            DataSet ds2 = new DataSet();
            da2.Fill(ds2);

            lbl_MarkaAd.Text = ds2.Tables[0].Rows[0][1].ToString();
            lbl_ModelAd.Text = ds2.Tables[0].Rows[0][2].ToString();
            lbl_Ram.Text = ds2.Tables[0].Rows[0][3].ToString();
            Lbl_Depolama.Text = ds2.Tables[0].Rows[0][4].ToString();
            Lbl_MaskDepo.Text = ds2.Tables[0].Rows[0][5].ToString();
            Lbl_Ekran.Text = ds2.Tables[0].Rows[0][6].ToString();
            lbl_ArkaKamera.Text = ds2.Tables[0].Rows[0][7].ToString();
            lbl_Onkamera.Text = ds2.Tables[0].Rows[0][8].ToString();
            lbl_Parmakİzi.Text = ds2.Tables[0].Rows[0][9].ToString();
            lbl_SimTip.Text = ds2.Tables[0].Rows[0][10].ToString();
            lbl_AgTip.Text = ds2.Tables[0].Rows[0][11].ToString();
            Lbl_Fiyat.Text = ds2.Tables[0].Rows[0][13].ToString();



            baglanti.Close();    
        }
    }
}
