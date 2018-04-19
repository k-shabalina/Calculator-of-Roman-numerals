using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        string rim1;
        string rim2;
        string znak;
        bool operation = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_I_Click(object sender, EventArgs e)
        {
            textBox_vvod.Text += "I";
        }

        private void button_V_Click(object sender, EventArgs e)
        {
            textBox_vvod.Text += "V";
        }

        private void button_X_Click(object sender, EventArgs e)
        {
            textBox_vvod.Text += "X";
        }

        private void button_L_Click(object sender, EventArgs e)
        {
            textBox_vvod.Text += "L";
        }

        private void button_C_Click(object sender, EventArgs e)
        {
            textBox_vvod.Text += "C";
        }

        private void button_D_Click(object sender, EventArgs e)
        {
            textBox_vvod.Text += "D";
        }

        private void button_M_Click(object sender, EventArgs e)
        {
            textBox_vvod.Text += "M";
        }

        private void button_plus_Click(object sender, EventArgs e)
        {
            operation = true;
            rim1 = textBox_vvod.Text;
            znak = "+";
            textBox_vvod.Text = "";
        }

        private void button_minus_Click(object sender, EventArgs e)
        {
            operation = true;
            rim1 = textBox_vvod.Text;
            znak = "-";
            textBox_vvod.Text = "";
        }

        private void button_umnozhit_Click(object sender, EventArgs e)
        {
            operation = true;
            rim1 = textBox_vvod.Text;
            znak = "*";
            textBox_vvod.Text = "";
        }

        private void button_div_Click(object sender, EventArgs e)
        {
            operation = true;
            rim1 = textBox_vvod.Text;
            znak = "/";
            textBox_vvod.Text = "";
        }

        private void button_mod_Click(object sender, EventArgs e)
        {
            operation = true;
            rim1 = textBox_vvod.Text;
            znak = "%";
            textBox_vvod.Text = "";
        }

        private void button1_to_10_Click(object sender, EventArgs e)
        {
            operation = true;
            rim1 = textBox_vvod.Text;
            znak = "->";
            textBox_vvod.Text = "";
        }

        private void button_toX_Click(object sender, EventArgs e)
        {
            operation = true;
            rim1 = textBox_vvod.Text;
            znak = "<-";
            textBox_vvod.Text = "";
        }

        private void button_ravno_Click(object sender, EventArgs e)
        {
            if (operation == true)
            {
                if (textBox_vvod.Text != "" && textBox_vvod.Text != null)
                {
                    rim2 = textBox_vvod.Text;
                }
            }
        }

        private void button_clean_Click(object sender, EventArgs e)
        {
            rim1 = null;
            rim2 = null;
            operation = false;
        }

        private void button_ce_Click(object sender, EventArgs e)
        {
            if (rim2 == null)
            {
                if (rim1 != null)
                {
                    rim1 = null;
                }
            }
            else
            {
                rim2 = null;
            }
        }

        private void button_0_Click(object sender, EventArgs e)
        {
            textBox_vvod.Text += "0";
        }

        private void button_1_Click(object sender, EventArgs e)
        {
            textBox_vvod.Text += "1";
        }

        private void button_2_Click(object sender, EventArgs e)
        {
            textBox_vvod.Text += "2";
        }

        private void button_3_Click(object sender, EventArgs e)
        {
            textBox_vvod.Text += "3";
        }

        private void button_4_Click(object sender, EventArgs e)
        {
            textBox_vvod.Text += "4";
        }

        private void button_5_Click(object sender, EventArgs e)
        {
            textBox_vvod.Text += "5";
        }

        private void button_6_Click(object sender, EventArgs e)
        {
            textBox_vvod.Text += "6";
        }

        private void button_7_Click(object sender, EventArgs e)
        {
            textBox_vvod.Text += "7";
        }

        private void button_8_Click(object sender, EventArgs e)
        {
            textBox_vvod.Text += "8";
        }

        private void button_9_Click(object sender, EventArgs e)
        {
            textBox_vvod.Text += "9";
        }
    }
}
