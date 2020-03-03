﻿using System;
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
    public partial class Ejercicio2 : Form
    {
        public Ejercicio2()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            lstAlfabeto.ForeColor = Color.Salmon;
            lstAlfabeto.Font = new Font("Arial", 20, FontStyle.Bold | FontStyle.Italic);
            lstAlfabeto.Items.Clear();
            for (char letra = 'A'; letra <= 'Z'; letra++)
            {
                lstAlfabeto.Items.Add(letra);
            }
            lstAlfabeto.Items.Insert(14, 'Ñ');
        }
    }
}
