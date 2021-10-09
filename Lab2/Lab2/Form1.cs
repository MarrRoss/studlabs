using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        public string action;
        public string first_number;
        public bool second_number;
        private double memory;
        private bool memory_flag;
        public double ex_watt_1;
        public double ex_watt_2;

        public Form1()
        {
            InitializeComponent();
            second_number = false;
            button_MC.Enabled = false;
            button_MR.Enabled = false;
            button_memory.Enabled = false;
            textbox.Focus();
            textbox.SelectionStart = textbox.Text.Length;

        }
        

        private void button_memory_Click(object sender, EventArgs e)
        {
            MessageBox.Show(memory.ToString());
        }

        private void button_equals_Click(object sender, EventArgs e)
        {
            if (textbox.Text == "")
                textbox.Text = "";
            else
            {
                double first_number_double, second_number_double, result;
                result = 0;
                first_number_double = Convert.ToDouble(first_number);
                second_number_double = Convert.ToDouble(textbox.Text);

                if (action == "+")
                {
                    result = first_number_double + second_number_double;

                }

                if (action == "−")
                {
                    result = first_number_double - second_number_double;

                }

                if (action == "×")
                {
                    result = first_number_double * second_number_double;
                }

                if (action == "÷")
                {
                    result = first_number_double / second_number_double;
                }

                if (action == "%")
                {
                    result = (second_number_double / 100) * first_number_double;
                }

                label.Text = first_number + " " + action + " " + textbox.Text + " =";
                action = "=";
                second_number = true;
                textbox.Text = result.ToString();
                textbox.Focus();
                textbox.SelectionStart = textbox.Text.Length;

            }
        }

        private void button_0_Click(object sender, EventArgs e)
        {
            if ((second_number == true) || (memory_flag == true))
            {
                second_number = false;
                textbox.Text = "0";
                memory_flag = false;
            }
            Button button_0 = (Button)sender;
            if (textbox.Text == "0")
                textbox.Text = button_0.Text;
            else
                textbox.Text = textbox.Text + button_0.Text;
        }

        private void button_1_Click(object sender, EventArgs e)
        {
            if ((second_number == true) || (memory_flag == true))
            {
                second_number = false;
                textbox.Text = "0";
                memory_flag = false;
            }
            Button button_1 = (Button)sender;
            if (textbox.Text == "0")
                textbox.Text = button_1.Text;
            else
                textbox.Text = textbox.Text + button_1.Text;
        }

        private void button_2_Click(object sender, EventArgs e)
        {
            if ((second_number == true) || (memory_flag == true))
            {
                second_number = false;
                textbox.Text = "0";
                memory_flag = false;
            }
            Button button_2 = (Button)sender;
            if (textbox.Text == "0")
                textbox.Text = button_2.Text;
            else
                textbox.Text = textbox.Text + button_2.Text;
        }

        private void button_3_Click(object sender, EventArgs e)
        {
            if ((second_number == true) || (memory_flag == true))
            {
                second_number = false;
                textbox.Text = "0";
                memory_flag = false;
            }
            Button button_3 = (Button)sender;
            if (textbox.Text == "0")
                textbox.Text = button_3.Text;
            else
                textbox.Text = textbox.Text + button_3.Text;
        }

        private void button_4_Click(object sender, EventArgs e)
        {
            if ((second_number == true) || (memory_flag == true))
            {
                second_number = false;
                textbox.Text = "0";
                memory_flag = false;
            }
            Button button_4 = (Button)sender;
            if (textbox.Text == "0")
                textbox.Text = button_4.Text;
            else
                textbox.Text = textbox.Text + button_4.Text;
        }

        private void button_5_Click(object sender, EventArgs e)
        {
            if ((second_number == true) || (memory_flag == true))
            {
                second_number = false;
                textbox.Text = "0";
                memory_flag = false;
            }
            Button button_5 = (Button)sender;
            if (textbox.Text == "0")
                textbox.Text = button_5.Text;
            else
                textbox.Text = textbox.Text + button_5.Text;
        }

        private void button_6_Click(object sender, EventArgs e)
        {
            if ((second_number == true) || (memory_flag == true))
            {
                second_number = false;
                textbox.Text = "0";
                memory_flag = false;
            }
            Button button_6 = (Button)sender;
            if (textbox.Text == "0")
                textbox.Text = button_6.Text;
            else
                textbox.Text = textbox.Text + button_6.Text;
        }

        private void button_7_Click(object sender, EventArgs e)
        {
            if ((second_number == true) || (memory_flag == true))
            {
                second_number = false;
                textbox.Text = "0";
                memory_flag = false;
            }
            Button button_7 = (Button)sender;
            if (textbox.Text == "0")
                textbox.Text = button_7.Text;
            else
                textbox.Text = textbox.Text + button_7.Text;
        }

        private void button_8_Click(object sender, EventArgs e)
        {
            if ((second_number == true) || (memory_flag == true))
            {
                second_number = false;
                textbox.Text = "0";
                memory_flag = false;
            }
            Button button_8 = (Button)sender;
            if (textbox.Text == "0")
                textbox.Text = button_8.Text;
            else
                textbox.Text = textbox.Text + button_8.Text;
        }

        private void button_9_Click(object sender, EventArgs e)
        {
            if ((second_number == true) || (memory_flag == true))
            {
                second_number = false;
                textbox.Text = "0";
                memory_flag = false;
            }
            Button button_9 = (Button)sender;
            if (textbox.Text == "0")
                textbox.Text = button_9.Text;
            else
                textbox.Text = textbox.Text + button_9.Text;
        }

        private void button_C_Click(object sender, EventArgs e)
        {
            textbox.Text = "";
            label.Text = "";
            textbox.Focus();
        }

        private void button_plus_Click(object sender, EventArgs e)
        {
            Button button_plus = (Button)sender;
            action = button_plus.Text;
            first_number = textbox.Text;
            second_number = true;
            label.Text = first_number + " " + action;
            textbox.Text = "";
            textbox.Focus();
            textbox.SelectionStart = textbox.Text.Length;
        }

        private void button_minus_Click(object sender, EventArgs e)
        {
            Button button_minus = (Button)sender;
            action = button_minus.Text;
            first_number = textbox.Text;
            second_number = true;
            label.Text = first_number + " " + action;
            textbox.Text = "";
            textbox.Focus();
            textbox.SelectionStart = textbox.Text.Length;
        }

        private void button_multiply_Click(object sender, EventArgs e)
        {
            Button button_multiply = (Button)sender;
            action = button_multiply.Text;
            first_number = textbox.Text;
            second_number = true;
            label.Text = first_number + " " + action;
            textbox.Text = "";
            textbox.Focus();
            textbox.SelectionStart = textbox.Text.Length;
        }

        private void button_divide_Click(object sender, EventArgs e)
        {
            Button button_divide = (Button)sender;
            action = button_divide.Text;
            first_number = textbox.Text;
            second_number = true;
            label.Text = first_number + " " + action;
            textbox.Text = "";
            textbox.Focus();
            textbox.SelectionStart = textbox.Text.Length;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ActiveControl = textbox;
            textbox.SelectionStart = textbox.Text.Length;
        }

        private void button_root_Click(object sender, EventArgs e)
        {
            if (textbox.Text == "")
                textbox.Text = "";
            else
            {
                double number_double, result;
                number_double = Convert.ToDouble(textbox.Text);
                result = Math.Sqrt(number_double);
                textbox.Text = result.ToString();
            }
        }

        private void button_square_Click(object sender, EventArgs e)
        {
            if (textbox.Text == "")
                textbox.Text = "";
            else
            {
                double number_double, result;
                number_double = Convert.ToDouble(textbox.Text);
                result = Math.Pow(number_double, 2);
                textbox.Text = result.ToString();
            }
        }

        private void button_fraction_Click(object sender, EventArgs e)
        {
            if (textbox.Text == "")
                textbox.Text = "";
            else
            {
                double number_double, result;
                number_double = Convert.ToDouble(textbox.Text);
                result = 1 / number_double;
                textbox.Text = result.ToString();
            }
        }

        private void button_negate_Click(object sender, EventArgs e)
        {
            if (textbox.Text == "")
                textbox.Text = "";
            else
            {
                if (textbox.Text == "0")
                    textbox.Text = "0";
                else
                {
                    double number_double, result;
                    number_double = Convert.ToDouble(textbox.Text);
                    result = -number_double;
                    textbox.Text = result.ToString();
                }
            }
        }

        private void button_percent_Click(object sender, EventArgs e)
        {
            Button button_percent = (Button)sender;
            action = button_percent.Text;
            first_number = textbox.Text;
            second_number = true;
        }

        private void button_point_Click(object sender, EventArgs e)
        {
            Button button_point = (Button)sender;
            if (!textbox.Text.Contains(","))
                textbox.Text = textbox.Text + ",";
        }

        private void button_del_Click(object sender, EventArgs e)
        {
            string number, result;
            number = textbox.Text;
            if (number.Length > 0)
            {
                result = number.Remove(number.Length - 1);
                textbox.Text = result;
            }
            if (textbox.Text == "")
                label.Text = "";
            textbox.Focus();
            textbox.SelectionStart = textbox.Text.Length;
        }

        private void button_MR_Click(object sender, EventArgs e)
        {
            textbox.Text = memory.ToString();
            memory_flag = true;
        }

        private void button_MS_Click(object sender, EventArgs e)
        {
            if (textbox.Text == "")
                textbox.Text = "";
            else
            {
                memory = Double.Parse(textbox.Text);
                button_MC.Enabled = true;
                button_MR.Enabled = true;
                button_memory.Enabled = true;
                memory_flag = true;
            }
        }

        private void button_MC_Click(object sender, EventArgs e)
        {
            textbox.Text = "";
            memory = 0;
            button_MR.Enabled = false;
            button_MC.Enabled = false;
            button_memory.Enabled = false;
        }

        private void button_M_plus_Click(object sender, EventArgs e)
        {
            if (textbox.Text == "")
                textbox.Text = "";
            else
                memory += Double.Parse(textbox.Text);
        }

        private void button_M_minus_Click(object sender, EventArgs e)
        {
            if (textbox.Text == "")
                textbox.Text = "";
            else
                memory -= Double.Parse(textbox.Text);
        }

        private void button_CE_Click(object sender, EventArgs e)
        {
            textbox.Text = "";
            textbox.Focus();
        }

        private void button_kilowatt_Click(object sender, EventArgs e)
        {
            
        }

        private void button_watt_Click(object sender, EventArgs e)
        {
            double number, result;
            number = Convert.ToDouble(textbox.Text);
            result = number / 1000;
            kilowatt.Text = result.ToString();
        }

        private void watt_TextChanged(object sender, EventArgs e)
        {
            if (watt.SelectionStart == 0)
                watt.SelectionStart = watt.Text.Length;
            if (watt.Text.EndsWith(" "))
                watt.Text = watt.Text.Remove(watt.Text.Length - 1);
            try
            {
                ex_watt_1 = Convert.ToDouble(watt.Text);
            }
            catch (FormatException) 
            {
                if (watt.Text.Length > 0)
                {
                    watt.Text = watt.Text.Remove(watt.Text.Length - 1);
                    watt.SelectionStart = watt.Text.Length;
                }
                else
                    watt.Text = "";
            }
            finally
            {
                if (watt.Text != "")
                {
                    ex_watt_2 = ex_watt_1 * 1000;
                    kilowatt.Text = ex_watt_2.ToString();
                }
                else
                    kilowatt.Text = "";
            }
        }

        private void kilowatt_TextChanged(object sender, EventArgs e)
        {
            if (kilowatt.SelectionStart == 0)
                kilowatt.SelectionStart = kilowatt.Text.Length;
            if (kilowatt.Text.EndsWith(" "))
                kilowatt.Text = kilowatt.Text.Remove(kilowatt.Text.Length - 1);

            try
            {
                ex_watt_1 = Convert.ToDouble(kilowatt.Text);
            }
            catch (FormatException)
            {
                if (kilowatt.Text.Length > 0)
                {
                    kilowatt.Text = kilowatt.Text.Remove(kilowatt.Text.Length - 1);
                    kilowatt.SelectionStart = kilowatt.Text.Length;
                }
                else
                    kilowatt.Text = "";
            }
            finally
            {
                if (kilowatt.Text != "")
                {
                    ex_watt_2 = ex_watt_1 / 1000;
                    watt.Text = ex_watt_2.ToString();
                }
                else
                    watt.Text = "";
            }
        }

        private void textbox_TextChanged(object sender, EventArgs e)
        {
            if (textbox.Text.EndsWith(" "))
                textbox.Text = textbox.Text.Remove(textbox.Text.Length - 1);
            if (textbox.SelectionStart == 0)
                textbox.SelectionStart = textbox.Text.Length;
            try
            {
                ex_watt_1 = Convert.ToDouble(textbox.Text);
            }
            catch (FormatException)
            {
                if (textbox.Text.Length > 0)
                {
                    textbox.Text = textbox.Text.Remove(textbox.Text.Length - 1);
                    textbox.SelectionStart = textbox.Text.Length;
                }
                else
                    textbox.Text = "";
            }
            finally
            { }
        }
    }
}
