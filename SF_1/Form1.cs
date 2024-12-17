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

            string message = "멈추지 않는 한 얼마나 천천히 가는지는 중요하지 않다.-공자";

            // 1. "-공자" 부분 삭제
            string onePractice = message.Remove(message.LastIndexOf("-공자"));

            // 2. "얼마나, 천천히, 가는지" 단어 나누고 배열에 요소로 각각 저장
            string[] splitSpaceBar;
            int start = message.IndexOf("얼마나");
            int end = message.LastIndexOf("는");
            string twoPractice = message.Substring(start, end-start);
            splitSpaceBar = twoPractice.Split(' ');

            // 3. .- 제거, " "을 ,로 변경
            int findidx = message.IndexOf(".");
            string threePractice = message.Remove(findidx,1);
            findidx = message.IndexOf("-");
            threePractice = message.Remove(findidx, 1);
            threePractice = threePractice.Replace(' ', ',');

            textBox_print.Text = onePractice + "\r\n";
            textBox_print.Text += splitSpaceBar[0] + "\r\n";
            textBox_print.Text += splitSpaceBar[1] + "\r\n";
            textBox_print.Text += splitSpaceBar[2] + "\r\n";
            textBox_print.Text += threePractice + "\r\n";



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