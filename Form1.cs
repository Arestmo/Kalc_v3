using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalc_v3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        String[] Result = new String[4];

        private void Check_add_CheckedChanged(object sender, EventArgs e)
        {
            if (Check_add.Checked)
            {
                int Val1 = Get_value(Text_val1);
                int Val2 = Get_value(Text_val2);
                int result = Val1 + Val2;
                Result[0] = "Wynik dodawania : " + result;
                //Place your code here
            }
            else
            {
                Result[0] = null;
            }
        }

        private void Check_substract_CheckedChanged(object sender, EventArgs e)
        {
            if(Check_substract.Checked)
            {
                int Val1 = Get_value(Text_val1);
                int Val2 = Get_value(Text_val2);
                int result = Val1 - Val2;
                Result[1] = "Wynik odejmowania : " + result;
                //Place your code here
            }
            else
            {
                Result[1] = null;
            }
        }

        private void Check_multiply_CheckedChanged(object sender, EventArgs e)
        {
            if (Check_multiply.Checked)
            {
                int Val1 = Get_value(Text_val1);
                int Val2 = Get_value(Text_val2);
                int result = Val1 * Val2;
                Result[2] = "Wynik mnozenia : " + result;

                //Place your code here
            }
            else
            {
                Result[2] = null;
            }
        }

        private void Check_divide_CheckedChanged(object sender, EventArgs e)
        {
            if (Check_divide.Checked)
            {
                int Val1 = Get_value(Text_val1);
                int Val2 = Get_value(Text_val2);
                int result = Val1 / Val2;
                Result[3] = "Wynik dzielenia : " + result;

                //Place your code here
            }
            else
            {
                Result[3] = null;
            }
        }

        private void Button_calc_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach(string result in Result)
            {
                if(result != null)
                {
                    listBox1.Items.Add(result);
                }
                
            }
        }

        private int Get_value(TextBox text)
        {
            return int.Parse(text.Text); ;
        }
    }
}
