using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RutaSmart.UI.Repartidores
{
    public partial class Repartidores : Form
    {
        private int filaSeleccionada = -1;
        public Repartidores()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool valido = true;
            errorProvider1.Clear();

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                errorProvider1.SetError(txtNombre, "Nombre obligatorio");
                valido = false;
            }

            if (cmbEstado.SelectedIndex == -1)
            {
                errorProvider1.SetError(cmbEstado, "Seleccione un estado");
                valido = false;
            }

            if (!valido) return;

            dataGridView1.Rows.Add(
                txtNombre.Text,
                txtTelefono.Text,
                cmbEstado.Text
            );

            MessageBox.Show("Repartidor guardado");

            btnLimpiar.PerformClick();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                filaSeleccionada = e.RowIndex;

                txtNombre.Text = dataGridView1?.Rows[e.RowIndex].Cells[1].Value?.ToString();
                txtTelefono.Text = dataGridView1?.Rows[e.RowIndex].Cells[2].Value?.ToString();
                cmbEstado.Text = dataGridView1?.Rows[e.RowIndex].Cells[3].Value?.ToString();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtTelefono.Clear();
            cmbEstado.SelectedIndex = -1;

            errorProvider1.Clear();
            filaSeleccionada = -1;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (filaSeleccionada == -1)
            {
                MessageBox.Show("Seleccione un repartidor");
                return;
            }

            bool valido = true;
            errorProvider1.Clear();

            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                errorProvider1.SetError(txtNombre, "Nombre obligatorio");
                valido = false;
            }

            if (!valido) return;

            dataGridView1.Rows[filaSeleccionada].Cells[1].Value = txtNombre.Text;
            dataGridView1.Rows[filaSeleccionada].Cells[2].Value = txtTelefono.Text;
            dataGridView1.Rows[filaSeleccionada].Cells[3].Value = cmbEstado.Text;

            MessageBox.Show("Repartidor actualizado");

            filaSeleccionada = -1;
            btnLimpiar.PerformClick();
        }
    }
}
