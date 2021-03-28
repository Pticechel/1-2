using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лабраб_1_2_
{
    public partial class Form1 : Form
    {
        double v, b, F;
        public Form1()
        {
            InitializeComponent();
        }

       
        private void Form1_Load(object sender, MouseEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_MouseMove_1(object sender, MouseEventArgs e)
        {
            Text = string.Format("Координаты: {0}, {1}", e.X, e.Y);
            textBox1.Text = (e.X + e.Y).ToString();
            textBox2.Text = (e.X).ToString();
            textBox3.Text = (e.Y).ToString();
            F = Math.Sin((v * e.X) / e.Y) * e.X + Math.Sqrt(Math.Abs(b * b * b)) - Math.Abs(e.X * e.X + Math.Cos(e.Y));
            textBox6.Text = F.ToString();

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            v = Convert.ToDouble(textBox4.Text);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            b = Convert.ToDouble(textBox5.Text);
        }

        }
    }

