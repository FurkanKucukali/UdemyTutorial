using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SenkronikAsenkronik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            Topla(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
        }

        private void btnCarp_Click(object sender, EventArgs e)
        {
            Carp(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
        }
        private void Topla(int sayi1,int sayi2)
        {
            MessageBox.Show($"Toplam : {sayi1 + sayi2}");
        }
        private void Carp(int sayi1, int sayi2)
        {
            Thread.Sleep(10000);
            MessageBox.Show($"Carpim : {sayi1 * sayi2}");
        }
    }
}
