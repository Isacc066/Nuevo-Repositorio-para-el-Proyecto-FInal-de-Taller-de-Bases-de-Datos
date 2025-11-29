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
            SuspendLayout();
            // 
            // btnUsuarios
            // 
            btnUsuarios.Location = new Point(337, 30);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(94, 29);
            btnUsuarios.TabIndex = 0;
            btnUsuarios.Text = "Usuarios";
            btnUsuarios.UseVisualStyleBackColor = true;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // btnProductos
            // 
            btnProductos.Location = new Point(337, 97);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(94, 29);
            btnProductos.TabIndex = 1;
            btnProductos.Text = "Productos";
            btnProductos.UseVisualStyleBackColor = true;
            btnProductos.Click += btnProductos_Click;
            // 
            // btnVentas
            // 
            btnVentas.Location = new Point(337, 165);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(94, 29);
            btnVentas.TabIndex = 2;
            btnVentas.Text = "Ventas";
            btnVentas.UseVisualStyleBackColor = true;
            btnVentas.Click += btnVentas_Click;
            // 
            // btnAuditoria
            // 
            btnAuditoria.Location = new Point(337, 227);
            btnAuditoria.Name = "btnAuditoria";
            btnAuditoria.Size = new Size(94, 29);
            btnAuditoria.TabIndex = 3;
            btnAuditoria.Text = "Auditoría";
            btnAuditoria.UseVisualStyleBackColor = true;
            btnAuditoria.Click += btnAuditoria_Click;
            // 
            // btnReportes
            // 
            btnReportes.Location = new Point(337, 291);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(94, 29);
            btnReportes.TabIndex = 4;
            btnReportes.Text = "Reportes";
            btnReportes.UseVisualStyleBackColor = true;
            btnReportes.Click += btnReportes_Click;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Location = new Point(337, 361);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(110, 29);
            btnCerrarSesion.TabIndex = 5;
            btnCerrarSesion.Text = "Cerrar Sesión";
            btnCerrarSesion.UseVisualStyleBackColor = true;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // FormMenuAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCerrarSesion);
            Controls.Add(btnReportes);
            Controls.Add(btnAuditoria);
            Controls.Add(btnVentas);
            Controls.Add(btnProductos);
            Controls.Add(btnUsuarios);
            Name = "FormMenuAdmin";
            Text = "FormMenuAdmin";
            ResumeLayout(false);
        }

        #endregion

        private Button btnUsuarios;
        private Button btnProductos;
        private Button btnVentas;
        private Button btnAuditoria;
        private Button btnReportes;
        private Button btnCerrarSesion;
    }
}