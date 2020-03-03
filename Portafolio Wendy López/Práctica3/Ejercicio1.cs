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
    public partial class Ejercicio1 : Form
    {
        public Ejercicio1()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            int num;
            if (int.TryParse(txtNumero.Text, out num))
            {
                lstTabla.Items.Clear();
                for (int i = 1; i <= 10; i++)
                {
                    lstTabla.Items.Add(num + " * " + i + " = " + num * i);
                }
            }
            else
            {
                MessageBox.Show("Ingrese un número.");
            }
        }
    }
}
