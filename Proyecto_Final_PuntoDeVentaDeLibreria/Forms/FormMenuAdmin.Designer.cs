namespace Proyecto_Final_PuntoDeVentaDeLibreria
{
    partial class FormMenuAdmin
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
            btnUsuarios = new Button();
            btnProductos = new Button();
            btnVentas = new Button();
            btnAuditoria = new Button();
            btnReportes = new Button();
            btnCerrarSesion = new Button();
            btnEmpleados = new Button();
            SuspendLayout();
            // 
            // btnUsuarios
            // 
            btnUsuarios.Location = new Point(629, 50);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(300, 70);
            btnUsuarios.TabIndex = 0;
            btnUsuarios.Text = "Usuarios";
            btnUsuarios.UseVisualStyleBackColor = true;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // btnProductos
            // 
            btnProductos.Location = new Point(639, 254);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(290, 64);
            btnProductos.TabIndex = 1;
            btnProductos.Text = "Productos";
            btnProductos.UseVisualStyleBackColor = true;
            btnProductos.Click += btnProductos_Click;
            // 
            // btnVentas
            // 
            btnVentas.Location = new Point(639, 355);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(290, 65);
            btnVentas.TabIndex = 2;
            btnVentas.Text = "Ventas";
            btnVentas.UseVisualStyleBackColor = true;
            btnVentas.Click += btnVentas_Click;
            // 
            // btnAuditoria
            // 
            btnAuditoria.Location = new Point(639, 448);
            btnAuditoria.Name = "btnAuditoria";
            btnAuditoria.Size = new Size(290, 60);
            btnAuditoria.TabIndex = 3;
            btnAuditoria.Text = "Auditoría";
            btnAuditoria.UseVisualStyleBackColor = true;
            btnAuditoria.Click += btnAuditoria_Click;
            // 
            // btnReportes
            // 
            btnReportes.Location = new Point(639, 542);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(290, 63);
            btnReportes.TabIndex = 4;
            btnReportes.Text = "Reportes";
            btnReportes.UseVisualStyleBackColor = true;
            btnReportes.Click += btnReportes_Click;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Location = new Point(639, 640);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(290, 66);
            btnCerrarSesion.TabIndex = 5;
            btnCerrarSesion.Text = "Cerrar Sesión";
            btnCerrarSesion.UseVisualStyleBackColor = true;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // btnEmpleados
            // 
            btnEmpleados.Location = new Point(639, 150);
            btnEmpleados.Name = "btnEmpleados";
            btnEmpleados.Size = new Size(290, 70);
            btnEmpleados.TabIndex = 6;
            btnEmpleados.Text = "Empleados";
            btnEmpleados.UseVisualStyleBackColor = true;
            btnEmpleados.Click += btnEmpleados_Click;
            // 
            // FormMenuAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1445, 727);
            Controls.Add(btnEmpleados);
            Controls.Add(btnCerrarSesion);
            Controls.Add(btnReportes);
            Controls.Add(btnAuditoria);
            Controls.Add(btnVentas);
            Controls.Add(btnProductos);
            Controls.Add(btnUsuarios);
            Name = "FormMenuAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menú De Administrador";
            Load += FormMenuAdmin_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnUsuarios;
        private Button btnProductos;
        private Button btnVentas;
        private Button btnAuditoria;
        private Button btnReportes;
        private Button btnCerrarSesion;
        private Button btnEmpleados;
    }
}