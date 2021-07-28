using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_1_WindowsForms
{
    public partial class Form1 : Form
    {
        double p;
        double M = 0, D, D1 = 0, Q, V;
        double count = 0;
        string mas = " ";
        string m = " ";
        string d = " ";
        string q = " ";
        string v = " ";


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox7.Clear();
            textBox9.Clear();
            this.chart1.Series[0].Points.Clear();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            double a = 0, b = 10 /*Class1.j*/, h = 0.1, y, x;
            Class1 r = new Class1();
            textBox1.Text = r.Array();
            textBox2.Text = r.MathExp().ToString();
            textBox3.Text = r.Dispersion().ToString();
            textBox4.Text = r.Mean_square_deviation().ToString();
            textBox5.Text = r.Сoefficient_of_variation().ToString();
            textBox7.Text = r.periodicity().ToString();
            textBox9.Text = r.Pearson_test().ToString();
            r.uniformity();
            textBox6.Text = r.Correlation_Coef().ToString();
            // b = int.Parse(textBox6.Text);
            this.chart1.Series[0].Points.Clear();

            y = a;
            for (int i = 0; i < b; i++)
            {
                x = Class1.Arr[i];
                this.chart1.Series[0].Points.AddXY(y + 0.1, x);
                y += h;
            }
        }
    }
}
