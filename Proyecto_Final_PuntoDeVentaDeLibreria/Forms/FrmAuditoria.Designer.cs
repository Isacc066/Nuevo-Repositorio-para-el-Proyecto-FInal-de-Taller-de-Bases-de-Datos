namespace Proyecto_Final_PuntoDeVentaDeLibreria.Forms
{
    partial class FrmAuditoria
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
            dgvAuditoria = new DataGridView();
            dtpFechaInicio = new DateTimePicker();
            dtpFechaFin = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            txtIdProducto = new TextBox();
            label3 = new Label();
            lblContador = new Label();
            btnBuscarProducto = new Button();
            btnMostrarTodos = new Button();
            btnFiltrarAccion = new Button();
            btnFiltrarFecha = new Button();
            cboAccion = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvAuditoria).BeginInit();
            SuspendLayout();
            // 
            // dgvAuditoria
            // 
            dgvAuditoria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAuditoria.Location = new Point(665, 28);
            dgvAuditoria.Name = "dgvAuditoria";
            dgvAuditoria.RowHeadersWidth = 51;
            dgvAuditoria.Size = new Size(780, 383);
            dgvAuditoria.TabIndex = 0;
            // 
            // dtpFechaInicio
            // 
            dtpFechaInicio.Location = new Point(44, 97);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.Size = new Size(250, 27);
            dtpFechaInicio.TabIndex = 1;
            // 
            // dtpFechaFin
            // 
            dtpFechaFin.Location = new Point(331, 97);
            dtpFechaFin.Name = "dtpFechaFin";
            dtpFechaFin.Size = new Size(250, 27);
            dtpFechaFin.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(151, 54);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 3;
            label1.Text = "Fecha Inicio";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(441, 54);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 4;
            label2.Text = "Fecha Fin";
            // 
            // txtIdProducto
            // 
            txtIdProducto.Location = new Point(211, 209);
            txtIdProducto.Name = "txtIdProducto";
            txtIdProducto.Size = new Size(125, 27);
            txtIdProducto.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(225, 169);
            label3.Name = "label3";
            label3.Size = new Size(82, 20);
            label3.TabIndex = 6;
            label3.Text = "IdProducto";
            // 
            // lblContador
            // 
            lblContador.AutoSize = true;
            lblContador.Location = new Point(44, 169);
            lblContador.Name = "lblContador";
            lblContador.Size = new Size(71, 20);
            lblContador.TabIndex = 7;
            lblContador.Text = "Contador";
            // 
            // btnBuscarProducto
            // 
            btnBuscarProducto.Location = new Point(198, 253);
            btnBuscarProducto.Name = "btnBuscarProducto";
            btnBuscarProducto.Size = new Size(138, 29);
            btnBuscarProducto.TabIndex = 8;
            btnBuscarProducto.Text = "Buscar Producto";
            btnBuscarProducto.UseVisualStyleBackColor = true;
            btnBuscarProducto.Click += btnBuscarProducto_Click;
            // 
            // btnMostrarTodos
            // 
            btnMostrarTodos.Location = new Point(441, 359);
            btnMostrarTodos.Name = "btnMostrarTodos";
            btnMostrarTodos.Size = new Size(118, 29);
            btnMostrarTodos.TabIndex = 9;
            btnMostrarTodos.Text = "Mostrar Todos";
            btnMostrarTodos.UseVisualStyleBackColor = true;
            btnMostrarTodos.Click += btnMostrarTodos_Click;
            // 
            // btnFiltrarAccion
            // 
            btnFiltrarAccion.Location = new Point(441, 253);
            btnFiltrarAccion.Name = "btnFiltrarAccion";
            btnFiltrarAccion.Size = new Size(118, 29);
            btnFiltrarAccion.TabIndex = 10;
            btnFiltrarAccion.Text = "Filtrar Accion";
            btnFiltrarAccion.UseVisualStyleBackColor = true;
            btnFiltrarAccion.Click += btnFiltrarAccion_Click;
            // 
            // btnFiltrarFecha
            // 
            btnFiltrarFecha.Location = new Point(441, 301);
            btnFiltrarFecha.Name = "btnFiltrarFecha";
            btnFiltrarFecha.Size = new Size(118, 29);
            btnFiltrarFecha.TabIndex = 11;
            btnFiltrarFecha.Text = "Filtrar Fecha";
            btnFiltrarFecha.UseVisualStyleBackColor = true;
            btnFiltrarFecha.Click += btnFiltrarFecha_Click;
            // 
            // cboAccion
            // 
            cboAccion.FormattingEnabled = true;
            cboAccion.Location = new Point(430, 209);
            cboAccion.Name = "cboAccion";
            cboAccion.Size = new Size(151, 28);
            cboAccion.TabIndex = 12;
            // 
            // FrmAuditoria
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1457, 450);
            Controls.Add(cboAccion);
            Controls.Add(btnFiltrarFecha);
            Controls.Add(btnFiltrarAccion);
            Controls.Add(btnMostrarTodos);
            Controls.Add(btnBuscarProducto);
            Controls.Add(lblContador);
            Controls.Add(label3);
            Controls.Add(txtIdProducto);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dtpFechaFin);
            Controls.Add(dtpFechaInicio);
            Controls.Add(dgvAuditoria);
            Name = "FrmAuditoria";
            Text = "FrmAuditoria";
            Load += FrmAuditoria_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAuditoria).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvAuditoria;
        private DateTimePicker dtpFechaInicio;
        private DateTimePicker dtpFechaFin;
        private Label label1;
        private Label label2;
        private TextBox txtIdProducto;
        private Label label3;
        private Label lblContador;
        private Button btnBuscarProducto;
        private Button btnMostrarTodos;
        private Button btnFiltrarAccion;
        private Button btnFiltrarFecha;
        private ComboBox cboAccion;
    }
}