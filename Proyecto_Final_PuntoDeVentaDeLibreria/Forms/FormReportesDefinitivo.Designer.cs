namespace Proyecto_Final_PuntoDeVentaDeLibreria.Forms
{
    partial class FormReportesDefinitivo
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.Label lblFin;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.Button btnReporteProductos;
        private System.Windows.Forms.Button btnReporteUsuarios;
        private System.Windows.Forms.DataGridView dgvReporteProductos;
        private System.Windows.Forms.DataGridView dgvReporteUsuarios;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblInicio = new Label();
            lblFin = new Label();
            dtpInicio = new DateTimePicker();
            dtpFin = new DateTimePicker();
            btnReporteProductos = new Button();
            btnReporteUsuarios = new Button();
            dgvReporteProductos = new DataGridView();
            dgvReporteUsuarios = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvReporteProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvReporteUsuarios).BeginInit();
            SuspendLayout();
            // 
            // lblInicio
            // 
            lblInicio.AutoSize = true;
            lblInicio.Location = new Point(25, 20);
            lblInicio.Name = "lblInicio";
            lblInicio.Size = new Size(90, 20);
            lblInicio.TabIndex = 0;
            lblInicio.Text = "Fecha inicio:";
            // 
            // lblFin
            // 
            lblFin.AutoSize = true;
            lblFin.Location = new Point(25, 60);
            lblFin.Name = "lblFin";
            lblFin.Size = new Size(83, 20);
            lblFin.TabIndex = 1;
            lblFin.Text = "Fecha final:";
            // 
            // dtpInicio
            // 
            dtpInicio.Location = new Point(120, 15);
            dtpInicio.Name = "dtpInicio";
            dtpInicio.Size = new Size(250, 27);
            dtpInicio.TabIndex = 2;
            // 
            // dtpFin
            // 
            dtpFin.Location = new Point(120, 55);
            dtpFin.Name = "dtpFin";
            dtpFin.Size = new Size(250, 27);
            dtpFin.TabIndex = 3;
            // 
            // btnReporteProductos
            // 
            btnReporteProductos.Location = new Point(400, 20);
            btnReporteProductos.Name = "btnReporteProductos";
            btnReporteProductos.Size = new Size(200, 30);
            btnReporteProductos.TabIndex = 4;
            btnReporteProductos.Text = "Reporte de productos";
            btnReporteProductos.Click += btnReporteProductos_Click;
            // 
            // btnReporteUsuarios
            // 
            btnReporteUsuarios.Location = new Point(400, 60);
            btnReporteUsuarios.Name = "btnReporteUsuarios";
            btnReporteUsuarios.Size = new Size(200, 30);
            btnReporteUsuarios.TabIndex = 5;
            btnReporteUsuarios.Text = "Reporte de vendedores";
            btnReporteUsuarios.Click += btnReporteUsuarios_Click;
            // 
            // dgvReporteProductos
            // 
            dgvReporteProductos.ColumnHeadersHeight = 29;
            dgvReporteProductos.Location = new Point(25, 110);
            dgvReporteProductos.Name = "dgvReporteProductos";
            dgvReporteProductos.RowHeadersWidth = 51;
            dgvReporteProductos.Size = new Size(750, 200);
            dgvReporteProductos.TabIndex = 6;
            // 
            // dgvReporteUsuarios
            // 
            dgvReporteUsuarios.ColumnHeadersHeight = 29;
            dgvReporteUsuarios.Location = new Point(25, 330);
            dgvReporteUsuarios.Name = "dgvReporteUsuarios";
            dgvReporteUsuarios.RowHeadersWidth = 51;
            dgvReporteUsuarios.Size = new Size(750, 200);
            dgvReporteUsuarios.TabIndex = 7;
            // 
            // FormReportesDefinitivo
            // 
            ClientSize = new Size(800, 560);
            Controls.Add(lblInicio);
            Controls.Add(lblFin);
            Controls.Add(dtpInicio);
            Controls.Add(dtpFin);
            Controls.Add(btnReporteProductos);
            Controls.Add(btnReporteUsuarios);
            Controls.Add(dgvReporteProductos);
            Controls.Add(dgvReporteUsuarios);
            Name = "FormReportesDefinitivo";
            Text = "Reportes de Ventas";
            Load += FrmReportes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvReporteProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvReporteUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}