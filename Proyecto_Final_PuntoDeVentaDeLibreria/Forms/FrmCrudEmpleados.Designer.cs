namespace Proyecto_Final_PuntoDeVentaDeLibreria.Forms
{
    partial class FrmCrudEmpleados
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
            btnAgregar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnGuardar = new Button();
            btnCancelar = new Button();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtTelefono = new TextBox();
            txtDireccion = new TextBox();
            dgvEmpleados = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).BeginInit();
            SuspendLayout();
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(32, 148);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(119, 51);
            btnAgregar.TabIndex = 0;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(32, 263);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(119, 50);
            btnEditar.TabIndex = 1;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(32, 511);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(119, 49);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(32, 386);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(119, 60);
            btnGuardar.TabIndex = 3;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(32, 617);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(119, 59);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = " Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(293, 53);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(146, 27);
            txtNombre.TabIndex = 5;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(561, 53);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(140, 27);
            txtApellido.TabIndex = 6;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(806, 53);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(138, 27);
            txtTelefono.TabIndex = 7;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(1131, 53);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(217, 27);
            txtDireccion.TabIndex = 8;
            // 
            // dgvEmpleados
            // 
            dgvEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmpleados.Location = new Point(179, 132);
            dgvEmpleados.Name = "dgvEmpleados";
            dgvEmpleados.RowHeadersWidth = 51;
            dgvEmpleados.Size = new Size(1269, 563);
            dgvEmpleados.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Info;
            label1.Location = new Point(321, 12);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 10;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Info;
            label2.Location = new Point(589, 12);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 11;
            label2.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Info;
            label3.Location = new Point(831, 12);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 12;
            label3.Text = "Telefono";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Info;
            label4.Location = new Point(1162, 12);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 13;
            label4.Text = "Dirección";
            // 
            // FrmCrudEmpleados
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(1460, 718);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvEmpleados);
            Controls.Add(txtDireccion);
            Controls.Add(txtTelefono);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(btnEliminar);
            Controls.Add(btnEditar);
            Controls.Add(btnAgregar);
            Name = "FrmCrudEmpleados";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CRUD De Empleados";
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregar;
        private Button btnEditar;
        private Button btnEliminar;
        private Button btnGuardar;
        private Button btnCancelar;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtTelefono;
        private TextBox txtDireccion;
        private DataGridView dgvEmpleados;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}