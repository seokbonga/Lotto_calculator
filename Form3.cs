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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(numericUpDown1.Value.ToString());
            int num2 = Convert.ToInt32(numericUpDown2.Value.ToString());

            string choice = comboBox1.Text;
            int res=0;

            if(choice.Equals("+"))
            {
                res = num1 + num2;
                label1.Text = string.Format("결과 : {0} + {1} = {2} ",num1,num2,res);
            }
            else if (choice.Equals("-"))
            {
                res = num1 - num2;
                label1.Text = string.Format("결과 : {0} - {1} = {2} ", num1, num2, res);
            }
            else if (choice.Equals("*"))
            {
                res = num1 * num2;
                label1.Text = string.Format("결과 : {0} * {1} = {2} ", num1, num2, res);
            }
            else if (choice.Equals("/"))
            {
                res = num1 / num2;
                label1.Text = string.Format("결과 : {0} / {1} = {2} ", num1, num2, res);
            }
        }
    }
}
