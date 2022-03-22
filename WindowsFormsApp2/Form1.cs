using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double guarda = 0;
        int control = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "1";         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "0";
        }
                                   // (( + ))
        private void button12_Click(object sender, EventArgs e)
        {
            guarda = Convert.ToDouble(richTextBox1.Text);
            richTextBox1.Clear();
            control = 1;

        }

        private void button11_Click(object sender, EventArgs e) //(( = ))
        {
            if(control == 1)
            {
                richTextBox1.Text = Convert.ToString(Convert.ToDouble(guarda) + Convert.ToDouble(richTextBox1.Text));
            }
            if(control == 2)
            {
                richTextBox1.Text = Convert.ToString(Convert.ToDouble(guarda) - Convert.ToDouble(richTextBox1.Text));
            }
            if(control == 3)
            {
                richTextBox1.Text = Convert.ToString(Convert.ToDouble(guarda) * Convert.ToDouble(richTextBox1.Text));
            }
            if (control == 4)
            {
                richTextBox1.Text = Convert.ToString(Convert.ToDouble(guarda) / Convert.ToDouble(richTextBox1.Text));
            }

        }

        private void button13_Click(object sender, EventArgs e) // (( - ))
        {
            guarda = Convert.ToDouble(richTextBox1.Text);
            richTextBox1.Clear();
            control = 2;
        }

        private void button14_Click(object sender, EventArgs e) // (( x ))
        {
            guarda = Convert.ToDouble(richTextBox1.Text);
            richTextBox1.Clear();
            control = 3;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            guarda = Convert.ToDouble(richTextBox1.Text);
            richTextBox1.Clear();
            control = 4;
        }
    }
}
