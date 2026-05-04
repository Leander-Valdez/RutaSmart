using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RutaSmart.UI.Clientes
{
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool valido = true;

            errorProvider1.Clear();

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                errorProvider1.SetError(txtNombre, "El nombre es obligatorio");
                valido = false;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                errorProvider1.SetError(txtEmail, "El email es obligatorio");
                valido = false;
            }
            else if (!txtEmail.Text.Contains("@"))
            {
                errorProvider1.SetError(txtEmail, "Email no válido");
                valido = false;
            }

            if (!string.IsNullOrWhiteSpace(txtTelefono.Text) && txtTelefono.Text.Length < 10)
            {
                errorProvider1.SetError(txtTelefono, "Teléfono inválido");
                valido = false;
            }


            if (valido)
            {
                MessageBox.Show("Cliente guardado correctamente");
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtEmail.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();

            errorProvider1.Clear();
        }
    }
}
