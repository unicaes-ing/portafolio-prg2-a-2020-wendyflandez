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
    public partial class Ejercicio1 : Form
    {
        public Ejercicio1()
        {
            InitializeComponent();
        }
        public static double Suma(double num1, double num2, double num3, double num4)
        {
            return num1 + num2 + num3 + num4;
        }
        private void btnSumar_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(txtnum1.Text);
            double num2 = Convert.ToDouble(txtnum2.Text);
            double num3 = Convert.ToDouble(txtnum3.Text);
            double num4 = Convert.ToDouble(txtnum4.Text);
            txtSuma.Text = Suma(num1, num2, num3, num4).ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtnum1.Clear();
            txtnum2.Clear();
            txtnum3.Clear();
            txtnum4.Clear();
            txtSuma.Clear();
            txtnum1.Focus();
        }
    }
}
