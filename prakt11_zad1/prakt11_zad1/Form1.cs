using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prakt11_zad1
{
    public partial class Form1 : Form
    {
        Student student = new Student();
        public Form1()
        {
            InitializeComponent();
            textBox2.Text = student.GetEat().ToString();
            numericUpDown1.Value = student.rost;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = student.zad(double.Parse(textBox3.Text), double.Parse(textBox2.Text)).ToString();
        }
    }
}
