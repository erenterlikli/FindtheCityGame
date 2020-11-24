using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ŞehirTahminOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        string[] sehirlistesi = { "İstanbul", "Ankara", "İzmir", "Adana", "Adıyaman", "Afyonkarahisar", "Ağrı", "Aksaray", "Amasya", "Antalya", "Ardahan", "Artvin", "Aydın", "Balıkesir", "Bartın", "Batman", "Bayburt", "Bilecik", "Bingöl", "Bitlis", "Bolu", "Burdur", "Bursa", "Çanakkale", "Çankırı", "Çorum", "Denizli", "Diyarbakır", "Düzce", "Edirne", "Elazığ", "Erzincan", "Erzurum", "Eskişehir", "Gaziantep", "Giresun", "Gümüşhane", "Hakkari", "Hatay", "Iğdır", "Isparta", "Kahramanmaraş", "Karabük", "Karaman", "Kars", "Kastamonu", "Kayseri", "Kırıkkale", "Kırklareli", "Kırşehir", "Kilis", "Kocaeli", "Konya", "Kütahya", "Malatya", "Manisa", "Mardin", "Mersin", "Muğla", "Muş", "Nevşehir", "Niğde", "Ordu", "Osmaniye", "Rize", "Sakarya", "Samsun", "Siirt", "Sinop", "Sivas", "Şırnak", "Tekirdağ", "Tokat", "Trabzon", "Tunceli", "Şanlıurfa", "Uşak", "Van", "Yalova", "Yozgat", "Zonguldak" };
        string bulunacaksehir;
        int bulunanharfsayisi = 0;
        int kalanhak = 4;
        Random rastgele;

        private void Form1_Load(object sender, EventArgs e)
        {
            BtnHarfGir.Enabled = false;
            BtnTahmin.Enabled = false;
            rastgele = new Random();

            this.AcceptButton = BtnHarfGir;

        }

        private void Yenisehirsec()
        {
            int rastgelesehir = rastgele.Next(0, sehirlistesi.Length);
            bulunacaksehir = sehirlistesi[rastgelesehir];
            
        }

        private void BtnYeniOyun_Click(object sender, EventArgs e)
        {
            bulunanharfsayisi = 0;
            BtnHarfGir.Enabled = true;
            BtnTahmin.Enabled = true;
            lblGirilen.Text = "";
            txtTahmin.Text = "";
            txtHarf.Text = "";
            kalanhak = 4;
            lblKalan.Text = kalanhak.ToString();
            Yenisehirsec();
            groupBox1.Controls.Clear();

            for(int i=0; i<bulunacaksehir.Length; i++)
            {
                Label lbl = new Label();
                lbl.Location = new Point(20 * i + 30, 20);
                lbl.Text = bulunacaksehir[i].ToString();
                lbl.Font = new System.Drawing.Font("Segoe UI", 8.50F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((Byte)(162)));
                lbl.Size = new System.Drawing.Size(20, 20);
                lbl.BackColor = Color.Red;
                lbl.ForeColor = Color.Red;
                groupBox1.Controls.Add(lbl);
            }
        }

        private void BtnHarfGir_Click(object sender, EventArgs e)
        {
            bool harfvarmi = false;
            if(txtHarf.Text.Length !=1)
            {
                MessageBox.Show("Lütfen tek bir harf giriniz!");
            }
            else
            {
                if(lblGirilen.Text.Contains(txtHarf.Text))
                {
                    MessageBox.Show("Bu harfi daha önce girmiştiniz. Lütfen başka harf deneyiniz!");
                    txtHarf.Text = "";
                    txtHarf.Focus();

                    return;
                }

                foreach(Control item in groupBox1.Controls)
                {
                    if(item is Label)
                    {
                        Label lbl = item as Label;
                        if(lbl.Text.ToUpper()==txtHarf.Text.ToUpper())
                        {
                            lbl.ForeColor = Color.Black;
                            lbl.BackColor = Color.Lime;
                            harfvarmi = true;
                            bulunanharfsayisi++;
                        }
                    }
                }
            }

            if(!harfvarmi)
            {
                kalanhak--;
                lblKalan.Text = kalanhak.ToString();
                if(kalanhak==0)
                {
                    MessageBox.Show("Hakkınız bitti, maalesef oyunu kaybettiniz.   Cevap:" +bulunacaksehir);
                    BtnHarfGir.Enabled = false;
                    BtnTahmin.Enabled = false;

                }
            }
            lblGirilen.Text+= txtHarf.Text+ " ";

            if(bulunanharfsayisi==bulunacaksehir.Length)
            {
                MessageBox.Show("Tebrikler, doğru bildiniz. Oyunu kazandınız!");
                BtnHarfGir.Enabled = false;
                BtnTahmin.Enabled = false;
            }

            txtHarf.Text = "";
            txtTahmin.Text = "";
            txtHarf.Focus();

        }

        private void BtnTahmin_Click(object sender, EventArgs e)
        {
            if(bulunacaksehir.ToUpper()==txtTahmin.Text.ToUpper())
            {
                foreach(Control item in groupBox1.Controls)
                {
                    if(item is Label)
                    {
                        Label lbl = item as Label;
                        lbl.ForeColor = Color.Black;
                        lbl.BackColor = Color.Lime;
                    }
                }
                MessageBox.Show("Tebrikler, doğru bildiniz. Oyunu kazandınız!");
            }
            else
            {
                MessageBox.Show("Maalesef yanlış bildiniz. Oyunu kaybettiniz.   Cevap:  "+ bulunacaksehir);
            }
            BtnHarfGir.Enabled = false;
            BtnTahmin.Enabled = false;

        }
    }
}
