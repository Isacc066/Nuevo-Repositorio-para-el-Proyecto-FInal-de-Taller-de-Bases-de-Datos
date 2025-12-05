namespace Proyecto_Final_PuntoDeVentaDeLibreria
{
    partial class FormMenuEmpleado
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
            btnVentas = new Button();
            btnReportes = new Button();
            btnCerrarSesion = new Button();
            btnProductos = new Button();
            SuspendLayout();
            // 
            // btnVentas
            // 
            btnVentas.Location = new Point(606, 102);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(332, 96);
            btnVentas.TabIndex = 0;
            btnVentas.Text = "Ventas";
            btnVentas.UseVisualStyleBackColor = true;
            btnVentas.Click += btnVentas_Click;
            // 
            // btnReportes
            // 
            btnReportes.Location = new Point(606, 364);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(332, 101);
            btnReportes.TabIndex = 1;
            btnReportes.Text = "Reportes";
            btnReportes.UseVisualStyleBackColor = true;
            btnReportes.Click += btnReportes_Click;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Location = new Point(606, 526);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(332, 120);
            btnCerrarSesion.TabIndex = 2;
            btnCerrarSesion.Text = "Cerrar Sesión";
            btnCerrarSesion.UseVisualStyleBackColor = true;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // btnProductos
            // 
            btnProductos.Location = new Point(606, 226);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(332, 108);
            btnProductos.TabIndex = 3;
            btnProductos.Text = "Productos";
            btnProductos.UseVisualStyleBackColor = true;
            btnProductos.Click += btnProductos_Click;
            // 
            // FormMenuEmpleado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(1478, 733);
            Controls.Add(btnProductos);
            Controls.Add(btnCerrarSesion);
            Controls.Add(btnReportes);
            Controls.Add(btnVentas);
            Name = "FormMenuEmpleado";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menú De Empleado";
            Load += FormMenuEmpleado_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnVentas;
        private Button btnReportes;
        private Button btnCerrarSesion;
        private Button btnProductos;
    }
}