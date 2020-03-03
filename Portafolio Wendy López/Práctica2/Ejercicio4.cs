using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Práctica2
{
    public partial class Ejercicio4 : Form
    {
        public Ejercicio4()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            bool validado = true;
            err.Clear();
            if (txtCorreo.TextLength <= 0)
            {
                err.SetError(txtCorreo, "Ingrese el correo electrónico.");
                validado = false;
            }
            else
            {
                string patronCorreo = @"^[^@]+@[^@]+\.[a-zA-Z]{2,}$";
                if (!Regex.IsMatch(txtCorreo.Text, patronCorreo))
                {
                    err.SetError(txtCorreo, "Ingrese correctamente el correo");
                    validado = false;
                }
            }
            if (txtContraseña.TextLength <= 0)
            {
                err.SetError(txtContraseña, "Ingrese una contraseña.");
                validado = false;
            }
            else
            {
                string patronContraseña = @"^(?=\w*\d)(?=\w*[A-Z])(?=\w*[a-z])\S{8,}$";
                if (!Regex.IsMatch(txtContraseña.Text, patronContraseña))
                {
                    err.SetError(txtContraseña, "La contraseña debe contener al menos un número, un carácter especial, una letra mayúscula y una minúscula");
                    validado = false;
                }
            }
            if (txtConfirmación.TextLength <= 0)
            {
                err.SetError(txtConfirmación, "Ingrese la confirmación de su contraseña.");
                validado = false;
            }
            else if (txtContraseña.Text == txtConfirmación.Text)
            {
                //Son iguales
            }
            else
            {
                err.SetError(txtConfirmación, "La confirmación debe ser igual a la contraseña escrita anteriormente");
                validado = false;
            }
            MessageBox.Show("Datos ingresados correctamente");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
