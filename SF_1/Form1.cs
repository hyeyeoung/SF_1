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

            int[] result = dividednMod_IntegerArr(13, 5);

            textBox_print.Text = result[0].ToString() + "\r\n";
            textBox_print.Text += result[1].ToString();
        }

        int[] dividednMod_IntegerArr(int a, int b)
        {
            int[] Result = new int[2];
            Result[0] = a / b;
            Result[1] = a % b;

            return Result;
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