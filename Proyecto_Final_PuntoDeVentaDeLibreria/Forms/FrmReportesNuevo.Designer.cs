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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblEstadoProductos = new System.Windows.Forms.Label();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.btnGenerarReporteProductos = new System.Windows.Forms.Button();
            this.dtpFinProductos = new System.Windows.Forms.DateTimePicker();
            this.dtpInicioProductos = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblEstadoEmpleados = new System.Windows.Forms.Label();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.btnGenerarReporteEmpleados = new System.Windows.Forms.Button();
            this.dtpFinEmpleados = new System.Windows.Forms.DateTimePicker();
            this.dtpInicioEmpleados = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1100, 650);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.lblEstadoProductos);
            this.tabPage1.Controls.Add(this.dgvProductos);
            this.tabPage1.Controls.Add(this.btnGenerarReporteProductos);
            this.tabPage1.Controls.Add(this.dtpFinProductos);
            this.tabPage1.Controls.Add(this.dtpInicioProductos);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1092, 618);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "📊 Reporte de Productos";
            // 
            // lblEstadoProductos
            // 
            this.lblEstadoProductos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEstadoProductos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEstadoProductos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblEstadoProductos.Location = new System.Drawing.Point(20, 575);
            this.lblEstadoProductos.Name = "lblEstadoProductos";
            this.lblEstadoProductos.Size = new System.Drawing.Size(1050, 25);
            this.lblEstadoProductos.TabIndex = 7;
            this.lblEstadoProductos.Text = "Seleccione un rango de fechas y genere el reporte";
            this.lblEstadoProductos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvProductos
            // 
            this.dgvProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProductos.BackgroundColor = System.Drawing.Color.White;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(20, 105);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.RowTemplate.Height = 25;
            this.dgvProductos.Size = new System.Drawing.Size(1050, 460);
            this.dgvProductos.TabIndex = 6;
            // 
            // btnGenerarReporteProductos
            // 
            this.btnGenerarReporteProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnGenerarReporteProductos.FlatAppearance.BorderSize = 0;
            this.btnGenerarReporteProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarReporteProductos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGenerarReporteProductos.ForeColor = System.Drawing.Color.White;
            this.btnGenerarReporteProductos.Location = new System.Drawing.Point(595, 57);
            this.btnGenerarReporteProductos.Name = "btnGenerarReporteProductos";
            this.btnGenerarReporteProductos.Size = new System.Drawing.Size(160, 35);
            this.btnGenerarReporteProductos.TabIndex = 5;
            this.btnGenerarReporteProductos.Text = "📊 Generar reporte";
            this.btnGenerarReporteProductos.UseVisualStyleBackColor = false;
            // 
            // dtpFinProductos
            // 
            this.dtpFinProductos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpFinProductos.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFinProductos.Location = new System.Drawing.Point(425, 62);
            this.dtpFinProductos.Name = "dtpFinProductos";
            this.dtpFinProductos.Size = new System.Drawing.Size(150, 25);
            this.dtpFinProductos.TabIndex = 4;
            // 
            // dtpInicioProductos
            // 
            this.dtpInicioProductos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpInicioProductos.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicioProductos.Location = new System.Drawing.Point(145, 62);
            this.dtpInicioProductos.Name = "dtpInicioProductos";
            this.dtpInicioProductos.Size = new System.Drawing.Size(150, 25);
            this.dtpInicioProductos.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(320, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha de fin:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(20, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha de inicio:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label1.Location = new System.Drawing.Point(20, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reporte de Ventas de Productos";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.lblEstadoEmpleados);
            this.tabPage2.Controls.Add(this.dgvEmpleados);
            this.tabPage2.Controls.Add(this.btnGenerarReporteEmpleados);
            this.tabPage2.Controls.Add(this.dtpFinEmpleados);
            this.tabPage2.Controls.Add(this.dtpInicioEmpleados);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1092, 618);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "👥 Reporte por Usuario";
            // 
            // lblEstadoEmpleados
            // 
            this.lblEstadoEmpleados.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEstadoEmpleados.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEstadoEmpleados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblEstadoEmpleados.Location = new System.Drawing.Point(20, 575);
            this.lblEstadoEmpleados.Name = "lblEstadoEmpleados";
            this.lblEstadoEmpleados.Size = new System.Drawing.Size(1050, 25);
            this.lblEstadoEmpleados.TabIndex = 7;
            this.lblEstadoEmpleados.Text = "Seleccione un rango de fechas y genere el reporte";
            this.lblEstadoEmpleados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEmpleados.BackgroundColor = System.Drawing.Color.White;
            this.dgvEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Location = new System.Drawing.Point(20, 105);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.RowTemplate.Height = 25;
            this.dgvEmpleados.Size = new System.Drawing.Size(1050, 460);
            this.dgvEmpleados.TabIndex = 6;
            // 
            // btnGenerarReporteEmpleados
            // 
            this.btnGenerarReporteEmpleados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.btnGenerarReporteEmpleados.FlatAppearance.BorderSize = 0;
            this.btnGenerarReporteEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarReporteEmpleados.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGenerarReporteEmpleados.ForeColor = System.Drawing.Color.White;
            this.btnGenerarReporteEmpleados.Location = new System.Drawing.Point(595, 57);
            this.btnGenerarReporteEmpleados.Name = "btnGenerarReporteEmpleados";
            this.btnGenerarReporteEmpleados.Size = new System.Drawing.Size(160, 35);
            this.btnGenerarReporteEmpleados.TabIndex = 5;
            this.btnGenerarReporteEmpleados.Text = "📊 Generar reporte";
            this.btnGenerarReporteEmpleados.UseVisualStyleBackColor = false;
            // 
            // dtpFinEmpleados
            // 
            this.dtpFinEmpleados.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpFinEmpleados.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFinEmpleados.Location = new System.Drawing.Point(425, 62);
            this.dtpFinEmpleados.Name = "dtpFinEmpleados";
            this.dtpFinEmpleados.Size = new System.Drawing.Size(150, 25);
            this.dtpFinEmpleados.TabIndex = 4;
            // 
            // dtpInicioEmpleados
            // 
            this.dtpInicioEmpleados.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpInicioEmpleados.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicioEmpleados.Location = new System.Drawing.Point(145, 62);
            this.dtpInicioEmpleados.Name = "dtpInicioEmpleados";
            this.dtpInicioEmpleados.Size = new System.Drawing.Size(150, 25);
            this.dtpInicioEmpleados.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(320, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 19);
            this.label6.TabIndex = 2;
            this.label6.Text = "Fecha de fin:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(20, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "Fecha de inicio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(68)))), ((int)(((byte)(173)))));
            this.label4.Location = new System.Drawing.Point(20, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(325, 30);
            this.label4.TabIndex = 0;
            this.label4.Text = "Reporte de Ventas por Usuario";
            // 
            // FrmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 650);
            this.Controls.Add(this.tabControl1);
            this.MinimumSize = new System.Drawing.Size(1116, 689);
            this.Name = "FrmReportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reportes de Ventas";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpleados)).EndInit();
            this.ResumeLayout(false);

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