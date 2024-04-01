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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            lblifResult.Text = "결과 : ";
            lblswitchResult.Text = "선택 : ";


        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number1 = Convert.ToInt32(nNumber1.Value.ToString());
            int number2 = Convert.ToInt32(nNumber2.Value.ToString()); 

            if (number1 == number2)
            {
                lblifResult.Text = String.Format("{0}숫자와 {1}숫자는 같습니다. 숫자{2}"
                    ,number1,number2,number1);               
              //  MessageBox.Show(String.Format("{0}숫자와 {1}숫자는 같습니다. 숫자{2}"
                   // , number1, number2, number1));          
            }
            else if (number1 > number2)
            {
                int res = number1 - number2;
                lblifResult.Text = String.Format("{0}숫자와 {1}숫자는 더 큽니다. 숫자{2}만큼 더 큼"
                    , number1, number2, res);
            }
            else if (number1 < number2)
            {
                int res = number2 - number1;
                lblifResult.Text = String.Format("{0}숫자와 {1}숫자는 더 작습니다. 숫자{2}만큼 더 작음"
                    , number1, number2, res);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string selectDay = cboxDay.Text;

            switch(selectDay)
            {
                case "월":
                    lblswitchResult.Text = "선택 요일은 월요일입니다.";
                    break;
                case "화":
                    lblswitchResult.Text = "선택 요일은 화요일입니다.";
                    break;
                case "수":
                    lblswitchResult.Text = "선택 요일은 수요일입니다.";
                    break;
                case "목":
                    lblswitchResult.Text = "선택 요일은 목요일입니다.";
                    break;
                case "금":
                    lblswitchResult.Text = "선택 요일은 금요일입니다.";
                    break;
                case "토":
                    lblswitchResult.Text = "선택 요일은 토요일입니다.";
                    break;
                case "일":
                    lblswitchResult.Text = "선택 요일은 일요일입니다.";
                    break;
            }
        }

        private void cboxDay_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
