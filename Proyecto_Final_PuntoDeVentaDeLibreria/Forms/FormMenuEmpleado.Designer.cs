namespace Proyecto_Final_PuntoDeVentaDeLibreria
{
    partial class FormMenuEmpleado
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenuEmpleado));
            panelMenu = new Panel();
            btnProductos = new Button();
            btnReportes = new Button();
            btnVentas = new Button();
            lblTitulo = new Label();
            btnCerrarSesion = new Button();
            panelContenido = new Panel();
            pictureCentro = new PictureBox();
            lblBienvenida = new Label();
            panelMenu.SuspendLayout();
            panelContenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureCentro).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(30, 30, 30);
            panelMenu.Controls.Add(btnProductos);
            panelMenu.Controls.Add(btnReportes);
            panelMenu.Controls.Add(btnVentas);
            panelMenu.Controls.Add(lblTitulo);
            panelMenu.Controls.Add(btnCerrarSesion);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(250, 700);
            panelMenu.TabIndex = 1;
            // 
            // btnProductos
            // 
            btnProductos.BackColor = Color.FromArgb(50, 50, 50);
            btnProductos.Dock = DockStyle.Top;
            btnProductos.FlatAppearance.BorderSize = 0;
            btnProductos.FlatStyle = FlatStyle.Flat;
            btnProductos.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnProductos.ForeColor = Color.White;
            btnProductos.Location = new Point(0, 210);
            btnProductos.Name = "btnProductos";
            btnProductos.Size = new Size(250, 55);
            btnProductos.TabIndex = 0;
            btnProductos.Text = "   📦  Inventario";
            btnProductos.UseVisualStyleBackColor = false;
            btnProductos.Click += btnProductos_Click;
            // 
            // btnReportes
            // 
            btnReportes.BackColor = Color.FromArgb(50, 50, 50);
            btnReportes.Dock = DockStyle.Top;
            btnReportes.FlatAppearance.BorderSize = 0;
            btnReportes.FlatStyle = FlatStyle.Flat;
            btnReportes.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnReportes.ForeColor = Color.White;
            btnReportes.Location = new Point(0, 155);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(250, 55);
            btnReportes.TabIndex = 1;
            btnReportes.Text = "   📊  Reportes";
            btnReportes.UseVisualStyleBackColor = false;
            btnReportes.Click += btnReportes_Click;
            // 
            // btnVentas
            // 
            btnVentas.BackColor = Color.FromArgb(50, 50, 50);
            btnVentas.Dock = DockStyle.Top;
            btnVentas.FlatAppearance.BorderSize = 0;
            btnVentas.FlatStyle = FlatStyle.Flat;
            btnVentas.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnVentas.ForeColor = Color.White;
            btnVentas.Location = new Point(0, 100);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(250, 55);
            btnVentas.TabIndex = 2;
            btnVentas.Text = "   💵  Ventas";
            btnVentas.UseVisualStyleBackColor = false;
            btnVentas.Click += btnVentas_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.Dock = DockStyle.Top;
            lblTitulo.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(250, 100);
            lblTitulo.TabIndex = 3;
            lblTitulo.Text = "Empleado";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.BackColor = Color.FromArgb(70, 70, 70);
            btnCerrarSesion.Dock = DockStyle.Bottom;
            btnCerrarSesion.FlatAppearance.BorderSize = 0;
            btnCerrarSesion.FlatStyle = FlatStyle.Flat;
            btnCerrarSesion.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCerrarSesion.ForeColor = Color.White;
            btnCerrarSesion.Location = new Point(0, 645);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(250, 55);
            btnCerrarSesion.TabIndex = 4;
            btnCerrarSesion.Text = "   ⬅  Cerrar Sesión";
            btnCerrarSesion.UseVisualStyleBackColor = false;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // panelContenido
            // 
            panelContenido.BackColor = Color.WhiteSmoke;
            panelContenido.Controls.Add(pictureCentro);
            panelContenido.Controls.Add(lblBienvenida);
            panelContenido.Dock = DockStyle.Fill;
            panelContenido.Location = new Point(250, 0);
            panelContenido.Name = "panelContenido";
            panelContenido.Size = new Size(950, 700);
            panelContenido.TabIndex = 0;
            // 
            // pictureCentro
            // 
            pictureCentro.Image = (Image)resources.GetObject("pictureCentro.Image");
            pictureCentro.Location = new Point(350, 140);
            pictureCentro.Name = "pictureCentro";
            pictureCentro.Size = new Size(350, 350);
            pictureCentro.SizeMode = PictureBoxSizeMode.Zoom;
            pictureCentro.TabIndex = 0;
            pictureCentro.TabStop = false;
            // 
            // lblBienvenida
            // 
            lblBienvenida.AutoSize = true;
            lblBienvenida.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblBienvenida.ForeColor = Color.FromArgb(40, 40, 40);
            lblBienvenida.Location = new Point(330, 70);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(526, 46);
            lblBienvenida.TabIndex = 1;
            lblBienvenida.Text = "Bienvenido al sistema de ventas";
            // 
            // FormMenuEmpleado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1200, 700);
            Controls.Add(panelContenido);
            Controls.Add(panelMenu);
            MinimumSize = new Size(900, 600);
            Name = "FormMenuEmpleado";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menú Empleado";
            panelMenu.ResumeLayout(false);
            panelContenido.ResumeLayout(false);
            panelContenido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureCentro).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Button btnReportes;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panelContenido;
        private System.Windows.Forms.PictureBox pictureCentro;
        private System.Windows.Forms.Label lblBienvenida;
    }
}