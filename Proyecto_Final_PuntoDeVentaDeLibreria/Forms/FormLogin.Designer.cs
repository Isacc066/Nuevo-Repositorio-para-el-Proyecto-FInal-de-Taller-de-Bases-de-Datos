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
            panelCard = new Panel();
            lblIcon = new Label();
            labelTitle = new Label();
            labelUsuario = new Label();
            txtUsuario = new TextBox();
            labelPassword = new Label();
            txtPassword = new TextBox();
            btnIngresar = new Button();
            btnProbarConexion = new Button();
            panelCard.SuspendLayout();
            SuspendLayout();
            // 
            // panelCard
            // 
            panelCard.Anchor = AnchorStyles.None;
            panelCard.BackColor = Color.White;
            panelCard.BorderStyle = BorderStyle.FixedSingle;
            panelCard.Controls.Add(lblIcon);
            panelCard.Controls.Add(labelTitle);
            panelCard.Controls.Add(labelUsuario);
            panelCard.Controls.Add(txtUsuario);
            panelCard.Controls.Add(labelPassword);
            panelCard.Controls.Add(txtPassword);
            panelCard.Controls.Add(btnIngresar);
            panelCard.Controls.Add(btnProbarConexion);
            panelCard.Location = new Point(130, 60);
            panelCard.Name = "panelCard";
            panelCard.Padding = new Padding(20);
            panelCard.Size = new Size(340, 401);
            panelCard.TabIndex = 0;
            // 
            // lblIcon
            // 
            lblIcon.AutoSize = true;
            lblIcon.Location = new Point(0, 0);
            lblIcon.Name = "lblIcon";
            lblIcon.Size = new Size(30, 20);
            lblIcon.TabIndex = 0;
            lblIcon.Text = "👤";
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            labelTitle.Location = new Point(30, 86);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(270, 46);
            labelTitle.TabIndex = 1;
            labelTitle.Text = "Inicio de Sesión";
            // 
            // labelUsuario
            // 
            labelUsuario.AutoSize = true;
            labelUsuario.Font = new Font("Segoe UI", 10F);
            labelUsuario.Location = new Point(30, 150);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(68, 23);
            labelUsuario.TabIndex = 2;
            labelUsuario.Text = "Usuario";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(30, 175);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(280, 27);
            txtUsuario.TabIndex = 0;
            txtUsuario.TextChanged += txtUsuario_TextChanged;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Segoe UI", 10F);
            labelPassword.Location = new Point(30, 215);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(97, 23);
            labelPassword.TabIndex = 3;
            labelPassword.Text = "Contraseña";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(30, 240);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(280, 27);
            txtPassword.TabIndex = 1;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.FromArgb(46, 139, 87);
            btnIngresar.FlatAppearance.BorderSize = 0;
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnIngresar.ForeColor = Color.White;
            btnIngresar.Location = new Point(30, 295);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(280, 40);
            btnIngresar.TabIndex = 2;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnProbarConexion
            // 
            btnProbarConexion.BackColor = Color.LightGray;
            btnProbarConexion.FlatStyle = FlatStyle.Flat;
            btnProbarConexion.Font = new Font("Segoe UI", 9F);
            btnProbarConexion.Location = new Point(95, 345);
            btnProbarConexion.Name = "btnProbarConexion";
            btnProbarConexion.Size = new Size(150, 30);
            btnProbarConexion.TabIndex = 3;
            btnProbarConexion.Text = "Probar Conexión";
            btnProbarConexion.UseVisualStyleBackColor = false;
            btnProbarConexion.Click += btnProbarConexion_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(240, 240, 240);
            ClientSize = new Size(600, 500);
            Controls.Add(panelCard);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio de Sesión";
            panelCard.ResumeLayout(false);
            panelCard.PerformLayout();
            ResumeLayout(false);
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
