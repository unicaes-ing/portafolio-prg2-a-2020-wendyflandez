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
    public partial class Ejercicio3 : Form
    {
        public Ejercicio3()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double total, por1, por2, por3;
            total = Convert.ToDouble(txt1.Text) + Convert.ToDouble(txt2.Text) + Convert.ToDouble(txt3.Text);
            txtTotal.Text = String.Format("{0:C2}", total);
            por1 = (Convert.ToDouble(txt1.Text) / total) * 100;
            txtp1.Text = String.Format("{0:N2}", por1 + "%");
            por2 = (Convert.ToDouble(txt2.Text) / total) * 100;
            txtp2.Text = String.Format("{0:N2}", por2 + "%");
            por3 = (Convert.ToDouble(txt3.Text) / total) * 100;
            txtp3.Text = String.Format("{0:N2}", por3 + "%");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txt1.Clear();
            txt2.Clear();
            txt3.Clear();
            txtp1.Clear();
            txtp2.Clear();
            txtp3.Clear();
            txtTotal.Clear();
            txt1.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
