namespace RutaSmart.UI.Rutas
{
    partial class Rutas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelForm = new Panel();
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            txtNombre = new TextBox();
            label4 = new Label();
            cmbRepartidor = new ComboBox();
            label5 = new Label();
            txtZona = new TextBox();
            btnGuardar = new Button();
            this.btnLimpiar = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel3 = new Panel();
            label6 = new Label();
            this.btnModificar = new Button();
            btnEliminar = new Button();
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Repartidor = new DataGridViewTextBoxColumn();
            Zona = new DataGridViewTextBoxColumn();
            panelForm.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panelForm
            // 
            panelForm.BackColor = Color.WhiteSmoke;
            panelForm.Controls.Add(tableLayoutPanel1);
            panelForm.Dock = DockStyle.Top;
            panelForm.Location = new Point(0, 0);
            panelForm.Name = "panelForm";
            panelForm.Size = new Size(800, 180);
            panelForm.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 180);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 270);
            panel1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel2, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 18F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 82F));
            tableLayoutPanel1.Size = new Size(800, 180);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 5);
            label1.Name = "label1";
            label1.Size = new Size(141, 21);
            label1.TabIndex = 0;
            label1.Text = "Gestion de  Rutas";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(this.btnLimpiar);
            panel2.Controls.Add(txtZona);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(btnGuardar);
            panel2.Controls.Add(cmbRepartidor);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txtNombre);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(142, 36);
            panel2.Name = "panel2";
            panel2.Size = new Size(515, 140);
            panel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(20, 20);
            label2.Name = "label2";
            label2.Size = new Size(27, 21);
            label2.TabIndex = 0;
            label2.Text = "ID";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(53, 22);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(174, 24);
            label3.Name = "label3";
            label3.Size = new Size(112, 21);
            label3.TabIndex = 2;
            label3.Text = "Nombre Ruta";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(306, 26);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(185, 23);
            txtNombre.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(20, 67);
            label4.Name = "label4";
            label4.Size = new Size(91, 21);
            label4.TabIndex = 4;
            label4.Text = "Repartidor";
            // 
            // cmbRepartidor
            // 
            cmbRepartidor.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRepartidor.FormattingEnabled = true;
            cmbRepartidor.Location = new Point(117, 67);
            cmbRepartidor.Name = "cmbRepartidor";
            cmbRepartidor.Size = new Size(121, 23);
            cmbRepartidor.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(259, 69);
            label5.Name = "label5";
            label5.Size = new Size(49, 21);
            label5.TabIndex = 6;
            label5.Text = "Zona";
            // 
            // txtZona
            // 
            txtZona.Location = new Point(327, 69);
            txtZona.Name = "txtZona";
            txtZona.Size = new Size(164, 23);
            txtZona.TabIndex = 7;
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.Left;
            btnGuardar.AutoSize = true;
            btnGuardar.BackColor = Color.SteelBlue;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(20, 109);
            btnGuardar.Margin = new Padding(145, 3, 3, 3);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(100, 26);
            btnGuardar.TabIndex = 2;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.AutoSize = true;
            this.btnLimpiar.BackColor = Color.DarkGray;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatStyle = FlatStyle.Flat;
            this.btnLimpiar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.btnLimpiar.ForeColor = Color.White;
            this.btnLimpiar.Location = new Point(138, 109);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new Size(100, 26);
            this.btnLimpiar.TabIndex = 8;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(panel3, 0, 0);
            tableLayoutPanel2.Controls.Add(dataGridView1, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel2.Size = new Size(800, 270);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnEliminar);
            panel3.Controls.Add(this.btnModificar);
            panel3.Controls.Add(label6);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(794, 48);
            panel3.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(35, 14);
            label6.Name = "label6";
            label6.Size = new Size(134, 21);
            label6.TabIndex = 0;
            label6.Text = "Listado de Rutas";
            // 
            // btnModificar
            // 
            this.btnModificar.AutoSize = true;
            this.btnModificar.BackColor = Color.OrangeRed;
            this.btnModificar.FlatStyle = FlatStyle.Flat;
            this.btnModificar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.btnModificar.ForeColor = Color.White;
            this.btnModificar.Location = new Point(531, 10);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new Size(100, 30);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            btnEliminar.AutoSize = true;
            btnEliminar.BackColor = Color.Fuchsia;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(661, 10);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(100, 30);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, Nombre, Repartidor, Zona });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 57);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(794, 210);
            dataGridView1.TabIndex = 1;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre Ruta";
            Nombre.Name = "Nombre";
            // 
            // Repartidor
            // 
            Repartidor.HeaderText = "Repartidor";
            Repartidor.Name = "Repartidor";
            // 
            // Zona
            // 
            Zona.HeaderText = "Zona / Area";
            Zona.Name = "Zona";
            // 
            // Rutas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(panelForm);
            Name = "Rutas";
            Text = "Rutas";
            panelForm.ResumeLayout(false);
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelForm;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Panel panel2;
        private TextBox textBox1;
        private Label label2;
        private ComboBox cmbRepartidor;
        private Label label4;
        private TextBox txtNombre;
        private Label label3;
        private TextBox txtZona;
        private Label label5;
        private Button btnGuardar;
        private Button btnLimpiar;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel3;
        private Button btnModificar;
        private Label label6;
        private Button btnEliminar;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Repartidor;
        private DataGridViewTextBoxColumn Zona;
    }
}