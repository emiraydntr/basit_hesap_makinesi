using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace basit_hesap_makinesi
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int s1, s2, sonuc;

        private void button3_Click(object sender, EventArgs e)
        {
            s1 = Convert.ToInt32(textBox1.Text);
            s2 = Convert.ToInt32(textBox2.Text);
            sonuc = s1 * s2;
            label5.Text = sonuc.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            s1 = Convert.ToInt32(textBox1.Text);
            s2 = Convert.ToInt32(textBox2.Text);
            sonuc = s1 / s2;
            label5.Text = sonuc.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            s1 = Convert.ToInt32(textBox1.Text);
            s2 = Convert.ToInt32(textBox2.Text);
            sonuc = s1 - s2;
            label5.Text = sonuc.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            s1 = Convert.ToInt32(textBox1.Text);
            s2 = Convert.ToInt32(textBox2.Text);
            sonuc = s1 + s2;
            label5.Text = sonuc.ToString();
        }
    }
}
