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
            cboAccion = new ComboBox();
            txtIdProducto = new TextBox();
            lblContador = new Label();
            label1 = new Label();
            btnMostrarTodos = new Button();
            btnFiltrarAccion = new Button();
            btnFiltrarFecha = new Button();
            btnBuscarProducto = new Button();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvAuditoria).BeginInit();
            SuspendLayout();
            // 
            // dgvAuditoria
            // 
            dgvAuditoria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAuditoria.Location = new Point(708, 124);
            dgvAuditoria.Name = "dgvAuditoria";
            dgvAuditoria.RowHeadersWidth = 51;
            dgvAuditoria.Size = new Size(704, 383);
            dgvAuditoria.TabIndex = 0;
            // 
            // dtpFechaInicio
            // 
            dtpFechaInicio.Location = new Point(21, 67);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.Size = new Size(250, 27);
            dtpFechaInicio.TabIndex = 1;
            // 
            // dtpFechaFin
            // 
            dtpFechaFin.Location = new Point(303, 67);
            dtpFechaFin.Name = "dtpFechaFin";
            dtpFechaFin.Size = new Size(250, 27);
            dtpFechaFin.TabIndex = 2;
            // 
            // cboAccion
            // 
            cboAccion.FormattingEnabled = true;
            cboAccion.Location = new Point(334, 124);
            cboAccion.Name = "cboAccion";
            cboAccion.Size = new Size(151, 28);
            cboAccion.TabIndex = 3;
            // 
            // txtIdProducto
            // 
            txtIdProducto.Location = new Point(190, 190);
            txtIdProducto.Name = "txtIdProducto";
            txtIdProducto.Size = new Size(125, 27);
            txtIdProducto.TabIndex = 4;
            // 
            // lblContador
            // 
            lblContador.AutoSize = true;
            lblContador.Location = new Point(21, 143);
            lblContador.Name = "lblContador";
            lblContador.Size = new Size(71, 20);
            lblContador.TabIndex = 5;
            lblContador.Text = "Contador";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(190, 143);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 6;
            label1.Text = "IdUsuario";
            // 
            // btnMostrarTodos
            // 
            btnMostrarTodos.Location = new Point(325, 188);
            btnMostrarTodos.Name = "btnMostrarTodos";
            btnMostrarTodos.Size = new Size(160, 29);
            btnMostrarTodos.TabIndex = 7;
            btnMostrarTodos.Text = "Mostar Todos";
            btnMostrarTodos.UseVisualStyleBackColor = true;
            btnMostrarTodos.Click += btnMostrarTodos_Click;
            // 
            // btnFiltrarAccion
            // 
            btnFiltrarAccion.Location = new Point(325, 253);
            btnFiltrarAccion.Name = "btnFiltrarAccion";
            btnFiltrarAccion.Size = new Size(160, 29);
            btnFiltrarAccion.TabIndex = 8;
            btnFiltrarAccion.Text = "Filtrar Accion";
            btnFiltrarAccion.UseVisualStyleBackColor = true;
            btnFiltrarAccion.Click += btnFiltrarAccion_Click;
            // 
            // btnFiltrarFecha
            // 
            btnFiltrarFecha.Location = new Point(325, 317);
            btnFiltrarFecha.Name = "btnFiltrarFecha";
            btnFiltrarFecha.Size = new Size(160, 29);
            btnFiltrarFecha.TabIndex = 9;
            btnFiltrarFecha.Text = "Filtrar Fecha";
            btnFiltrarFecha.UseVisualStyleBackColor = true;
            btnFiltrarFecha.Click += btnFiltrarFecha_Click;
            // 
            // btnBuscarProducto
            // 
            btnBuscarProducto.Location = new Point(134, 253);
            btnBuscarProducto.Name = "btnBuscarProducto";
            btnBuscarProducto.Size = new Size(160, 29);
            btnBuscarProducto.TabIndex = 10;
            btnBuscarProducto.Text = "Buscar Producto";
            btnBuscarProducto.UseVisualStyleBackColor = true;
            btnBuscarProducto.Click += btnBuscarProducto_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(104, 27);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 11;
            label2.Text = "Fecha Inicio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(390, 27);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 12;
            label3.Text = "Fecha Fin";
            // 
            // FrmAuditoria
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1459, 543);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnBuscarProducto);
            Controls.Add(btnFiltrarFecha);
            Controls.Add(btnFiltrarAccion);
            Controls.Add(btnMostrarTodos);
            Controls.Add(label1);
            Controls.Add(lblContador);
            Controls.Add(txtIdProducto);
            Controls.Add(cboAccion);
            Controls.Add(dtpFechaFin);
            Controls.Add(dtpFechaInicio);
            Controls.Add(dgvAuditoria);
            Name = "FrmAuditoria";
            Text = "FrmAuditoria";
            ((System.ComponentModel.ISupportInitialize)dgvAuditoria).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvAuditoria;
        private DateTimePicker dtpFechaInicio;
        private DateTimePicker dtpFechaFin;
        private ComboBox cboAccion;
        private TextBox txtIdProducto;
        private Label lblContador;
        private Label label1;
        private Button btnMostrarTodos;
        private Button btnFiltrarAccion;
        private Button btnFiltrarFecha;
        private Button btnBuscarProducto;
        private Label label2;
        private Label label3;
    }
}