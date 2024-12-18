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

            bool myChoice = true;
            if (ThrowCoinAndMatch(myChoice))
            {
                textBox_print.Text += "승리\r\n";
            }
            else
            {
                textBox_print.Text += "패배\r\n";
            }
        }

        bool ThrowCoinAndMatch(bool x)
        {
            Random randomINT = new Random();
            int coin = randomINT.Next();
            textBox_print.Text = "내가 선택한 값: " + x.ToString() + "\r\n";
            bool randomCoinRes = coin % 2 == 1;
            textBox_print.Text += "자동 생성된 값: " + randomCoinRes.ToString() + "\r\n";

            if (x == randomCoinRes)
                return true;
            else
                return false;
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