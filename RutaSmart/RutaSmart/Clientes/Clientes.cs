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
        private int filaSeleccionada = -1;
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                filaSeleccionada = e.RowIndex;

                txtNombre.Text = dataGridView1?.Rows?[e.RowIndex]?.Cells[1]?.Value?.ToString();
                txtEmail.Text = dataGridView1?.Rows?[e.RowIndex]?.Cells[2]?.Value?.ToString();
                txtTelefono.Text = dataGridView1?.Rows[e.RowIndex].Cells[3].Value?.ToString();
                txtDireccion.Text = dataGridView1?.Rows[e.RowIndex]?.Cells[4]?.Value?.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (filaSeleccionada == -1)
            {
                MessageBox.Show("Seleccione un cliente primero");
                return;
            }

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

            if (!valido) return;

            dataGridView1.Rows[filaSeleccionada].Cells[1].Value = txtNombre.Text;
            dataGridView1.Rows[filaSeleccionada].Cells[2].Value = txtEmail.Text;
            dataGridView1.Rows[filaSeleccionada].Cells[3].Value = txtTelefono.Text;
            dataGridView1.Rows[filaSeleccionada].Cells[4].Value = txtDireccion.Text;

            MessageBox.Show("Cliente actualizado");

            filaSeleccionada = -1;
            btnLimpiar.PerformClick();
        }
    }
}
