namespace RutaSmart.UI.Clientes
{
    partial class Clientes
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
            panel1 = new Panel();
            panelForm = new Panel();
            btnLimpiar = new Button();
            btnGuardar = new Button();
            txtEmail = new TextBox();
            label6 = new Label();
            txtTelefono = new TextBox();
            label5 = new Label();
            txtNombre = new TextBox();
            label4 = new Label();
            txtDireccion = new TextBox();
            label3 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            errorProvider1 = new ErrorProvider(components);
            label7 = new Label();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            Dirección = new DataGridViewTextBoxColumn();
            button1 = new Button();
            panel1.SuspendLayout();
            panelForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(panelForm);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 0;
            // 
            // panelForm
            // 
            panelForm.BackColor = Color.WhiteSmoke;
            panelForm.BorderStyle = BorderStyle.FixedSingle;
            panelForm.Controls.Add(btnLimpiar);
            panelForm.Controls.Add(btnGuardar);
            panelForm.Controls.Add(txtEmail);
            panelForm.Controls.Add(label6);
            panelForm.Controls.Add(txtTelefono);
            panelForm.Controls.Add(label5);
            panelForm.Controls.Add(txtNombre);
            panelForm.Controls.Add(label4);
            panelForm.Controls.Add(txtDireccion);
            panelForm.Controls.Add(label3);
            panelForm.Controls.Add(label2);
            panelForm.Controls.Add(textBox1);
            panelForm.Location = new Point(48, 48);
            panelForm.Name = "panelForm";
            panelForm.Size = new Size(700, 185);
            panelForm.TabIndex = 1;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.OrangeRed;
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(173, 144);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(100, 30);
            btnLimpiar.TabIndex = 11;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = SystemColors.Highlight;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.FlatStyle = FlatStyle.Flat;
            btnGuardar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(48, 145);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(100, 30);
            btnGuardar.TabIndex = 10;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(115, 105);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(249, 23);
            txtEmail.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(47, 101);
            label6.Name = "label6";
            label6.Size = new Size(53, 21);
            label6.TabIndex = 8;
            label6.Text = "Email";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(436, 64);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(172, 23);
            txtTelefono.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(341, 62);
            label5.Name = "label5";
            label5.Size = new Size(77, 21);
            label5.TabIndex = 6;
            label5.Text = "Telefono";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(131, 60);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(188, 23);
            txtNombre.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(45, 59);
            label4.Name = "label4";
            label4.Size = new Size(73, 21);
            label4.TabIndex = 4;
            label4.Text = "Nombre";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(365, 22);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(213, 23);
            txtDireccion.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(247, 20);
            label3.Name = "label3";
            label3.Size = new Size(83, 21);
            label3.TabIndex = 2;
            label3.Text = "Direccion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(45, 16);
            label2.Name = "label2";
            label2.Size = new Size(25, 21);
            label2.TabIndex = 1;
            label2.Text = "Id";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(90, 18);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(20, 20);
            label1.Name = "label1";
            label1.Size = new Size(181, 25);
            label1.TabIndex = 0;
            label1.Text = "Gestion de Clientes";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(33, 252);
            label7.Name = "label7";
            label7.Size = new Size(185, 25);
            label7.TabIndex = 2;
            label7.Text = "Listados de Clientes";
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Location = new Point(4, 285);
            panel2.Name = "panel2";
            panel2.Size = new Size(793, 153);
            panel2.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, Nombre, Email, Column1, Telefono, Dirección });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(793, 153);
            dataGridView1.TabIndex = 0;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            // 
            // Email
            // 
            Email.HeaderText = "Email";
            Email.Name = "Email";
            // 
            // Column1
            // 
            Column1.HeaderText = "Column1";
            Column1.Name = "Column1";
            // 
            // Telefono
            // 
            Telefono.HeaderText = "Telefono";
            Telefono.Name = "Telefono";
            // 
            // Dirección
            // 
            Dirección.HeaderText = "Dirección";
            Dirección.Name = "Dirección";
            // 
            // button1
            // 
            button1.BackColor = Color.Gray;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(648, 247);
            button1.Name = "button1";
            button1.Size = new Size(100, 30);
            button1.TabIndex = 4;
            button1.Text = "Modificar";
            button1.UseVisualStyleBackColor = false;
            // 
            // Clientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "Clientes";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelForm.ResumeLayout(false);
            panelForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panelForm;
        private Label label2;
        private TextBox textBox1;
        private TextBox txtTelefono;
        private Label label5;
        private TextBox txtNombre;
        private Label label4;
        private TextBox txtDireccion;
        private Label label3;
        private TextBox txtEmail;
        private Label label6;
        private Button btnLimpiar;
        private Button btnGuardar;
        private ErrorProvider errorProvider1;
        private Label label7;
        private Panel panel2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewTextBoxColumn Dirección;
        private Button button1;
    }
}