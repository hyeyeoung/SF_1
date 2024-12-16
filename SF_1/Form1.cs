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
            byte inClassChildren = 10;
            short inClassTeachers = 2;
            int citizenNumber = 5000;

            float biasPercent = 10;
            double learningRate = 0.5;
            decimal sumAllPeaopleheight = 500000000;

            textBox_print.Text = inClassChildren.GetType().ToString() + "  inClassChildren " + inClassChildren + "\r\n";
            textBox_print.Text += inClassTeachers.GetType().ToString() + "  inClassTeachers " + inClassTeachers + "\r\n";
            textBox_print.Text += citizenNumber.GetType().ToString() + "  citizenNumber " + citizenNumber + "\r\n";
            textBox_print.Text += biasPercent.GetType().ToString() + "  biasPercent " + biasPercent + "\r\n";
            textBox_print.Text += learningRate.GetType().ToString() + "  learningRate " + learningRate + "\r\n";
            textBox_print.Text += sumAllPeaopleheight.GetType().ToString() + "  sumAllPeaopleheight " + sumAllPeaopleheight + "\r\n";
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
