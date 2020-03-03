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
    public partial class Ejercicio1 : Form
    {
        public Ejercicio1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double promedio;
            promedio = (Convert.ToDouble(txtExamen1.Text) + Convert.ToDouble(txtExamen2.Text) + Convert.ToDouble(txtExamen3.Text)) / 3;
            txtPromedio.Text = String.Format("{0:N2}", promedio);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtExamen1.Clear();
            txtExamen2.Clear();
            txtExamen3.Clear();
            txtPromedio.Clear();
            txtExamen1.Focus();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
