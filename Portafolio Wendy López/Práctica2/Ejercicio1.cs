using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Práctica2
{
    public partial class Ejercicio1 : Form
    {
        public Ejercicio1()
        {
            InitializeComponent();
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(txtNumero.Text) == 1)
                {
                    lblRomano.Text = String.Format("Equivale a I en romano");
                }
                else if (Convert.ToInt32(txtNumero.Text) == 2)
                {
                    lblRomano.Text = String.Format("Equivale a II en romano");
                }
                else if (Convert.ToInt32(txtNumero.Text) == 3)
                {
                    lblRomano.Text = String.Format("Equivale a III en romano");
                }
                else if (Convert.ToInt32(txtNumero.Text) == 4)
                {
                    lblRomano.Text = String.Format("Equivale a IV en romano");
                }
                else if (Convert.ToInt32(txtNumero.Text) == 5)
                {
                    lblRomano.Text = String.Format("Equivale a V en romano");
                }
                else if (Convert.ToInt32(txtNumero.Text) == 6)
                {
                    lblRomano.Text = String.Format("Equivale a VI en romano");
                }
                else if (Convert.ToInt32(txtNumero.Text) == 7)
                {
                    lblRomano.Text = String.Format("Equivale a VII en romano");
                }
                else if (Convert.ToInt32(txtNumero.Text) == 8)
                {
                    lblRomano.Text = String.Format("Equivale a VIII en romano");
                }
                else if (Convert.ToInt32(txtNumero.Text) == 9)
                {
                    lblRomano.Text = String.Format("Equivale a IX en romano");
                }
                else
                {
                    lblRomano.Text = String.Format("Equivale a X en romano");
                }
            }
            catch (Exception)
            {
                txtNumero.Clear();
                txtNumero.Focus();
                MessageBox.Show("Ingrese un número del 1 al 10");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
