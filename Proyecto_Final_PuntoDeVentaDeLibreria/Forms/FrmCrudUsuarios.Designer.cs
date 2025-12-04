namespace Proyecto_Final_PuntoDeVentaDeLibreria.Forms
{
    partial class FrmCrudUsuarios
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
            dgvUsuarios = new DataGridView();
            txtUsuario = new TextBox();
            txtContrasena = new TextBox();
            cboRol = new ComboBox();
            btnAgregar = new Button();
            btnActualizar = new Button();
            btnEliminar = new Button();
            label1 = new Label();
            label2 = new Label();
            txtIdUsuario = new TextBox();
            btnListar = new Button();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            SuspendLayout();
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuarios.Location = new Point(693, 47);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.RowHeadersWidth = 51;
            dgvUsuarios.Size = new Size(409, 467);
            dgvUsuarios.TabIndex = 0;
            dgvUsuarios.CellContentClick += dgvUsuarios_CellClick;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(212, 70);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(158, 27);
            txtUsuario.TabIndex = 1;
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(212, 130);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.PasswordChar = '*';
            txtContrasena.Size = new Size(158, 27);
            txtContrasena.TabIndex = 2;
            // 
            // cboRol
            // 
            cboRol.FormattingEnabled = true;
            cboRol.Location = new Point(219, 208);
            cboRol.Name = "cboRol";
            cboRol.Size = new Size(151, 28);
            cboRol.TabIndex = 3;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(219, 323);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(160, 55);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(219, 412);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(160, 51);
            btnActualizar.TabIndex = 5;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(219, 592);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(160, 47);
            btnEliminar.TabIndex = 6;
            btnEliminar.Text = "Elliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Info;
            label1.Location = new Point(81, 77);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 7;
            label1.Text = "Usuario:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Info;
            label2.Location = new Point(81, 137);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 8;
            label2.Text = "Contraseña:";
            // 
            // txtIdUsuario
            // 
            txtIdUsuario.BackColor = SystemColors.Window;
            txtIdUsuario.Enabled = false;
            txtIdUsuario.Location = new Point(507, 70);
            txtIdUsuario.Name = "txtIdUsuario";
            txtIdUsuario.ReadOnly = true;
            txtIdUsuario.Size = new Size(125, 27);
            txtIdUsuario.TabIndex = 9;
            // 
            // btnListar
            // 
            btnListar.Location = new Point(219, 498);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(160, 52);
            btnListar.TabIndex = 10;
            btnListar.Text = "Listar Usuarios";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Info;
            label3.Location = new Point(547, 35);
            label3.Name = "label3";
            label3.Size = new Size(24, 20);
            label3.TabIndex = 11;
            label3.Text = "ID";
            // 
            // FrmCrudUsuarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1456, 722);
            Controls.Add(label3);
            Controls.Add(btnListar);
            Controls.Add(txtIdUsuario);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnEliminar);
            Controls.Add(btnActualizar);
            Controls.Add(btnAgregar);
            Controls.Add(cboRol);
            Controls.Add(txtContrasena);
            Controls.Add(txtUsuario);
            Controls.Add(dgvUsuarios);
            Name = "FrmCrudUsuarios";
            Text = "CRUD De Usuarios";
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvUsuarios;
        private TextBox txtUsuario;
        private TextBox txtContrasena;
        private ComboBox cboRol;
        private Button btnAgregar;
        private Button btnActualizar;
        private Button btnEliminar;
        private Label label1;
        private Label label2;
        private TextBox txtIdUsuario;
        private Button btnListar;
        private Label label3;
    }
}