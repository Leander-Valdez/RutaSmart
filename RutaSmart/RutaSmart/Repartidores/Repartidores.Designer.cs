namespace RutaSmart.UI.Repartidores
{
    partial class Repartidores
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
            components = new System.ComponentModel.Container();
            paneltop = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            btnLimpiar = new Button();
            btnGuardar = new Button();
            label1 = new Label();
            cmbEstado = new ComboBox();
            label5 = new Label();
            txtNombre = new TextBox();
            label4 = new Label();
            txtTelefono = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            panelBottom = new Panel();
            tableLayoutPanel2 = new TableLayoutPanel();
            label6 = new Label();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            errorProvider1 = new ErrorProvider(components);
            btnActualizar = new Button();
            paneltop.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panelBottom.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // paneltop
            // 
            paneltop.Controls.Add(tableLayoutPanel1);
            paneltop.Dock = DockStyle.Top;
            paneltop.Location = new Point(0, 0);
            paneltop.Name = "paneltop";
            paneltop.Size = new Size(800, 190);
            paneltop.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.White;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(800, 190);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(btnActualizar);
            panel1.Controls.Add(btnLimpiar);
            panel1.Controls.Add(btnGuardar);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(cmbEstado);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtTelefono);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(54, 7);
            panel1.Name = "panel1";
            panel1.Size = new Size(692, 175);
            panel1.TabIndex = 0;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.DimGray;
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(150, 132);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(100, 30);
            btnLimpiar.TabIndex = 9;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.SteelBlue;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(29, 132);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(100, 30);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.WhiteSmoke;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(13, 13);
            label1.Name = "label1";
            label1.Size = new Size(192, 21);
            label1.TabIndex = 0;
            label1.Text = "Gestion de Repartidores";
            // 
            // cmbEstado
            // 
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Items.AddRange(new object[] { "Disponible", "En Ruta", "Inactivo" });
            cmbEstado.Location = new Point(382, 88);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(134, 23);
            cmbEstado.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(302, 90);
            label5.Name = "label5";
            label5.Size = new Size(61, 21);
            label5.TabIndex = 6;
            label5.Text = "Estado";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(108, 92);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(179, 23);
            txtNombre.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(29, 94);
            label4.Name = "label4";
            label4.Size = new Size(73, 21);
            label4.TabIndex = 4;
            label4.Text = "Nombre";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(315, 55);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(201, 23);
            txtTelefono.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(232, 57);
            label3.Name = "label3";
            label3.Size = new Size(77, 21);
            label3.TabIndex = 2;
            label3.Text = "Telefono";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(72, 55);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(39, 57);
            label2.Name = "label2";
            label2.Size = new Size(27, 21);
            label2.TabIndex = 0;
            label2.Text = "ID";
            // 
            // panelBottom
            // 
            panelBottom.BackColor = Color.White;
            panelBottom.Controls.Add(tableLayoutPanel2);
            panelBottom.Dock = DockStyle.Fill;
            panelBottom.Location = new Point(0, 190);
            panelBottom.Name = "panelBottom";
            panelBottom.Size = new Size(800, 296);
            panelBottom.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(label6, 0, 0);
            tableLayoutPanel2.Controls.Add(panel2, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 26.7806911F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 73.21931F));
            tableLayoutPanel2.Size = new Size(800, 296);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Top;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(3, 0);
            label6.Name = "label6";
            label6.Padding = new Padding(20);
            label6.Size = new Size(794, 61);
            label6.TabIndex = 0;
            label6.Text = "Listado de  Repartidores";
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 82);
            panel2.Name = "panel2";
            panel2.Size = new Size(794, 211);
            panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, Nombre, Telefono, Estado });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(794, 211);
            dataGridView1.TabIndex = 0;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            // 
            // Telefono
            // 
            Telefono.HeaderText = "Telefono";
            Telefono.Name = "Telefono";
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.Name = "Estado";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.Coral;
            btnActualizar.FlatAppearance.BorderSize = 0;
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnActualizar.ForeColor = Color.White;
            btnActualizar.Location = new Point(273, 132);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(100, 30);
            btnActualizar.TabIndex = 10;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // Repartidores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 486);
            Controls.Add(panelBottom);
            Controls.Add(paneltop);
            Name = "Repartidores";
            Text = "Repartidores";
            paneltop.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelBottom.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel paneltop;
        private Panel panelBottom;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private ComboBox cmbEstado;
        private Label label5;
        private TextBox txtNombre;
        private Label label4;
        private TextBox txtTelefono;
        private Label label3;
        private TextBox textBox1;
        private Label label2;
        private Button btnGuardar;
        private Button btnLimpiar;
        private TableLayoutPanel tableLayoutPanel2;
        private ErrorProvider errorProvider1;
        private Label label6;
        private Panel panel2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewTextBoxColumn Estado;
        private Button btnActualizar;
    }
}