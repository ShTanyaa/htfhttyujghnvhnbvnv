using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace robot
{
    public partial class Form1 : Form
    {

        class robot
        {
            public int kollife;



            public int getlife()
            {
                return kollife;
            }
            public void min(int a)
            {
                Random rn1 = new Random();
                kollife = a;
                kollife = rn1.Next(0, (a * 70 / 100));
            }
            public void kol(int a, int k)
            {
                if (k == a / 2)
                {
                    kollife = kollife + 30;
                }
                else if (k == a * 0.7)
                {
                    kollife += 20;
                }
                else if (k >= a / 2 && k < a * 0.7)
                {
                    kollife += 40;
                }
                else if (k < a / 2 && k > 0)
                {
                    kollife += 50;
                }
                else if (k == 0)
                {
                    kollife += 100;
                }
            }
        }
    
    public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            robot robot1 = new robot();
            robot robot2 = new robot();
            robot robot3 = new robot();
            Random rn = new Random();
            int b = rn.Next(0, 100);
            robot1.min(b);
            robot1.kollife = Convert.ToInt32(textBox1.Text);
            label1.Text =" Количество жизней робота1 в начале игры " +robot1.kollife;
            robot2.kollife = Convert.ToInt32(textBox2.Text);
            label7.Text = " Количество жизней робота2 в начале игры " +robot2.kollife;
            robot3.kollife = Convert.ToInt32(textBox3.Text);
            label9.Text =" Количество жизней робота3 в начале игры " +robot3.kollife;
            int a = robot1.kollife;
            robot1.min(robot1.kollife);
            label2.Text = "Количество жизней робота1 в конце игры " +Convert.ToString(robot1.getlife());
            robot2.kol(a, robot1.kollife);
            label6.Text = "Количество жизней робота2 в конце игры " + Convert.ToString(robot2.getlife());
            robot3.kol(a, robot1.kollife);
            label8.Text ="Количество жизней робота3 в конце игры " +Convert.ToString(robot3.getlife());
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}  


