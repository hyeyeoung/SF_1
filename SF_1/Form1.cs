using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace SF_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); // -> Form1.designe.cs로 이동
            string[] StringArr = new string[10];
            StringArr[0] = ("동해 물과 백두산이".IndexOf("백두산")).ToString();
            StringArr[1] = ("토요일에 먹는 토마토".LastIndexOf("토")).ToString();
            StringArr[2] = ("질서있는 퇴장".Contains("퇴")).ToString();
            StringArr[3] = ("그 사람의 그림자는 그랬다.".Replace("그", "이"));
            StringArr[4] = ("삼성 갤럭시".Insert(3, "애플 "));
            StringArr[5] = ("오늘은 왠지 더 배고프다".Remove(7,1));
            String[] tmp = "이름,나이,전화번호".Split(',');
            StringArr[6] = tmp[0];
            StringArr[7] = tmp[1];
            StringArr[8] = tmp[2];
            StringArr[9] = "우리 나라 만세".Substring(3, 2);

            // ---------------------------------------
            textBox_print.Text = StringArr[0]+"\r\n";
            textBox_print.Text += StringArr[1] + "\r\n";
            textBox_print.Text += StringArr[2] + "\r\n";
            textBox_print.Text += StringArr[3] + "\r\n";
            textBox_print.Text += StringArr[4] + "\r\n";
            textBox_print.Text += StringArr[5] + "\r\n";
            textBox_print.Text += StringArr[6] + "\r\n";
            textBox_print.Text += StringArr[7] + "\r\n";
            textBox_print.Text += StringArr[8] + "\r\n";
            textBox_print.Text += StringArr[9] + "\r\n";

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}