using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yemekTarifi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        string[] stages =  {"Makarna Tarifi","1-Tencereye 2 litre su ekleyin ve kaynatın","2-Su kaynadıktan sonra 1 paket makarnayı tencereye ilave edin ve 8-10 dakika karıştırın","3-Süre geçtikten sonra süzün,bir bardak suyu saklayın ve tencerenizde soğan salça kavurun.","4-makarnayı ilave edin karıştırın ve ayırdığınız suyu da dökün.","5-Kendi referansına göre baharatlarını ayarlayın.","Afiyet olsun." };
        int index = 0;
        private void btnAsamaEkle_Click(object sender, EventArgs e)
        {
            //int index=0;
            if (index <stages.Length)
            {
                listFbox.Items.Add(stages[index]);
                index++;
            }
            else
            {
                MessageBox.Show("Tarif tamamlanmistir Afiyet olsun.");
            }
        }
    }
}
