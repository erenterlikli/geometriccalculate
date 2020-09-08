using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlanÇevre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "Kare";
            label7.Visible = false;
            textBox2.Visible = false;
            panel1.Visible = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "Dikdörtgen";
            label2.Text = "Kısa Kenar";
            panel1.Visible = true;
            int kisa, uzun;
            int alan, cevre;
            uzun = Convert.ToInt32(textBox2.Text);
            kisa = Convert.ToInt32(textBox1.Text);
            alan = kisa * uzun;
            cevre = (2 * kisa) + (2 * uzun);
            label4.Text = alan.ToString();
            label5.Text = cevre.ToString();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int birkenar;
            int alan, cevre;
            birkenar = Convert.ToInt32(textBox1.Text);
            alan = birkenar * birkenar;
            cevre = 4 * birkenar;
            label4.Text = alan.ToString();
            label5.Text = cevre.ToString();
        }
    }
}
