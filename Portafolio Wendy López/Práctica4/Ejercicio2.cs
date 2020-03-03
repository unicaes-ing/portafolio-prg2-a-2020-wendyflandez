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
    public partial class Ejercicio2 : Form
    {
        public Ejercicio2()
        {
            InitializeComponent();
        }
        public static int Buscar(int numBus, ListBox lista)
        {
            int cont = 0;
            foreach (int n in lista.Items)
            {
                if (n == numBus) cont++;
            }
            return cont;
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                int num = Convert.ToInt32(txtNum.Text);
                lstNumeros.Items.Add(num);
                txtNum.Clear();
                txtNumBusc.Clear();
                txtNum.Focus();
            }
            catch (Exception)
            {
                MessageBox.Show("Ingrese un número");
                txtNum.SelectAll();
                txtNum.Focus();
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                int num = Convert.ToInt32(txtNumBusc.Text);
                int cant = Buscar(num, lstNumeros);
                MessageBox.Show(" Se encuentra " + cant + " veces");
            }
            catch (Exception)
            {
                MessageBox.Show("Ingrese un numero");
                txtNumBusc.SelectAll();
                txtNumBusc.Focus();
            }
        }
    }
}
