namespace RutaSmart
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelHeader = new Panel();
            label2 = new Label();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            inicioToolStripMenuItem = new ToolStripMenuItem();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            pedidosToolStripMenuItem = new ToolStripMenuItem();
            repartidoresToolStripMenuItem = new ToolStripMenuItem();
            rutasToolStripMenuItem = new ToolStripMenuItem();
            reportesToolStripMenuItem = new ToolStripMenuItem();
            label3 = new Label();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            Clientes = new DataGridViewTextBoxColumn();
            Dirección = new DataGridViewTextBoxColumn();
            Repartidor = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel3 = new Panel();
            label8 = new Label();
            label7 = new Label();
            panel4 = new Panel();
            label10 = new Label();
            label9 = new Label();
            panel1 = new Panel();
            label6 = new Label();
            label5 = new Label();
            panel2 = new Panel();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panelHeader.SuspendLayout();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.RoyalBlue;
            panelHeader.Controls.Add(label2);
            panelHeader.Controls.Add(label1);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(801, 80);
            panelHeader.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 41);
            label2.Name = "label2";
            label2.Size = new Size(308, 21);
            label2.TabIndex = 1;
            label2.Text = "Sistema de logística y control de entrega";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(142, 32);
            label1.TabIndex = 0;
            label1.Text = "Ruta Smart";
            // 
            // menuStrip1
            // 
            menuStrip1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            menuStrip1.Items.AddRange(new ToolStripItem[] { inicioToolStripMenuItem, clientesToolStripMenuItem, pedidosToolStripMenuItem, repartidoresToolStripMenuItem, rutasToolStripMenuItem, reportesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 80);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(801, 25);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            inicioToolStripMenuItem.Size = new Size(54, 21);
            inicioToolStripMenuItem.Text = "Inicio";
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(69, 21);
            clientesToolStripMenuItem.Text = "Clientes";
            // 
            // pedidosToolStripMenuItem
            // 
            pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            pedidosToolStripMenuItem.Size = new Size(69, 21);
            pedidosToolStripMenuItem.Text = "Pedidos";
            // 
            // repartidoresToolStripMenuItem
            // 
            repartidoresToolStripMenuItem.Name = "repartidoresToolStripMenuItem";
            repartidoresToolStripMenuItem.Size = new Size(98, 21);
            repartidoresToolStripMenuItem.Text = "Repartidores";
            // 
            // rutasToolStripMenuItem
            // 
            rutasToolStripMenuItem.Name = "rutasToolStripMenuItem";
            rutasToolStripMenuItem.Size = new Size(54, 21);
            rutasToolStripMenuItem.Text = "Rutas";
            // 
            // reportesToolStripMenuItem
            // 
            reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            reportesToolStripMenuItem.Size = new Size(74, 21);
            reportesToolStripMenuItem.Text = "Reportes";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Top;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(0, 105);
            label3.Margin = new Padding(3, 20, 3, 0);
            label3.Name = "label3";
            label3.Padding = new Padding(20, 25, 10, 10);
            label3.Size = new Size(248, 56);
            label3.TabIndex = 2;
            label3.Text = "Resumen de Entregas - Hoy";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Top;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(0, 261);
            label4.Name = "label4";
            label4.Padding = new Padding(20, 30, 0, 10);
            label4.Size = new Size(155, 61);
            label4.TabIndex = 4;
            label4.Text = "Ultimos Pedidos";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Clientes, Dirección, Repartidor, Estado });
            dataGridView1.Dock = DockStyle.Top;
            dataGridView1.Location = new Point(0, 322);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(801, 200);
            dataGridView1.TabIndex = 5;
            // 
            // Clientes
            // 
            Clientes.HeaderText = "Clientes";
            Clientes.Name = "Clientes";
            // 
            // Dirección
            // 
            Dirección.HeaderText = "Dirección";
            Dirección.Name = "Dirección";
            // 
            // Repartidor
            // 
            Repartidor.HeaderText = "Repartidor";
            Repartidor.Name = "Repartidor";
            // 
            // Estado
            // 
            Estado.HeaderText = " Estado";
            Estado.Name = "Estado";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(panel3, 1, 0);
            tableLayoutPanel1.Controls.Add(panel4, 2, 0);
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 161);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(801, 100);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.None;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label7);
            panel3.Location = new Point(296, 10);
            panel3.Name = "panel3";
            panel3.Size = new Size(205, 80);
            panel3.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(83, 42);
            label8.Name = "label8";
            label8.Size = new Size(28, 32);
            label8.TabIndex = 1;
            label8.Text = "0";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(34, 12);
            label7.Name = "label7";
            label7.Size = new Size(133, 21);
            label7.TabIndex = 0;
            label7.Text = "Pedidos en Ruta";
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.None;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(label10);
            panel4.Controls.Add(label9);
            panel4.Location = new Point(564, 10);
            panel4.Name = "panel4";
            panel4.Size = new Size(205, 80);
            panel4.TabIndex = 2;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(80, 40);
            label10.Name = "label10";
            label10.Size = new Size(28, 32);
            label10.TabIndex = 1;
            label10.Text = "0";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(20, 11);
            label9.Name = "label9";
            label9.Size = new Size(155, 21);
            label9.TabIndex = 0;
            label9.Text = "Pedidos Entegados";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Location = new Point(30, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(205, 80);
            panel1.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(77, 40);
            label6.Name = "label6";
            label6.Size = new Size(28, 32);
            label6.TabIndex = 1;
            label6.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(31, 12);
            label5.Name = "label5";
            label5.Size = new Size(145, 20);
            label5.TabIndex = 0;
            label5.Text = "Pedidos Pendientes";
            // 
            // panel2
            // 
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 524);
            panel2.Name = "panel2";
            panel2.Size = new Size(801, 80);
            panel2.TabIndex = 7;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(192, 0, 192);
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(502, 19);
            button4.Name = "button4";
            button4.Size = new Size(120, 35);
            button4.TabIndex = 3;
            button4.Text = "Salir";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click_1;
            // 
            // button3
            // 
            button3.BackColor = Color.OrangeRed;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(344, 19);
            button3.Name = "button3";
            button3.Size = new Size(120, 35);
            button3.TabIndex = 2;
            button3.Text = "Generar Reportes";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.DimGray;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(184, 19);
            button2.Name = "button2";
            button2.Size = new Size(120, 35);
            button2.TabIndex = 1;
            button2.Text = "Nuevo Cliente";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.RoyalBlue;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(35, 19);
            button1.Name = "button1";
            button1.Size = new Size(120, 35);
            button1.TabIndex = 0;
            button1.Text = "Nuevo Pedido";
            button1.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(801, 604);
            Controls.Add(panel2);
            Controls.Add(dataGridView1);
            Controls.Add(label4);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label3);
            Controls.Add(menuStrip1);
            Controls.Add(panelHeader);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "RutaSmart";
            WindowState = FormWindowState.Maximized;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelHeader;
        private Label label1;
        private Label label2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem inicioToolStripMenuItem;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem pedidosToolStripMenuItem;
        private ToolStripMenuItem repartidoresToolStripMenuItem;
        private ToolStripMenuItem rutasToolStripMenuItem;
        private ToolStripMenuItem reportesToolStripMenuItem;
        private Label label3;
        private Label label4;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Clientes;
        private DataGridViewTextBoxColumn Dirección;
        private DataGridViewTextBoxColumn Repartidor;
        private DataGridViewTextBoxColumn Estado;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Panel panel3;
        private Panel panel4;
        private Panel panel2;
        private Button button2;
        private Button button1;
        private Button button3;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label8;
        private Label label9;
        private Label label10;
        private Button button4;
    }
}
