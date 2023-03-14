using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hesapMakinesi1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "+";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "-";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "/";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "*";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            char[] delimiterChars = { '+', '-', '/', '*' };
            String s = textBox1.Text;
            String[] k = s.Split(delimiterChars);
            Convert.ToInt64(k[0]);
            Convert.ToInt64(k[1]);
            if (s.Contains("+"))
            {
                long result = Convert.ToInt64(k[0]) + Convert.ToInt64(k[1]);
                textBox1.Text = Convert.ToString(result);
            }
            if (s.Contains("*"))
            {
                long result = Convert.ToInt64(k[0]) * Convert.ToInt64(k[1]);
                textBox1.Text = Convert.ToString(result);
            }
            if (s.Contains("-"))
            {
                long result = Convert.ToInt64(k[0]) - Convert.ToInt64(k[1]);
                textBox1.Text = Convert.ToString(result);
            }
            if (s.Contains("/"))
            {
                if (Convert.ToInt64(k[1]) != 0)
                {
                    double result = (double)Convert.ToInt64(k[0]) / Convert.ToInt64(k[1]);
                    textBox1.Text = Convert.ToString(result);
                }
                else
                {
                    textBox1.Text = "Hatali Giris Yapildi..";
                }
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
        private void hesapMakinesi_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
    }
}
