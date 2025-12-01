namespace Proyecto_Final_PuntoDeVentaDeLibreria.Forms
{
    partial class FrmVentas
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
            txtISBN = new TextBox();
            txtCantidad = new TextBox();
            btnAgregar = new Button();
            dgvCarrito = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            btnPagar = new Button();
            btnCancelar = new Button();
            lblTotal = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).BeginInit();
            SuspendLayout();
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(157, 82);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(125, 27);
            txtISBN.TabIndex = 0;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(321, 82);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(125, 27);
            txtCantidad.TabIndex = 1;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(28, 141);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dgvCarrito
            // 
            dgvCarrito.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarrito.Location = new Point(157, 129);
            dgvCarrito.Name = "dgvCarrito";
            dgvCarrito.RowHeadersWidth = 51;
            dgvCarrito.Size = new Size(615, 279);
            dgvCarrito.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Info;
            label1.Location = new Point(193, 47);
            label1.Name = "label1";
            label1.Size = new Size(41, 20);
            label1.TabIndex = 4;
            label1.Text = "ISBN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Info;
            label2.Location = new Point(355, 47);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 5;
            label2.Text = "Cantidad";
            // 
            // btnPagar
            // 
            btnPagar.Location = new Point(28, 210);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(94, 29);
            btnPagar.TabIndex = 6;
            btnPagar.Text = "Pagar";
            btnPagar.UseVisualStyleBackColor = true;
            btnPagar.Click += btnPagar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(28, 283);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 29);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(592, 85);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(42, 20);
            lblTotal.TabIndex = 8;
            lblTotal.Text = "Total";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Info;
            label3.Location = new Point(592, 47);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 9;
            label3.Text = "Total";
            // 
            // FrmVentas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(lblTotal);
            Controls.Add(btnCancelar);
            Controls.Add(btnPagar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvCarrito);
            Controls.Add(btnAgregar);
            Controls.Add(txtCantidad);
            Controls.Add(txtISBN);
            Name = "FrmVentas";
            Text = "FrmVentas";
            Load += FrmVentas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtISBN;
        private TextBox txtCantidad;
        private Button btnAgregar;
        private DataGridView dgvCarrito;
        private Label label1;
        private Label label2;
        private Button btnPagar;
        private Button btnCancelar;
        private Label lblTotal;
        private Label label3;
    }
}