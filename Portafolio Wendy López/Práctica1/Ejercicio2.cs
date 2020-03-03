﻿using System;
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
    public partial class Ejercicio2 : Form
    {
        public Ejercicio2()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            txtBinario.Text = Convert.ToString(Convert.ToInt32(txtDecimal.Text), 2);
            txtOctal.Text = Convert.ToString(Convert.ToInt32(txtDecimal.Text), 8);
            txtHexadecimal.Text = Convert.ToString(Convert.ToInt32(txtDecimal.Text), 16);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtDecimal.Clear();
            txtBinario.Clear();
            txtOctal.Clear();
            txtHexadecimal.Clear();
            txtDecimal.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtDecimal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
