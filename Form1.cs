using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace c_sharp_form_ornegi
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void girisYap_Click(object sender, EventArgs e)
        {
            string KullanıcıAdı = textBoxKullanıcıAdı.Text;
            string Sifre = textBoxSifre.Text;

            if (KullanıcıAdı=="123456789")
            {
                if (Sifre=="123456789")
                {
                    labelSonuc.Text = "Giris Basarılı";
                }
                else
                {
                    labelSonuc.Text = "Giris Basarısız,Lutfen kontrol  edip tekrar deneyin";
                }
            }
            else
            {
                labelSonuc.Text = "Giris Basarısız,Lutfen kontrol  edip tekrar deneyin";
            }
        }








        //private void Form1_DoubleClick_1(object sender, EventArgs e)
        //{
        //    label1.Visible = true;
        //}

        //private void label1_Click_1(object sender, EventArgs e)
        //{
        //    label2.Visible = true;
        //}

        //texboxtaki yazıyı label'e aktarma
        //private void textBox1_TextChanged(object sender, EventArgs e)
        //{
        //    string yazı = textBox1.Text;
        //    textboxyazısı.Text = yazı;
        //}

        //butona tıkladıgında texboxtaki yazıyı label'e aktarma

        //private void yazıyıLabeleEKle_Click(object sender, EventArgs e)
        //{
        //    string yazı = textBox1.Text;
        //    textboxyazısı.Text = yazı;
        //}
    }
}
