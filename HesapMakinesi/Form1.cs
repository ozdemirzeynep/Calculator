using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

         double sayi1 = 0;
         double sayi2 = 0;
         double sonuc = 0;

        private void Button1_Click(object sender, EventArgs e)
        {
            
            sayi1 = Convert.ToDouble(textBox1.Text);
            sayi2 = Convert.ToDouble(textBox2.Text);
            sonuc = sayi1 + sayi2;
            label4.Text = Convert.ToString(sonuc);

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            
            sayi1 = Convert.ToDouble(textBox1.Text);
            sayi2 = Convert.ToDouble(textBox2.Text);
            sonuc = sayi1 - sayi2;
            label4.Text = Convert.ToString(sonuc);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            
            sayi1 = Convert.ToDouble(textBox1.Text);
            sayi2 = Convert.ToDouble(textBox2.Text);
            sonuc = sayi1 * sayi2;
            label4.Text = Convert.ToString(sonuc);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            
            sayi1 = Convert.ToDouble(textBox1.Text);
            sayi2 = Convert.ToDouble(textBox2.Text);
            sonuc = sayi1 / sayi2;
            label4.Text = Convert.ToString(sonuc);
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
