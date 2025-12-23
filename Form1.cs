using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        double sayi1, sayi2, Cikti;
        string islem;
        private void buttonNumber_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            txtDisplay.Text += b.Text;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(txtDisplay.Text);
            islem = "/";
            txtDisplay.Clear();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(txtDisplay.Text);
            islem = "*";
            txtDisplay.Clear();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(txtDisplay.Text);
            islem = "-";
            txtDisplay.Clear();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToDouble(txtDisplay.Text);
            islem = "+";
            txtDisplay.Clear();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            sayi2 = Convert.ToDouble(txtDisplay.Text);
            Hesapla(islem);
        }
        public void Hesapla(string islem)
        {
            switch (islem)
            {
                case "+":
                    Cikti = sayi1 + sayi2;
                    break;
                case "-":
                    Cikti = sayi1 - sayi2;
                    break;
                case "*":
                    Cikti = sayi1 * sayi2;
                    break;
                case "/":
                    if (sayi2 != 0 || sayi1 == null || sayi2 == null)
                        Cikti = sayi1 / sayi2;
                    else
                    {
                        MessageBox.Show("القسمة على صفر كفر!");
                        return;
                    }
                    break;
            }
            txtDisplay.Text = Cikti.ToString();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
            sayi1 = sayi2 = Cikti = 0;
        }
    }
}
