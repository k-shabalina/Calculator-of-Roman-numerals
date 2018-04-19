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
        string _rim1;
        string _rim2;
        string _znak;
        bool operation = false;
        bool chisla = true;

        public void GetResult(string result)
        {
            label_result.Text = result;
        }

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
            chisla = true;
            for (int i = 0; i < textBox_vvod.Text.Length; i++)
            {
                if (Convert.ToString(textBox_vvod.Text[i]) == "0")
                {
                    chisla = false;
                }
                if (Convert.ToString(textBox_vvod.Text[i]) == "1")
                {
                    chisla = false;
                }
                if (Convert.ToString(textBox_vvod.Text[i]) == "2")
                {
                    chisla = false;
                }
                if (Convert.ToString(textBox_vvod.Text[i]) == "3")
                {
                    chisla = false;
                }
                if (Convert.ToString(textBox_vvod.Text[i]) == "4")
                {
                    chisla = false;
                }
                if (Convert.ToString(textBox_vvod.Text[i]) == "5")
                {
                    chisla = false;
                }
                if (Convert.ToString(textBox_vvod.Text[i]) == "6")
                {
                    chisla = false;
                }
                if (Convert.ToString(textBox_vvod.Text[i]) == "7")
                {
                    chisla = false;
                }
                if (Convert.ToString(textBox_vvod.Text[i]) == "8")
                {
                    chisla = false;
                }
                if (Convert.ToString(textBox_vvod.Text[i]) == "9")
                {
                    chisla = false;
                }
            }
            if (chisla == true)
            {
                operation = true;
                _rim1 = textBox_vvod.Text;
                _znak = "+";
                textBox_vvod.Text = "";
            }
            else
            {
                MessageBox.Show("Данная операция недоступная для арабских чисел","Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void button_minus_Click(object sender, EventArgs e)
        {
            chisla = true;
            for (int i = 0; i < textBox_vvod.Text.Length; i++)
            {
                if (Convert.ToString(textBox_vvod.Text[i]) == "0")
                {
                    chisla = false;
                }
                if (Convert.ToString(textBox_vvod.Text[i]) == "1")
                {
                    chisla = false;
                }
                if (Convert.ToString(textBox_vvod.Text[i]) == "2")
                {
                    chisla = false;
                }
                if (Convert.ToString(textBox_vvod.Text[i]) == "3")
                {
                    chisla = false;
                }
                if (Convert.ToString(textBox_vvod.Text[i]) == "4")
                {
                    chisla = false;
                }
                if (Convert.ToString(textBox_vvod.Text[i]) == "5")
                {
                    chisla = false;
                }
                if (Convert.ToString(textBox_vvod.Text[i]) == "6")
                {
                    chisla = false;
                }
                if (Convert.ToString(textBox_vvod.Text[i]) == "7")
                {
                    chisla = false;
                }
                if (Convert.ToString(textBox_vvod.Text[i]) == "8")
                {
                    chisla = false;
                }
                if (Convert.ToString(textBox_vvod.Text[i]) == "9")
                {
                    chisla = false;
                }
            }
            if (chisla == true)
            {
                operation = true;
                _rim1 = textBox_vvod.Text;
                _znak = "-";
                textBox_vvod.Text = "";
            }
            else
            {
                MessageBox.Show("Данная операция недоступная для арабских чисел", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_umnozhit_Click(object sender, EventArgs e)
        {
            chisla = true;
            for (int i = 0; i < textBox_vvod.Text.Length; i++)
            {
                if (Convert.ToString(textBox_vvod.Text[i]) == "0")
                {
                    chisla = false;
                }
                if (Convert.ToString(textBox_vvod.Text[i]) == "1")
                {
                    chisla = false;
                }
                if (Convert.ToString(textBox_vvod.Text[i]) == "2")
                {
                    chisla = false;
                }
                if (Convert.ToString(textBox_vvod.Text[i]) == "3")
                {
                    chisla = false;
                }
                if (Convert.ToString(textBox_vvod.Text[i]) == "4")
                {
                    chisla = false;
                }
                if (Convert.ToString(textBox_vvod.Text[i]) == "5")
                {
                    chisla = false;
                }
                if (Convert.ToString(textBox_vvod.Text[i]) == "6")
                {
                    chisla = false;
                }
                if (Convert.ToString(textBox_vvod.Text[i]) == "7")
                {
                    chisla = false;
                }
                if (Convert.ToString(textBox_vvod.Text[i]) == "8")
                {
                    chisla = false;
                }
                if (Convert.ToString(textBox_vvod.Text[i]) == "9")
                {
                    chisla = false;
                }
            }
            if (chisla == true)
            {
                operation = true;
                _rim1 = textBox_vvod.Text;
                _znak = "*";
                textBox_vvod.Text = "";
            }
            else
            {
                MessageBox.Show("Данная операция недоступная для арабских чисел", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_div_Click(object sender, EventArgs e)
        {
            chisla = true;
            for (int i = 0; i < textBox_vvod.Text.Length; i++)
            {
                if (Convert.ToString(textBox_vvod.Text[i]) == "0")
                {
                    chisla = false;
                }
                if (Convert.ToString(textBox_vvod.Text[i]) == "1")
                {
                    chisla = false;
                }
                if (Convert.ToString(textBox_vvod.Text[i]) == "2")
                {
                    chisla = false;
                }
                if (Convert.ToString(textBox_vvod.Text[i]) == "3")
                {
                    chisla = false;
                }
                if (Convert.ToString(textBox_vvod.Text[i]) == "4")
                {
                    chisla = false;
                }
                if (Convert.ToString(textBox_vvod.Text[i]) == "5")
                {
                    chisla = false;
                }
                if (Convert.ToString(textBox_vvod.Text[i]) == "6")
                {
                    chisla = false;
                }
                if (Convert.ToString(textBox_vvod.Text[i]) == "7")
                {
                    chisla = false;
                }
                if (Convert.ToString(textBox_vvod.Text[i]) == "8")
                {
                    chisla = false;
                }
                if (Convert.ToString(textBox_vvod.Text[i]) == "9")
                {
                    chisla = false;
                }
            }
            if (chisla == true)
            {
                operation = true;
                _rim1 = textBox_vvod.Text;
                _znak = "/";
                textBox_vvod.Text = "";
            }
            else
            {
                MessageBox.Show("Данная операция недоступная для арабских чисел", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_mod_Click(object sender, EventArgs e)
        {
            chisla = true;
            for (int i = 0; i < textBox_vvod.Text.Length; i++)
            {
                if (Convert.ToString(textBox_vvod.Text[i]) == "0")
                {
                    chisla = false;
                }
                if (Convert.ToString(textBox_vvod.Text[i]) == "1")
                {
                    chisla = false;
                }
                if (Convert.ToString(textBox_vvod.Text[i]) == "2")
                {
                    chisla = false;
                }
                if (Convert.ToString(textBox_vvod.Text[i]) == "3")
                {
                    chisla = false;
                }
                if (Convert.ToString(textBox_vvod.Text[i]) == "4")
                {
                    chisla = false;
                }
                if (Convert.ToString(textBox_vvod.Text[i]) == "5")
                {
                    chisla = false;
                }
                if (Convert.ToString(textBox_vvod.Text[i]) == "6")
                {
                    chisla = false;
                }
                if (Convert.ToString(textBox_vvod.Text[i]) == "7")
                {
                    chisla = false;
                }
                if (Convert.ToString(textBox_vvod.Text[i]) == "8")
                {
                    chisla = false;
                }
                if (Convert.ToString(textBox_vvod.Text[i]) == "9")
                {
                    chisla = false;
                }
            }
            if (chisla == true)
            {
                operation = true;
                _rim1 = textBox_vvod.Text;
                _znak = "%";
                textBox_vvod.Text = null;
            }
            else
            {
                MessageBox.Show("Данная операция недоступная для арабских чисел", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_to_10_Click(object sender, EventArgs e)
        {
            chisla = true;
            for (int i = 0; i < textBox_vvod.Text.Length; i++)
            {
                if (Convert.ToString(textBox_vvod.Text[i]) == "0")
                {
                    chisla = false;
                }
                if (Convert.ToString(textBox_vvod.Text[i]) == "1")
                {
                    chisla = false;
                }
                if (Convert.ToString(textBox_vvod.Text[i]) == "2")
                {
                    chisla = false;
                }
                if (Convert.ToString(textBox_vvod.Text[i]) == "3")
                {
                    chisla = false;
                }
                if (Convert.ToString(textBox_vvod.Text[i]) == "4")
                {
                    chisla = false;
                }
                if (Convert.ToString(textBox_vvod.Text[i]) == "5")
                {
                    chisla = false;
                }
                if (Convert.ToString(textBox_vvod.Text[i]) == "6")
                {
                    chisla = false;
                }
                if (Convert.ToString(textBox_vvod.Text[i]) == "7")
                {
                    chisla = false;
                }
                if (Convert.ToString(textBox_vvod.Text[i]) == "8")
                {
                    chisla = false;
                }
                if (Convert.ToString(textBox_vvod.Text[i]) == "9")
                {
                    chisla = false;
                }
            }
            if (chisla == true)
            {
                operation = false;
                _rim1 = textBox_vvod.Text;
                _znak = null;
                textBox_vvod.Text = null;
                label_result.Text = Convert.ToString(Calc.RimToArab(_rim1));
            }
            else
            {
                MessageBox.Show("Данная операция недоступная для арабских чисел", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button_toX_Click(object sender, EventArgs e)
        {
            chisla = true;
            for (int i = 0; i < textBox_vvod.Text.Length; i++)
            {
                if (Convert.ToString(textBox_vvod.Text[i]) == "I")
                {
                    chisla = false;
                }
                if (Convert.ToString(textBox_vvod.Text[i]) == "X")
                {
                    chisla = false;
                }
                if (Convert.ToString(textBox_vvod.Text[i]) == "V")
                {
                    chisla = false;
                }
                if (Convert.ToString(textBox_vvod.Text[i]) == "L")
                {
                    chisla = false;
                }
                if (Convert.ToString(textBox_vvod.Text[i]) == "M")
                {
                    chisla = false;
                }
                if (Convert.ToString(textBox_vvod.Text[i]) == "C")
                {
                    chisla = false;
                }
                if (Convert.ToString(textBox_vvod.Text[i]) == "D")
                {
                    chisla = false;
                }
            }
            if (chisla == true)
            {
                operation = false;
                _rim1 = textBox_vvod.Text;
                _znak = null;
                textBox_vvod.Text = null;
                label_result.Text = Calc.ArabToRim(Convert.ToInt32(_rim1));
            }
            else
            {
                MessageBox.Show("Данная операция недоступная для римских чисел", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_ravno_Click(object sender, EventArgs e)
        {
            if (operation == true)
            {
                if (textBox_vvod.Text != "" && textBox_vvod.Text != null)
                {
                    _rim2 = textBox_vvod.Text;
                    operation = false;
                    textBox_vvod.Text = null;
                    if (_znak == "+")
                    {
                        label_result.Text = Calc.Plus(_rim1, _rim2);
                    }
                    if (_znak == "-")
                    {
                        label_result.Text = Calc.Minus(_rim1, _rim2);
                    }
                    if (_znak == "*")
                    {
                        label_result.Text = Calc.Multiply(_rim1, _rim2);
                    }
                    if (_znak == "/")
                    {
                        label_result.Text = Calc.Divide(_rim1, _rim2);
                    }
                    if (_znak == "%")
                    {
                        label_result.Text = Calc.Percent(_rim1, _rim2);
                    }
                }
                _znak = null;
            }
            else
            {
                MessageBox.Show("Некорректная операция", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    

        private void button_clean_Click(object sender, EventArgs e)
        {
            textBox_vvod.Text = null;
            _rim1 = null;
            _rim2 = null;
            operation = false;
        }

        private void button_ce_Click(object sender, EventArgs e)
        {
            textBox_vvod.Text = null;
            if (_rim2 == null)
            {
                if (_rim1 != null)
                {
                    _rim1 = null;
                }
            }
            else
            {
                _rim2 = null;
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
