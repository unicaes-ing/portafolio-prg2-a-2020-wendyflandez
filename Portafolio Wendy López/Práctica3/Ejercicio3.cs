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
    public partial class Ejercicio3 : Form
    {
        public Ejercicio3()
        {
            InitializeComponent();
        }

        private void btnLanzar_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            const int cantidad = 5000;
            int c = 0;
            lstLanzamientos.Items.Clear();
            for (int i = 1; i <= 5000; i++)
            {
                int num = r.Next(1, 7);
                lstLanzamientos.Items.Add(num);
                if (num == 6) c++;
            }
            MessageBox.Show("Se obtuvo " + c + " veces el 6");
        }
    }
}
