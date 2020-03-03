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
    public partial class Ejercicio2 : Form
    {
        public Ejercicio2()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int cant = Convert.ToInt32(txtCantidad.Text);
            double precio = Convert.ToDouble(txtPrecio.Text);
            double sub = cant * precio;
            double total, desc;
            if (rdo0.Checked)
            {
                desc = sub * 0.0;
                total = sub - desc;
            }
            else if (rdo5.Checked)
            {
                desc = sub * 0.05;
                total = sub - desc;
            }
            else if (rdo10.Checked)
            {
                desc = sub * 0.10;
                total = sub - desc;
            }
            else if (rdo15.Checked)
            {
                desc = sub * 0.15;
                total = sub - desc;
            }
            else
            {
                desc = sub * 0.20;
                total = sub - desc;
            }
            txtDescuento.Text = String.Format("{0:C2}", desc);
            txtTotal.Text = String.Format("{0:C2}", total);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCantidad.Clear();
            txtPrecio.Clear();
            txtDescuento.Clear();
            txtTotal.Clear();
            txtCantidad.Focus();
            rdo0.Checked = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
