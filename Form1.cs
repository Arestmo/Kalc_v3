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

        String result = "";

        private void Check_add_CheckedChanged(object sender, EventArgs e)
        {
            if(Check_add.Checked)
            {
                int val1 = Get_value(Text_val1);
                int val2 = Get_value(Text_val2);

                //Place your code here
            }
        }

        private void Check_substract_CheckedChanged(object sender, EventArgs e)
        {
            if(Check_substract.Checked)
            {
                int val1 = Get_value(Text_val1);
                int val2 = Get_value(Text_val2);

                //Place your code here
            }
        }

        private void Check_multiply_CheckedChanged(object sender, EventArgs e)
        {
            if (Check_multiply.Checked)
            {
                int val1 = Get_value(Text_val1);
                int val2 = Get_value(Text_val2);

                //Place your code here
            }
        }

        private void Check_divide_CheckedChanged(object sender, EventArgs e)
        {
            if (Check_divide.Checked)
            {
                int val1 = Get_value(Text_val1);
                int val2 = Get_value(Text_val2);

                //Place your code here
            }
        }

        private void Button_calc_Click(object sender, EventArgs e)
        {
            Result_text.Text = result;
        }

        private int Get_value(TextBox text)
        {
            int value = int.Parse(text.Text);
            return value;
        }
    }
}
