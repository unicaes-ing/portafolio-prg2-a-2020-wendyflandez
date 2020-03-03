using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Práctica4
{
    public partial class Ejercicio3 : Form
    {
        public Ejercicio3()
        {
            InitializeComponent();
        }
        public static int Fibonacci(int num)
        {
            int a, b, c, t;
            t = num;
            a = 0;
            b = 1;
            for (int i = 0; i < t; i++)
            {
                c = a;
                a = b;
                b = c + a;
            }
            return a;
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int num, f;
            num = Convert.ToInt32(txtNum.Text);
            f = Fibonacci(num);
            txtFibonacci.Text = string.Format("{0}", f);
        }
    }
}
