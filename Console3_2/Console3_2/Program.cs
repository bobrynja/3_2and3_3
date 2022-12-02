using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console3_2
{
    class Program
    {
        static double f(double x, double a)
        {

            if (x < a) return 0;
            else if (x > a) return Math.Round((x - a) / (x + a), 4);
            else return 1;

        }
        static void f(double x, double a, out double y)
        {
            if (x < a) y=0;
            else if (x > a) y= Math.Round((x - a) / (x + a), 4);
            else y=1;
        }


        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите нижнюю границу: ");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите верхнюю границу: ");
                double b = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите шаг: ");
                double h = Convert.ToDouble(Console.ReadLine());
                if (a > b)
                {
                    Console.WriteLine("Нижняя граница должна быть меньше верхней");
                }
                else if (h == 0) Console.WriteLine("Шаг не может быть равен 0");
                else
                {
                    int n = Convert.ToInt32((b - a) / h);
                    double x = a;
                    for (int i = 0; i < n; i++)
                    {
                        
                        Console.Write(x + " - ");
                        Console.WriteLine(f(x, a) + ";");
                        x += h;

                    }

                    double result = 0.0;
                    f(x, a, out result);
                    Console.WriteLine("Перезагрузка метода");
                    x = a;
                    for (int i = 0; i < n; i++)
                    {

                        Console.Write(x + " - ");
                        f(x, a, out result);
                        Console.WriteLine(result + ";");
                        x += h;

                    }
                }



            }
            catch { Console.WriteLine("Некорректный ввод данных"); }
            Console.ReadKey();
        }
    }
}

