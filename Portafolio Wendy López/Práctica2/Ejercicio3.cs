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
    public partial class Ejercicio3 : Form
    {
        public Ejercicio3()
        {
            InitializeComponent();
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            double longi = Convert.ToDouble(txtAnterior.Text);
            double res = 0;
            if (lstDe.SelectedItem.Equals("Pulgadas"))
            {
                if (lstA.SelectedItem.Equals("Pulgadas"))
                {
                    res = longi;
                }
                else if (lstA.SelectedItem.Equals("Pies"))
                {
                    res = longi / 12;
                }
                else if (lstA.SelectedItem.Equals("Yardas"))
                {
                    res = longi / 36;
                }
                txtNueva.Text = Convert.ToString(res);
            }
            else if (lstDe.SelectedItem.Equals("Pies"))
            {
                if (lstA.SelectedItem.Equals("Pulgadas"))
                {
                    res = longi * 12;
                }
                else if (lstA.SelectedItem.Equals("Pies"))
                {
                    res = longi;
                }
                else if (lstA.SelectedItem.Equals("Yardas"))
                {
                    res = longi / 3;
                }
                txtNueva.Text = Convert.ToString(res);
            }
            else if (lstDe.SelectedItem.Equals("Yardas"))
            {
                if (lstA.SelectedItem.Equals("Pulgadas"))
                {
                    res = longi / 12;
                }
                else if (lstA.SelectedItem.Equals("Pies"))
                {
                    res = longi * 3;
                }
                else if (lstA.SelectedItem.Equals("Yardas"))
                {
                    res = longi;
                }
                txtNueva.Text = Convert.ToString(res);
            }
            else
            {
                MessageBox.Show("Debe seleccionar longitudes a convertir");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
