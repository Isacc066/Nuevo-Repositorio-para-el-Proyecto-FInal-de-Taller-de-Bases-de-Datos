namespace Proyecto_Final_PuntoDeVentaDeLibreria.Forms
{
    partial class FrmReportesNuevo
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            lblEstadoProductos = new Label();
            dgvProductos = new DataGridView();
            btnGenerarReporteProductos = new Button();
            dtpFinProductos = new DateTimePicker();
            dtpInicioProductos = new DateTimePicker();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            lblEstadoEmpleados = new Label();
            dgvEmpleados = new DataGridView();
            btnGenerarReporteEmpleados = new Button();
            dtpFinEmpleados = new DateTimePicker();
            dtpInicioEmpleados = new DateTimePicker();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Font = new Font("Segoe UI", 10F);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Margin = new Padding(3, 4, 3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1257, 867);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.White;
            tabPage1.Controls.Add(lblEstadoProductos);
            tabPage1.Controls.Add(dgvProductos);
            tabPage1.Controls.Add(btnGenerarReporteProductos);
            tabPage1.Controls.Add(dtpFinProductos);
            tabPage1.Controls.Add(dtpInicioProductos);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 32);
            tabPage1.Margin = new Padding(3, 4, 3, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 4, 3, 4);
            tabPage1.Size = new Size(1249, 831);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "📊 Reporte de Productos";
            // 
            // lblEstadoProductos
            // 
            lblEstadoProductos.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblEstadoProductos.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblEstadoProductos.ForeColor = Color.FromArgb(52, 73, 94);
            lblEstadoProductos.Location = new Point(23, 767);
            lblEstadoProductos.Name = "lblEstadoProductos";
            lblEstadoProductos.Size = new Size(1200, 33);
            lblEstadoProductos.TabIndex = 7;
            lblEstadoProductos.Text = "Seleccione un rango de fechas y genere el reporte";
            lblEstadoProductos.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dgvProductos
            // 
            dgvProductos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvProductos.BackgroundColor = Color.White;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(23, 140);
            dgvProductos.Margin = new Padding(3, 4, 3, 4);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowHeadersWidth = 51;
            dgvProductos.RowTemplate.Height = 25;
            dgvProductos.Size = new Size(828, 613);
            dgvProductos.TabIndex = 6;
            // 
            // btnGenerarReporteProductos
            // 
            btnGenerarReporteProductos.BackColor = Color.FromArgb(46, 204, 113);
            btnGenerarReporteProductos.FlatAppearance.BorderSize = 0;
            btnGenerarReporteProductos.FlatStyle = FlatStyle.Flat;
            btnGenerarReporteProductos.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnGenerarReporteProductos.ForeColor = Color.White;
            btnGenerarReporteProductos.Location = new Point(680, 76);
            btnGenerarReporteProductos.Margin = new Padding(3, 4, 3, 4);
            btnGenerarReporteProductos.Name = "btnGenerarReporteProductos";
            btnGenerarReporteProductos.Size = new Size(183, 47);
            btnGenerarReporteProductos.TabIndex = 5;
            btnGenerarReporteProductos.Text = "📊 Generar reporte";
            btnGenerarReporteProductos.UseVisualStyleBackColor = false;
            // 
            // dtpFinProductos
            // 
            dtpFinProductos.Font = new Font("Segoe UI", 10F);
            dtpFinProductos.Format = DateTimePickerFormat.Short;
            dtpFinProductos.Location = new Point(486, 83);
            dtpFinProductos.Margin = new Padding(3, 4, 3, 4);
            dtpFinProductos.Name = "dtpFinProductos";
            dtpFinProductos.Size = new Size(171, 30);
            dtpFinProductos.TabIndex = 4;
            // 
            // dtpInicioProductos
            // 
            dtpInicioProductos.Font = new Font("Segoe UI", 10F);
            dtpInicioProductos.Format = DateTimePickerFormat.Short;
            dtpInicioProductos.Location = new Point(166, 83);
            dtpInicioProductos.Margin = new Padding(3, 4, 3, 4);
            dtpInicioProductos.Name = "dtpInicioProductos";
            dtpInicioProductos.Size = new Size(171, 30);
            dtpInicioProductos.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.Location = new Point(366, 87);
            label3.Name = "label3";
            label3.Size = new Size(112, 23);
            label3.TabIndex = 2;
            label3.Text = "Fecha de fin:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.Location = new Point(23, 87);
            label2.Name = "label2";
            label2.Size = new Size(133, 23);
            label2.TabIndex = 1;
            label2.Text = "Fecha de inicio:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(41, 128, 185);
            label1.Location = new Point(23, 20);
            label1.Name = "label1";
            label1.Size = new Size(429, 37);
            label1.TabIndex = 0;
            label1.Text = "Reporte de Ventas de Productos";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.White;
            tabPage2.Controls.Add(lblEstadoEmpleados);
            tabPage2.Controls.Add(dgvEmpleados);
            tabPage2.Controls.Add(btnGenerarReporteEmpleados);
            tabPage2.Controls.Add(dtpFinEmpleados);
            tabPage2.Controls.Add(dtpInicioEmpleados);
            tabPage2.Controls.Add(label6);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(label4);
            tabPage2.Location = new Point(4, 32);
            tabPage2.Margin = new Padding(3, 4, 3, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 4, 3, 4);
            tabPage2.Size = new Size(1249, 831);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "👥 Reporte por Usuario";
            // 
            // lblEstadoEmpleados
            // 
            lblEstadoEmpleados.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblEstadoEmpleados.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblEstadoEmpleados.ForeColor = Color.FromArgb(52, 73, 94);
            lblEstadoEmpleados.Location = new Point(23, 767);
            lblEstadoEmpleados.Name = "lblEstadoEmpleados";
            lblEstadoEmpleados.Size = new Size(1200, 33);
            lblEstadoEmpleados.TabIndex = 7;
            lblEstadoEmpleados.Text = "Seleccione un rango de fechas y genere el reporte";
            lblEstadoEmpleados.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dgvEmpleados
            // 
            dgvEmpleados.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvEmpleados.BackgroundColor = Color.White;
            dgvEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmpleados.Location = new Point(23, 140);
            dgvEmpleados.Margin = new Padding(3, 4, 3, 4);
            dgvEmpleados.Name = "dgvEmpleados";
            dgvEmpleados.RowHeadersWidth = 51;
            dgvEmpleados.RowTemplate.Height = 25;
            dgvEmpleados.Size = new Size(615, 613);
            dgvEmpleados.TabIndex = 6;
            // 
            // btnGenerarReporteEmpleados
            // 
            btnGenerarReporteEmpleados.BackColor = Color.FromArgb(155, 89, 182);
            btnGenerarReporteEmpleados.FlatAppearance.BorderSize = 0;
            btnGenerarReporteEmpleados.FlatStyle = FlatStyle.Flat;
            btnGenerarReporteEmpleados.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnGenerarReporteEmpleados.ForeColor = Color.White;
            btnGenerarReporteEmpleados.Location = new Point(680, 76);
            btnGenerarReporteEmpleados.Margin = new Padding(3, 4, 3, 4);
            btnGenerarReporteEmpleados.Name = "btnGenerarReporteEmpleados";
            btnGenerarReporteEmpleados.Size = new Size(183, 47);
            btnGenerarReporteEmpleados.TabIndex = 5;
            btnGenerarReporteEmpleados.Text = "📊 Generar reporte";
            btnGenerarReporteEmpleados.UseVisualStyleBackColor = false;
            // 
            // dtpFinEmpleados
            // 
            dtpFinEmpleados.Font = new Font("Segoe UI", 10F);
            dtpFinEmpleados.Format = DateTimePickerFormat.Short;
            dtpFinEmpleados.Location = new Point(486, 83);
            dtpFinEmpleados.Margin = new Padding(3, 4, 3, 4);
            dtpFinEmpleados.Name = "dtpFinEmpleados";
            dtpFinEmpleados.Size = new Size(171, 30);
            dtpFinEmpleados.TabIndex = 4;
            // 
            // dtpInicioEmpleados
            // 
            dtpInicioEmpleados.Font = new Font("Segoe UI", 10F);
            dtpInicioEmpleados.Format = DateTimePickerFormat.Short;
            dtpInicioEmpleados.Location = new Point(166, 83);
            dtpInicioEmpleados.Margin = new Padding(3, 4, 3, 4);
            dtpInicioEmpleados.Name = "dtpInicioEmpleados";
            dtpInicioEmpleados.Size = new Size(171, 30);
            dtpInicioEmpleados.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label6.Location = new Point(366, 87);
            label6.Name = "label6";
            label6.Size = new Size(112, 23);
            label6.TabIndex = 2;
            label6.Text = "Fecha de fin:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label5.Location = new Point(23, 87);
            label5.Name = "label5";
            label5.Size = new Size(133, 23);
            label5.TabIndex = 1;
            label5.Text = "Fecha de inicio:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(142, 68, 173);
            label4.Location = new Point(23, 20);
            label4.Name = "label4";
            label4.Size = new Size(410, 37);
            label4.TabIndex = 0;
            label4.Text = "Reporte de Ventas por Usuario";
            // 
            // FrmReportesNuevo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1257, 867);
            Controls.Add(tabControl1);
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(1273, 903);
            Name = "FrmReportesNuevo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reportes de Ventas";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpInicioProductos;
        private System.Windows.Forms.DateTimePicker dtpFinProductos;
        private System.Windows.Forms.Button btnGenerarReporteProductos;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Label lblEstadoProductos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpInicioEmpleados;
        private System.Windows.Forms.DateTimePicker dtpFinEmpleados;
        private System.Windows.Forms.Button btnGenerarReporteEmpleados;
        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.Label lblEstadoEmpleados;
    }
}