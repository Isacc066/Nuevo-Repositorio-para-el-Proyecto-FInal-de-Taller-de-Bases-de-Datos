namespace Proyecto_Final_PuntoDeVentaDeLibreria.Forms
{
    partial class FrmVentasNuevo
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
            panelSuperior = new Panel();
            lblTitulo = new Label();
            groupBoxProducto = new GroupBox();
            btnAgregar = new Button();
            txtCantidad = new TextBox();
            txtISBN = new TextBox();
            label2 = new Label();
            label1 = new Label();
            dgvCarrito = new DataGridView();
            panelInferior = new Panel();
            btnCancelar = new Button();
            btnPagar = new Button();
            lblTotal = new Label();
            label3 = new Label();
            panelSuperior.SuspendLayout();
            groupBoxProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).BeginInit();
            panelInferior.SuspendLayout();
            SuspendLayout();
            // 
            // panelSuperior
            // 
            panelSuperior.BackColor = Color.FromArgb(230, 126, 34);
            panelSuperior.Controls.Add(lblTitulo);
            panelSuperior.Dock = DockStyle.Top;
            panelSuperior.Location = new Point(0, 0);
            panelSuperior.Margin = new Padding(3, 4, 3, 4);
            panelSuperior.Name = "panelSuperior";
            panelSuperior.Size = new Size(1143, 93);
            panelSuperior.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(34, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(322, 46);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "💰 Punto de Venta";
            // 
            // groupBoxProducto
            // 
            groupBoxProducto.Controls.Add(btnAgregar);
            groupBoxProducto.Controls.Add(txtCantidad);
            groupBoxProducto.Controls.Add(txtISBN);
            groupBoxProducto.Controls.Add(label2);
            groupBoxProducto.Controls.Add(label1);
            groupBoxProducto.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            groupBoxProducto.Location = new Point(34, 120);
            groupBoxProducto.Margin = new Padding(3, 4, 3, 4);
            groupBoxProducto.Name = "groupBoxProducto";
            groupBoxProducto.Padding = new Padding(3, 4, 3, 4);
            groupBoxProducto.Size = new Size(1074, 133);
            groupBoxProducto.TabIndex = 1;
            groupBoxProducto.TabStop = false;
            groupBoxProducto.Text = "Agregar Producto";
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(46, 204, 113);
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(857, 47);
            btnAgregar.Margin = new Padding(3, 4, 3, 4);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(183, 60);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "➕ Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtCantidad
            // 
            txtCantidad.Font = new Font("Segoe UI", 12F);
            txtCantidad.Location = new Point(640, 60);
            txtCantidad.Margin = new Padding(3, 4, 3, 4);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(171, 34);
            txtCantidad.TabIndex = 3;
            txtCantidad.Text = "1";
            txtCantidad.TextAlign = HorizontalAlignment.Center;
            // 
            // txtISBN
            // 
            txtISBN.Font = new Font("Segoe UI", 12F);
            txtISBN.Location = new Point(171, 60);
            txtISBN.Margin = new Padding(3, 4, 3, 4);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(285, 34);
            txtISBN.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(514, 64);
            label2.Name = "label2";
            label2.Size = new Size(92, 25);
            label2.TabIndex = 1;
            label2.Text = "Cantidad:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(34, 64);
            label1.Name = "label1";
            label1.Size = new Size(134, 25);
            label1.TabIndex = 0;
            label1.Text = "ISBN / Código:";
            // 
            // dgvCarrito
            // 
            dgvCarrito.BackgroundColor = Color.White;
            dgvCarrito.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarrito.Location = new Point(34, 280);
            dgvCarrito.Margin = new Padding(3, 4, 3, 4);
            dgvCarrito.Name = "dgvCarrito";
            dgvCarrito.RowHeadersWidth = 51;
            dgvCarrito.RowTemplate.Height = 25;
            dgvCarrito.Size = new Size(634, 467);
            dgvCarrito.TabIndex = 2;
            // 
            // panelInferior
            // 
            panelInferior.BackColor = Color.FromArgb(44, 62, 80);
            panelInferior.Controls.Add(btnCancelar);
            panelInferior.Controls.Add(btnPagar);
            panelInferior.Controls.Add(lblTotal);
            panelInferior.Controls.Add(label3);
            panelInferior.Dock = DockStyle.Bottom;
            panelInferior.Location = new Point(0, 774);
            panelInferior.Margin = new Padding(3, 4, 3, 4);
            panelInferior.Name = "panelInferior";
            panelInferior.Size = new Size(1143, 133);
            panelInferior.TabIndex = 3;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(231, 76, 60);
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(743, 33);
            btnCancelar.Margin = new Padding(3, 4, 3, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(160, 67);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "🗑️ Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnPagar
            // 
            btnPagar.BackColor = Color.FromArgb(46, 204, 113);
            btnPagar.FlatAppearance.BorderSize = 0;
            btnPagar.FlatStyle = FlatStyle.Flat;
            btnPagar.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            btnPagar.ForeColor = Color.White;
            btnPagar.Location = new Point(926, 20);
            btnPagar.Margin = new Padding(3, 4, 3, 4);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(183, 93);
            btnPagar.TabIndex = 2;
            btnPagar.Text = "💳 PAGAR";
            btnPagar.UseVisualStyleBackColor = false;
            btnPagar.Click += btnPagar_Click;
            // 
            // lblTotal
            // 
            lblTotal.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            lblTotal.ForeColor = Color.FromArgb(46, 204, 113);
            lblTotal.Location = new Point(229, 27);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(343, 80);
            lblTotal.TabIndex = 1;
            lblTotal.Text = "$0.00";
            lblTotal.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(34, 47);
            label3.Name = "label3";
            label3.Size = new Size(228, 37);
            label3.TabIndex = 0;
            label3.Text = "TOTAL A PAGAR:";
            // 
            // FrmVentasNuevo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 907);
            Controls.Add(panelInferior);
            Controls.Add(dgvCarrito);
            Controls.Add(groupBoxProducto);
            Controls.Add(panelSuperior);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "FrmVentasNuevo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Punto de Venta";
            panelSuperior.ResumeLayout(false);
            panelSuperior.PerformLayout();
            groupBoxProducto.ResumeLayout(false);
            groupBoxProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCarrito).EndInit();
            panelInferior.ResumeLayout(false);
            panelInferior.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelSuperior;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox groupBoxProducto;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvCarrito;
        private System.Windows.Forms.Panel panelInferior;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label3;
    }
}