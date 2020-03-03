using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Práctica1
{
    public partial class Ejercicio4 : Form
    {
        public Ejercicio4()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double subtotal, total, imp;
            subtotal = Convert.ToInt32(txtCantidad.Text) * Convert.ToDouble(txtPrecio.Text);
            txtSubtotal.Text = String.Format("{0:C2}", subtotal);
            imp = subtotal * 0.13;
            txtImpuesto.Text = String.Format("{0:C2}", imp);
            total = subtotal + imp;
            txtTotal.Text = String.Format("{0:C2}", total);
        }

        private void btnNueva_Click(object sender, EventArgs e)
        {
            txtPrecio.Clear();
            txtCantidad.Clear();
            txtSubtotal.Clear();
            txtImpuesto.Clear();
            txtTotal.Clear();
            cboLibro.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
