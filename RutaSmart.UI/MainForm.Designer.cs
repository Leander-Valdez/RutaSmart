namespace RutaSmart.UI
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
            toolStripMenuItem1 = new ToolStripMenuItem();
            rutasToolStripMenuItem = new ToolStripMenuItem();
            repartidoresToolStripMenuItem = new ToolStripMenuItem();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            label4 = new Label();
            label3 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panelPendientes = new FlowLayoutPanel();
            label5 = new Label();
            lblPendientes = new Label();
            panelEnRuta = new FlowLayoutPanel();
            label6 = new Label();
            lblEnRuta = new Label();
            panelEntregados = new FlowLayoutPanel();
            label7 = new Label();
            lblEntregados = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            panelHeader.SuspendLayout();
            menuStrip1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panelPendientes.SuspendLayout();
            panelEnRuta.SuspendLayout();
            panelEntregados.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.BlueViolet;
            panelHeader.Controls.Add(label2);
            panelHeader.Controls.Add(label1);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1184, 29);
            panelHeader.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(0, 2);
            label2.Name = "label2";
            label2.Size = new Size(269, 21);
            label2.TabIndex = 1;
            label2.Text = "RutaSmart — Sistema de Logística";
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.WhiteSmoke;
            menuStrip1.Items.AddRange(new ToolStripItem[] { inicioToolStripMenuItem, clientesToolStripMenuItem, pedidosToolStripMenuItem, toolStripMenuItem1, rutasToolStripMenuItem, repartidoresToolStripMenuItem });
            menuStrip1.Location = new Point(0, 29);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RenderMode = ToolStripRenderMode.System;
            menuStrip1.Size = new Size(1184, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            inicioToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            inicioToolStripMenuItem.Size = new Size(49, 20);
            inicioToolStripMenuItem.Text = "Inicio";
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(63, 20);
            clientesToolStripMenuItem.Text = "Clientes";
            // 
            // pedidosToolStripMenuItem
            // 
            pedidosToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            pedidosToolStripMenuItem.Size = new Size(62, 20);
            pedidosToolStripMenuItem.Text = "Pedidos";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(12, 20);
            // 
            // rutasToolStripMenuItem
            // 
            rutasToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rutasToolStripMenuItem.Name = "rutasToolStripMenuItem";
            rutasToolStripMenuItem.Size = new Size(50, 20);
            rutasToolStripMenuItem.Text = "Rutas";
            // 
            // repartidoresToolStripMenuItem
            // 
            repartidoresToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            repartidoresToolStripMenuItem.Name = "repartidoresToolStripMenuItem";
            repartidoresToolStripMenuItem.Size = new Size(91, 20);
            repartidoresToolStripMenuItem.Text = "Repartidores";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 53);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(1184, 608);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1178, 115);
            panel1.TabIndex = 0;
            // 
            // label4
            // 
            label4.Dock = DockStyle.Top;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(0, 47);
            label4.Name = "label4";
            label4.Size = new Size(1178, 21);
            label4.TabIndex = 1;
            label4.Text = "Control de  Entregas";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Top;
            label3.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(0, 0);
            label3.Name = "label3";
            label3.Size = new Size(1178, 47);
            label3.TabIndex = 0;
            label3.Text = "RutaSmart";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.None;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(panel2, 0, 0);
            tableLayoutPanel2.Controls.Add(panel3, 1, 0);
            tableLayoutPanel2.Controls.Add(panel4, 0, 1);
            tableLayoutPanel2.Controls.Add(panel5, 1, 1);
            tableLayoutPanel2.Location = new Point(272, 124);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(640, 358);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = Color.FromArgb(91, 155, 255);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label8);
            panel2.Location = new Point(15, 22);
            panel2.Margin = new Padding(10);
            panel2.Name = "panel2";
            panel2.Size = new Size(289, 135);
            panel2.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.None;
            panel3.BackColor = Color.FromArgb(91, 155, 255);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(label10);
            panel3.Location = new Point(335, 22);
            panel3.Margin = new Padding(10);
            panel3.Name = "panel3";
            panel3.Size = new Size(289, 135);
            panel3.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.None;
            panel4.BackColor = Color.FromArgb(91, 155, 255);
            panel4.Controls.Add(label13);
            panel4.Controls.Add(label12);
            panel4.Location = new Point(15, 201);
            panel4.Margin = new Padding(10);
            panel4.Name = "panel4";
            panel4.Size = new Size(289, 135);
            panel4.TabIndex = 2;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.None;
            panel5.BackColor = Color.FromArgb(91, 155, 255);
            panel5.Controls.Add(label15);
            panel5.Controls.Add(label14);
            panel5.Location = new Point(335, 201);
            panel5.Margin = new Padding(10);
            panel5.Name = "panel5";
            panel5.Size = new Size(289, 135);
            panel5.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Anchor = AnchorStyles.None;
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.Controls.Add(panelPendientes);
            flowLayoutPanel1.Controls.Add(panelEnRuta);
            flowLayoutPanel1.Controls.Add(panelEntregados);
            flowLayoutPanel1.Location = new Point(435, 519);
            flowLayoutPanel1.Margin = new Padding(0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(313, 55);
            flowLayoutPanel1.TabIndex = 2;
            flowLayoutPanel1.WrapContents = false;
            // 
            // panelPendientes
            // 
            panelPendientes.AutoSize = true;
            panelPendientes.Controls.Add(label5);
            panelPendientes.Controls.Add(lblPendientes);
            panelPendientes.FlowDirection = FlowDirection.TopDown;
            panelPendientes.Location = new Point(20, 0);
            panelPendientes.Margin = new Padding(20, 0, 20, 0);
            panelPendientes.Name = "panelPendientes";
            panelPendientes.Size = new Size(71, 55);
            panelPendientes.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(3, 0);
            label5.Name = "label5";
            label5.Size = new Size(51, 40);
            label5.TabIndex = 0;
            label5.Text = "24";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPendientes
            // 
            lblPendientes.AutoSize = true;
            lblPendientes.Location = new Point(3, 40);
            lblPendientes.Name = "lblPendientes";
            lblPendientes.Size = new Size(65, 15);
            lblPendientes.TabIndex = 1;
            lblPendientes.Text = "Pendientes";
            lblPendientes.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelEnRuta
            // 
            panelEnRuta.AutoSize = true;
            panelEnRuta.Controls.Add(label6);
            panelEnRuta.Controls.Add(lblEnRuta);
            panelEnRuta.FlowDirection = FlowDirection.TopDown;
            panelEnRuta.Location = new Point(131, 0);
            panelEnRuta.Margin = new Padding(20, 0, 20, 0);
            panelEnRuta.Name = "panelEnRuta";
            panelEnRuta.Size = new Size(50, 55);
            panelEnRuta.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Gray;
            label6.Location = new Point(3, 0);
            label6.Name = "label6";
            label6.Size = new Size(34, 40);
            label6.TabIndex = 1;
            label6.Text = "8";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblEnRuta
            // 
            lblEnRuta.AutoSize = true;
            lblEnRuta.Location = new Point(3, 40);
            lblEnRuta.Name = "lblEnRuta";
            lblEnRuta.Size = new Size(44, 15);
            lblEnRuta.TabIndex = 2;
            lblEnRuta.Text = "En ruta";
            lblEnRuta.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelEntregados
            // 
            panelEntregados.AutoSize = true;
            panelEntregados.Controls.Add(label7);
            panelEntregados.Controls.Add(lblEntregados);
            panelEntregados.FlowDirection = FlowDirection.TopDown;
            panelEntregados.Location = new Point(221, 0);
            panelEntregados.Margin = new Padding(20, 0, 20, 0);
            panelEntregados.Name = "panelEntregados";
            panelEntregados.Size = new Size(72, 55);
            panelEntregados.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.Highlight;
            label7.Location = new Point(3, 0);
            label7.Name = "label7";
            label7.Size = new Size(51, 40);
            label7.TabIndex = 2;
            label7.Text = "12";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblEntregados
            // 
            lblEntregados.AutoSize = true;
            lblEntregados.Location = new Point(3, 40);
            lblEntregados.Name = "lblEntregados";
            lblEntregados.Size = new Size(66, 15);
            lblEntregados.TabIndex = 3;
            lblEntregados.Text = "Entregados";
            lblEntregados.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(95, 56);
            label8.Name = "label8";
            label8.Size = new Size(90, 30);
            label8.TabIndex = 0;
            label8.Text = "Clientes";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(77, 97);
            label9.Name = "label9";
            label9.Size = new Size(136, 21);
            label9.TabIndex = 1;
            label9.Text = "Registro Y gestion";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(94, 54);
            label10.Name = "label10";
            label10.Size = new Size(90, 30);
            label10.TabIndex = 0;
            label10.Text = "Pedidos";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(79, 97);
            label11.Name = "label11";
            label11.Size = new Size(141, 21);
            label11.TabIndex = 1;
            label11.Text = "Control de Pedidos";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(104, 60);
            label12.Name = "label12";
            label12.Size = new Size(68, 30);
            label12.TabIndex = 0;
            label12.Text = "Rutas";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(77, 100);
            label13.Name = "label13";
            label13.Size = new Size(127, 21);
            label13.TabIndex = 1;
            label13.Text = "Gestion de Rutas";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(79, 60);
            label14.Name = "label14";
            label14.Size = new Size(138, 30);
            label14.TabIndex = 0;
            label14.Text = "Repartidores";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.Location = new Point(79, 100);
            label15.Name = "label15";
            label15.Size = new Size(155, 21);
            label15.TabIndex = 1;
            label15.Text = "Asignacion Y Control";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            BackColor = Color.White;
            Controls.Add(tableLayoutPanel1);
            Controls.Add(menuStrip1);
            Controls.Add(panelHeader);
            MainMenuStrip = menuStrip1;
            MinimumSize = new Size(1200, 700);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            panelPendientes.ResumeLayout(false);
            panelPendientes.PerformLayout();
            panelEnRuta.ResumeLayout(false);
            panelEnRuta.PerformLayout();
            panelEntregados.ResumeLayout(false);
            panelEntregados.PerformLayout();
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
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem rutasToolStripMenuItem;
        private ToolStripMenuItem repartidoresToolStripMenuItem;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Label label3;
        private Label label4;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel panelPendientes;
        private Label label5;
        private Label lblPendientes;
        private FlowLayoutPanel panelEnRuta;
        private Label label6;
        private Label lblEnRuta;
        private FlowLayoutPanel panelEntregados;
        private Label label7;
        private Label lblEntregados;
        private Label label9;
        private Label label8;
        private Label label11;
        private Label label10;
        private Label label13;
        private Label label12;
        private Label label15;
        private Label label14;
    }
}

