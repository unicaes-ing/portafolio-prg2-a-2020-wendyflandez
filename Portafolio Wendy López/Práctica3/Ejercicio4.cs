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
    public partial class Ejercicio4 : Form
    {
        public Ejercicio4()
        {
            InitializeComponent();
        }

        private void Ejercicio4_Load(object sender, EventArgs e)
        {
            dataGridView1.Size = new Size(210, 220);
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ScrollBars = ScrollBars.None;
            dataGridView1.ColumnCount = 10;
            dataGridView1.ColumnHeadersVisible = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            Random r = new Random();
            for (int f = 0; f < 10; f++)
            {
                dataGridView1.Rows.Add();
                for (int c = 0; c < 10; c++)
                {
                    dataGridView1.Rows[f].Cells[c].Value = r.Next(10, 100);
                }
            }
            dataGridView1.ClearSelection();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(txtNumBus.Text);
            for (int f = 0; f < 10; f++)
            {
                for (int c = 0; c < 10; c++)
                {
                    string valor;
                    valor = dataGridView1.Rows[f].Cells[c].Value.ToString();
                    if (num == Convert.ToInt32(valor))
                    {
                        dataGridView1.Rows[f].Cells[c].Style.BackColor = Color.Aqua;
                    }
                }
            }
        }
    }
}
