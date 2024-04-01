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
    public partial class Form5 : Form
    {
        Random random = new Random(); // 랜덤 객체 생성
        public int[] lot = new int[6]; // 뽑은 로또 번호를 저장하는 배열
        public int[] WinningLot = new int[6]; // 당첨 로또 번호를 저장하는 배열

        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void SelectNumber_Click(object sender, EventArgs e)
        {
            int n;

            for(int i=0; i<6; i++)
            {
                while(true)
                {
                    n = random.Next(1, 46); // 뽑은 로또 번호
                    if(!lot.Contains(n)) // lot배열에 n값이 곂치지않으면 lot[i]번째에 저장
                    {
                        lot[i] = n;
                        break;
                    }
                }
            }
           
            Array.Sort(lot); // lot배열 오름차순으로 정렬

            // N1~N6 레이블에 차례대로 값을 넣어줌
            N1.Text = lot[0].ToString();
            N2.Text = lot[1].ToString();
            N3.Text = lot[2].ToString();
            N4.Text = lot[3].ToString();
            N5.Text = lot[4].ToString();
            N6.Text = lot[5].ToString();

           
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close(); // 창 닫기
        }

        private void WinningResult_Click(object sender, EventArgs e)
        {
            int count = 0;
            int w;

            for (int i = 0; i < 6; i++)
            {
                while (true)
                {
                    w = random.Next(1, 46); // 당첨 로또 번호
                    if (!WinningLot.Contains(w)) // WinningLot배열에 w값이 곂치지않으면 WinningLot[i]번째에 저장
                    {
                        WinningLot[i] = w;
                        break;
                    }
                }
            }

            // W1~W6 레이블에 차례대로 값을 넣어줌
            W1.Text = WinningLot[0].ToString();
            W2.Text = WinningLot[1].ToString();
            W3.Text = WinningLot[2].ToString();
            W4.Text = WinningLot[3].ToString();
            W5.Text = WinningLot[4].ToString();
            W6.Text = WinningLot[5].ToString();


            // 값이 중복하지 않으므로
            // 반복문 두개를 통하여 각각 비교를 통해 같으면 count+1을 함
            for (int i=0; i<lot.Length; i++) 
            {
                for (int j = 0; j < WinningLot.Length; j++)
                    if (lot[i] == WinningLot[j]) count++; 
            }
            Array.Sort(WinningLot); // WinningLot배열 오름차순으로 정렬

            string a = String.Format("당첨된 번호 갯수는 {0} 개 입니다!", count.ToString());
            tboxResult.Text = a;
        }
    }
}
