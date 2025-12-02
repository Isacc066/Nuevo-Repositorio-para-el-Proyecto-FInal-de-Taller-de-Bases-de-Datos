namespace Proyecto_Final_PuntoDeVentaDeLibreria.Forms
{
    partial class FrmReportes
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
            dgvReporte = new DataGridView();
            txtBuscarVenta = new TextBox();
            lblTotalProductosVendidos = new Label();
            lblProductoMasVendido = new Label();
            lblTotalVentasHoy = new Label();
            lblResumen = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            dtpFechaInicio = new DateTimePicker();
            dtpFechaFin = new DateTimePicker();
            dtpFechaConsulta = new DateTimePicker();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            gbEstadisticas = new GroupBox();
            btnActualizarEstadisticas = new Button();
            gbFiltros = new GroupBox();
            btnReporteCompleto = new Button();
            btnFiltrarPorFecha = new Button();
            gbConsultas = new GroupBox();
            btnBuscarVenta = new Button();
            btnConsultarFecha = new Button();
            panelBotones = new Panel();
            btnCerrar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvReporte).BeginInit();
            gbEstadisticas.SuspendLayout();
            gbFiltros.SuspendLayout();
            gbConsultas.SuspendLayout();
            panelBotones.SuspendLayout();
            SuspendLayout();
            // 
            // dgvReporte
            // 
            dgvReporte.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReporte.Location = new Point(527, 331);
            dgvReporte.Name = "dgvReporte";
            dgvReporte.RowHeadersWidth = 51;
            dgvReporte.Size = new Size(1020, 349);
            dgvReporte.TabIndex = 0;
            // 
            // txtBuscarVenta
            // 
            txtBuscarVenta.Location = new Point(16, 177);
            txtBuscarVenta.Name = "txtBuscarVenta";
            txtBuscarVenta.Size = new Size(125, 27);
            txtBuscarVenta.TabIndex = 1;
            // 
            // lblTotalProductosVendidos
            // 
            lblTotalProductosVendidos.AutoSize = true;
            lblTotalProductosVendidos.BackColor = SystemColors.ButtonFace;
            lblTotalProductosVendidos.Location = new Point(19, 68);
            lblTotalProductosVendidos.Name = "lblTotalProductosVendidos";
            lblTotalProductosVendidos.Size = new Size(50, 20);
            lblTotalProductosVendidos.TabIndex = 2;
            lblTotalProductosVendidos.Text = "label1";
            // 
            // lblProductoMasVendido
            // 
            lblProductoMasVendido.AutoSize = true;
            lblProductoMasVendido.BackColor = SystemColors.ButtonFace;
            lblProductoMasVendido.Location = new Point(226, 68);
            lblProductoMasVendido.Name = "lblProductoMasVendido";
            lblProductoMasVendido.Size = new Size(50, 20);
            lblProductoMasVendido.TabIndex = 3;
            lblProductoMasVendido.Text = "label2";
            // 
            // lblTotalVentasHoy
            // 
            lblTotalVentasHoy.AutoSize = true;
            lblTotalVentasHoy.BackColor = SystemColors.ButtonFace;
            lblTotalVentasHoy.Location = new Point(432, 68);
            lblTotalVentasHoy.Name = "lblTotalVentasHoy";
            lblTotalVentasHoy.Size = new Size(50, 20);
            lblTotalVentasHoy.TabIndex = 4;
            lblTotalVentasHoy.Text = "label3";
            // 
            // lblResumen
            // 
            lblResumen.AutoSize = true;
            lblResumen.Location = new Point(23, 374);
            lblResumen.Name = "lblResumen";
            lblResumen.Size = new Size(164, 20);
            lblResumen.TabIndex = 5;
            lblResumen.Text = "No hay datos a mostrar";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Info;
            label1.Location = new Point(19, 38);
            label1.Name = "label1";
            label1.Size = new Size(177, 20);
            label1.TabIndex = 6;
            label1.Text = "Total Productos Vendidos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Info;
            label2.Location = new Point(226, 38);
            label2.Name = "label2";
            label2.Size = new Size(159, 20);
            label2.TabIndex = 7;
            label2.Text = "Producto Más Vendido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Info;
            label3.Location = new Point(432, 38);
            label3.Name = "label3";
            label3.Size = new Size(143, 20);
            label3.TabIndex = 8;
            label3.Text = "Total Ventas De Hoy";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Info;
            label4.Location = new Point(23, 342);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 9;
            label4.Text = "Resumen";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Info;
            label5.Location = new Point(16, 139);
            label5.Name = "label5";
            label5.Size = new Size(93, 20);
            label5.TabIndex = 10;
            label5.Text = "Buscar Venta";
            // 
            // dtpFechaInicio
            // 
            dtpFechaInicio.Location = new Point(6, 46);
            dtpFechaInicio.Name = "dtpFechaInicio";
            dtpFechaInicio.Size = new Size(277, 27);
            dtpFechaInicio.TabIndex = 11;
            // 
            // dtpFechaFin
            // 
            dtpFechaFin.Location = new Point(6, 124);
            dtpFechaFin.Name = "dtpFechaFin";
            dtpFechaFin.Size = new Size(277, 27);
            dtpFechaFin.TabIndex = 12;
            // 
            // dtpFechaConsulta
            // 
            dtpFechaConsulta.Location = new Point(16, 83);
            dtpFechaConsulta.Name = "dtpFechaConsulta";
            dtpFechaConsulta.Size = new Size(287, 27);
            dtpFechaConsulta.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.Info;
            label6.Location = new Point(6, 23);
            label6.Name = "label6";
            label6.Size = new Size(108, 20);
            label6.TabIndex = 14;
            label6.Text = "Fecha de Inicio";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.Info;
            label7.Location = new Point(6, 90);
            label7.Name = "label7";
            label7.Size = new Size(91, 20);
            label7.TabIndex = 15;
            label7.Text = "Fecha de Fin";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.Info;
            label8.Location = new Point(16, 35);
            label8.Name = "label8";
            label8.Size = new Size(129, 20);
            label8.TabIndex = 16;
            label8.Text = "Fecha de Consulta";
            // 
            // gbEstadisticas
            // 
            gbEstadisticas.BackColor = SystemColors.GradientInactiveCaption;
            gbEstadisticas.Controls.Add(btnActualizarEstadisticas);
            gbEstadisticas.Controls.Add(label1);
            gbEstadisticas.Controls.Add(lblTotalProductosVendidos);
            gbEstadisticas.Controls.Add(label2);
            gbEstadisticas.Controls.Add(lblProductoMasVendido);
            gbEstadisticas.Controls.Add(label3);
            gbEstadisticas.Controls.Add(lblTotalVentasHoy);
            gbEstadisticas.Location = new Point(14, 12);
            gbEstadisticas.Name = "gbEstadisticas";
            gbEstadisticas.Size = new Size(581, 313);
            gbEstadisticas.TabIndex = 17;
            gbEstadisticas.TabStop = false;
            gbEstadisticas.Text = "Estadísticas Generales";
            // 
            // btnActualizarEstadisticas
            // 
            btnActualizarEstadisticas.Location = new Point(39, 218);
            btnActualizarEstadisticas.Name = "btnActualizarEstadisticas";
            btnActualizarEstadisticas.Size = new Size(157, 64);
            btnActualizarEstadisticas.TabIndex = 9;
            btnActualizarEstadisticas.Text = "Actualizar";
            btnActualizarEstadisticas.UseVisualStyleBackColor = true;
            btnActualizarEstadisticas.Click += btnActualizarEstadisticas_Click;
            // 
            // gbFiltros
            // 
            gbFiltros.BackColor = SystemColors.GradientInactiveCaption;
            gbFiltros.Controls.Add(btnReporteCompleto);
            gbFiltros.Controls.Add(btnFiltrarPorFecha);
            gbFiltros.Controls.Add(label6);
            gbFiltros.Controls.Add(dtpFechaInicio);
            gbFiltros.Controls.Add(label7);
            gbFiltros.Controls.Add(dtpFechaFin);
            gbFiltros.Location = new Point(612, 12);
            gbFiltros.Name = "gbFiltros";
            gbFiltros.Size = new Size(581, 313);
            gbFiltros.TabIndex = 18;
            gbFiltros.TabStop = false;
            gbFiltros.Text = "Filtros de Reporte";
            // 
            // btnReporteCompleto
            // 
            btnReporteCompleto.Location = new Point(229, 218);
            btnReporteCompleto.Name = "btnReporteCompleto";
            btnReporteCompleto.Size = new Size(174, 50);
            btnReporteCompleto.TabIndex = 18;
            btnReporteCompleto.Text = "Reporte Completo";
            btnReporteCompleto.UseVisualStyleBackColor = true;
            btnReporteCompleto.Click += btnReporteCompleto_Click;
            // 
            // btnFiltrarPorFecha
            // 
            btnFiltrarPorFecha.Location = new Point(19, 218);
            btnFiltrarPorFecha.Name = "btnFiltrarPorFecha";
            btnFiltrarPorFecha.Size = new Size(187, 57);
            btnFiltrarPorFecha.TabIndex = 17;
            btnFiltrarPorFecha.Text = "Filtrar por Fechas";
            btnFiltrarPorFecha.UseVisualStyleBackColor = true;
            btnFiltrarPorFecha.Click += btnFiltrarPorFecha_Click;
            // 
            // gbConsultas
            // 
            gbConsultas.BackColor = SystemColors.GradientInactiveCaption;
            gbConsultas.Controls.Add(btnBuscarVenta);
            gbConsultas.Controls.Add(btnConsultarFecha);
            gbConsultas.Controls.Add(label8);
            gbConsultas.Controls.Add(dtpFechaConsulta);
            gbConsultas.Controls.Add(label5);
            gbConsultas.Controls.Add(txtBuscarVenta);
            gbConsultas.Location = new Point(1199, 12);
            gbConsultas.Name = "gbConsultas";
            gbConsultas.Size = new Size(487, 313);
            gbConsultas.TabIndex = 19;
            gbConsultas.TabStop = false;
            gbConsultas.Text = "Consultas Específicas";
            // 
            // btnBuscarVenta
            // 
            btnBuscarVenta.Location = new Point(20, 223);
            btnBuscarVenta.Name = "btnBuscarVenta";
            btnBuscarVenta.Size = new Size(138, 45);
            btnBuscarVenta.TabIndex = 18;
            btnBuscarVenta.Text = "Buscar";
            btnBuscarVenta.UseVisualStyleBackColor = true;
            btnBuscarVenta.Click += btnBuscarVenta_Click;
            // 
            // btnConsultarFecha
            // 
            btnConsultarFecha.Location = new Point(205, 223);
            btnConsultarFecha.Name = "btnConsultarFecha";
            btnConsultarFecha.Size = new Size(121, 45);
            btnConsultarFecha.TabIndex = 17;
            btnConsultarFecha.Text = "Consultar";
            btnConsultarFecha.UseVisualStyleBackColor = true;
            btnConsultarFecha.Click += btnConsultarFecha_Click;
            // 
            // panelBotones
            // 
            panelBotones.Controls.Add(btnCerrar);
            panelBotones.Dock = DockStyle.Bottom;
            panelBotones.Location = new Point(0, 561);
            panelBotones.Name = "panelBotones";
            panelBotones.Size = new Size(1698, 125);
            panelBotones.TabIndex = 20;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(64, 35);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(200, 61);
            btnCerrar.TabIndex = 0;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // FrmReportes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1698, 686);
            Controls.Add(panelBotones);
            Controls.Add(gbConsultas);
            Controls.Add(gbFiltros);
            Controls.Add(gbEstadisticas);
            Controls.Add(label4);
            Controls.Add(lblResumen);
            Controls.Add(dgvReporte);
            Name = "FrmReportes";
            Text = "FrmReportes";
            ((System.ComponentModel.ISupportInitialize)dgvReporte).EndInit();
            gbEstadisticas.ResumeLayout(false);
            gbEstadisticas.PerformLayout();
            gbFiltros.ResumeLayout(false);
            gbFiltros.PerformLayout();
            gbConsultas.ResumeLayout(false);
            gbConsultas.PerformLayout();
            panelBotones.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvReporte;
        private TextBox txtBuscarVenta;
        private Label lblTotalProductosVendidos;
        private Label lblProductoMasVendido;
        private Label lblTotalVentasHoy;
        private Label lblResumen;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private DateTimePicker dtpFechaInicio;
        private DateTimePicker dtpFechaFin;
        private DateTimePicker dtpFechaConsulta;
        private Label label6;
        private Label label7;
        private Label label8;
        private GroupBox gbEstadisticas;
        private Button btnActualizarEstadisticas;
        private GroupBox gbFiltros;
        private Button btnFiltrarPorFecha;
        private Button btnReporteCompleto;
        private GroupBox gbConsultas;
        private Button btnBuscarVenta;
        private Button btnConsultarFecha;
        private Panel panelBotones;
        private Button btnCerrar;
    }
}