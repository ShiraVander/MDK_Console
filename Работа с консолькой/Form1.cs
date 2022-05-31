using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Работа_с_консолькой
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //1

            DateTime now = DateTime.Now;
            Console.WriteLine("*Silence is golden*");
            Console.WriteLine($"Дата и время: {now:f}");
            Console.WriteLine("Хозяшева Наталья");

            Console.WriteLine("*");
            Console.WriteLine("**");
            Console.WriteLine("***");
            Console.WriteLine("****");
            Console.WriteLine("*****");

            Console.WriteLine("A A A A A A A A");
            Console.WriteLine("A A A A A A A A");
            Console.WriteLine("A A A A A A A A");
            Console.WriteLine("A A A A A A A A");
            Console.WriteLine("A A A A A A A A");

            Console.WriteLine("*           *           *");
            Console.WriteLine("  *       *   *       *  ");
            Console.WriteLine("    *   *       *   *    ");
            Console.WriteLine("      *           *      ");

            int u = 1 + 2 - 4;
            Console.WriteLine(u);


            //2

            int i = 1 / 2 + 1 / 4;
            Console.WriteLine("7.  1/2 + 1/4");
            Console.WriteLine(i);
            Console.WriteLine("");

            int ii = (2 + 4 * 3) * (2 - 3 * 3) + (2 * 2);
            Console.WriteLine("8.  (a+4b)(a-3b) + a^2; При a = 2; b = 3");
            Console.WriteLine(ii);
            Console.WriteLine("");

            int w = -2;
            int ww = 5;
            int o = Math.Abs(-2);
            Console.WriteLine("9.  |x| + x^5; Если  x = -2");
            Console.WriteLine(o + Math.Pow(w, ww));
            Console.WriteLine("");

            double qq = 1.7;
            double yy = Convert.ToDouble(((qq + 1) * (qq + 1)) + 3 * (qq + 1));
            Console.WriteLine("10.  (x+1)^2 + 3(x+1); При a) x = 1.7; б) x = 3");
            Console.WriteLine(yy);

            double q = 3;
            double y = Convert.ToDouble(((q + 1) * (q + 1)) + 3 * (q + 1));
            Console.WriteLine(y);
            Console.WriteLine("");

            double t = -2.34;
            double p = Math.Abs(t - 5);
            double iii = Math.Sin(t);
            double r = Math.Cos(2 * t);
            double yu = Math.Sqrt(t*t + 2014 )* r - 3;
            double qwe = ((p - iii) / 3) + yu;
            Console.WriteLine("11.  |x-5| - x^4 * cos 1/x; При x = 3.6");
            Console.WriteLine(qwe);
            Console.WriteLine("");

            double nn = 3.6;
            double yp = nn - 2;
            double op = Math.Pow(2.71, yp);
            double il = Math.Abs(Math.Sin(nn));
            double nmb = Math.Pow(nn, 4);
            double sdf = Math.Cos(1 / nn);
            Console.WriteLine("12.  e^x-2 + |sin(x)| - x^4 * cos 1/x;  При x = 3.6");
            Console.WriteLine(op + il - nmb * sdf);
            Console.WriteLine("");

            double u1 = 0.1;
            double u2 = 0.2;
            double bnb = 1 + u2;
            double bn = Math.Pow(bnb, 1 / 5);
            double poi = (Math.Pow(u2, 2) * Math.Pow(Math.Sin(1), 3) * (1 + u1)) / 1;
            Console.WriteLine("13.  5√(x^2 + b) - (b^2sin^3(x+a)) / x;  При a=0.1, b = 0.2, x = 1");
            Console.WriteLine(bn - poi);
            Console.WriteLine("");
        }
    }
}
