namespace Proyecto_Final_PuntoDeVentaDeLibreria
{
    partial class FormLogin
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
            this.panelCard = new System.Windows.Forms.Panel();
            this.lblIcon = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnProbarConexion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            this.ClientSize = new System.Drawing.Size(600, 500);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio de Sesión";
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;

            // ===== Panel tipo tarjeta =====
            this.panelCard.BackColor = System.Drawing.Color.White;
            this.panelCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCard.Location = new System.Drawing.Point(130, 60);
            this.panelCard.Size = new System.Drawing.Size(340, 380);
            this.panelCard.Padding = new System.Windows.Forms.Padding(20);
            this.panelCard.Anchor = System.Windows.Forms.AnchorStyles.None;

            // ===== Icono =====
            this.lblIcon.Text = "👤";
            this.lblIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 48F, System.Drawing.FontStyle.Regular);
            this.lblIcon.AutoSize = true;
            this.lblIcon.Location = new System.Drawing.Point(120, 10);

            // ===== Título =====
            this.labelTitle.Text = "Inicio de Sesión";
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(75, 95);

            // ===== Usuario =====
            this.labelUsuario.Text = "Usuario";
            this.labelUsuario.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Location = new System.Drawing.Point(30, 150);

            this.txtUsuario.Location = new System.Drawing.Point(30, 175);
            this.txtUsuario.Size = new System.Drawing.Size(280, 27);
            this.txtUsuario.TabIndex = 0;
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);

            // ===== Contraseña =====
            this.labelPassword.Text = "Contraseña";
            this.labelPassword.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(30, 215);

            this.txtPassword.Location = new System.Drawing.Point(30, 240);
            this.txtPassword.Size = new System.Drawing.Size(280, 27);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.PasswordChar = '*';

            // ===== Botón Ingresar =====
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnIngresar.BackColor = System.Drawing.Color.FromArgb(46, 139, 87);
            this.btnIngresar.ForeColor = System.Drawing.Color.White;
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.FlatAppearance.BorderSize = 0;
            this.btnIngresar.Location = new System.Drawing.Point(30, 295);
            this.btnIngresar.Size = new System.Drawing.Size(280, 40);
            this.btnIngresar.TabIndex = 2;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);

            // ===== Botón Probar Conexión =====
            this.btnProbarConexion.Text = "Probar Conexión";
            this.btnProbarConexion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnProbarConexion.BackColor = System.Drawing.Color.LightGray;
            this.btnProbarConexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProbarConexion.Location = new System.Drawing.Point(95, 345);
            this.btnProbarConexion.Size = new System.Drawing.Size(150, 30);
            this.btnProbarConexion.TabIndex = 3;
            this.btnProbarConexion.Click += new System.EventHandler(this.btnProbarConexion_Click);

            // ===== Agregar controles a la tarjeta =====
            this.panelCard.Controls.Add(this.lblIcon);
            this.panelCard.Controls.Add(this.labelTitle);
            this.panelCard.Controls.Add(this.labelUsuario);
            this.panelCard.Controls.Add(this.txtUsuario);
            this.panelCard.Controls.Add(this.labelPassword);
            this.panelCard.Controls.Add(this.txtPassword);
            this.panelCard.Controls.Add(this.btnIngresar);
            this.panelCard.Controls.Add(this.btnProbarConexion);

            // ===== Agregar panel al Form =====
            this.Controls.Add(this.panelCard);

            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelCard;
        private System.Windows.Forms.Label lblIcon;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnProbarConexion;
    }
}
