using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KDV_PROJE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string telefon;
            int fiyat;
            double kdv, toplam;

            telefon = textBox1.Text;
            fiyat = Convert.ToInt16(textBox2.Text);
            kdv = fiyat * 18 / 100;
            toplam = kdv + fiyat;
            listBox1.Items.Add("Telefon :" + telefon + " \n" + " %18 kdvli fiyat" + toplam);


        }
    }
}
