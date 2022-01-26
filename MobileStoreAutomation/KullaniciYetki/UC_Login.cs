using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileStoreAutomation.KullaniciYetki
{
    public partial class UC_Login : UserControl
    {
        
        public UC_Login()
        {
            
            InitializeComponent();
        }

        int abc = 0;
        private void timer1_Tick(object sender, EventArgs e) //login işlemi için zamanlayıcı konuldu
        {
            abc++;
            lbl_Hata.Visible = false;
            if (abc == 10) // 10 saniye bekleme süresi
            {
                abc = 0;
                if(txt_KullaniciAd.Text=="admin" && txt_Sifre.Text == "admin") // giriş işlemlerini yap
                {
                    this.Hide();
                    timer1.Stop();
                }
                else
                {
                    panel1.Visible = true;
                    lbl_Hata.Visible = true;
                    timer1.Stop();
                    this.guna2WinProgressIndicator1.Stop();
                }
            }
        }

        private void Btn_Giris_Click(object sender, EventArgs e)
        {
            this.timer1.Start(); // zamanlayıcıyı başlatıp login işlemlerini yap
            panel1.Visible = false;
            this.guna2WinProgressIndicator1.Start();
        }
    }
}
