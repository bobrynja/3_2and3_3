using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static double f(double x, double a)
        {
            if (x < a) return 0;
            else if (x > a) return Math.Round((x - a) / (x + a), 4);
            else
            {
                return 1;

            }
        }
        static void f(double x, double a, out double y)
        {
            if (x < a) y = 0;
            else if (x > a) y = Math.Round((x - a) / (x + a), 4);
            else y = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                double a = Convert.ToDouble(textBox1.Text);
                double b = Convert.ToDouble(textBox2.Text);
                double h = Convert.ToDouble(textBox3.Text);
                if (a > b) MessageBox.Show("Нижняя граница должна быть меньше верхней");
                else if (h == 0) MessageBox.Show("Шаг не может быть равен 0");
                else
                {
                    textBox4.Text = "";
                    int n = Convert.ToInt32((b - a) / h);
                    double x = a;
                    for (int i = 0; i < n; i++)
                    {
                        textBox4.Text += x;
                        textBox4.Text += " - ";
                        textBox4.Text += f(x, a); textBox4.Text += ";"; textBox4.Text += Environment.NewLine;
                        x += h;
                    }
                    textBox5.Text = "";
                    x = a;
                    double result = 0.0;
                    for (int i = 0; i < n; i++)
                    {
                        textBox5.Text += x;
                        textBox5.Text += " - ";
                        f(x, a, out result);
                        textBox5.Text += result; textBox5.Text += ";"; textBox5.Text += Environment.NewLine;
                        x += h;
                    }

                }
            }
            catch { MessageBox.Show("Некорректный ввод данных"); }
        }
    }
    }

