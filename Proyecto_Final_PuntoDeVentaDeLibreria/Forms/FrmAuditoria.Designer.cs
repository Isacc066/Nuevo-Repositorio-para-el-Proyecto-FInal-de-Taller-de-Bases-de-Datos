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
            txtIdUsuario = new TextBox();
            label3 = new Label();
            lblContador = new Label();
            btnBuscar = new Button();
            btnMostrar = new Button();
            btnFiltrarAccion = new Button();
            btnFiltrarFecha = new Button();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvAuditoria).BeginInit();
            SuspendLayout();
            // 
            // dgvAuditoria
            // 
            dgvAuditoria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAuditoria.Location = new Point(765, 209);
            dgvAuditoria.Name = "dgvAuditoria";
            dgvAuditoria.RowHeadersWidth = 51;
            dgvAuditoria.Size = new Size(300, 188);
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
            // txtIdUsuario
            // 
            txtIdUsuario.Location = new Point(169, 209);
            txtIdUsuario.Name = "txtIdUsuario";
            txtIdUsuario.Size = new Size(125, 27);
            txtIdUsuario.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(185, 173);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 6;
            label3.Text = "IdUsuario";
            // 
            // lblContador
            // 
            lblContador.AutoSize = true;
            lblContador.Location = new Point(56, 168);
            lblContador.Name = "lblContador";
            lblContador.Size = new Size(71, 20);
            lblContador.TabIndex = 7;
            lblContador.Text = "Contador";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(169, 275);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(138, 29);
            btnBuscar.TabIndex = 8;
            btnBuscar.Text = "Buscar Producto";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(463, 243);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(118, 29);
            btnMostrar.TabIndex = 9;
            btnMostrar.Text = "Mostrar Todos";
            btnMostrar.UseVisualStyleBackColor = true;
            // 
            // btnFiltrarAccion
            // 
            btnFiltrarAccion.Location = new Point(463, 303);
            btnFiltrarAccion.Name = "btnFiltrarAccion";
            btnFiltrarAccion.Size = new Size(118, 29);
            btnFiltrarAccion.TabIndex = 10;
            btnFiltrarAccion.Text = "Filtrar Accion";
            btnFiltrarAccion.UseVisualStyleBackColor = true;
            // 
            // btnFiltrarFecha
            // 
            btnFiltrarFecha.Location = new Point(463, 354);
            btnFiltrarFecha.Name = "btnFiltrarFecha";
            btnFiltrarFecha.Size = new Size(118, 29);
            btnFiltrarFecha.TabIndex = 11;
            btnFiltrarFecha.Text = "Filtrar Fecha";
            btnFiltrarFecha.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(463, 161);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 12;
            // 
            // FrmAuditoria
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1154, 450);
            Controls.Add(comboBox1);
            Controls.Add(btnFiltrarFecha);
            Controls.Add(btnFiltrarAccion);
            Controls.Add(btnMostrar);
            Controls.Add(btnBuscar);
            Controls.Add(lblContador);
            Controls.Add(label3);
            Controls.Add(txtIdUsuario);
            Controls.Add(label2);
            Controls.Add(label1);
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
        private Label label1;
        private Label label2;
        private TextBox txtIdUsuario;
        private Label label3;
        private Label lblContador;
        private Button btnBuscar;
        private Button btnMostrar;
        private Button btnFiltrarAccion;
        private Button btnFiltrarFecha;
        private ComboBox comboBox1;
    }
}