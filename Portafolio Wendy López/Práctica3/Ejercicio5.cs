using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Práctica3
{
    public partial class Ejercicio5 : Form
    {
        public Ejercicio5()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nom = Convert.ToString(txtNombre.Text);
            int h = Convert.ToInt32(txtHoras.Text);
            double v = Convert.ToDouble(txtValor.Text);
            double sub, tot, IVA;
            sub = h * v;
            IVA = sub * 0.13;
            tot = sub + IVA;
            dataGridView1.Rows.Add(nom, h, v, sub, IVA, tot);
            dataGridView1.ClearSelection();
            int tot1 = 0;
            for (int f = 0; f < dataGridView1.Rows.Count; f++)
            {
                tot1 += Convert.ToInt32(dataGridView1.Rows[f].Cells[3].Value);
                lblTotal.Text = string.Format("{0:C2}", tot);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtValor.Clear();
            txtHoras.Clear();
            txtNombre.Focus();
        }
    }
}
